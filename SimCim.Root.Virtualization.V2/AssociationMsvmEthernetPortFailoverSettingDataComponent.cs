using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmEthernetPortFailoverSettingDataComponentAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_EthernetPortFailoverSettingDataComponent", "CIM_ResourceAllocationSettingData", "Msvm_FailoverNetworkAdapterSettingData", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MsvmEthernetPortFailoverSettingDataComponentAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmFailoverNetworkAdapterSettingData> PartComponent(CIMResourceAllocationSettingData inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MsvmFailoverNetworkAdapterSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMResourceAllocationSettingData> GroupComponent(MsvmFailoverNetworkAdapterSettingData inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMResourceAllocationSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmFailoverNetworkAdapterSettingData> PartComponentAsync(CIMResourceAllocationSettingData inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MsvmFailoverNetworkAdapterSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMResourceAllocationSettingData> GroupComponentAsync(MsvmFailoverNetworkAdapterSettingData inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMResourceAllocationSettingData)scope.Mapper.Create(scope, i));
        }
    }
}