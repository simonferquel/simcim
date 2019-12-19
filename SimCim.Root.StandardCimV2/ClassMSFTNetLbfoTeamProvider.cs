using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetLbfoTeamProvider : CIMComponent
    {
        public MSFTNetLbfoTeamProvider()
        {
        }

        public MSFTNetLbfoTeamProvider(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public new MSFTNetLbfoProvider PartComponent
        {
            get
            {
                MSFTNetLbfoProvider result;
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