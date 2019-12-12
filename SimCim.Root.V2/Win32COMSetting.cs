using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32COMSetting : CIMSetting
    {
        protected Win32COMSetting()
        {
        }

        protected Win32COMSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}