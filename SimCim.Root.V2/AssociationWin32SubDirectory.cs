using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SubDirectoryAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SubDirectory", "Win32_Directory", "Win32_Directory", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public Win32SubDirectoryAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Directory> PartComponent(Win32Directory inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32Directory)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32Directory> GroupComponent(Win32Directory inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32Directory)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Directory> PartComponentAsync(Win32Directory inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32Directory)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Directory> GroupComponentAsync(Win32Directory inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32Directory)scope.Mapper.Create(scope, i));
        }
    }
}