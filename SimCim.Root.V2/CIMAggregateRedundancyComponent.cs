using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMAggregateRedundancyComponent : CIMRedundancyComponent
    {
        protected CIMAggregateRedundancyComponent()
        {
        }

        protected CIMAggregateRedundancyComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMStorageRedundancyGroup GroupComponent
        {
            get
            {
                CIMStorageRedundancyGroup result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMAggregatePExtent PartComponent
        {
            get
            {
                CIMAggregatePExtent result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}