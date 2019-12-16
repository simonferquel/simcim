using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataLSMUserInputDelayperSession : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataLSMUserInputDelayperSession()
        {
        }

        public Win32PerfFormattedDataLSMUserInputDelayperSession(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? MaxInputDelay
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxInputDelay", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxInputDelay", value);
            }
        }
    }
}