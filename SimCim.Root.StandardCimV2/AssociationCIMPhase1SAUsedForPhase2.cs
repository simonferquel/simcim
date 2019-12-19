using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.StandardCimV2
{
    public struct CIMPhase1SAUsedForPhase2Association
    {
        private static AssociationResolver _resolver = new AssociationResolver("CIM_Phase1SAUsedForPhase2", "CIM_SecurityAssociationEndpoint", "CIM_IPsecSAEndpoint", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public CIMPhase1SAUsedForPhase2Association(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMIPsecSAEndpoint> Dependent(CIMSecurityAssociationEndpoint inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMIPsecSAEndpoint)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMSecurityAssociationEndpoint> Antecedent(CIMIPsecSAEndpoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMSecurityAssociationEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMIPsecSAEndpoint> DependentAsync(CIMSecurityAssociationEndpoint inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMIPsecSAEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMSecurityAssociationEndpoint> AntecedentAsync(CIMIPsecSAEndpoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMSecurityAssociationEndpoint)scope.Mapper.Create(scope, i));
        }
    }
}