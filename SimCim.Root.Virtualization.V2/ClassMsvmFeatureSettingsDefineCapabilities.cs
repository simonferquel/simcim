using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmFeatureSettingsDefineCapabilities : CIMSettingsDefineCapabilities
    {
        public MsvmFeatureSettingsDefineCapabilities()
        {
        }

        public MsvmFeatureSettingsDefineCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmEthernetSwitchFeatureCapabilities GroupComponent
        {
            get
            {
                MsvmEthernetSwitchFeatureCapabilities result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new MsvmFeatureSettingData PartComponent
        {
            get
            {
                MsvmFeatureSettingData result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}