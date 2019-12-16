using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMLogicalDevice : CIMLogicalElement
    {
        protected CIMLogicalDevice()
        {
        }

        protected CIMLogicalDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Availability
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Availability", out result);
                return result;
            }
        }

        public System.UInt32? ConfigManagerErrorCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConfigManagerErrorCode", out result);
                return result;
            }
        }

        public System.Boolean? ConfigManagerUserConfig
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ConfigManagerUserConfig", out result);
                return result;
            }
        }

        public System.String CreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CreationClassName", out result);
                return result;
            }
        }

        public System.String DeviceID
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceID", out result);
                return result;
            }
        }

        public System.Boolean? ErrorCleared
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ErrorCleared", out result);
                return result;
            }
        }

        public System.String ErrorDescription
        {
            get
            {
                System.String result;
                this.GetProperty("ErrorDescription", out result);
                return result;
            }
        }

        public System.UInt32? LastErrorCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LastErrorCode", out result);
                return result;
            }
        }

        public System.String PNPDeviceID
        {
            get
            {
                System.String result;
                this.GetProperty("PNPDeviceID", out result);
                return result;
            }
        }

        public System.UInt16[] PowerManagementCapabilities
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("PowerManagementCapabilities", out result);
                return result;
            }
        }

        public System.Boolean? PowerManagementSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PowerManagementSupported", out result);
                return result;
            }
        }

        public System.UInt16? StatusInfo
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("StatusInfo", out result);
                return result;
            }
        }

        public System.String SystemCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemCreationClassName", out result);
                return result;
            }
        }

        public System.String SystemName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemName", out result);
                return result;
            }
        }

        public System.UInt32 SetPowerState(System.UInt16? inPowerState, System.DateTime? inTime)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPowerState.HasValue)
                parameters.Add(CimMethodParameter.Create("PowerState", inPowerState.Value, CimFlags.None));
            if (inTime.HasValue)
                parameters.Add(CimMethodParameter.Create("Time", inTime.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetPowerState", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Reset()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Reset", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public Win32Bus ResolveWin32DeviceBusAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_DeviceBus", "Win32_Bus", "Dependent", "Antecedent");
            return instances.Select(i => (Win32Bus)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SCSIController ResolveWin32SCSIControllerDeviceAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SCSIControllerDevice", "Win32_SCSIController", "Dependent", "Antecedent");
            return instances.Select(i => (Win32SCSIController)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMUSBController ResolveWin32USBControllerDeviceAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_USBControllerDevice", "CIM_USBController", "Dependent", "Antecedent");
            return instances.Select(i => (CIMUSBController)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32IDEController ResolveWin32IDEControllerDeviceAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_IDEControllerDevice", "Win32_IDEController", "Dependent", "Antecedent");
            return instances.Select(i => (Win32IDEController)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win321394Controller ResolveWin321394ControllerDeviceAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_1394ControllerDevice", "Win32_1394Controller", "Dependent", "Antecedent");
            return instances.Select(i => (Win321394Controller)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMDataFile ResolveWin32CIMLogicalDeviceCIMDataFileDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_CIMLogicalDeviceCIMDataFile", "CIM_DataFile", "Antecedent", "Dependent");
            return instances.Select(i => (CIMDataFile)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMSystemResource ResolveWin32AllocatedResourceAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_AllocatedResource", "CIM_SystemResource", "Dependent", "Antecedent");
            return instances.Select(i => (CIMSystemResource)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32ComputerSystem> ResolveWin32SystemDevicesGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemDevices", "Win32_ComputerSystem", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32ComputerSystem)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public CIMSetting ResolveWin32DeviceSettingsSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_DeviceSettings", "CIM_Setting", "Element", "Setting");
            return instances.Select(i => (CIMSetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32PnPEntity ResolveWin32PnPDeviceSystemElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_PnPDevice", "Win32_PnPEntity", "SameElement", "SystemElement");
            return instances.Select(i => (Win32PnPEntity)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}