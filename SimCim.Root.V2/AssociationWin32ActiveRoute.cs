using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ActiveRouteAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ActiveRoute", "Win32_IP4PersistedRouteTable", "Win32_IP4RouteTable", "SameElement", "SystemElement");
        private IInfrastructureObjectScope _scope;
        public Win32ActiveRouteAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32IP4RouteTable> SystemElement(Win32IP4PersistedRouteTable inSameElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inSameElement.AsCimInstance(), options);
            return instances.Select(i => (Win32IP4RouteTable)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32IP4PersistedRouteTable> SameElement(Win32IP4RouteTable inSystemElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSystemElement.AsCimInstance(), options);
            return instances.Select(i => (Win32IP4PersistedRouteTable)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32IP4RouteTable> SystemElementAsync(Win32IP4PersistedRouteTable inSameElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inSameElement.AsCimInstance(), options);
            return instances.Select(i => (Win32IP4RouteTable)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32IP4PersistedRouteTable> SameElementAsync(Win32IP4RouteTable inSystemElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSystemElement.AsCimInstance(), options);
            return instances.Select(i => (Win32IP4PersistedRouteTable)scope.Mapper.Create(scope, i));
        }
    }
}