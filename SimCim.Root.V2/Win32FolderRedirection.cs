using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32FolderRedirection : GenericInfrastructureObject
    {
        public Win32FolderRedirection()
        {
        }

        public Win32FolderRedirection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? ContentsMoved
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ContentsMoved", out result);
                return result;
            }

            set
            {
                this.SetProperty("ContentsMoved", value);
            }
        }

        public System.Boolean? ContentsMovedOnPolicyRemoval
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ContentsMovedOnPolicyRemoval", out result);
                return result;
            }

            set
            {
                this.SetProperty("ContentsMovedOnPolicyRemoval", value);
            }
        }

        public System.Boolean? ContentsRenamedInLocalCache
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ContentsRenamedInLocalCache", out result);
                return result;
            }

            set
            {
                this.SetProperty("ContentsRenamedInLocalCache", value);
            }
        }

        public System.Boolean? ExclusiveRightsGranted
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ExclusiveRightsGranted", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExclusiveRightsGranted", value);
            }
        }

        public System.String FolderId
        {
            get
            {
                System.String result;
                this.GetProperty("FolderId", out result);
                return result;
            }
        }

        public System.Boolean? MakeFolderAvailableOfflineDisabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MakeFolderAvailableOfflineDisabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("MakeFolderAvailableOfflineDisabled", value);
            }
        }

        public System.String RedirectionPath
        {
            get
            {
                System.String result;
                this.GetProperty("RedirectionPath", out result);
                return result;
            }

            set
            {
                this.SetProperty("RedirectionPath", value);
            }
        }

        public System.Byte? RedirectionType
        {
            get
            {
                System.Byte? result;
                this.GetProperty("RedirectionType", out result);
                return result;
            }

            set
            {
                this.SetProperty("RedirectionType", value);
            }
        }
    }
}