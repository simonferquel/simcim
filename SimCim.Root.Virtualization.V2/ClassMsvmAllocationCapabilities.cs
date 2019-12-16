using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmAllocationCapabilities : CIMAllocationCapabilities
    {
        public MsvmAllocationCapabilities()
        {
        }

        public MsvmAllocationCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}