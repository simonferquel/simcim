using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmResourceAllocationFromPoolAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_ResourceAllocationFromPool", "CIM_ResourcePool", "CIM_ResourceAllocationSettingData", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmResourceAllocationFromPoolAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMResourceAllocationSettingData> Dependent(CIMResourcePool inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMResourceAllocationSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMResourcePool> Antecedent(CIMResourceAllocationSettingData inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMResourcePool)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMResourceAllocationSettingData> DependentAsync(CIMResourcePool inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMResourceAllocationSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMResourcePool> AntecedentAsync(CIMResourceAllocationSettingData inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMResourcePool)scope.Mapper.Create(scope, i));
        }
    }
}