using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertySint16 : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertySint16()
        {
        }

        public Win32PnPDevicePropertySint16(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Int16? Data
        {
            get
            {
                System.Int16? result;
                this.GetProperty("Data", out result);
                return result;
            }
        }
    }
}