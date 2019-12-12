using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataPerfDiskPhysicalDisk : Win32PerfRawData
    {
        public Win32PerfRawDataPerfDiskPhysicalDisk()
        {
        }

        public Win32PerfRawDataPerfDiskPhysicalDisk(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt32? AvgDiskBytesPerReadBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgDiskBytesPerRead_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDiskBytesPerRead_Base", value);
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

        public System.UInt32? AvgDiskBytesPerTransferBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgDiskBytesPerTransfer_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDiskBytesPerTransfer_Base", value);
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

        public System.UInt32? AvgDiskBytesPerWriteBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgDiskBytesPerWrite_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDiskBytesPerWrite_Base", value);
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

        public System.UInt32? AvgDisksecPerReadBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgDisksecPerRead_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDisksecPerRead_Base", value);
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

        public System.UInt32? AvgDisksecPerTransferBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgDisksecPerTransfer_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDisksecPerTransfer_Base", value);
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

        public System.UInt32? AvgDisksecPerWriteBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgDisksecPerWrite_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDisksecPerWrite_Base", value);
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

        public System.UInt64? PercentDiskReadTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentDiskReadTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentDiskReadTime_Base", value);
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

        public System.UInt64? PercentDiskTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentDiskTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentDiskTime_Base", value);
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

        public System.UInt64? PercentDiskWriteTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentDiskWriteTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentDiskWriteTime_Base", value);
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

        public System.UInt64? PercentIdleTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentIdleTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentIdleTime_Base", value);
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