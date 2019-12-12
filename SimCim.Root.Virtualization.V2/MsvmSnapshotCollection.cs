using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSnapshotCollection : CIMCollection
    {
        public MsvmSnapshotCollection()
        {
        }

        public MsvmSnapshotCollection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CollectionID
        {
            get
            {
                System.String result;
                this.GetProperty("CollectionID", out result);
                return result;
            }

            set
            {
                this.SetProperty("CollectionID", value);
            }
        }

        public IEnumerable<MsvmVirtualSystemSettingData> ResolveMsvmCollectedSnapshotsMember()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_CollectedSnapshots", "Msvm_VirtualSystemSettingData", "Collection", "Member");
            return instances.Select(i => (MsvmVirtualSystemSettingData)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}