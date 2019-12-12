using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetPortSettingDataComponent : CIMComponent
    {
        public MsvmEthernetPortSettingDataComponent()
        {
        }

        public MsvmEthernetPortSettingDataComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmEthernetPortAllocationSettingData GroupComponent
        {
            get
            {
                MsvmEthernetPortAllocationSettingData result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupComponent", value);
            }
        }

        public new MsvmEthernetSwitchPortFeatureSettingData PartComponent
        {
            get
            {
                MsvmEthernetSwitchPortFeatureSettingData result;
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