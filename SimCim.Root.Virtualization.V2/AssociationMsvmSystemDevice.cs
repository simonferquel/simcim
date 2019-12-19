using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmSystemDeviceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_SystemDevice", "CIM_System", "CIM_LogicalDevice", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MsvmSystemDeviceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMLogicalDevice> PartComponent(CIMSystem inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMSystem> GroupComponent(CIMLogicalDevice inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLogicalDevice> PartComponentAsync(CIMSystem inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMSystem> GroupComponentAsync(CIMLogicalDevice inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSystem)scope.Mapper.Create(scope, i));
        }
    }
}