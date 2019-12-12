using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataWinNatCountersWinNAT : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataWinNatCountersWinNAT()
        {
        }

        public Win32PerfFormattedDataWinNatCountersWinNAT(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CurrentSessionCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentSessionCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentSessionCount", value);
            }
        }

        public System.UInt32? DroppedICMPerrorpackets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DroppedICMPerrorpackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("DroppedICMPerrorpackets", value);
            }
        }

        public System.UInt32? DroppedICMPerrorpacketsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DroppedICMPerrorpacketsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DroppedICMPerrorpacketsPersec", value);
            }
        }

        public System.UInt32? DroppedPackets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DroppedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("DroppedPackets", value);
            }
        }

        public System.UInt32? DroppedPacketsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DroppedPacketsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DroppedPacketsPersec", value);
            }
        }

        public System.UInt32? InterRoutingDomainHairpinnedPackets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterRoutingDomainHairpinnedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterRoutingDomainHairpinnedPackets", value);
            }
        }

        public System.UInt32? InterRoutingDomainHairpinnedPacketsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterRoutingDomainHairpinnedPacketsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterRoutingDomainHairpinnedPacketsPersec", value);
            }
        }

        public System.UInt32? IntraRoutingDomainHairpinnedPackets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IntraRoutingDomainHairpinnedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("IntraRoutingDomainHairpinnedPackets", value);
            }
        }

        public System.UInt32? IntraRoutingDomainHairpinnedPacketsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IntraRoutingDomainHairpinnedPacketsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IntraRoutingDomainHairpinnedPacketsPersec", value);
            }
        }

        public System.UInt32? PacketsExternaltoInternal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsExternaltoInternal", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsExternaltoInternal", value);
            }
        }

        public System.UInt32? PacketsInternaltoExternal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsInternaltoExternal", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsInternaltoExternal", value);
            }
        }

        public System.UInt32? PacketsPersecExternaltoInternal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsPersecExternaltoInternal", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsPersecExternaltoInternal", value);
            }
        }

        public System.UInt32? PacketsPersecInternaltoExternal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsPersecInternaltoExternal", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsPersecInternaltoExternal", value);
            }
        }

        public System.UInt32? SessionsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionsPersec", value);
            }
        }
    }
}