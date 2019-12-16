using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class CIMDataFile : CIMLogicalFile
    {
        public CIMDataFile()
        {
        }

        public CIMDataFile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Manufacturer
        {
            get
            {
                System.String result;
                this.GetProperty("Manufacturer", out result);
                return result;
            }
        }

        public System.String Version
        {
            get
            {
                System.String result;
                this.GetProperty("Version", out result);
                return result;
            }
        }

        public Win32Printer ResolveWin32PrinterDriverDllDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_PrinterDriverDll", "Win32_Printer", "Antecedent", "Dependent");
            return instances.Select(i => (Win32Printer)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMLogicalDevice ResolveWin32CIMLogicalDeviceCIMDataFileAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_CIMLogicalDeviceCIMDataFile", "CIM_LogicalDevice", "Dependent", "Antecedent");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32PnPSignedDriver ResolveWin32PnPSignedDriverCIMDataFileAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_PnPSignedDriverCIMDataFile", "Win32_PnPSignedDriver", "Dependent", "Antecedent");
            return instances.Select(i => (Win32PnPSignedDriver)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMProcess ResolveCIMProcessExecutableDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "CIM_ProcessExecutable", "CIM_Process", "Antecedent", "Dependent");
            return instances.Select(i => (CIMProcess)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32LogicalProgramGroupItem ResolveWin32LogicalProgramGroupItemDataFileAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalProgramGroupItemDataFile", "Win32_LogicalProgramGroupItem", "Dependent", "Antecedent");
            return instances.Select(i => (Win32LogicalProgramGroupItem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<CIMDirectory> ResolveCIMDirectoryContainsFileGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "CIM_DirectoryContainsFile", "CIM_Directory", "PartComponent", "GroupComponent");
            return instances.Select(i => (CIMDirectory)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public Win32DCOMApplication ResolveWin32ClientApplicationSettingApplication()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ClientApplicationSetting", "Win32_DCOMApplication", "Client", "Application");
            return instances.Select(i => (Win32DCOMApplication)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}