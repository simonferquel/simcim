using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMClassIndication : CIMIndication
    {
        protected CIMClassIndication()
        {
        }

        protected CIMClassIndication(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CimInstance ClassDefinition
        {
            get
            {
                CimInstance result;
                this.GetProperty("ClassDefinition", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClassDefinition", value);
            }
        }
    }
}