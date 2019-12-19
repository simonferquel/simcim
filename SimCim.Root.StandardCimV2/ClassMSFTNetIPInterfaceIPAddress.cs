using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetIPInterfaceIPAddress : CIMBindsToLANEndpoint
    {
        public MSFTNetIPInterfaceIPAddress()
        {
        }

        public MSFTNetIPInterfaceIPAddress(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public new MSFTNetIPAddress Dependent
        {
            get
            {
                MSFTNetIPAddress result;
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