using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataWindowsMediaPlayerWindowsMediaPlayerMetadata : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataWindowsMediaPlayerWindowsMediaPlayerMetadata()
        {
        }

        public Win32PerfFormattedDataWindowsMediaPlayerWindowsMediaPlayerMetadata(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AFTSExecutionTimems
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AFTSExecutionTimems", out result);
                return result;
            }

            set
            {
                this.SetProperty("AFTSExecutionTimems", value);
            }
        }

        public System.UInt32? ArtExtractionTimems
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ArtExtractionTimems", out result);
                return result;
            }

            set
            {
                this.SetProperty("ArtExtractionTimems", value);
            }
        }

        public System.UInt32? CommitTimems
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CommitTimems", out result);
                return result;
            }

            set
            {
                this.SetProperty("CommitTimems", value);
            }
        }

        public System.UInt32? DirectoryChangeQueueLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DirectoryChangeQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("DirectoryChangeQueueLength", value);
            }
        }

        public System.UInt32? DirtyDirectoryHitCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DirtyDirectoryHitCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("DirtyDirectoryHitCount", value);
            }
        }

        public System.UInt32? FileScanningThreadPrioirty
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FileScanningThreadPrioirty", out result);
                return result;
            }

            set
            {
                this.SetProperty("FileScanningThreadPrioirty", value);
            }
        }

        public System.UInt64? FilesScannedPerMinute
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FilesScannedPerMinute", out result);
                return result;
            }

            set
            {
                this.SetProperty("FilesScannedPerMinute", value);
            }
        }

        public System.UInt64? GrovelerServiceRoutineExecutionsPerSecond
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("GrovelerServiceRoutineExecutionsPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("GrovelerServiceRoutineExecutionsPerSecond", value);
            }
        }

        public System.UInt64? LibraryDescriptionChangeNotificationsPerSecond
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LibraryDescriptionChangeNotificationsPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("LibraryDescriptionChangeNotificationsPerSecond", value);
            }
        }

        public System.UInt64? LibraryDescriptionUpdatesPerSecond
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LibraryDescriptionUpdatesPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("LibraryDescriptionUpdatesPerSecond", value);
            }
        }

        public System.UInt64? MonitoredFolderUpdatesPerSecond
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MonitoredFolderUpdatesPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("MonitoredFolderUpdatesPerSecond", value);
            }
        }

        public System.UInt32? NormalizationTimems
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NormalizationTimems", out result);
                return result;
            }

            set
            {
                this.SetProperty("NormalizationTimems", value);
            }
        }

        public System.UInt32? PropertyExtractionTimems
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PropertyExtractionTimems", out result);
                return result;
            }

            set
            {
                this.SetProperty("PropertyExtractionTimems", value);
            }
        }

        public System.UInt32? ReorganizeTimems
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReorganizeTimems", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReorganizeTimems", value);
            }
        }

        public System.UInt32? ScanningState
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ScanningState", out result);
                return result;
            }

            set
            {
                this.SetProperty("ScanningState", value);
            }
        }

        public System.UInt32? TimestampDirectoryHitCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TimestampDirectoryHitCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimestampDirectoryHitCount", value);
            }
        }

        public System.UInt32? URLClassificationTimems
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("URLClassificationTimems", out result);
                return result;
            }

            set
            {
                this.SetProperty("URLClassificationTimems", value);
            }
        }
    }
}