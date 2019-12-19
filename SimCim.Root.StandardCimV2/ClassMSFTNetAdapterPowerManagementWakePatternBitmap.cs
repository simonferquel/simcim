using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterPowerManagementWakePatternBitmap : MSFTNetAdapterPowerManagementWakePattern
    {
        public MSFTNetAdapterPowerManagementWakePatternBitmap()
        {
        }

        public MSFTNetAdapterPowerManagementWakePatternBitmap(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte[] Mask
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("Mask", out result);
                return result;
            }

            set
            {
                this.SetProperty("Mask", value);
            }
        }

        public System.Byte[] Pattern
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("Pattern", out result);
                return result;
            }

            set
            {
                this.SetProperty("Pattern", value);
            }
        }
    }
}