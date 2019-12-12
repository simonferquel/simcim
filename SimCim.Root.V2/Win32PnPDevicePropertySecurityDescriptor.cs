using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertySecurityDescriptor : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertySecurityDescriptor()
        {
        }

        public Win32PnPDevicePropertySecurityDescriptor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32SecurityDescriptor Data
        {
            get
            {
                Win32SecurityDescriptor result;
                this.GetInfrastructureObjectProperty("Data", out result);
                return result;
            }
        }
    }
}