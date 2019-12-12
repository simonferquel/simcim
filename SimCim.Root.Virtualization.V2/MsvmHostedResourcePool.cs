using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmHostedResourcePool : CIMSystemComponent
    {
        public MsvmHostedResourcePool()
        {
        }

        public MsvmHostedResourcePool(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmComputerSystem GroupComponent
        {
            get
            {
                MsvmComputerSystem result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupComponent", value);
            }
        }

        public new CIMResourcePool PartComponent
        {
            get
            {
                CIMResourcePool result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("PartComponent", value);
            }
        }
    }
}