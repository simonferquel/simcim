using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ProtocolBindingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ProtocolBinding", "Win32_NetworkProtocol", "Win32_NetworkAdapter", "Antecedent", "Device");
        private IInfrastructureObjectScope _scope;
        public Win32ProtocolBindingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32NetworkAdapter> Device(Win32NetworkProtocol inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (Win32NetworkAdapter)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32NetworkProtocol> Antecedent(Win32NetworkAdapter inDevice)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDevice.AsCimInstance());
            return instances.Select(i => (Win32NetworkProtocol)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NetworkAdapter> DeviceAsync(Win32NetworkProtocol inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32NetworkAdapter)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NetworkProtocol> AntecedentAsync(Win32NetworkAdapter inDevice, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDevice.AsCimInstance(), options);
            return instances.Select(i => (Win32NetworkProtocol)scope.Mapper.Create(scope, i));
        }
    }
}