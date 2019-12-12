using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSettingDataComponent : CIMComponent
    {
        public MsvmSettingDataComponent()
        {
        }

        public MsvmSettingDataComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public new MsvmGuestNetworkAdapterConfiguration PartComponent
        {
            get
            {
                MsvmGuestNetworkAdapterConfiguration result;
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