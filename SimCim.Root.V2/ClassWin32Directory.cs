using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Directory : CIMDirectory
    {
        public Win32Directory()
        {
        }

        public Win32Directory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}