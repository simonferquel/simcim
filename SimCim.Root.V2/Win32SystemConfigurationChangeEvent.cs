using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SystemConfigurationChangeEvent : Win32DeviceChangeEvent
    {
        public Win32SystemConfigurationChangeEvent()
        {
        }

        public Win32SystemConfigurationChangeEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}