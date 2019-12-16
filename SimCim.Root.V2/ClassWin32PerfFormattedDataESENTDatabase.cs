using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataESENTDatabase : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataESENTDatabase()
        {
        }

        public Win32PerfFormattedDataESENTDatabase(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? DatabaseCacheMemoryCommitted
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DatabaseCacheMemoryCommitted", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCacheMemoryCommitted", value);
            }
        }

        public System.UInt64? DatabaseCacheMemoryCommittedMB
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DatabaseCacheMemoryCommittedMB", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCacheMemoryCommittedMB", value);
            }
        }

        public System.UInt64? DatabaseCacheMemoryReserved
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DatabaseCacheMemoryReserved", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCacheMemoryReserved", value);
            }
        }

        public System.UInt64? DatabaseCacheMemoryReservedMB
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DatabaseCacheMemoryReservedMB", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCacheMemoryReservedMB", value);
            }
        }

        public System.UInt64? DatabaseCacheMissAttachedAverageLatency
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DatabaseCacheMissAttachedAverageLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCacheMissAttachedAverageLatency", value);
            }
        }

        public System.UInt32? DatabaseCacheMissesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatabaseCacheMissesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCacheMissesPersec", value);
            }
        }

        public System.UInt32? DatabaseCachePercentDehydrated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatabaseCachePercentDehydrated", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCachePercentDehydrated", value);
            }
        }

        public System.UInt32? DatabaseCachePercentHit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatabaseCachePercentHit", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCachePercentHit", value);
            }
        }

        public System.UInt32? DatabaseCachePercentHitUnique
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatabaseCachePercentHitUnique", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCachePercentHitUnique", value);
            }
        }

        public System.UInt32? DatabaseCacheRequestsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatabaseCacheRequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCacheRequestsPersec", value);
            }
        }

        public System.UInt32? DatabaseCacheRequestsPersecUnique
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatabaseCacheRequestsPersecUnique", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCacheRequestsPersecUnique", value);
            }
        }

        public System.UInt64? DatabaseCacheSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DatabaseCacheSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCacheSize", value);
            }
        }

        public System.UInt64? DatabaseCacheSizeEffective
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DatabaseCacheSizeEffective", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCacheSizeEffective", value);
            }
        }

        public System.UInt64? DatabaseCacheSizeEffectiveMB
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DatabaseCacheSizeEffectiveMB", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCacheSizeEffectiveMB", value);
            }
        }

        public System.UInt64? DatabaseCacheSizeMB
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DatabaseCacheSizeMB", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCacheSizeMB", value);
            }
        }

        public System.UInt64? DatabaseCacheSizeResident
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DatabaseCacheSizeResident", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCacheSizeResident", value);
            }
        }

        public System.UInt64? DatabaseCacheSizeResidentMB
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DatabaseCacheSizeResidentMB", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCacheSizeResidentMB", value);
            }
        }

        public System.UInt32? DatabaseMaintenanceDuration
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatabaseMaintenanceDuration", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseMaintenanceDuration", value);
            }
        }

        public System.UInt32? DatabasePageEvictionsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatabasePageEvictionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabasePageEvictionsPersec", value);
            }
        }

        public System.UInt32? DatabasePageFaultsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatabasePageFaultsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabasePageFaultsPersec", value);
            }
        }

        public System.UInt32? DatabasePageFaultStallsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatabasePageFaultStallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabasePageFaultStallsPersec", value);
            }
        }

        public System.UInt32? DefragmentationTasks
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DefragmentationTasks", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefragmentationTasks", value);
            }
        }

        public System.UInt32? DefragmentationTasksPending
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DefragmentationTasksPending", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefragmentationTasksPending", value);
            }
        }

        public System.UInt64? IODatabaseReadsAttachedAverageLatency
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IODatabaseReadsAttachedAverageLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseReadsAttachedAverageLatency", value);
            }
        }

        public System.UInt32? IODatabaseReadsAttachedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IODatabaseReadsAttachedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseReadsAttachedPersec", value);
            }
        }

        public System.UInt64? IODatabaseReadsAverageLatency
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IODatabaseReadsAverageLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseReadsAverageLatency", value);
            }
        }

        public System.UInt32? IODatabaseReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IODatabaseReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseReadsPersec", value);
            }
        }

        public System.UInt64? IODatabaseReadsRecoveryAverageLatency
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IODatabaseReadsRecoveryAverageLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseReadsRecoveryAverageLatency", value);
            }
        }

        public System.UInt32? IODatabaseReadsRecoveryPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IODatabaseReadsRecoveryPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseReadsRecoveryPersec", value);
            }
        }

        public System.UInt64? IODatabaseWritesAttachedAverageLatency
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IODatabaseWritesAttachedAverageLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseWritesAttachedAverageLatency", value);
            }
        }

        public System.UInt32? IODatabaseWritesAttachedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IODatabaseWritesAttachedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseWritesAttachedPersec", value);
            }
        }

        public System.UInt64? IODatabaseWritesAverageLatency
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IODatabaseWritesAverageLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseWritesAverageLatency", value);
            }
        }

        public System.UInt32? IODatabaseWritesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IODatabaseWritesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseWritesPersec", value);
            }
        }

        public System.UInt64? IODatabaseWritesRecoveryAverageLatency
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IODatabaseWritesRecoveryAverageLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseWritesRecoveryAverageLatency", value);
            }
        }

        public System.UInt32? IODatabaseWritesRecoveryPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IODatabaseWritesRecoveryPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseWritesRecoveryPersec", value);
            }
        }

        public System.UInt64? IOFlushMapWritesAverageLatency
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOFlushMapWritesAverageLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOFlushMapWritesAverageLatency", value);
            }
        }

        public System.UInt32? IOFlushMapWritesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IOFlushMapWritesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOFlushMapWritesPersec", value);
            }
        }

        public System.UInt64? IOLogReadsAverageLatency
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOLogReadsAverageLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOLogReadsAverageLatency", value);
            }
        }

        public System.UInt32? IOLogReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IOLogReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOLogReadsPersec", value);
            }
        }

        public System.UInt64? IOLogWritesAverageLatency
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOLogWritesAverageLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOLogWritesAverageLatency", value);
            }
        }

        public System.UInt32? IOLogWritesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IOLogWritesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOLogWritesPersec", value);
            }
        }

        public System.UInt32? LogBytesGeneratedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogBytesGeneratedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogBytesGeneratedPersec", value);
            }
        }

        public System.UInt32? LogBytesWritePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogBytesWritePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogBytesWritePersec", value);
            }
        }

        public System.UInt32? LogRecordStallsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogRecordStallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogRecordStallsPersec", value);
            }
        }

        public System.UInt32? LogThreadsWaiting
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogThreadsWaiting", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogThreadsWaiting", value);
            }
        }

        public System.UInt32? LogWritesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogWritesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogWritesPersec", value);
            }
        }

        public System.UInt32? SessionsInUse
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionsInUse", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionsInUse", value);
            }
        }

        public System.UInt32? SessionsPercentUsed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionsPercentUsed", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionsPercentUsed", value);
            }
        }

        public System.UInt32? TableClosesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TableClosesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TableClosesPersec", value);
            }
        }

        public System.UInt32? TableOpenCacheHitsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TableOpenCacheHitsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TableOpenCacheHitsPersec", value);
            }
        }

        public System.UInt32? TableOpenCacheMissesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TableOpenCacheMissesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TableOpenCacheMissesPersec", value);
            }
        }

        public System.UInt32? TableOpenCachePercentHit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TableOpenCachePercentHit", out result);
                return result;
            }

            set
            {
                this.SetProperty("TableOpenCachePercentHit", value);
            }
        }

        public System.UInt32? TableOpensPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TableOpensPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TableOpensPersec", value);
            }
        }

        public System.UInt32? TablesOpen
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TablesOpen", out result);
                return result;
            }

            set
            {
                this.SetProperty("TablesOpen", value);
            }
        }

        public System.UInt32? VersionBucketsAllocated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VersionBucketsAllocated", out result);
                return result;
            }

            set
            {
                this.SetProperty("VersionBucketsAllocated", value);
            }
        }
    }
}