using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OfflineFilesDiskSpaceLimit : GenericInfrastructureObject
    {
        public Win32OfflineFilesDiskSpaceLimit()
        {
        }

        public Win32OfflineFilesDiskSpaceLimit(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AutoCacheSizeInMB
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AutoCacheSizeInMB", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutoCacheSizeInMB", value);
            }
        }

        public System.UInt32? TotalSizeInMB
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalSizeInMB", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalSizeInMB", value);
            }
        }
    }
}