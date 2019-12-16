using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Fan : CIMFan
    {
        public Win32Fan()
        {
        }

        public Win32Fan(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}