using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersProcessorInformation : Win32PerfRawData
    {
        public Win32PerfRawDataCountersProcessorInformation()
        {
        }

        public Win32PerfRawDataCountersProcessorInformation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AverageIdleTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageIdleTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageIdleTime", value);
            }
        }

        public System.UInt64? AverageIdleTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageIdleTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageIdleTime_Base", value);
            }
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

        public System.UInt32? ClockInterruptsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ClockInterruptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClockInterruptsPersec", value);
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

        public System.UInt64? IdleBreakEventsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IdleBreakEventsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IdleBreakEventsPersec", value);
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

        public System.UInt32? ParkingStatus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ParkingStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("ParkingStatus", value);
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

        public System.UInt32? PercentofMaximumFrequency
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentofMaximumFrequency", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentofMaximumFrequency", value);
            }
        }

        public System.UInt32? PercentPerformanceLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentPerformanceLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentPerformanceLimit", value);
            }
        }

        public System.UInt64? PercentPriorityTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentPriorityTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentPriorityTime", value);
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

        public System.UInt64? PercentPrivilegedUtility
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentPrivilegedUtility", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentPrivilegedUtility", value);
            }
        }

        public System.UInt32? PercentPrivilegedUtilityBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentPrivilegedUtility_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentPrivilegedUtility_Base", value);
            }
        }

        public System.UInt64? PercentProcessorPerformance
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentProcessorPerformance", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentProcessorPerformance", value);
            }
        }

        public System.UInt32? PercentProcessorPerformanceBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentProcessorPerformance_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentProcessorPerformance_Base", value);
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

        public System.UInt64? PercentProcessorUtility
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentProcessorUtility", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentProcessorUtility", value);
            }
        }

        public System.UInt32? PercentProcessorUtilityBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentProcessorUtility_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentProcessorUtility_Base", value);
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

        public System.UInt32? PerformanceLimitFlags
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PerformanceLimitFlags", out result);
                return result;
            }

            set
            {
                this.SetProperty("PerformanceLimitFlags", value);
            }
        }

        public System.UInt32? ProcessorFrequency
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessorFrequency", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProcessorFrequency", value);
            }
        }

        public System.UInt32? ProcessorStateFlags
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessorStateFlags", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProcessorStateFlags", value);
            }
        }
    }
}