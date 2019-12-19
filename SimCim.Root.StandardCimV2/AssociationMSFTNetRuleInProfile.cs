using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetRuleInProfileAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetRuleInProfile", "MSFT_NetFirewallProfile", "CIM_PolicyRule", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetRuleInProfileAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMPolicyRule> PartComponent(MSFTNetFirewallProfile inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMPolicyRule)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetFirewallProfile> GroupComponent(CIMPolicyRule inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetFirewallProfile)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMPolicyRule> PartComponentAsync(MSFTNetFirewallProfile inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMPolicyRule)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetFirewallProfile> GroupComponentAsync(CIMPolicyRule inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetFirewallProfile)scope.Mapper.Create(scope, i));
        }
    }
}