using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertySint8 : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertySint8()
        {
        }

        public Win32PnPDevicePropertySint8(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.SByte? Data
        {
            get
            {
                System.SByte? result;
                this.GetProperty("Data", out result);
                return result;
            }
        }
    }
}