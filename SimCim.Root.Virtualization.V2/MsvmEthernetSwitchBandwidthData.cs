using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchBandwidthData : MsvmEthernetSwitchData
    {
        public MsvmEthernetSwitchBandwidthData()
        {
        }

        public MsvmEthernetSwitchBandwidthData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? Capacity
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Capacity", out result);
                return result;
            }
        }

        public System.UInt64? DefaultFlowReservation
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DefaultFlowReservation", out result);
                return result;
            }
        }

        public System.UInt32? DefaultFlowReservationPercentage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DefaultFlowReservationPercentage", out result);
                return result;
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
        }

        public System.UInt64? Reservation
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Reservation", out result);
                return result;
            }
        }
    }
}