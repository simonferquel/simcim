using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetBranchCacheStatus : CIMLogicalElement
    {
        public MSFTNetBranchCacheStatus()
        {
        }

        public MSFTNetBranchCacheStatus(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? BranchCacheIsEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("BranchCacheIsEnabled", out result);
                return result;
            }
        }

        public System.UInt32? BranchCacheServiceStartType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BranchCacheServiceStartType", out result);
                return result;
            }
        }

        public System.UInt32? BranchCacheServiceStatus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BranchCacheServiceStatus", out result);
                return result;
            }
        }

        public MSFTNetBranchCacheClientSettingData ClientConfiguration
        {
            get
            {
                MSFTNetBranchCacheClientSettingData result;
                this.GetInfrastructureObjectProperty("ClientConfiguration", out result);
                return result;
            }
        }

        public MSFTNetBranchCacheContentServerSettingData ContentServerConfiguration
        {
            get
            {
                MSFTNetBranchCacheContentServerSettingData result;
                this.GetInfrastructureObjectProperty("ContentServerConfiguration", out result);
                return result;
            }
        }

        public MSFTNetBranchCacheDataCache DataCache
        {
            get
            {
                MSFTNetBranchCacheDataCache result;
                this.GetInfrastructureObjectProperty("DataCache", out result);
                return result;
            }
        }

        public MSFTNetBranchCacheHashCache HashCache
        {
            get
            {
                MSFTNetBranchCacheHashCache result;
                this.GetInfrastructureObjectProperty("HashCache", out result);
                return result;
            }
        }

        public MSFTNetBranchCacheHostedCacheServerSettingData HostedCacheServerConfiguration
        {
            get
            {
                MSFTNetBranchCacheHostedCacheServerSettingData result;
                this.GetInfrastructureObjectProperty("HostedCacheServerConfiguration", out result);
                return result;
            }
        }

        public MSFTNetBranchCacheNetworkSettingData NetworkConfiguration
        {
            get
            {
                MSFTNetBranchCacheNetworkSettingData result;
                this.GetInfrastructureObjectProperty("NetworkConfiguration", out result);
                return result;
            }
        }
    }
}