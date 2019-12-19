using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmAffectedStorageJobElementAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_AffectedStorageJobElement", "CIM_ManagedElement", "Msvm_StorageJob", "AffectedElement", "AffectingElement");
        private IInfrastructureObjectScope _scope;
        public MsvmAffectedStorageJobElementAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmStorageJob> AffectingElement(CIMManagedElement inAffectedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAffectedElement.AsCimInstance(), options);
            return instances.Select(i => (MsvmStorageJob)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMManagedElement> AffectedElement(MsvmStorageJob inAffectingElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inAffectingElement.AsCimInstance(), options);
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmStorageJob> AffectingElementAsync(CIMManagedElement inAffectedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAffectedElement.AsCimInstance(), options);
            return instances.Select(i => (MsvmStorageJob)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMManagedElement> AffectedElementAsync(MsvmStorageJob inAffectingElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inAffectingElement.AsCimInstance(), options);
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }
    }
}