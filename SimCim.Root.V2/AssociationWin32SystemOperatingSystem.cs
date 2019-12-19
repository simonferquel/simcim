using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SystemOperatingSystemAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SystemOperatingSystem", "Win32_ComputerSystem", "Win32_OperatingSystem", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public Win32SystemOperatingSystemAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32OperatingSystem> PartComponent(Win32ComputerSystem inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32OperatingSystem)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32ComputerSystem> GroupComponent(Win32OperatingSystem inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32ComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32OperatingSystem> PartComponentAsync(Win32ComputerSystem inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32OperatingSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ComputerSystem> GroupComponentAsync(Win32OperatingSystem inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32ComputerSystem)scope.Mapper.Create(scope, i));
        }
    }
}