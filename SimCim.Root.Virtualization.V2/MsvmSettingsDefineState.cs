using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSettingsDefineState : CIMSettingsDefineState
    {
        public MsvmSettingsDefineState()
        {
        }

        public MsvmSettingsDefineState(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}