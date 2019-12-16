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
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPassword != null)
                parameters.Add(CimMethodParameter.Create("Password", inPassword, CimType.String, inPassword == null ? CimFlags.NullValue : CimFlags.None));
            if (inUserName != null)
                parameters.Add(CimMethodParameter.Create("UserName", inUserName, CimType.String, inUserName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Rename", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 JoinDomainOrWorkgroup(System.String inAccountOU, System.UInt32? inFJoinOptions, System.String inName, System.String inPassword, System.String inUserName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAccountOU != null)
                parameters.Add(CimMethodParameter.Create("AccountOU", inAccountOU, CimType.String, inAccountOU == null ? CimFlags.NullValue : CimFlags.None));
            if (inFJoinOptions.HasValue)
                parameters.Add(CimMethodParameter.Create("FJoinOptions", inFJoinOptions.Value, CimFlags.None));
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPassword != null)
                parameters.Add(CimMethodParameter.Create("Password", inPassword, CimType.String, inPassword == null ? CimFlags.NullValue : CimFlags.None));
            if (inUserName != null)
                parameters.Add(CimMethodParameter.Create("UserName", inUserName, CimType.String, inUserName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "JoinDomainOrWorkgroup", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 UnjoinDomainOrWorkgroup(System.UInt32? inFUnjoinOptions, System.String inPassword, System.String inUserName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFUnjoinOptions.HasValue)
                parameters.Add(CimMethodParameter.Create("FUnjoinOptions", inFUnjoinOptions.Value, CimFlags.None));
            if (inPassword != null)
                parameters.Add(CimMethodParameter.Create("Password", inPassword, CimType.String, inPassword == null ? CimFlags.NullValue : CimFlags.None));
            if (inUserName != null)
                parameters.Add(CimMethodParameter.Create("UserName", inUserName, CimType.String, inUserName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "UnjoinDomainOrWorkgroup", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}