using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OfflineFilesPinInfo : GenericInfrastructureObject
    {
        public Win32OfflineFilesPinInfo()
        {
        }

        public Win32OfflineFilesPinInfo(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Pinned
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Pinned", out result);
                return result;
            }
        }

        public System.UInt32? PinnedForComputer
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PinnedForComputer", out result);
                return result;
            }
        }

        public System.UInt32? PinnedForFolderRedirection
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PinnedForFolderRedirection", out result);
                return result;
            }
        }

        public System.UInt32? PinnedForUser
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PinnedForUser", out result);
                return result;
            }
        }

        public System.UInt32? PinnedForUserByPolicy
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PinnedForUserByPolicy", out result);
                return result;
            }
        }
    }
}