using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SCSIControllerDevice : CIMControlledBy
    {
        public Win32SCSIControllerDevice()
        {
        }

        public Win32SCSIControllerDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32SCSIController Antecedent
        {
            get
            {
                Win32SCSIController result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }
    }
}