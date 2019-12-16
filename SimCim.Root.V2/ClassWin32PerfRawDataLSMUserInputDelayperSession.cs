using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataLSMUserInputDelayperSession : Win32PerfRawData
    {
        public Win32PerfRawDataLSMUserInputDelayperSession()
        {
        }

        public Win32PerfRawDataLSMUserInputDelayperSession(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt32? MaxInputDelayBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxInputDelay_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxInputDelay_Base", value);
            }
        }
    }
}