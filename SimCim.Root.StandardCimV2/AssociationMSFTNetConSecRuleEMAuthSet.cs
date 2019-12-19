using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.StandardCimV2
{
    public struct MSFTNetConSecRuleEMAuthSetAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetConSecRuleEMAuthSet", "MSFT_NetConSecRule", "MSFT_NetIKEP2AuthSet", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetConSecRuleEMAuthSetAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetIKEP2AuthSet> PartComponent(MSFTNetConSecRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIKEP2AuthSet)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetConSecRule> GroupComponent(MSFTNetIKEP2AuthSet inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetConSecRule)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetIKEP2AuthSet> PartComponentAsync(MSFTNetConSecRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIKEP2AuthSet)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetConSecRule> GroupComponentAsync(MSFTNetIKEP2AuthSet inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetConSecRule)scope.Mapper.Create(scope, i));
        }
    }
}