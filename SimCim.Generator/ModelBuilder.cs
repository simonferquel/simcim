using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Generic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCim.Generator
{
    class ModelBuilder
    {
        private readonly CimSession _cimSession;
        private readonly ModelBuildingOptions _options;
        private readonly string _cimNamespace;

        public ModelBuilder(CimSession cimSession, string cimNamespace, ModelBuildingOptions options)
        {
            _cimSession = cimSession;
            _cimNamespace = cimNamespace;
            _options = options;
        }

        internal void Build()
        {
            var typeDeclMap = new Dictionary<string, CimTypeDeclaration>();
            foreach (var c in _cimSession.EnumerateClasses(_cimNamespace))
            {
                var typeDecl = new CimTypeDeclaration(c);
                typeDeclMap.Add(typeDecl.Name, typeDecl);
            }
            foreach(var association in typeDeclMap.Values.Where(d => d.IsAssociation))
            {
                foreach(var p in association.Properties.Where(prop => prop.Flags.HasFlag(CimFlags.Key)))
                {
                    if(typeDeclMap.TryGetValue(p.ReferenceClassName, out var member))
                    {
                        member.AddAssociation(association, p);
                    }
                }
            }
            foreach(var kvp in typeDeclMap)
            {
                var classBuilder = new ClassBuilder(_options, kvp.Value, typeDeclMap);
                classBuilder.Build();
            }
            BuildFactoryClass(typeDeclMap);
            BuildSimCimScopeExtensions(typeDeclMap);
        }

        private void BuildSimCimScopeExtensions(Dictionary<string, CimTypeDeclaration> typeDeclMap)
        {
            var workspace = new AdhocWorkspace();
            var generator = SyntaxGenerator.GetGenerator(workspace, LanguageNames.CSharp);
            var classDecl = generator.ClassDeclaration("SimCimScopeExtensions",
                accessibility: Accessibility.Public,
                modifiers: DeclarationModifiers.Static);

            var members = new List<SyntaxNode>();

            members.Add(
                SyntaxFactory.MethodDeclaration(SyntaxHelper.IInfrastructureObjectScopeType, "With" + _options.CSharpNamespace.Replace(".", ""))
                    .AddModifiers(SyntaxHelper.Public, SyntaxHelper.Static)
                    .AddParameterListParameters(
                        SyntaxFactory.Parameter(SyntaxFactory.Identifier("scope")).WithType(SyntaxHelper.IInfrastructureObjectScopeType).AddModifiers(SyntaxHelper.This)
                    )
                    .AddBodyStatements(
                        SyntaxFactory.ParseStatement($"scope.Mapper.AddNamespaceMapper(\"{_cimNamespace}\", new InfrastructureObjectMapper(scope));"),
                        SyntaxFactory.ParseStatement("return scope;")
                    )
                );

            foreach (var type in typeDeclMap.Values)
            {
                if (type.IsSingleton)
                {
                    members.Add(
                       SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName(type.CSharpName), "Get" + type.CSharpName)
                           .AddModifiers(SyntaxHelper.Public, SyntaxHelper.Static)
                           .AddParameterListParameters(
                               SyntaxFactory.Parameter(SyntaxFactory.Identifier("scope")).WithType(SyntaxHelper.IInfrastructureObjectScopeType).AddModifiers(SyntaxHelper.This)
                           )
                           .AddBodyStatements(
                               SyntaxFactory.ParseStatement($"return scope.EnumerateInstances<{type.CSharpName}>().Single();")
                           )
                    );
                    members.Add(
                       SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName($"Task<{type.CSharpName}>"), "Get" + type.CSharpName+ "Async")
                           .AddModifiers(SyntaxHelper.Public, SyntaxHelper.Static)
                           .AddParameterListParameters(
                               SyntaxFactory.Parameter(SyntaxFactory.Identifier("scope")).WithType(SyntaxHelper.IInfrastructureObjectScopeType).AddModifiers(SyntaxHelper.This),
                               SyntaxFactory.Parameter(SyntaxFactory.Identifier("options"))
                                .WithType(SyntaxHelper.CimOperationOptionsType)
                                .WithDefault(SyntaxFactory.EqualsValueClause(SyntaxFactory.ParseExpression("null")))
                           )
                           .AddBodyStatements(
                               SyntaxFactory.ParseStatement($"return scope.EnumerateInstancesAsync<{type.CSharpName}>(options).ToTask();")
                           )
                    );
                }
                else if(type.IsEvent(typeDeclMap))
                {
                    members.Add(
                       SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName($"IObservable<BookmarkedEvent<{type.CSharpName}>>"), $"SubscribeTo{type.CSharpName}")
                           .AddModifiers(SyntaxHelper.Public, SyntaxHelper.Static)
                           .AddParameterListParameters(
                               SyntaxFactory.Parameter(SyntaxFactory.Identifier("scope")).WithType(SyntaxHelper.IInfrastructureObjectScopeType).AddModifiers(SyntaxHelper.This),
                               SyntaxFactory.Parameter(SyntaxFactory.Identifier("pollingIntervalSeconds"))
                                .WithType(SyntaxFactory.ParseTypeName("double?"))
                                .WithDefault(SyntaxFactory.EqualsValueClause(SyntaxFactory.ParseExpression("null"))),
                               SyntaxFactory.Parameter(SyntaxFactory.Identifier("wqlFilter"))
                                .WithType(SyntaxFactory.ParseTypeName("string"))
                                .WithDefault(SyntaxFactory.EqualsValueClause(SyntaxFactory.ParseExpression("null"))),
                               SyntaxFactory.Parameter(SyntaxFactory.Identifier("options"))
                                .WithType(SyntaxHelper.CimOperationOptionsType)
                                .WithDefault(SyntaxFactory.EqualsValueClause(SyntaxFactory.ParseExpression("null")))
                           )
                           .AddBodyStatements(
                               SyntaxFactory.ParseStatement($"return scope.SubscribeToEvents<{type.CSharpName}>(pollingIntervalSeconds, wqlFilter, options);")
                           )
                    );

                }
            }

            classDecl = generator.AddMembers(classDecl, members);
            var namespaceDecl = generator.NamespaceDeclaration(_options.CSharpNamespace, classDecl);
            var finalDoc = generator.CompilationUnit(
                generator.NamespaceImportDeclaration("Microsoft.Management.Infrastructure"),
                generator.NamespaceImportDeclaration("Microsoft.Management.Infrastructure.Options"),
                generator.NamespaceImportDeclaration("SimCim.Core"),
                generator.NamespaceImportDeclaration("System"),
                generator.NamespaceImportDeclaration("System.Collections.Generic"),
                generator.NamespaceImportDeclaration("System.Linq"),
                generator.NamespaceImportDeclaration("System.Reactive.Threading.Tasks"),
                generator.NamespaceImportDeclaration("System.Threading.Tasks"),
                namespaceDecl).NormalizeWhitespace();
            File.WriteAllText(Path.Join(_options.OutputDir, "InfrastructureObjectScopeExtensions.cs"), finalDoc.ToFullString(), Encoding.UTF8);
        }

        private void BuildFactoryClass(Dictionary<string, CimTypeDeclaration> typeDeclMap)
        {
            var workspace = new AdhocWorkspace();
            var generator = SyntaxGenerator.GetGenerator(workspace, LanguageNames.CSharp);
            var classDecl = generator.ClassDeclaration("InfrastructureObjectMapper",
                accessibility: Accessibility.Public,
                interfaceTypes: new SyntaxNode[] { SyntaxHelper.IInfrastructureObjectMapperType });
            var members = new List<SyntaxNode>();
            members.Add(SyntaxFactory.FieldDeclaration(
                    SyntaxFactory.VariableDeclaration(SyntaxHelper.IInfrastructureObjectScopeType).AddVariables(SyntaxFactory.VariableDeclarator("_scope"))
                ).AddModifiers(SyntaxFactory.Token(SyntaxKind.PrivateKeyword), SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword)));

            members.Add(SyntaxFactory.ConstructorDeclaration("InfrastructureObjectMapper")
                .AddModifiers(SyntaxHelper.Public)
                .AddParameterListParameters(SyntaxFactory.Parameter(SyntaxFactory.Identifier("scope")).WithType(SyntaxHelper.IInfrastructureObjectScopeType))
                .AddBodyStatements(SyntaxFactory.ParseStatement("_scope = scope;")));

            members.Add(SyntaxFactory.MethodDeclaration(SyntaxHelper.IInfrastructureObjectType, "Create")
                .AddModifiers(SyntaxHelper.Public)
                .AddParameterListParameters(SyntaxFactory.Parameter(SyntaxFactory.Identifier("cimInstance")).WithType(SyntaxFactory.ParseTypeName("CimInstance")))
                .AddBodyStatements(
                    SyntaxFactory.SwitchStatement(SyntaxFactory.ParseExpression("cimInstance.CimSystemProperties.ClassName"))
                        .AddSections(typeDeclMap.Where(kvp => !kvp.Value.IsAbstract).Select(kvp => GenerateSwitchCase(kvp.Value)).ToArray())
                        .AddSections(SyntaxFactory.SwitchSection().AddLabels(SyntaxFactory.DefaultSwitchLabel()).AddStatements(SyntaxFactory.ParseStatement("throw new KeyNotFoundException();")))
                    )
                );

            members.Add(
                SyntaxFactory.FieldDeclaration(
                    SyntaxFactory.VariableDeclaration(SyntaxFactory.ParseTypeName("Dictionary<Type, (string, string)>"))
                        .AddVariables(SyntaxFactory.VariableDeclarator("_typeMap").WithInitializer(
                            SyntaxFactory.EqualsValueClause(
                                SyntaxFactory.ObjectCreationExpression(SyntaxFactory.ParseTypeName("Dictionary<Type, (string, string)>"))
                                .WithInitializer(
                                    SyntaxFactory.InitializerExpression(SyntaxKind.CollectionInitializerExpression)
                                        .AddExpressions(typeDeclMap.Select(kvp => GenerateTypeMapInitializerExpression(kvp.Value)).ToArray())
                                    )
                                )
                            )
                        )
                     )
                    .AddModifiers(SyntaxFactory.Token(SyntaxKind.PrivateKeyword), SyntaxHelper.Static)

                );

            members.Add(
                SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName("(string cimNamespace, string cimClassName)"), "TryResolveType")
                .AddModifiers(SyntaxHelper.Public)
                .AddParameterListParameters(SyntaxFactory.Parameter(SyntaxFactory.Identifier("type")).WithType(SyntaxFactory.ParseTypeName("Type")))
                .AddBodyStatements(SyntaxFactory.ParseStatement(@"if(_typeMap.TryGetValue(type, out var result))
                    {
                        return result;
                    }"), SyntaxFactory.ParseStatement("return (null, null);")
                    )
                );

            classDecl = generator.AddMembers(classDecl, members);
            var namespaceDecl = generator.NamespaceDeclaration(_options.CSharpNamespace, classDecl);
            var finalDoc = generator.CompilationUnit(
                generator.NamespaceImportDeclaration("Microsoft.Management.Infrastructure"),
                generator.NamespaceImportDeclaration("System"),
                generator.NamespaceImportDeclaration("System.Collections.Generic"),
                generator.NamespaceImportDeclaration("SimCim.Core"),
                namespaceDecl).NormalizeWhitespace();
            File.WriteAllText(Path.Join(_options.OutputDir, "InfrastructureObjectMapper.cs"), finalDoc.ToFullString(), Encoding.UTF8);
        }

        private ExpressionSyntax GenerateTypeMapInitializerExpression(CimTypeDeclaration value)
        {
            return SyntaxFactory.ParseExpression($"{{ typeof({value.CSharpName}), (\"{_cimNamespace}\", \"{value.Name}\")}}");
        }

        private SwitchSectionSyntax GenerateSwitchCase(CimTypeDeclaration value)
        {
            return SyntaxFactory.SwitchSection()
                .AddLabels(SyntaxFactory.CaseSwitchLabel(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(value.Name))))
                .AddStatements(SyntaxFactory.ParseStatement($"return new {value.CSharpName}(_scope, cimInstance);"));
        }

        private string PrintQualifiers(CimReadOnlyKeyedCollection<CimQualifier> qualifiers)
        {
            var sb = new StringBuilder();
            bool isFirst = true;
            foreach (var q in qualifiers)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    sb.Append(", ");
                }
                sb.Append($"{q.Name} = {PrintValue(q.Value)}");
            }
            return sb.ToString();
        }
        private string PrintValue(object v)
        {
            switch (v)
            {
                case string[] a:
                    return string.Join(", ", a);
                default:
                    return v.ToString();
            }
        }
    }

}
