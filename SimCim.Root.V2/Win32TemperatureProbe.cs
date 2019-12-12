using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32TemperatureProbe : CIMTemperatureSensor
    {
        public Win32TemperatureProbe()
        {
        }

        public Win32TemperatureProbe(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}