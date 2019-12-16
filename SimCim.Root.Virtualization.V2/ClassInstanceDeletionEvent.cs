using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class InstanceDeletionEvent : InstanceOperationEvent
    {
        public InstanceDeletionEvent()
        {
        }

        public InstanceDeletionEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}