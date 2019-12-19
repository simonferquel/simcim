using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetLbfoTeamNic : MSFTNetImPlatAdapter
    {
        public MSFTNetLbfoTeamNic()
        {
        }

        public MSFTNetLbfoTeamNic(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Default
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Default", out result);
                return result;
            }

            set
            {
                this.SetProperty("Default", value);
            }
        }

        public System.Boolean? Primary
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Primary", out result);
                return result;
            }
        }

        public System.UInt32? VlanID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VlanID", out result);
                return result;
            }

            set
            {
                this.SetProperty("VlanID", value);
            }
        }
    }
}