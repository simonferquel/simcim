using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersVFPPortTotalInboundNetworkTraffic : Win32PerfRawData
    {
        public Win32PerfRawDataCountersVFPPortTotalInboundNetworkTraffic()
        {
        }

        public Win32PerfRawDataCountersVFPPortTotalInboundNetworkTraffic(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? TotalInboundBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundBytes", value);
            }
        }

        public System.UInt64? TotalInboundForwardedMulticastPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundForwardedMulticastPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundForwardedMulticastPackets", value);
            }
        }

        public System.UInt64? TotalInboundForwardedUnicastPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundForwardedUnicastPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundForwardedUnicastPackets", value);
            }
        }

        public System.UInt64? TotalInboundGFTBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundGFTBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundGFTBytes", value);
            }
        }

        public System.UInt64? TotalInboundGFTCopyFINPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundGFTCopyFINPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundGFTCopyFINPackets", value);
            }
        }

        public System.UInt64? TotalInboundGFTCopyPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundGFTCopyPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundGFTCopyPackets", value);
            }
        }

        public System.UInt64? TotalInboundGFTCopyResetPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundGFTCopyResetPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundGFTCopyResetPackets", value);
            }
        }

        public System.UInt64? TotalInboundGFTExceptionPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundGFTExceptionPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundGFTExceptionPackets", value);
            }
        }

        public System.UInt64? TotalInboundGFTExceptionUFOffloadBlockedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundGFTExceptionUFOffloadBlockedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundGFTExceptionUFOffloadBlockedPackets", value);
            }
        }

        public System.UInt64? TotalInboundGFTExceptionUFOffloadDeferredPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundGFTExceptionUFOffloadDeferredPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundGFTExceptionUFOffloadDeferredPackets", value);
            }
        }

        public System.UInt64? TotalInboundGFTExceptionUFOffloadedTCPPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundGFTExceptionUFOffloadedTCPPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundGFTExceptionUFOffloadedTCPPackets", value);
            }
        }

        public System.UInt64? TotalInboundGFTExceptionUFOffloadedUDPPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundGFTExceptionUFOffloadedUDPPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundGFTExceptionUFOffloadedUDPPackets", value);
            }
        }

        public System.UInt64? TotalInboundGFTExceptionUFOffloadFailedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundGFTExceptionUFOffloadFailedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundGFTExceptionUFOffloadFailedPackets", value);
            }
        }

        public System.UInt64? TotalInboundGFTExceptionUFOffloadPendingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundGFTExceptionUFOffloadPendingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundGFTExceptionUFOffloadPendingPackets", value);
            }
        }

        public System.UInt64? TotalInboundGFTExceptionUFPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundGFTExceptionUFPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundGFTExceptionUFPackets", value);
            }
        }

        public System.UInt64? TotalInboundGFTExceptionUFRetryAwaitingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundGFTExceptionUFRetryAwaitingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundGFTExceptionUFRetryAwaitingPackets", value);
            }
        }

        public System.UInt64? TotalInboundGFTPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundGFTPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundGFTPackets", value);
            }
        }

        public System.UInt64? TotalInboundHairpinnedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundHairpinnedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundHairpinnedPackets", value);
            }
        }

        public System.UInt64? TotalInboundInterceptedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundInterceptedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundInterceptedPackets", value);
            }
        }

        public System.UInt64? TotalInboundMissedInterceptedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundMissedInterceptedPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundMissedInterceptedPackets", value);
            }
        }

        public System.UInt64? TotalInboundNonIPPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundNonIPPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundNonIPPackets", value);
            }
        }

        public System.UInt64? TotalInboundPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundPackets", value);
            }
        }

        public System.UInt64? TotalInboundPendingPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundPendingPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundPendingPackets", value);
            }
        }

        public System.UInt64? TotalInboundTCPSYNACKPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundTCPSYNACKPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundTCPSYNACKPackets", value);
            }
        }

        public System.UInt64? TotalInboundTCPSYNPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundTCPSYNPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundTCPSYNPackets", value);
            }
        }

        public System.UInt64? TotalInboundThrottledPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundThrottledPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundThrottledPackets", value);
            }
        }

        public System.UInt64? TotalInboundUnicastForwardedGFTExceptionPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInboundUnicastForwardedGFTExceptionPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInboundUnicastForwardedGFTExceptionPackets", value);
            }
        }
    }
}