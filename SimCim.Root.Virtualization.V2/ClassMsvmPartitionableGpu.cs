using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmPartitionableGpu : CIMComputerSystem
    {
        public MsvmPartitionableGpu()
        {
        }

        public MsvmPartitionableGpu(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AvailableCompute
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvailableCompute", out result);
                return result;
            }
        }

        public System.UInt64? AvailableDecode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvailableDecode", out result);
                return result;
            }
        }

        public System.UInt64? AvailableEncode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvailableEncode", out result);
                return result;
            }
        }

        public System.UInt64? AvailableVRAM
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvailableVRAM", out result);
                return result;
            }
        }

        public System.UInt64? MaxPartitionCompute
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxPartitionCompute", out result);
                return result;
            }
        }

        public System.UInt64? MaxPartitionDecode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxPartitionDecode", out result);
                return result;
            }
        }

        public System.UInt64? MaxPartitionEncode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxPartitionEncode", out result);
                return result;
            }
        }

        public System.UInt64? MaxPartitionVRAM
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxPartitionVRAM", out result);
                return result;
            }
        }

        public System.UInt64? MinPartitionCompute
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MinPartitionCompute", out result);
                return result;
            }
        }

        public System.UInt64? MinPartitionDecode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MinPartitionDecode", out result);
                return result;
            }
        }

        public System.UInt64? MinPartitionEncode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MinPartitionEncode", out result);
                return result;
            }
        }

        public System.UInt64? MinPartitionVRAM
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MinPartitionVRAM", out result);
                return result;
            }
        }

        public System.UInt64? OptimalPartitionCompute
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OptimalPartitionCompute", out result);
                return result;
            }
        }

        public System.UInt64? OptimalPartitionDecode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OptimalPartitionDecode", out result);
                return result;
            }
        }

        public System.UInt64? OptimalPartitionEncode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OptimalPartitionEncode", out result);
                return result;
            }
        }

        public System.UInt64? OptimalPartitionVRAM
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OptimalPartitionVRAM", out result);
                return result;
            }
        }

        public System.UInt16? PartitionCount
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PartitionCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("PartitionCount", value);
            }
        }

        public System.UInt64? TotalCompute
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalCompute", out result);
                return result;
            }
        }

        public System.UInt64? TotalDecode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalDecode", out result);
                return result;
            }
        }

        public System.UInt64? TotalEncode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalEncode", out result);
                return result;
            }
        }

        public System.UInt64? TotalVRAM
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalVRAM", out result);
                return result;
            }
        }

        public System.UInt16[] ValidPartitionCounts
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("ValidPartitionCounts", out result);
                return result;
            }

            set
            {
                this.SetProperty("ValidPartitionCounts", value);
            }
        }
    }
}