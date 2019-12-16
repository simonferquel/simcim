using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32LogicalDiskRootDirectoryAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_LogicalDiskRootDirectory", "Win32_LogicalDisk", "Win32_Directory", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public Win32LogicalDiskRootDirectoryAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Directory> PartComponent(Win32LogicalDisk inGroupComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance());
            return instances.Select(i => (Win32Directory)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32LogicalDisk> GroupComponent(Win32Directory inPartComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance());
            return instances.Select(i => (Win32LogicalDisk)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Directory> PartComponentAsync(Win32LogicalDisk inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32Directory)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32LogicalDisk> GroupComponentAsync(Win32Directory inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalDisk)scope.Mapper.Create(scope, i));
        }
    }
}