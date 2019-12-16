using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataNvspSwitchStatsHyperVVirtualSwitch : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataNvspSwitchStatsHyperVVirtualSwitch()
        {
        }

        public Win32PerfFormattedDataNvspSwitchStatsHyperVVirtualSwitch(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt64? LearnedMacAddresses
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LearnedMacAddresses", out result);
                return result;
            }

            set
            {
                this.SetProperty("LearnedMacAddresses", value);
            }
        }

        public System.UInt64? LearnedMacAddressesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LearnedMacAddressesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LearnedMacAddressesPersec", value);
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

        public System.UInt64? NumberofSendChannelMovesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberofSendChannelMovesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofSendChannelMovesPersec", value);
            }
        }

        public System.UInt64? NumberofVMQMovesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberofVMQMovesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofVMQMovesPersec", value);
            }
        }

        public System.UInt64? PacketsFlooded
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsFlooded", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsFlooded", value);
            }
        }

        public System.UInt64? PacketsFloodedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsFloodedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsFloodedPersec", value);
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

        public System.UInt64? PurgedMacAddresses
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PurgedMacAddresses", out result);
                return result;
            }

            set
            {
                this.SetProperty("PurgedMacAddresses", value);
            }
        }

        public System.UInt64? PurgedMacAddressesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PurgedMacAddressesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PurgedMacAddressesPersec", value);
            }
        }

        public System.UInt64? RSCCoalescedBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSCCoalescedBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCCoalescedBytes", value);
            }
        }

        public System.UInt64? RSCCoalescedEventBucket10To1
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSCCoalescedEventBucket10To1", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCCoalescedEventBucket10To1", value);
            }
        }

        public System.UInt64? RSCCoalescedEventBucket22To3
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSCCoalescedEventBucket22To3", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCCoalescedEventBucket22To3", value);
            }
        }

        public System.UInt64? RSCCoalescedEventBucket34To7
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSCCoalescedEventBucket34To7", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCCoalescedEventBucket34To7", value);
            }
        }

        public System.UInt64? RSCCoalescedEventBucket48To15
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSCCoalescedEventBucket48To15", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCCoalescedEventBucket48To15", value);
            }
        }

        public System.UInt64? RSCCoalescedEventBucket516To31
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSCCoalescedEventBucket516To31", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCCoalescedEventBucket516To31", value);
            }
        }

        public System.UInt64? RSCCoalescedEventBucket632To63
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSCCoalescedEventBucket632To63", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCCoalescedEventBucket632To63", value);
            }
        }

        public System.UInt64? RSCCoalescedPacketBucket10To1
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSCCoalescedPacketBucket10To1", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCCoalescedPacketBucket10To1", value);
            }
        }

        public System.UInt64? RSCCoalescedPacketBucket22To3
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSCCoalescedPacketBucket22To3", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCCoalescedPacketBucket22To3", value);
            }
        }

        public System.UInt64? RSCCoalescedPacketBucket34To7
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSCCoalescedPacketBucket34To7", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCCoalescedPacketBucket34To7", value);
            }
        }

        public System.UInt64? RSCCoalescedPacketBucket48To15
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSCCoalescedPacketBucket48To15", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCCoalescedPacketBucket48To15", value);
            }
        }

        public System.UInt64? RSCCoalescedPacketBucket516To31
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSCCoalescedPacketBucket516To31", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCCoalescedPacketBucket516To31", value);
            }
        }

        public System.UInt64? RSCCoalescedPacketBucket632To63
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSCCoalescedPacketBucket632To63", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCCoalescedPacketBucket632To63", value);
            }
        }

        public System.UInt64? RSCCoalescedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSCCoalescedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCCoalescedPackets", value);
            }
        }

        public System.UInt64? RSCCoalesceEvents
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSCCoalesceEvents", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCCoalesceEvents", value);
            }
        }

        public System.UInt64? RSCPacketsProcessed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RSCPacketsProcessed", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCPacketsProcessed", value);
            }
        }
    }
}