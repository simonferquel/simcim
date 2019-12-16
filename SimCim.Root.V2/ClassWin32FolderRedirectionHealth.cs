using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32FolderRedirectionHealth : GenericInfrastructureObject
    {
        public Win32FolderRedirectionHealth()
        {
        }

        public Win32FolderRedirectionHealth(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? HealthStatus
        {
            get
            {
                System.Byte? result;
                this.GetProperty("HealthStatus", out result);
                return result;
            }
        }

        public System.DateTime? LastSuccessfulSyncTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastSuccessfulSyncTime", out result);
                return result;
            }
        }

        public System.Byte? LastSyncStatus
        {
            get
            {
                System.Byte? result;
                this.GetProperty("LastSyncStatus", out result);
                return result;
            }
        }

        public System.DateTime? LastSyncTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastSyncTime", out result);
                return result;
            }
        }

        public System.Boolean? OfflineAccessEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OfflineAccessEnabled", out result);
                return result;
            }
        }

        public System.String OfflineFileNameFolderGUID
        {
            get
            {
                System.String result;
                this.GetProperty("OfflineFileNameFolderGUID", out result);
                return result;
            }
        }

        public System.Boolean? Redirected
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Redirected", out result);
                return result;
            }
        }
    }
}