using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersVFPQoSQueueAverageOutboundNetworkTraffic : Win32PerfRawData
    {
        public Win32PerfRawDataCountersVFPQoSQueueAverageOutboundNetworkTraffic()
        {
        }

        public Win32PerfRawDataCountersVFPQoSQueueAverageOutboundNetworkTraffic(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AverageOutboundBytesAllowedThroughtheQueue
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundBytesAllowedThroughtheQueue", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundBytesAllowedThroughtheQueue", value);
            }
        }

        public System.UInt64? AverageOutboundBytesDropped
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundBytesDropped", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundBytesDropped", value);
            }
        }

        public System.UInt64? AverageOutboundBytesEnteringtheQueue
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundBytesEnteringtheQueue", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundBytesEnteringtheQueue", value);
            }
        }

        public System.UInt64? AverageOutboundBytesQueuedduetoBacklog
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundBytesQueuedduetoBacklog", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundBytesQueuedduetoBacklog", value);
            }
        }

        public System.UInt64? AverageOutboundBytesQueuedduetoInsufficientTokens
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundBytesQueuedduetoInsufficientTokens", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundBytesQueuedduetoInsufficientTokens", value);
            }
        }

        public System.UInt64? AverageOutboundBytesResumed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundBytesResumed", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundBytesResumed", value);
            }
        }

        public System.UInt64? AverageOutboundPacketsAllowedThroughtheQueue
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundPacketsAllowedThroughtheQueue", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundPacketsAllowedThroughtheQueue", value);
            }
        }

        public System.UInt64? AverageOutboundPacketsDropped
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundPacketsDropped", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundPacketsDropped", value);
            }
        }

        public System.UInt64? AverageOutboundPacketsEnteringtheQueue
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundPacketsEnteringtheQueue", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundPacketsEnteringtheQueue", value);
            }
        }

        public System.UInt64? AverageOutboundPacketsQueuedduetoBacklog
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundPacketsQueuedduetoBacklog", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundPacketsQueuedduetoBacklog", value);
            }
        }

        public System.UInt64? AverageOutboundPacketsQueuedduetoInsufficientTokens
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundPacketsQueuedduetoInsufficientTokens", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundPacketsQueuedduetoInsufficientTokens", value);
            }
        }

        public System.UInt64? AverageOutboundPacketsResumed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundPacketsResumed", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundPacketsResumed", value);
            }
        }
    }
}