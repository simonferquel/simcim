using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertyStringArray : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertyStringArray()
        {
        }

        public Win32PnPDevicePropertyStringArray(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] Data
        {
            get
            {
                System.String[] result;
                this.GetProperty("Data", out result);
                return result;
            }
        }
    }
}