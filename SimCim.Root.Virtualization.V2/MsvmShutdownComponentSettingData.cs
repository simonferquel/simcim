using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmShutdownComponentSettingData : CIMResourceAllocationSettingData
    {
        public MsvmShutdownComponentSettingData()
        {
        }

        public MsvmShutdownComponentSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? EnabledState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EnabledState", out result);
                return result;
            }
        }
    }
}