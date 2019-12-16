using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertySecurityDescriptorArray : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertySecurityDescriptorArray()
        {
        }

        public Win32PnPDevicePropertySecurityDescriptorArray(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public IEnumerable<Win32SecurityDescriptor> Data
        {
            get
            {
                IEnumerable<Win32SecurityDescriptor> result;
                this.GetInfrastructureObjectProperty("Data", out result);
                return result;
            }
        }
    }
}