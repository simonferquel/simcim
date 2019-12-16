using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmGpuPartitionSettingData : CIMResourceAllocationSettingData
    {
        public MsvmGpuPartitionSettingData()
        {
        }

        public MsvmGpuPartitionSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? MaxPartitionCompute
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxPartitionCompute", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxPartitionCompute", value);
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

            set
            {
                this.SetProperty("MaxPartitionDecode", value);
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

            set
            {
                this.SetProperty("MaxPartitionEncode", value);
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

            set
            {
                this.SetProperty("MaxPartitionVRAM", value);
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

            set
            {
                this.SetProperty("MinPartitionCompute", value);
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

            set
            {
                this.SetProperty("MinPartitionDecode", value);
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

            set
            {
                this.SetProperty("MinPartitionEncode", value);
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

            set
            {
                this.SetProperty("MinPartitionVRAM", value);
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

            set
            {
                this.SetProperty("OptimalPartitionCompute", value);
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

            set
            {
                this.SetProperty("OptimalPartitionDecode", value);
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

            set
            {
                this.SetProperty("OptimalPartitionEncode", value);
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

            set
            {
                this.SetProperty("OptimalPartitionVRAM", value);
            }
        }

        public System.String[] VirtualSystemIdentifiers
        {
            get
            {
                System.String[] result;
                this.GetProperty("VirtualSystemIdentifiers", out result);
                return result;
            }
        }
    }
}