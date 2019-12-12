using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmGpuPartition : CIMLogicalDevice
    {
        public MsvmGpuPartition()
        {
        }

        public MsvmGpuPartition(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DeviceInstancePath
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceInstancePath", out result);
                return result;
            }
        }

        public System.UInt16? PartitionId
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PartitionId", out result);
                return result;
            }
        }

        public System.String PartitionVfLuid
        {
            get
            {
                System.String result;
                this.GetProperty("PartitionVfLuid", out result);
                return result;
            }
        }
    }
}