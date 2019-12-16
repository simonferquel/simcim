using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMProcessThread : CIMComponent
    {
        protected CIMProcessThread()
        {
        }

        protected CIMProcessThread(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMProcess GroupComponent
        {
            get
            {
                CIMProcess result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMThread PartComponent
        {
            get
            {
                CIMThread result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}