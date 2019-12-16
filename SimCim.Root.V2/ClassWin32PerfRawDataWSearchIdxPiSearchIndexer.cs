using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataWSearchIdxPiSearchIndexer : Win32PerfRawData
    {
        public Win32PerfRawDataWSearchIdxPiSearchIndexer()
        {
        }

        public Win32PerfRawDataWSearchIdxPiSearchIndexer(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActiveConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveConnections", value);
            }
        }

        public System.UInt32? CleanWidSets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CleanWidSets", out result);
                return result;
            }

            set
            {
                this.SetProperty("CleanWidSets", value);
            }
        }

        public System.UInt32? DirtyWidSets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DirtyWidSets", out result);
                return result;
            }

            set
            {
                this.SetProperty("DirtyWidSets", value);
            }
        }

        public System.UInt32? DocumentsFiltered
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentsFiltered", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentsFiltered", value);
            }
        }

        public System.UInt32? IndexSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IndexSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("IndexSize", value);
            }
        }

        public System.UInt32? L0IndexesWordlists
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L0IndexesWordlists", out result);
                return result;
            }

            set
            {
                this.SetProperty("L0IndexesWordlists", value);
            }
        }

        public System.UInt32? L0MergeFlushCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L0MergeFlushCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("L0MergeFlushCount", value);
            }
        }

        public System.UInt32? L0MergeFlushSpeedAverage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L0MergeFlushSpeedAverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("L0MergeFlushSpeedAverage", value);
            }
        }

        public System.UInt32? L0MergeFlushSpeedLast
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L0MergeFlushSpeedLast", out result);
                return result;
            }

            set
            {
                this.SetProperty("L0MergeFlushSpeedLast", value);
            }
        }

        public System.UInt32? L0MergesflushesNow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L0MergesflushesNow", out result);
                return result;
            }

            set
            {
                this.SetProperty("L0MergesflushesNow", value);
            }
        }

        public System.UInt32? L1MergeCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L1MergeCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("L1MergeCount", value);
            }
        }

        public System.UInt32? L1MergesNow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L1MergesNow", out result);
                return result;
            }

            set
            {
                this.SetProperty("L1MergesNow", value);
            }
        }

        public System.UInt32? L1MergeSpeedaverage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L1MergeSpeedaverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("L1MergeSpeedaverage", value);
            }
        }

        public System.UInt32? L1MergeSpeedlast
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L1MergeSpeedlast", out result);
                return result;
            }

            set
            {
                this.SetProperty("L1MergeSpeedlast", value);
            }
        }

        public System.UInt32? L2MergeCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L2MergeCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("L2MergeCount", value);
            }
        }

        public System.UInt32? L2MergesNow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L2MergesNow", out result);
                return result;
            }

            set
            {
                this.SetProperty("L2MergesNow", value);
            }
        }

        public System.UInt32? L2MergeSpeedaverage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L2MergeSpeedaverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("L2MergeSpeedaverage", value);
            }
        }

        public System.UInt32? L2MergeSpeedlast
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L2MergeSpeedlast", out result);
                return result;
            }

            set
            {
                this.SetProperty("L2MergeSpeedlast", value);
            }
        }

        public System.UInt32? L3MergeCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L3MergeCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("L3MergeCount", value);
            }
        }

        public System.UInt32? L3MergesNow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L3MergesNow", out result);
                return result;
            }

            set
            {
                this.SetProperty("L3MergesNow", value);
            }
        }

        public System.UInt32? L3MergeSpeedaverage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L3MergeSpeedaverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("L3MergeSpeedaverage", value);
            }
        }

        public System.UInt32? L3MergeSpeedlast
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L3MergeSpeedlast", out result);
                return result;
            }

            set
            {
                this.SetProperty("L3MergeSpeedlast", value);
            }
        }

        public System.UInt32? L4MergeCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L4MergeCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("L4MergeCount", value);
            }
        }

        public System.UInt32? L4MergesNow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L4MergesNow", out result);
                return result;
            }

            set
            {
                this.SetProperty("L4MergesNow", value);
            }
        }

        public System.UInt32? L4MergeSpeedaverage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L4MergeSpeedaverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("L4MergeSpeedaverage", value);
            }
        }

        public System.UInt32? L4MergeSpeedlast
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L4MergeSpeedlast", out result);
                return result;
            }

            set
            {
                this.SetProperty("L4MergeSpeedlast", value);
            }
        }

        public System.UInt32? L5MergeCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L5MergeCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("L5MergeCount", value);
            }
        }

        public System.UInt32? L5MergesNow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L5MergesNow", out result);
                return result;
            }

            set
            {
                this.SetProperty("L5MergesNow", value);
            }
        }

        public System.UInt32? L5MergeSpeedaverage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L5MergeSpeedaverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("L5MergeSpeedaverage", value);
            }
        }

        public System.UInt32? L5MergeSpeedlast
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L5MergeSpeedlast", out result);
                return result;
            }

            set
            {
                this.SetProperty("L5MergeSpeedlast", value);
            }
        }

        public System.UInt32? L6MergeCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L6MergeCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("L6MergeCount", value);
            }
        }

        public System.UInt32? L6MergesNow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L6MergesNow", out result);
                return result;
            }

            set
            {
                this.SetProperty("L6MergesNow", value);
            }
        }

        public System.UInt32? L6MergeSpeedaverage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L6MergeSpeedaverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("L6MergeSpeedaverage", value);
            }
        }

        public System.UInt32? L6MergeSpeedlast
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L6MergeSpeedlast", out result);
                return result;
            }

            set
            {
                this.SetProperty("L6MergeSpeedlast", value);
            }
        }

        public System.UInt32? L7MergeCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L7MergeCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("L7MergeCount", value);
            }
        }

        public System.UInt32? L7MergesNow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L7MergesNow", out result);
                return result;
            }

            set
            {
                this.SetProperty("L7MergesNow", value);
            }
        }

        public System.UInt32? L7MergeSpeedaverage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L7MergeSpeedaverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("L7MergeSpeedaverage", value);
            }
        }

        public System.UInt32? L7MergeSpeedlast
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L7MergeSpeedlast", out result);
                return result;
            }

            set
            {
                this.SetProperty("L7MergeSpeedlast", value);
            }
        }

        public System.UInt32? L8MergeCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L8MergeCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("L8MergeCount", value);
            }
        }

        public System.UInt32? L8MergesNow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L8MergesNow", out result);
                return result;
            }

            set
            {
                this.SetProperty("L8MergesNow", value);
            }
        }

        public System.UInt32? L8MergeSpeedaverage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L8MergeSpeedaverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("L8MergeSpeedaverage", value);
            }
        }

        public System.UInt32? L8MergeSpeedlast
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L8MergeSpeedlast", out result);
                return result;
            }

            set
            {
                this.SetProperty("L8MergeSpeedlast", value);
            }
        }

        public System.UInt32? MasterIndexLevel
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MasterIndexLevel", out result);
                return result;
            }

            set
            {
                this.SetProperty("MasterIndexLevel", value);
            }
        }

        public System.UInt32? MasterMergeProgress
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MasterMergeProgress", out result);
                return result;
            }

            set
            {
                this.SetProperty("MasterMergeProgress", value);
            }
        }

        public System.UInt32? MasterMergesNow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MasterMergesNow", out result);
                return result;
            }

            set
            {
                this.SetProperty("MasterMergesNow", value);
            }
        }

        public System.UInt32? MasterMergestoDate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MasterMergestoDate", out result);
                return result;
            }

            set
            {
                this.SetProperty("MasterMergestoDate", value);
            }
        }

        public System.UInt32? PersistentIndexes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PersistentIndexes", out result);
                return result;
            }

            set
            {
                this.SetProperty("PersistentIndexes", value);
            }
        }

        public System.UInt32? PersistentIndexesL1
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PersistentIndexesL1", out result);
                return result;
            }

            set
            {
                this.SetProperty("PersistentIndexesL1", value);
            }
        }

        public System.UInt32? PersistentIndexesL2
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PersistentIndexesL2", out result);
                return result;
            }

            set
            {
                this.SetProperty("PersistentIndexesL2", value);
            }
        }

        public System.UInt32? PersistentIndexesL3
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PersistentIndexesL3", out result);
                return result;
            }

            set
            {
                this.SetProperty("PersistentIndexesL3", value);
            }
        }

        public System.UInt32? PersistentIndexesL4
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PersistentIndexesL4", out result);
                return result;
            }

            set
            {
                this.SetProperty("PersistentIndexesL4", value);
            }
        }

        public System.UInt32? PersistentIndexesL5
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PersistentIndexesL5", out result);
                return result;
            }

            set
            {
                this.SetProperty("PersistentIndexesL5", value);
            }
        }

        public System.UInt32? PersistentIndexesL6
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PersistentIndexesL6", out result);
                return result;
            }

            set
            {
                this.SetProperty("PersistentIndexesL6", value);
            }
        }

        public System.UInt32? PersistentIndexesL7
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PersistentIndexesL7", out result);
                return result;
            }

            set
            {
                this.SetProperty("PersistentIndexesL7", value);
            }
        }

        public System.UInt32? PersistentIndexesL8
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PersistentIndexesL8", out result);
                return result;
            }

            set
            {
                this.SetProperty("PersistentIndexesL8", value);
            }
        }

        public System.UInt32? Queries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Queries", out result);
                return result;
            }

            set
            {
                this.SetProperty("Queries", value);
            }
        }

        public System.UInt32? QueriesFailed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QueriesFailed", out result);
                return result;
            }

            set
            {
                this.SetProperty("QueriesFailed", value);
            }
        }

        public System.UInt32? QueriesSucceeded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QueriesSucceeded", out result);
                return result;
            }

            set
            {
                this.SetProperty("QueriesSucceeded", value);
            }
        }

        public System.UInt32? ShadowMergeLevels
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ShadowMergeLevels", out result);
                return result;
            }

            set
            {
                this.SetProperty("ShadowMergeLevels", value);
            }
        }

        public System.UInt32? ShadowMergeLevelsThreshold
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ShadowMergeLevelsThreshold", out result);
                return result;
            }

            set
            {
                this.SetProperty("ShadowMergeLevelsThreshold", value);
            }
        }

        public System.UInt32? UniqueKeys
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UniqueKeys", out result);
                return result;
            }

            set
            {
                this.SetProperty("UniqueKeys", value);
            }
        }

        public System.UInt32? WorkItemsCreated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkItemsCreated", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkItemsCreated", value);
            }
        }

        public System.UInt32? WorkItemsDeleted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkItemsDeleted", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkItemsDeleted", value);
            }
        }
    }
}