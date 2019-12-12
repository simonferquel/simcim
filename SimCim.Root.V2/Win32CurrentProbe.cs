using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32CurrentProbe : CIMCurrentSensor
    {
        public Win32CurrentProbe()
        {
        }

        public Win32CurrentProbe(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}