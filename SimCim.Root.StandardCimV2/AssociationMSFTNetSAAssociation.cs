using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetSAAssociationAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetSAAssociation", "CIM_SecurityAssociationEndpoint", "CIM_IPsecSAEndpoint", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetSAAssociationAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMIPsecSAEndpoint> Dependent(CIMSecurityAssociationEndpoint inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (CIMIPsecSAEndpoint)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMSecurityAssociationEndpoint> Antecedent(CIMIPsecSAEndpoint inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
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