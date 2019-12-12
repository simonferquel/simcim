using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchHardwareOffloadSettingData : MsvmEthernetSwitchFeatureSettingData
    {
        public MsvmEthernetSwitchHardwareOffloadSettingData()
        {
        }

        public MsvmEthernetSwitchHardwareOffloadSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? DefaultQueueVmmqEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DefaultQueueVmmqEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultQueueVmmqEnabled", value);
            }
        }

        public System.UInt32? DefaultQueueVmmqQueuePairs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DefaultQueueVmmqQueuePairs", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultQueueVmmqQueuePairs", value);
            }
        }

        public System.Boolean? DefaultQueueVrssEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DefaultQueueVrssEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultQueueVrssEnabled", value);
            }
        }

        public System.Boolean? DefaultQueueVrssExcludePrimaryProcessor
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DefaultQueueVrssExcludePrimaryProcessor", out result);
                return result;
            }
        }

        public System.Boolean? DefaultQueueVrssIndependentHostSpreading
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DefaultQueueVrssIndependentHostSpreading", out result);
                return result;
            }
        }

        public System.UInt32? DefaultQueueVrssMinQueuePairs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DefaultQueueVrssMinQueuePairs", out result);
                return result;
            }
        }

        public System.UInt32? DefaultQueueVrssQueueSchedulingMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DefaultQueueVrssQueueSchedulingMode", out result);
                return result;
            }
        }

        public System.Boolean? SoftwareRscEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SoftwareRscEnabled", out result);
                return result;
            }
        }
    }
}