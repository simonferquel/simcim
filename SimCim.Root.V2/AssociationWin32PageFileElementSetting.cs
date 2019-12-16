using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32PageFileElementSettingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_PageFileElementSetting", "Win32_PageFileUsage", "Win32_PageFileSetting", "Element", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32PageFileElementSettingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32PageFileSetting> Setting(Win32PageFileUsage inElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inElement.AsCimInstance());
            return instances.Select(i => (Win32PageFileSetting)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32PageFileUsage> Element(Win32PageFileSetting inSetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance());
            return instances.Select(i => (Win32PageFileUsage)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32PageFileSetting> SettingAsync(Win32PageFileUsage inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32PageFileSetting)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32PageFileUsage> ElementAsync(Win32PageFileSetting inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32PageFileUsage)scope.Mapper.Create(scope, i));
        }
    }
}