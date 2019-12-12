using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersPacketDirectQueueDepth : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersPacketDirectQueueDepth()
        {
        }

        public Win32PerfFormattedDataCountersPacketDirectQueueDepth(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AverageQueueDepth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AverageQueueDepth", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageQueueDepth", value);
            }
        }

        public System.UInt32? PercentAverageQueueUtilization
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentAverageQueueUtilization", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentAverageQueueUtilization", value);
            }
        }
    }
}