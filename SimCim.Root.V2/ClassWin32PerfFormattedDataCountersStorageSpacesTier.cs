using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersStorageSpacesTier : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersStorageSpacesTier()
        {
        }

        public Win32PerfFormattedDataCountersStorageSpacesTier(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? TierReadBytesAverage
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TierReadBytesAverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("TierReadBytesAverage", value);
            }
        }

        public System.UInt64? TierReadBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TierReadBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TierReadBytesPersec", value);
            }
        }

        public System.UInt32? TierReadLatency
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TierReadLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("TierReadLatency", value);
            }
        }

        public System.UInt64? TierReadsAverage
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TierReadsAverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("TierReadsAverage", value);
            }
        }

        public System.UInt64? TierReadsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TierReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TierReadsPersec", value);
            }
        }

        public System.UInt64? TierTransferBytesAverage
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TierTransferBytesAverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("TierTransferBytesAverage", value);
            }
        }

        public System.UInt64? TierTransferBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TierTransferBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TierTransferBytesPersec", value);
            }
        }

        public System.UInt32? TierTransferLatency
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TierTransferLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("TierTransferLatency", value);
            }
        }

        public System.UInt64? TierTransfersAverage
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TierTransfersAverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("TierTransfersAverage", value);
            }
        }

        public System.UInt32? TierTransfersCurrent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TierTransfersCurrent", out result);
                return result;
            }

            set
            {
                this.SetProperty("TierTransfersCurrent", value);
            }
        }

        public System.UInt64? TierTransfersPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TierTransfersPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TierTransfersPersec", value);
            }
        }

        public System.UInt64? TierWriteBytesAverage
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TierWriteBytesAverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("TierWriteBytesAverage", value);
            }
        }

        public System.UInt64? TierWriteBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TierWriteBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TierWriteBytesPersec", value);
            }
        }

        public System.UInt32? TierWriteLatency
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TierWriteLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("TierWriteLatency", value);
            }
        }

        public System.UInt64? TierWritesAverage
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TierWritesAverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("TierWritesAverage", value);
            }
        }

        public System.UInt64? TierWritesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TierWritesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TierWritesPersec", value);
            }
        }
    }
}