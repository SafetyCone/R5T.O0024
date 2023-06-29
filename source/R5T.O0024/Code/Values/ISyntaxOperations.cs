using System;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0131;
using R5T.T0161.N1;

using R5T.L0048.F000.Extensions;


namespace R5T.O0024
{
    [ValuesMarker]
    public partial interface ISyntaxOperations : IValuesMarker
    {
        public async Task<MethodDeclarationSyntax> Get_MethodOnType(
            Project project,
            ITypeName typeName,
            IMethodName methodName)
        {
            var type = await Instances.ProjectOperator.Get_AllSyntaxNodesOfType<TypeDeclarationSyntax>(project)
                    .Where(type => type.Is_Named(typeName))
                    .FirstAsync();

            var method = type.DescendantNodes()
                .OfType<MethodDeclarationSyntax>()
                .Where(method => method.Is_Named(methodName))
                .First();

            return method;
        }
    }
}
