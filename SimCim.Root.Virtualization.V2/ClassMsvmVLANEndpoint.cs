using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVLANEndpoint : CIMVLANEndpoint
    {
        public MsvmVLANEndpoint()
        {
        }

        public MsvmVLANEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] SupportedEndpointModes
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("SupportedEndpointModes", out result);
                return result;
            }
        }
    }
}