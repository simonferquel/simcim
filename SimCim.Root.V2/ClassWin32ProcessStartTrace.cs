using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ProcessStartTrace : Win32ProcessTrace
    {
        public Win32ProcessStartTrace()
        {
        }

        public Win32ProcessStartTrace(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}