using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class CIMPortImplementsEndpoint : CIMDeviceSAPImplementation
    {
        public CIMPortImplementsEndpoint()
        {
        }

        public CIMPortImplementsEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMLogicalPort Antecedent
        {
            get
            {
                CIMLogicalPort result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new CIMProtocolEndpoint Dependent
        {
            get
            {
                CIMProtocolEndpoint result;
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