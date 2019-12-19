using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetBranchCacheDataCache : MSFTNetBranchCachePrimaryCache
    {
        public MSFTNetBranchCacheDataCache()
        {
        }

        public MSFTNetBranchCacheDataCache(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public IEnumerable<MSFTNetBranchCacheDataCacheExtension> DataCacheExtensions
        {
            get
            {
                IEnumerable<MSFTNetBranchCacheDataCacheExtension> result;
                this.GetInfrastructureObjectProperty("DataCacheExtensions", out result);
                return result;
            }
        }
    }
}