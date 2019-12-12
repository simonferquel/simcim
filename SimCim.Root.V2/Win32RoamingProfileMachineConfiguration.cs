using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32RoamingProfileMachineConfiguration : GenericInfrastructureObject
    {
        public Win32RoamingProfileMachineConfiguration()
        {
        }

        public Win32RoamingProfileMachineConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AddAdminGroupToRUPEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AddAdminGroupToRUPEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("AddAdminGroupToRUPEnabled", value);
            }
        }

        public System.Boolean? AllowCrossForestUserPolicy
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AllowCrossForestUserPolicy", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowCrossForestUserPolicy", value);
            }
        }

        public Win32RoamingProfileBackgroundUploadParams BackgroundUploadParams
        {
            get
            {
                Win32RoamingProfileBackgroundUploadParams result;
                this.GetInfrastructureObjectProperty("BackgroundUploadParams", out result);
                return result;
            }

            set
            {
                this.SetProperty("BackgroundUploadParams", value);
            }
        }

        public System.UInt16? DeleteProfilesOlderDays
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DeleteProfilesOlderDays", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeleteProfilesOlderDays", value);
            }
        }

        public System.Boolean? DeleteRoamingCacheEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DeleteRoamingCacheEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeleteRoamingCacheEnabled", value);
            }
        }

        public System.Boolean? DetectSlowLinkDisabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DetectSlowLinkDisabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("DetectSlowLinkDisabled", value);
            }
        }

        public System.Boolean? ForceUnloadDisabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ForceUnloadDisabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("ForceUnloadDisabled", value);
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

        public System.String MachineProfilePath
        {
            get
            {
                System.String result;
                this.GetProperty("MachineProfilePath", out result);
                return result;
            }

            set
            {
                this.SetProperty("MachineProfilePath", value);
            }
        }

        public System.Boolean? OnlyAllowLocalProfiles
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OnlyAllowLocalProfiles", out result);
                return result;
            }

            set
            {
                this.SetProperty("OnlyAllowLocalProfiles", value);
            }
        }

        public System.Boolean? OwnerCheckDisabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OwnerCheckDisabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("OwnerCheckDisabled", value);
            }
        }

        public System.Boolean? PrimaryComputerEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PrimaryComputerEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrimaryComputerEnabled", value);
            }
        }

        public System.Boolean? ProfileUploadDisabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ProfileUploadDisabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProfileUploadDisabled", value);
            }
        }

        public Win32RoamingProfileSlowLinkParams SlowLinkTimeOutParams
        {
            get
            {
                Win32RoamingProfileSlowLinkParams result;
                this.GetInfrastructureObjectProperty("SlowLinkTimeOutParams", out result);
                return result;
            }

            set
            {
                this.SetProperty("SlowLinkTimeOutParams", value);
            }
        }

        public System.Boolean? SlowLinkUIEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SlowLinkUIEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("SlowLinkUIEnabled", value);
            }
        }

        public System.Boolean? TempProfileLogonBlocked
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TempProfileLogonBlocked", out result);
                return result;
            }

            set
            {
                this.SetProperty("TempProfileLogonBlocked", value);
            }
        }

        public System.UInt16? WaitForNetworkInSec
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("WaitForNetworkInSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WaitForNetworkInSec", value);
            }
        }

        public System.Boolean? WaitForRemoteProfile
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("WaitForRemoteProfile", out result);
                return result;
            }

            set
            {
                this.SetProperty("WaitForRemoteProfile", value);
            }
        }
    }
}