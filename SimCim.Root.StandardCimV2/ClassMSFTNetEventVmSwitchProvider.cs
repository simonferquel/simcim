using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetEventVmSwitchProvider : MSFTNetEventProviderBase
    {
        public MSFTNetEventVmSwitchProvider()
        {
        }

        public MSFTNetEventVmSwitchProvider(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32[] PortIds
        {
            get
            {
                System.UInt32[] result;
                this.GetProperty("PortIds", out result);
                return result;
            }

            set
            {
                this.SetProperty("PortIds", value);
            }
        }

        public System.String SwitchName
        {
            get
            {
                System.String result;
                this.GetProperty("SwitchName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SwitchName", value);
            }
        }
    }
}