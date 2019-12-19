using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.StandardCimV2
{
    public struct MSFTNetMainModeRuleFilterByAddressAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetMainModeRuleFilterByAddress", "MSFT_NetMainModeRule", "MSFT_NetAddressFilter", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetMainModeRuleFilterByAddressAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetAddressFilter> PartComponent(MSFTNetMainModeRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAddressFilter)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetMainModeRule> GroupComponent(MSFTNetAddressFilter inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetMainModeRule)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetAddressFilter> PartComponentAsync(MSFTNetMainModeRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAddressFilter)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetMainModeRule> GroupComponentAsync(MSFTNetAddressFilter inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetMainModeRule)scope.Mapper.Create(scope, i));
        }
    }
}