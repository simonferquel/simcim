using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataRdyboostReadyBoostCache : Win32PerfRawData
    {
        public Win32PerfRawDataRdyboostReadyBoostCache()
        {
        }

        public Win32PerfRawDataRdyboostReadyBoostCache(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? Bytescached
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Bytescached", out result);
                return result;
            }

            set
            {
                this.SetProperty("Bytescached", value);
            }
        }

        public System.UInt64? CachereadbytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CachereadbytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CachereadbytesPersec", value);
            }
        }

        public System.UInt32? CachereadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CachereadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CachereadsPersec", value);
            }
        }

        public System.UInt64? Cachespaceused
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Cachespaceused", out result);
                return result;
            }

            set
            {
                this.SetProperty("Cachespaceused", value);
            }
        }

        public System.UInt64? CompressionRatio
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CompressionRatio", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompressionRatio", value);
            }
        }

        public System.UInt64? CompressionRatioBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CompressionRatio_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompressionRatio_Base", value);
            }
        }

        public System.UInt64? SkippedreadbytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SkippedreadbytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SkippedreadbytesPersec", value);
            }
        }

        public System.UInt32? SkippedreadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SkippedreadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SkippedreadsPersec", value);
            }
        }

        public System.UInt64? Totalcachesizebytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Totalcachesizebytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("Totalcachesizebytes", value);
            }
        }

        public System.UInt64? TotalreadbytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalreadbytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalreadbytesPersec", value);
            }
        }

        public System.UInt32? TotalreadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalreadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalreadsPersec", value);
            }
        }
    }
}