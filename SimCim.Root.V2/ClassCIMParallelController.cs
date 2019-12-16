using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMParallelController : CIMController
    {
        protected CIMParallelController()
        {
        }

        protected CIMParallelController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] Capabilities
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("Capabilities", out result);
                return result;
            }
        }

        public System.String[] CapabilityDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("CapabilityDescriptions", out result);
                return result;
            }
        }

        public System.Boolean? DMASupport
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DMASupport", out result);
                return result;
            }
        }
    }
}