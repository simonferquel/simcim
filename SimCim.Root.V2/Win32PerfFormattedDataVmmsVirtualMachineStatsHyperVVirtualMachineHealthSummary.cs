using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary()
        {
        }

        public Win32PerfFormattedDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? HealthCritical
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HealthCritical", out result);
                return result;
            }

            set
            {
                this.SetProperty("HealthCritical", value);
            }
        }

        public System.UInt32? HealthOk
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HealthOk", out result);
                return result;
            }

            set
            {
                this.SetProperty("HealthOk", value);
            }
        }
    }
}