using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetIPInterfaceRouteAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetIPInterfaceRoute", "CIM_LANEndpoint", "MSFT_NetRoute", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetIPInterfaceRouteAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetRoute> Dependent(CIMLANEndpoint inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetRoute)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMLANEndpoint> Antecedent(MSFTNetRoute inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMLANEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetRoute> DependentAsync(CIMLANEndpoint inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetRoute)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLANEndpoint> AntecedentAsync(MSFTNetRoute inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMLANEndpoint)scope.Mapper.Create(scope, i));
        }
    }
}