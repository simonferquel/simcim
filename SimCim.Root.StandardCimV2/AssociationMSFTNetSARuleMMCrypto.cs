using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.StandardCimV2
{
    public struct MSFTNetSARuleMMCryptoAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetSARuleMMCrypto", "CIM_SARule", "MSFT_NetIKEMMCryptoSet", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetSARuleMMCryptoAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetIKEMMCryptoSet> PartComponent(CIMSARule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIKEMMCryptoSet)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMSARule> GroupComponent(MSFTNetIKEMMCryptoSet inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSARule)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetIKEMMCryptoSet> PartComponentAsync(CIMSARule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIKEMMCryptoSet)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMSARule> GroupComponentAsync(MSFTNetIKEMMCryptoSet inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSARule)scope.Mapper.Create(scope, i));
        }
    }
}