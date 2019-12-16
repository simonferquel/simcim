using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmHostedResourcePoolAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_HostedResourcePool", "Msvm_ComputerSystem", "CIM_ResourcePool", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MsvmHostedResourcePoolAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMResourcePool> PartComponent(MsvmComputerSystem inGroupComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance());
            return instances.Select(i => (CIMResourcePool)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmComputerSystem> GroupComponent(CIMResourcePool inPartComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance());
            return instances.Select(i => (MsvmComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMResourcePool> PartComponentAsync(MsvmComputerSystem inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMResourcePool)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmComputerSystem> GroupComponentAsync(CIMResourcePool inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MsvmComputerSystem)scope.Mapper.Create(scope, i));
        }
    }
}