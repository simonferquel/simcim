using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersXHCIInterrupter : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersXHCIInterrupter()
        {
        }

        public Win32PerfFormattedDataCountersXHCIInterrupter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? DpcRequeueCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DpcRequeueCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("DpcRequeueCount", value);
            }
        }

        public System.UInt32? DPCsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DPCsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DPCsPersec", value);
            }
        }

        public System.UInt32? EventRingFullCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EventRingFullCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventRingFullCount", value);
            }
        }

        public System.UInt64? EventsprocessedDPC
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EventsprocessedDPC", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventsprocessedDPC", value);
            }
        }

        public System.UInt32? InterruptsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterruptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterruptsPersec", value);
            }
        }
    }
}