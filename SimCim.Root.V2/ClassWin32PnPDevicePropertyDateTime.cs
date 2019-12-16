using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertyDateTime : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertyDateTime()
        {
        }

        public Win32PnPDevicePropertyDateTime(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.DateTime? Data
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("Data", out result);
                return result;
            }
        }
    }
}