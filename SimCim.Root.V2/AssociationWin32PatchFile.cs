using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32PatchFileAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_PatchFile", "Win32_FileSpecification", "Win32_Patch", "Check", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32PatchFileAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Patch> Setting(Win32FileSpecification inCheck)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCheck.AsCimInstance());
            return instances.Select(i => (Win32Patch)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32FileSpecification> Check(Win32Patch inSetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance());
            return instances.Select(i => (Win32FileSpecification)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Patch> SettingAsync(Win32FileSpecification inCheck, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCheck.AsCimInstance(), options);
            return instances.Select(i => (Win32Patch)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32FileSpecification> CheckAsync(Win32Patch inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32FileSpecification)scope.Mapper.Create(scope, i));
        }
    }
}