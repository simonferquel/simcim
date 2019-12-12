using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class ClassOperationEvent : Event
    {
        public ClassOperationEvent()
        {
        }

        public ClassOperationEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CimInstance TargetClass
        {
            get
            {
                CimInstance result;
                this.GetProperty("TargetClass", out result);
                return result;
            }

            set
            {
                this.SetProperty("TargetClass", value);
            }
        }
    }
}