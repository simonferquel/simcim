using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSetting : GenericInfrastructureObject
    {
        protected CIMSetting()
        {
        }

        protected CIMSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Caption
        {
            get
            {
                System.String result;
                this.GetProperty("Caption", out result);
                return result;
            }
        }

        public System.String Description
        {
            get
            {
                System.String result;
                this.GetProperty("Description", out result);
                return result;
            }
        }

        public System.String SettingID
        {
            get
            {
                System.String result;
                this.GetProperty("SettingID", out result);
                return result;
            }
        }

        public CIMLogicalDevice ResolveWin32DeviceSettingsElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_DeviceSettings", "CIM_LogicalDevice", "Setting", "Element");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32ComputerSystem ResolveWin32SystemSettingElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemSetting", "Win32_ComputerSystem", "Setting", "Element");
            return instances.Select(i => (Win32ComputerSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}