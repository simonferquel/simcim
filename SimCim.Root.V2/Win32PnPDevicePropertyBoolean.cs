using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertyBoolean : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertyBoolean()
        {
        }

        public Win32PnPDevicePropertyBoolean(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Data
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Data", out result);
                return result;
            }
        }
    }
}