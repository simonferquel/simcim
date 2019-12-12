using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmGuestServiceInterfaceSettingDataComponent : CIMComponent
    {
        public MsvmGuestServiceInterfaceSettingDataComponent()
        {
        }

        public MsvmGuestServiceInterfaceSettingDataComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmGuestServiceInterfaceComponentSettingData GroupComponent
        {
            get
            {
                MsvmGuestServiceInterfaceComponentSettingData result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupComponent", value);
            }
        }

        public new CIMSettingData PartComponent
        {
            get
            {
                CIMSettingData result;
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