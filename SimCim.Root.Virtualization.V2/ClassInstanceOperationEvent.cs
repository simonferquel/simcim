using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class InstanceOperationEvent : Event
    {
        public InstanceOperationEvent()
        {
        }

        public InstanceOperationEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CimInstance TargetInstance
        {
            get
            {
                CimInstance result;
                this.GetProperty("TargetInstance", out result);
                return result;
            }

            set
            {
                this.SetProperty("TargetInstance", value);
            }
        }
    }
}