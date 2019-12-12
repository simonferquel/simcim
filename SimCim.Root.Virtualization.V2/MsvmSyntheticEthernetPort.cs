using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSyntheticEthernetPort : CIMEthernetPort
    {
        public MsvmSyntheticEthernetPort()
        {
        }

        public MsvmSyntheticEthernetPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}