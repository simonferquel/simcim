using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataAuthorizationManagerAuthorizationManagerApplications : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataAuthorizationManagerAuthorizationManagerApplications()
        {
        }

        public Win32PerfFormattedDataAuthorizationManagerAuthorizationManagerApplications(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? NumberofScopesloadedinmemory
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofScopesloadedinmemory", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofScopesloadedinmemory", value);
            }
        }

        public System.UInt32? Totalnumberofscopes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Totalnumberofscopes", out result);
                return result;
            }

            set
            {
                this.SetProperty("Totalnumberofscopes", value);
            }
        }
    }
}