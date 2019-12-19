using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetSARuleEMAuthAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetSARuleEMAuth", "CIM_SARule", "MSFT_NetIKEP2AuthSet", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetSARuleEMAuthAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetIKEP2AuthSet> PartComponent(CIMSARule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIKEP2AuthSet)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMSARule> GroupComponent(MSFTNetIKEP2AuthSet inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSARule)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetIKEP2AuthSet> PartComponentAsync(CIMSARule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIKEP2AuthSet)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMSARule> GroupComponentAsync(MSFTNetIKEP2AuthSet inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSARule)scope.Mapper.Create(scope, i));
        }
    }
}