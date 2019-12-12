using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchPortBandwidthData : MsvmEthernetPortData
    {
        public MsvmEthernetSwitchPortBandwidthData()
        {
        }

        public MsvmEthernetSwitchPortBandwidthData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CurrentBandwidthReservationPercentage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentBandwidthReservationPercentage", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentBandwidthReservationPercentage", value);
            }
        }
    }
}