using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMComponent : GenericInfrastructureObject
    {
        protected CIMComponent()
        {
        }

        protected CIMComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMManagedSystemElement GroupComponent
        {
            get
            {
                CIMManagedSystemElement result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public CIMManagedSystemElement PartComponent
        {
            get
            {
                CIMManagedSystemElement result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}