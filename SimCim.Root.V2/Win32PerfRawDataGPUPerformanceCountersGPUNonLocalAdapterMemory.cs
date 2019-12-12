﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataGPUPerformanceCountersGPUNonLocalAdapterMemory : Win32PerfRawData
    {
        public Win32PerfRawDataGPUPerformanceCountersGPUNonLocalAdapterMemory()
        {
        }

        public Win32PerfRawDataGPUPerformanceCountersGPUNonLocalAdapterMemory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? NonLocalUsage
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NonLocalUsage", out result);
                return result;
            }

            set
            {
                this.SetProperty("NonLocalUsage", value);
            }
        }
    }
}