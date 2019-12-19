using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public abstract class CIMScopedSettingData : CIMSettingData
    {
        protected CIMScopedSettingData()
        {
        }

        protected CIMScopedSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}