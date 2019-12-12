using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class ProviderRegistration : SystemClass
    {
        protected ProviderRegistration()
        {
        }

        protected ProviderRegistration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Provider Provider
        {
            get
            {
                Provider result;
                this.GetInfrastructureObjectProperty("provider", out result);
                return result;
            }

            set
            {
                this.SetProperty("provider", value);
            }
        }
    }
}