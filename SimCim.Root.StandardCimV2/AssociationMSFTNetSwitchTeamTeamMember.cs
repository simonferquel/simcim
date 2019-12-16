using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetSwitchTeamTeamMemberAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetSwitchTeam_TeamMember", "MSFT_NetSwitchTeamMember", "MSFT_NetSwitchTeam", "MemberOfTheTeam", "TeamOfTheMember");
        private IInfrastructureObjectScope _scope;
        public MSFTNetSwitchTeamTeamMemberAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetSwitchTeam> TeamOfTheMember(MSFTNetSwitchTeamMember inMemberOfTheTeam)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inMemberOfTheTeam.AsCimInstance());
            return instances.Select(i => (MSFTNetSwitchTeam)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetSwitchTeamMember> MemberOfTheTeam(MSFTNetSwitchTeam inTeamOfTheMember)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inTeamOfTheMember.AsCimInstance());
            return instances.Select(i => (MSFTNetSwitchTeamMember)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetSwitchTeam> TeamOfTheMemberAsync(MSFTNetSwitchTeamMember inMemberOfTheTeam, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inMemberOfTheTeam.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetSwitchTeam)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetSwitchTeamMember> MemberOfTheTeamAsync(MSFTNetSwitchTeam inTeamOfTheMember, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inTeamOfTheMember.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetSwitchTeamMember)scope.Mapper.Create(scope, i));
        }
    }
}