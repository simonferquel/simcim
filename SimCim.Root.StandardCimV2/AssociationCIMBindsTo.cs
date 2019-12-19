using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.StandardCimV2
{
    public struct CIMBindsToAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("CIM_BindsTo", "CIM_ProtocolEndpoint", "CIM_ServiceAccessPoint", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public CIMBindsToAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMServiceAccessPoint> Dependent(CIMProtocolEndpoint inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMServiceAccessPoint)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMProtocolEndpoint> Antecedent(CIMServiceAccessPoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMProtocolEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMServiceAccessPoint> DependentAsync(CIMProtocolEndpoint inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMServiceAccessPoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMProtocolEndpoint> AntecedentAsync(CIMServiceAccessPoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMProtocolEndpoint)scope.Mapper.Create(scope, i));
        }
    }
}