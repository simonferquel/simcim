using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32OperatingSystemAutochkSettingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_OperatingSystemAutochkSetting", "Win32_OperatingSystem", "Win32_AutochkSetting", "Element", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32OperatingSystemAutochkSettingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32AutochkSetting> Setting(Win32OperatingSystem inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32AutochkSetting)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32OperatingSystem> Element(Win32AutochkSetting inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32OperatingSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32AutochkSetting> SettingAsync(Win32OperatingSystem inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32AutochkSetting)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32OperatingSystem> ElementAsync(Win32AutochkSetting inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32OperatingSystem)scope.Mapper.Create(scope, i));
        }
    }
}