using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DefragAnalysis : GenericInfrastructureObject
    {
        public Win32DefragAnalysis()
        {
        }

        public Win32DefragAnalysis(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AverageFileSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageFileSize", out result);
                return result;
            }
        }

        public System.Double? AverageFragmentsPerFile
        {
            get
            {
                System.Double? result;
                this.GetProperty("AverageFragmentsPerFile", out result);
                return result;
            }
        }

        public System.UInt64? AverageFreeSpacePerExtent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AverageFreeSpacePerExtent", out result);
                return result;
            }
        }

        public System.UInt64? ClusterSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ClusterSize", out result);
                return result;
            }
        }

        public System.UInt64? ExcessFolderFragments
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ExcessFolderFragments", out result);
                return result;
            }
        }

        public System.UInt32? FilePercentFragmentation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FilePercentFragmentation", out result);
                return result;
            }
        }

        public System.UInt64? FragmentedFolders
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FragmentedFolders", out result);
                return result;
            }
        }

        public System.UInt64? FreeSpace
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FreeSpace", out result);
                return result;
            }
        }

        public System.UInt32? FreeSpacePercent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FreeSpacePercent", out result);
                return result;
            }
        }

        public System.UInt32? FreeSpacePercentFragmentation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FreeSpacePercentFragmentation", out result);
                return result;
            }
        }

        public System.UInt64? LargestFreeSpaceExtent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LargestFreeSpaceExtent", out result);
                return result;
            }
        }

        public System.UInt32? MFTPercentInUse
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MFTPercentInUse", out result);
                return result;
            }
        }

        public System.UInt64? MFTRecordCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MFTRecordCount", out result);
                return result;
            }
        }

        public System.UInt64? PageFileSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageFileSize", out result);
                return result;
            }
        }

        public System.UInt64? TotalExcessFragments
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalExcessFragments", out result);
                return result;
            }
        }

        public System.UInt64? TotalFiles
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalFiles", out result);
                return result;
            }
        }

        public System.UInt64? TotalFolders
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalFolders", out result);
                return result;
            }
        }

        public System.UInt64? TotalFragmentedFiles
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalFragmentedFiles", out result);
                return result;
            }
        }

        public System.UInt64? TotalFreeSpaceExtents
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalFreeSpaceExtents", out result);
                return result;
            }
        }

        public System.UInt64? TotalMFTFragments
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalMFTFragments", out result);
                return result;
            }
        }

        public System.UInt64? TotalMFTSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalMFTSize", out result);
                return result;
            }
        }

        public System.UInt64? TotalPageFileFragments
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalPageFileFragments", out result);
                return result;
            }
        }

        public System.UInt32? TotalPercentFragmentation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalPercentFragmentation", out result);
                return result;
            }
        }

        public System.UInt64? TotalUnmovableFiles
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalUnmovableFiles", out result);
                return result;
            }
        }

        public System.UInt64? UsedSpace
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("UsedSpace", out result);
                return result;
            }
        }

        public System.String VolumeName
        {
            get
            {
                System.String result;
                this.GetProperty("VolumeName", out result);
                return result;
            }
        }

        public System.UInt64? VolumeSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VolumeSize", out result);
                return result;
            }
        }
    }
}