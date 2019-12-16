using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMVirtualSystemSettingDataComponent : CIMComponent
    {
        protected CIMVirtualSystemSettingDataComponent()
        {
        }

        protected CIMVirtualSystemSettingDataComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMVirtualSystemSettingData GroupComponent
        {
            get
            {
                CIMVirtualSystemSettingData result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupComponent", value);
            }
        }

        public new CIMResourceAllocationSettingData PartComponent
        {
            get
            {
                CIMResourceAllocationSettingData result;
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