using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmEthernetPortSettingDataComponentAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_EthernetPortSettingDataComponent", "Msvm_EthernetPortAllocationSettingData", "Msvm_EthernetSwitchPortFeatureSettingData", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MsvmEthernetPortSettingDataComponentAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmEthernetSwitchPortFeatureSettingData> PartComponent(MsvmEthernetPortAllocationSettingData inGroupComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance());
            return instances.Select(i => (MsvmEthernetSwitchPortFeatureSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmEthernetPortAllocationSettingData> GroupComponent(MsvmEthernetSwitchPortFeatureSettingData inPartComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance());
            return instances.Select(i => (MsvmEthernetPortAllocationSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmEthernetSwitchPortFeatureSettingData> PartComponentAsync(MsvmEthernetPortAllocationSettingData inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MsvmEthernetSwitchPortFeatureSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmEthernetPortAllocationSettingData> GroupComponentAsync(MsvmEthernetSwitchPortFeatureSettingData inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MsvmEthernetPortAllocationSettingData)scope.Mapper.Create(scope, i));
        }
    }
}