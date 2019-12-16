using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetIPInterfaceAdapterAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetIPInterfaceAdapter", "MSFT_NetIPInterface", "CIM_NetworkPort", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetIPInterfaceAdapterAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMNetworkPort> Dependent(MSFTNetIPInterface inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (CIMNetworkPort)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetIPInterface> Antecedent(CIMNetworkPort inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (MSFTNetIPInterface)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMNetworkPort> DependentAsync(MSFTNetIPInterface inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMNetworkPort)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetIPInterface> AntecedentAsync(CIMNetworkPort inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIPInterface)scope.Mapper.Create(scope, i));
        }
    }
}