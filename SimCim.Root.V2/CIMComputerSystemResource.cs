using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMComputerSystemResource : CIMSystemComponent
    {
        protected CIMComputerSystemResource()
        {
        }

        protected CIMComputerSystemResource(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMComputerSystem GroupComponent
        {
            get
            {
                CIMComputerSystem result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMSystemResource PartComponent
        {
            get
            {
                CIMSystemResource result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}