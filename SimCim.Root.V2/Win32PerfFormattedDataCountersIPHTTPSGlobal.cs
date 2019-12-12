using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersIPHTTPSGlobal : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersIPHTTPSGlobal()
        {
        }

        public Win32PerfFormattedDataCountersIPHTTPSGlobal(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? DropsNeighborresolutiontimeouts
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DropsNeighborresolutiontimeouts", out result);
                return result;
            }

            set
            {
                this.SetProperty("DropsNeighborresolutiontimeouts", value);
            }
        }

        public System.UInt64? ErrorsAuthenticationErrors
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ErrorsAuthenticationErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorsAuthenticationErrors", value);
            }
        }

        public System.UInt64? ErrorsReceiveerrorsontheserver
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ErrorsReceiveerrorsontheserver", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorsReceiveerrorsontheserver", value);
            }
        }

        public System.UInt64? ErrorsTransmiterrorsontheserver
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ErrorsTransmiterrorsontheserver", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorsTransmiterrorsontheserver", value);
            }
        }

        public System.UInt64? InTotalbytesreceived
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InTotalbytesreceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTotalbytesreceived", value);
            }
        }

        public System.UInt64? InTotalpacketsreceived
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InTotalpacketsreceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTotalpacketsreceived", value);
            }
        }

        public System.UInt64? OutTotalbytesforwarded
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutTotalbytesforwarded", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTotalbytesforwarded", value);
            }
        }

        public System.UInt64? OutTotalbytessent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutTotalbytessent", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTotalbytessent", value);
            }
        }

        public System.UInt64? OutTotalpacketssent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutTotalpacketssent", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTotalpacketssent", value);
            }
        }

        public System.UInt64? SessionsTotalsessions
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SessionsTotalsessions", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionsTotalsessions", value);
            }
        }
    }
}