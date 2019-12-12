using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OfflineFilesSuspendInfo : GenericInfrastructureObject
    {
        public Win32OfflineFilesSuspendInfo()
        {
        }

        public Win32OfflineFilesSuspendInfo(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Suspended
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Suspended", out result);
                return result;
            }
        }

        public System.Boolean? SuspendedRoot
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SuspendedRoot", out result);
                return result;
            }
        }
    }
}