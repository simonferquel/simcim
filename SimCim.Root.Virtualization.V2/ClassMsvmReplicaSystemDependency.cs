using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmReplicaSystemDependency : CIMDependency
    {
        public MsvmReplicaSystemDependency()
        {
        }

        public MsvmReplicaSystemDependency(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMComputerSystem Antecedent
        {
            get
            {
                CIMComputerSystem result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMComputerSystem Dependent
        {
            get
            {
                CIMComputerSystem result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}