using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersHTTPService : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersHTTPService()
        {
        }

        public Win32PerfFormattedDataCountersHTTPService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CurrentUrisCached
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentUrisCached", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentUrisCached", value);
            }
        }

        public System.UInt32? TotalFlushedUris
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalFlushedUris", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalFlushedUris", value);
            }
        }

        public System.UInt32? TotalUrisCached
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalUrisCached", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalUrisCached", value);
            }
        }

        public System.UInt32? UriCacheFlushes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UriCacheFlushes", out result);
                return result;
            }

            set
            {
                this.SetProperty("UriCacheFlushes", value);
            }
        }

        public System.UInt32? UriCacheHits
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UriCacheHits", out result);
                return result;
            }

            set
            {
                this.SetProperty("UriCacheHits", value);
            }
        }

        public System.UInt32? UriCacheMisses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UriCacheMisses", out result);
                return result;
            }

            set
            {
                this.SetProperty("UriCacheMisses", value);
            }
        }
    }
}