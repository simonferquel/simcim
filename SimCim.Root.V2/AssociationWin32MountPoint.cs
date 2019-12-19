using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32MountPointAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_MountPoint", "Win32_Directory", "Win32_Volume", "Directory", "Volume");
        private IInfrastructureObjectScope _scope;
        public Win32MountPointAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Volume> Volume(Win32Directory inDirectory, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inDirectory.AsCimInstance(), options);
            return instances.Select(i => (Win32Volume)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32Directory> Directory(Win32Volume inVolume, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inVolume.AsCimInstance(), options);
            return instances.Select(i => (Win32Directory)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Volume> VolumeAsync(Win32Directory inDirectory, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inDirectory.AsCimInstance(), options);
            return instances.Select(i => (Win32Volume)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Directory> DirectoryAsync(Win32Volume inVolume, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inVolume.AsCimInstance(), options);
            return instances.Select(i => (Win32Directory)scope.Mapper.Create(scope, i));
        }
    }
}