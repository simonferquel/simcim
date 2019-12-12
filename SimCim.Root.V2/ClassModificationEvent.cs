using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class ClassModificationEvent : ClassOperationEvent
    {
        public ClassModificationEvent()
        {
        }

        public ClassModificationEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CimInstance PreviousClass
        {
            get
            {
                CimInstance result;
                this.GetProperty("PreviousClass", out result);
                return result;
            }

            set
            {
                this.SetProperty("PreviousClass", value);
            }
        }
    }
}