using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32LoadOrderGroupServiceMembersAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_LoadOrderGroupServiceMembers", "Win32_LoadOrderGroup", "Win32_BaseService", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public Win32LoadOrderGroupServiceMembersAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32BaseService> PartComponent(Win32LoadOrderGroup inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32BaseService)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32LoadOrderGroup> GroupComponent(Win32BaseService inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32LoadOrderGroup)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32BaseService> PartComponentAsync(Win32LoadOrderGroup inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32BaseService)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32LoadOrderGroup> GroupComponentAsync(Win32BaseService inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32LoadOrderGroup)scope.Mapper.Create(scope, i));
        }
    }
}