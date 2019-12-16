using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OfflineFilesItem : GenericInfrastructureObject
    {
        public Win32OfflineFilesItem()
        {
        }

        public Win32OfflineFilesItem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32OfflineFilesChangeInfo ChangeInfo
        {
            get
            {
                Win32OfflineFilesChangeInfo result;
                this.GetInfrastructureObjectProperty("ChangeInfo", out result);
                return result;
            }
        }

        public Win32OfflineFilesConnectionInfo ConnectionInfo
        {
            get
            {
                Win32OfflineFilesConnectionInfo result;
                this.GetInfrastructureObjectProperty("ConnectionInfo", out result);
                return result;
            }
        }

        public Win32OfflineFilesDirtyInfo DirtyInfo
        {
            get
            {
                Win32OfflineFilesDirtyInfo result;
                this.GetInfrastructureObjectProperty("DirtyInfo", out result);
                return result;
            }
        }

        public System.Boolean? Encrypted
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Encrypted", out result);
                return result;
            }
        }

        public Win32OfflineFilesFileSysInfo FileSysInfo
        {
            get
            {
                Win32OfflineFilesFileSysInfo result;
                this.GetInfrastructureObjectProperty("FileSysInfo", out result);
                return result;
            }
        }

        public System.String ItemName
        {
            get
            {
                System.String result;
                this.GetProperty("ItemName", out result);
                return result;
            }
        }

        public System.String ItemPath
        {
            get
            {
                System.String result;
                this.GetProperty("ItemPath", out result);
                return result;
            }
        }

        public System.UInt32? ItemType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ItemType", out result);
                return result;
            }
        }

        public System.String ParentItemPath
        {
            get
            {
                System.String result;
                this.GetProperty("ParentItemPath", out result);
                return result;
            }
        }

        public Win32OfflineFilesPinInfo PinInfo
        {
            get
            {
                Win32OfflineFilesPinInfo result;
                this.GetInfrastructureObjectProperty("PinInfo", out result);
                return result;
            }
        }

        public System.Boolean? Sparse
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Sparse", out result);
                return result;
            }
        }

        public Win32OfflineFilesSuspendInfo SuspendInfo
        {
            get
            {
                Win32OfflineFilesSuspendInfo result;
                this.GetInfrastructureObjectProperty("SuspendInfo", out result);
                return result;
            }
        }
    }
}