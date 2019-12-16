using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct CIMRouteUsesEndpointAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("CIM_RouteUsesEndpoint", "CIM_ProtocolEndpoint", "CIM_NextHopRoute", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public CIMRouteUsesEndpointAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMNextHopRoute> Dependent(CIMProtocolEndpoint inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (CIMNextHopRoute)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMProtocolEndpoint> Antecedent(CIMNextHopRoute inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (CIMProtocolEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMNextHopRoute> DependentAsync(CIMProtocolEndpoint inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMNextHopRoute)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMProtocolEndpoint> AntecedentAsync(CIMNextHopRoute inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMProtocolEndpoint)scope.Mapper.Create(scope, i));
        }
    }
}