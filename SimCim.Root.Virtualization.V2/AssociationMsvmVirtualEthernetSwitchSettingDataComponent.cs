using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmVirtualEthernetSwitchSettingDataComponentAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_VirtualEthernetSwitchSettingDataComponent", "Msvm_VirtualEthernetSwitchSettingData", "Msvm_EthernetSwitchFeatureSettingData", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MsvmVirtualEthernetSwitchSettingDataComponentAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmEthernetSwitchFeatureSettingData> PartComponent(MsvmVirtualEthernetSwitchSettingData inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MsvmEthernetSwitchFeatureSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmVirtualEthernetSwitchSettingData> GroupComponent(MsvmEthernetSwitchFeatureSettingData inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualEthernetSwitchSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmEthernetSwitchFeatureSettingData> PartComponentAsync(MsvmVirtualEthernetSwitchSettingData inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MsvmEthernetSwitchFeatureSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmVirtualEthernetSwitchSettingData> GroupComponentAsync(MsvmEthernetSwitchFeatureSettingData inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualEthernetSwitchSettingData)scope.Mapper.Create(scope, i));
        }
    }
}