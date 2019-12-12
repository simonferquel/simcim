using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMBootSAP : CIMServiceAccessPoint
    {
        protected CIMBootSAP()
        {
        }

        protected CIMBootSAP(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}