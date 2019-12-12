using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertyString : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertyString()
        {
        }

        public Win32PnPDevicePropertyString(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Data
        {
            get
            {
                System.String result;
                this.GetProperty("Data", out result);
                return result;
            }
        }
    }
}