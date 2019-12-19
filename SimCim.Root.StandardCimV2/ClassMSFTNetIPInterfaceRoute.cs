using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetIPInterfaceRoute : CIMRouteUsesEndpoint
    {
        public MSFTNetIPInterfaceRoute()
        {
        }

        public MSFTNetIPInterfaceRoute(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMLANEndpoint Antecedent
        {
            get
            {
                CIMLANEndpoint result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new MSFTNetRoute Dependent
        {
            get
            {
                MSFTNetRoute result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Dependent", value);
            }
        }
    }
}