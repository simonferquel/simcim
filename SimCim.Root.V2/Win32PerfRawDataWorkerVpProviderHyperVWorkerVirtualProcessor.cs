using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataWorkerVpProviderHyperVWorkerVirtualProcessor : Win32PerfRawData
    {
        public Win32PerfRawDataWorkerVpProviderHyperVWorkerVirtualProcessor()
        {
        }

        public Win32PerfRawDataWorkerVpProviderHyperVWorkerVirtualProcessor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? InterceptDelayTimems
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InterceptDelayTimems", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterceptDelayTimems", value);
            }
        }

        public System.UInt64? InterceptsDelayed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InterceptsDelayed", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterceptsDelayed", value);
            }
        }
    }
}