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
            if (inTimeoutPeriod.HasValue)
                parameters.Add(CimMethodParameter.Create("TimeoutPeriod", inTimeoutPeriod.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RequestReplicationStateChange", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) InjectNonMaskableInterrupt()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "InjectNonMaskableInterrupt", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RequestReplicationStateChangeEx(System.String inReplicationRelationship, System.UInt16? inRequestedState, System.DateTime? inTimeoutPeriod)
        {
            var parameters = new CimMethodParametersCollection();
            if (inReplicationRelationship != null)
                parameters.Add(CimMethodParameter.Create("ReplicationRelationship", inReplicationRelationship, CimType.String, inReplicationRelationship == null ? CimFlags.NullValue : CimFlags.None));
            if (inRequestedState.HasValue)
                parameters.Add(CimMethodParameter.Create("RequestedState", inRequestedState.Value, CimFlags.None));
            if (inTimeoutPeriod.HasValue)
                parameters.Add(CimMethodParameter.Create("TimeoutPeriod", inTimeoutPeriod.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RequestReplicationStateChangeEx", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }
    }
}