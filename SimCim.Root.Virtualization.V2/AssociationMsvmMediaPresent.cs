using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmMediaPresentAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_MediaPresent", "CIM_MediaAccessDevice", "CIM_StorageExtent", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmMediaPresentAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMStorageExtent> Dependent(CIMMediaAccessDevice inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMStorageExtent)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMMediaAccessDevice> Antecedent(CIMStorageExtent inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMMediaAccessDevice)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMStorageExtent> DependentAsync(CIMMediaAccessDevice inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMStorageExtent)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMMediaAccessDevice> AntecedentAsync(CIMStorageExtent inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMMediaAccessDevice)scope.Mapper.Create(scope, i));
        }
    }
}