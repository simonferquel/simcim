using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogicalShareSecuritySetting : Win32SecuritySetting
    {
        public Win32LogicalShareSecuritySetting()
        {
        }

        public Win32LogicalShareSecuritySetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
                return result;
            }
        }

        public Win32Share ResolveWin32SecuritySettingOfLogicalShareElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SecuritySettingOfLogicalShare", "Win32_Share", "Setting", "Element");
            return instances.Select(i => (Win32Share)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SID ResolveWin32LogicalShareAuditingTrustee()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalShareAuditing", "Win32_SID", "SecuritySetting", "Trustee");
            return instances.Select(i => (Win32SID)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SID ResolveWin32LogicalShareAccessTrustee()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalShareAccess", "Win32_SID", "SecuritySetting", "Trustee");
            return instances.Select(i => (Win32SID)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}