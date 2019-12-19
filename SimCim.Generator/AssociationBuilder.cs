using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SimCim.Generator
{
    internal class AssociationBuilder
    {
        private readonly ModelBuildingOptions _options;
        private readonly CimTypeDeclaration _declaration;
        private readonly IDictionary<string, CimTypeDeclaration> _typeRepository;
        private CimPropertyDeclaration _sourceProperty;
        private CimPropertyDeclaration _targetProperty;

        internal AssociationBuilder(ModelBuildingOptions options, CimTypeDeclaration declaration, IDictionary<string, CimTypeDeclaration> typeRepository)
        {
            _options = options;
            _declaration = declaration;
            _typeRepository = typeRepository;

            var keyProperties = declaration.Properties.Where(p => p.IsKey()).ToList();
            if(keyProperties.Count == 0 )
            {
                keyProperties = declaration.Properties.Where(p=>p.IsReference()).ToList();
            }
            if(keyProperties.Count != 2)
            {
                throw new NotSupportedException($"{_declaration.Name} association type should have 2 key properties. Got {keyProperties.Count}");
            }
            _sourceProperty = keyProperties[0];
            _targetProperty = keyProperties[1];
        }

        public void Build()
        {
            var workspace = new AdhocWorkspace();
            var generator = SyntaxGenerator.GetGenerator(workspace, LanguageNames.CSharp);            

            var classDecl = generator.StructDeclaration(_declaration.CSharpName+"Association",
                accessibility: Accessibility.Public);
            var members = new List<SyntaxNode>();

            members.Add(SyntaxFactory.FieldDeclaration(SyntaxFactory.VariableDeclaration(SyntaxHelper.AssociationResolverType))
                .AddDeclarationVariables(SyntaxFactory.VariableDeclarator("_resolver").WithInitializer(
                        SyntaxFactory.EqualsValueClause(SyntaxFactory.ParseExpression(
                            $"new AssociationResolver(\"{_declaration.Name}\", \"{_sourceProperty.ReferenceClassName}\", \"{_targetProperty.ReferenceClassName}\", \"{_sourceProperty.Name}\", \"{_targetProperty.Name}\")"))
                    ))
                .AddModifiers(SyntaxHelper.Private, SyntaxHelper.Static));

            members.Add(SyntaxFactory.FieldDeclaration(SyntaxFactory.VariableDeclaration(SyntaxHelper.IInfrastructureObjectScopeType))
                .AddDeclarationVariables(SyntaxFactory.VariableDeclarator("_scope"))
                .AddModifiers(SyntaxHelper.Private));

            members.Add(SyntaxFactory.ConstructorDeclaration(_declaration.CSharpName + "Association")
                .AddModifiers(SyntaxHelper.Public)
                .AddParameterListParameters(
                    SyntaxFactory.Parameter(SyntaxFactory.Identifier("scope")).WithType(SyntaxHelper.IInfrastructureObjectScopeType)
                    )
                .WithBody(SyntaxHelper.ParseBlock("_scope = scope;"))
                );

            var targetReturnType = _targetProperty.ResolveType(_typeRepository, out var targetIsCimObject);
            var sourceReturnType = _sourceProperty.ResolveType(_typeRepository, out var sourceIsCimObject);

            members.Add(SyntaxFactory.MethodDeclaration(SyntaxHelper.EnumerableOf(targetReturnType), _targetProperty.Name)
                .AddModifiers(SyntaxHelper.Public)
                .AddParameterListParameters(
                    SyntaxFactory.Parameter(SyntaxFactory.Identifier("in" + _sourceProperty.Name)).WithType(sourceReturnType),
                    SyntaxFactory.Parameter(SyntaxFactory.Identifier("options")).WithType(SyntaxHelper.CimOperationOptionsType)
                    .WithDefault(
                        SyntaxFactory.EqualsValueClause(SyntaxFactory.ParseExpression("null"))
                    )
                )
                .WithBody(SyntaxHelper.ParseBlock(
                    "var scope = _scope;",
                    $"var instances = _resolver.ResolveTarget(scope, in{_sourceProperty.Name}{(sourceIsCimObject ? ".AsCimInstance()" : string.Empty)}, options);",
                    targetIsCimObject ? $"return instances.Select(i => ({targetReturnType})scope.Mapper.Create(scope, i));" : "return instances;"
                    )
                ));

            members.Add(SyntaxFactory.MethodDeclaration(SyntaxHelper.EnumerableOf(sourceReturnType), _sourceProperty.Name)
                .AddModifiers(SyntaxHelper.Public)
                .AddParameterListParameters(
                    SyntaxFactory.Parameter(SyntaxFactory.Identifier("in" + _targetProperty.Name)).WithType(targetReturnType),
                    SyntaxFactory.Parameter(SyntaxFactory.Identifier("options")).WithType(SyntaxHelper.CimOperationOptionsType)
                    .WithDefault(
                        SyntaxFactory.EqualsValueClause(SyntaxFactory.ParseExpression("null"))
                    )
                )
                .WithBody(SyntaxHelper.ParseBlock(
                    "var scope = _scope;",
                    $"var instances = _resolver.ResolveSource(scope, in{_targetProperty.Name}{(targetIsCimObject ? ".AsCimInstance()" : string.Empty)}, options);",
                    sourceIsCimObject ? $"return instances.Select(i => ({sourceReturnType})scope.Mapper.Create(scope, i));" : "return instances;"
                    )
                ));


            members.Add(SyntaxFactory.MethodDeclaration(SyntaxHelper.ObservableOf(targetReturnType), _targetProperty.Name+ "Async")
                .AddModifiers(SyntaxHelper.Public)
                .AddParameterListParameters(
                    SyntaxFactory.Parameter(SyntaxFactory.Identifier("in" + _sourceProperty.Name)).WithType(sourceReturnType),
                    SyntaxFactory.Parameter(SyntaxFactory.Identifier("options")).WithType(SyntaxHelper.CimOperationOptionsType)
                    .WithDefault(
                        SyntaxFactory.EqualsValueClause(SyntaxFactory.ParseExpression("null"))
                    )
                )
                .WithBody(SyntaxHelper.ParseBlock(
                    "var scope = _scope;",
                    $"var instances = _resolver.ResolveTargetAsync(scope, in{_sourceProperty.Name}{(sourceIsCimObject ? ".AsCimInstance()" : string.Empty)}, options);",
                    targetIsCimObject ? $"return instances.Select(i => ({targetReturnType})scope.Mapper.Create(scope, i));" : "return instances;"
                    )
                ));

            members.Add(SyntaxFactory.MethodDeclaration(SyntaxHelper.ObservableOf(sourceReturnType), _sourceProperty.Name + "Async")
                .AddModifiers(SyntaxHelper.Public)
                .AddParameterListParameters(
                    SyntaxFactory.Parameter(SyntaxFactory.Identifier("in" + _targetProperty.Name)).WithType(targetReturnType),
                    SyntaxFactory.Parameter(SyntaxFactory.Identifier("options")).WithType(SyntaxHelper.CimOperationOptionsType)
                    .WithDefault(
                        SyntaxFactory.EqualsValueClause(SyntaxFactory.ParseExpression("null"))
                    )
                )
                .WithBody(SyntaxHelper.ParseBlock(
                    "var scope = _scope;",
                    $"var instances = _resolver.ResolveSourceAsync(scope, in{_targetProperty.Name}{(targetIsCimObject ? ".AsCimInstance()" : string.Empty)}, options);",
                    sourceIsCimObject ? $"return instances.Select(i => ({sourceReturnType})scope.Mapper.Create(scope, i));" : "return instances;"
                    )
                ));


            classDecl = generator.AddMembers(classDecl, members);

            var namespaceDecl = generator.NamespaceDeclaration(_options.CSharpNamespace, classDecl);


            var finalDoc = generator.CompilationUnit(
                generator.NamespaceImportDeclaration("Microsoft.Management.Infrastructure"),
                generator.NamespaceImportDeclaration("Microsoft.Management.Infrastructure.Options"),            
                generator.NamespaceImportDeclaration("SimCim.Core"),
                generator.NamespaceImportDeclaration("System"),
                generator.NamespaceImportDeclaration("System.Collections.Generic"),
                generator.NamespaceImportDeclaration("System.Linq"),
                generator.NamespaceImportDeclaration("System.Reactive.Linq"),
                namespaceDecl).NormalizeWhitespace();
            File.WriteAllText(Path.Join(_options.OutputDir, "Association"+_declaration.CSharpName + ".cs"), finalDoc.ToFullString(), Encoding.UTF8);
        }
    }
}
