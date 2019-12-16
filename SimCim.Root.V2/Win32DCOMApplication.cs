using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DCOMApplication : Win32COMApplication
    {
        public Win32DCOMApplication()
        {
        }

        public Win32DCOMApplication(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AppID
        {
            get
            {
                System.String result;
                this.GetProperty("AppID", out result);
                return result;
            }
        }

        public Win32DCOMApplicationSetting ResolveWin32COMApplicationSettingsSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_COMApplicationSettings", "Win32_DCOMApplicationSetting", "Element", "Setting");
            return instances.Select(i => (Win32DCOMApplicationSetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SID ResolveWin32DCOMApplicationAccessAllowedSettingSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_DCOMApplicationAccessAllowedSetting", "Win32_SID", "Element", "Setting");
            return instances.Select(i => (Win32SID)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMDataFile ResolveWin32ClientApplicationSettingClient()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ClientApplicationSetting", "CIM_DataFile", "Application", "Client");
            return instances.Select(i => (CIMDataFile)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32ClassicCOMClass> ResolveWin32ClassicCOMApplicationClassesPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ClassicCOMApplicationClasses", "Win32_ClassicCOMClass", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32ClassicCOMClass)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public Win32SID ResolveWin32DCOMApplicationLaunchAllowedSettingSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_DCOMApplicationLaunchAllowedSetting", "Win32_SID", "Element", "Setting");
            return instances.Select(i => (Win32SID)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}