using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class CIMUSBDevice : CIMLogicalDevice
    {
        public CIMUSBDevice()
        {
        }

        public CIMUSBDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? ClassCode
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ClassCode", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClassCode", value);
            }
        }

        public System.Byte[] CurrentAlternateSettings
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("CurrentAlternateSettings", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentAlternateSettings", value);
            }
        }

        public System.Byte? CurrentConfigValue
        {
            get
            {
                System.Byte? result;
                this.GetProperty("CurrentConfigValue", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentConfigValue", value);
            }
        }

        public System.Byte? NumberOfConfigs
        {
            get
            {
                System.Byte? result;
                this.GetProperty("NumberOfConfigs", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfConfigs", value);
            }
        }

        public System.Byte? ProtocolCode
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ProtocolCode", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProtocolCode", value);
            }
        }

        public System.Byte? SubclassCode
        {
            get
            {
                System.Byte? result;
                this.GetProperty("SubclassCode", out result);
                return result;
            }

            set
            {
                this.SetProperty("SubclassCode", value);
            }
        }

        public System.UInt16? USBVersion
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("USBVersion", out result);
                return result;
            }

            set
            {
                this.SetProperty("USBVersion", value);
            }
        }

        public (System.UInt32 retval, System.UInt16? outRequestLength, System.Byte[] outBuffer) GetDescriptor(System.UInt16? inRequestIndex, System.UInt16? inRequestLength, System.Byte? inRequestType, System.UInt16? inRequestValue)
        {
            var parameters = new CimMethodParametersCollection();
            if (inRequestIndex.HasValue)
                parameters.Add(CimMethodParameter.Create("RequestIndex", inRequestIndex.Value, CimFlags.None));
            if (inRequestLength.HasValue)
                parameters.Add(CimMethodParameter.Create("RequestLength", inRequestLength.Value, CimFlags.None));
            if (inRequestType.HasValue)
                parameters.Add(CimMethodParameter.Create("RequestType", inRequestType.Value, CimFlags.None));
            if (inRequestValue.HasValue)
                parameters.Add(CimMethodParameter.Create("RequestValue", inRequestValue.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetDescriptor", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.UInt16? )result.OutParameters["RequestLength"].Value, (System.Byte[])result.OutParameters["Buffer"].Value);
        }
    }
}