using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMView : CIMManagedElement
    {
        protected CIMView()
        {
        }

        protected CIMView(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}