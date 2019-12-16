using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersVFPQoSQueueTotalOutboundNetworkTraffic : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersVFPQoSQueueTotalOutboundNetworkTraffic()
        {
        }

        public Win32PerfFormattedDataCountersVFPQoSQueueTotalOutboundNetworkTraffic(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? TotalOutboundBytesDropped
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundBytesDropped", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundBytesDropped", value);
            }
        }

        public System.UInt64? TotalOutboundPacketsDropped
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundPacketsDropped", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundPacketsDropped", value);
            }
        }
    }
}