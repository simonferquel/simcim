using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetPolicyRuleFiltersAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetPolicyRuleFilters", "CIM_PolicyRule", "CIM_FilterEntryBase", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetPolicyRuleFiltersAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMFilterEntryBase> PartComponent(CIMPolicyRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMFilterEntryBase)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMPolicyRule> GroupComponent(CIMFilterEntryBase inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMPolicyRule)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMFilterEntryBase> PartComponentAsync(CIMPolicyRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMFilterEntryBase)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMPolicyRule> GroupComponentAsync(CIMFilterEntryBase inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMPolicyRule)scope.Mapper.Create(scope, i));
        }
    }
}