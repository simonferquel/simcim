using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class EventGenerator : IndicationRelated
    {
        protected EventGenerator()
        {
        }

        protected EventGenerator(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}