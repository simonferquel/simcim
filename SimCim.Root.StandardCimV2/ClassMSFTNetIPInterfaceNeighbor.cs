using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetIPInterfaceNeighbor : CIMBindsToLANEndpoint
    {
        public MSFTNetIPInterfaceNeighbor()
        {
        }

        public MSFTNetIPInterfaceNeighbor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetIPInterface Antecedent
        {
            get
            {
                MSFTNetIPInterface result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new MSFTNetNeighbor Dependent
        {
            get
            {
                MSFTNetNeighbor result;
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