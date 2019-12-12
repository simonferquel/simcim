using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersSMBClientShares : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersSMBClientShares()
        {
        }

        public Win32PerfFormattedDataCountersSMBClientShares(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt32? CompressedBytesSentPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CompressedBytesSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompressedBytesSentPersec", value);
            }
        }

        public System.UInt32? CompressedRequestsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CompressedRequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompressedRequestsPersec", value);
            }
        }

        public System.UInt32? CompressedResponsesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CompressedResponsesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompressedResponsesPersec", value);
            }
        }

        public System.UInt32? CreditStallsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CreditStallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CreditStallsPersec", value);
            }
        }

        public System.UInt32? CurrentDataQueueLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentDataQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentDataQueueLength", value);
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

        public System.UInt32? MetadataRequestsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MetadataRequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MetadataRequestsPersec", value);
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

        public System.UInt32? TurboIOReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TurboIOReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TurboIOReadsPersec", value);
            }
        }

        public System.UInt32? TurboIOWritesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TurboIOWritesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TurboIOWritesPersec", value);
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