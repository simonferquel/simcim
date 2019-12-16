using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win321394ControllerDevice : CIMControlledBy
    {
        public Win321394ControllerDevice()
        {
        }

        public Win321394ControllerDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win321394Controller Antecedent
        {
            get
            {
                Win321394Controller result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }
    }
}