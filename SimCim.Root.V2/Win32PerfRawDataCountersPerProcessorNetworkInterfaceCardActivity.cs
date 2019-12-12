using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersPerProcessorNetworkInterfaceCardActivity : Win32PerfRawData
    {
        public Win32PerfRawDataCountersPerProcessorNetworkInterfaceCardActivity()
        {
        }

        public Win32PerfRawDataCountersPerProcessorNetworkInterfaceCardActivity(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? BuildScatterGatherListCallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BuildScatterGatherListCallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BuildScatterGatherListCallsPersec", value);
            }
        }

        public System.UInt64? DPCsDeferredPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DPCsDeferredPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DPCsDeferredPersec", value);
            }
        }

        public System.UInt64? DPCsQueuedonOtherCPUsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DPCsQueuedonOtherCPUsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DPCsQueuedonOtherCPUsPersec", value);
            }
        }

        public System.UInt64? DPCsQueuedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DPCsQueuedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DPCsQueuedPersec", value);
            }
        }

        public System.UInt64? InterruptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InterruptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterruptsPersec", value);
            }
        }

        public System.UInt64? LowResourceReceivedPacketsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LowResourceReceivedPacketsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LowResourceReceivedPacketsPersec", value);
            }
        }

        public System.UInt64? LowResourceReceiveIndicationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LowResourceReceiveIndicationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LowResourceReceiveIndicationsPersec", value);
            }
        }

        public System.UInt64? PacketsCoalescedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsCoalescedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsCoalescedPersec", value);
            }
        }

        public System.UInt64? ReceivedPacketsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceivedPacketsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedPacketsPersec", value);
            }
        }

        public System.UInt64? ReceiveIndicationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceiveIndicationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiveIndicationsPersec", value);
            }
        }

        public System.UInt64? ReturnedPacketsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReturnedPacketsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReturnedPacketsPersec", value);
            }
        }

        public System.UInt64? ReturnPacketCallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReturnPacketCallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReturnPacketCallsPersec", value);
            }
        }

        public System.UInt64? RSSIndirectionTableChangeCallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSSIndirectionTableChangeCallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSSIndirectionTableChangeCallsPersec", value);
            }
        }

        public System.UInt64? SendCompleteCallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SendCompleteCallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SendCompleteCallsPersec", value);
            }
        }

        public System.UInt64? SendRequestCallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SendRequestCallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SendRequestCallsPersec", value);
            }
        }

        public System.UInt64? SentCompletePacketsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SentCompletePacketsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentCompletePacketsPersec", value);
            }
        }

        public System.UInt64? SentPacketsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SentPacketsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentPacketsPersec", value);
            }
        }

        public System.UInt64? TcpOffloadReceivebytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TcpOffloadReceivebytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TcpOffloadReceivebytesPersec", value);
            }
        }

        public System.UInt64? TcpOffloadReceiveIndicationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TcpOffloadReceiveIndicationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TcpOffloadReceiveIndicationsPersec", value);
            }
        }

        public System.UInt64? TcpOffloadSendbytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TcpOffloadSendbytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TcpOffloadSendbytesPersec", value);
            }
        }

        public System.UInt64? TcpOffloadSendRequestCallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TcpOffloadSendRequestCallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TcpOffloadSendRequestCallsPersec", value);
            }
        }
    }
}