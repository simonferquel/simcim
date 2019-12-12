using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEmulatedEthernetPortSettingData : CIMEthernetPortAllocationSettingData
    {
        public MsvmEmulatedEthernetPortSettingData()
        {
        }

        public MsvmEmulatedEthernetPortSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? ClusterMonitored
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ClusterMonitored", out result);
                return result;
            }
        }

        public System.Boolean? StaticMacAddress
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("StaticMacAddress", out result);
                return result;
            }
        }
    }
}