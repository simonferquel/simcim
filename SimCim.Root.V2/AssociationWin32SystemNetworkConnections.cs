using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SystemNetworkConnectionsAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SystemNetworkConnections", "Win32_ComputerSystem", "Win32_NetworkConnection", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public Win32SystemNetworkConnectionsAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32NetworkConnection> PartComponent(Win32ComputerSystem inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32NetworkConnection)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32ComputerSystem> GroupComponent(Win32NetworkConnection inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32ComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NetworkConnection> PartComponentAsync(Win32ComputerSystem inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32NetworkConnection)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ComputerSystem> GroupComponentAsync(Win32NetworkConnection inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32ComputerSystem)scope.Mapper.Create(scope, i));
        }
    }
}