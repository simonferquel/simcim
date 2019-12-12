using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataNETMemoryCache40NETMemoryCache40 : Win32PerfRawData
    {
        public Win32PerfRawDataNETMemoryCache40NETMemoryCache40()
        {
        }

        public Win32PerfRawDataNETMemoryCache40NETMemoryCache40(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CacheEntries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheEntries", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheEntries", value);
            }
        }

        public System.UInt32? CacheHitRatio
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheHitRatio", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheHitRatio", value);
            }
        }

        public System.UInt32? CacheHitRatioBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheHitRatio_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheHitRatio_Base", value);
            }
        }

        public System.UInt32? CacheHits
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheHits", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheHits", value);
            }
        }

        public System.UInt32? CacheMisses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheMisses", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheMisses", value);
            }
        }

        public System.UInt32? CacheTrims
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheTrims", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheTrims", value);
            }
        }

        public System.UInt32? CacheTurnoverRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheTurnoverRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheTurnoverRate", value);
            }
        }
    }
}