using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmFeatureSettingsDefineCapabilitiesAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_FeatureSettingsDefineCapabilities", "Msvm_EthernetSwitchFeatureCapabilities", "Msvm_FeatureSettingData", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MsvmFeatureSettingsDefineCapabilitiesAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmFeatureSettingData> PartComponent(MsvmEthernetSwitchFeatureCapabilities inGroupComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance());
            return instances.Select(i => (MsvmFeatureSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmEthernetSwitchFeatureCapabilities> GroupComponent(MsvmFeatureSettingData inPartComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance());
            return instances.Select(i => (MsvmEthernetSwitchFeatureCapabilities)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmFeatureSettingData> PartComponentAsync(MsvmEthernetSwitchFeatureCapabilities inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MsvmFeatureSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmEthernetSwitchFeatureCapabilities> GroupComponentAsync(MsvmFeatureSettingData inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MsvmEthernetSwitchFeatureCapabilities)scope.Mapper.Create(scope, i));
        }
    }
}