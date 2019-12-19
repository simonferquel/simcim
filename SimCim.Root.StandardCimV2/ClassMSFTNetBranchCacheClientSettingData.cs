using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetBranchCacheClientSettingData : MSFTNetBranchCacheSettingData
    {
        public MSFTNetBranchCacheClientSettingData()
        {
        }

        public MSFTNetBranchCacheClientSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CurrentClientMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentClientMode", out result);
                return result;
            }
        }

        public System.Boolean? DistributedCachingIsEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DistributedCachingIsEnabled", out result);
                return result;
            }
        }

        public System.Boolean? HostedCacheDiscoveryEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HostedCacheDiscoveryEnabled", out result);
                return result;
            }
        }

        public System.String[] HostedCacheServerList
        {
            get
            {
                System.String[] result;
                this.GetProperty("HostedCacheServerList", out result);
                return result;
            }
        }

        public System.UInt32? HostedCacheVersion
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HostedCacheVersion", out result);
                return result;
            }
        }

        public System.UInt32? MinimumSmbLatencyInMilliseconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MinimumSmbLatencyInMilliseconds", out result);
                return result;
            }
        }

        public System.UInt32? PreferredContentInformationVersion
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PreferredContentInformationVersion", out result);
                return result;
            }
        }

        public System.Boolean? ServeDistributedCachingPeersOnBatteryPower
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ServeDistributedCachingPeersOnBatteryPower", out result);
                return result;
            }
        }
    }
}