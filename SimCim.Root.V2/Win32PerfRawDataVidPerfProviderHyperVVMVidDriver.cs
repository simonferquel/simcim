using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataVidPerfProviderHyperVVMVidDriver : Win32PerfRawData
    {
        public Win32PerfRawDataVidPerfProviderHyperVVMVidDriver()
        {
        }

        public Win32PerfRawDataVidPerfProviderHyperVVMVidDriver(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? VidPartitions
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VidPartitions", out result);
                return result;
            }

            set
            {
                this.SetProperty("VidPartitions", value);
            }
        }
    }
}