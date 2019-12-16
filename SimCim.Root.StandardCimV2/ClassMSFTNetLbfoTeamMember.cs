using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetLbfoTeamMember : MSFTNetImPlatAdapter
    {
        public MSFTNetLbfoTeamMember()
        {
        }

        public MSFTNetLbfoTeamMember(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AdministrativeMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AdministrativeMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("AdministrativeMode", value);
            }
        }

        public System.UInt32? OperationalMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OperationalMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("OperationalMode", value);
            }
        }
    }
}