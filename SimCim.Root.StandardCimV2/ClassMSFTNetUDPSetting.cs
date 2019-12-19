using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetUDPSetting : CIMPolicyAction
    {
        public MSFTNetUDPSetting()
        {
        }

        public MSFTNetUDPSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? DynamicPortRangeNumberOfPorts
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DynamicPortRangeNumberOfPorts", out result);
                return result;
            }

            set
            {
                this.SetProperty("DynamicPortRangeNumberOfPorts", value);
            }
        }

        public System.UInt16? DynamicPortRangeStartPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DynamicPortRangeStartPort", out result);
                return result;
            }

            set
            {
                this.SetProperty("DynamicPortRangeStartPort", value);
            }
        }
    }
}