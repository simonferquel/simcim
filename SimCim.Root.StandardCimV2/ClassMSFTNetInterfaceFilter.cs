using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetInterfaceFilter : CIMFilterEntryBase
    {
        public MSFTNetInterfaceFilter()
        {
        }

        public MSFTNetInterfaceFilter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] InterfaceAlias
        {
            get
            {
                System.String[] result;
                this.GetProperty("InterfaceAlias", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterfaceAlias", value);
            }
        }
    }
}