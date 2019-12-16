using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataTcpipNetworkAdapter : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataTcpipNetworkAdapter()
        {
        }

        public Win32PerfFormattedDataTcpipNetworkAdapter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? BytesReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesReceivedPersec", value);
            }
        }

        public System.UInt64? BytesSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesSentPersec", value);
            }
        }

        public System.UInt64? BytesTotalPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesTotalPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesTotalPersec", value);
            }
        }

        public System.UInt64? CurrentBandwidth
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CurrentBandwidth", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentBandwidth", value);
            }
        }

        public System.UInt64? OffloadedConnections
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OffloadedConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("OffloadedConnections", value);
            }
        }

        public System.UInt64? OutputQueueLength
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutputQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutputQueueLength", value);
            }
        }

        public System.UInt64? PacketsOutboundDiscarded
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsOutboundDiscarded", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsOutboundDiscarded", value);
            }
        }

        public System.UInt64? PacketsOutboundErrors
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsOutboundErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsOutboundErrors", value);
            }
        }

        public System.UInt64? PacketsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsPersec", value);
            }
        }

        public System.UInt64? PacketsReceivedDiscarded
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsReceivedDiscarded", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsReceivedDiscarded", value);
            }
        }

        public System.UInt64? PacketsReceivedErrors
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsReceivedErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsReceivedErrors", value);
            }
        }

        public System.UInt64? PacketsReceivedNonUnicastPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsReceivedNonUnicastPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsReceivedNonUnicastPersec", value);
            }
        }

        public System.UInt64? PacketsReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsReceivedPersec", value);
            }
        }

        public System.UInt64? PacketsReceivedUnicastPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsReceivedUnicastPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsReceivedUnicastPersec", value);
            }
        }

        public System.UInt64? PacketsReceivedUnknown
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsReceivedUnknown", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsReceivedUnknown", value);
            }
        }

        public System.UInt64? PacketsSentNonUnicastPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsSentNonUnicastPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsSentNonUnicastPersec", value);
            }
        }

        public System.UInt64? PacketsSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsSentPersec", value);
            }
        }

        public System.UInt64? PacketsSentUnicastPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsSentUnicastPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsSentUnicastPersec", value);
            }
        }

        public System.UInt64? TCPActiveRSCConnections
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TCPActiveRSCConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPActiveRSCConnections", value);
            }
        }

        public System.UInt64? TCPRSCAveragePacketSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TCPRSCAveragePacketSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPRSCAveragePacketSize", value);
            }
        }

        public System.UInt64? TCPRSCCoalescedPacketsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TCPRSCCoalescedPacketsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPRSCCoalescedPacketsPersec", value);
            }
        }

        public System.UInt64? TCPRSCExceptionsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TCPRSCExceptionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPRSCExceptionsPersec", value);
            }
        }
    }
}