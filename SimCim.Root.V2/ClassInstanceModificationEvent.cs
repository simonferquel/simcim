using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class InstanceModificationEvent : InstanceOperationEvent
    {
        public InstanceModificationEvent()
        {
        }

        public InstanceModificationEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CimInstance PreviousInstance
        {
            get
            {
                CimInstance result;
                this.GetProperty("PreviousInstance", out result);
                return result;
            }

            set
            {
                this.SetProperty("PreviousInstance", value);
            }
        }
    }
}