using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmActiveConnection : CIMActiveConnection
    {
        public MsvmActiveConnection()
        {
        }

        public MsvmActiveConnection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public new CIMLANEndpoint Dependent
        {
            get
            {
                CIMLANEndpoint result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}