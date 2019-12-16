using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32VideoSettingsAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_VideoSettings", "Win32_VideoController", "CIM_VideoControllerResolution", "Element", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32VideoSettingsAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMVideoControllerResolution> Setting(Win32VideoController inElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inElement.AsCimInstance());
            return instances.Select(i => (CIMVideoControllerResolution)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32VideoController> Element(CIMVideoControllerResolution inSetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance());
            return instances.Select(i => (Win32VideoController)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMVideoControllerResolution> SettingAsync(Win32VideoController inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (CIMVideoControllerResolution)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32VideoController> ElementAsync(CIMVideoControllerResolution inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32VideoController)scope.Mapper.Create(scope, i));
        }
    }
}