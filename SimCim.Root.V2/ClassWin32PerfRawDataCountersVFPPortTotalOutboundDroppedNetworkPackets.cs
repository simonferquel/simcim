using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersVFPPortTotalOutboundDroppedNetworkPackets : Win32PerfRawData
    {
        public Win32PerfRawDataCountersVFPPortTotalOutboundDroppedNetworkPackets()
        {
        }

        public Win32PerfRawDataCountersVFPPortTotalOutboundDroppedNetworkPackets(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? TotalOutboundDroppedACLPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedACLPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedACLPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedARPFilterPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedARPFilterPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedARPFilterPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedARPGuardPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedARPGuardPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedARPGuardPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedARPLimiterPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedARPLimiterPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedARPLimiterPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedBlockedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedBlockedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedBlockedPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedBroadcastPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedBroadcastPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedBroadcastPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedDHCPGuardPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedDHCPGuardPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedDHCPGuardPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedDHCPLimiterPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedDHCPLimiterPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedDHCPLimiterPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedForwardingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedForwardingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedForwardingPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedGFTCopyPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedGFTCopyPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedGFTCopyPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedGFTExceptionPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedGFTExceptionPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedGFTExceptionPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedInvalidPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedInvalidPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedInvalidPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedInvalidRuleMatchPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedInvalidRuleMatchPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedInvalidRuleMatchPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedIPV4SpoofingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedIPV4SpoofingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedIPV4SpoofingPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedIPV6SpoofingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedIPV6SpoofingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedIPV6SpoofingPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedMACSpoofingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedMACSpoofingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedMACSpoofingPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedMalformedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedMalformedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedMalformedPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedMonitoringPingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedMonitoringPingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedMonitoringPingPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedNonIPPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedNonIPPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedNonIPPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedNoResourcePackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedNoResourcePackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedNoResourcePackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedPendingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedPendingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedPendingPackets", value);
            }
        }

        public System.UInt64? TotalOutboundDroppedSimulationPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundDroppedSimulationPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundDroppedSimulationPackets", value);
            }
        }
    }
}