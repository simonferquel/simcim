using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32RoamingProfileUserConfiguration : GenericInfrastructureObject
    {
        public Win32RoamingProfileUserConfiguration()
        {
        }

        public Win32RoamingProfileUserConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] DirectoriesToSyncAtLogonLogoff
        {
            get
            {
                System.String[] result;
                this.GetProperty("DirectoriesToSyncAtLogonLogoff", out result);
                return result;
            }

            set
            {
                this.SetProperty("DirectoriesToSyncAtLogonLogoff", value);
            }
        }

        public System.String[] ExcludedProfileDirs
        {
            get
            {
                System.String[] result;
                this.GetProperty("ExcludedProfileDirs", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExcludedProfileDirs", value);
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
    }
}