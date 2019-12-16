using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataNvspNicVRSSStatsHyperVVirtualNetworkAdapterVRSS : Win32PerfRawData
    {
        public Win32PerfRawDataNvspNicVRSSStatsHyperVVirtualNetworkAdapterVRSS()
        {
        }

        public Win32PerfRawDataNvspNicVRSSStatsHyperVVirtualNetworkAdapterVRSS(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? PostmoveReceivePacketsPerSecond
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PostmoveReceivePacketsPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("PostmoveReceivePacketsPerSecond", value);
            }
        }

        public System.UInt64? PostmoveReceivePacketsTotal
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PostmoveReceivePacketsTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("PostmoveReceivePacketsTotal", value);
            }
        }

        public System.UInt64? PostmoveSendPacketCompletionsPerSecond
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PostmoveSendPacketCompletionsPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("PostmoveSendPacketCompletionsPerSecond", value);
            }
        }

        public System.UInt64? PostmoveSendPacketCompletionsTotal
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PostmoveSendPacketCompletionsTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("PostmoveSendPacketCompletionsTotal", value);
            }
        }

        public System.UInt64? PostmoveSendPacketsPerSecond
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PostmoveSendPacketsPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("PostmoveSendPacketsPerSecond", value);
            }
        }

        public System.UInt64? PostmoveSendPacketsTotal
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PostmoveSendPacketsTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("PostmoveSendPacketsTotal", value);
            }
        }

        public System.UInt64? ReceivePacketPerSecond
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceivePacketPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivePacketPerSecond", value);
            }
        }

        public System.UInt64? ReceivePacketTotal
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceivePacketTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivePacketTotal", value);
            }
        }

        public System.UInt32? ReceiveProcessor
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceiveProcessor", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiveProcessor", value);
            }
        }

        public System.UInt32? ReceiveProcessorGroup
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceiveProcessorGroup", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiveProcessorGroup", value);
            }
        }

        public System.UInt64? SendPacketCompletionsPerSecond
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SendPacketCompletionsPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("SendPacketCompletionsPerSecond", value);
            }
        }

        public System.UInt64? SendPacketCompletionsTotal
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SendPacketCompletionsTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("SendPacketCompletionsTotal", value);
            }
        }

        public System.UInt64? SendPacketPerSecond
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SendPacketPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("SendPacketPerSecond", value);
            }
        }

        public System.UInt64? SendPacketTotal
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SendPacketTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("SendPacketTotal", value);
            }
        }

        public System.UInt32? SendProcessor
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SendProcessor", out result);
                return result;
            }

            set
            {
                this.SetProperty("SendProcessor", value);
            }
        }

        public System.UInt32? SendProcessorGroup
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SendProcessorGroup", out result);
                return result;
            }

            set
            {
                this.SetProperty("SendProcessorGroup", value);
            }
        }
    }
}