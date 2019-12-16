using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmVirtualEthernetSwitchNicTeamingMemberAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_VirtualEthernetSwitchNicTeamingMember", "Msvm_ExternalEthernetPort", "Msvm_ExternalEthernetPort", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmVirtualEthernetSwitchNicTeamingMemberAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmExternalEthernetPort> Dependent(MsvmExternalEthernetPort inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (MsvmExternalEthernetPort)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmExternalEthernetPort> Antecedent(MsvmExternalEthernetPort inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (MsvmExternalEthernetPort)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmExternalEthernetPort> DependentAsync(MsvmExternalEthernetPort inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmExternalEthernetPort)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmExternalEthernetPort> AntecedentAsync(MsvmExternalEthernetPort inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmExternalEthernetPort)scope.Mapper.Create(scope, i));
        }
    }
}