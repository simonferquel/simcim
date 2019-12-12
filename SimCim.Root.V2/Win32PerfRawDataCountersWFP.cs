using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersWFP : Win32PerfRawData
    {
        public Win32PerfRawDataCountersWFP()
        {
        }

        public Win32PerfRawDataCountersWFP(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ProviderCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProviderCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderCount", value);
            }
        }
    }
}