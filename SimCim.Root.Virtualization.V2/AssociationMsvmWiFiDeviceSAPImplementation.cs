using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmWiFiDeviceSAPImplementationAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_WiFiDeviceSAPImplementation", "Msvm_WiFiPort", "Msvm_WiFiEndpoint", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmWiFiDeviceSAPImplementationAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmWiFiEndpoint> Dependent(MsvmWiFiPort inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmWiFiEndpoint)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmWiFiPort> Antecedent(MsvmWiFiEndpoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmWiFiPort)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmWiFiEndpoint> DependentAsync(MsvmWiFiPort inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmWiFiEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmWiFiPort> AntecedentAsync(MsvmWiFiEndpoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmWiFiPort)scope.Mapper.Create(scope, i));
        }
    }
}