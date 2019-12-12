using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class NamespaceOperationEvent : Event
    {
        public NamespaceOperationEvent()
        {
        }

        public NamespaceOperationEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CimInstance TargetNamespace
        {
            get
            {
                CimInstance result;
                this.GetProperty("TargetNamespace", out result);
                return result;
            }

            set
            {
                this.SetProperty("TargetNamespace", value);
            }
        }
    }
}