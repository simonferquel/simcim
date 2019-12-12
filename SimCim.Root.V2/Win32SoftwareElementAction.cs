using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SoftwareElementAction : CIMSoftwareElementActions
    {
        public Win32SoftwareElementAction()
        {
        }

        public Win32SoftwareElementAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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