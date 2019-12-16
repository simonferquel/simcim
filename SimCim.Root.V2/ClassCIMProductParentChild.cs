using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMProductParentChild : GenericInfrastructureObject
    {
        protected CIMProductParentChild()
        {
        }

        protected CIMProductParentChild(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMProduct Child
        {
            get
            {
                CIMProduct result;
                this.GetInfrastructureObjectProperty("Child", out result);
                return result;
            }
        }

        public CIMProduct Parent
        {
            get
            {
                CIMProduct result;
                this.GetInfrastructureObjectProperty("Parent", out result);
                return result;
            }
        }
    }
}