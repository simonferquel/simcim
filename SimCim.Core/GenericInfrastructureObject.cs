using Microsoft.Management.Infrastructure;

namespace SimCim.Core
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1063:Implement IDisposable Correctly", Justification = "By design, inheriting objects must not override Dispose mechanism")]
    public class GenericInfrastructureObject : IInfrastructureObject
    {
        public GenericInfrastructureObject() { }
        public GenericInfrastructureObject(IInfrastructureObjectScope scope, CimInstance instance)
        {
            InfrastuctureObjectScope = scope;
            InnerCimInstance = instance;
        }
        public void Connect(IInfrastructureObjectScope scope, CimInstance instance)
        {
            InfrastuctureObjectScope = scope;
            // dispose previous instance
            InnerCimInstance?.Dispose();
            InnerCimInstance = instance;
        }

        public IInfrastructureObjectScope InfrastuctureObjectScope { get; private set; }
        public CimInstance InnerCimInstance { get; private set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA1816:Dispose methods should call SuppressFinalize", Justification = "Only dispose managed object")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1063:Implement IDisposable Correctly", Justification = "Only dispose wrapped managed object")]
        public void Dispose() => InnerCimInstance?.Dispose();
    }
}
