using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ClassicCOMClassSettingsAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ClassicCOMClassSettings", "Win32_ClassicCOMClass", "Win32_ClassicCOMClassSetting", "Element", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32ClassicCOMClassSettingsAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32ClassicCOMClassSetting> Setting(Win32ClassicCOMClass inElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inElement.AsCimInstance());
            return instances.Select(i => (Win32ClassicCOMClassSetting)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32ClassicCOMClass> Element(Win32ClassicCOMClassSetting inSetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance());
            return instances.Select(i => (Win32ClassicCOMClass)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ClassicCOMClassSetting> SettingAsync(Win32ClassicCOMClass inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32ClassicCOMClassSetting)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ClassicCOMClass> ElementAsync(Win32ClassicCOMClassSetting inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32ClassicCOMClass)scope.Mapper.Create(scope, i));
        }
    }
}