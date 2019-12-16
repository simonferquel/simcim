using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmAffectedJobElementAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_AffectedJobElement", "CIM_ManagedElement", "CIM_Job", "AffectedElement", "AffectingElement");
        private IInfrastructureObjectScope _scope;
        public MsvmAffectedJobElementAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMJob> AffectingElement(CIMManagedElement inAffectedElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAffectedElement.AsCimInstance());
            return instances.Select(i => (CIMJob)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMManagedElement> AffectedElement(CIMJob inAffectingElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inAffectingElement.AsCimInstance());
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMJob> AffectingElementAsync(CIMManagedElement inAffectedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAffectedElement.AsCimInstance(), options);
            return instances.Select(i => (CIMJob)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMManagedElement> AffectedElementAsync(CIMJob inAffectingElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inAffectingElement.AsCimInstance(), options);
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }
    }
}