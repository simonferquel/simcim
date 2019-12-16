using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32NetworkAdapterSettingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_NetworkAdapterSetting", "Win32_NetworkAdapter", "Win32_NetworkAdapterConfiguration", "Element", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32NetworkAdapterSettingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32NetworkAdapterConfiguration> Setting(Win32NetworkAdapter inElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inElement.AsCimInstance());
            return instances.Select(i => (Win32NetworkAdapterConfiguration)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32NetworkAdapter> Element(Win32NetworkAdapterConfiguration inSetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance());
            return instances.Select(i => (Win32NetworkAdapter)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NetworkAdapterConfiguration> SettingAsync(Win32NetworkAdapter inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32NetworkAdapterConfiguration)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NetworkAdapter> ElementAsync(Win32NetworkAdapterConfiguration inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32NetworkAdapter)scope.Mapper.Create(scope, i));
        }
    }
}