using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSynthetic3DDisplayControllerSettingData : CIMResourceAllocationSettingData
    {
        public MsvmSynthetic3DDisplayControllerSettingData()
        {
        }

        public MsvmSynthetic3DDisplayControllerSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? MaximumMonitors
        {
            get
            {
                System.Byte? result;
                this.GetProperty("MaximumMonitors", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaximumMonitors", value);
            }
        }

        public System.Byte? MaximumScreenResolution
        {
            get
            {
                System.Byte? result;
                this.GetProperty("MaximumScreenResolution", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaximumScreenResolution", value);
            }
        }

        public System.UInt64? VRAMSizeBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VRAMSizeBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VRAMSizeBytes", value);
            }
        }
    }
}