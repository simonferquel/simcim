using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataVidPerfProviderHyperVVMVidPartition : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataVidPerfProviderHyperVVMVidPartition()
        {
        }

        public Win32PerfFormattedDataVidPerfProviderHyperVVMVidPartition(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? PhysicalPagesAllocated
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PhysicalPagesAllocated", out result);
                return result;
            }

            set
            {
                this.SetProperty("PhysicalPagesAllocated", value);
            }
        }

        public System.UInt64? PreferredNUMANodeIndex
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PreferredNUMANodeIndex", out result);
                return result;
            }

            set
            {
                this.SetProperty("PreferredNUMANodeIndex", value);
            }
        }

        public System.UInt64? RemotePhysicalPages
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RemotePhysicalPages", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemotePhysicalPages", value);
            }
        }
    }
}