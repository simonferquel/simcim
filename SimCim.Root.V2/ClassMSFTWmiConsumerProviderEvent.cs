using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTWmiConsumerProviderEvent : MSFTWmiProviderEvent
    {
        public MSFTWmiConsumerProviderEvent()
        {
        }

        public MSFTWmiConsumerProviderEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Machine
        {
            get
            {
                System.String result;
                this.GetProperty("Machine", out result);
                return result;
            }

            set
            {
                this.SetProperty("Machine", value);
            }
        }
    }
}