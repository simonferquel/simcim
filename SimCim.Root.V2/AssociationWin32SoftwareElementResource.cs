using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SoftwareElementResourceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SoftwareElementResource", "Win32_SoftwareElement", "Win32_MSIResource", "Element", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32SoftwareElementResourceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32MSIResource> Setting(Win32SoftwareElement inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32MSIResource)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32SoftwareElement> Element(Win32MSIResource inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32SoftwareElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32MSIResource> SettingAsync(Win32SoftwareElement inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32MSIResource)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SoftwareElement> ElementAsync(Win32MSIResource inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32SoftwareElement)scope.Mapper.Create(scope, i));
        }
    }
}