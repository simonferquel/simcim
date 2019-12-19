using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmSettingsDefineCapabilitiesAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_SettingsDefineCapabilities", "CIM_Capabilities", "CIM_SettingData", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MsvmSettingsDefineCapabilitiesAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMSettingData> PartComponent(CIMCapabilities inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMCapabilities> GroupComponent(CIMSettingData inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMCapabilities)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMSettingData> PartComponentAsync(CIMCapabilities inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMCapabilities> GroupComponentAsync(CIMSettingData inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMCapabilities)scope.Mapper.Create(scope, i));
        }
    }
}