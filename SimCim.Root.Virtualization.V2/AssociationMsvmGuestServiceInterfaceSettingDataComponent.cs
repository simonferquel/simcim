using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmGuestServiceInterfaceSettingDataComponentAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_GuestServiceInterfaceSettingDataComponent", "Msvm_GuestServiceInterfaceComponentSettingData", "CIM_SettingData", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MsvmGuestServiceInterfaceSettingDataComponentAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMSettingData> PartComponent(MsvmGuestServiceInterfaceComponentSettingData inGroupComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance());
            return instances.Select(i => (CIMSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmGuestServiceInterfaceComponentSettingData> GroupComponent(CIMSettingData inPartComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance());
            return instances.Select(i => (MsvmGuestServiceInterfaceComponentSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMSettingData> PartComponentAsync(MsvmGuestServiceInterfaceComponentSettingData inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmGuestServiceInterfaceComponentSettingData> GroupComponentAsync(CIMSettingData inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MsvmGuestServiceInterfaceComponentSettingData)scope.Mapper.Create(scope, i));
        }
    }
}