using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetBranchCacheHostedCacheServerSettingData : MSFTNetBranchCacheSettingData
    {
        public MSFTNetBranchCacheHostedCacheServerSettingData()
        {
        }

        public MSFTNetBranchCacheHostedCacheServerSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ClientAuthenticationMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ClientAuthenticationMode", out result);
                return result;
            }
        }

        public System.Boolean? HostedCacheScpRegistrationEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HostedCacheScpRegistrationEnabled", out result);
                return result;
            }
        }

        public System.Boolean? HostedCacheServerIsEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HostedCacheServerIsEnabled", out result);
                return result;
            }
        }
    }
}