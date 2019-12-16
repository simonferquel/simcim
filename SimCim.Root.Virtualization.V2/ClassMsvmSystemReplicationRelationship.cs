using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSystemReplicationRelationship : CIMDependency
    {
        public MsvmSystemReplicationRelationship()
        {
        }

        public MsvmSystemReplicationRelationship(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmComputerSystem Antecedent
        {
            get
            {
                MsvmComputerSystem result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new MsvmReplicationRelationship Dependent
        {
            get
            {
                MsvmReplicationRelationship result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}