using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmBootSourceComponent : CIMComponent
    {
        public MsvmBootSourceComponent()
        {
        }

        public MsvmBootSourceComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}