using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmVirtualSystemMigrationServiceSettingDataComponentAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_VirtualSystemMigrationServiceSettingDataComponent", "Msvm_VirtualSystemMigrationServiceSettingData", "Msvm_VirtualSystemMigrationNetworkSettingData", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MsvmVirtualSystemMigrationServiceSettingDataComponentAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmVirtualSystemMigrationNetworkSettingData> PartComponent(MsvmVirtualSystemMigrationServiceSettingData inGroupComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance());
            return instances.Select(i => (MsvmVirtualSystemMigrationNetworkSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmVirtualSystemMigrationServiceSettingData> GroupComponent(MsvmVirtualSystemMigrationNetworkSettingData inPartComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance());
            return instances.Select(i => (MsvmVirtualSystemMigrationServiceSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmVirtualSystemMigrationNetworkSettingData> PartComponentAsync(MsvmVirtualSystemMigrationServiceSettingData inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualSystemMigrationNetworkSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmVirtualSystemMigrationServiceSettingData> GroupComponentAsync(MsvmVirtualSystemMigrationNetworkSettingData inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualSystemMigrationServiceSettingData)scope.Mapper.Create(scope, i));
        }
    }
}