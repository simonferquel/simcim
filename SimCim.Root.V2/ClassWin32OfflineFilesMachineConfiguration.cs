using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OfflineFilesMachineConfiguration : GenericInfrastructureObject
    {
        public Win32OfflineFilesMachineConfiguration()
        {
        }

        public Win32OfflineFilesMachineConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? BackgroundSyncEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("BackgroundSyncEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("BackgroundSyncEnabled", value);
            }
        }

        public Win32OfflineFilesBackgroundSync BackgroundSyncParams
        {
            get
            {
                Win32OfflineFilesBackgroundSync result;
                this.GetInfrastructureObjectProperty("BackgroundSyncParams", out result);
                return result;
            }

            set
            {
                this.SetProperty("BackgroundSyncParams", value);
            }
        }

        public System.Boolean? DiskSpaceLimitEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DiskSpaceLimitEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("DiskSpaceLimitEnabled", value);
            }
        }

        public Win32OfflineFilesDiskSpaceLimit DiskSpaceLimitParams
        {
            get
            {
                Win32OfflineFilesDiskSpaceLimit result;
                this.GetInfrastructureObjectProperty("DiskSpaceLimitParams", out result);
                return result;
            }

            set
            {
                this.SetProperty("DiskSpaceLimitParams", value);
            }
        }

        public System.Boolean? EconomicalAdminPinningEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EconomicalAdminPinningEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("EconomicalAdminPinningEnabled", value);
            }
        }

        public System.Boolean? Enabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Enabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("Enabled", value);
            }
        }

        public System.String[] ExcludedFileTypes
        {
            get
            {
                System.String[] result;
                this.GetProperty("ExcludedFileTypes", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExcludedFileTypes", value);
            }
        }

        public System.Boolean? IsConfiguredByWMI
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsConfiguredByWMI", out result);
                return result;
            }
        }

        public System.Boolean? MakeAvailableOfflineButtonRemoved
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MakeAvailableOfflineButtonRemoved", out result);
                return result;
            }

            set
            {
                this.SetProperty("MakeAvailableOfflineButtonRemoved", value);
            }
        }

        public System.Boolean? OfflineFilesCacheEncrypted
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OfflineFilesCacheEncrypted", out result);
                return result;
            }

            set
            {
                this.SetProperty("OfflineFilesCacheEncrypted", value);
            }
        }

        public System.Boolean? SlowLinkEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SlowLinkEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("SlowLinkEnabled", value);
            }
        }

        public System.String[] SlowLinkParams
        {
            get
            {
                System.String[] result;
                this.GetProperty("SlowLinkParams", out result);
                return result;
            }

            set
            {
                this.SetProperty("SlowLinkParams", value);
            }
        }

        public System.Boolean? SyncOnCostedNetworkEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SyncOnCostedNetworkEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("SyncOnCostedNetworkEnabled", value);
            }
        }

        public System.UInt32? TransparentCachingLatencyThreshold
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransparentCachingLatencyThreshold", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransparentCachingLatencyThreshold", value);
            }
        }

        public System.Boolean? WorkOfflineButtonRemoved
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("WorkOfflineButtonRemoved", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkOfflineButtonRemoved", value);
            }
        }
    }
}