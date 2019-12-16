using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ShadowStorageAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ShadowStorage", "Win32_Volume", "Win32_Volume", "DiffVolume", "Volume");
        private IInfrastructureObjectScope _scope;
        public Win32ShadowStorageAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Volume> Volume(Win32Volume inDiffVolume)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inDiffVolume.AsCimInstance());
            return instances.Select(i => (Win32Volume)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32Volume> DiffVolume(Win32Volume inVolume)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inVolume.AsCimInstance());
            return instances.Select(i => (Win32Volume)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Volume> VolumeAsync(Win32Volume inDiffVolume, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inDiffVolume.AsCimInstance(), options);
            return instances.Select(i => (Win32Volume)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Volume> DiffVolumeAsync(Win32Volume inVolume, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inVolume.AsCimInstance(), options);
            return instances.Select(i => (Win32Volume)scope.Mapper.Create(scope, i));
        }
    }
}