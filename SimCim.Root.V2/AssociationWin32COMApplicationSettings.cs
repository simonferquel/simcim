using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32COMApplicationSettingsAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_COMApplicationSettings", "Win32_DCOMApplication", "Win32_DCOMApplicationSetting", "Element", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32COMApplicationSettingsAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32DCOMApplicationSetting> Setting(Win32DCOMApplication inElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inElement.AsCimInstance());
            return instances.Select(i => (Win32DCOMApplicationSetting)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32DCOMApplication> Element(Win32DCOMApplicationSetting inSetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance());
            return instances.Select(i => (Win32DCOMApplication)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32DCOMApplicationSetting> SettingAsync(Win32DCOMApplication inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32DCOMApplicationSetting)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32DCOMApplication> ElementAsync(Win32DCOMApplicationSetting inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32DCOMApplication)scope.Mapper.Create(scope, i));
        }
    }
}