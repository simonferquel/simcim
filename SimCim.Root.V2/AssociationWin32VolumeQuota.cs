using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32VolumeQuotaAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_VolumeQuota", "Win32_Volume", "Win32_QuotaSetting", "Element", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32VolumeQuotaAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32QuotaSetting> Setting(Win32Volume inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32QuotaSetting)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32Volume> Element(Win32QuotaSetting inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32Volume)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32QuotaSetting> SettingAsync(Win32Volume inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32QuotaSetting)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Volume> ElementAsync(Win32QuotaSetting inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32Volume)scope.Mapper.Create(scope, i));
        }
    }
}