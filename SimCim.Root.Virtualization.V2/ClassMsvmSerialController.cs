using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSerialController : CIMSerialController
    {
        public MsvmSerialController()
        {
        }

        public MsvmSerialController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}