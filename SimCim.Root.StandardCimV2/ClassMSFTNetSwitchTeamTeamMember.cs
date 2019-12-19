using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetSwitchTeamTeamMember : GenericInfrastructureObject
    {
        public MSFTNetSwitchTeamTeamMember()
        {
        }

        public MSFTNetSwitchTeamTeamMember(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public MSFTNetSwitchTeamMember MemberOfTheTeam
        {
            get
            {
                MSFTNetSwitchTeamMember result;
                this.GetInfrastructureObjectProperty("MemberOfTheTeam", out result);
                return result;
            }

            set
            {
                this.SetProperty("MemberOfTheTeam", value);
            }
        }

        public MSFTNetSwitchTeam TeamOfTheMember
        {
            get
            {
                MSFTNetSwitchTeam result;
                this.GetInfrastructureObjectProperty("TeamOfTheMember", out result);
                return result;
            }

            set
            {
                this.SetProperty("TeamOfTheMember", value);
            }
        }
    }
}