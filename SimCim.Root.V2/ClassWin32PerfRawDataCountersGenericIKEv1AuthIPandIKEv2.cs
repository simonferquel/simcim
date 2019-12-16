using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersGenericIKEv1AuthIPandIKEv2 : Win32PerfRawData
    {
        public Win32PerfRawDataCountersGenericIKEv1AuthIPandIKEv2()
        {
        }

        public Win32PerfRawDataCountersGenericIKEv1AuthIPandIKEv2(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AuthIPMainModeNegotiationTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AuthIPMainModeNegotiationTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("AuthIPMainModeNegotiationTime", value);
            }
        }

        public System.UInt32? AuthIPQuickModeNegotiationTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AuthIPQuickModeNegotiationTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("AuthIPQuickModeNegotiationTime", value);
            }
        }

        public System.UInt32? ExtendedModeNegotiationTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExtendedModeNegotiationTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExtendedModeNegotiationTime", value);
            }
        }

        public System.UInt32? FailedNegotiations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FailedNegotiations", out result);
                return result;
            }

            set
            {
                this.SetProperty("FailedNegotiations", value);
            }
        }

        public System.UInt32? FailedNegotiationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FailedNegotiationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FailedNegotiationsPersec", value);
            }
        }

        public System.UInt32? IKEv1MainModeNegotiationTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IKEv1MainModeNegotiationTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("IKEv1MainModeNegotiationTime", value);
            }
        }

        public System.UInt32? IKEv1QuickModeNegotiationTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IKEv1QuickModeNegotiationTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("IKEv1QuickModeNegotiationTime", value);
            }
        }

        public System.UInt32? IKEv2MainModeNegotiationTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IKEv2MainModeNegotiationTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("IKEv2MainModeNegotiationTime", value);
            }
        }

        public System.UInt32? IKEv2QuickModeNegotiationTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IKEv2QuickModeNegotiationTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("IKEv2QuickModeNegotiationTime", value);
            }
        }

        public System.UInt32? InvalidPacketsReceivedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InvalidPacketsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InvalidPacketsReceivedPersec", value);
            }
        }

        public System.UInt32? PacketsReceivedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsReceivedPersec", value);
            }
        }

        public System.UInt32? SuccessfulNegotiations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SuccessfulNegotiations", out result);
                return result;
            }

            set
            {
                this.SetProperty("SuccessfulNegotiations", value);
            }
        }

        public System.UInt32? SuccessfulNegotiationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SuccessfulNegotiationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SuccessfulNegotiationsPersec", value);
            }
        }
    }
}