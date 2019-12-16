using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmRegisteredGuestService : CIMDependency
    {
        public MsvmRegisteredGuestService()
        {
        }

        public MsvmRegisteredGuestService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmGuestServiceInterfaceComponent Antecedent
        {
            get
            {
                MsvmGuestServiceInterfaceComponent result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new MsvmGuestService Dependent
        {
            get
            {
                MsvmGuestService result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}