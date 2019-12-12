using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataPerfOSProcessor : Win32PerfRawData
    {
        public Win32PerfRawDataPerfOSProcessor()
        {
        }

        public Win32PerfRawDataPerfOSProcessor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? C1TransitionsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("C1TransitionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("C1TransitionsPersec", value);
            }
        }

        public System.UInt64? C2TransitionsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("C2TransitionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("C2TransitionsPersec", value);
            }
        }

        public System.UInt64? C3TransitionsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("C3TransitionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("C3TransitionsPersec", value);
            }
        }

        public System.UInt32? DPCRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DPCRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("DPCRate", value);
            }
        }

        public System.UInt32? DPCsQueuedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DPCsQueuedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DPCsQueuedPersec", value);
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

        public System.UInt64? PercentC1Time
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentC1Time", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentC1Time", value);
            }
        }

        public System.UInt64? PercentC2Time
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentC2Time", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentC2Time", value);
            }
        }

        public System.UInt64? PercentC3Time
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentC3Time", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentC3Time", value);
            }
        }

        public System.UInt64? PercentDPCTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentDPCTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentDPCTime", value);
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

        public System.UInt64? PercentInterruptTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentInterruptTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentInterruptTime", value);
            }
        }

        public System.UInt64? PercentPrivilegedTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentPrivilegedTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentPrivilegedTime", value);
            }
        }

        public System.UInt64? PercentProcessorTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentProcessorTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentProcessorTime", value);
            }
        }

        public System.UInt64? PercentUserTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentUserTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentUserTime", value);
            }
        }
    }
}