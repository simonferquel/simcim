using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32InstalledSoftwareElement : CIMInstalledSoftwareElement
    {
        public Win32InstalledSoftwareElement()
        {
        }

        public Win32InstalledSoftwareElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32SoftwareElement Software
        {
            get
            {
                Win32SoftwareElement result;
                this.GetInfrastructureObjectProperty("Software", out result);
                return result;
            }
        }
    }
}