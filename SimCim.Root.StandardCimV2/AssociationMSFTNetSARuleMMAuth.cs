using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetSARuleMMAuthAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetSARuleMMAuth", "CIM_SARule", "MSFT_NetIKEP1AuthSet", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetSARuleMMAuthAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetIKEP1AuthSet> PartComponent(CIMSARule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIKEP1AuthSet)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMSARule> GroupComponent(MSFTNetIKEP1AuthSet inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSARule)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetIKEP1AuthSet> PartComponentAsync(CIMSARule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIKEP1AuthSet)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMSARule> GroupComponentAsync(MSFTNetIKEP1AuthSet inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSARule)scope.Mapper.Create(scope, i));
        }
    }
}