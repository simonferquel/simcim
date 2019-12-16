using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataPerfOSCache : Win32PerfRawData
    {
        public Win32PerfRawDataPerfOSCache()
        {
        }

        public Win32PerfRawDataPerfOSCache(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AsyncCopyReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AsyncCopyReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AsyncCopyReadsPersec", value);
            }
        }

        public System.UInt32? AsyncDataMapsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AsyncDataMapsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AsyncDataMapsPersec", value);
            }
        }

        public System.UInt32? AsyncFastReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AsyncFastReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AsyncFastReadsPersec", value);
            }
        }

        public System.UInt32? AsyncMDLReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AsyncMDLReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AsyncMDLReadsPersec", value);
            }
        }

        public System.UInt32? AsyncPinReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AsyncPinReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AsyncPinReadsPersec", value);
            }
        }

        public System.UInt32? CopyReadHitsPercent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CopyReadHitsPercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("CopyReadHitsPercent", value);
            }
        }

        public System.UInt32? CopyReadHitsPercentBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CopyReadHitsPercent_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("CopyReadHitsPercent_Base", value);
            }
        }

        public System.UInt32? CopyReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CopyReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CopyReadsPersec", value);
            }
        }

        public System.UInt32? DataFlushesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DataFlushesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DataFlushesPersec", value);
            }
        }

        public System.UInt32? DataFlushPagesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DataFlushPagesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DataFlushPagesPersec", value);
            }
        }

        public System.UInt32? DataMapHitsPercent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DataMapHitsPercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("DataMapHitsPercent", value);
            }
        }

        public System.UInt32? DataMapHitsPercentBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DataMapHitsPercent_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("DataMapHitsPercent_Base", value);
            }
        }

        public System.UInt32? DataMapPinsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DataMapPinsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DataMapPinsPersec", value);
            }
        }

        public System.UInt32? DataMapPinsPersecBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DataMapPinsPersec_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("DataMapPinsPersec_Base", value);
            }
        }

        public System.UInt32? DataMapsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DataMapsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DataMapsPersec", value);
            }
        }

        public System.UInt64? DirtyPages
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DirtyPages", out result);
                return result;
            }

            set
            {
                this.SetProperty("DirtyPages", value);
            }
        }

        public System.UInt64? DirtyPageThreshold
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DirtyPageThreshold", out result);
                return result;
            }

            set
            {
                this.SetProperty("DirtyPageThreshold", value);
            }
        }

        public System.UInt32? FastReadNotPossiblesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FastReadNotPossiblesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FastReadNotPossiblesPersec", value);
            }
        }

        public System.UInt32? FastReadResourceMissesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FastReadResourceMissesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FastReadResourceMissesPersec", value);
            }
        }

        public System.UInt32? FastReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FastReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FastReadsPersec", value);
            }
        }

        public System.UInt32? LazyWriteFlushesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LazyWriteFlushesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LazyWriteFlushesPersec", value);
            }
        }

        public System.UInt32? LazyWritePagesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LazyWritePagesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LazyWritePagesPersec", value);
            }
        }

        public System.UInt32? MDLReadHitsPercent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MDLReadHitsPercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("MDLReadHitsPercent", value);
            }
        }

        public System.UInt32? MDLReadHitsPercentBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MDLReadHitsPercent_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("MDLReadHitsPercent_Base", value);
            }
        }

        public System.UInt32? MDLReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MDLReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MDLReadsPersec", value);
            }
        }

        public System.UInt32? PinReadHitsPercent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PinReadHitsPercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("PinReadHitsPercent", value);
            }
        }

        public System.UInt32? PinReadHitsPercentBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PinReadHitsPercent_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PinReadHitsPercent_Base", value);
            }
        }

        public System.UInt32? PinReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PinReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PinReadsPersec", value);
            }
        }

        public System.UInt32? ReadAheadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReadAheadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadAheadsPersec", value);
            }
        }

        public System.UInt32? SyncCopyReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SyncCopyReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SyncCopyReadsPersec", value);
            }
        }

        public System.UInt32? SyncDataMapsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SyncDataMapsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SyncDataMapsPersec", value);
            }
        }

        public System.UInt32? SyncFastReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SyncFastReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SyncFastReadsPersec", value);
            }
        }

        public System.UInt32? SyncMDLReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SyncMDLReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SyncMDLReadsPersec", value);
            }
        }

        public System.UInt32? SyncPinReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SyncPinReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SyncPinReadsPersec", value);
            }
        }
    }
}