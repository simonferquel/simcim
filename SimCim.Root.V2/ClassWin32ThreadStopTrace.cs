using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ThreadStopTrace : Win32ThreadTrace
    {
        public Win32ThreadStopTrace()
        {
        }

        public Win32ThreadStopTrace(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}