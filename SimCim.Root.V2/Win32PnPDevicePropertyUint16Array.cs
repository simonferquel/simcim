using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertyUint16Array : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertyUint16Array()
        {
        }

        public Win32PnPDevicePropertyUint16Array(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] Data
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("Data", out result);
                return result;
            }
        }
    }
}