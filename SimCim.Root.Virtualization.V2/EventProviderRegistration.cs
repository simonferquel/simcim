using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class EventProviderRegistration : ProviderRegistration
    {
        public EventProviderRegistration()
        {
        }

        public EventProviderRegistration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.String[] EventQueryList
        {
            get
            {
                System.String[] result;
                this.GetProperty("EventQueryList", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventQueryList", value);
            }
        }
    }
}