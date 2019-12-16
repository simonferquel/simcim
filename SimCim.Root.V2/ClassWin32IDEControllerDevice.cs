using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32IDEControllerDevice : CIMControlledBy
    {
        public Win32IDEControllerDevice()
        {
        }

        public Win32IDEControllerDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32IDEController Antecedent
        {
            get
            {
                Win32IDEController result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }
    }
}