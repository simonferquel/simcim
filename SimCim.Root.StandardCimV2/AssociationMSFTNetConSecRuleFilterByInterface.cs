using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetConSecRuleFilterByInterfaceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetConSecRuleFilterByInterface", "MSFT_NetConSecRule", "MSFT_NetInterfaceFilter", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetConSecRuleFilterByInterfaceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetInterfaceFilter> PartComponent(MSFTNetConSecRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetInterfaceFilter)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetConSecRule> GroupComponent(MSFTNetInterfaceFilter inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetConSecRule)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetInterfaceFilter> PartComponentAsync(MSFTNetConSecRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetInterfaceFilter)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetConSecRule> GroupComponentAsync(MSFTNetInterfaceFilter inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetConSecRule)scope.Mapper.Create(scope, i));
        }
    }
}