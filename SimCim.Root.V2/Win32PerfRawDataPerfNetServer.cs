using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataPerfNetServer : Win32PerfRawData
    {
        public Win32PerfRawDataPerfNetServer()
        {
        }

        public Win32PerfRawDataPerfNetServer(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BlockingRequestsRejected
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BlockingRequestsRejected", out result);
                return result;
            }

            set
            {
                this.SetProperty("BlockingRequestsRejected", value);
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

        public System.UInt64? BytesTotalPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesTotalPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesTotalPersec", value);
            }
        }

        public System.UInt64? BytesTransmittedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesTransmittedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesTransmittedPersec", value);
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

        public System.UInt32? ErrorsAccessPermissions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorsAccessPermissions", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorsAccessPermissions", value);
            }
        }

        public System.UInt32? ErrorsGrantedAccess
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorsGrantedAccess", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorsGrantedAccess", value);
            }
        }

        public System.UInt32? ErrorsLogon
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorsLogon", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorsLogon", value);
            }
        }

        public System.UInt32? ErrorsSystem
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorsSystem", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorsSystem", value);
            }
        }

        public System.UInt32? FileDirectorySearches
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FileDirectorySearches", out result);
                return result;
            }

            set
            {
                this.SetProperty("FileDirectorySearches", value);
            }
        }

        public System.UInt32? FilesOpen
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FilesOpen", out result);
                return result;
            }

            set
            {
                this.SetProperty("FilesOpen", value);
            }
        }

        public System.UInt32? FilesOpenedTotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FilesOpenedTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("FilesOpenedTotal", value);
            }
        }

        public System.UInt32? LogonPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogonPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogonPersec", value);
            }
        }

        public System.UInt32? LogonTotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogonTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogonTotal", value);
            }
        }

        public System.UInt32? PoolNonpagedBytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PoolNonpagedBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("PoolNonpagedBytes", value);
            }
        }

        public System.UInt32? PoolNonpagedFailures
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PoolNonpagedFailures", out result);
                return result;
            }

            set
            {
                this.SetProperty("PoolNonpagedFailures", value);
            }
        }

        public System.UInt32? PoolNonpagedPeak
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PoolNonpagedPeak", out result);
                return result;
            }

            set
            {
                this.SetProperty("PoolNonpagedPeak", value);
            }
        }

        public System.UInt32? PoolPagedBytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PoolPagedBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("PoolPagedBytes", value);
            }
        }

        public System.UInt32? PoolPagedFailures
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PoolPagedFailures", out result);
                return result;
            }

            set
            {
                this.SetProperty("PoolPagedFailures", value);
            }
        }

        public System.UInt32? PoolPagedPeak
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PoolPagedPeak", out result);
                return result;
            }

            set
            {
                this.SetProperty("PoolPagedPeak", value);
            }
        }

        public System.UInt32? ReconnectedDurableHandles
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReconnectedDurableHandles", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReconnectedDurableHandles", value);
            }
        }

        public System.UInt32? ReconnectedResilientHandles
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReconnectedResilientHandles", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReconnectedResilientHandles", value);
            }
        }

        public System.UInt32? ServerSessions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ServerSessions", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServerSessions", value);
            }
        }

        public System.UInt32? SessionsErroredOut
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionsErroredOut", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionsErroredOut", value);
            }
        }

        public System.UInt32? SessionsForcedOff
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionsForcedOff", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionsForcedOff", value);
            }
        }

        public System.UInt32? SessionsLoggedOff
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionsLoggedOff", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionsLoggedOff", value);
            }
        }

        public System.UInt32? SessionsTimedOut
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionsTimedOut", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionsTimedOut", value);
            }
        }

        public System.UInt64? SMBBranchCacheHashBytesSent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SMBBranchCacheHashBytesSent", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheHashBytesSent", value);
            }
        }

        public System.UInt32? SMBBranchCacheHashGenerationRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SMBBranchCacheHashGenerationRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheHashGenerationRequests", value);
            }
        }

        public System.UInt32? SMBBranchCacheHashHeaderRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SMBBranchCacheHashHeaderRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheHashHeaderRequests", value);
            }
        }

        public System.UInt32? SMBBranchCacheHashRequestsReceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SMBBranchCacheHashRequestsReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheHashRequestsReceived", value);
            }
        }

        public System.UInt32? SMBBranchCacheHashResponsesSent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SMBBranchCacheHashResponsesSent", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheHashResponsesSent", value);
            }
        }

        public System.UInt64? SMBBranchCacheHashV2BytesSent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SMBBranchCacheHashV2BytesSent", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheHashV2BytesSent", value);
            }
        }

        public System.UInt32? SMBBranchCacheHashV2GenerationRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SMBBranchCacheHashV2GenerationRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheHashV2GenerationRequests", value);
            }
        }

        public System.UInt32? SMBBranchCacheHashV2HeaderRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SMBBranchCacheHashV2HeaderRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheHashV2HeaderRequests", value);
            }
        }

        public System.UInt32? SMBBranchCacheHashV2RequestsReceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SMBBranchCacheHashV2RequestsReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheHashV2RequestsReceived", value);
            }
        }

        public System.UInt32? SMBBranchCacheHashV2RequestsServedFromDedup
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SMBBranchCacheHashV2RequestsServedFromDedup", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheHashV2RequestsServedFromDedup", value);
            }
        }

        public System.UInt32? SMBBranchCacheHashV2ResponsesSent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SMBBranchCacheHashV2ResponsesSent", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheHashV2ResponsesSent", value);
            }
        }

        public System.UInt32? TotalDurableHandles
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalDurableHandles", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalDurableHandles", value);
            }
        }

        public System.UInt32? TotalResilientHandles
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalResilientHandles", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalResilientHandles", value);
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
    }
}