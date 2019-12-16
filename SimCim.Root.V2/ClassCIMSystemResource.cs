using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSystemResource : CIMLogicalElement
    {
        protected CIMSystemResource()
        {
        }

        protected CIMSystemResource(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}