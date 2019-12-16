using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmSystemReplicationRelationshipAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_SystemReplicationRelationship", "Msvm_ComputerSystem", "Msvm_ReplicationRelationship", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmSystemReplicationRelationshipAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmReplicationRelationship> Dependent(MsvmComputerSystem inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (MsvmReplicationRelationship)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmComputerSystem> Antecedent(MsvmReplicationRelationship inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (MsvmComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmReplicationRelationship> DependentAsync(MsvmComputerSystem inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmReplicationRelationship)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmComputerSystem> AntecedentAsync(MsvmReplicationRelationship inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmComputerSystem)scope.Mapper.Create(scope, i));
        }
    }
}