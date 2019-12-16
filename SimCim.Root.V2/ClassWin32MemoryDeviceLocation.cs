using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32MemoryDeviceLocation : CIMRealizes
    {
        public Win32MemoryDeviceLocation()
        {
        }

        public Win32MemoryDeviceLocation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32PhysicalMemory Antecedent
        {
            get
            {
                Win32PhysicalMemory result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32MemoryDevice Dependent
        {
            get
            {
                Win32MemoryDevice result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}