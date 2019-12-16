using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmReplicationRelationship : CIMManagedSystemElement
    {
        public MsvmReplicationRelationship()
        {
        }

        public MsvmReplicationRelationship(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.DateTime? LastApplicationConsistentReplicationTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastApplicationConsistentReplicationTime", out result);
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

        public System.DateTime? LastReplicationTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastReplicationTime", out result);
                return result;
            }
        }

        public System.UInt16? LastReplicationType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LastReplicationType", out result);
                return result;
            }
        }

        public System.UInt16? ReplicationHealth
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ReplicationHealth", out result);
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

        public IEnumerable<MsvmComputerSystem> ResolveMsvmSystemReplicationRelationshipAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SystemReplicationRelationship", "Msvm_ComputerSystem", "Dependent", "Antecedent");
            return instances.Select(i => (MsvmComputerSystem)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}