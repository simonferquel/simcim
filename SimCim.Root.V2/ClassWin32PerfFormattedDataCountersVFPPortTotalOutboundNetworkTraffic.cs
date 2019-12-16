using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersVFPPortTotalOutboundNetworkTraffic : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersVFPPortTotalOutboundNetworkTraffic()
        {
        }

        public Win32PerfFormattedDataCountersVFPPortTotalOutboundNetworkTraffic(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? TotalOutboundBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundBytes", value);
            }
        }

        public System.UInt64? TotalOutboundForwardedMulticastPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundForwardedMulticastPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundForwardedMulticastPackets", value);
            }
        }

        public System.UInt64? TotalOutboundForwardedUnicastPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundForwardedUnicastPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundForwardedUnicastPackets", value);
            }
        }

        public System.UInt64? TotalOutboundGFTBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundGFTBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundGFTBytes", value);
            }
        }

        public System.UInt64? TotalOutboundGFTCopyFINPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundGFTCopyFINPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundGFTCopyFINPackets", value);
            }
        }

        public System.UInt64? TotalOutboundGFTCopyPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundGFTCopyPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundGFTCopyPackets", value);
            }
        }

        public System.UInt64? TotalOutboundGFTCopyResetPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundGFTCopyResetPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundGFTCopyResetPackets", value);
            }
        }

        public System.UInt64? TotalOutboundGFTExceptionPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundGFTExceptionPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundGFTExceptionPackets", value);
            }
        }

        public System.UInt64? TotalOutboundGFTExceptionUFOffloadBlockedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundGFTExceptionUFOffloadBlockedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundGFTExceptionUFOffloadBlockedPackets", value);
            }
        }

        public System.UInt64? TotalOutboundGFTExceptionUFOffloadDeferredPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundGFTExceptionUFOffloadDeferredPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundGFTExceptionUFOffloadDeferredPackets", value);
            }
        }

        public System.UInt64? TotalOutboundGFTExceptionUFOffloadedTCPPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundGFTExceptionUFOffloadedTCPPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundGFTExceptionUFOffloadedTCPPackets", value);
            }
        }

        public System.UInt64? TotalOutboundGFTExceptionUFOffloadedUDPPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundGFTExceptionUFOffloadedUDPPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundGFTExceptionUFOffloadedUDPPackets", value);
            }
        }

        public System.UInt64? TotalOutboundGFTExceptionUFOffloadFailedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundGFTExceptionUFOffloadFailedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundGFTExceptionUFOffloadFailedPackets", value);
            }
        }

        public System.UInt64? TotalOutboundGFTExceptionUFOffloadPendingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundGFTExceptionUFOffloadPendingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundGFTExceptionUFOffloadPendingPackets", value);
            }
        }

        public System.UInt64? TotalOutboundGFTExceptionUFPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundGFTExceptionUFPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundGFTExceptionUFPackets", value);
            }
        }

        public System.UInt64? TotalOutboundGFTRetryAwaitingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundGFTRetryAwaitingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundGFTRetryAwaitingPackets", value);
            }
        }

        public System.UInt64? TotalOutboundGftTotalPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundGftTotalPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundGftTotalPackets", value);
            }
        }

        public System.UInt64? TotalOutboundHairPinnedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundHairPinnedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundHairPinnedPackets", value);
            }
        }

        public System.UInt64? TotalOutboundInterceptedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundInterceptedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundInterceptedPackets", value);
            }
        }

        public System.UInt64? TotalOutboundMissedInterceptedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundMissedInterceptedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundMissedInterceptedPackets", value);
            }
        }

        public System.UInt64? TotalOutboundNonIPPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundNonIPPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundNonIPPackets", value);
            }
        }

        public System.UInt64? TotalOutboundPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundPackets", value);
            }
        }

        public System.UInt64? TotalOutboundPendingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundPendingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundPendingPackets", value);
            }
        }

        public System.UInt64? TotalOutboundTCPSYNACKPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundTCPSYNACKPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundTCPSYNACKPackets", value);
            }
        }

        public System.UInt64? TotalOutboundTCPSYNPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundTCPSYNPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundTCPSYNPackets", value);
            }
        }

        public System.UInt64? TotalOutboundThrottledPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundThrottledPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundThrottledPackets", value);
            }
        }

        public System.UInt64? TotalOutboundUnicastForwardedGFTExceptionPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOutboundUnicastForwardedGFTExceptionPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOutboundUnicastForwardedGFTExceptionPackets", value);
            }
        }
    }
}