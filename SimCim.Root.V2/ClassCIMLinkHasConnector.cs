using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMLinkHasConnector : CIMComponent
    {
        protected CIMLinkHasConnector()
        {
        }

        protected CIMLinkHasConnector(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMPhysicalLink GroupComponent
        {
            get
            {
                CIMPhysicalLink result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
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