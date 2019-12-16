using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
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

        public System.UInt32 EnableDevice(System.Boolean? inEnabled)
        {
            var parameters = new CimMethodParametersCollection();
            if (inEnabled.HasValue)
                parameters.Add(CimMethodParameter.Create("Enabled", inEnabled.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "EnableDevice", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 OnlineDevice(System.Boolean? inOnline)
        {
            var parameters = new CimMethodParametersCollection();
            if (inOnline.HasValue)
                parameters.Add(CimMethodParameter.Create("Online", inOnline.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "OnlineDevice", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 QuiesceDevice(System.Boolean? inQuiesce)
        {
            var parameters = new CimMethodParametersCollection();
            if (inQuiesce.HasValue)
                parameters.Add(CimMethodParameter.Create("Quiesce", inQuiesce.Value, CimFlags.None));
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
    }
}