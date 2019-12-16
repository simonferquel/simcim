using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataPerfNetRedirector : Win32PerfRawData
    {
        public Win32PerfRawDataPerfNetRedirector()
        {
        }

        public Win32PerfRawDataPerfNetRedirector(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.UInt32? ConnectsCore
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectsCore", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectsCore", value);
            }
        }

        public System.UInt32? ConnectsLanManager20
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectsLanManager20", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectsLanManager20", value);
            }
        }

        public System.UInt32? ConnectsLanManager21
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectsLanManager21", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectsLanManager21", value);
            }
        }

        public System.UInt32? ConnectsWindowsNT
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectsWindowsNT", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectsWindowsNT", value);
            }
        }

        public System.UInt32? CurrentCommands
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentCommands", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentCommands", value);
            }
        }

        public System.UInt32? FileDataOperationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FileDataOperationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FileDataOperationsPersec", value);
            }
        }

        public System.UInt32? FileReadOperationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FileReadOperationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FileReadOperationsPersec", value);
            }
        }

        public System.UInt32? FileWriteOperationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FileWriteOperationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FileWriteOperationsPersec", value);
            }
        }

        public System.UInt32? NetworkErrorsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NetworkErrorsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NetworkErrorsPersec", value);
            }
        }

        public System.UInt64? PacketsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsPersec", value);
            }
        }

        public System.UInt64? PacketsReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsReceivedPersec", value);
            }
        }

        public System.UInt64? PacketsTransmittedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsTransmittedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsTransmittedPersec", value);
            }
        }

        public System.UInt64? ReadBytesCachePersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadBytesCachePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadBytesCachePersec", value);
            }
        }

        public System.UInt64? ReadBytesNetworkPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadBytesNetworkPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadBytesNetworkPersec", value);
            }
        }

        public System.UInt64? ReadBytesNonPagingPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadBytesNonPagingPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadBytesNonPagingPersec", value);
            }
        }

        public System.UInt64? ReadBytesPagingPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadBytesPagingPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadBytesPagingPersec", value);
            }
        }

        public System.UInt32? ReadOperationsRandomPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReadOperationsRandomPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadOperationsRandomPersec", value);
            }
        }

        public System.UInt32? ReadPacketsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReadPacketsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadPacketsPersec", value);
            }
        }

        public System.UInt32? ReadPacketsSmallPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReadPacketsSmallPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadPacketsSmallPersec", value);
            }
        }

        public System.UInt32? ReadsDeniedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReadsDeniedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadsDeniedPersec", value);
            }
        }

        public System.UInt32? ReadsLargePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReadsLargePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadsLargePersec", value);
            }
        }

        public System.UInt32? ServerDisconnects
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ServerDisconnects", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServerDisconnects", value);
            }
        }

        public System.UInt32? ServerReconnects
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ServerReconnects", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServerReconnects", value);
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

        public System.UInt32? ServerSessionsHung
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ServerSessionsHung", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServerSessionsHung", value);
            }
        }

        public System.UInt64? WriteBytesCachePersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteBytesCachePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteBytesCachePersec", value);
            }
        }

        public System.UInt64? WriteBytesNetworkPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteBytesNetworkPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteBytesNetworkPersec", value);
            }
        }

        public System.UInt64? WriteBytesNonPagingPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteBytesNonPagingPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteBytesNonPagingPersec", value);
            }
        }

        public System.UInt64? WriteBytesPagingPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteBytesPagingPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteBytesPagingPersec", value);
            }
        }

        public System.UInt32? WriteOperationsRandomPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WriteOperationsRandomPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteOperationsRandomPersec", value);
            }
        }

        public System.UInt32? WritePacketsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WritePacketsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WritePacketsPersec", value);
            }
        }

        public System.UInt32? WritePacketsSmallPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WritePacketsSmallPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WritePacketsSmallPersec", value);
            }
        }

        public System.UInt32? WritesDeniedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WritesDeniedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WritesDeniedPersec", value);
            }
        }

        public System.UInt32? WritesLargePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WritesLargePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WritesLargePersec", value);
            }
        }
    }
}