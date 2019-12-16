using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32DCOMApplicationLaunchAllowedSettingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_DCOMApplicationLaunchAllowedSetting", "Win32_DCOMApplication", "Win32_SID", "Element", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32DCOMApplicationLaunchAllowedSettingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32SID> Setting(Win32DCOMApplication inElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inElement.AsCimInstance());
            return instances.Select(i => (Win32SID)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32DCOMApplication> Element(Win32SID inSetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance());
            return instances.Select(i => (Win32DCOMApplication)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SID> SettingAsync(Win32DCOMApplication inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32SID)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32DCOMApplication> ElementAsync(Win32SID inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32DCOMApplication)scope.Mapper.Create(scope, i));
        }
    }
}