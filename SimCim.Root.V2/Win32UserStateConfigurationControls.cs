using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32UserStateConfigurationControls : GenericInfrastructureObject
    {
        public Win32UserStateConfigurationControls()
        {
        }

        public Win32UserStateConfigurationControls(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? FolderRedirection
        {
            get
            {
                System.Byte? result;
                this.GetProperty("FolderRedirection", out result);
                return result;
            }

            set
            {
                this.SetProperty("FolderRedirection", value);
            }
        }

        public System.Byte? OfflineFiles
        {
            get
            {
                System.Byte? result;
                this.GetProperty("OfflineFiles", out result);
                return result;
            }

            set
            {
                this.SetProperty("OfflineFiles", value);
            }
        }

        public System.Byte? RoamingUserProfile
        {
            get
            {
                System.Byte? result;
                this.GetProperty("RoamingUserProfile", out result);
                return result;
            }

            set
            {
                this.SetProperty("RoamingUserProfile", value);
            }
        }
    }
}