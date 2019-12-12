using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMNonVolatileStorage : CIMMemory
    {
        protected CIMNonVolatileStorage()
        {
        }

        protected CIMNonVolatileStorage(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? IsWriteable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsWriteable", out result);
                return result;
            }
        }
    }
}