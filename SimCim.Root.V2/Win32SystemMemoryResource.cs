using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32SystemMemoryResource : CIMMemoryMappedIO
    {
        protected Win32SystemMemoryResource()
        {
        }

        protected Win32SystemMemoryResource(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}