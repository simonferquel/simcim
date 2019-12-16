using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataPerfDiskLogicalDisk : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataPerfDiskLogicalDisk()
        {
        }

        public Win32PerfFormattedDataPerfDiskLogicalDisk(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AvgDiskBytesPerRead
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgDiskBytesPerRead", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDiskBytesPerRead", value);
            }
        }

        public System.UInt64? AvgDiskBytesPerTransfer
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgDiskBytesPerTransfer", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDiskBytesPerTransfer", value);
            }
        }

        public System.UInt64? AvgDiskBytesPerWrite
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgDiskBytesPerWrite", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDiskBytesPerWrite", value);
            }
        }

        public System.UInt64? AvgDiskQueueLength
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgDiskQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDiskQueueLength", value);
            }
        }

        public System.UInt64? AvgDiskReadQueueLength
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgDiskReadQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDiskReadQueueLength", value);
            }
        }

        public System.UInt32? AvgDisksecPerRead
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgDisksecPerRead", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDisksecPerRead", value);
            }
        }

        public System.UInt32? AvgDisksecPerTransfer
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgDisksecPerTransfer", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDisksecPerTransfer", value);
            }
        }

        public System.UInt32? AvgDisksecPerWrite
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgDisksecPerWrite", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDisksecPerWrite", value);
            }
        }

        public System.UInt64? AvgDiskWriteQueueLength
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgDiskWriteQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDiskWriteQueueLength", value);
            }
        }

        public System.UInt32? CurrentDiskQueueLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentDiskQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentDiskQueueLength", value);
            }
        }

        public System.UInt64? DiskBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DiskBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DiskBytesPersec", value);
            }
        }

        public System.UInt64? DiskReadBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DiskReadBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DiskReadBytesPersec", value);
            }
        }

        public System.UInt32? DiskReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DiskReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DiskReadsPersec", value);
            }
        }

        public System.UInt32? DiskTransfersPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DiskTransfersPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DiskTransfersPersec", value);
            }
        }

        public System.UInt64? DiskWriteBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DiskWriteBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DiskWriteBytesPersec", value);
            }
        }

        public System.UInt32? DiskWritesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DiskWritesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DiskWritesPersec", value);
            }
        }

        public System.UInt32? FreeMegabytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FreeMegabytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("FreeMegabytes", value);
            }
        }

        public System.UInt64? PercentDiskReadTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentDiskReadTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentDiskReadTime", value);
            }
        }

        public System.UInt64? PercentDiskTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentDiskTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentDiskTime", value);
            }
        }

        public System.UInt64? PercentDiskWriteTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentDiskWriteTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentDiskWriteTime", value);
            }
        }

        public System.UInt32? PercentFreeSpace
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentFreeSpace", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentFreeSpace", value);
            }
        }

        public System.UInt64? PercentIdleTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentIdleTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentIdleTime", value);
            }
        }

        public System.UInt32? SplitIOPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SplitIOPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SplitIOPerSec", value);
            }
        }
    }
}