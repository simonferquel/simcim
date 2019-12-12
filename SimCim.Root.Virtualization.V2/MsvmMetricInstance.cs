using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmMetricInstance : CIMMetricInstance
    {
        public MsvmMetricInstance()
        {
        }

        public MsvmMetricInstance(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}