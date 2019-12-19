using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetSAActionInSARuleAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetSAActionInSARule", "CIM_SARule", "CIM_SAAction", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetSAActionInSARuleAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMSAAction> PartComponent(CIMSARule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSAAction)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMSARule> GroupComponent(CIMSAAction inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSARule)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMSAAction> PartComponentAsync(CIMSARule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSAAction)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMSARule> GroupComponentAsync(CIMSAAction inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSARule)scope.Mapper.Create(scope, i));
        }
    }
}