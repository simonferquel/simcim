using CaseExtensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace SimCim.Generator
{
    class ClassBuilder
    {
        private readonly ModelBuildingOptions _options;
        private readonly CimTypeDeclaration _declaration;
        private readonly IDictionary<string, CimTypeDeclaration> _typeRepository;

        public ClassBuilder(ModelBuildingOptions options, CimTypeDeclaration declaration, IDictionary<string, CimTypeDeclaration> typeRepository)
        {
            _options = options;
            _declaration = declaration;
            _typeRepository = typeRepository;
        }

        public void Build()
        {
            var _ = typeof(Microsoft.CodeAnalysis.CSharp.Formatting.CSharpFormattingOptions);
            var workspace = new AdhocWorkspace();
            var generator = SyntaxGenerator.GetGenerator(workspace, LanguageNames.CSharp);

            SyntaxNode baseType = SyntaxHelper.GenericInfrastructureObjectType;
            var parent = _declaration.GetParent(_typeRepository);
            if (parent != null)
            {
                baseType = generator.IdentifierName(parent.CSharpName);
            }

            var classDecl = generator.ClassDeclaration(_declaration.CSharpName,
                accessibility: Accessibility.Public,
                modifiers: _declaration.IsAbstract ? DeclarationModifiers.Abstract : DeclarationModifiers.None,
                baseType: baseType);
            var members = new List<SyntaxNode>();

            var defaultConstructor = SyntaxFactory.ConstructorDeclaration(_declaration.CSharpName)
                .WithBody(SyntaxFactory.Block());

            var connectConstructor = SyntaxFactory.ConstructorDeclaration(_declaration.CSharpName)
               .WithParameterList(SyntaxFactory.ParameterList().AddParameters(
                    SyntaxFactory.Parameter(SyntaxFactory.Identifier("scope")).WithType(SyntaxHelper.IInfrastructureObjectScopeType),
                    SyntaxFactory.Parameter(SyntaxFactory.Identifier("instance")).WithType(SyntaxFactory.ParseTypeName("CimInstance"))))
               .WithInitializer(
                    SyntaxFactory.ConstructorInitializer(SyntaxKind.BaseConstructorInitializer).AddArgumentListArguments(
                        SyntaxFactory.Argument(SyntaxFactory.IdentifierName("scope")),
                        SyntaxFactory.Argument(SyntaxFactory.IdentifierName("instance"))))
                .WithBody(SyntaxFactory.Block());
            if (_declaration.IsAbstract)
            {
                defaultConstructor = defaultConstructor.WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.ProtectedKeyword)));
                connectConstructor = connectConstructor.WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.ProtectedKeyword)));
            }
            else
            {
                defaultConstructor = defaultConstructor.WithModifiers(SyntaxFactory.TokenList(SyntaxHelper.Public));
                connectConstructor = connectConstructor.WithModifiers(SyntaxFactory.TokenList(SyntaxHelper.Public));
            }
            members.Add(defaultConstructor);
            members.Add(connectConstructor);

            members.AddRange(Properties());
            members.AddRange(Methods());

            classDecl = generator.AddMembers(classDecl, members);

            var namespaceDecl = generator.NamespaceDeclaration(_options.CSharpNamespace, classDecl);


            var finalDoc = generator.CompilationUnit(
                generator.NamespaceImportDeclaration("Microsoft.Management.Infrastructure"),
                generator.NamespaceImportDeclaration("System"),
                generator.NamespaceImportDeclaration("System.Collections.Generic"),
                generator.NamespaceImportDeclaration("System.Linq"),
                generator.NamespaceImportDeclaration("SimCim.Core"),
                namespaceDecl).NormalizeWhitespace();
            File.WriteAllText(Path.Join(_options.OutputDir, "Class"+_declaration.CSharpName + ".cs"), finalDoc.ToFullString(), Encoding.UTF8);
        }

        //private IEnumerable<SyntaxNode> Associations()
        //{
        //    foreach (var association in _declaration.Associations)
        //    {
        //        var otherSide = association.AssociationType.Properties.Where(p => p.Name != association.ThisSideOfAssociation.Name && p.IsKey()).Single();

        //        var returnType = otherSide.ResolveType(_typeRepository, out var returnTypeIsCimObject);
        //        var scalarReturnType = returnType;
        //        if (association.ThisSideOfAssociation.IsAggegate(association.AssociationType.CimClass))
        //        {
        //            returnType = SyntaxFactory.ParseTypeName($"IEnumerable<{returnType}>");
        //        }
        //        yield return SyntaxFactory.MethodDeclaration(returnType, "Resolve" + association.AssociationType.CSharpName + otherSide.Name.ToPascalCase())
        //            .AddModifiers(SyntaxHelper.Public)
        //            .WithBody(SyntaxHelper.ParseBlock(
        //                $"var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances(\"{_options.CimNamespace}\", InnerCimInstance, \"{association.AssociationType.Name}\", \"{otherSide.ReferenceClassName}\", \"{association.ThisSideOfAssociation.Name}\", \"{otherSide.Name}\");",
        //                $"return instances{(returnTypeIsCimObject ? $".Select(i=>({scalarReturnType})InfrastuctureObjectScope.Mapper.Create(i))" : string.Empty)}{(!association.ThisSideOfAssociation.IsAggegate(association.AssociationType.CimClass) ? ".SingleOrDefault()" : string.Empty)};"
        //                )
        //            );
                    
        //    }
        //}

        private IEnumerable<SyntaxNode> Methods()
        {
            var parent = _declaration.GetParent(_typeRepository);
            foreach (var m in _declaration.Methods)
            {
                var analysis = m.Analyze(_typeRepository);
                if (parent != null)
                {
                    var parentMethodAnalysis = parent.Methods.Where(parentMethod => m.Name == parentMethod.Name).FirstOrDefault()?.Analyze(_typeRepository);
                    if (parentMethodAnalysis.HasValue && parentMethodAnalysis.Value.Match(analysis))
                    {
                        continue;
                    }
                }
                var returnType = analysis.OutputParameters.Length == 0 ? analysis.ReturnType :
                    SyntaxFactory.ParseTypeName($"({analysis.ReturnType} retval, {string.Join(", ", analysis.OutputParameters.Select(p => $"{p.Type} out{p.Name}"))})");
                var decl = SyntaxFactory.MethodDeclaration(returnType, m.Name)
                    .AddModifiers(SyntaxHelper.Public)
                    .AddParameterListParameters(analysis.InputParameters.Select(p =>
                        SyntaxFactory.Parameter(SyntaxFactory.Identifier("in" + p.Name)).WithType(p.Type)
                    ).ToArray())
                    .AddBodyStatements(
                        SyntaxFactory.ParseStatement("var parameters = new CimMethodParametersCollection();")
                    )
                    .AddBodyStatements(
                        analysis.InputParameters.SelectMany(p => FillInputParametersStatements(p)).ToArray()
                    )
                    .AddBodyStatements(
                        SyntaxFactory.ParseStatement($"var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, \"{m.Name}\", parameters);")
                    )
                    .AddBodyStatements(
                        analysis.OutputParameters.Length == 0 ? new StatementSyntax[] { SyntaxFactory.ParseStatement($"return ({returnType}) result.ReturnValue.Value;") } :
                        new StatementSyntax[]
                        {
                            SyntaxFactory.ReturnStatement(SyntaxFactory.TupleExpression()
                            .AddArguments(SyntaxFactory.Argument(SyntaxFactory.ParseExpression($"({analysis.ReturnType}) result.ReturnValue.Value")))
                            .AddArguments(analysis.OutputParameters.Select(p=>ReturnStatementSyntax(p)).ToArray())
                            )
                        }
                    );
                if (parent != null && (parent.SymbolNames(_typeRepository).Contains(m.Name.ToPascalCase())))
                {
                    decl = decl.AddModifiers(SyntaxHelper.New);
                }
                yield return decl;
            }
        }

        private ArgumentSyntax ReturnStatementSyntax(CimPropertyDeclarationExtensions.NameAndType p)
        {
            if (p.IsCimObject)
            {
                return SyntaxFactory.Argument(SyntaxFactory.ParseExpression($"({p.Type}) InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance) result.OutParameters[\"{p.Name}\"].Value)"));
            }
            else
            {
                return SyntaxFactory.Argument(SyntaxFactory.ParseExpression($"({p.Type}) result.OutParameters[\"{p.Name}\"].Value"));
            }
        }

        private IEnumerable<StatementSyntax> FillInputParametersStatements(CimPropertyDeclarationExtensions.NameAndType p)
        {
            if (p.IsNullableValueType)
            {
                yield return SyntaxFactory.IfStatement(SyntaxFactory.ParseExpression($"in{p.Name}.HasValue"),
                    SyntaxFactory.ParseStatement($"parameters.Add(CimMethodParameter.Create(\"{p.Name}\", in{p.Name}.Value, CimFlags.None));"));
            }
            else if (p.IsCimObject)
            {
                yield return SyntaxFactory.ParseStatement($"if (in{p.Name} != null) parameters.Add(CimMethodParameter.Create(\"{p.Name}\", in{p.Name}.AsCimInstance(), CimType.{p.CimType} , in{p.Name} == null? CimFlags.NullValue : CimFlags.None));");
            }
            else
            {
                yield return SyntaxFactory.ParseStatement($"if (in{p.Name} != null) parameters.Add(CimMethodParameter.Create(\"{p.Name}\", in{p.Name}, CimType.{p.CimType}, in{p.Name} == null? CimFlags.NullValue : CimFlags.None));");
            }
        }

        private IEnumerable<SyntaxNode> Properties()
        {
            var parent = _declaration.GetParent(_typeRepository);
            foreach (var p in _declaration.Properties)
            {
                if (parent != null && parent.HasPropertyWithSameType(p, _typeRepository))
                {
                    continue;
                }
                var t = p.ResolveType(_typeRepository, out var isCimObject);
                var prop = SyntaxFactory.PropertyDeclaration(t, p.Name.ToPascalCase())
                    .AddModifiers(SyntaxHelper.Public)
                    .AddAccessorListAccessors(
                        SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration,
                        SyntaxHelper.ParseBlock(
                            $"{t.ToString()} result;",
                            $"this.{(isCimObject ? "GetInfrastructureObjectProperty" : "GetProperty")}(\"{p.Name}\", out result);",
                            "return result;")
                        )
                    );
                if (!p.IsReadOnly())
                {
                    prop = prop.AddAccessorListAccessors(
                        SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration,
                            SyntaxHelper.ParseBlock($"this.SetProperty(\"{p.Name}\", value);")
                        )
                    );
                }
                if (parent != null && (parent.SymbolNames(_typeRepository).Contains(p.Name.ToPascalCase())))
                {
                    prop = prop.AddModifiers(SyntaxHelper.New);
                }
                yield return prop;
            }
        }
    }

    static class CimPropertyDeclarationExtensions
    {
        public static bool IsReadOnly(this CimPropertyDeclaration p)
        {
            return (p.Flags & CimFlags.ReadOnly) == CimFlags.ReadOnly;
        }
        public static bool IsKey(this CimPropertyDeclaration p)
        {
            return (p.Flags & CimFlags.Key) == CimFlags.Key;
        }

        public static bool IsReference(this CimPropertyDeclaration p)
        {
            return p.CimType == CimType.Reference;
        }

        public static bool IsNotNull(this CimReadOnlyKeyedCollection<CimQualifier> qs)
        {
            return qs["KEY"] != null || qs["INDEXED"] != null || qs["NOT_NULL"] != null;            
        }

        public static bool IsAggegate(this CimPropertyDeclaration p, CimClass associationClass)
        {
            var q = p.Qualifiers["Aggregate"];
            if (q != null)
            {
                return true;
            }

            return associationClass.CimClassQualifiers["Aggregation"] != null;
        }

        public static TypeSyntax ResolveType(this CimPropertyDeclaration p, IDictionary<string, CimTypeDeclaration> typeRepo, out bool isCimObject)
        {
            return ResolveType(p.CimType, p.ReferenceClassName, p.Qualifiers.IsNotNull(), typeRepo, out isCimObject, out var _);
        }

        private static TypeSyntax ResolveType(CimType cimType, string referenceClassName, bool isNotNull, IDictionary<string, CimTypeDeclaration> typeRepo, out bool isCimObject, out bool isNullableValueType)
        {
            isCimObject = false;
            isNullableValueType = false;
            switch (cimType)
            {
                case Microsoft.Management.Infrastructure.CimType.Instance:
                case Microsoft.Management.Infrastructure.CimType.Reference:
                    if (referenceClassName != null)
                    {
                        return SyntaxFactory.ParseTypeName(typeRepo.CSharpNameOrCimInstance(referenceClassName, out isCimObject));
                    }
                    return SyntaxFactory.ParseTypeName("CimInstance");
                case Microsoft.Management.Infrastructure.CimType.InstanceArray:
                case Microsoft.Management.Infrastructure.CimType.ReferenceArray:
                    if (referenceClassName != null)
                    {
                        return SyntaxFactory.ParseTypeName($"IEnumerable<{typeRepo.CSharpNameOrCimInstance(referenceClassName, out isCimObject)}>");
                    }
                    return SyntaxFactory.ParseTypeName("IEnumerable<CimInstance>");
                default:
                    var type = CimConverter.GetDotNetType(cimType);
                    if (cimType == CimType.DateTime)
                    {
                        type = typeof(DateTime);
                    }
                    if (cimType == CimType.DateTimeArray)
                    {
                        type = typeof(DateTime[]);
                    }
                    if (type.IsValueType && !isNotNull)
                    {
                        isNullableValueType = true;
                        return SyntaxFactory.ParseTypeName(type.FullName + "?");
                    }
                    return SyntaxFactory.ParseTypeName(type.FullName);
            }
        }

        public static string CSharpNameOrCimInstance(this IDictionary<string, CimTypeDeclaration> typeRepo, string cimName, out bool isCimObject)
        {
            if (typeRepo.TryGetValue(cimName, out var d))
            {
                isCimObject = true;
                return d.CSharpName;
            }
            isCimObject = false;
            return "CimInstance";
        }

        public struct NameAndType
        {
            public string Name { get; set; }
            public TypeSyntax Type { get; set; }
            public bool IsCimObject { get; set; }
            public bool IsNullableValueType { get; set; }
            public bool Match(NameAndType other)
            {
                return Name == other.Name && IsCimObject == other.IsCimObject && Type.ToString() == other.Type.ToString();
            }

            public CimType CimType { get; set; }
        }

        struct NamedAndTypeComparer : IEqualityComparer<NameAndType>
        {
            public bool Equals([AllowNull] NameAndType x, [AllowNull] NameAndType y) => x.Match(y);
            public int GetHashCode([DisallowNull] NameAndType obj) => obj.GetHashCode();
        }

        public struct MethodAnalysis
        {
            public TypeSyntax ReturnType { get; set; }
            public NameAndType[] InputParameters { get; set; }
            public NameAndType[] OutputParameters { get; set; }

            public bool Match(MethodAnalysis other)
            {
                return ReturnType.ToString() == other.ReturnType.ToString()
                    && Enumerable.SequenceEqual(InputParameters, other.InputParameters, new NamedAndTypeComparer())
                    && Enumerable.SequenceEqual(OutputParameters, other.OutputParameters, new NamedAndTypeComparer());
            }

        }

        static bool IsIn(CimMethodParameterDeclaration p)
        {
            var q = p.Qualifiers["In"];
            return q != null;
        }
        static bool IsOut(CimMethodParameterDeclaration p)
        {
            var q = p.Qualifiers["Out"];
            return q != null;
        }

        public static MethodAnalysis Analyze(this CimMethodDeclaration d, IDictionary<string, CimTypeDeclaration> typeRepo)
        {
            TypeSyntax returnType;
            var dotnetReturnType = CimConverter.GetDotNetType(d.ReturnType);
            if (d.ReturnType == CimType.DateTime)
            {
                dotnetReturnType = typeof(DateTime);
            }
            if (d.ReturnType == CimType.DateTimeArray)
            {
                dotnetReturnType = typeof(DateTime[]);
            }
            if (dotnetReturnType == null)
            {
                returnType = SyntaxFactory.ParseTypeName("void");
            }
            else
            {
                returnType = SyntaxFactory.ParseTypeName(dotnetReturnType.FullName);
            }
            var inputParameters = new List<NameAndType>();
            var outputParameters = new List<NameAndType>();
            foreach (var p in d.Parameters)
            {
                var type = ResolveType(p.CimType, p.ReferenceClassName ?? p.Qualifiers["EmbeddedInstance"]?.Value as string, p.Qualifiers.IsNotNull(), typeRepo, out var isCimObject, out var isNullableValueType);
                var entry = new NameAndType
                {
                    IsCimObject = isCimObject,
                    Name = p.Name,
                    Type = type,
                    IsNullableValueType = isNullableValueType,
                    CimType = p.CimType,
                };
                if (IsIn(p))
                {
                    inputParameters.Add(entry);
                }
                if (IsOut(p))
                {
                    outputParameters.Add(entry);
                }
            }
            return new MethodAnalysis
            {
                ReturnType = returnType,
                InputParameters = inputParameters.ToArray(),
                OutputParameters = outputParameters.ToArray()
            };
        }
    }
}
