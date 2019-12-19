using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SystemTimeZoneAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SystemTimeZone", "Win32_ComputerSystem", "Win32_TimeZone", "Element", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32SystemTimeZoneAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32TimeZone> Setting(Win32ComputerSystem inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32TimeZone)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32ComputerSystem> Element(Win32TimeZone inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32ComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32TimeZone> SettingAsync(Win32ComputerSystem inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32TimeZone)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ComputerSystem> ElementAsync(Win32TimeZone inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32ComputerSystem)scope.Mapper.Create(scope, i));
        }
    }
}