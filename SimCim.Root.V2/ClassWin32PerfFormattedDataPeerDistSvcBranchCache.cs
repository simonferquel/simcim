using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataPeerDistSvcBranchCache : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataPeerDistSvcBranchCache()
        {
        }

        public Win32PerfFormattedDataPeerDistSvcBranchCache(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? BITSBytesfromcache
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BITSBytesfromcache", out result);
                return result;
            }

            set
            {
                this.SetProperty("BITSBytesfromcache", value);
            }
        }

        public System.UInt64? BITSBytesfromserver
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BITSBytesfromserver", out result);
                return result;
            }

            set
            {
                this.SetProperty("BITSBytesfromserver", value);
            }
        }

        public System.UInt32? DiscoveryAttempteddiscoveries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DiscoveryAttempteddiscoveries", out result);
                return result;
            }

            set
            {
                this.SetProperty("DiscoveryAttempteddiscoveries", value);
            }
        }

        public System.UInt32? DiscoverySuccessfuldiscoveries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DiscoverySuccessfuldiscoveries", out result);
                return result;
            }

            set
            {
                this.SetProperty("DiscoverySuccessfuldiscoveries", value);
            }
        }

        public System.UInt32? DiscoveryWeightedaveragediscoverytime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DiscoveryWeightedaveragediscoverytime", out result);
                return result;
            }

            set
            {
                this.SetProperty("DiscoveryWeightedaveragediscoverytime", value);
            }
        }

        public System.UInt32? HostedCacheClientfilesegmentoffersmade
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HostedCacheClientfilesegmentoffersmade", out result);
                return result;
            }

            set
            {
                this.SetProperty("HostedCacheClientfilesegmentoffersmade", value);
            }
        }

        public System.UInt32? HostedCacheSegmentoffersqueuesize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HostedCacheSegmentoffersqueuesize", out result);
                return result;
            }

            set
            {
                this.SetProperty("HostedCacheSegmentoffersqueuesize", value);
            }
        }

        public System.UInt32? LocalCacheAverageaccesstime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LocalCacheAverageaccesstime", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalCacheAverageaccesstime", value);
            }
        }

        public System.UInt32? LocalCacheCachecompletefilesegments
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LocalCacheCachecompletefilesegments", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalCacheCachecompletefilesegments", value);
            }
        }

        public System.UInt32? LocalCacheCachepartialfilesegments
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LocalCacheCachepartialfilesegments", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalCacheCachepartialfilesegments", value);
            }
        }

        public System.UInt64? OTHERBytesfromcache
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OTHERBytesfromcache", out result);
                return result;
            }

            set
            {
                this.SetProperty("OTHERBytesfromcache", value);
            }
        }

        public System.UInt64? OTHERBytesfromserver
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OTHERBytesfromserver", out result);
                return result;
            }

            set
            {
                this.SetProperty("OTHERBytesfromserver", value);
            }
        }

        public System.UInt32? PublicationCachePublishedcontents
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PublicationCachePublishedcontents", out result);
                return result;
            }

            set
            {
                this.SetProperty("PublicationCachePublishedcontents", value);
            }
        }

        public System.UInt64? RetrievalAveragebranchrate
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RetrievalAveragebranchrate", out result);
                return result;
            }

            set
            {
                this.SetProperty("RetrievalAveragebranchrate", value);
            }
        }

        public System.UInt64? RetrievalBytesfromcache
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RetrievalBytesfromcache", out result);
                return result;
            }

            set
            {
                this.SetProperty("RetrievalBytesfromcache", value);
            }
        }

        public System.UInt64? RetrievalBytesfromserver
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RetrievalBytesfromserver", out result);
                return result;
            }

            set
            {
                this.SetProperty("RetrievalBytesfromserver", value);
            }
        }

        public System.UInt64? RetrievalBytesserved
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RetrievalBytesserved", out result);
                return result;
            }

            set
            {
                this.SetProperty("RetrievalBytesserved", value);
            }
        }

        public System.UInt64? SMBBytesfromcache
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SMBBytesfromcache", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBytesfromcache", value);
            }
        }

        public System.UInt64? SMBBytesfromserver
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SMBBytesfromserver", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBytesfromserver", value);
            }
        }

        public System.UInt64? WINHTTPBytesfromcache
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WINHTTPBytesfromcache", out result);
                return result;
            }

            set
            {
                this.SetProperty("WINHTTPBytesfromcache", value);
            }
        }

        public System.UInt64? WINHTTPBytesfromserver
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WINHTTPBytesfromserver", out result);
                return result;
            }

            set
            {
                this.SetProperty("WINHTTPBytesfromserver", value);
            }
        }

        public System.UInt64? WININETBytesfromcache
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WININETBytesfromcache", out result);
                return result;
            }

            set
            {
                this.SetProperty("WININETBytesfromcache", value);
            }
        }

        public System.UInt64? WININETBytesfromserver
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WININETBytesfromserver", out result);
                return result;
            }

            set
            {
                this.SetProperty("WININETBytesfromserver", value);
            }
        }
    }
}