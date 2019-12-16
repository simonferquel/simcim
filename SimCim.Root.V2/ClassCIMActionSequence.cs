using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMActionSequence : GenericInfrastructureObject
    {
        protected CIMActionSequence()
        {
        }

        protected CIMActionSequence(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMAction Next
        {
            get
            {
                CIMAction result;
                this.GetInfrastructureObjectProperty("Next", out result);
                return result;
            }
        }

        public CIMAction Prior
        {
            get
            {
                CIMAction result;
                this.GetInfrastructureObjectProperty("Prior", out result);
                return result;
            }
        }
    }
}