using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32GroupUserAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_GroupUser", "Win32_Group", "Win32_Account", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public Win32GroupUserAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Account> PartComponent(Win32Group inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32Account)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32Group> GroupComponent(Win32Account inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32Group)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Account> PartComponentAsync(Win32Group inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32Account)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Group> GroupComponentAsync(Win32Account inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32Group)scope.Mapper.Create(scope, i));
        }
    }
}