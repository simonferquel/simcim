using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OfflineFilesUserConfiguration : GenericInfrastructureObject
    {
        public Win32OfflineFilesUserConfiguration()
        {
        }

        public Win32OfflineFilesUserConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] AssignedOfflineFiles
        {
            get
            {
                System.String[] result;
                this.GetProperty("AssignedOfflineFiles", out result);
                return result;
            }

            set
            {
                this.SetProperty("AssignedOfflineFiles", value);
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