using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32MemoryArrayLocation : CIMRealizes
    {
        public Win32MemoryArrayLocation()
        {
        }

        public Win32MemoryArrayLocation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32PhysicalMemoryArray Antecedent
        {
            get
            {
                Win32PhysicalMemoryArray result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32MemoryArray Dependent
        {
            get
            {
                Win32MemoryArray result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}