using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MethodProviderRegistration : ProviderRegistration
    {
        public MethodProviderRegistration()
        {
        }

        public MethodProviderRegistration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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
    }
}