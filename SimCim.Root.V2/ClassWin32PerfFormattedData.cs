using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32PerfFormattedData : Win32Perf
    {
        protected Win32PerfFormattedData()
        {
        }

        protected Win32PerfFormattedData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}