using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataVidPerfProviderHyperVVMVidNumaNode : Win32PerfRawData
    {
        public Win32PerfRawDataVidPerfProviderHyperVVMVidNumaNode()
        {
        }

        public Win32PerfRawDataVidPerfProviderHyperVVMVidNumaNode(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? PageCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageCount", value);
            }
        }

        public System.UInt64? ProcessorCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProcessorCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProcessorCount", value);
            }
        }
    }
}