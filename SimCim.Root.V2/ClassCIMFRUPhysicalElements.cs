using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMFRUPhysicalElements : GenericInfrastructureObject
    {
        protected CIMFRUPhysicalElements()
        {
        }

        protected CIMFRUPhysicalElements(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMPhysicalElement Component
        {
            get
            {
                CIMPhysicalElement result;
                this.GetInfrastructureObjectProperty("Component", out result);
                return result;
            }
        }

        public CIMFRU FRU
        {
            get
            {
                CIMFRU result;
                this.GetInfrastructureObjectProperty("FRU", out result);
                return result;
            }
        }
    }
}