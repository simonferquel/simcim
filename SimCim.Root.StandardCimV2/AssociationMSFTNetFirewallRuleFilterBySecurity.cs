using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.StandardCimV2
{
    public struct MSFTNetFirewallRuleFilterBySecurityAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetFirewallRuleFilterBySecurity", "MSFT_NetFirewallRule", "MSFT_NetNetworkLayerSecurityFilter", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetFirewallRuleFilterBySecurityAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetNetworkLayerSecurityFilter> PartComponent(MSFTNetFirewallRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetNetworkLayerSecurityFilter)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetFirewallRule> GroupComponent(MSFTNetNetworkLayerSecurityFilter inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetFirewallRule)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetNetworkLayerSecurityFilter> PartComponentAsync(MSFTNetFirewallRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetNetworkLayerSecurityFilter)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetFirewallRule> GroupComponentAsync(MSFTNetNetworkLayerSecurityFilter inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetFirewallRule)scope.Mapper.Create(scope, i));
        }
    }
}