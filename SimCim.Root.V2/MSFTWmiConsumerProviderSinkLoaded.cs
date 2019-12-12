using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTWmiConsumerProviderSinkLoaded : MSFTWmiConsumerProviderEvent
    {
        public MSFTWmiConsumerProviderSinkLoaded()
        {
        }

        public MSFTWmiConsumerProviderSinkLoaded(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public EventConsumer Consumer
        {
            get
            {
                EventConsumer result;
                this.GetInfrastructureObjectProperty("Consumer", out result);
                return result;
            }

            set
            {
                this.SetProperty("Consumer", value);
            }
        }
    }
}