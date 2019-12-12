using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersVFPPortAverageOutboundNetworkTraffic : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersVFPPortAverageOutboundNetworkTraffic()
        {
        }

        public Win32PerfFormattedDataCountersVFPPortAverageOutboundNetworkTraffic(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AverageGFTOutboundBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageGFTOutboundBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageGFTOutboundBytes", value);
            }
        }

        public System.UInt64? AverageOutboundBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundBytes", value);
            }
        }

        public System.UInt64? AverageOutboundForwardedMulticastPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundForwardedMulticastPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundForwardedMulticastPackets", value);
            }
        }

        public System.UInt64? AverageOutboundForwardedUnicastPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundForwardedUnicastPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundForwardedUnicastPackets", value);
            }
        }

        public System.UInt64? AverageOutboundGFTCopyFINPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundGFTCopyFINPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundGFTCopyFINPackets", value);
            }
        }

        public System.UInt64? AverageOutboundGFTCopyPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundGFTCopyPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundGFTCopyPackets", value);
            }
        }

        public System.UInt64? AverageOutboundGFTCopyResetPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundGFTCopyResetPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundGFTCopyResetPackets", value);
            }
        }

        public System.UInt64? AverageOutboundGFTExceptionPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundGFTExceptionPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundGFTExceptionPackets", value);
            }
        }

        public System.UInt64? AverageOutboundGFTExceptionUFOffloadBlockedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundGFTExceptionUFOffloadBlockedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundGFTExceptionUFOffloadBlockedPackets", value);
            }
        }

        public System.UInt64? AverageOutboundGFTExceptionUFOffloadDeferredPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundGFTExceptionUFOffloadDeferredPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundGFTExceptionUFOffloadDeferredPackets", value);
            }
        }

        public System.UInt64? AverageOutboundGFTExceptionUFOffloadedTCPPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundGFTExceptionUFOffloadedTCPPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundGFTExceptionUFOffloadedTCPPackets", value);
            }
        }

        public System.UInt64? AverageOutboundGFTExceptionUFOffloadedUDPPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundGFTExceptionUFOffloadedUDPPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundGFTExceptionUFOffloadedUDPPackets", value);
            }
        }

        public System.UInt64? AverageOutboundGFTExceptionUFOffloadFailedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundGFTExceptionUFOffloadFailedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundGFTExceptionUFOffloadFailedPackets", value);
            }
        }

        public System.UInt64? AverageOutboundGFTExceptionUFOffloadPendingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundGFTExceptionUFOffloadPendingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundGFTExceptionUFOffloadPendingPackets", value);
            }
        }

        public System.UInt64? AverageOutboundGFTExceptionUFOffloadRetryAwaitingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundGFTExceptionUFOffloadRetryAwaitingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundGFTExceptionUFOffloadRetryAwaitingPackets", value);
            }
        }

        public System.UInt64? AverageOutboundGFTExceptionUFPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundGFTExceptionUFPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundGFTExceptionUFPackets", value);
            }
        }

        public System.UInt64? AverageOutboundGFTPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundGFTPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundGFTPackets", value);
            }
        }

        public System.UInt64? AverageOutboundHairpinnedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundHairpinnedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundHairpinnedPackets", value);
            }
        }

        public System.UInt64? AverageOutboundInterceptedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundInterceptedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundInterceptedPackets", value);
            }
        }

        public System.UInt64? AverageOutboundMissedInterceptedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundMissedInterceptedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundMissedInterceptedPackets", value);
            }
        }

        public System.UInt64? AverageOutboundNonIPPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundNonIPPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundNonIPPackets", value);
            }
        }

        public System.UInt64? AverageOutboundPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundPackets", value);
            }
        }

        public System.UInt64? AverageOutboundPendingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundPendingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundPendingPackets", value);
            }
        }

        public System.UInt64? AverageOutboundTCPSYNACKPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundTCPSYNACKPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundTCPSYNACKPackets", value);
            }
        }

        public System.UInt64? AverageOutboundTCPSYNPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundTCPSYNPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundTCPSYNPackets", value);
            }
        }

        public System.UInt64? AverageOutboundThrottledPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundThrottledPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundThrottledPackets", value);
            }
        }

        public System.UInt64? AverageOutboundUnicastForwardedGFTExceptionPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageOutboundUnicastForwardedGFTExceptionPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageOutboundUnicastForwardedGFTExceptionPackets", value);
            }
        }
    }
}