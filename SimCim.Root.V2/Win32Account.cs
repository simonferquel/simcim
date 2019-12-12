using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32Account : CIMLogicalElement
    {
        protected Win32Account()
        {
        }

        protected Win32Account(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Domain
        {
            get
            {
                System.String result;
                this.GetProperty("Domain", out result);
                return result;
            }
        }

        public System.Boolean? LocalAccount
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("LocalAccount", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalAccount", value);
            }
        }

        public System.String SID
        {
            get
            {
                System.String result;
                this.GetProperty("SID", out result);
                return result;
            }
        }

        public System.Byte? SIDType
        {
            get
            {
                System.Byte? result;
                this.GetProperty("SIDType", out result);
                return result;
            }
        }

        public Win32Group ResolveWin32GroupUserGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_GroupUser", "Win32_Group", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32Group)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32LogonSession ResolveWin32LoggedOnUserDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LoggedOnUser", "Win32_LogonSession", "Antecedent", "Dependent");
            return instances.Select(i => (Win32LogonSession)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32LogicalDisk ResolveWin32DiskQuotaQuotaVolume()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_DiskQuota", "Win32_LogicalDisk", "User", "QuotaVolume");
            return instances.Select(i => (Win32LogicalDisk)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SID ResolveWin32AccountSIDSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_AccountSID", "Win32_SID", "Element", "Setting");
            return instances.Select(i => (Win32SID)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32Volume ResolveWin32VolumeUserQuotaVolume()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_VolumeUserQuota", "Win32_Volume", "Account", "Volume");
            return instances.Select(i => (Win32Volume)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}