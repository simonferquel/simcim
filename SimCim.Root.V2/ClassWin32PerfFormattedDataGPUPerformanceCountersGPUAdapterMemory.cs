using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataGPUPerformanceCountersGPUAdapterMemory : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataGPUPerformanceCountersGPUAdapterMemory()
        {
        }

        public Win32PerfFormattedDataGPUPerformanceCountersGPUAdapterMemory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? DedicatedUsage
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DedicatedUsage", out result);
                return result;
            }

            set
            {
                this.SetProperty("DedicatedUsage", value);
            }
        }

        public System.UInt64? SharedUsage
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SharedUsage", out result);
                return result;
            }

            set
            {
                this.SetProperty("SharedUsage", value);
            }
        }

        public System.UInt64? TotalCommitted
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalCommitted", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalCommitted", value);
            }
        }
    }
}