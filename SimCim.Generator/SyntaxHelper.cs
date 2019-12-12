using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCim.Generator
{
    static class SyntaxHelper
    {
        public static TypeSyntax IInfrastructureObjectScopeType { get; } = SyntaxFactory.ParseTypeName("IInfrastructureObjectScope");
        public static TypeSyntax IInfrastructureObjectType { get; } = SyntaxFactory.ParseTypeName("IInfrastructureObject");
        public static TypeSyntax GenericInfrastructureObjectType { get; } = SyntaxFactory.ParseTypeName("GenericInfrastructureObject");
        public static TypeSyntax IInfrastructureObjectMapperType { get; } = SyntaxFactory.ParseTypeName("IInfrastructureObjectMapper");
        public static SyntaxToken New { get; } = SyntaxFactory.Token(SyntaxKind.NewKeyword);
        public static BlockSyntax ParseBlock(params string[] statements) => SyntaxFactory.Block(statements.Select(s => SyntaxFactory.ParseStatement(s)));
        public static SyntaxToken Public { get; } = SyntaxFactory.Token(SyntaxKind.PublicKeyword);
        public static SyntaxToken Static { get; } = SyntaxFactory.Token(SyntaxKind.StaticKeyword);
        public static SyntaxToken This { get; } = SyntaxFactory.Token(SyntaxKind.ThisKeyword);
        public static SyntaxToken Async { get; } = SyntaxFactory.Token(SyntaxKind.AsyncKeyword);
        public static TypeSyntax CimOperationOptionsType { get; } = SyntaxFactory.ParseTypeName("CimOperationOptions");
    }
}
