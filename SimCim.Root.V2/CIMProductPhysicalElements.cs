using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMProductPhysicalElements : GenericInfrastructureObject
    {
        protected CIMProductPhysicalElements()
        {
        }

        protected CIMProductPhysicalElements(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public CIMProduct Product
        {
            get
            {
                CIMProduct result;
                this.GetInfrastructureObjectProperty("Product", out result);
                return result;
            }
        }
    }
}