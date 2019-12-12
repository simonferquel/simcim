using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmS3DisplayController : CIMDisplayController
    {
        public MsvmS3DisplayController()
        {
        }

        public MsvmS3DisplayController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}