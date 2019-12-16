using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SystemServicesAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SystemServices", "Win32_ComputerSystem", "Win32_Service", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public Win32SystemServicesAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Service> PartComponent(Win32ComputerSystem inGroupComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance());
            return instances.Select(i => (Win32Service)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32ComputerSystem> GroupComponent(Win32Service inPartComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance());
            return instances.Select(i => (Win32ComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Service> PartComponentAsync(Win32ComputerSystem inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32Service)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ComputerSystem> GroupComponentAsync(Win32Service inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32ComputerSystem)scope.Mapper.Create(scope, i));
        }
    }
}