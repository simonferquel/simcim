using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataLsaSecurityPerProcessStatistics : Win32PerfRawData
    {
        public Win32PerfRawDataLsaSecurityPerProcessStatistics()
        {
        }

        public Win32PerfRawDataLsaSecurityPerProcessStatistics(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ContextHandles
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ContextHandles", out result);
                return result;
            }

            set
            {
                this.SetProperty("ContextHandles", value);
            }
        }

        public System.UInt32? CredentialHandles
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CredentialHandles", out result);
                return result;
            }

            set
            {
                this.SetProperty("CredentialHandles", value);
            }
        }
    }
}