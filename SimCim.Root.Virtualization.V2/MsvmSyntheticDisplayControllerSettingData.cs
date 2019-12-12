using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSyntheticDisplayControllerSettingData : CIMResourceAllocationSettingData
    {
        public MsvmSyntheticDisplayControllerSettingData()
        {
        }

        public MsvmSyntheticDisplayControllerSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? HorizontalResolution
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HorizontalResolution", out result);
                return result;
            }

            set
            {
                this.SetProperty("HorizontalResolution", value);
            }
        }

        public System.Byte? ResolutionType
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ResolutionType", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResolutionType", value);
            }
        }

        public System.UInt16? VerticalResolution
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("VerticalResolution", out result);
                return result;
            }

            set
            {
                this.SetProperty("VerticalResolution", value);
            }
        }
    }
}