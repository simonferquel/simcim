using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32Trustee : Trustee
    {
        protected Win32Trustee()
        {
        }

        protected Win32Trustee(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}