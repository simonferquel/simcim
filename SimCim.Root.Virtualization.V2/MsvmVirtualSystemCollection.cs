using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualSystemCollection : CIMCollectionOfMSEs
    {
        public MsvmVirtualSystemCollection()
        {
        }

        public MsvmVirtualSystemCollection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? FailedOverReplicationType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("FailedOverReplicationType", out result);
                return result;
            }
        }

        public System.UInt16? LastApplyConsistencyLevel
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LastApplyConsistencyLevel", out result);
                return result;
            }
        }

        public System.DateTime? LastApplyTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastApplyTime", out result);
                return result;
            }
        }

        public System.String[] LastApplyVirtualMachineIds
        {
            get
            {
                System.String[] result;
                this.GetProperty("LastApplyVirtualMachineIds", out result);
                return result;
            }
        }

        public System.UInt16? ReplicationMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ReplicationMode", out result);
                return result;
            }
        }

        public System.UInt16? ReplicationState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ReplicationState", out result);
                return result;
            }
        }

        public IEnumerable<MsvmComputerSystem> ResolveMsvmCollectedVirtualSystemsMember()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_CollectedVirtualSystems", "Msvm_ComputerSystem", "Collection", "Member");
            return instances.Select(i => (MsvmComputerSystem)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}