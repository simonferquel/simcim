using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32COMApplication : CIMLogicalElement
    {
        protected Win32COMApplication()
        {
        }

        protected Win32COMApplication(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}