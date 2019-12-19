using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public abstract class MSFTNetBranchCacheCache : CIMLogicalElement
    {
        protected MSFTNetBranchCacheCache()
        {
        }

        protected MSFTNetBranchCacheCache(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CacheFileDirectoryPath
        {
            get
            {
                System.String result;
                this.GetProperty("CacheFileDirectoryPath", out result);
                return result;
            }
        }

        public System.UInt64? CurrentSizeOnDiskAsNumberOfBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CurrentSizeOnDiskAsNumberOfBytes", out result);
                return result;
            }
        }

        public System.UInt64? MaxCacheSizeAsNumberOfBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxCacheSizeAsNumberOfBytes", out result);
                return result;
            }
        }

        public System.UInt32? MaxCacheSizeAsPercentageOfDiskVolume
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxCacheSizeAsPercentageOfDiskVolume", out result);
                return result;
            }
        }
    }
}