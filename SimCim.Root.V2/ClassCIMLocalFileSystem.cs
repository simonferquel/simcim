using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMLocalFileSystem : CIMFileSystem
    {
        protected CIMLocalFileSystem()
        {
        }

        protected CIMLocalFileSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}