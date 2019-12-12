using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMConnectedTo : CIMDependency
    {
        protected CIMConnectedTo()
        {
        }

        protected CIMConnectedTo(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMPhysicalConnector Antecedent
        {
            get
            {
                CIMPhysicalConnector result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMPhysicalConnector Dependent
        {
            get
            {
                CIMPhysicalConnector result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}