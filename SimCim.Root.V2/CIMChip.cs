using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMChip : CIMPhysicalComponent
    {
        protected CIMChip()
        {
        }

        protected CIMChip(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? FormFactor
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("FormFactor", out result);
                return result;
            }
        }
    }
}