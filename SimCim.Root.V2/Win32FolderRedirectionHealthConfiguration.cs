using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32FolderRedirectionHealthConfiguration : GenericInfrastructureObject
    {
        public Win32FolderRedirectionHealthConfiguration()
        {
        }

        public Win32FolderRedirectionHealthConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? LastSyncDurationCautionInHours
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LastSyncDurationCautionInHours", out result);
                return result;
            }

            set
            {
                this.SetProperty("LastSyncDurationCautionInHours", value);
            }
        }

        public System.UInt32? LastSyncDurationUnhealthyInHours
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LastSyncDurationUnhealthyInHours", out result);
                return result;
            }

            set
            {
                this.SetProperty("LastSyncDurationUnhealthyInHours", value);
            }
        }
    }
}