using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetPortFailoverSettingDataComponent : CIMComponent
    {
        public MsvmEthernetPortFailoverSettingDataComponent()
        {
        }

        public MsvmEthernetPortFailoverSettingDataComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMResourceAllocationSettingData GroupComponent
        {
            get
            {
                CIMResourceAllocationSettingData result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupComponent", value);
            }
        }

        public new MsvmFailoverNetworkAdapterSettingData PartComponent
        {
            get
            {
                MsvmFailoverNetworkAdapterSettingData result;
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