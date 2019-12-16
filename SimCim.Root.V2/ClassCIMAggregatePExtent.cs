using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMAggregatePExtent : CIMStorageExtent
    {
        protected CIMAggregatePExtent()
        {
        }

        protected CIMAggregatePExtent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}