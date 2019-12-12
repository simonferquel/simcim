using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmHeartbeatComponent : CIMLogicalDevice
    {
        public MsvmHeartbeatComponent()
        {
        }

        public MsvmHeartbeatComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}