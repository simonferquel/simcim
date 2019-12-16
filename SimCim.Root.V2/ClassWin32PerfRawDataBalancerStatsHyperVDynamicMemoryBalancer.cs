using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataBalancerStatsHyperVDynamicMemoryBalancer : Win32PerfRawData
    {
        public Win32PerfRawDataBalancerStatsHyperVDynamicMemoryBalancer()
        {
        }

        public Win32PerfRawDataBalancerStatsHyperVDynamicMemoryBalancer(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AvailableMemory
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvailableMemory", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvailableMemory", value);
            }
        }

        public System.UInt32? AvailableMemoryForBalancing
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvailableMemoryForBalancing", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvailableMemoryForBalancing", value);
            }
        }

        public System.UInt32? AveragePressure
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AveragePressure", out result);
                return result;
            }

            set
            {
                this.SetProperty("AveragePressure", value);
            }
        }

        public System.UInt32? SystemCurrentPressure
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SystemCurrentPressure", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemCurrentPressure", value);
            }
        }
    }
}