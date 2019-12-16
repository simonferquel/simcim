using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTWmiThreadPoolEvent : MSFTWmiEssEvent
    {
        public MSFTWmiThreadPoolEvent()
        {
        }

        public MSFTWmiThreadPoolEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ThreadId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ThreadId", out result);
                return result;
            }

            set
            {
                this.SetProperty("ThreadId", value);
            }
        }
    }
}