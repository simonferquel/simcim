using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMComputerSystemDMA : CIMComputerSystemResource
    {
        protected CIMComputerSystemDMA()
        {
        }

        protected CIMComputerSystemDMA(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMDMA PartComponent
        {
            get
            {
                CIMDMA result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}