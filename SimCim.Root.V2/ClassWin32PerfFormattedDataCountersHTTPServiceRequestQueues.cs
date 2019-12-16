using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersHTTPServiceRequestQueues : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersHTTPServiceRequestQueues()
        {
        }

        public Win32PerfFormattedDataCountersHTTPServiceRequestQueues(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? ArrivalRate
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ArrivalRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("ArrivalRate", value);
            }
        }

        public System.UInt64? CacheHitRate
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CacheHitRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheHitRate", value);
            }
        }

        public System.UInt32? CurrentQueueSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentQueueSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentQueueSize", value);
            }
        }

        public System.UInt64? MaxQueueItemAge
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxQueueItemAge", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxQueueItemAge", value);
            }
        }

        public System.UInt64? RejectedRequests
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RejectedRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("RejectedRequests", value);
            }
        }

        public System.UInt64? RejectionRate
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RejectionRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("RejectionRate", value);
            }
        }
    }
}