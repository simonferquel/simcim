using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SID : GenericInfrastructureObject
    {
        public Win32SID()
        {
        }

        public Win32SID(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AccountName
        {
            get
            {
                System.String result;
                this.GetProperty("AccountName", out result);
                return result;
            }
        }

        public System.Byte[] BinaryRepresentation
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("BinaryRepresentation", out result);
                return result;
            }
        }

        public System.String ReferencedDomainName
        {
            get
            {
                System.String result;
                this.GetProperty("ReferencedDomainName", out result);
                return result;
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

        public System.UInt32? SidLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SidLength", out result);
                return result;
            }
        }

        public Win32Account ResolveWin32AccountSIDElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_AccountSID", "Win32_Account", "Setting", "Element");
            return instances.Select(i => (Win32Account)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32DCOMApplication ResolveWin32DCOMApplicationAccessAllowedSettingElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_DCOMApplicationAccessAllowedSetting", "Win32_DCOMApplication", "Setting", "Element");
            return instances.Select(i => (Win32DCOMApplication)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SecuritySetting ResolveWin32SecuritySettingOwnerSecuritySetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SecuritySettingOwner", "Win32_SecuritySetting", "Owner", "SecuritySetting");
            return instances.Select(i => (Win32SecuritySetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32LogicalFileSecuritySetting ResolveWin32LogicalFileOwnerSecuritySetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalFileOwner", "Win32_LogicalFileSecuritySetting", "Owner", "SecuritySetting");
            return instances.Select(i => (Win32LogicalFileSecuritySetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SecuritySetting ResolveWin32SecuritySettingGroupSecuritySetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SecuritySettingGroup", "Win32_SecuritySetting", "Group", "SecuritySetting");
            return instances.Select(i => (Win32SecuritySetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32LogicalFileSecuritySetting ResolveWin32LogicalFileGroupSecuritySetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalFileGroup", "Win32_LogicalFileSecuritySetting", "Group", "SecuritySetting");
            return instances.Select(i => (Win32LogicalFileSecuritySetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32DCOMApplication ResolveWin32DCOMApplicationLaunchAllowedSettingElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_DCOMApplicationLaunchAllowedSetting", "Win32_DCOMApplication", "Setting", "Element");
            return instances.Select(i => (Win32DCOMApplication)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SecuritySetting ResolveWin32SecuritySettingAuditingSecuritySetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SecuritySettingAuditing", "Win32_SecuritySetting", "Trustee", "SecuritySetting");
            return instances.Select(i => (Win32SecuritySetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32LogicalFileSecuritySetting ResolveWin32LogicalFileAuditingSecuritySetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalFileAuditing", "Win32_LogicalFileSecuritySetting", "Trustee", "SecuritySetting");
            return instances.Select(i => (Win32LogicalFileSecuritySetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32LogicalShareSecuritySetting ResolveWin32LogicalShareAuditingSecuritySetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalShareAuditing", "Win32_LogicalShareSecuritySetting", "Trustee", "SecuritySetting");
            return instances.Select(i => (Win32LogicalShareSecuritySetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SecuritySetting ResolveWin32SecuritySettingAccessSecuritySetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SecuritySettingAccess", "Win32_SecuritySetting", "Trustee", "SecuritySetting");
            return instances.Select(i => (Win32SecuritySetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32LogicalFileSecuritySetting ResolveWin32LogicalFileAccessSecuritySetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalFileAccess", "Win32_LogicalFileSecuritySetting", "Trustee", "SecuritySetting");
            return instances.Select(i => (Win32LogicalFileSecuritySetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32LogicalShareSecuritySetting ResolveWin32LogicalShareAccessSecuritySetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalShareAccess", "Win32_LogicalShareSecuritySetting", "Trustee", "SecuritySetting");
            return instances.Select(i => (Win32LogicalShareSecuritySetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}