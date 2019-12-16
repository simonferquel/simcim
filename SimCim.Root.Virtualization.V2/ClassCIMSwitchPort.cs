using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMSwitchPort : CIMProtocolEndpoint
    {
        protected CIMSwitchPort()
        {
        }

        protected CIMSwitchPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? PortNumber
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PortNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("PortNumber", value);
            }
        }
    }
}