﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetBranchCacheHashCache : MSFTNetBranchCachePrimaryCache
    {
        public MSFTNetBranchCacheHashCache()
        {
        }

        public MSFTNetBranchCacheHashCache(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}