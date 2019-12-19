using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetBranchCacheContentServerSettingData : MSFTNetBranchCacheSettingData
    {
        public MSFTNetBranchCacheContentServerSettingData()
        {
        }

        public MSFTNetBranchCacheContentServerSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? ContentServerIsEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ContentServerIsEnabled", out result);
                return result;
            }
        }
    }
}