using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersEventLog : Win32PerfRawData
    {
        public Win32PerfRawDataCountersEventLog()
        {
        }

        public Win32PerfRawDataCountersEventLog(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Activesubscriptions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Activesubscriptions", out result);
                return result;
            }

            set
            {
                this.SetProperty("Activesubscriptions", value);
            }
        }

        public System.UInt64? ELFRPCcallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ELFRPCcallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ELFRPCcallsPersec", value);
            }
        }

        public System.UInt32? EnabledChannels
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EnabledChannels", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnabledChannels", value);
            }
        }

        public System.UInt64? EventfilteroperationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EventfilteroperationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventfilteroperationsPersec", value);
            }
        }

        public System.UInt64? EventsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EventsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventsPersec", value);
            }
        }

        public System.UInt64? WEVTRPCcallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WEVTRPCcallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WEVTRPCcallsPersec", value);
            }
        }
    }
}