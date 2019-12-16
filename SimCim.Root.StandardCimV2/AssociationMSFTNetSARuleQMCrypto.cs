using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetSARuleQMCryptoAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetSARuleQMCrypto", "CIM_SARule", "MSFT_NetIKEQMCryptoSet", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetSARuleQMCryptoAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetIKEQMCryptoSet> PartComponent(CIMSARule inGroupComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance());
            return instances.Select(i => (MSFTNetIKEQMCryptoSet)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMSARule> GroupComponent(MSFTNetIKEQMCryptoSet inPartComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance());
            return instances.Select(i => (CIMSARule)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetIKEQMCryptoSet> PartComponentAsync(CIMSARule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIKEQMCryptoSet)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMSARule> GroupComponentAsync(MSFTNetIKEQMCryptoSet inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSARule)scope.Mapper.Create(scope, i));
        }
    }
}