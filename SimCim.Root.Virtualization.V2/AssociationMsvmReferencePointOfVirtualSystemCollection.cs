using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmReferencePointOfVirtualSystemCollectionAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_ReferencePointOfVirtualSystemCollection", "CIM_CollectionOfMSEs", "CIM_Collection", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmReferencePointOfVirtualSystemCollectionAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMCollection> Dependent(CIMCollectionOfMSEs inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMCollection)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMCollectionOfMSEs> Antecedent(CIMCollection inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMCollectionOfMSEs)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMCollection> DependentAsync(CIMCollectionOfMSEs inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMCollection)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMCollectionOfMSEs> AntecedentAsync(CIMCollection inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMCollectionOfMSEs)scope.Mapper.Create(scope, i));
        }
    }
}