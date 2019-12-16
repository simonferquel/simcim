using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32SecuritySetting : CIMSetting
    {
        protected Win32SecuritySetting()
        {
        }

        protected Win32SecuritySetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ControlFlags
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ControlFlags", out result);
                return result;
            }
        }

        public (System.UInt32 retval, Win32SecurityDescriptor outDescriptor) GetSecurityDescriptor()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetSecurityDescriptor", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (Win32SecurityDescriptor)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Descriptor"].Value));
        }

        public System.UInt32 SetSecurityDescriptor(Win32SecurityDescriptor inDescriptor)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDescriptor != null)
                parameters.Add(CimMethodParameter.Create("Descriptor", inDescriptor.AsCimInstance(), CimType.Instance, inDescriptor == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetSecurityDescriptor", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public Win32SID ResolveWin32SecuritySettingOwnerOwner()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SecuritySettingOwner", "Win32_SID", "SecuritySetting", "Owner");
            return instances.Select(i => (Win32SID)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SID ResolveWin32SecuritySettingGroupGroup()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SecuritySettingGroup", "Win32_SID", "SecuritySetting", "Group");
            return instances.Select(i => (Win32SID)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SID ResolveWin32SecuritySettingAuditingTrustee()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SecuritySettingAuditing", "Win32_SID", "SecuritySetting", "Trustee");
            return instances.Select(i => (Win32SID)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SID ResolveWin32SecuritySettingAccessTrustee()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SecuritySettingAccess", "Win32_SID", "SecuritySetting", "Trustee");
            return instances.Select(i => (Win32SID)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}