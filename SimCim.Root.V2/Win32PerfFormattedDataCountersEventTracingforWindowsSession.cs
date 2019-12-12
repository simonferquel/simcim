using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersEventTracingforWindowsSession : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersEventTracingforWindowsSession()
        {
        }

        public Win32PerfFormattedDataCountersEventTracingforWindowsSession(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BufferMemoryUsageNonPagedPool
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BufferMemoryUsageNonPagedPool", out result);
                return result;
            }

            set
            {
                this.SetProperty("BufferMemoryUsageNonPagedPool", value);
            }
        }

        public System.UInt32? BufferMemoryUsagePagedPool
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BufferMemoryUsagePagedPool", out result);
                return result;
            }

            set
            {
                this.SetProperty("BufferMemoryUsagePagedPool", value);
            }
        }

        public System.UInt64? EventsLoggedpersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EventsLoggedpersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventsLoggedpersec", value);
            }
        }

        public System.UInt32? EventsLost
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EventsLost", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventsLost", value);
            }
        }

        public System.UInt32? NumberofRealTimeConsumers
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofRealTimeConsumers", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofRealTimeConsumers", value);
            }
        }
    }
}