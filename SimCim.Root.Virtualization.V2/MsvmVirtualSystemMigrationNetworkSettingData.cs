using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualSystemMigrationNetworkSettingData : CIMSettingData
    {
        public MsvmVirtualSystemMigrationNetworkSettingData()
        {
        }

        public MsvmVirtualSystemMigrationNetworkSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Metric
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Metric", out result);
                return result;
            }
        }

        public System.Byte? PrefixLength
        {
            get
            {
                System.Byte? result;
                this.GetProperty("PrefixLength", out result);
                return result;
            }
        }

        public System.String SubnetNumber
        {
            get
            {
                System.String result;
                this.GetProperty("SubnetNumber", out result);
                return result;
            }
        }

        public System.String[] Tags
        {
            get
            {
                System.String[] result;
                this.GetProperty("Tags", out result);
                return result;
            }
        }

        public IEnumerable<MsvmVirtualSystemMigrationServiceSettingData> ResolveMsvmVirtualSystemMigrationServiceSettingDataComponentGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_VirtualSystemMigrationServiceSettingDataComponent", "Msvm_VirtualSystemMigrationServiceSettingData", "PartComponent", "GroupComponent");
            return instances.Select(i => (MsvmVirtualSystemMigrationServiceSettingData)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}