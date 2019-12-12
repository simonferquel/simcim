using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualEthernetSwitchNicTeamingSettingData : MsvmEthernetSwitchFeatureSettingData
    {
        public MsvmVirtualEthernetSwitchNicTeamingSettingData()
        {
        }

        public MsvmVirtualEthernetSwitchNicTeamingSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? LoadBalancingAlgorithm
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LoadBalancingAlgorithm", out result);
                return result;
            }

            set
            {
                this.SetProperty("LoadBalancingAlgorithm", value);
            }
        }

        public System.UInt32? TeamingMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TeamingMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("TeamingMode", value);
            }
        }
    }
}