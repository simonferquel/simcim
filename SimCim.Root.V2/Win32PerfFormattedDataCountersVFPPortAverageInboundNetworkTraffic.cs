using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersVFPPortAverageInboundNetworkTraffic : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersVFPPortAverageInboundNetworkTraffic()
        {
        }

        public Win32PerfFormattedDataCountersVFPPortAverageInboundNetworkTraffic(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AverageInboundBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundBytes", value);
            }
        }

        public System.UInt64? AverageInboundForwardedMulticastPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundForwardedMulticastPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundForwardedMulticastPackets", value);
            }
        }

        public System.UInt64? AverageInboundForwardedUnicastPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundForwardedUnicastPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundForwardedUnicastPackets", value);
            }
        }

        public System.UInt64? AverageInboundGFTCopyFINPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundGFTCopyFINPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundGFTCopyFINPackets", value);
            }
        }

        public System.UInt64? AverageInboundGFTCopyPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundGFTCopyPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundGFTCopyPackets", value);
            }
        }

        public System.UInt64? AverageInboundGFTCopyResetPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundGFTCopyResetPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundGFTCopyResetPackets", value);
            }
        }

        public System.UInt64? AverageInboundGFTExceptionPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundGFTExceptionPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundGFTExceptionPackets", value);
            }
        }

        public System.UInt64? AverageInboundGFTExceptionUFOffloadBlockedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundGFTExceptionUFOffloadBlockedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundGFTExceptionUFOffloadBlockedPackets", value);
            }
        }

        public System.UInt64? AverageInboundGFTExceptionUFOffloadDeferredPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundGFTExceptionUFOffloadDeferredPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundGFTExceptionUFOffloadDeferredPackets", value);
            }
        }

        public System.UInt64? AverageInboundGFTExceptionUFOffloadedTCPPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundGFTExceptionUFOffloadedTCPPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundGFTExceptionUFOffloadedTCPPackets", value);
            }
        }

        public System.UInt64? AverageInboundGFTExceptionUFOffloadedUDPPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundGFTExceptionUFOffloadedUDPPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundGFTExceptionUFOffloadedUDPPackets", value);
            }
        }

        public System.UInt64? AverageInboundGFTExceptionUFOffloadFailedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundGFTExceptionUFOffloadFailedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundGFTExceptionUFOffloadFailedPackets", value);
            }
        }

        public System.UInt64? AverageInboundGFTExceptionUFOffloadPendingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundGFTExceptionUFOffloadPendingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundGFTExceptionUFOffloadPendingPackets", value);
            }
        }

        public System.UInt64? AverageInboundGFTExceptionUFOffloadRetryAwaitingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundGFTExceptionUFOffloadRetryAwaitingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundGFTExceptionUFOffloadRetryAwaitingPackets", value);
            }
        }

        public System.UInt64? AverageInboundGFTExceptionUFPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundGFTExceptionUFPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundGFTExceptionUFPackets", value);
            }
        }

        public System.UInt64? AverageInboundGFTTotalBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundGFTTotalBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundGFTTotalBytes", value);
            }
        }

        public System.UInt64? AverageInboundGFTTotalPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundGFTTotalPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundGFTTotalPackets", value);
            }
        }

        public System.UInt64? AverageInboundHairPinnedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundHairPinnedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundHairPinnedPackets", value);
            }
        }

        public System.UInt64? AverageInboundInterceptedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundInterceptedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundInterceptedPackets", value);
            }
        }

        public System.UInt64? AverageInboundMissedInterceptedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundMissedInterceptedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundMissedInterceptedPackets", value);
            }
        }

        public System.UInt64? AverageInboundNonIPPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundNonIPPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundNonIPPackets", value);
            }
        }

        public System.UInt64? AverageInboundPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundPackets", value);
            }
        }

        public System.UInt64? AverageInboundPendingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundPendingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundPendingPackets", value);
            }
        }

        public System.UInt64? AverageInboundTCPSYNACKPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundTCPSYNACKPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundTCPSYNACKPackets", value);
            }
        }

        public System.UInt64? AverageInboundTCPSYNPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundTCPSYNPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundTCPSYNPackets", value);
            }
        }

        public System.UInt64? AverageInboundThrottledPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundThrottledPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundThrottledPackets", value);
            }
        }

        public System.UInt64? AverageInboundUnicastForwardedGFTExceptionPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageInboundUnicastForwardedGFTExceptionPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageInboundUnicastForwardedGFTExceptionPackets", value);
            }
        }
    }
}