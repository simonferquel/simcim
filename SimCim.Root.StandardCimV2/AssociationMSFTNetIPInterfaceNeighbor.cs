using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.StandardCimV2
{
    public struct MSFTNetIPInterfaceNeighborAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetIPInterfaceNeighbor", "MSFT_NetIPInterface", "MSFT_NetNeighbor", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetIPInterfaceNeighborAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetNeighbor> Dependent(MSFTNetIPInterface inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetNeighbor)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetIPInterface> Antecedent(MSFTNetNeighbor inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIPInterface)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetNeighbor> DependentAsync(MSFTNetIPInterface inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetNeighbor)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetIPInterface> AntecedentAsync(MSFTNetNeighbor inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIPInterface)scope.Mapper.Create(scope, i));
        }
    }
}