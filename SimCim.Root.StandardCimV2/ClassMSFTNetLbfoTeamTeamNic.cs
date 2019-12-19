using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetLbfoTeamTeamNic : CIMComponent
    {
        public MSFTNetLbfoTeamTeamNic()
        {
        }

        public MSFTNetLbfoTeamTeamNic(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public new MSFTNetLbfoTeamNic PartComponent
        {
            get
            {
                MSFTNetLbfoTeamNic result;
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