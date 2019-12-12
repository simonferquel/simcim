using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataTapiSrvTelephony : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataTapiSrvTelephony()
        {
        }

        public Win32PerfFormattedDataTapiSrvTelephony(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActiveLines
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveLines", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveLines", value);
            }
        }

        public System.UInt32? ActiveTelephones
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveTelephones", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveTelephones", value);
            }
        }

        public System.UInt32? ClientApps
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ClientApps", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClientApps", value);
            }
        }

        public System.UInt32? CurrentIncomingCalls
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentIncomingCalls", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentIncomingCalls", value);
            }
        }

        public System.UInt32? CurrentOutgoingCalls
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentOutgoingCalls", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentOutgoingCalls", value);
            }
        }

        public System.UInt32? IncomingCallsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IncomingCallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingCallsPersec", value);
            }
        }

        public System.UInt32? Lines
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Lines", out result);
                return result;
            }

            set
            {
                this.SetProperty("Lines", value);
            }
        }

        public System.UInt32? OutgoingcallsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutgoingcallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingcallsPersec", value);
            }
        }

        public System.UInt32? TelephoneDevices
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TelephoneDevices", out result);
                return result;
            }

            set
            {
                this.SetProperty("TelephoneDevices", value);
            }
        }
    }
}