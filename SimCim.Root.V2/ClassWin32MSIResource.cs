using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32MSIResource : CIMSetting
    {
        protected Win32MSIResource()
        {
        }

        protected Win32MSIResource(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}