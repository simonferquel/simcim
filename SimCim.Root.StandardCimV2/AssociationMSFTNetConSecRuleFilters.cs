using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.StandardCimV2
{
    public struct MSFTNetConSecRuleFiltersAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetConSecRuleFilters", "MSFT_NetConSecRule", "CIM_FilterEntryBase", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetConSecRuleFiltersAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMFilterEntryBase> PartComponent(MSFTNetConSecRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMFilterEntryBase)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetConSecRule> GroupComponent(CIMFilterEntryBase inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetConSecRule)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMFilterEntryBase> PartComponentAsync(MSFTNetConSecRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMFilterEntryBase)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetConSecRule> GroupComponentAsync(CIMFilterEntryBase inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetConSecRule)scope.Mapper.Create(scope, i));
        }
    }
}