using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualEthernetSwitchSettingDataComponent : CIMComponent
    {
        public MsvmVirtualEthernetSwitchSettingDataComponent()
        {
        }

        public MsvmVirtualEthernetSwitchSettingDataComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmVirtualEthernetSwitchSettingData GroupComponent
        {
            get
            {
                MsvmVirtualEthernetSwitchSettingData result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupComponent", value);
            }
        }

        public new MsvmEthernetSwitchFeatureSettingData PartComponent
        {
            get
            {
                MsvmEthernetSwitchFeatureSettingData result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("PartComponent", value);
            }
        }
    }
}