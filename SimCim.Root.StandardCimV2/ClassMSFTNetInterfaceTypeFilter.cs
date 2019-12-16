using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetInterfaceTypeFilter : CIMFilterEntryBase
    {
        public MSFTNetInterfaceTypeFilter()
        {
        }

        public MSFTNetInterfaceTypeFilter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? InterfaceType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterfaceType", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterfaceType", value);
            }
        }
    }
}