using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OperatingSystem : CIMOperatingSystem
    {
        public Win32OperatingSystem()
        {
        }

        public Win32OperatingSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String BootDevice
        {
            get
            {
                System.String result;
                this.GetProperty("BootDevice", out result);
                return result;
            }
        }

        public System.String BuildNumber
        {
            get
            {
                System.String result;
                this.GetProperty("BuildNumber", out result);
                return result;
            }
        }

        public System.String BuildType
        {
            get
            {
                System.String result;
                this.GetProperty("BuildType", out result);
                return result;
            }
        }

        public System.String CodeSet
        {
            get
            {
                System.String result;
                this.GetProperty("CodeSet", out result);
                return result;
            }
        }

        public System.String CountryCode
        {
            get
            {
                System.String result;
                this.GetProperty("CountryCode", out result);
                return result;
            }
        }

        public System.String CSDVersion
        {
            get
            {
                System.String result;
                this.GetProperty("CSDVersion", out result);
                return result;
            }
        }

        public System.Boolean? DataExecutionPrevention32BitApplications
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DataExecutionPrevention_32BitApplications", out result);
                return result;
            }
        }

        public System.Boolean? DataExecutionPreventionAvailable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DataExecutionPrevention_Available", out result);
                return result;
            }
        }

        public System.Boolean? DataExecutionPreventionDrivers
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DataExecutionPrevention_Drivers", out result);
                return result;
            }
        }

        public System.Byte? DataExecutionPreventionSupportPolicy
        {
            get
            {
                System.Byte? result;
                this.GetProperty("DataExecutionPrevention_SupportPolicy", out result);
                return result;
            }
        }

        public System.Boolean? Debug
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Debug", out result);
                return result;
            }
        }

        public System.UInt32? EncryptionLevel
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EncryptionLevel", out result);
                return result;
            }
        }

        public System.Byte? ForegroundApplicationBoost
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ForegroundApplicationBoost", out result);
                return result;
            }

            set
            {
                this.SetProperty("ForegroundApplicationBoost", value);
            }
        }

        public System.UInt32? LargeSystemCache
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LargeSystemCache", out result);
                return result;
            }
        }

        public System.String Locale
        {
            get
            {
                System.String result;
                this.GetProperty("Locale", out result);
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

        public System.String[] MUILanguages
        {
            get
            {
                System.String[] result;
                this.GetProperty("MUILanguages", out result);
                return result;
            }
        }

        public System.UInt32? OperatingSystemSKU
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OperatingSystemSKU", out result);
                return result;
            }
        }

        public System.String Organization
        {
            get
            {
                System.String result;
                this.GetProperty("Organization", out result);
                return result;
            }
        }

        public System.String OSArchitecture
        {
            get
            {
                System.String result;
                this.GetProperty("OSArchitecture", out result);
                return result;
            }
        }

        public System.UInt32? OSLanguage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OSLanguage", out result);
                return result;
            }
        }

        public System.UInt32? OSProductSuite
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OSProductSuite", out result);
                return result;
            }
        }

        public System.Boolean? PAEEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PAEEnabled", out result);
                return result;
            }
        }

        public System.String PlusProductID
        {
            get
            {
                System.String result;
                this.GetProperty("PlusProductID", out result);
                return result;
            }
        }

        public System.String PlusVersionNumber
        {
            get
            {
                System.String result;
                this.GetProperty("PlusVersionNumber", out result);
                return result;
            }
        }

        public System.Boolean? PortableOperatingSystem
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PortableOperatingSystem", out result);
                return result;
            }
        }

        public System.Boolean? Primary
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Primary", out result);
                return result;
            }
        }

        public System.UInt32? ProductType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProductType", out result);
                return result;
            }
        }

        public System.String RegisteredUser
        {
            get
            {
                System.String result;
                this.GetProperty("RegisteredUser", out result);
                return result;
            }
        }

        public System.String SerialNumber
        {
            get
            {
                System.String result;
                this.GetProperty("SerialNumber", out result);
                return result;
            }
        }

        public System.UInt16? ServicePackMajorVersion
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ServicePackMajorVersion", out result);
                return result;
            }
        }

        public System.UInt16? ServicePackMinorVersion
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ServicePackMinorVersion", out result);
                return result;
            }
        }

        public System.UInt32? SuiteMask
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SuiteMask", out result);
                return result;
            }
        }

        public System.String SystemDevice
        {
            get
            {
                System.String result;
                this.GetProperty("SystemDevice", out result);
                return result;
            }
        }

        public System.String SystemDirectory
        {
            get
            {
                System.String result;
                this.GetProperty("SystemDirectory", out result);
                return result;
            }
        }

        public System.String SystemDrive
        {
            get
            {
                System.String result;
                this.GetProperty("SystemDrive", out result);
                return result;
            }
        }

        public System.String WindowsDirectory
        {
            get
            {
                System.String result;
                this.GetProperty("WindowsDirectory", out result);
                return result;
            }
        }

        public System.UInt32 Win32Shutdown(System.Int32? inFlags, System.Int32? inReserved)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFlags.HasValue)
                parameters.Add(CimMethodParameter.Create("Flags", inFlags.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Flags", null, CimFlags.NullValue));
            if (inReserved.HasValue)
                parameters.Add(CimMethodParameter.Create("Reserved", inReserved.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Reserved", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Win32Shutdown", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Win32ShutdownTracker(System.String inComment, System.Int32? inFlags, System.UInt32? inReasonCode, System.UInt32? inTimeout)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComment != null)
                parameters.Add(CimMethodParameter.Create("Comment", inComment, CimType.String, inComment == null ? CimFlags.NullValue : CimFlags.None));
            if (inFlags.HasValue)
                parameters.Add(CimMethodParameter.Create("Flags", inFlags.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Flags", null, CimFlags.NullValue));
            if (inReasonCode.HasValue)
                parameters.Add(CimMethodParameter.Create("ReasonCode", inReasonCode.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ReasonCode", null, CimFlags.NullValue));
            if (inTimeout.HasValue)
                parameters.Add(CimMethodParameter.Create("Timeout", inTimeout.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Timeout", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Win32ShutdownTracker", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetDateTime(System.DateTime? inLocalDateTime)
        {
            var parameters = new CimMethodParametersCollection();
            if (inLocalDateTime.HasValue)
                parameters.Add(CimMethodParameter.Create("LocalDateTime", inLocalDateTime.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("LocalDateTime", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetDateTime", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public Win32QuickFixEngineering ResolveWin32OperatingSystemQFEDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_OperatingSystemQFE", "Win32_QuickFixEngineering", "Antecedent", "Dependent");
            return instances.Select(i => (Win32QuickFixEngineering)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32ComputerSystem> ResolveWin32SystemOperatingSystemGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemOperatingSystem", "Win32_ComputerSystem", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32ComputerSystem)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public Win32AutochkSetting ResolveWin32OperatingSystemAutochkSettingSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_OperatingSystemAutochkSetting", "Win32_AutochkSetting", "Element", "Setting");
            return instances.Select(i => (Win32AutochkSetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}