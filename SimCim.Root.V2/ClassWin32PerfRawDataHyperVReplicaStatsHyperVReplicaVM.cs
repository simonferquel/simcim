using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataHyperVReplicaStatsHyperVReplicaVM : Win32PerfRawData
    {
        public Win32PerfRawDataHyperVReplicaStatsHyperVReplicaVM()
        {
        }

        public Win32PerfRawDataHyperVReplicaStatsHyperVReplicaVM(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AverageReplicationLatency
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageReplicationLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageReplicationLatency", value);
            }
        }

        public System.UInt64? AverageReplicationSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageReplicationSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageReplicationSize", value);
            }
        }

        public System.UInt64? CompressionEfficiency
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CompressionEfficiency", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompressionEfficiency", value);
            }
        }

        public System.UInt64? LastReplicationSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LastReplicationSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("LastReplicationSize", value);
            }
        }

        public System.UInt64? NetworkBytesRecv
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NetworkBytesRecv", out result);
                return result;
            }

            set
            {
                this.SetProperty("NetworkBytesRecv", value);
            }
        }

        public System.UInt64? NetworkBytesSent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NetworkBytesSent", out result);
                return result;
            }

            set
            {
                this.SetProperty("NetworkBytesSent", value);
            }
        }

        public System.UInt32? ReplicationCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReplicationCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReplicationCount", value);
            }
        }

        public System.UInt64? ReplicationLatency
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReplicationLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReplicationLatency", value);
            }
        }

        public System.UInt64? ResynchronizedBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ResynchronizedBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResynchronizedBytes", value);
            }
        }
    }
}