using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmResourceAllocationFromPool : CIMResourceAllocationFromPool
    {
        public MsvmResourceAllocationFromPool()
        {
        }

        public MsvmResourceAllocationFromPool(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}