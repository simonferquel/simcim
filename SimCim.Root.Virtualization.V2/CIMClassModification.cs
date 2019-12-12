using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class CIMClassModification : CIMClassIndication
    {
        public CIMClassModification()
        {
        }

        public CIMClassModification(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CimInstance PreviousClassDefinition
        {
            get
            {
                CimInstance result;
                this.GetProperty("PreviousClassDefinition", out result);
                return result;
            }

            set
            {
                this.SetProperty("PreviousClassDefinition", value);
            }
        }
    }
}