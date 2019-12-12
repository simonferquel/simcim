using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMMemoryCheck : CIMCheck
    {
        protected CIMMemoryCheck()
        {
        }

        protected CIMMemoryCheck(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? MemorySize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MemorySize", out result);
                return result;
            }
        }
    }
}