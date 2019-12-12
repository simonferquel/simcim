using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualSystemMigrationServiceSettingDataComponent : CIMComponent
    {
        public MsvmVirtualSystemMigrationServiceSettingDataComponent()
        {
        }

        public MsvmVirtualSystemMigrationServiceSettingDataComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmVirtualSystemMigrationServiceSettingData GroupComponent
        {
            get
            {
                MsvmVirtualSystemMigrationServiceSettingData result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new MsvmVirtualSystemMigrationNetworkSettingData PartComponent
        {
            get
            {
                MsvmVirtualSystemMigrationNetworkSettingData result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}