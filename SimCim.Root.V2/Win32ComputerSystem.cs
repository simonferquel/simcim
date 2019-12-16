using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ComputerSystem : CIMUnitaryComputerSystem
    {
        public Win32ComputerSystem()
        {
        }

        public Win32ComputerSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AdminPasswordStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AdminPasswordStatus", out result);
                return result;
            }
        }

        public System.Boolean? AutomaticManagedPagefile
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AutomaticManagedPagefile", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutomaticManagedPagefile", value);
            }
        }

        public System.Boolean? AutomaticResetBootOption
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AutomaticResetBootOption", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutomaticResetBootOption", value);
            }
        }

        public System.Boolean? AutomaticResetCapability
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AutomaticResetCapability", out result);
                return result;
            }
        }

        public System.UInt16? BootOptionOnLimit
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("BootOptionOnLimit", out result);
                return result;
            }
        }

        public System.UInt16? BootOptionOnWatchDog
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("BootOptionOnWatchDog", out result);
                return result;
            }
        }

        public System.Boolean? BootROMSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("BootROMSupported", out result);
                return result;
            }
        }

        public System.UInt16[] BootStatus
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("BootStatus", out result);
                return result;
            }
        }

        public System.String BootupState
        {
            get
            {
                System.String result;
                this.GetProperty("BootupState", out result);
                return result;
            }
        }

        public System.UInt16? ChassisBootupState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ChassisBootupState", out result);
                return result;
            }
        }

        public System.String ChassisSKUNumber
        {
            get
            {
                System.String result;
                this.GetProperty("ChassisSKUNumber", out result);
                return result;
            }
        }

        public System.Int16? CurrentTimeZone
        {
            get
            {
                System.Int16? result;
                this.GetProperty("CurrentTimeZone", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentTimeZone", value);
            }
        }

        public System.Boolean? DaylightInEffect
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DaylightInEffect", out result);
                return result;
            }
        }

        public System.String DNSHostName
        {
            get
            {
                System.String result;
                this.GetProperty("DNSHostName", out result);
                return result;
            }
        }

        public System.String Domain
        {
            get
            {
                System.String result;
                this.GetProperty("Domain", out result);
                return result;
            }
        }

        public System.UInt16? DomainRole
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DomainRole", out result);
                return result;
            }
        }

        public System.Boolean? EnableDaylightSavingsTime
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableDaylightSavingsTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableDaylightSavingsTime", value);
            }
        }

        public System.UInt16? FrontPanelResetStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("FrontPanelResetStatus", out result);
                return result;
            }
        }

        public System.Boolean? HypervisorPresent
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HypervisorPresent", out result);
                return result;
            }
        }

        public System.Boolean? InfraredSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("InfraredSupported", out result);
                return result;
            }
        }

        public System.UInt16? KeyboardPasswordStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("KeyboardPasswordStatus", out result);
                return result;
            }
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

        public System.String Model
        {
            get
            {
                System.String result;
                this.GetProperty("Model", out result);
                return result;
            }
        }

        public System.Boolean? NetworkServerModeEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NetworkServerModeEnabled", out result);
                return result;
            }
        }

        public System.UInt32? NumberOfLogicalProcessors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfLogicalProcessors", out result);
                return result;
            }
        }

        public System.UInt32? NumberOfProcessors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfProcessors", out result);
                return result;
            }
        }

        public System.Byte[] OEMLogoBitmap
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("OEMLogoBitmap", out result);
                return result;
            }
        }

        public System.String[] OEMStringArray
        {
            get
            {
                System.String[] result;
                this.GetProperty("OEMStringArray", out result);
                return result;
            }
        }

        public System.Boolean? PartOfDomain
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PartOfDomain", out result);
                return result;
            }
        }

        public System.Int64? PauseAfterReset
        {
            get
            {
                System.Int64? result;
                this.GetProperty("PauseAfterReset", out result);
                return result;
            }
        }

        public System.UInt16? PCSystemType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PCSystemType", out result);
                return result;
            }
        }

        public System.UInt16? PCSystemTypeEx
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PCSystemTypeEx", out result);
                return result;
            }
        }

        public System.UInt16? PowerOnPasswordStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PowerOnPasswordStatus", out result);
                return result;
            }
        }

        public System.UInt16? PowerSupplyState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PowerSupplyState", out result);
                return result;
            }
        }

        public System.Int16? ResetCount
        {
            get
            {
                System.Int16? result;
                this.GetProperty("ResetCount", out result);
                return result;
            }
        }

        public System.Int16? ResetLimit
        {
            get
            {
                System.Int16? result;
                this.GetProperty("ResetLimit", out result);
                return result;
            }
        }

        public System.String[] SupportContactDescription
        {
            get
            {
                System.String[] result;
                this.GetProperty("SupportContactDescription", out result);
                return result;
            }
        }

        public System.String SystemFamily
        {
            get
            {
                System.String result;
                this.GetProperty("SystemFamily", out result);
                return result;
            }
        }

        public System.String SystemSKUNumber
        {
            get
            {
                System.String result;
                this.GetProperty("SystemSKUNumber", out result);
                return result;
            }
        }

        public System.UInt16? SystemStartupDelay
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SystemStartupDelay", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemStartupDelay", value);
            }
        }

        public System.String[] SystemStartupOptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("SystemStartupOptions", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemStartupOptions", value);
            }
        }

        public System.Byte? SystemStartupSetting
        {
            get
            {
                System.Byte? result;
                this.GetProperty("SystemStartupSetting", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemStartupSetting", value);
            }
        }

        public System.String SystemType
        {
            get
            {
                System.String result;
                this.GetProperty("SystemType", out result);
                return result;
            }
        }

        public System.UInt16? ThermalState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ThermalState", out result);
                return result;
            }
        }

        public System.UInt64? TotalPhysicalMemory
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalPhysicalMemory", out result);
                return result;
            }
        }

        public System.String UserName
        {
            get
            {
                System.String result;
                this.GetProperty("UserName", out result);
                return result;
            }
        }

        public System.UInt16? WakeUpType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("WakeUpType", out result);
                return result;
            }
        }

        public System.String Workgroup
        {
            get
            {
                System.String result;
                this.GetProperty("Workgroup", out result);
                return result;
            }

            set
            {
                this.SetProperty("Workgroup", value);
            }
        }

        public System.UInt32 Rename(System.String inName, System.String inPassword, System.String inUserName)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Name", inName, inName == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("Password", inPassword, inPassword == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("UserName", inUserName, inUserName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Rename", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 JoinDomainOrWorkgroup(System.String inAccountOU, System.UInt32? inFJoinOptions, System.String inName, System.String inPassword, System.String inUserName)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("AccountOU", inAccountOU, inAccountOU == null ? CimFlags.NullValue : CimFlags.None));
            if (inFJoinOptions.HasValue)
                parameters.Add(CimMethodParameter.Create("FJoinOptions", inFJoinOptions.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("FJoinOptions", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("Name", inName, inName == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("Password", inPassword, inPassword == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("UserName", inUserName, inUserName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "JoinDomainOrWorkgroup", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 UnjoinDomainOrWorkgroup(System.UInt32? inFUnjoinOptions, System.String inPassword, System.String inUserName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFUnjoinOptions.HasValue)
                parameters.Add(CimMethodParameter.Create("FUnjoinOptions", inFUnjoinOptions.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("FUnjoinOptions", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("Password", inPassword, inPassword == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("UserName", inUserName, inUserName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "UnjoinDomainOrWorkgroup", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public CIMSetting ResolveWin32SystemSettingSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemSetting", "CIM_Setting", "Element", "Setting");
            return instances.Select(i => (CIMSetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32LogicalProgramGroup ResolveWin32SystemProgramGroupsSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemProgramGroups", "Win32_LogicalProgramGroup", "Element", "Setting");
            return instances.Select(i => (Win32LogicalProgramGroup)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32BootConfiguration ResolveWin32SystemBootConfigurationSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemBootConfiguration", "Win32_BootConfiguration", "Element", "Setting");
            return instances.Select(i => (Win32BootConfiguration)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32TimeZone ResolveWin32SystemTimeZoneSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemTimeZone", "Win32_TimeZone", "Element", "Setting");
            return instances.Select(i => (Win32TimeZone)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32Desktop ResolveWin32SystemDesktopSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemDesktop", "Win32_Desktop", "Element", "Setting");
            return instances.Select(i => (Win32Desktop)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32Service> ResolveWin32SystemServicesPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemServices", "Win32_Service", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32Service)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<Win32NetworkConnection> ResolveWin32SystemNetworkConnectionsPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemNetworkConnections", "Win32_NetworkConnection", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32NetworkConnection)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<CIMSystemResource> ResolveWin32SystemResourcesPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemResources", "CIM_SystemResource", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMSystemResource)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<Win32BIOS> ResolveWin32SystemBIOSPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemBIOS", "Win32_BIOS", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32BIOS)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<Win32LoadOrderGroup> ResolveWin32SystemLoadOrderGroupsPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemLoadOrderGroups", "Win32_LoadOrderGroup", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32LoadOrderGroup)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<Win32UserAccount> ResolveWin32SystemUsersPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemUsers", "Win32_UserAccount", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32UserAccount)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<Win32OperatingSystem> ResolveWin32SystemOperatingSystemPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemOperatingSystem", "Win32_OperatingSystem", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32OperatingSystem)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<CIMLogicalDevice> ResolveWin32SystemDevicesPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemDevices", "CIM_LogicalDevice", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<Win32Processor> ResolveWin32ComputerSystemProcessorPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ComputerSystemProcessor", "Win32_Processor", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32Processor)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<Win32DiskPartition> ResolveWin32SystemPartitionsPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemPartitions", "Win32_DiskPartition", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32DiskPartition)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<Win32SystemDriver> ResolveWin32SystemSystemDriverPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemSystemDriver", "Win32_SystemDriver", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32SystemDriver)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<Win32Process> ResolveWin32SystemProcessesPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemProcesses", "Win32_Process", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32Process)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public Win32NTLogEvent ResolveWin32NTLogEventComputerRecord()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_NTLogEventComputer", "Win32_NTLogEvent", "Computer", "Record");
            return instances.Select(i => (Win32NTLogEvent)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}