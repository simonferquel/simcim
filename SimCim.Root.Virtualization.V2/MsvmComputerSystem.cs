using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmComputerSystem : CIMComputerSystem
    {
        public MsvmComputerSystem()
        {
        }

        public MsvmComputerSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? EnhancedSessionModeState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EnhancedSessionModeState", out result);
                return result;
            }
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

        public System.UInt32? HwThreadsPerCoreRealized
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HwThreadsPerCoreRealized", out result);
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

        public System.DateTime? LastSuccessfulBackupTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastSuccessfulBackupTime", out result);
                return result;
            }
        }

        public System.UInt16? NumberOfNumaNodes
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NumberOfNumaNodes", out result);
                return result;
            }
        }

        public System.UInt64? OnTimeInMilliseconds
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OnTimeInMilliseconds", out result);
                return result;
            }
        }

        public System.UInt32? ProcessID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessID", out result);
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

        public System.DateTime? TimeOfLastConfigurationChange
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeOfLastConfigurationChange", out result);
                return result;
            }
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RequestReplicationStateChange(System.UInt16? inRequestedState, System.DateTime? inTimeoutPeriod)
        {
            var parameters = new CimMethodParametersCollection();
            if (inRequestedState.HasValue)
                parameters.Add(CimMethodParameter.Create("RequestedState", inRequestedState.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("RequestedState", null, CimFlags.NullValue));
            if (inTimeoutPeriod.HasValue)
                parameters.Add(CimMethodParameter.Create("TimeoutPeriod", inTimeoutPeriod.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("TimeoutPeriod", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RequestReplicationStateChange", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) InjectNonMaskableInterrupt()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "InjectNonMaskableInterrupt", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RequestReplicationStateChangeEx(System.String inReplicationRelationship, System.UInt16? inRequestedState, System.DateTime? inTimeoutPeriod)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ReplicationRelationship", inReplicationRelationship, inReplicationRelationship == null ? CimFlags.NullValue : CimFlags.None));
            if (inRequestedState.HasValue)
                parameters.Add(CimMethodParameter.Create("RequestedState", inRequestedState.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("RequestedState", null, CimFlags.NullValue));
            if (inTimeoutPeriod.HasValue)
                parameters.Add(CimMethodParameter.Create("TimeoutPeriod", inTimeoutPeriod.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("TimeoutPeriod", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RequestReplicationStateChangeEx", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public IEnumerable<MsvmVirtualSystemCollection> ResolveMsvmCollectedVirtualSystemsCollection()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_CollectedVirtualSystems", "Msvm_VirtualSystemCollection", "Member", "Collection");
            return instances.Select(i => (MsvmVirtualSystemCollection)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<CIMResourcePool> ResolveMsvmHostedResourcePoolPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_HostedResourcePool", "CIM_ResourcePool", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMResourcePool)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public MsvmTerminalConnection ResolveMsvmSystemTerminalConnectionDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SystemTerminalConnection", "Msvm_TerminalConnection", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmTerminalConnection)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<MsvmVirtualSystemReferencePoint> ResolveMsvmReferencePointOfVirtualSystemDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ReferencePointOfVirtualSystem", "Msvm_VirtualSystemReferencePoint", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmVirtualSystemReferencePoint)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<MsvmReplicationRelationship> ResolveMsvmSystemReplicationRelationshipDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SystemReplicationRelationship", "Msvm_ReplicationRelationship", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmReplicationRelationship)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public CimInstance ResolveMsvmElementConformsToProfileConformantStandard()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ElementConformsToProfile", "Msvm_RegisteredProfile", "ManagedElement", "ConformantStandard");
            return instances.SingleOrDefault();
        }
    }
}