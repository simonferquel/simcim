using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32Reliability : GenericInfrastructureObject
    {
        protected Win32Reliability()
        {
        }

        protected Win32Reliability(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}