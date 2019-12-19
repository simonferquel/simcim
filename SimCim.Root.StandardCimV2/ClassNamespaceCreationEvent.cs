using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class NamespaceCreationEvent : NamespaceOperationEvent
    {
        public NamespaceCreationEvent()
        {
        }

        public NamespaceCreationEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}