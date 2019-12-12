using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OfflineFilesHealth : GenericInfrastructureObject
    {
        public Win32OfflineFilesHealth()
        {
        }

        public Win32OfflineFilesHealth(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String LastSuccessfulSyncTime
        {
            get
            {
                System.String result;
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

        public System.String LastSyncTime
        {
            get
            {
                System.String result;
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

        public System.Boolean? OnlineMode
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OnlineMode", out result);
                return result;
            }
        }
    }
}