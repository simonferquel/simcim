using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetFirewallRuleFilterByInterfaceTypeAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetFirewallRuleFilterByInterfaceType", "MSFT_NetFirewallRule", "MSFT_NetInterfaceTypeFilter", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetFirewallRuleFilterByInterfaceTypeAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetInterfaceTypeFilter> PartComponent(MSFTNetFirewallRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetInterfaceTypeFilter)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetFirewallRule> GroupComponent(MSFTNetInterfaceTypeFilter inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetFirewallRule)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetInterfaceTypeFilter> PartComponentAsync(MSFTNetFirewallRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetInterfaceTypeFilter)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetFirewallRule> GroupComponentAsync(MSFTNetInterfaceTypeFilter inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetFirewallRule)scope.Mapper.Create(scope, i));
        }
    }
}