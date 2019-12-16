using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetLbfoTeamTeamMember : CIMComponent
    {
        public MSFTNetLbfoTeamTeamMember()
        {
        }

        public MSFTNetLbfoTeamTeamMember(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetLbfoTeam GroupComponent
        {
            get
            {
                MSFTNetLbfoTeam result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupComponent", value);
            }
        }

        public new MSFTNetLbfoTeamMember PartComponent
        {
            get
            {
                MSFTNetLbfoTeamMember result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("PartComponent", value);
            }
        }
    }
}