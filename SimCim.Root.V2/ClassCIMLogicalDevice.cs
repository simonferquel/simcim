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
    }
}