using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmEthernetPortInfoAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_EthernetPortInfo", "Msvm_EthernetSwitchPort", "Msvm_EthernetPortData", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmEthernetPortInfoAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmEthernetPortData> Dependent(MsvmEthernetSwitchPort inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (MsvmEthernetPortData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmEthernetSwitchPort> Antecedent(MsvmEthernetPortData inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (MsvmEthernetSwitchPort)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmEthernetPortData> DependentAsync(MsvmEthernetSwitchPort inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmEthernetPortData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmEthernetSwitchPort> AntecedentAsync(MsvmEthernetPortData inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmEthernetSwitchPort)scope.Mapper.Create(scope, i));
        }
    }
}