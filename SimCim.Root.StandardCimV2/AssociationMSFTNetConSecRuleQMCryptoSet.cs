using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.StandardCimV2
{
    public struct MSFTNetConSecRuleQMCryptoSetAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetConSecRuleQMCryptoSet", "MSFT_NetConSecRule", "MSFT_NetIKEQMCryptoSet", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetConSecRuleQMCryptoSetAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetIKEQMCryptoSet> PartComponent(MSFTNetConSecRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIKEQMCryptoSet)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetConSecRule> GroupComponent(MSFTNetIKEQMCryptoSet inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetConSecRule)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetIKEQMCryptoSet> PartComponentAsync(MSFTNetConSecRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIKEQMCryptoSet)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetConSecRule> GroupComponentAsync(MSFTNetIKEQMCryptoSet inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetConSecRule)scope.Mapper.Create(scope, i));
        }
    }
}