using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public abstract class SecurityRelatedClass : GenericInfrastructureObject
    {
        protected SecurityRelatedClass()
        {
        }

        protected SecurityRelatedClass(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}