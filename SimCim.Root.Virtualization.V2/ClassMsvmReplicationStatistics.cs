using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmReplicationStatistics : CIMManagedElement
    {
        public MsvmReplicationStatistics()
        {
        }

        public MsvmReplicationStatistics(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ApplicationConsistentSnapshotFailureCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ApplicationConsistentSnapshotFailureCount", out result);
                return result;
            }
        }

        public System.DateTime? EndStatisticTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("EndStatisticTime", out result);
                return result;
            }
        }

        public System.DateTime? LastTestFailoverTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastTestFailoverTime", out result);
                return result;
            }
        }

        public System.UInt32? MaxReplicationLatency
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxReplicationLatency", out result);
                return result;
            }
        }

        public System.UInt64? MaxReplicationSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxReplicationSize", out result);
                return result;
            }
        }

        public System.UInt32? NetworkFailureCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NetworkFailureCount", out result);
                return result;
            }
        }

        public System.UInt64? PendingReplicationSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PendingReplicationSize", out result);
                return result;
            }
        }

        public System.UInt32? ReplicationFailureCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReplicationFailureCount", out result);
                return result;
            }
        }

        public System.UInt32? ReplicationHealth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReplicationHealth", out result);
                return result;
            }
        }

        public System.UInt32? ReplicationLatency
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReplicationLatency", out result);
                return result;
            }
        }

        public System.UInt32? ReplicationMissCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReplicationMissCount", out result);
                return result;
            }
        }

        public System.UInt64? ReplicationSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReplicationSize", out result);
                return result;
            }
        }

        public System.UInt32? ReplicationSuccessCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReplicationSuccessCount", out result);
                return result;
            }
        }

        public System.DateTime? StartStatisticTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("StartStatisticTime", out result);
                return result;
            }
        }
    }
}