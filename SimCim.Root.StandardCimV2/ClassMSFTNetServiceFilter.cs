using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetServiceFilter : CIMFilterEntryBase
    {
        public MSFTNetServiceFilter()
        {
        }

        public MSFTNetServiceFilter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ServiceName
        {
            get
            {
                System.String result;
                this.GetProperty("ServiceName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServiceName", value);
            }
        }
    }
}