using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32ManagedSystemElementResource : GenericInfrastructureObject
    {
        protected Win32ManagedSystemElementResource()
        {
        }

        protected Win32ManagedSystemElementResource(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}