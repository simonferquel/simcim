using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersSMBServerShares : Win32PerfRawData
    {
        public Win32PerfRawDataCountersSMBServerShares()
        {
        }

        public Win32PerfRawDataCountersSMBServerShares(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AvgBytesPerRead
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgBytesPerRead", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgBytesPerRead", value);
            }
        }

        public System.UInt32? AvgBytesPerReadBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgBytesPerRead_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgBytesPerRead_Base", value);
            }
        }

        public System.UInt64? AvgBytesPerWrite
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgBytesPerWrite", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgBytesPerWrite", value);
            }
        }

        public System.UInt32? AvgBytesPerWriteBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgBytesPerWrite_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgBytesPerWrite_Base", value);
            }
        }

        public System.UInt64? AvgDataBytesPerRequest
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgDataBytesPerRequest", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDataBytesPerRequest", value);
            }
        }

        public System.UInt32? AvgDataBytesPerRequestBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgDataBytesPerRequest_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDataBytesPerRequest_Base", value);
            }
        }

        public System.UInt64? AvgDataQueueLength
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgDataQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDataQueueLength", value);
            }
        }

        public System.UInt64? AvgReadQueueLength
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgReadQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgReadQueueLength", value);
            }
        }

        public System.UInt32? AvgsecPerDataRequest
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgsecPerDataRequest", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgsecPerDataRequest", value);
            }
        }

        public System.UInt32? AvgsecPerDataRequestBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgsecPerDataRequest_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgsecPerDataRequest_Base", value);
            }
        }

        public System.UInt32? AvgsecPerRead
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgsecPerRead", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgsecPerRead", value);
            }
        }

        public System.UInt32? AvgsecPerReadBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgsecPerRead_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgsecPerRead_Base", value);
            }
        }

        public System.UInt32? AvgsecPerRequest
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgsecPerRequest", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgsecPerRequest", value);
            }
        }

        public System.UInt32? AvgsecPerRequestBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgsecPerRequest_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgsecPerRequest_Base", value);
            }
        }

        public System.UInt32? AvgsecPerWrite
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgsecPerWrite", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgsecPerWrite", value);
            }
        }

        public System.UInt32? AvgsecPerWriteBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgsecPerWrite_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgsecPerWrite_Base", value);
            }
        }

        public System.UInt64? AvgWriteQueueLength
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgWriteQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgWriteQueueLength", value);
            }
        }

        public System.UInt64? BytesCompressedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesCompressedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesCompressedPersec", value);
            }
        }

        public System.UInt64? CompressedRequestsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CompressedRequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompressedRequestsPersec", value);
            }
        }

        public System.UInt64? CompressedResponsesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CompressedResponsesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompressedResponsesPersec", value);
            }
        }

        public System.UInt64? CurrentBypassOpenFileCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CurrentBypassOpenFileCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentBypassOpenFileCount", value);
            }
        }

        public System.UInt64? CurrentDataQueueLength
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CurrentDataQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentDataQueueLength", value);
            }
        }

        public System.UInt64? CurrentDurableOpenFileCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CurrentDurableOpenFileCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentDurableOpenFileCount", value);
            }
        }

        public System.UInt64? CurrentOpenFileCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CurrentOpenFileCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentOpenFileCount", value);
            }
        }

        public System.UInt64? CurrentPendingRequests
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CurrentPendingRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentPendingRequests", value);
            }
        }

        public System.UInt64? DataBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DataBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DataBytesPersec", value);
            }
        }

        public System.UInt32? DataRequestsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DataRequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DataRequestsPersec", value);
            }
        }

        public System.UInt64? FilesOpenedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FilesOpenedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FilesOpenedPersec", value);
            }
        }

        public System.UInt64? MetadataRequestsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MetadataRequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MetadataRequestsPersec", value);
            }
        }

        public System.UInt64? PercentPersistentHandles
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentPersistentHandles", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentPersistentHandles", value);
            }
        }

        public System.UInt64? PercentPersistentHandlesBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentPersistentHandles_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentPersistentHandles_Base", value);
            }
        }

        public System.UInt64? PercentResilientHandles
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentResilientHandles", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentResilientHandles", value);
            }
        }

        public System.UInt64? PercentResilientHandlesBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentResilientHandles_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentResilientHandles_Base", value);
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

        public System.UInt64? ReadBytestransmittedByPassCSVPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadBytestransmittedByPassCSVPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadBytestransmittedByPassCSVPersec", value);
            }
        }

        public System.UInt64? ReadBytestransmittedviaSMBDirectPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadBytestransmittedviaSMBDirectPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadBytestransmittedviaSMBDirectPersec", value);
            }
        }

        public System.UInt32? ReadRequestsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReadRequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadRequestsPersec", value);
            }
        }

        public System.UInt32? ReadRequeststransmittedviaBypassCSVPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReadRequeststransmittedviaBypassCSVPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadRequeststransmittedviaBypassCSVPersec", value);
            }
        }

        public System.UInt32? ReadRequeststransmittedviaSMBDirectPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReadRequeststransmittedviaSMBDirectPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadRequeststransmittedviaSMBDirectPersec", value);
            }
        }

        public System.UInt64? ReceivedBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceivedBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedBytesPersec", value);
            }
        }

        public System.UInt64? RequestsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsPersec", value);
            }
        }

        public System.UInt64? SentBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SentBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentBytesPersec", value);
            }
        }

        public System.UInt64? TotalDurableHandleReopenCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalDurableHandleReopenCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalDurableHandleReopenCount", value);
            }
        }

        public System.UInt64? TotalFailedDurableHandleReopenCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalFailedDurableHandleReopenCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalFailedDurableHandleReopenCount", value);
            }
        }

        public System.UInt64? TotalFailedPersistentHandleReopenCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalFailedPersistentHandleReopenCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalFailedPersistentHandleReopenCount", value);
            }
        }

        public System.UInt64? TotalFailedResilientHandleReopenCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalFailedResilientHandleReopenCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalFailedResilientHandleReopenCount", value);
            }
        }

        public System.UInt64? TotalFileOpenCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalFileOpenCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalFileOpenCount", value);
            }
        }

        public System.UInt64? TotalPersistentHandleReopenCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalPersistentHandleReopenCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalPersistentHandleReopenCount", value);
            }
        }

        public System.UInt64? TotalResilientHandleReopenCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalResilientHandleReopenCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalResilientHandleReopenCount", value);
            }
        }

        public System.UInt64? TransferredBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TransferredBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransferredBytesPersec", value);
            }
        }

        public System.UInt64? TreeConnectCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TreeConnectCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("TreeConnectCount", value);
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

        public System.UInt64? WriteBytestransmittedByPassCSVPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteBytestransmittedByPassCSVPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteBytestransmittedByPassCSVPersec", value);
            }
        }

        public System.UInt64? WriteBytestransmittedviaSMBDirectPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteBytestransmittedviaSMBDirectPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteBytestransmittedviaSMBDirectPersec", value);
            }
        }

        public System.UInt32? WriteRequestsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WriteRequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteRequestsPersec", value);
            }
        }

        public System.UInt32? WriteRequeststransmittedviaBypassCSVPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WriteRequeststransmittedviaBypassCSVPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteRequeststransmittedviaBypassCSVPersec", value);
            }
        }

        public System.UInt32? WriteRequeststransmittedviaSMBDirectPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WriteRequeststransmittedviaSMBDirectPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteRequeststransmittedviaSMBDirectPersec", value);
            }
        }
    }
}