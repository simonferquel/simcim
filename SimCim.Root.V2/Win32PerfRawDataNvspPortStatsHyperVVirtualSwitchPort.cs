using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataNvspPortStatsHyperVVirtualSwitchPort : Win32PerfRawData
    {
        public Win32PerfRawDataNvspPortStatsHyperVVirtualSwitchPort()
        {
        }

        public Win32PerfRawDataNvspPortStatsHyperVVirtualSwitchPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? BroadcastPacketsReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BroadcastPacketsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BroadcastPacketsReceivedPersec", value);
            }
        }

        public System.UInt64? BroadcastPacketsSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BroadcastPacketsSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BroadcastPacketsSentPersec", value);
            }
        }

        public System.UInt64? BytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesPersec", value);
            }
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

        public System.UInt64? DirectedPacketsReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DirectedPacketsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DirectedPacketsReceivedPersec", value);
            }
        }

        public System.UInt64? DirectedPacketsSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DirectedPacketsSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DirectedPacketsSentPersec", value);
            }
        }

        public System.UInt64? DroppedPacketsIncomingPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DroppedPacketsIncomingPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DroppedPacketsIncomingPersec", value);
            }
        }

        public System.UInt64? DroppedPacketsOutgoingPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DroppedPacketsOutgoingPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DroppedPacketsOutgoingPersec", value);
            }
        }

        public System.UInt64? ExtensionsDroppedPacketsIncomingPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ExtensionsDroppedPacketsIncomingPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExtensionsDroppedPacketsIncomingPersec", value);
            }
        }

        public System.UInt64? ExtensionsDroppedPacketsOutgoingPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ExtensionsDroppedPacketsOutgoingPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExtensionsDroppedPacketsOutgoingPersec", value);
            }
        }

        public System.UInt64? IPsecoffloadBytesReceivePersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IPsecoffloadBytesReceivePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPsecoffloadBytesReceivePersec", value);
            }
        }

        public System.UInt64? IPsecoffloadBytesSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IPsecoffloadBytesSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPsecoffloadBytesSentPersec", value);
            }
        }

        public System.UInt64? IPsecSAsOffloaded
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IPsecSAsOffloaded", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPsecSAsOffloaded", value);
            }
        }

        public System.UInt64? MulticastPacketsReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MulticastPacketsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MulticastPacketsReceivedPersec", value);
            }
        }

        public System.UInt64? MulticastPacketsSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MulticastPacketsSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MulticastPacketsSentPersec", value);
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

        public System.UInt64? UnhashedPacketsReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("UnhashedPacketsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("UnhashedPacketsReceivedPersec", value);
            }
        }

        public System.UInt64? UnhashedPacketsSendCompletedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("UnhashedPacketsSendCompletedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("UnhashedPacketsSendCompletedPersec", value);
            }
        }
    }
}