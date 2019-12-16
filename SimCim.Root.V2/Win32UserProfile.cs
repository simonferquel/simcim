using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32UserProfile : GenericInfrastructureObject
    {
        public Win32UserProfile()
        {
        }

        public Win32UserProfile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32FolderRedirectionHealth AppDataRoaming
        {
            get
            {
                Win32FolderRedirectionHealth result;
                this.GetInfrastructureObjectProperty("AppDataRoaming", out result);
                return result;
            }
        }

        public Win32FolderRedirectionHealth Contacts
        {
            get
            {
                Win32FolderRedirectionHealth result;
                this.GetInfrastructureObjectProperty("Contacts", out result);
                return result;
            }
        }

        public Win32FolderRedirectionHealth Desktop
        {
            get
            {
                Win32FolderRedirectionHealth result;
                this.GetInfrastructureObjectProperty("Desktop", out result);
                return result;
            }
        }

        public Win32FolderRedirectionHealth Documents
        {
            get
            {
                Win32FolderRedirectionHealth result;
                this.GetInfrastructureObjectProperty("Documents", out result);
                return result;
            }
        }

        public Win32FolderRedirectionHealth Downloads
        {
            get
            {
                Win32FolderRedirectionHealth result;
                this.GetInfrastructureObjectProperty("Downloads", out result);
                return result;
            }
        }

        public Win32FolderRedirectionHealth Favorites
        {
            get
            {
                Win32FolderRedirectionHealth result;
                this.GetInfrastructureObjectProperty("Favorites", out result);
                return result;
            }
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

        public System.DateTime? LastAttemptedProfileDownloadTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastAttemptedProfileDownloadTime", out result);
                return result;
            }
        }

        public System.DateTime? LastAttemptedProfileUploadTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastAttemptedProfileUploadTime", out result);
                return result;
            }
        }

        public System.DateTime? LastBackgroundRegistryUploadTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastBackgroundRegistryUploadTime", out result);
                return result;
            }
        }

        public System.DateTime? LastDownloadTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastDownloadTime", out result);
                return result;
            }
        }

        public System.DateTime? LastUploadTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastUploadTime", out result);
                return result;
            }
        }

        public System.DateTime? LastUseTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastUseTime", out result);
                return result;
            }
        }

        public Win32FolderRedirectionHealth Links
        {
            get
            {
                Win32FolderRedirectionHealth result;
                this.GetInfrastructureObjectProperty("Links", out result);
                return result;
            }
        }

        public System.Boolean? Loaded
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Loaded", out result);
                return result;
            }
        }

        public System.String LocalPath
        {
            get
            {
                System.String result;
                this.GetProperty("LocalPath", out result);
                return result;
            }
        }

        public Win32FolderRedirectionHealth Music
        {
            get
            {
                Win32FolderRedirectionHealth result;
                this.GetInfrastructureObjectProperty("Music", out result);
                return result;
            }
        }

        public Win32FolderRedirectionHealth Pictures
        {
            get
            {
                Win32FolderRedirectionHealth result;
                this.GetInfrastructureObjectProperty("Pictures", out result);
                return result;
            }
        }

        public System.UInt32? RefCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RefCount", out result);
                return result;
            }
        }

        public System.Boolean? RoamingConfigured
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RoamingConfigured", out result);
                return result;
            }
        }

        public System.String RoamingPath
        {
            get
            {
                System.String result;
                this.GetProperty("RoamingPath", out result);
                return result;
            }
        }

        public System.Boolean? RoamingPreference
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RoamingPreference", out result);
                return result;
            }

            set
            {
                this.SetProperty("RoamingPreference", value);
            }
        }

        public Win32FolderRedirectionHealth SavedGames
        {
            get
            {
                Win32FolderRedirectionHealth result;
                this.GetInfrastructureObjectProperty("SavedGames", out result);
                return result;
            }
        }

        public Win32FolderRedirectionHealth Searches
        {
            get
            {
                Win32FolderRedirectionHealth result;
                this.GetInfrastructureObjectProperty("Searches", out result);
                return result;
            }
        }

        public System.String SID
        {
            get
            {
                System.String result;
                this.GetProperty("SID", out result);
                return result;
            }
        }

        public System.Boolean? Special
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Special", out result);
                return result;
            }
        }

        public Win32FolderRedirectionHealth StartMenu
        {
            get
            {
                Win32FolderRedirectionHealth result;
                this.GetInfrastructureObjectProperty("StartMenu", out result);
                return result;
            }
        }

        public System.UInt32? Status
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Status", out result);
                return result;
            }
        }

        public Win32FolderRedirectionHealth Videos
        {
            get
            {
                Win32FolderRedirectionHealth result;
                this.GetInfrastructureObjectProperty("Videos", out result);
                return result;
            }
        }

        public System.UInt32 ChangeOwner(System.UInt32? inFlags, System.String inNewOwnerSID)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFlags.HasValue)
                parameters.Add(CimMethodParameter.Create("Flags", inFlags.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Flags", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("NewOwnerSID", inNewOwnerSID, CimType.String, inNewOwnerSID == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ChangeOwner", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}