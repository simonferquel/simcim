using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OfflineFilesFileSysInfo : GenericInfrastructureObject
    {
        public Win32OfflineFilesFileSysInfo()
        {
        }

        public Win32OfflineFilesFileSysInfo(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? LocalAttributes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LocalAttributes", out result);
                return result;
            }
        }

        public System.DateTime? LocalChangeTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LocalChangeTime", out result);
                return result;
            }
        }

        public System.DateTime? LocalCreationTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LocalCreationTime", out result);
                return result;
            }
        }

        public System.DateTime? LocalLastAccessTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LocalLastAccessTime", out result);
                return result;
            }
        }

        public System.DateTime? LocalLastWriteTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LocalLastWriteTime", out result);
                return result;
            }
        }

        public System.Int64? LocalSize
        {
            get
            {
                System.Int64? result;
                this.GetProperty("LocalSize", out result);
                return result;
            }
        }

        public System.UInt32? OriginalAttributes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OriginalAttributes", out result);
                return result;
            }
        }

        public System.DateTime? OriginalChangeTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("OriginalChangeTime", out result);
                return result;
            }
        }

        public System.DateTime? OriginalCreationTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("OriginalCreationTime", out result);
                return result;
            }
        }

        public System.DateTime? OriginalLastAccessTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("OriginalLastAccessTime", out result);
                return result;
            }
        }

        public System.DateTime? OriginalLastWriteTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("OriginalLastWriteTime", out result);
                return result;
            }
        }

        public System.Int64? OriginalSize
        {
            get
            {
                System.Int64? result;
                this.GetProperty("OriginalSize", out result);
                return result;
            }
        }

        public System.UInt32? RemoteAttributes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RemoteAttributes", out result);
                return result;
            }
        }

        public System.DateTime? RemoteChangeTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("RemoteChangeTime", out result);
                return result;
            }
        }

        public System.DateTime? RemoteCreationTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("RemoteCreationTime", out result);
                return result;
            }
        }

        public System.DateTime? RemoteLastAccessTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("RemoteLastAccessTime", out result);
                return result;
            }
        }

        public System.DateTime? RemoteLastWriteTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("RemoteLastWriteTime", out result);
                return result;
            }
        }

        public System.Int64? RemoteSize
        {
            get
            {
                System.Int64? result;
                this.GetProperty("RemoteSize", out result);
                return result;
            }
        }
    }
}