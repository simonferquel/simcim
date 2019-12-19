using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class CIMRouteUsesEndpoint : CIMDependency
    {
        public CIMRouteUsesEndpoint()
        {
        }

        public CIMRouteUsesEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMProtocolEndpoint Antecedent
        {
            get
            {
                CIMProtocolEndpoint result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new CIMNextHopRoute Dependent
        {
            get
            {
                CIMNextHopRoute result;
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