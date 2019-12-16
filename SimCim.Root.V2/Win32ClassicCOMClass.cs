using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ClassicCOMClass : Win32COMClass
    {
        public Win32ClassicCOMClass()
        {
        }

        public Win32ClassicCOMClass(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ComponentId
        {
            get
            {
                System.String result;
                this.GetProperty("ComponentId", out result);
                return result;
            }
        }

        public Win32ClassicCOMClassSetting ResolveWin32ClassicCOMClassSettingsSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ClassicCOMClassSettings", "Win32_ClassicCOMClassSetting", "Element", "Setting");
            return instances.Select(i => (Win32ClassicCOMClassSetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32ComponentCategory ResolveWin32ImplementedCategoryCategory()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ImplementedCategory", "Win32_ComponentCategory", "Component", "Category");
            return instances.Select(i => (Win32ComponentCategory)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32DCOMApplication> ResolveWin32ClassicCOMApplicationClassesGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ClassicCOMApplicationClasses", "Win32_DCOMApplication", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32DCOMApplication)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public Win32ClassicCOMClass ResolveWin32ComClassAutoEmulatorOldVersion()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ComClassAutoEmulator", "Win32_ClassicCOMClass", "NewVersion", "OldVersion");
            return instances.Select(i => (Win32ClassicCOMClass)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32ClassicCOMClass ResolveWin32ComClassAutoEmulatorNewVersion()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ComClassAutoEmulator", "Win32_ClassicCOMClass", "OldVersion", "NewVersion");
            return instances.Select(i => (Win32ClassicCOMClass)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32ClassicCOMClass ResolveWin32ComClassEmulatorOldVersion()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ComClassEmulator", "Win32_ClassicCOMClass", "NewVersion", "OldVersion");
            return instances.Select(i => (Win32ClassicCOMClass)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32ClassicCOMClass ResolveWin32ComClassEmulatorNewVersion()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ComClassEmulator", "Win32_ClassicCOMClass", "OldVersion", "NewVersion");
            return instances.Select(i => (Win32ClassicCOMClass)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}