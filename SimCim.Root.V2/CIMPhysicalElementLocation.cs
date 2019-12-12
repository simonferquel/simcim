using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPhysicalElementLocation : GenericInfrastructureObject
    {
        protected CIMPhysicalElementLocation()
        {
        }

        protected CIMPhysicalElementLocation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public CIMLocation PhysicalLocation
        {
            get
            {
                CIMLocation result;
                this.GetInfrastructureObjectProperty("PhysicalLocation", out result);
                return result;
            }
        }
    }
}