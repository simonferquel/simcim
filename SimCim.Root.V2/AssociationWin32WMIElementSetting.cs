using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32WMIElementSettingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_WMIElementSetting", "Win32_Service", "Win32_WMISetting", "Element", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32WMIElementSettingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32WMISetting> Setting(Win32Service inElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inElement.AsCimInstance());
            return instances.Select(i => (Win32WMISetting)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32Service> Element(Win32WMISetting inSetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance());
            return instances.Select(i => (Win32Service)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32WMISetting> SettingAsync(Win32Service inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32WMISetting)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Service> ElementAsync(Win32WMISetting inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32Service)scope.Mapper.Create(scope, i));
        }
    }
}