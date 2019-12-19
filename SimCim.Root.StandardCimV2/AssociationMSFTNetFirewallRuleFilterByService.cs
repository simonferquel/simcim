using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.StandardCimV2
{
    public struct MSFTNetFirewallRuleFilterByServiceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetFirewallRuleFilterByService", "MSFT_NetFirewallRule", "MSFT_NetServiceFilter", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetFirewallRuleFilterByServiceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetServiceFilter> PartComponent(MSFTNetFirewallRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetServiceFilter)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetFirewallRule> GroupComponent(MSFTNetServiceFilter inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetFirewallRule)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetServiceFilter> PartComponentAsync(MSFTNetFirewallRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetServiceFilter)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetFirewallRule> GroupComponentAsync(MSFTNetServiceFilter inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetFirewallRule)scope.Mapper.Create(scope, i));
        }
    }
}