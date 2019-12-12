using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataPerfNetServerWorkQueues : Win32PerfRawData
    {
        public Win32PerfRawDataPerfNetServerWorkQueues()
        {
        }

        public Win32PerfRawDataPerfNetServerWorkQueues(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActiveThreads
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveThreads", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveThreads", value);
            }
        }

        public System.UInt32? AvailableThreads
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvailableThreads", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvailableThreads", value);
            }
        }

        public System.UInt32? AvailableWorkItems
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvailableWorkItems", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvailableWorkItems", value);
            }
        }

        public System.UInt32? BorrowedWorkItems
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BorrowedWorkItems", out result);
                return result;
            }

            set
            {
                this.SetProperty("BorrowedWorkItems", value);
            }
        }

        public System.UInt64? BytesReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesReceivedPersec", value);
            }
        }

        public System.UInt64? BytesSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesSentPersec", value);
            }
        }

        public System.UInt64? BytesTransferredPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesTransferredPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesTransferredPersec", value);
            }
        }

        public System.UInt32? ContextBlocksQueuedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ContextBlocksQueuedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ContextBlocksQueuedPersec", value);
            }
        }

        public System.UInt32? CurrentClients
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentClients", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentClients", value);
            }
        }

        public System.UInt32? QueueLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("QueueLength", value);
            }
        }

        public System.UInt64? ReadBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadBytesPersec", value);
            }
        }

        public System.UInt64? ReadOperationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadOperationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadOperationsPersec", value);
            }
        }

        public System.UInt64? TotalBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalBytesPersec", value);
            }
        }

        public System.UInt64? TotalOperationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalOperationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalOperationsPersec", value);
            }
        }

        public System.UInt32? WorkItemShortages
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkItemShortages", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkItemShortages", value);
            }
        }

        public System.UInt64? WriteBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteBytesPersec", value);
            }
        }

        public System.UInt64? WriteOperationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteOperationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteOperationsPersec", value);
            }
        }
    }
}