using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersIPsecDriver : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersIPsecDriver()
        {
        }

        public Win32PerfFormattedDataCountersIPsecDriver(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActiveSecurityAssociations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveSecurityAssociations", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveSecurityAssociations", value);
            }
        }

        public System.UInt32? BytesReceivedinTransportModePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BytesReceivedinTransportModePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesReceivedinTransportModePersec", value);
            }
        }

        public System.UInt32? BytesReceivedinTunnelModePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BytesReceivedinTunnelModePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesReceivedinTunnelModePersec", value);
            }
        }

        public System.UInt32? BytesSentinTransportModePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BytesSentinTransportModePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesSentinTransportModePersec", value);
            }
        }

        public System.UInt32? BytesSentinTunnelModePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BytesSentinTunnelModePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesSentinTunnelModePersec", value);
            }
        }

        public System.UInt32? InboundPacketsDroppedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InboundPacketsDroppedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InboundPacketsDroppedPersec", value);
            }
        }

        public System.UInt32? InboundPacketsReceivedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InboundPacketsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InboundPacketsReceivedPersec", value);
            }
        }

        public System.UInt32? IncorrectSPIPackets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IncorrectSPIPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncorrectSPIPackets", value);
            }
        }

        public System.UInt32? IncorrectSPIPacketsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IncorrectSPIPacketsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncorrectSPIPacketsPersec", value);
            }
        }

        public System.UInt32? OffloadedBytesReceivedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OffloadedBytesReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("OffloadedBytesReceivedPersec", value);
            }
        }

        public System.UInt32? OffloadedBytesSentPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OffloadedBytesSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("OffloadedBytesSentPersec", value);
            }
        }

        public System.UInt32? OffloadedSecurityAssociations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OffloadedSecurityAssociations", out result);
                return result;
            }

            set
            {
                this.SetProperty("OffloadedSecurityAssociations", value);
            }
        }

        public System.UInt32? PacketsNotAuthenticated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsNotAuthenticated", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsNotAuthenticated", value);
            }
        }

        public System.UInt32? PacketsNotAuthenticatedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsNotAuthenticatedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsNotAuthenticatedPersec", value);
            }
        }

        public System.UInt32? PacketsNotDecrypted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsNotDecrypted", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsNotDecrypted", value);
            }
        }

        public System.UInt32? PacketsNotDecryptedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsNotDecryptedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsNotDecryptedPersec", value);
            }
        }

        public System.UInt32? PacketsReceivedOverWrongSA
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsReceivedOverWrongSA", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsReceivedOverWrongSA", value);
            }
        }

        public System.UInt32? PacketsReceivedOverWrongSAPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsReceivedOverWrongSAPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsReceivedOverWrongSAPersec", value);
            }
        }

        public System.UInt32? PacketsThatFailedESPValidation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsThatFailedESPValidation", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsThatFailedESPValidation", value);
            }
        }

        public System.UInt32? PacketsThatFailedESPValidationPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsThatFailedESPValidationPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsThatFailedESPValidationPersec", value);
            }
        }

        public System.UInt32? PacketsThatFailedReplayDetection
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsThatFailedReplayDetection", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsThatFailedReplayDetection", value);
            }
        }

        public System.UInt32? PacketsThatFailedReplayDetectionPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsThatFailedReplayDetectionPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsThatFailedReplayDetectionPersec", value);
            }
        }

        public System.UInt32? PacketsThatFailedUDPESPValidation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsThatFailedUDPESPValidation", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsThatFailedUDPESPValidation", value);
            }
        }

        public System.UInt32? PacketsThatFailedUDPESPValidationPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsThatFailedUDPESPValidationPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsThatFailedUDPESPValidationPersec", value);
            }
        }

        public System.UInt32? PendingSecurityAssociations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PendingSecurityAssociations", out result);
                return result;
            }

            set
            {
                this.SetProperty("PendingSecurityAssociations", value);
            }
        }

        public System.UInt32? PlaintextPacketsReceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PlaintextPacketsReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("PlaintextPacketsReceived", value);
            }
        }

        public System.UInt32? PlaintextPacketsReceivedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PlaintextPacketsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PlaintextPacketsReceivedPersec", value);
            }
        }

        public System.UInt32? SARekeys
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SARekeys", out result);
                return result;
            }

            set
            {
                this.SetProperty("SARekeys", value);
            }
        }

        public System.UInt32? SecurityAssociationsAdded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SecurityAssociationsAdded", out result);
                return result;
            }

            set
            {
                this.SetProperty("SecurityAssociationsAdded", value);
            }
        }

        public System.UInt32? TotalInboundPacketsDropped
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalInboundPacketsDropped", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundPacketsDropped", value);
            }
        }

        public System.UInt32? TotalInboundPacketsReceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalInboundPacketsReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundPacketsReceived", value);
            }
        }
    }
}