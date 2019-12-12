using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersThermalZoneInformation : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersThermalZoneInformation()
        {
        }

        public Win32PerfFormattedDataCountersThermalZoneInformation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? HighPrecisionTemperature
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HighPrecisionTemperature", out result);
                return result;
            }

            set
            {
                this.SetProperty("HighPrecisionTemperature", value);
            }
        }

        public System.UInt32? PercentPassiveLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentPassiveLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentPassiveLimit", value);
            }
        }

        public System.UInt32? Temperature
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Temperature", out result);
                return result;
            }

            set
            {
                this.SetProperty("Temperature", value);
            }
        }

        public System.UInt32? ThrottleReasons
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ThrottleReasons", out result);
                return result;
            }

            set
            {
                this.SetProperty("ThrottleReasons", value);
            }
        }
    }
}