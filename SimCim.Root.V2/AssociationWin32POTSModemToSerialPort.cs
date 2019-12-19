using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32POTSModemToSerialPortAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_POTSModemToSerialPort", "Win32_SerialPort", "Win32_POTSModem", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32POTSModemToSerialPortAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32POTSModem> Dependent(Win32SerialPort inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32POTSModem)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32SerialPort> Antecedent(Win32POTSModem inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32SerialPort)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32POTSModem> DependentAsync(Win32SerialPort inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32POTSModem)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SerialPort> AntecedentAsync(Win32POTSModem inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32SerialPort)scope.Mapper.Create(scope, i));
        }
    }
}