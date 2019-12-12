using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchHardwareOffloadData : MsvmEthernetSwitchData
    {
        public MsvmEthernetSwitchHardwareOffloadData()
        {
        }

        public MsvmEthernetSwitchHardwareOffloadData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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
        }

        public System.UInt32? DefaultQueueVmmqQueuePairs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DefaultQueueVmmqQueuePairs", out result);
                return result;
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

        public System.UInt32? IovQueuePairCapacity
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IovQueuePairCapacity", out result);
                return result;
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
        }

        public System.UInt32? IovVfCapacity
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IovVfCapacity", out result);
                return result;
            }
        }

        public System.UInt32? IovVfUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IovVfUsage", out result);
                return result;
            }
        }

        public System.UInt32? IPsecSACapacity
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPsecSACapacity", out result);
                return result;
            }
        }

        public System.UInt32? IPsecSAUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPsecSAUsage", out result);
                return result;
            }
        }

        public System.Boolean? PacketDirectInUse
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PacketDirectInUse", out result);
                return result;
            }
        }

        public System.UInt32? VmqCapacity
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VmqCapacity", out result);
                return result;
            }
        }

        public System.UInt32? VmqUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VmqUsage", out result);
                return result;
            }
        }
    }
}