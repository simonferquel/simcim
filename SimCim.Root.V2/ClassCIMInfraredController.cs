using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMInfraredController : CIMController
    {
        protected CIMInfraredController()
        {
        }

        protected CIMInfraredController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}