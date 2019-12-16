using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SoftwareElementCheck : CIMSoftwareElementChecks
    {
        public Win32SoftwareElementCheck()
        {
        }

        public Win32SoftwareElementCheck(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32SoftwareElement Element
        {
            get
            {
                Win32SoftwareElement result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }
    }
}