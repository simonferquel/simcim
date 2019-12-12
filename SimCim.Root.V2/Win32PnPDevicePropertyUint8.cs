using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertyUint8 : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertyUint8()
        {
        }

        public Win32PnPDevicePropertyUint8(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? Data
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Data", out result);
                return result;
            }
        }
    }
}