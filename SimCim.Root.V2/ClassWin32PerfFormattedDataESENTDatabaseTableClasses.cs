﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataESENTDatabaseTableClasses : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataESENTDatabaseTableClasses()
        {
        }

        public Win32PerfFormattedDataESENTDatabaseTableClasses(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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
    }
}