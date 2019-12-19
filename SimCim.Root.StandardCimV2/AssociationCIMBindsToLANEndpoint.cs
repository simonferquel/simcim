using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.StandardCimV2
{
    public struct CIMBindsToLANEndpointAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("CIM_BindsToLANEndpoint", "CIM_LANEndpoint", "CIM_ServiceAccessPoint", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public CIMBindsToLANEndpointAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMServiceAccessPoint> Dependent(CIMLANEndpoint inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMServiceAccessPoint)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMLANEndpoint> Antecedent(CIMServiceAccessPoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMLANEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMServiceAccessPoint> DependentAsync(CIMLANEndpoint inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMServiceAccessPoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLANEndpoint> AntecedentAsync(CIMServiceAccessPoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMLANEndpoint)scope.Mapper.Create(scope, i));
        }
    }
}