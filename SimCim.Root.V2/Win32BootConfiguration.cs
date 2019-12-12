using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32BootConfiguration : CIMSetting
    {
        public Win32BootConfiguration()
        {
        }

        public Win32BootConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String BootDirectory
        {
            get
            {
                System.String result;
                this.GetProperty("BootDirectory", out result);
                return result;
            }
        }

        public System.String ConfigurationPath
        {
            get
            {
                System.String result;
                this.GetProperty("ConfigurationPath", out result);
                return result;
            }
        }

        public System.String LastDrive
        {
            get
            {
                System.String result;
                this.GetProperty("LastDrive", out result);
                return result;
            }
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

        public System.String ScratchDirectory
        {
            get
            {
                System.String result;
                this.GetProperty("ScratchDirectory", out result);
                return result;
            }
        }

        public System.String TempDirectory
        {
            get
            {
                System.String result;
                this.GetProperty("TempDirectory", out result);
                return result;
            }
        }

        public Win32ComputerSystem ResolveWin32SystemBootConfigurationElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemBootConfiguration", "Win32_ComputerSystem", "Setting", "Element");
            return instances.Select(i => (Win32ComputerSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}