using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetLbfoTeamProviderAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetLbfoTeam_Provider", "MSFT_NetLbfoTeam", "MSFT_NetLbfoProvider", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetLbfoTeamProviderAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetLbfoProvider> PartComponent(MSFTNetLbfoTeam inGroupComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance());
            return instances.Select(i => (MSFTNetLbfoProvider)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetLbfoTeam> GroupComponent(MSFTNetLbfoProvider inPartComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance());
            return instances.Select(i => (MSFTNetLbfoTeam)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetLbfoProvider> PartComponentAsync(MSFTNetLbfoTeam inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetLbfoProvider)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetLbfoTeam> GroupComponentAsync(MSFTNetLbfoProvider inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetLbfoTeam)scope.Mapper.Create(scope, i));
        }
    }
}