using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmResourceDependentOnResourceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_ResourceDependentOnResource", "CIM_ResourceAllocationSettingData", "CIM_ResourceAllocationSettingData", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmResourceDependentOnResourceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMResourceAllocationSettingData> Dependent(CIMResourceAllocationSettingData inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (CIMResourceAllocationSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMResourceAllocationSettingData> Antecedent(CIMResourceAllocationSettingData inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (CIMResourceAllocationSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMResourceAllocationSettingData> DependentAsync(CIMResourceAllocationSettingData inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMResourceAllocationSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMResourceAllocationSettingData> AntecedentAsync(CIMResourceAllocationSettingData inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMResourceAllocationSettingData)scope.Mapper.Create(scope, i));
        }
    }
}