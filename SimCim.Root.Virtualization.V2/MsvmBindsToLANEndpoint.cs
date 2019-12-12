using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmBindsToLANEndpoint : CIMBindsToLANEndpoint
    {
        public MsvmBindsToLANEndpoint()
        {
        }

        public MsvmBindsToLANEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmLANEndpoint Antecedent
        {
            get
            {
                MsvmLANEndpoint result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new MsvmVLANEndpoint Dependent
        {
            get
            {
                MsvmVLANEndpoint result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}