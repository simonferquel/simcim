using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMContainer : CIMComponent
    {
        protected CIMContainer()
        {
        }

        protected CIMContainer(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMPhysicalPackage GroupComponent
        {
            get
            {
                CIMPhysicalPackage result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMPhysicalElement PartComponent
        {
            get
            {
                CIMPhysicalElement result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }

        public System.String LocationWithinContainer
        {
            get
            {
                System.String result;
                this.GetProperty("LocationWithinContainer", out result);
                return result;
            }
        }
    }
}