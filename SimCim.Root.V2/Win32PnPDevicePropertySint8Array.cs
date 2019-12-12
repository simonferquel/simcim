using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertySint8Array : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertySint8Array()
        {
        }

        public Win32PnPDevicePropertySint8Array(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.SByte[] Data
        {
            get
            {
                System.SByte[] result;
                this.GetProperty("Data", out result);
                return result;
            }
        }
    }
}