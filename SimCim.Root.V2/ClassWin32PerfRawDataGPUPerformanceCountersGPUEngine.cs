﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataGPUPerformanceCountersGPUEngine : Win32PerfRawData
    {
        public Win32PerfRawDataGPUPerformanceCountersGPUEngine()
        {
        }

        public Win32PerfRawDataGPUPerformanceCountersGPUEngine(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? RunningTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RunningTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("RunningTime", value);
            }
        }

        public System.UInt64? UtilizationPercentage
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("UtilizationPercentage", out result);
                return result;
            }

            set
            {
                this.SetProperty("UtilizationPercentage", value);
            }
        }
    }
}