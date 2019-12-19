using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetFirewallRuleFiltersAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetFirewallRuleFilters", "MSFT_NetFirewallRule", "CIM_FilterEntryBase", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetFirewallRuleFiltersAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMFilterEntryBase> PartComponent(MSFTNetFirewallRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMFilterEntryBase)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetFirewallRule> GroupComponent(CIMFilterEntryBase inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetFirewallRule)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMFilterEntryBase> PartComponentAsync(MSFTNetFirewallRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMFilterEntryBase)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetFirewallRule> GroupComponentAsync(CIMFilterEntryBase inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetFirewallRule)scope.Mapper.Create(scope, i));
        }
    }
}