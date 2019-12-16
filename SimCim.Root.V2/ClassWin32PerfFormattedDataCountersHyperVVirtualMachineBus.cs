using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersHyperVVirtualMachineBus : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersHyperVVirtualMachineBus()
        {
        }

        public Win32PerfFormattedDataCountersHyperVVirtualMachineBus(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? InterruptsReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InterruptsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterruptsReceivedPersec", value);
            }
        }

        public System.UInt64? InterruptsSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InterruptsSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterruptsSentPersec", value);
            }
        }

        public System.UInt64? ThrottleEvents
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ThrottleEvents", out result);
                return result;
            }

            set
            {
                this.SetProperty("ThrottleEvents", value);
            }
        }
    }
}