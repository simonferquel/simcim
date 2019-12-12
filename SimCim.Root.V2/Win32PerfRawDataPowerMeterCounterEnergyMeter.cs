using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataPowerMeterCounterEnergyMeter : Win32PerfRawData
    {
        public Win32PerfRawDataPowerMeterCounterEnergyMeter()
        {
        }

        public Win32PerfRawDataPowerMeterCounterEnergyMeter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? Energy
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Energy", out result);
                return result;
            }

            set
            {
                this.SetProperty("Energy", value);
            }
        }

        public System.UInt64? Power
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Power", out result);
                return result;
            }

            set
            {
                this.SetProperty("Power", value);
            }
        }

        public System.UInt32? PowerBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Power_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("Power_Base", value);
            }
        }

        public System.UInt64? Time
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Time", out result);
                return result;
            }

            set
            {
                this.SetProperty("Time", value);
            }
        }
    }
}