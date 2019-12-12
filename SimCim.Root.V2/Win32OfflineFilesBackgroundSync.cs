using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OfflineFilesBackgroundSync : GenericInfrastructureObject
    {
        public Win32OfflineFilesBackgroundSync()
        {
        }

        public Win32OfflineFilesBackgroundSync(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? BackgroundSyncWorkOfflineSharesEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("BackgroundSyncWorkOfflineSharesEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("BackgroundSyncWorkOfflineSharesEnabled", value);
            }
        }

        public System.UInt16? BlockOutDurationMin
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("BlockOutDurationMin", out result);
                return result;
            }

            set
            {
                this.SetProperty("BlockOutDurationMin", value);
            }
        }

        public System.UInt16? BlockOutStartTimeHoursMinutes
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("BlockOutStartTimeHoursMinutes", out result);
                return result;
            }

            set
            {
                this.SetProperty("BlockOutStartTimeHoursMinutes", value);
            }
        }

        public System.UInt16? MaxTimeBetweenSyncs
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MaxTimeBetweenSyncs", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxTimeBetweenSyncs", value);
            }
        }

        public System.UInt16? SyncInterval
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SyncInterval", out result);
                return result;
            }

            set
            {
                this.SetProperty("SyncInterval", value);
            }
        }

        public System.UInt16? SyncVariance
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SyncVariance", out result);
                return result;
            }

            set
            {
                this.SetProperty("SyncVariance", value);
            }
        }
    }
}