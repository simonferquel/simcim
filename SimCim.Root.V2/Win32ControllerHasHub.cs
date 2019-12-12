using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ControllerHasHub : CIMUSBControllerHasHub
    {
        public Win32ControllerHasHub()
        {
        }

        public Win32ControllerHasHub(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32USBController Antecedent
        {
            get
            {
                Win32USBController result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32USBHub Dependent
        {
            get
            {
                Win32USBHub result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}