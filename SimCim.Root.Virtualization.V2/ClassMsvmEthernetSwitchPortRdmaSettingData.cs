using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchPortRdmaSettingData : MsvmEthernetSwitchPortFeatureSettingData
    {
        public MsvmEthernetSwitchPortRdmaSettingData()
        {
        }

        public MsvmEthernetSwitchPortRdmaSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? RdmaOffloadWeight
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RdmaOffloadWeight", out result);
                return result;
            }

            set
            {
                this.SetProperty("RdmaOffloadWeight", value);
            }
        }
    }
}