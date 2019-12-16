using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMCreateDirectoryAction : CIMDirectoryAction
    {
        protected CIMCreateDirectoryAction()
        {
        }

        protected CIMCreateDirectoryAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}