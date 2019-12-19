using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SystemResourcesAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SystemResources", "Win32_ComputerSystem", "CIM_SystemResource", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public Win32SystemResourcesAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMSystemResource> PartComponent(Win32ComputerSystem inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSystemResource)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32ComputerSystem> GroupComponent(CIMSystemResource inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32ComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMSystemResource> PartComponentAsync(Win32ComputerSystem inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSystemResource)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ComputerSystem> GroupComponentAsync(CIMSystemResource inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32ComputerSystem)scope.Mapper.Create(scope, i));
        }
    }
}