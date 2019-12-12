using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32MethodParameterClass : GenericInfrastructureObject
    {
        protected Win32MethodParameterClass()
        {
        }

        protected Win32MethodParameterClass(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}