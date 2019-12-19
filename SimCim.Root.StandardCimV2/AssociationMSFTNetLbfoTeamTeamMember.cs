﻿using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.StandardCimV2
{
    public struct MSFTNetLbfoTeamTeamMemberAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetLbfoTeam_TeamMember", "MSFT_NetLbfoTeam", "MSFT_NetLbfoTeamMember", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetLbfoTeamTeamMemberAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetLbfoTeamMember> PartComponent(MSFTNetLbfoTeam inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetLbfoTeamMember)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetLbfoTeam> GroupComponent(MSFTNetLbfoTeamMember inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetLbfoTeam)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetLbfoTeamMember> PartComponentAsync(MSFTNetLbfoTeam inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetLbfoTeamMember)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetLbfoTeam> GroupComponentAsync(MSFTNetLbfoTeamMember inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetLbfoTeam)scope.Mapper.Create(scope, i));
        }
    }
}