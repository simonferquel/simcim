using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertyReal64Array : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertyReal64Array()
        {
        }

        public Win32PnPDevicePropertyReal64Array(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Double[] Data
        {
            get
            {
                System.Double[] result;
                this.GetProperty("Data", out result);
                return result;
            }
        }
    }
}