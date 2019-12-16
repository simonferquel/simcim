using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetMainModeRuleInProfileAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetMainModeRuleInProfile", "MSFT_NetFirewallProfile", "MSFT_NetMainModeRule", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetMainModeRuleInProfileAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetMainModeRule> PartComponent(MSFTNetFirewallProfile inGroupComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance());
            return instances.Select(i => (MSFTNetMainModeRule)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetFirewallProfile> GroupComponent(MSFTNetMainModeRule inPartComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance());
            return instances.Select(i => (MSFTNetFirewallProfile)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetMainModeRule> PartComponentAsync(MSFTNetFirewallProfile inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetMainModeRule)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetFirewallProfile> GroupComponentAsync(MSFTNetMainModeRule inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetFirewallProfile)scope.Mapper.Create(scope, i));
        }
    }
}