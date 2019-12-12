using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ModuleTrace : Win32SystemTrace
    {
        public Win32ModuleTrace()
        {
        }

        public Win32ModuleTrace(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}