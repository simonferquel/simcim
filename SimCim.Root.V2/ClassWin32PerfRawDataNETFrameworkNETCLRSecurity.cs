using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataNETFrameworkNETCLRSecurity : Win32PerfRawData
    {
        public Win32PerfRawDataNETFrameworkNETCLRSecurity()
        {
        }

        public Win32PerfRawDataNETFrameworkNETCLRSecurity(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? NumberLinkTimeChecks
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberLinkTimeChecks", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberLinkTimeChecks", value);
            }
        }

        public System.UInt32? PercentTimeinRTchecks
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentTimeinRTchecks", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentTimeinRTchecks", value);
            }
        }

        public System.UInt32? PercentTimeinRTchecksBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentTimeinRTchecks_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentTimeinRTchecks_Base", value);
            }
        }

        public System.UInt64? PercentTimeSigAuthenticating
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentTimeSigAuthenticating", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentTimeSigAuthenticating", value);
            }
        }

        public System.UInt32? StackWalkDepth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StackWalkDepth", out result);
                return result;
            }

            set
            {
                this.SetProperty("StackWalkDepth", value);
            }
        }

        public System.UInt32? TotalRuntimeChecks
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalRuntimeChecks", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalRuntimeChecks", value);
            }
        }
    }
}