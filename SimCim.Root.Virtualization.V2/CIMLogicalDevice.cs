using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMLogicalDevice : CIMEnabledLogicalElement
    {
        protected CIMLogicalDevice()
        {
        }

        protected CIMLogicalDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] AdditionalAvailability
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("AdditionalAvailability", out result);
                return result;
            }

            set
            {
                this.SetProperty("AdditionalAvailability", value);
            }
        }

        public System.UInt16? Availability
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Availability", out result);
                return result;
            }

            set
            {
                this.SetProperty("Availability", value);
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

            set
            {
                this.SetProperty("CreationClassName", value);
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

            set
            {
                this.SetProperty("DeviceID", value);
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

            set
            {
                this.SetProperty("ErrorCleared", value);
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

            set
            {
                this.SetProperty("ErrorDescription", value);
            }
        }

        public System.String[] IdentifyingDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("IdentifyingDescriptions", out result);
                return result;
            }

            set
            {
                this.SetProperty("IdentifyingDescriptions", value);
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

            set
            {
                this.SetProperty("LastErrorCode", value);
            }
        }

        public System.UInt64? MaxQuiesceTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxQuiesceTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxQuiesceTime", value);
            }
        }

        public System.String[] OtherIdentifyingInfo
        {
            get
            {
                System.String[] result;
                this.GetProperty("OtherIdentifyingInfo", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherIdentifyingInfo", value);
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

            set
            {
                this.SetProperty("PowerManagementCapabilities", value);
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

            set
            {
                this.SetProperty("PowerManagementSupported", value);
            }
        }

        public System.UInt64? PowerOnHours
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PowerOnHours", out result);
                return result;
            }

            set
            {
                this.SetProperty("PowerOnHours", value);
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

            set
            {
                this.SetProperty("StatusInfo", value);
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

            set
            {
                this.SetProperty("SystemCreationClassName", value);
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

            set
            {
                this.SetProperty("SystemName", value);
            }
        }

        public System.UInt64? TotalPowerOnHours
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalPowerOnHours", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalPowerOnHours", value);
            }
        }

        public System.UInt32 SetPowerState(System.UInt16? inPowerState, System.DateTime? inTime)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPowerState.HasValue)
                parameters.Add(CimMethodParameter.Create("PowerState", inPowerState.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("PowerState", null, CimFlags.NullValue));
            if (inTime.HasValue)
                parameters.Add(CimMethodParameter.Create("Time", inTime.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Time", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetPowerState", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Reset()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Reset", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 EnableDevice(System.Boolean? inEnabled)
        {
            var parameters = new CimMethodParametersCollection();
            if (inEnabled.HasValue)
                parameters.Add(CimMethodParameter.Create("Enabled", inEnabled.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Enabled", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "EnableDevice", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 OnlineDevice(System.Boolean? inOnline)
        {
            var parameters = new CimMethodParametersCollection();
            if (inOnline.HasValue)
                parameters.Add(CimMethodParameter.Create("Online", inOnline.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Online", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "OnlineDevice", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 QuiesceDevice(System.Boolean? inQuiesce)
        {
            var parameters = new CimMethodParametersCollection();
            if (inQuiesce.HasValue)
                parameters.Add(CimMethodParameter.Create("Quiesce", inQuiesce.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Quiesce", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "QuiesceDevice", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SaveProperties()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SaveProperties", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 RestoreProperties()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RestoreProperties", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public CIMSystem ResolveCIMSystemDeviceGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SystemDevice", "CIM_System", "PartComponent", "GroupComponent");
            return instances.Select(i => (CIMSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMSystem ResolveMsvmSystemDeviceGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SystemDevice", "CIM_System", "PartComponent", "GroupComponent");
            return instances.Select(i => (CIMSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMProtocolController ResolveCIMProtocolControllerForDeviceAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ProtocolControllerForDevice", "CIM_ProtocolController", "Dependent", "Antecedent");
            return instances.Select(i => (CIMProtocolController)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMProtocolController ResolveCIMProtocolControllerForUnitAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ProtocolControllerForUnit", "CIM_ProtocolController", "Dependent", "Antecedent");
            return instances.Select(i => (CIMProtocolController)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMProtocolController ResolveMsvmProtocolControllerForUnitAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ProtocolControllerForUnit", "CIM_ProtocolController", "Dependent", "Antecedent");
            return instances.Select(i => (CIMProtocolController)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMServiceAccessPoint ResolveCIMDeviceSAPImplementationDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_DeviceSAPImplementation", "CIM_ServiceAccessPoint", "Antecedent", "Dependent");
            return instances.Select(i => (CIMServiceAccessPoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMServiceAccessPoint ResolveMsvmDeviceSAPImplementationDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_DeviceSAPImplementation", "CIM_ServiceAccessPoint", "Antecedent", "Dependent");
            return instances.Select(i => (CIMServiceAccessPoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMLogicalPort ResolveCIMPortOnDeviceDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_PortOnDevice", "CIM_LogicalPort", "Antecedent", "Dependent");
            return instances.Select(i => (CIMLogicalPort)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMLogicalPort ResolveMsvmSerialPortOnSerialControllerDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SerialPortOnSerialController", "CIM_LogicalPort", "Antecedent", "Dependent");
            return instances.Select(i => (CIMLogicalPort)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMLogicalDevice ResolveCIMDeviceConnectionDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_DeviceConnection", "CIM_LogicalDevice", "Antecedent", "Dependent");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMLogicalDevice ResolveCIMDeviceConnectionAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_DeviceConnection", "CIM_LogicalDevice", "Dependent", "Antecedent");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMController ResolveCIMControlledByAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ControlledBy", "CIM_Controller", "Dependent", "Antecedent");
            return instances.Select(i => (CIMController)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMController ResolveMsvmControlledByAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ControlledBy", "CIM_Controller", "Dependent", "Antecedent");
            return instances.Select(i => (CIMController)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}