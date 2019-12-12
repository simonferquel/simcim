using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMBindsTo : CIMSAPSAPDependency
    {
        protected CIMBindsTo()
        {
        }

        protected CIMBindsTo(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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
    }
}