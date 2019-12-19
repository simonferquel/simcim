using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmVirtualSystemSettingDataComponentAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_VirtualSystemSettingDataComponent", "CIM_VirtualSystemSettingData", "CIM_ResourceAllocationSettingData", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MsvmVirtualSystemSettingDataComponentAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMResourceAllocationSettingData> PartComponent(CIMVirtualSystemSettingData inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMResourceAllocationSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMVirtualSystemSettingData> GroupComponent(CIMResourceAllocationSettingData inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMVirtualSystemSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMResourceAllocationSettingData> PartComponentAsync(CIMVirtualSystemSettingData inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMResourceAllocationSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMVirtualSystemSettingData> GroupComponentAsync(CIMResourceAllocationSettingData inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMVirtualSystemSettingData)scope.Mapper.Create(scope, i));
        }
    }
}