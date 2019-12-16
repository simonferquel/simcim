using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmServiceAffectsElementAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_ServiceAffectsElement", "CIM_ManagedElement", "CIM_Service", "AffectedElement", "AffectingElement");
        private IInfrastructureObjectScope _scope;
        public MsvmServiceAffectsElementAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMService> AffectingElement(CIMManagedElement inAffectedElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAffectedElement.AsCimInstance());
            return instances.Select(i => (CIMService)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMManagedElement> AffectedElement(CIMService inAffectingElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inAffectingElement.AsCimInstance());
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMService> AffectingElementAsync(CIMManagedElement inAffectedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAffectedElement.AsCimInstance(), options);
            return instances.Select(i => (CIMService)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMManagedElement> AffectedElementAsync(CIMService inAffectingElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inAffectingElement.AsCimInstance(), options);
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }
    }
}