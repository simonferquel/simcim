using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataMmPerfProviderHyperVVMWorkerProcessMemoryManager : Win32PerfRawData
    {
        public Win32PerfRawDataMmPerfProviderHyperVVMWorkerProcessMemoryManager()
        {
        }

        public Win32PerfRawDataMmPerfProviderHyperVVMWorkerProcessMemoryManager(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? MemoryBlockCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MemoryBlockCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("MemoryBlockCount", value);
            }
        }
    }
}