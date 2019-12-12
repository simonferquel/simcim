using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersTeredoRelay : Win32PerfRawData
    {
        public Win32PerfRawDataCountersTeredoRelay()
        {
        }

        public Win32PerfRawDataCountersTeredoRelay(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? InTeredoRelayErrorPacketsDestinationError
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoRelayErrorPacketsDestinationError", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoRelayErrorPacketsDestinationError", value);
            }
        }

        public System.UInt32? InTeredoRelayErrorPacketsHeaderError
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoRelayErrorPacketsHeaderError", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoRelayErrorPacketsHeaderError", value);
            }
        }

        public System.UInt32? InTeredoRelayErrorPacketsSourceError
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoRelayErrorPacketsSourceError", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoRelayErrorPacketsSourceError", value);
            }
        }

        public System.UInt32? InTeredoRelayErrorPacketsTotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoRelayErrorPacketsTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoRelayErrorPacketsTotal", value);
            }
        }

        public System.UInt32? InTeredoRelaySuccessPacketsBubbles
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoRelaySuccessPacketsBubbles", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoRelaySuccessPacketsBubbles", value);
            }
        }

        public System.UInt64? InTeredoRelaySuccessPacketsDataPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InTeredoRelaySuccessPacketsDataPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoRelaySuccessPacketsDataPackets", value);
            }
        }

        public System.UInt64? InTeredoRelaySuccessPacketsDataPacketsKernelMode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InTeredoRelaySuccessPacketsDataPacketsKernelMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoRelaySuccessPacketsDataPacketsKernelMode", value);
            }
        }

        public System.UInt64? InTeredoRelaySuccessPacketsDataPacketsUserMode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InTeredoRelaySuccessPacketsDataPacketsUserMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoRelaySuccessPacketsDataPacketsUserMode", value);
            }
        }

        public System.UInt64? InTeredoRelaySuccessPacketsTotal
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InTeredoRelaySuccessPacketsTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoRelaySuccessPacketsTotal", value);
            }
        }

        public System.UInt32? InTeredoRelayTotalPacketsSuccessError
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoRelayTotalPacketsSuccessError", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoRelayTotalPacketsSuccessError", value);
            }
        }

        public System.UInt32? InTeredoRelayTotalPacketsSuccessErrorPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoRelayTotalPacketsSuccessErrorPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoRelayTotalPacketsSuccessErrorPersec", value);
            }
        }

        public System.UInt32? OutTeredoRelayErrorPackets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutTeredoRelayErrorPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoRelayErrorPackets", value);
            }
        }

        public System.UInt32? OutTeredoRelayErrorPacketsDestinationError
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutTeredoRelayErrorPacketsDestinationError", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoRelayErrorPacketsDestinationError", value);
            }
        }

        public System.UInt32? OutTeredoRelayErrorPacketsHeaderError
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutTeredoRelayErrorPacketsHeaderError", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoRelayErrorPacketsHeaderError", value);
            }
        }

        public System.UInt32? OutTeredoRelayErrorPacketsSourceError
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutTeredoRelayErrorPacketsSourceError", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoRelayErrorPacketsSourceError", value);
            }
        }

        public System.UInt64? OutTeredoRelaySuccessPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutTeredoRelaySuccessPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoRelaySuccessPackets", value);
            }
        }

        public System.UInt32? OutTeredoRelaySuccessPacketsBubbles
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutTeredoRelaySuccessPacketsBubbles", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoRelaySuccessPacketsBubbles", value);
            }
        }

        public System.UInt64? OutTeredoRelaySuccessPacketsDataPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutTeredoRelaySuccessPacketsDataPackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoRelaySuccessPacketsDataPackets", value);
            }
        }

        public System.UInt64? OutTeredoRelaySuccessPacketsDataPacketsKernelMode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutTeredoRelaySuccessPacketsDataPacketsKernelMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoRelaySuccessPacketsDataPacketsKernelMode", value);
            }
        }

        public System.UInt64? OutTeredoRelaySuccessPacketsDataPacketsUserMode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutTeredoRelaySuccessPacketsDataPacketsUserMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoRelaySuccessPacketsDataPacketsUserMode", value);
            }
        }

        public System.UInt32? OutTeredoRelayTotalPacketsSuccessError
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutTeredoRelayTotalPacketsSuccessError", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoRelayTotalPacketsSuccessError", value);
            }
        }

        public System.UInt32? OutTeredoRelayTotalPacketsSuccessErrorPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutTeredoRelayTotalPacketsSuccessErrorPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoRelayTotalPacketsSuccessErrorPersec", value);
            }
        }
    }
}