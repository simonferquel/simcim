using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMElementCapacity : GenericInfrastructureObject
    {
        protected CIMElementCapacity()
        {
        }

        protected CIMElementCapacity(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMPhysicalCapacity Capacity
        {
            get
            {
                CIMPhysicalCapacity result;
                this.GetInfrastructureObjectProperty("Capacity", out result);
                return result;
            }
        }

        public CIMPhysicalElement Element
        {
            get
            {
                CIMPhysicalElement result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }
    }
}