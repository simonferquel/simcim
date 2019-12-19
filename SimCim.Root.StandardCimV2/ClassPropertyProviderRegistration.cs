using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class PropertyProviderRegistration : ProviderRegistration
    {
        public PropertyProviderRegistration()
        {
        }

        public PropertyProviderRegistration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.Boolean? SupportsGet
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsGet", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportsGet", value);
            }
        }

        public System.Boolean? SupportsPut
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsPut", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportsPut", value);
            }
        }
    }
}