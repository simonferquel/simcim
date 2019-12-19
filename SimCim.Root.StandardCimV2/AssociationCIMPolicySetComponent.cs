using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct CIMPolicySetComponentAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("CIM_PolicySetComponent", "CIM_PolicySet", "CIM_PolicySet", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public CIMPolicySetComponentAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMPolicySet> PartComponent(CIMPolicySet inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMPolicySet)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMPolicySet> GroupComponent(CIMPolicySet inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMPolicySet)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMPolicySet> PartComponentAsync(CIMPolicySet inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMPolicySet)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMPolicySet> GroupComponentAsync(CIMPolicySet inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMPolicySet)scope.Mapper.Create(scope, i));
        }
    }
}