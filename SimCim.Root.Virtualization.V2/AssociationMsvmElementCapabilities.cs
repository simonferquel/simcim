using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmElementCapabilitiesAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_ElementCapabilities", "CIM_Capabilities", "CIM_ManagedElement", "Capabilities", "ManagedElement");
        private IInfrastructureObjectScope _scope;
        public MsvmElementCapabilitiesAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMManagedElement> ManagedElement(CIMCapabilities inCapabilities)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCapabilities.AsCimInstance());
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMCapabilities> Capabilities(CIMManagedElement inManagedElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inManagedElement.AsCimInstance());
            return instances.Select(i => (CIMCapabilities)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMManagedElement> ManagedElementAsync(CIMCapabilities inCapabilities, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCapabilities.AsCimInstance(), options);
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMCapabilities> CapabilitiesAsync(CIMManagedElement inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (CIMCapabilities)scope.Mapper.Create(scope, i));
        }
    }
}