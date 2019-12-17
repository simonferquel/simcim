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

            var toRemove = new List<string>();
            foreach (var kvp in typeDeclMap)
            {
                if (kvp.Value.IsAssociation)
                {
                    if (!kvp.Value.IsAbstract)
                    {
                        try
                        {
                            var associationBuilder = new AssociationBuilder(_options, kvp.Value, typeDeclMap);
                            associationBuilder.Build();
                        }
                        catch (Exception ex)
                        {
                            _options.Error.WriteLine(ex.Message);
                        }
                    }
                }

                var classBuilder = new ClassBuilder(_options, kvp.Value, typeDeclMap);
                classBuilder.Build();
            }
            foreach (var r in toRemove)
            {
                typeDeclMap.Remove(r);
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

            members.Add(SyntaxFactory.StructDeclaration("AllAssociations")
                .AddModifiers(SyntaxHelper.Public)
                .AddMembers(
                    SyntaxFactory.FieldDeclaration(SyntaxFactory.VariableDeclaration(SyntaxHelper.IInfrastructureObjectScopeType))
                        .AddDeclarationVariables(SyntaxFactory.VariableDeclarator("_scope"))
                        .AddModifiers(SyntaxHelper.Private),
                    SyntaxFactory.ConstructorDeclaration("AllAssociations")
                        .AddModifiers(SyntaxHelper.Public)
                        .AddParameterListParameters(
                            SyntaxFactory.Parameter(SyntaxFactory.Identifier("scope")).WithType(SyntaxHelper.IInfrastructureObjectScopeType)
                            )
                        .WithBody(SyntaxHelper.ParseBlock("_scope = scope;")
                    )
                )
                .AddMembers(
                    typeDeclMap.Values.Where(v => v.IsAssociation && !v.IsAbstract)
                    .Select(a => SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName(a.CSharpName + "Association"), a.CSharpName)
                        .AddModifiers(SyntaxHelper.Public)
                        .WithExpressionBody(SyntaxFactory.ArrowExpressionClause(SyntaxFactory.ParseExpression($"new {a.CSharpName}Association(_scope)")))
                        .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)))
                    .Cast<MemberDeclarationSyntax>().ToArray()
                )
            );

            members.Add(
                       SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName("AllAssociations"), "Associations")
                           .AddModifiers(SyntaxHelper.Public, SyntaxHelper.Static)
                           .AddParameterListParameters(
                               SyntaxFactory.Parameter(SyntaxFactory.Identifier("scope")).WithType(SyntaxHelper.IInfrastructureObjectScopeType).AddModifiers(SyntaxHelper.This)
                           )
                           .AddBodyStatements(
                               SyntaxFactory.ParseStatement($"return new AllAssociations(scope);")
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
                       SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName($"Task<{type.CSharpName}>"), "Get" + type.CSharpName + "Async")
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
                else if (type.IsEvent(typeDeclMap))
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

            members.Add(SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName("string"), "CimNamespace").WithExpressionBody(
                SyntaxFactory.ArrowExpressionClause(SyntaxFactory.ParseExpression($"\"{_options.CimNamespace}\"")))
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                .AddModifiers(SyntaxHelper.Public));

            members.Add(SyntaxFactory.MethodDeclaration(SyntaxHelper.IInfrastructureObjectType, "Create")
                .AddModifiers(SyntaxHelper.Public)
                .AddParameterListParameters(SyntaxFactory.Parameter(SyntaxFactory.Identifier("scope")).WithType(SyntaxHelper.IInfrastructureObjectScopeType))
                .AddParameterListParameters(SyntaxFactory.Parameter(SyntaxFactory.Identifier("cimInstance")).WithType(SyntaxFactory.ParseTypeName("CimInstance")))
                .AddBodyStatements(
                    SyntaxFactory.ParseStatement("if(cimInstance == null){ return null; }"),
                    SyntaxFactory.SwitchStatement(SyntaxFactory.ParseExpression("cimInstance.CimSystemProperties.ClassName"))
                        .AddSections(typeDeclMap.Where(kvp => !kvp.Value.IsAbstract && !kvp.Value.IsAssociation).Select(kvp => GenerateSwitchCase(kvp.Value)).ToArray())
                        .AddSections(SyntaxFactory.SwitchSection().AddLabels(SyntaxFactory.DefaultSwitchLabel()).AddStatements(SyntaxFactory.ParseStatement("throw new KeyNotFoundException();")))
                    )
                );

            members.Add(
                SyntaxFactory.FieldDeclaration(
                    SyntaxFactory.VariableDeclaration(SyntaxFactory.ParseTypeName("Dictionary<Type, string>"))
                        .AddVariables(SyntaxFactory.VariableDeclarator("_typeMap").WithInitializer(
                            SyntaxFactory.EqualsValueClause(
                                SyntaxFactory.ObjectCreationExpression(SyntaxFactory.ParseTypeName("Dictionary<Type, string>"))
                                .WithInitializer(
                                    SyntaxFactory.InitializerExpression(SyntaxKind.CollectionInitializerExpression)
                                        .AddExpressions(typeDeclMap.Where(kvp => !kvp.Value.IsAssociation).Select(kvp => GenerateTypeMapInitializerExpression(kvp.Value)).ToArray())
                                    )
                                )
                            )
                        )
                     )
                    .AddModifiers(SyntaxFactory.Token(SyntaxKind.PrivateKeyword), SyntaxHelper.Static)

                );

            members.Add(
                SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName("string"), "TryResolveType")
                .AddModifiers(SyntaxHelper.Public)
                .AddParameterListParameters(SyntaxFactory.Parameter(SyntaxFactory.Identifier("type")).WithType(SyntaxFactory.ParseTypeName("Type")))
                .AddBodyStatements(SyntaxFactory.ParseStatement(@"if(_typeMap.TryGetValue(type, out var result))
                    {
                        return result;
                    }"), SyntaxFactory.ParseStatement("return null;")
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
            return SyntaxFactory.ParseExpression($"{{ typeof({value.CSharpName}), \"{value.Name}\"}}");
        }

        private SwitchSectionSyntax GenerateSwitchCase(CimTypeDeclaration value)
        {
            return SyntaxFactory.SwitchSection()
                .AddLabels(SyntaxFactory.CaseSwitchLabel(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(value.Name))))
                .AddStatements(SyntaxFactory.ParseStatement($"return new {value.CSharpName}(scope, cimInstance);"));
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
