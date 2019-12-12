using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertyUint32Array : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertyUint32Array()
        {
        }

        public Win32PnPDevicePropertyUint32Array(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32[] Data
        {
            get
            {
                System.UInt32[] result;
                this.GetProperty("Data", out result);
                return result;
            }
        }
    }
}