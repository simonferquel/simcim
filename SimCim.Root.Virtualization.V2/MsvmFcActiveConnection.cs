using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmFcActiveConnection : CIMActiveConnection
    {
        public MsvmFcActiveConnection()
        {
        }

        public MsvmFcActiveConnection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmFcEndpoint Antecedent
        {
            get
            {
                MsvmFcEndpoint result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new MsvmFcEndpoint Dependent
        {
            get
            {
                MsvmFcEndpoint result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}