using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersStorageSpacesWriteCache : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersStorageSpacesWriteCache()
        {
        }

        public Win32PerfFormattedDataCountersStorageSpacesWriteCache(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CacheAdvances
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheAdvances", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheAdvances", value);
            }
        }

        public System.UInt32? CacheCheckpoints
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheCheckpoints", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheCheckpoints", value);
            }
        }

        public System.UInt64? CacheDataBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CacheDataBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheDataBytes", value);
            }
        }

        public System.UInt64? CacheDataPercent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CacheDataPercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheDataPercent", value);
            }
        }

        public System.UInt32? CacheDestagesCurrent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheDestagesCurrent", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheDestagesCurrent", value);
            }
        }

        public System.UInt64? CacheReclaimableBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CacheReclaimableBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheReclaimableBytes", value);
            }
        }

        public System.UInt64? CacheReclaimablePercent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CacheReclaimablePercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheReclaimablePercent", value);
            }
        }

        public System.UInt64? CacheSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CacheSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheSize", value);
            }
        }

        public System.UInt64? CacheUsedBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CacheUsedBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheUsedBytes", value);
            }
        }

        public System.UInt64? CacheUsedPercent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CacheUsedPercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheUsedPercent", value);
            }
        }

        public System.UInt64? EvictCacheBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EvictCacheBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("EvictCacheBytesPersec", value);
            }
        }

        public System.UInt64? EvictCacheDestagedBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EvictCacheDestagedBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("EvictCacheDestagedBytesPersec", value);
            }
        }

        public System.UInt64? EvictCacheDestagedPercent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EvictCacheDestagedPercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("EvictCacheDestagedPercent", value);
            }
        }

        public System.UInt64? EvictCacheOverwriteBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EvictCacheOverwriteBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("EvictCacheOverwriteBytesPersec", value);
            }
        }

        public System.UInt64? EvictCacheOverwritePercent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EvictCacheOverwritePercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("EvictCacheOverwritePercent", value);
            }
        }

        public System.UInt64? ReadBypassBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadBypassBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadBypassBytesPersec", value);
            }
        }

        public System.UInt64? ReadBypassPercent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadBypassPercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadBypassPercent", value);
            }
        }

        public System.UInt64? ReadCacheBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadCacheBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadCacheBytesPersec", value);
            }
        }

        public System.UInt64? ReadCachePercent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadCachePercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadCachePercent", value);
            }
        }

        public System.UInt64? WriteBypassBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteBypassBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteBypassBytesPersec", value);
            }
        }

        public System.UInt64? WriteBypassPercent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteBypassPercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteBypassPercent", value);
            }
        }

        public System.UInt64? WriteCacheBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteCacheBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteCacheBytesPersec", value);
            }
        }

        public System.UInt64? WriteCacheOverlapBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteCacheOverlapBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteCacheOverlapBytesPersec", value);
            }
        }

        public System.UInt64? WriteCacheOverlapPercent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteCacheOverlapPercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteCacheOverlapPercent", value);
            }
        }

        public System.UInt64? WriteCachePercent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteCachePercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteCachePercent", value);
            }
        }

        public System.UInt64? WriteCacheUnalignedBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteCacheUnalignedBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteCacheUnalignedBytesPersec", value);
            }
        }

        public System.UInt64? WriteCacheUnalignedPercent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteCacheUnalignedPercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteCacheUnalignedPercent", value);
            }
        }

        public System.UInt64? WriteCacheUntrimmedBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteCacheUntrimmedBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteCacheUntrimmedBytesPersec", value);
            }
        }

        public System.UInt64? WriteCacheUntrimmedPercent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteCacheUntrimmedPercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteCacheUntrimmedPercent", value);
            }
        }
    }
}