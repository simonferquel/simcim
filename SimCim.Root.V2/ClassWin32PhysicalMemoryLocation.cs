using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PhysicalMemoryLocation : CIMPackagedComponent
    {
        public Win32PhysicalMemoryLocation()
        {
        }

        public Win32PhysicalMemoryLocation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32PhysicalMemoryArray GroupComponent
        {
            get
            {
                Win32PhysicalMemoryArray result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new Win32PhysicalMemory PartComponent
        {
            get
            {
                Win32PhysicalMemory result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}