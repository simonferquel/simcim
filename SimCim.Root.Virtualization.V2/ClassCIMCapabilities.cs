using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMCapabilities : CIMManagedElement
    {
        protected CIMCapabilities()
        {
        }

        protected CIMCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}