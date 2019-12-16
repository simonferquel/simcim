using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersIPsecConnections : Win32PerfRawData
    {
        public Win32PerfRawDataCountersIPsecConnections()
        {
        }

        public Win32PerfRawDataCountersIPsecConnections(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Maxnumberofconnectionssinceboot
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Maxnumberofconnectionssinceboot", out result);
                return result;
            }

            set
            {
                this.SetProperty("Maxnumberofconnectionssinceboot", value);
            }
        }

        public System.UInt64? Numberoffailedauthentications
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Numberoffailedauthentications", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberoffailedauthentications", value);
            }
        }

        public System.UInt64? TotalBytesInsincestart
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalBytesInsincestart", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalBytesInsincestart", value);
            }
        }

        public System.UInt64? TotalBytesOutsincestart
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalBytesOutsincestart", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalBytesOutsincestart", value);
            }
        }

        public System.UInt32? TotalNumbercurrentConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalNumbercurrentConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalNumbercurrentConnections", value);
            }
        }

        public System.UInt64? Totalnumberofcumulativeconnectionssinceboot
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Totalnumberofcumulativeconnectionssinceboot", out result);
                return result;
            }

            set
            {
                this.SetProperty("Totalnumberofcumulativeconnectionssinceboot", value);
            }
        }
    }
}