using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertyUint64 : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertyUint64()
        {
        }

        public Win32PnPDevicePropertyUint64(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? Data
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Data", out result);
                return result;
            }
        }
    }
}