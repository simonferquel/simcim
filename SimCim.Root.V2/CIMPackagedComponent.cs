using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPackagedComponent : CIMContainer
    {
        protected CIMPackagedComponent()
        {
        }

        protected CIMPackagedComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMPhysicalComponent PartComponent
        {
            get
            {
                CIMPhysicalComponent result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}