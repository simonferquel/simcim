using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32UserDesktopAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_UserDesktop", "Win32_UserAccount", "Win32_Desktop", "Element", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32UserDesktopAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Desktop> Setting(Win32UserAccount inElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inElement.AsCimInstance());
            return instances.Select(i => (Win32Desktop)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32UserAccount> Element(Win32Desktop inSetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance());
            return instances.Select(i => (Win32UserAccount)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Desktop> SettingAsync(Win32UserAccount inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32Desktop)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32UserAccount> ElementAsync(Win32Desktop inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32UserAccount)scope.Mapper.Create(scope, i));
        }
    }
}