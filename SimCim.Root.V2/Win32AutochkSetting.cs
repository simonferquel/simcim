using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32AutochkSetting : CIMSetting
    {
        public Win32AutochkSetting()
        {
        }

        public Win32AutochkSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? UserInputDelay
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UserInputDelay", out result);
                return result;
            }

            set
            {
                this.SetProperty("UserInputDelay", value);
            }
        }

        public Win32OperatingSystem ResolveWin32OperatingSystemAutochkSettingElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_OperatingSystemAutochkSetting", "Win32_OperatingSystem", "Setting", "Element");
            return instances.Select(i => (Win32OperatingSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}