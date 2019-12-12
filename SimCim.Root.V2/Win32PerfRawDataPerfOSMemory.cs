using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataPerfOSMemory : Win32PerfRawData
    {
        public Win32PerfRawDataPerfOSMemory()
        {
        }

        public Win32PerfRawDataPerfOSMemory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AvailableBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvailableBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvailableBytes", value);
            }
        }

        public System.UInt64? AvailableKBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvailableKBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvailableKBytes", value);
            }
        }

        public System.UInt64? AvailableMBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvailableMBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvailableMBytes", value);
            }
        }

        public System.UInt64? CacheBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CacheBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheBytes", value);
            }
        }

        public System.UInt64? CacheBytesPeak
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CacheBytesPeak", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheBytesPeak", value);
            }
        }

        public System.UInt32? CacheFaultsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheFaultsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheFaultsPersec", value);
            }
        }

        public System.UInt64? CommitLimit
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CommitLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("CommitLimit", value);
            }
        }

        public System.UInt64? CommittedBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CommittedBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("CommittedBytes", value);
            }
        }

        public System.UInt32? DemandZeroFaultsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DemandZeroFaultsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DemandZeroFaultsPersec", value);
            }
        }

        public System.UInt64? FreeAndZeroPageListBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FreeAndZeroPageListBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("FreeAndZeroPageListBytes", value);
            }
        }

        public System.UInt32? FreeSystemPageTableEntries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FreeSystemPageTableEntries", out result);
                return result;
            }

            set
            {
                this.SetProperty("FreeSystemPageTableEntries", value);
            }
        }

        public System.UInt32? LongTermAverageStandbyCacheLifetimes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LongTermAverageStandbyCacheLifetimes", out result);
                return result;
            }

            set
            {
                this.SetProperty("LongTermAverageStandbyCacheLifetimes", value);
            }
        }

        public System.UInt64? ModifiedPageListBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ModifiedPageListBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("ModifiedPageListBytes", value);
            }
        }

        public System.UInt32? PageFaultsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PageFaultsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageFaultsPersec", value);
            }
        }

        public System.UInt32? PageReadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PageReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageReadsPersec", value);
            }
        }

        public System.UInt32? PagesInputPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PagesInputPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PagesInputPersec", value);
            }
        }

        public System.UInt32? PagesOutputPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PagesOutputPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PagesOutputPersec", value);
            }
        }

        public System.UInt32? PagesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PagesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PagesPersec", value);
            }
        }

        public System.UInt32? PageWritesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PageWritesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageWritesPersec", value);
            }
        }

        public System.UInt32? PercentCommittedBytesInUse
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentCommittedBytesInUse", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentCommittedBytesInUse", value);
            }
        }

        public System.UInt32? PercentCommittedBytesInUseBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentCommittedBytesInUse_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentCommittedBytesInUse_Base", value);
            }
        }

        public System.UInt32? PoolNonpagedAllocs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PoolNonpagedAllocs", out result);
                return result;
            }

            set
            {
                this.SetProperty("PoolNonpagedAllocs", value);
            }
        }

        public System.UInt64? PoolNonpagedBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PoolNonpagedBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("PoolNonpagedBytes", value);
            }
        }

        public System.UInt32? PoolPagedAllocs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PoolPagedAllocs", out result);
                return result;
            }

            set
            {
                this.SetProperty("PoolPagedAllocs", value);
            }
        }

        public System.UInt64? PoolPagedBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PoolPagedBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("PoolPagedBytes", value);
            }
        }

        public System.UInt64? PoolPagedResidentBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PoolPagedResidentBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("PoolPagedResidentBytes", value);
            }
        }

        public System.UInt64? StandbyCacheCoreBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("StandbyCacheCoreBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("StandbyCacheCoreBytes", value);
            }
        }

        public System.UInt64? StandbyCacheNormalPriorityBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("StandbyCacheNormalPriorityBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("StandbyCacheNormalPriorityBytes", value);
            }
        }

        public System.UInt64? StandbyCacheReserveBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("StandbyCacheReserveBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("StandbyCacheReserveBytes", value);
            }
        }

        public System.UInt64? SystemCacheResidentBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SystemCacheResidentBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemCacheResidentBytes", value);
            }
        }

        public System.UInt64? SystemCodeResidentBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SystemCodeResidentBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemCodeResidentBytes", value);
            }
        }

        public System.UInt64? SystemCodeTotalBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SystemCodeTotalBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemCodeTotalBytes", value);
            }
        }

        public System.UInt64? SystemDriverResidentBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SystemDriverResidentBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemDriverResidentBytes", value);
            }
        }

        public System.UInt64? SystemDriverTotalBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SystemDriverTotalBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemDriverTotalBytes", value);
            }
        }

        public System.UInt32? TransitionFaultsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransitionFaultsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransitionFaultsPersec", value);
            }
        }

        public System.UInt32? TransitionPagesRePurposedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransitionPagesRePurposedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransitionPagesRePurposedPersec", value);
            }
        }

        public System.UInt32? WriteCopiesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WriteCopiesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteCopiesPersec", value);
            }
        }
    }
}