using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SecuritySettingOfLogicalShareAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SecuritySettingOfLogicalShare", "Win32_Share", "Win32_LogicalShareSecuritySetting", "Element", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32SecuritySettingOfLogicalShareAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32LogicalShareSecuritySetting> Setting(Win32Share inElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inElement.AsCimInstance());
            return instances.Select(i => (Win32LogicalShareSecuritySetting)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32Share> Element(Win32LogicalShareSecuritySetting inSetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance());
            return instances.Select(i => (Win32Share)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32LogicalShareSecuritySetting> SettingAsync(Win32Share inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalShareSecuritySetting)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Share> ElementAsync(Win32LogicalShareSecuritySetting inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32Share)scope.Mapper.Create(scope, i));
        }
    }
}