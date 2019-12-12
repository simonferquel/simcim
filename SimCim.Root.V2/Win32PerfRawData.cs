using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32PerfRawData : Win32Perf
    {
        protected Win32PerfRawData()
        {
        }

        protected Win32PerfRawData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}