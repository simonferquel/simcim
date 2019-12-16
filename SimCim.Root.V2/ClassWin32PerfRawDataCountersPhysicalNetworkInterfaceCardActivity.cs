using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersPhysicalNetworkInterfaceCardActivity : Win32PerfRawData
    {
        public Win32PerfRawDataCountersPhysicalNetworkInterfaceCardActivity()
        {
        }

        public Win32PerfRawDataCountersPhysicalNetworkInterfaceCardActivity(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? DevicePowerState
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DevicePowerState", out result);
                return result;
            }

            set
            {
                this.SetProperty("DevicePowerState", value);
            }
        }

        public System.UInt32? LowPowerTransitionsLifetime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LowPowerTransitionsLifetime", out result);
                return result;
            }

            set
            {
                this.SetProperty("LowPowerTransitionsLifetime", value);
            }
        }

        public System.UInt64? PercentTimeSuspendedInstantaneous
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentTimeSuspendedInstantaneous", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentTimeSuspendedInstantaneous", value);
            }
        }

        public System.UInt64? PercentTimeSuspendedLifetime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentTimeSuspendedLifetime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentTimeSuspendedLifetime", value);
            }
        }

        public System.UInt64? PercentTimeSuspendedLifetimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentTimeSuspendedLifetime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentTimeSuspendedLifetime_Base", value);
            }
        }
    }
}