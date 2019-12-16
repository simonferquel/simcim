using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct CIMPortImplementsEndpointAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("CIM_PortImplementsEndpoint", "CIM_LogicalPort", "CIM_ProtocolEndpoint", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public CIMPortImplementsEndpointAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMProtocolEndpoint> Dependent(CIMLogicalPort inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (CIMProtocolEndpoint)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMLogicalPort> Antecedent(CIMProtocolEndpoint inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (CIMLogicalPort)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMProtocolEndpoint> DependentAsync(CIMLogicalPort inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMProtocolEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLogicalPort> AntecedentAsync(CIMProtocolEndpoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalPort)scope.Mapper.Create(scope, i));
        }
    }
}