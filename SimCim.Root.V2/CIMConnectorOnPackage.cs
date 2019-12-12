using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMConnectorOnPackage : CIMContainer
    {
        protected CIMConnectorOnPackage()
        {
        }

        protected CIMConnectorOnPackage(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMPhysicalConnector PartComponent
        {
            get
            {
                CIMPhysicalConnector result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}