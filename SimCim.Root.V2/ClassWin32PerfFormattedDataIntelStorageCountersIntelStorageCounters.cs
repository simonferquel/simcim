using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataIntelStorageCountersIntelStorageCounters : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataIntelStorageCountersIntelStorageCounters()
        {
        }

        public Win32PerfFormattedDataIntelStorageCountersIntelStorageCounters(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? PsiAverageStorageDataUpdateTimeMs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PsiAverageStorageDataUpdateTimeMs", out result);
                return result;
            }

            set
            {
                this.SetProperty("PsiAverageStorageDataUpdateTimeMs", value);
            }
        }

        public System.UInt32? PsiInitialStorageDataLoadTimeMs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PsiInitialStorageDataLoadTimeMs", out result);
                return result;
            }

            set
            {
                this.SetProperty("PsiInitialStorageDataLoadTimeMs", value);
            }
        }

        public System.UInt32? PsiSnapshotCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PsiSnapshotCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("PsiSnapshotCount", value);
            }
        }

        public System.UInt32? PsiStorageDriverBusyCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PsiStorageDriverBusyCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("PsiStorageDriverBusyCount", value);
            }
        }

        public System.UInt32? PsiStorageDriverErrorCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PsiStorageDriverErrorCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("PsiStorageDriverErrorCount", value);
            }
        }

        public System.UInt32? PsiUpdateCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PsiUpdateCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("PsiUpdateCount", value);
            }
        }
    }
}