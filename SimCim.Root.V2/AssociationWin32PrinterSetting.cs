using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32PrinterSettingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_PrinterSetting", "Win32_Printer", "Win32_PrinterConfiguration", "Element", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32PrinterSettingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32PrinterConfiguration> Setting(Win32Printer inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32PrinterConfiguration)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32Printer> Element(Win32PrinterConfiguration inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32Printer)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32PrinterConfiguration> SettingAsync(Win32Printer inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32PrinterConfiguration)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Printer> ElementAsync(Win32PrinterConfiguration inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32Printer)scope.Mapper.Create(scope, i));
        }
    }
}