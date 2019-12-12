using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersHyperVDynamicMemoryIntegrationService : Win32PerfRawData
    {
        public Win32PerfRawDataCountersHyperVDynamicMemoryIntegrationService()
        {
        }

        public Win32PerfRawDataCountersHyperVDynamicMemoryIntegrationService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? MaximumMemoryMbytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaximumMemoryMbytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaximumMemoryMbytes", value);
            }
        }
    }
}