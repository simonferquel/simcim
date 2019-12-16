using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmOwningJobElementAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_OwningJobElement", "CIM_Job", "CIM_ManagedElement", "OwnedElement", "OwningElement");
        private IInfrastructureObjectScope _scope;
        public MsvmOwningJobElementAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMManagedElement> OwningElement(CIMJob inOwnedElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inOwnedElement.AsCimInstance());
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMJob> OwnedElement(CIMManagedElement inOwningElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inOwningElement.AsCimInstance());
            return instances.Select(i => (CIMJob)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMManagedElement> OwningElementAsync(CIMJob inOwnedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inOwnedElement.AsCimInstance(), options);
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMJob> OwnedElementAsync(CIMManagedElement inOwningElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inOwningElement.AsCimInstance(), options);
            return instances.Select(i => (CIMJob)scope.Mapper.Create(scope, i));
        }
    }
}