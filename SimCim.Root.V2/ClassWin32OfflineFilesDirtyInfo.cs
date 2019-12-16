using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OfflineFilesDirtyInfo : GenericInfrastructureObject
    {
        public Win32OfflineFilesDirtyInfo()
        {
        }

        public Win32OfflineFilesDirtyInfo(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Int64? LocalDirtyByteCount
        {
            get
            {
                System.Int64? result;
                this.GetProperty("LocalDirtyByteCount", out result);
                return result;
            }
        }

        public System.Int64? RemoteDirtyByteCount
        {
            get
            {
                System.Int64? result;
                this.GetProperty("RemoteDirtyByteCount", out result);
                return result;
            }
        }
    }
}