using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmBootSourceSettingData : CIMSettingData
    {
        public MsvmBootSourceSettingData()
        {
        }

        public MsvmBootSourceSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String BootSourceDescription
        {
            get
            {
                System.String result;
                this.GetProperty("BootSourceDescription", out result);
                return result;
            }
        }

        public System.UInt32? BootSourceType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BootSourceType", out result);
                return result;
            }
        }

        public System.String FirmwareDevicePath
        {
            get
            {
                System.String result;
                this.GetProperty("FirmwareDevicePath", out result);
                return result;
            }
        }

        public System.Byte[] OptionalData
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("OptionalData", out result);
                return result;
            }
        }

        public System.String OtherLocation
        {
            get
            {
                System.String result;
                this.GetProperty("OtherLocation", out result);
                return result;
            }
        }
    }
}