using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersTeredoClient : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersTeredoClient()
        {
        }

        public Win32PerfFormattedDataCountersTeredoClient(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? InTeredoBubble
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoBubble", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoBubble", value);
            }
        }

        public System.UInt64? InTeredoData
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InTeredoData", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoData", value);
            }
        }

        public System.UInt64? InTeredoDataKernelMode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InTeredoDataKernelMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoDataKernelMode", value);
            }
        }

        public System.UInt64? InTeredoDataUserMode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InTeredoDataUserMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoDataUserMode", value);
            }
        }

        public System.UInt32? InTeredoInvalid
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoInvalid", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoInvalid", value);
            }
        }

        public System.UInt32? InTeredoRouterAdvertisement
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoRouterAdvertisement", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoRouterAdvertisement", value);
            }
        }

        public System.UInt32? OutTeredoBubble
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutTeredoBubble", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoBubble", value);
            }
        }

        public System.UInt64? OutTeredoData
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutTeredoData", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoData", value);
            }
        }

        public System.UInt64? OutTeredoDataKernelMode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutTeredoDataKernelMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoDataKernelMode", value);
            }
        }

        public System.UInt64? OutTeredoDataUserMode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutTeredoDataUserMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoDataUserMode", value);
            }
        }

        public System.UInt32? OutTeredoRouterSolicitation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutTeredoRouterSolicitation", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoRouterSolicitation", value);
            }
        }
    }
}