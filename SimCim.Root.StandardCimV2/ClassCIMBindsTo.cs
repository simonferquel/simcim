using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class CIMBindsTo : CIMSAPSAPDependency
    {
        public CIMBindsTo()
        {
        }

        public CIMBindsTo(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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