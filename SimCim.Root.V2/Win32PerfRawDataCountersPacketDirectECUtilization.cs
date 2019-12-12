using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersPacketDirectECUtilization : Win32PerfRawData
    {
        public Win32PerfRawDataCountersPacketDirectECUtilization()
        {
        }

        public Win32PerfRawDataCountersPacketDirectECUtilization(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BusyWaitIterationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BusyWaitIterationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BusyWaitIterationsPersec", value);
            }
        }

        public System.UInt32? IterationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IterationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IterationsPersec", value);
            }
        }

        public System.UInt64? PercentBusyWaitingTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentBusyWaitingTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentBusyWaitingTime", value);
            }
        }

        public System.UInt64? PercentBusyWaitingTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentBusyWaitingTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentBusyWaitingTime_Base", value);
            }
        }

        public System.UInt32? PercentBusyWaitIterations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentBusyWaitIterations", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentBusyWaitIterations", value);
            }
        }

        public System.UInt32? PercentBusyWaitIterationsBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentBusyWaitIterations_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentBusyWaitIterations_Base", value);
            }
        }

        public System.UInt64? PercentIdleTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentIdleTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentIdleTime", value);
            }
        }

        public System.UInt64? PercentIdleTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentIdleTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentIdleTime_Base", value);
            }
        }

        public System.UInt64? PercentProcessingTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentProcessingTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentProcessingTime", value);
            }
        }

        public System.UInt64? PercentProcessingTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentProcessingTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentProcessingTime_Base", value);
            }
        }

        public System.UInt32? ProcessorNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessorNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProcessorNumber", value);
            }
        }

        public System.UInt32? RXQueueCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RXQueueCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("RXQueueCount", value);
            }
        }

        public System.UInt64? TotalBusyWaitIterations
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalBusyWaitIterations", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalBusyWaitIterations", value);
            }
        }

        public System.UInt64? TotalIterations
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalIterations", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalIterations", value);
            }
        }

        public System.UInt32? TXQueueCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TXQueueCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("TXQueueCount", value);
            }
        }
    }
}