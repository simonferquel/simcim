using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataESENTDatabaseDatabases : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataESENTDatabaseDatabases()
        {
        }

        public Win32PerfFormattedDataESENTDatabaseDatabases(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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
    }
}