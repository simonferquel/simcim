using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualEthernetSwitchBandwidthSettingData : MsvmEthernetSwitchFeatureSettingData
    {
        public MsvmVirtualEthernetSwitchBandwidthSettingData()
        {
        }

        public MsvmVirtualEthernetSwitchBandwidthSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? DefaultFlowReservation
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DefaultFlowReservation", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultFlowReservation", value);
            }
        }

        public System.UInt64? DefaultFlowWeight
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DefaultFlowWeight", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultFlowWeight", value);
            }
        }
    }
}