using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNCProvCancelQuery : MSFTNCProvEvent
    {
        public MSFTNCProvCancelQuery()
        {
        }

        public MSFTNCProvCancelQuery(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ID", out result);
                return result;
            }

            set
            {
                this.SetProperty("ID", value);
            }
        }
    }
}