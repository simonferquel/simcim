using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class MsvmSystemComponentSettingData : CIMSettingData
    {
        protected MsvmSystemComponentSettingData()
        {
        }

        protected MsvmSystemComponentSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}