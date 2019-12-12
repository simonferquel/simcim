using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OfflineFilesConnectionInfo : GenericInfrastructureObject
    {
        public Win32OfflineFilesConnectionInfo()
        {
        }

        public Win32OfflineFilesConnectionInfo(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ConnectState
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectState", out result);
                return result;
            }
        }

        public System.UInt32? OfflineReason
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OfflineReason", out result);
                return result;
            }
        }
    }
}