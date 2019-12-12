using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmCollectedVirtualSystems : CIMCollectedMSEs
    {
        public MsvmCollectedVirtualSystems()
        {
        }

        public MsvmCollectedVirtualSystems(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmVirtualSystemCollection Collection
        {
            get
            {
                MsvmVirtualSystemCollection result;
                this.GetInfrastructureObjectProperty("Collection", out result);
                return result;
            }

            set
            {
                this.SetProperty("Collection", value);
            }
        }

        public new MsvmComputerSystem Member
        {
            get
            {
                MsvmComputerSystem result;
                this.GetInfrastructureObjectProperty("Member", out result);
                return result;
            }

            set
            {
                this.SetProperty("Member", value);
            }
        }
    }
}