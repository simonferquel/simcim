using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMVolatileStorage : CIMMemory
    {
        protected CIMVolatileStorage()
        {
        }

        protected CIMVolatileStorage(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Cacheable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Cacheable", out result);
                return result;
            }
        }

        public System.UInt16? CacheType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CacheType", out result);
                return result;
            }
        }
    }
}