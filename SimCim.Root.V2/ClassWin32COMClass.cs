using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32COMClass : CIMLogicalElement
    {
        protected Win32COMClass()
        {
        }

        protected Win32COMClass(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}