using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertySint16Array : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertySint16Array()
        {
        }

        public Win32PnPDevicePropertySint16Array(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Int64[] Data
        {
            get
            {
                System.Int64[] result;
                this.GetProperty("Data", out result);
                return result;
            }
        }
    }
}