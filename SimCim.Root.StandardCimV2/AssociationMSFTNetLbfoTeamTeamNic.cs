using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.StandardCimV2
{
    public struct MSFTNetLbfoTeamTeamNicAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetLbfoTeam_TeamNic", "MSFT_NetLbfoTeam", "MSFT_NetLbfoTeamNic", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetLbfoTeamTeamNicAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetLbfoTeamNic> PartComponent(MSFTNetLbfoTeam inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetLbfoTeamNic)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetLbfoTeam> GroupComponent(MSFTNetLbfoTeamNic inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetLbfoTeam)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetLbfoTeamNic> PartComponentAsync(MSFTNetLbfoTeam inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetLbfoTeamNic)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetLbfoTeam> GroupComponentAsync(MSFTNetLbfoTeamNic inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetLbfoTeam)scope.Mapper.Create(scope, i));
        }
    }
}