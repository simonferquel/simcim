using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSoftwareElementActions : GenericInfrastructureObject
    {
        protected CIMSoftwareElementActions()
        {
        }

        protected CIMSoftwareElementActions(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMAction Action
        {
            get
            {
                CIMAction result;
                this.GetInfrastructureObjectProperty("Action", out result);
                return result;
            }
        }

        public CIMSoftwareElement Element
        {
            get
            {
                CIMSoftwareElement result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }
    }
}