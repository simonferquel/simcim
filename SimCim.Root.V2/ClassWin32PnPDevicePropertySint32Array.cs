using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertySint32Array : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertySint32Array()
        {
        }

        public Win32PnPDevicePropertySint32Array(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Int32[] Data
        {
            get
            {
                System.Int32[] result;
                this.GetProperty("Data", out result);
                return result;
            }
        }
    }
}