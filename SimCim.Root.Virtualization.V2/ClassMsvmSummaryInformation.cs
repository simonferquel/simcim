using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSummaryInformation : MsvmSummaryInformationBase
    {
        public MsvmSummaryInformation()
        {
        }

        public MsvmSummaryInformation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AllocatedGPU
        {
            get
            {
                System.String result;
                this.GetProperty("AllocatedGPU", out result);
                return result;
            }
        }

        public System.UInt16? ApplicationHealth
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ApplicationHealth", out result);
                return result;
            }
        }

        public IEnumerable<CIMConcreteJob> AsynchronousTasks
        {
            get
            {
                IEnumerable<CIMConcreteJob> result;
                this.GetInfrastructureObjectProperty("AsynchronousTasks", out result);
                return result;
            }
        }

        public System.Int32? AvailableMemoryBuffer
        {
            get
            {
                System.Int32? result;
                this.GetProperty("AvailableMemoryBuffer", out result);
                return result;
            }
        }

        public System.String GuestOperatingSystem
        {
            get
            {
                System.String result;
                this.GetProperty("GuestOperatingSystem", out result);
                return result;
            }
        }

        public System.UInt16? Heartbeat
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Heartbeat", out result);
                return result;
            }
        }

        public System.UInt64? HypervisorPartitionId
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HypervisorPartitionId", out result);
                return result;
            }
        }

        public System.UInt16? IntegrationServicesVersionState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("IntegrationServicesVersionState", out result);
                return result;
            }
        }

        public System.Int32? MemoryAvailable
        {
            get
            {
                System.Int32? result;
                this.GetProperty("MemoryAvailable", out result);
                return result;
            }
        }

        public System.Boolean? MemorySpansPhysicalNumaNodes
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MemorySpansPhysicalNumaNodes", out result);
                return result;
            }
        }

        public System.UInt64? MemoryUsage
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MemoryUsage", out result);
                return result;
            }
        }

        public System.UInt16? ProcessorLoad
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ProcessorLoad", out result);
                return result;
            }
        }

        public System.UInt16[] ProcessorLoadHistory
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("ProcessorLoadHistory", out result);
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

        public System.UInt16[] ReplicationHealthEx
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("ReplicationHealthEx", out result);
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

        public System.String[] ReplicationProviderId
        {
            get
            {
                System.String[] result;
                this.GetProperty("ReplicationProviderId", out result);
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

        public System.UInt16[] ReplicationStateEx
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("ReplicationStateEx", out result);
                return result;
            }
        }

        public System.Boolean? Shielded
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Shielded", out result);
                return result;
            }
        }

        public IEnumerable<CIMVirtualSystemSettingData> Snapshots
        {
            get
            {
                IEnumerable<CIMVirtualSystemSettingData> result;
                this.GetInfrastructureObjectProperty("Snapshots", out result);
                return result;
            }
        }

        public System.Boolean? SwapFilesInUse
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SwapFilesInUse", out result);
                return result;
            }
        }

        public CIMComputerSystem TestReplicaSystem
        {
            get
            {
                CIMComputerSystem result;
                this.GetInfrastructureObjectProperty("TestReplicaSystem", out result);
                return result;
            }
        }

        public System.Byte[] ThumbnailImage
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("ThumbnailImage", out result);
                return result;
            }
        }

        public System.UInt16? ThumbnailImageHeight
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ThumbnailImageHeight", out result);
                return result;
            }
        }

        public System.UInt16? ThumbnailImageWidth
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ThumbnailImageWidth", out result);
                return result;
            }
        }
    }
}