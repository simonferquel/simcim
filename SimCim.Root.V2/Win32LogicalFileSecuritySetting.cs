using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogicalFileSecuritySetting : Win32SecuritySetting
    {
        public Win32LogicalFileSecuritySetting()
        {
        }

        public Win32LogicalFileSecuritySetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? OwnerPermissions
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OwnerPermissions", out result);
                return result;
            }
        }

        public System.String Path
        {
            get
            {
                System.String result;
                this.GetProperty("Path", out result);
                return result;
            }
        }

        public CIMLogicalFile ResolveWin32SecuritySettingOfLogicalFileElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SecuritySettingOfLogicalFile", "CIM_LogicalFile", "Setting", "Element");
            return instances.Select(i => (CIMLogicalFile)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SID ResolveWin32LogicalFileOwnerOwner()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalFileOwner", "Win32_SID", "SecuritySetting", "Owner");
            return instances.Select(i => (Win32SID)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SID ResolveWin32LogicalFileGroupGroup()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalFileGroup", "Win32_SID", "SecuritySetting", "Group");
            return instances.Select(i => (Win32SID)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SID ResolveWin32LogicalFileAuditingTrustee()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalFileAuditing", "Win32_SID", "SecuritySetting", "Trustee");
            return instances.Select(i => (Win32SID)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SID ResolveWin32LogicalFileAccessTrustee()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalFileAccess", "Win32_SID", "SecuritySetting", "Trustee");
            return instances.Select(i => (Win32SID)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}