using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersReFS : Win32PerfRawData
    {
        public Win32PerfRawDataCountersReFS()
        {
        }

        public Win32PerfRawDataCountersReFS(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AllocationofDataClustersonFastTierPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AllocationofDataClustersonFastTierPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllocationofDataClustersonFastTierPersec", value);
            }
        }

        public System.UInt64? AllocationofDataClustersonSlowTierPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AllocationofDataClustersonSlowTierPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllocationofDataClustersonSlowTierPersec", value);
            }
        }

        public System.UInt64? AllocationofMetadataClustersonFastTierPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AllocationofMetadataClustersonFastTierPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllocationofMetadataClustersonFastTierPersec", value);
            }
        }

        public System.UInt64? AllocationofMetadataClustersonSlowTierPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AllocationofMetadataClustersonSlowTierPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllocationofMetadataClustersonSlowTierPersec", value);
            }
        }

        public System.UInt64? Checkpointlatency100ns
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Checkpointlatency100ns", out result);
                return result;
            }

            set
            {
                this.SetProperty("Checkpointlatency100ns", value);
            }
        }

        public System.UInt32? Checkpointlatency100nsBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Checkpointlatency100ns_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("Checkpointlatency100ns_Base", value);
            }
        }

        public System.UInt64? CheckpointsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CheckpointsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CheckpointsPersec", value);
            }
        }

        public System.UInt64? CompactedContainerFillRatioPercent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CompactedContainerFillRatioPercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompactedContainerFillRatioPercent", value);
            }
        }

        public System.UInt32? CompactedContainerFillRatioPercentBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CompactedContainerFillRatioPercent_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompactedContainerFillRatioPercent_Base", value);
            }
        }

        public System.UInt32? CompactionFailureCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CompactionFailureCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompactionFailureCount", value);
            }
        }

        public System.UInt64? Compactionreadlatency100ns
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Compactionreadlatency100ns", out result);
                return result;
            }

            set
            {
                this.SetProperty("Compactionreadlatency100ns", value);
            }
        }

        public System.UInt32? Compactionreadlatency100nsBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Compactionreadlatency100ns_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("Compactionreadlatency100ns_Base", value);
            }
        }

        public System.UInt32? Compactionsfailedduetoineligiblecontainer
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Compactionsfailedduetoineligiblecontainer", out result);
                return result;
            }

            set
            {
                this.SetProperty("Compactionsfailedduetoineligiblecontainer", value);
            }
        }

        public System.UInt32? Compactionsfailedduetomaxfragmentation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Compactionsfailedduetomaxfragmentation", out result);
                return result;
            }

            set
            {
                this.SetProperty("Compactionsfailedduetomaxfragmentation", value);
            }
        }

        public System.UInt64? Compactionwritelatency100ns
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Compactionwritelatency100ns", out result);
                return result;
            }

            set
            {
                this.SetProperty("Compactionwritelatency100ns", value);
            }
        }

        public System.UInt32? Compactionwritelatency100nsBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Compactionwritelatency100ns_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("Compactionwritelatency100ns_Base", value);
            }
        }

        public System.UInt64? ContainerDestagesFromFastTierPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ContainerDestagesFromFastTierPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ContainerDestagesFromFastTierPersec", value);
            }
        }

        public System.UInt64? ContainerDestagesFromSlowTierPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ContainerDestagesFromSlowTierPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ContainerDestagesFromSlowTierPersec", value);
            }
        }

        public System.UInt32? ContainerMoveFailureCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ContainerMoveFailureCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("ContainerMoveFailureCount", value);
            }
        }

        public System.UInt32? ContainerMoveRetryCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ContainerMoveRetryCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("ContainerMoveRetryCount", value);
            }
        }

        public System.UInt32? Containermovesfailedduetoineligiblecontainer
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Containermovesfailedduetoineligiblecontainer", out result);
                return result;
            }

            set
            {
                this.SetProperty("Containermovesfailedduetoineligiblecontainer", value);
            }
        }

        public System.UInt32? CurrentFastTierDataFillPercentage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentFastTierDataFillPercentage", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentFastTierDataFillPercentage", value);
            }
        }

        public System.UInt32? CurrentFastTierMetadataFillPercentage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentFastTierMetadataFillPercentage", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentFastTierMetadataFillPercentage", value);
            }
        }

        public System.UInt32? CurrentSlowTierDataFillPercentage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentSlowTierDataFillPercentage", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentSlowTierDataFillPercentage", value);
            }
        }

        public System.UInt32? CurrentSlowTierMetadataFillPercentage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentSlowTierMetadataFillPercentage", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentSlowTierMetadataFillPercentage", value);
            }
        }

        public System.UInt64? DataCompactionsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DataCompactionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DataCompactionsPersec", value);
            }
        }

        public System.UInt64? DataInPlaceWriteClustersPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DataInPlaceWriteClustersPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DataInPlaceWriteClustersPersec", value);
            }
        }

        public System.UInt32? DeleteQueueentries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DeleteQueueentries", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeleteQueueentries", value);
            }
        }

        public System.UInt64? Dirtymetadatapages
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Dirtymetadatapages", out result);
                return result;
            }

            set
            {
                this.SetProperty("Dirtymetadatapages", value);
            }
        }

        public System.UInt32? Dirtytablelistentries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Dirtytablelistentries", out result);
                return result;
            }

            set
            {
                this.SetProperty("Dirtytablelistentries", value);
            }
        }

        public System.UInt64? FastTierDestagedContainerFillRatioPercent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FastTierDestagedContainerFillRatioPercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("FastTierDestagedContainerFillRatioPercent", value);
            }
        }

        public System.UInt32? FastTierDestagedContainerFillRatioPercentBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FastTierDestagedContainerFillRatioPercent_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("FastTierDestagedContainerFillRatioPercent_Base", value);
            }
        }

        public System.UInt64? Fasttierdestagereadlatency100ns
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Fasttierdestagereadlatency100ns", out result);
                return result;
            }

            set
            {
                this.SetProperty("Fasttierdestagereadlatency100ns", value);
            }
        }

        public System.UInt32? Fasttierdestagereadlatency100nsBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Fasttierdestagereadlatency100ns_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("Fasttierdestagereadlatency100ns_Base", value);
            }
        }

        public System.UInt64? Fasttierdestagewritelatency100ns
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Fasttierdestagewritelatency100ns", out result);
                return result;
            }

            set
            {
                this.SetProperty("Fasttierdestagewritelatency100ns", value);
            }
        }

        public System.UInt32? Fasttierdestagewritelatency100nsBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Fasttierdestagewritelatency100ns_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("Fasttierdestagewritelatency100ns_Base", value);
            }
        }

        public System.UInt32? Logfillpercentage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Logfillpercentage", out result);
                return result;
            }

            set
            {
                this.SetProperty("Logfillpercentage", value);
            }
        }

        public System.UInt64? LogwritesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LogwritesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogwritesPersec", value);
            }
        }

        public System.UInt64? SlowTierDestagedContainerFillRatioPercent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SlowTierDestagedContainerFillRatioPercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("SlowTierDestagedContainerFillRatioPercent", value);
            }
        }

        public System.UInt32? SlowTierDestagedContainerFillRatioPercentBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SlowTierDestagedContainerFillRatioPercent_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("SlowTierDestagedContainerFillRatioPercent_Base", value);
            }
        }

        public System.UInt64? Slowtierdestagereadlatency100ns
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Slowtierdestagereadlatency100ns", out result);
                return result;
            }

            set
            {
                this.SetProperty("Slowtierdestagereadlatency100ns", value);
            }
        }

        public System.UInt32? Slowtierdestagereadlatency100nsBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Slowtierdestagereadlatency100ns_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("Slowtierdestagereadlatency100ns_Base", value);
            }
        }

        public System.UInt64? Slowtierdestagewritelatency100ns
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Slowtierdestagewritelatency100ns", out result);
                return result;
            }

            set
            {
                this.SetProperty("Slowtierdestagewritelatency100ns", value);
            }
        }

        public System.UInt32? Slowtierdestagewritelatency100nsBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Slowtierdestagewritelatency100ns_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("Slowtierdestagewritelatency100ns_Base", value);
            }
        }

        public System.UInt64? TotalAllocationofClustersPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalAllocationofClustersPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalAllocationofClustersPersec", value);
            }
        }

        public System.UInt64? Treeupdatelatency100ns
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Treeupdatelatency100ns", out result);
                return result;
            }

            set
            {
                this.SetProperty("Treeupdatelatency100ns", value);
            }
        }

        public System.UInt32? Treeupdatelatency100nsBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Treeupdatelatency100ns_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("Treeupdatelatency100ns_Base", value);
            }
        }

        public System.UInt64? TreeupdatesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TreeupdatesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TreeupdatesPersec", value);
            }
        }

        public System.UInt64? Trimlatency100ns
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Trimlatency100ns", out result);
                return result;
            }

            set
            {
                this.SetProperty("Trimlatency100ns", value);
            }
        }

        public System.UInt32? Trimlatency100nsBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Trimlatency100ns_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("Trimlatency100ns_Base", value);
            }
        }
    }
}