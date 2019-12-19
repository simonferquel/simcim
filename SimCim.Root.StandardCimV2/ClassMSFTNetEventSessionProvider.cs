using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetEventSessionProvider : CIMComponent
    {
        public MSFTNetEventSessionProvider()
        {
        }

        public MSFTNetEventSessionProvider(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetEventSession GroupComponent
        {
            get
            {
                MSFTNetEventSession result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupComponent", value);
            }
        }

        public new MSFTNetEventProvider PartComponent
        {
            get
            {
                MSFTNetEventProvider result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("PartComponent", value);
            }
        }
    }
}