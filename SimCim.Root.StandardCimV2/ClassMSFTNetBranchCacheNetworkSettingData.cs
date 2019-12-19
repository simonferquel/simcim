using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetBranchCacheNetworkSettingData : MSFTNetBranchCacheSettingData
    {
        public MSFTNetBranchCacheNetworkSettingData()
        {
        }

        public MSFTNetBranchCacheNetworkSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? ContentDownloadConnectPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ContentDownloadConnectPort", out result);
                return result;
            }
        }

        public System.UInt16? ContentDownloadListenPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ContentDownloadListenPort", out result);
                return result;
            }
        }

        public System.Boolean? ContentRetrievalFirewallRulesEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ContentRetrievalFirewallRulesEnabled", out result);
                return result;
            }
        }

        public System.Boolean? ContentRetrievalUrlReservationEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ContentRetrievalUrlReservationEnabled", out result);
                return result;
            }
        }

        public System.Boolean? HostedCacheClientFirewallRulesEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HostedCacheClientFirewallRulesEnabled", out result);
                return result;
            }
        }

        public System.UInt16? HostedCacheHttpConnectPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HostedCacheHttpConnectPort", out result);
                return result;
            }
        }

        public System.UInt16? HostedCacheHttpListenPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HostedCacheHttpListenPort", out result);
                return result;
            }
        }

        public System.UInt16? HostedCacheHttpsConnectPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HostedCacheHttpsConnectPort", out result);
                return result;
            }
        }

        public System.UInt16? HostedCacheHttpsListenPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HostedCacheHttpsListenPort", out result);
                return result;
            }
        }

        public System.Boolean? HostedCacheHttpsUrlReservationEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HostedCacheHttpsUrlReservationEnabled", out result);
                return result;
            }
        }

        public System.Boolean? HostedCacheHttpUrlReservationEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HostedCacheHttpUrlReservationEnabled", out result);
                return result;
            }
        }

        public System.Boolean? HostedCacheServerFirewallRulesEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HostedCacheServerFirewallRulesEnabled", out result);
                return result;
            }
        }

        public System.Boolean? PeerDiscoveryFirewallRulesEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PeerDiscoveryFirewallRulesEnabled", out result);
                return result;
            }
        }
    }
}