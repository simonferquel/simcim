using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmEthernetDeviceSAPImplementationAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_EthernetDeviceSAPImplementation", "CIM_EthernetPort", "Msvm_LANEndpoint", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmEthernetDeviceSAPImplementationAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmLANEndpoint> Dependent(CIMEthernetPort inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmLANEndpoint)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMEthernetPort> Antecedent(MsvmLANEndpoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMEthernetPort)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmLANEndpoint> DependentAsync(CIMEthernetPort inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmLANEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMEthernetPort> AntecedentAsync(MsvmLANEndpoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMEthernetPort)scope.Mapper.Create(scope, i));
        }
    }
}