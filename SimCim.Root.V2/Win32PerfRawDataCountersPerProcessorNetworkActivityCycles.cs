using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersPerProcessorNetworkActivityCycles : Win32PerfRawData
    {
        public Win32PerfRawDataCountersPerProcessorNetworkActivityCycles()
        {
        }

        public Win32PerfRawDataCountersPerProcessorNetworkActivityCycles(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? BuildScatterGatherCyclesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BuildScatterGatherCyclesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BuildScatterGatherCyclesPersec", value);
            }
        }

        public System.UInt64? InterruptCyclesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InterruptCyclesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterruptCyclesPersec", value);
            }
        }

        public System.UInt64? InterruptDPCCyclesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InterruptDPCCyclesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterruptDPCCyclesPersec", value);
            }
        }

        public System.UInt64? InterruptDPCLatencyCyclesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InterruptDPCLatencyCyclesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterruptDPCLatencyCyclesPersec", value);
            }
        }

        public System.UInt64? MiniportReturnPacketCyclesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MiniportReturnPacketCyclesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MiniportReturnPacketCyclesPersec", value);
            }
        }

        public System.UInt64? MiniportRSSIndirectionTableChangeCycles
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MiniportRSSIndirectionTableChangeCycles", out result);
                return result;
            }

            set
            {
                this.SetProperty("MiniportRSSIndirectionTableChangeCycles", value);
            }
        }

        public System.UInt64? MiniportSendCyclesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MiniportSendCyclesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MiniportSendCyclesPersec", value);
            }
        }

        public System.UInt64? NDISReceiveIndicationCyclesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NDISReceiveIndicationCyclesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NDISReceiveIndicationCyclesPersec", value);
            }
        }

        public System.UInt64? NDISReturnPacketCyclesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NDISReturnPacketCyclesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NDISReturnPacketCyclesPersec", value);
            }
        }

        public System.UInt64? NDISSendCompleteCyclesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NDISSendCompleteCyclesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NDISSendCompleteCyclesPersec", value);
            }
        }

        public System.UInt64? NDISSendCyclesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NDISSendCyclesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NDISSendCyclesPersec", value);
            }
        }

        public System.UInt64? StackReceiveIndicationCyclesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("StackReceiveIndicationCyclesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("StackReceiveIndicationCyclesPersec", value);
            }
        }

        public System.UInt64? StackSendCompleteCyclesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("StackSendCompleteCyclesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("StackSendCompleteCyclesPersec", value);
            }
        }
    }
}