using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersVFPQoSQueueTotalInboundNetworkTraffic : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersVFPQoSQueueTotalInboundNetworkTraffic()
        {
        }

        public Win32PerfFormattedDataCountersVFPQoSQueueTotalInboundNetworkTraffic(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? TotalInboundBytesDropped
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundBytesDropped", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundBytesDropped", value);
            }
        }

        public System.UInt64? TotalInboundPacketsDropped
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundPacketsDropped", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundPacketsDropped", value);
            }
        }
    }
}