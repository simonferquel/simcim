using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchPortBandwidthSettingData : MsvmEthernetSwitchPortFeatureSettingData
    {
        public MsvmEthernetSwitchPortBandwidthSettingData()
        {
        }

        public MsvmEthernetSwitchPortBandwidthSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? BurstLimit
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BurstLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("BurstLimit", value);
            }
        }

        public System.UInt64? BurstSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BurstSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("BurstSize", value);
            }
        }

        public System.UInt64? Limit
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Limit", out result);
                return result;
            }

            set
            {
                this.SetProperty("Limit", value);
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

            set
            {
                this.SetProperty("Reservation", value);
            }
        }

        public System.UInt64? Weight
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Weight", out result);
                return result;
            }

            set
            {
                this.SetProperty("Weight", value);
            }
        }
    }
}