using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetFirewallRuleFilterByAddressAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetFirewallRuleFilterByAddress", "MSFT_NetFirewallRule", "MSFT_NetAddressFilter", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetFirewallRuleFilterByAddressAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetAddressFilter> PartComponent(MSFTNetFirewallRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAddressFilter)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetFirewallRule> GroupComponent(MSFTNetAddressFilter inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetFirewallRule)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetAddressFilter> PartComponentAsync(MSFTNetFirewallRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAddressFilter)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetFirewallRule> GroupComponentAsync(MSFTNetAddressFilter inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetFirewallRule)scope.Mapper.Create(scope, i));
        }
    }
}