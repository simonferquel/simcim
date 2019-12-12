using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataGPUPerformanceCountersGPULocalAdapterMemory : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataGPUPerformanceCountersGPULocalAdapterMemory()
        {
        }

        public Win32PerfFormattedDataGPUPerformanceCountersGPULocalAdapterMemory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? LocalUsage
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LocalUsage", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalUsage", value);
            }
        }
    }
}