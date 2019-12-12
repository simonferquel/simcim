using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMMemoryCapacity : CIMPhysicalCapacity
    {
        protected CIMMemoryCapacity()
        {
        }

        protected CIMMemoryCapacity(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? MaximumMemoryCapacity
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaximumMemoryCapacity", out result);
                return result;
            }
        }

        public System.UInt16? MemoryType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MemoryType", out result);
                return result;
            }
        }

        public System.UInt64? MinimumMemoryCapacity
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MinimumMemoryCapacity", out result);
                return result;
            }
        }
    }
}