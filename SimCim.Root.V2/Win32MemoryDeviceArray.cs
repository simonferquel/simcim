using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32MemoryDeviceArray : CIMComponent
    {
        public Win32MemoryDeviceArray()
        {
        }

        public Win32MemoryDeviceArray(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32MemoryArray GroupComponent
        {
            get
            {
                Win32MemoryArray result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new Win32MemoryDevice PartComponent
        {
            get
            {
                Win32MemoryDevice result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}