using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class NamespaceModificationEvent : NamespaceOperationEvent
    {
        public NamespaceModificationEvent()
        {
        }

        public NamespaceModificationEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CimInstance PreviousNamespace
        {
            get
            {
                CimInstance result;
                this.GetProperty("PreviousNamespace", out result);
                return result;
            }

            set
            {
                this.SetProperty("PreviousNamespace", value);
            }
        }
    }
}