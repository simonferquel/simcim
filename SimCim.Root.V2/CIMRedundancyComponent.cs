using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMRedundancyComponent : CIMComponent
    {
        protected CIMRedundancyComponent()
        {
        }

        protected CIMRedundancyComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMRedundancyGroup GroupComponent
        {
            get
            {
                CIMRedundancyGroup result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }
    }
}