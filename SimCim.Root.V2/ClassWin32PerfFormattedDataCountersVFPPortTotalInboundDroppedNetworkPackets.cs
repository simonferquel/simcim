using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersVFPPortTotalInboundDroppedNetworkPackets : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersVFPPortTotalInboundDroppedNetworkPackets()
        {
        }

        public Win32PerfFormattedDataCountersVFPPortTotalInboundDroppedNetworkPackets(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? TotalInboundDroppedACLPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedACLPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedACLPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedARPFilterPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedARPFilterPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedARPFilterPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedARPGuardPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedARPGuardPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedARPGuardPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedARPLimiterPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedARPLimiterPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedARPLimiterPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedBlockedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedBlockedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedBlockedPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedBroadcastPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedBroadcastPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedBroadcastPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedDHCPGuardPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedDHCPGuardPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedDHCPGuardPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedDHCPLimiterPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedDHCPLimiterPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedDHCPLimiterPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedForwardingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedForwardingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedForwardingPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedGFTCopyPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedGFTCopyPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedGFTCopyPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedGFTExceptionPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedGFTExceptionPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedGFTExceptionPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedInvalidPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedInvalidPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedInvalidPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedInvalidRuleMatchPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedInvalidRuleMatchPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedInvalidRuleMatchPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedIPV4SpoofingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedIPV4SpoofingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedIPV4SpoofingPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedIPV6SpoofingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedIPV6SpoofingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedIPV6SpoofingPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedMACSpoofingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedMACSpoofingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedMACSpoofingPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedMalformedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedMalformedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedMalformedPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedMonitoringPingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedMonitoringPingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedMonitoringPingPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedNonIPPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedNonIPPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedNonIPPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedNoResourcePackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedNoResourcePackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedNoResourcePackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedPendingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedPendingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedPendingPackets", value);
            }
        }

        public System.UInt64? TotalInboundDroppedSimulationPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundDroppedSimulationPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundDroppedSimulationPackets", value);
            }
        }
    }
}