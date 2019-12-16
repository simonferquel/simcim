using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ComClassAutoEmulatorAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ComClassAutoEmulator", "Win32_ClassicCOMClass", "Win32_ClassicCOMClass", "NewVersion", "OldVersion");
        private IInfrastructureObjectScope _scope;
        public Win32ComClassAutoEmulatorAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32ClassicCOMClass> OldVersion(Win32ClassicCOMClass inNewVersion)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inNewVersion.AsCimInstance());
            return instances.Select(i => (Win32ClassicCOMClass)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32ClassicCOMClass> NewVersion(Win32ClassicCOMClass inOldVersion)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inOldVersion.AsCimInstance());
            return instances.Select(i => (Win32ClassicCOMClass)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ClassicCOMClass> OldVersionAsync(Win32ClassicCOMClass inNewVersion, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inNewVersion.AsCimInstance(), options);
            return instances.Select(i => (Win32ClassicCOMClass)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ClassicCOMClass> NewVersionAsync(Win32ClassicCOMClass inOldVersion, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inOldVersion.AsCimInstance(), options);
            return instances.Select(i => (Win32ClassicCOMClass)scope.Mapper.Create(scope, i));
        }
    }
}