using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmAssignableDeviceDismountSettingData : CIMSettingData
    {
        public MsvmAssignableDeviceDismountSettingData()
        {
        }

        public MsvmAssignableDeviceDismountSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DeviceInstancePath
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceInstancePath", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeviceInstancePath", value);
            }
        }

        public System.String DeviceLocationPath
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceLocationPath", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeviceLocationPath", value);
            }
        }

        public System.Boolean? RequireAcsSupport
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RequireAcsSupport", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequireAcsSupport", value);
            }
        }

        public System.Boolean? RequireDeviceMitigations
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RequireDeviceMitigations", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequireDeviceMitigations", value);
            }
        }
    }
}