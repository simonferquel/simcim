using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.StandardCimV2
{
    public struct MSFTNetEventSessionProviderAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetEventSession_Provider", "MSFT_NetEventSession", "MSFT_NetEventProvider", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetEventSessionProviderAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetEventProvider> PartComponent(MSFTNetEventSession inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetEventProvider)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetEventSession> GroupComponent(MSFTNetEventProvider inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetEventSession)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetEventProvider> PartComponentAsync(MSFTNetEventSession inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetEventProvider)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetEventSession> GroupComponentAsync(MSFTNetEventProvider inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetEventSession)scope.Mapper.Create(scope, i));
        }
    }
}