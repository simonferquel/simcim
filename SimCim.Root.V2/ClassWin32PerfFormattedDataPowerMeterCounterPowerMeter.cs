using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataPowerMeterCounterPowerMeter : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataPowerMeterCounterPowerMeter()
        {
        }

        public Win32PerfFormattedDataPowerMeterCounterPowerMeter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Power
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Power", out result);
                return result;
            }

            set
            {
                this.SetProperty("Power", value);
            }
        }

        public System.UInt32? PowerBudget
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PowerBudget", out result);
                return result;
            }

            set
            {
                this.SetProperty("PowerBudget", value);
            }
        }
    }
}