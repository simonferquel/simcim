﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class EventConsumerProviderRegistration : ProviderRegistration
    {
        public EventConsumerProviderRegistration()
        {
        }

        public EventConsumerProviderRegistration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CimInstance Provider
        {
            get
            {
                CimInstance result;
                this.GetProperty("provider", out result);
                return result;
            }

            set
            {
                this.SetProperty("provider", value);
            }
        }

        public System.String[] ConsumerClassNames
        {
            get
            {
                System.String[] result;
                this.GetProperty("ConsumerClassNames", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConsumerClassNames", value);
            }
        }
    }
}