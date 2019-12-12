using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmMemorySettingData : CIMResourceAllocationSettingData
    {
        public MsvmMemorySettingData()
        {
        }

        public MsvmMemorySettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? DynamicMemoryEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DynamicMemoryEnabled", out result);
                return result;
            }
        }

        public System.Boolean? HugePagesEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HugePagesEnabled", out result);
                return result;
            }
        }

        public System.Boolean? IsVirtualized
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsVirtualized", out result);
                return result;
            }
        }

        public System.UInt64? MaxMemoryBlocksPerNumaNode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxMemoryBlocksPerNumaNode", out result);
                return result;
            }
        }

        public System.Boolean? SgxEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SgxEnabled", out result);
                return result;
            }
        }

        public System.String SgxLaunchControlDefault
        {
            get
            {
                System.String result;
                this.GetProperty("SgxLaunchControlDefault", out result);
                return result;
            }
        }

        public System.UInt32? SgxLaunchControlMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SgxLaunchControlMode", out result);
                return result;
            }
        }

        public System.UInt64? SgxSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SgxSize", out result);
                return result;
            }
        }

        public System.Boolean? SwapFilesInUse
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SwapFilesInUse", out result);
                return result;
            }
        }

        public System.UInt32? TargetMemoryBuffer
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TargetMemoryBuffer", out result);
                return result;
            }
        }
    }
}