using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SerialPortSettingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SerialPortSetting", "Win32_SerialPort", "Win32_SerialPortConfiguration", "Element", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32SerialPortSettingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32SerialPortConfiguration> Setting(Win32SerialPort inElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inElement.AsCimInstance());
            return instances.Select(i => (Win32SerialPortConfiguration)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32SerialPort> Element(Win32SerialPortConfiguration inSetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance());
            return instances.Select(i => (Win32SerialPort)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SerialPortConfiguration> SettingAsync(Win32SerialPort inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32SerialPortConfiguration)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SerialPort> ElementAsync(Win32SerialPortConfiguration inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32SerialPort)scope.Mapper.Create(scope, i));
        }
    }
}