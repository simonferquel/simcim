using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public abstract class MSFTNetBranchCachePrimaryCache : MSFTNetBranchCacheCache
    {
        protected MSFTNetBranchCachePrimaryCache()
        {
        }

        protected MSFTNetBranchCachePrimaryCache(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? CurrentActiveCacheSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CurrentActiveCacheSize", out result);
                return result;
            }
        }
    }
}