using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataESENTDatabaseInstances : Win32PerfRawData
    {
        public Win32PerfRawDataESENTDatabaseInstances()
        {
        }

        public Win32PerfRawDataESENTDatabaseInstances(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.UInt32? DatabaseCacheMissAttachedAverageLatencyBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatabaseCacheMissAttachedAverageLatency_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCacheMissAttachedAverageLatency_Base", value);
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

        public System.UInt32? DatabaseCachePercentHitBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatabaseCachePercentHit_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCachePercentHit_Base", value);
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

        public System.UInt32? DatabaseCachePercentHitUniqueBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatabaseCachePercentHitUnique_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseCachePercentHitUnique_Base", value);
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

        public System.UInt64? DatabaseOldestTransaction
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DatabaseOldestTransaction", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatabaseOldestTransaction", value);
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

        public System.UInt32? IODatabaseReadsAttachedAverageLatencyBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IODatabaseReadsAttachedAverageLatency_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseReadsAttachedAverageLatency_Base", value);
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

        public System.UInt32? IODatabaseReadsAverageLatencyBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IODatabaseReadsAverageLatency_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseReadsAverageLatency_Base", value);
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

        public System.UInt32? IODatabaseReadsRecoveryAverageLatencyBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IODatabaseReadsRecoveryAverageLatency_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseReadsRecoveryAverageLatency_Base", value);
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

        public System.UInt32? IODatabaseWritesAttachedAverageLatencyBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IODatabaseWritesAttachedAverageLatency_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseWritesAttachedAverageLatency_Base", value);
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

        public System.UInt32? IODatabaseWritesAverageLatencyBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IODatabaseWritesAverageLatency_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseWritesAverageLatency_Base", value);
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

        public System.UInt32? IODatabaseWritesRecoveryAverageLatencyBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IODatabaseWritesRecoveryAverageLatency_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODatabaseWritesRecoveryAverageLatency_Base", value);
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

        public System.UInt32? IOFlushMapWritesAverageLatencyBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IOFlushMapWritesAverageLatency_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOFlushMapWritesAverageLatency_Base", value);
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

        public System.UInt32? IOLogReadsAverageLatencyBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IOLogReadsAverageLatency_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOLogReadsAverageLatency_Base", value);
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

        public System.UInt32? IOLogWritesAverageLatencyBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IOLogWritesAverageLatency_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOLogWritesAverageLatency_Base", value);
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

        public System.UInt32? LogCheckpointDepthasaPercentofTarget
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogCheckpointDepthasaPercentofTarget", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogCheckpointDepthasaPercentofTarget", value);
            }
        }

        public System.UInt32? LogCheckpointDepthasaPercentofTargetBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogCheckpointDepthasaPercentofTarget_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogCheckpointDepthasaPercentofTarget_Base", value);
            }
        }

        public System.UInt32? LogFileCurrentGeneration
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogFileCurrentGeneration", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogFileCurrentGeneration", value);
            }
        }

        public System.UInt32? LogFilesGenerated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogFilesGenerated", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogFilesGenerated", value);
            }
        }

        public System.UInt32? LogFilesGeneratedPrematurely
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogFilesGeneratedPrematurely", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogFilesGeneratedPrematurely", value);
            }
        }

        public System.UInt32? LogGenerationCheckpointDepth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogGenerationCheckpointDepth", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogGenerationCheckpointDepth", value);
            }
        }

        public System.UInt32? LogGenerationCheckpointDepthMax
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogGenerationCheckpointDepthMax", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogGenerationCheckpointDepthMax", value);
            }
        }

        public System.UInt32? LogGenerationCheckpointDepthTarget
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogGenerationCheckpointDepthTarget", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogGenerationCheckpointDepthTarget", value);
            }
        }

        public System.UInt32? LogGenerationLossResiliencyDepth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogGenerationLossResiliencyDepth", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogGenerationLossResiliencyDepth", value);
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

        public System.UInt32? SessionsPercentUsedBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionsPercentUsed_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionsPercentUsed_Base", value);
            }
        }

        public System.UInt32? StreamingBackupPagesReadPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StreamingBackupPagesReadPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("StreamingBackupPagesReadPersec", value);
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

        public System.UInt32? TableOpenCachePercentHitBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TableOpenCachePercentHit_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("TableOpenCachePercentHit_Base", value);
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

        public System.UInt32? Versionbucketsallocated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Versionbucketsallocated", out result);
                return result;
            }

            set
            {
                this.SetProperty("Versionbucketsallocated", value);
            }
        }
    }
}