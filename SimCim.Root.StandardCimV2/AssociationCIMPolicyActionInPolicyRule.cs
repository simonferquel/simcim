using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct CIMPolicyActionInPolicyRuleAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("CIM_PolicyActionInPolicyRule", "CIM_PolicyRule", "CIM_PolicyAction", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public CIMPolicyActionInPolicyRuleAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMPolicyAction> PartComponent(CIMPolicyRule inGroupComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance());
            return instances.Select(i => (CIMPolicyAction)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMPolicyRule> GroupComponent(CIMPolicyAction inPartComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance());
            return instances.Select(i => (CIMPolicyRule)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMPolicyAction> PartComponentAsync(CIMPolicyRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMPolicyAction)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMPolicyRule> GroupComponentAsync(CIMPolicyAction inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMPolicyRule)scope.Mapper.Create(scope, i));
        }
    }
}