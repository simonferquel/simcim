using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchPortOffloadSettingData : MsvmEthernetSwitchPortFeatureSettingData
    {
        public MsvmEthernetSwitchPortOffloadSettingData()
        {
        }

        public MsvmEthernetSwitchPortOffloadSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? IOVInterruptModeration
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IOVInterruptModeration", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOVInterruptModeration", value);
            }
        }

        public System.UInt32? IOVOffloadWeight
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IOVOffloadWeight", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOVOffloadWeight", value);
            }
        }

        public System.UInt32? IOVQueuePairsRequested
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IOVQueuePairsRequested", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOVQueuePairsRequested", value);
            }
        }

        public System.UInt32? IPSecOffloadLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPSecOffloadLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPSecOffloadLimit", value);
            }
        }

        public System.UInt32? PacketDirectModerationCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketDirectModerationCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketDirectModerationCount", value);
            }
        }

        public System.UInt32? PacketDirectModerationInterval
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketDirectModerationInterval", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketDirectModerationInterval", value);
            }
        }

        public System.UInt32? PacketDirectNumProcs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketDirectNumProcs", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketDirectNumProcs", value);
            }
        }

        public System.Boolean? VmmqEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VmmqEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("VmmqEnabled", value);
            }
        }

        public System.UInt32? VmmqQueuePairs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VmmqQueuePairs", out result);
                return result;
            }

            set
            {
                this.SetProperty("VmmqQueuePairs", value);
            }
        }

        public System.UInt32? VMQOffloadWeight
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VMQOffloadWeight", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMQOffloadWeight", value);
            }
        }

        public System.Boolean? VrssEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VrssEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("VrssEnabled", value);
            }
        }

        public System.Boolean? VrssExcludePrimaryProcessor
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VrssExcludePrimaryProcessor", out result);
                return result;
            }

            set
            {
                this.SetProperty("VrssExcludePrimaryProcessor", value);
            }
        }

        public System.Boolean? VrssIndependentHostSpreading
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VrssIndependentHostSpreading", out result);
                return result;
            }

            set
            {
                this.SetProperty("VrssIndependentHostSpreading", value);
            }
        }

        public System.UInt32? VrssMinQueuePairs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VrssMinQueuePairs", out result);
                return result;
            }

            set
            {
                this.SetProperty("VrssMinQueuePairs", value);
            }
        }

        public System.UInt32? VrssQueueSchedulingMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VrssQueueSchedulingMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("VrssQueueSchedulingMode", value);
            }
        }

        public System.UInt32? VrssVmbusChannelAffinityPolicy
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VrssVmbusChannelAffinityPolicy", out result);
                return result;
            }

            set
            {
                this.SetProperty("VrssVmbusChannelAffinityPolicy", value);
            }
        }
    }
}