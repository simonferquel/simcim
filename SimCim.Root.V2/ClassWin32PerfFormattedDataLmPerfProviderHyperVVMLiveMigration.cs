using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataLmPerfProviderHyperVVMLiveMigration : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataLmPerfProviderHyperVVMLiveMigration()
        {
        }

        public Win32PerfFormattedDataLmPerfProviderHyperVVMLiveMigration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? CompressorBytestobeCompressed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CompressorBytestobeCompressed", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompressorBytestobeCompressed", value);
            }
        }

        public System.UInt64? CompressorCompressedBytesSent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CompressorCompressedBytesSent", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompressorCompressedBytesSent", value);
            }
        }

        public System.UInt64? CompressorCompressedBytesSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CompressorCompressedBytesSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompressorCompressedBytesSentPersec", value);
            }
        }

        public System.UInt64? CompressorEnabledThreads
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CompressorEnabledThreads", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompressorEnabledThreads", value);
            }
        }

        public System.UInt64? CompressorMaximumThreads
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CompressorMaximumThreads", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompressorMaximumThreads", value);
            }
        }

        public System.UInt64? MemoryWalkerBytesReadPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MemoryWalkerBytesReadPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MemoryWalkerBytesReadPersec", value);
            }
        }

        public System.UInt64? MemoryWalkerBytesSentforCompression
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MemoryWalkerBytesSentforCompression", out result);
                return result;
            }

            set
            {
                this.SetProperty("MemoryWalkerBytesSentforCompression", value);
            }
        }

        public System.UInt64? MemoryWalkerBytesSentforCompressionPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MemoryWalkerBytesSentforCompressionPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MemoryWalkerBytesSentforCompressionPersec", value);
            }
        }

        public System.UInt64? MemoryWalkerMaximumThreads
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MemoryWalkerMaximumThreads", out result);
                return result;
            }

            set
            {
                this.SetProperty("MemoryWalkerMaximumThreads", value);
            }
        }

        public System.UInt64? MemoryWalkerUncompressedBytesSent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MemoryWalkerUncompressedBytesSent", out result);
                return result;
            }

            set
            {
                this.SetProperty("MemoryWalkerUncompressedBytesSent", value);
            }
        }

        public System.UInt64? MemoryWalkerUncompressedBytesSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MemoryWalkerUncompressedBytesSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MemoryWalkerUncompressedBytesSentPersec", value);
            }
        }

        public System.UInt64? ReceiverBytesPendingDecompression
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceiverBytesPendingDecompression", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiverBytesPendingDecompression", value);
            }
        }

        public System.UInt64? ReceiverBytesPendingWrite
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceiverBytesPendingWrite", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiverBytesPendingWrite", value);
            }
        }

        public System.UInt64? ReceiverBytesWrittenPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceiverBytesWrittenPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiverBytesWrittenPersec", value);
            }
        }

        public System.UInt64? ReceiverCompressedBytesReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceiverCompressedBytesReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiverCompressedBytesReceivedPersec", value);
            }
        }

        public System.UInt64? ReceiverDecompressedBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceiverDecompressedBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiverDecompressedBytesPersec", value);
            }
        }

        public System.UInt64? ReceiverMaximumThreadpoolThreadCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceiverMaximumThreadpoolThreadCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiverMaximumThreadpoolThreadCount", value);
            }
        }

        public System.UInt64? ReceiverUncompressedBytesReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceiverUncompressedBytesReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiverUncompressedBytesReceivedPersec", value);
            }
        }

        public System.UInt64? SMBTransportBytesSent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SMBTransportBytesSent", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBTransportBytesSent", value);
            }
        }

        public System.UInt64? SMBTransportBytesSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SMBTransportBytesSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBTransportBytesSentPersec", value);
            }
        }

        public System.UInt64? SMBTransportPendingSendBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SMBTransportPendingSendBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBTransportPendingSendBytes", value);
            }
        }

        public System.UInt64? SMBTransportPendingSendCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SMBTransportPendingSendCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBTransportPendingSendCount", value);
            }
        }

        public System.UInt64? TCPTransportBytesPendingProcessing
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TCPTransportBytesPendingProcessing", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPTransportBytesPendingProcessing", value);
            }
        }

        public System.UInt64? TCPTransportBytesPendingSend
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TCPTransportBytesPendingSend", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPTransportBytesPendingSend", value);
            }
        }

        public System.UInt64? TCPTransportBytesReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TCPTransportBytesReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPTransportBytesReceivedPersec", value);
            }
        }

        public System.UInt64? TCPTransportBytesSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TCPTransportBytesSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPTransportBytesSentPersec", value);
            }
        }

        public System.UInt64? TCPTransportPendingSendCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TCPTransportPendingSendCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPTransportPendingSendCount", value);
            }
        }

        public System.UInt64? TCPTransportPostedReceiveBufferCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TCPTransportPostedReceiveBufferCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPTransportPostedReceiveBufferCount", value);
            }
        }

        public System.UInt64? TCPTransportTotalbuffercount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TCPTransportTotalbuffercount", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPTransportTotalbuffercount", value);
            }
        }

        public System.UInt64? TransferpassCPUCap
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TransferpassCPUCap", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransferpassCPUCap", value);
            }
        }

        public System.UInt64? TransferpassDirtyPageCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TransferpassDirtyPageCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransferpassDirtyPageCount", value);
            }
        }

        public System.UInt64? TransferPassIsblackout
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TransferPassIsblackout", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransferPassIsblackout", value);
            }
        }

        public System.UInt64? TransferPassNumber
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TransferPassNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransferPassNumber", value);
            }
        }
    }
}