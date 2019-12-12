using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataHvStatsHyperVHypervisorLogicalProcessor : Win32PerfRawData
    {
        public Win32PerfRawDataHvStatsHyperVHypervisorLogicalProcessor()
        {
        }

        public Win32PerfRawDataHvStatsHyperVHypervisorLogicalProcessor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt64? ContextSwitchesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ContextSwitchesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ContextSwitchesPersec", value);
            }
        }

        public System.UInt64? Frequency
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Frequency", out result);
                return result;
            }

            set
            {
                this.SetProperty("Frequency", value);
            }
        }

        public System.UInt64? HardwareInterruptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HardwareInterruptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("HardwareInterruptsPersec", value);
            }
        }

        public System.UInt64? HWPRequestMSRContextSwitchesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HWPRequestMSRContextSwitchesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("HWPRequestMSRContextSwitchesPersec", value);
            }
        }

        public System.UInt64? HypervisorBranchPredictorFlushesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HypervisorBranchPredictorFlushesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("HypervisorBranchPredictorFlushesPersec", value);
            }
        }

        public System.UInt64? HypervisorImmediateL1DataCacheFlushesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HypervisorImmediateL1DataCacheFlushesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("HypervisorImmediateL1DataCacheFlushesPersec", value);
            }
        }

        public System.UInt64? HypervisorL1DataCacheFlushesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HypervisorL1DataCacheFlushesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("HypervisorL1DataCacheFlushesPersec", value);
            }
        }

        public System.UInt64? HypervisorMicroarchitecturalBufferFlushesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HypervisorMicroarchitecturalBufferFlushesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("HypervisorMicroarchitecturalBufferFlushesPersec", value);
            }
        }

        public System.UInt64? InterProcessorInterruptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InterProcessorInterruptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterProcessorInterruptsPersec", value);
            }
        }

        public System.UInt64? InterProcessorInterruptsSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InterProcessorInterruptsSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterProcessorInterruptsSentPersec", value);
            }
        }

        public System.UInt64? MonitorTransitionCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MonitorTransitionCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("MonitorTransitionCost", value);
            }
        }

        public System.UInt64? ParkingStatus
        {
            get
            {
                System.UInt64? result;
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

        public System.UInt64? PercentC1TimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentC1Time_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentC1Time_Base", value);
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

        public System.UInt64? PercentC2TimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentC2Time_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentC2Time_Base", value);
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

        public System.UInt64? PercentC3TimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentC3Time_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentC3Time_Base", value);
            }
        }

        public System.UInt64? PercentGuestRunTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentGuestRunTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentGuestRunTime", value);
            }
        }

        public System.UInt64? PercentGuestRunTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentGuestRunTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentGuestRunTime_Base", value);
            }
        }

        public System.UInt64? PercentHypervisorRunTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentHypervisorRunTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentHypervisorRunTime", value);
            }
        }

        public System.UInt64? PercentHypervisorRunTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentHypervisorRunTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentHypervisorRunTime_Base", value);
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

        public System.UInt64? PercentofMaxFrequency
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentofMaxFrequency", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentofMaxFrequency", value);
            }
        }

        public System.UInt64? PercentTotalRunTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentTotalRunTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentTotalRunTime", value);
            }
        }

        public System.UInt64? PercentTotalRunTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentTotalRunTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentTotalRunTime_Base", value);
            }
        }

        public System.UInt64? PostedInterruptNotificationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PostedInterruptNotificationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PostedInterruptNotificationsPersec", value);
            }
        }

        public System.UInt64? ProcessorStateFlags
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProcessorStateFlags", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProcessorStateFlags", value);
            }
        }

        public System.UInt64? RootVpIndex
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RootVpIndex", out result);
                return result;
            }

            set
            {
                this.SetProperty("RootVpIndex", value);
            }
        }

        public System.UInt64? SchedulerInterruptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SchedulerInterruptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SchedulerInterruptsPersec", value);
            }
        }

        public System.UInt64? TimerInterruptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TimerInterruptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimerInterruptsPersec", value);
            }
        }

        public System.UInt64? TotalInterruptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInterruptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInterruptsPersec", value);
            }
        }
    }
}