using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersVFPQoSQueueAverageInboundNetworkTraffic : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersVFPQoSQueueAverageInboundNetworkTraffic()
        {
        }

        public Win32PerfFormattedDataCountersVFPQoSQueueAverageInboundNetworkTraffic(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AverageInboundBytesAllowedThroughtheQueue
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundBytesAllowedThroughtheQueue", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundBytesAllowedThroughtheQueue", value);
            }
        }

        public System.UInt64? AverageInboundBytesDropped
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundBytesDropped", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundBytesDropped", value);
            }
        }

        public System.UInt64? AverageInboundBytesEnteringtheQueue
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundBytesEnteringtheQueue", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundBytesEnteringtheQueue", value);
            }
        }

        public System.UInt64? AverageInboundBytesQueuedduetoBacklog
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundBytesQueuedduetoBacklog", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundBytesQueuedduetoBacklog", value);
            }
        }

        public System.UInt64? AverageInboundBytesQueuedduetoInsufficientTokens
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundBytesQueuedduetoInsufficientTokens", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundBytesQueuedduetoInsufficientTokens", value);
            }
        }

        public System.UInt64? AverageInboundBytesResumed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundBytesResumed", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundBytesResumed", value);
            }
        }

        public System.UInt64? AverageInboundPacketsAllowedThroughtheQueue
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundPacketsAllowedThroughtheQueue", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundPacketsAllowedThroughtheQueue", value);
            }
        }

        public System.UInt64? AverageInboundPacketsDropped
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundPacketsDropped", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundPacketsDropped", value);
            }
        }

        public System.UInt64? AverageInboundPacketsEnteringtheQueue
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundPacketsEnteringtheQueue", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundPacketsEnteringtheQueue", value);
            }
        }

        public System.UInt64? AverageInboundPacketsQueuedduetoBacklog
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundPacketsQueuedduetoBacklog", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundPacketsQueuedduetoBacklog", value);
            }
        }

        public System.UInt64? AverageInboundPacketsQueuedduetoInsufficientTokens
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundPacketsQueuedduetoInsufficientTokens", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundPacketsQueuedduetoInsufficientTokens", value);
            }
        }

        public System.UInt64? AverageInboundPacketsResumed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundPacketsResumed", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundPacketsResumed", value);
            }
        }
    }
}