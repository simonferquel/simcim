using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNCProvClientConnected : MSFTNCProvEvent
    {
        public MSFTNCProvClientConnected()
        {
        }

        public MSFTNCProvClientConnected(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Inproc
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Inproc", out result);
                return result;
            }

            set
            {
                this.SetProperty("Inproc", value);
            }
        }
    }
}