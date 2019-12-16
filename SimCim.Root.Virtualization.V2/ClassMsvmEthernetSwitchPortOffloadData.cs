using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchPortOffloadData : MsvmEthernetPortData
    {
        public MsvmEthernetSwitchPortOffloadData()
        {
        }

        public MsvmEthernetSwitchPortOffloadData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? IovOffloadUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IovOffloadUsage", out result);
                return result;
            }

            set
            {
                this.SetProperty("IovOffloadUsage", value);
            }
        }

        public System.UInt32? IovQueuePairUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IovQueuePairUsage", out result);
                return result;
            }

            set
            {
                this.SetProperty("IovQueuePairUsage", value);
            }
        }

        public System.Boolean? IovVfDataPathActive
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IovVfDataPathActive", out result);
                return result;
            }

            set
            {
                this.SetProperty("IovVfDataPathActive", value);
            }
        }

        public System.UInt16? IovVfId
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("IovVfId", out result);
                return result;
            }

            set
            {
                this.SetProperty("IovVfId", value);
            }
        }

        public System.UInt32? IpsecCurrentOffloadSaCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IpsecCurrentOffloadSaCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("IpsecCurrentOffloadSaCount", value);
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
        }

        public System.UInt32? VmmqQueuePairs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VmmqQueuePairs", out result);
                return result;
            }
        }

        public System.UInt32? VMQId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VMQId", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMQId", value);
            }
        }

        public System.UInt32? VMQOffloadUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VMQOffloadUsage", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMQOffloadUsage", value);
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
        }

        public System.Boolean? VrssExcludePrimaryProcessor
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VrssExcludePrimaryProcessor", out result);
                return result;
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
        }

        public System.UInt32? VrssMinQueuePairs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VrssMinQueuePairs", out result);
                return result;
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
        }

        public System.UInt32? VrssVmbusChannelAffinityPolicy
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VrssVmbusChannelAffinityPolicy", out result);
                return result;
            }
        }
    }
}