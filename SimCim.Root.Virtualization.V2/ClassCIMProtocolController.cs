using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMProtocolController : CIMLogicalDevice
    {
        protected CIMProtocolController()
        {
        }

        protected CIMProtocolController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? MaxUnitsControlled
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxUnitsControlled", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxUnitsControlled", value);
            }
        }
    }
}