using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmTimeSyncComponent : CIMLogicalDevice
    {
        public MsvmTimeSyncComponent()
        {
        }

        public MsvmTimeSyncComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}