using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32MemoryDevice : Win32SMBIOSMemory
    {
        public Win32MemoryDevice()
        {
        }

        public Win32MemoryDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? ErrorGranularity
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ErrorGranularity", out result);
                return result;
            }
        }
    }
}