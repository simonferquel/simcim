using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class CIMInstModification : CIMInstIndication
    {
        public CIMInstModification()
        {
        }

        public CIMInstModification(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CimInstance PreviousInstance
        {
            get
            {
                CimInstance result;
                this.GetProperty("PreviousInstance", out result);
                return result;
            }

            set
            {
                this.SetProperty("PreviousInstance", value);
            }
        }
    }
}