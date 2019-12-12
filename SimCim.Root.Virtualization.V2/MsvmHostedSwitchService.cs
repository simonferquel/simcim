using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmHostedSwitchService : CIMHostedService
    {
        public MsvmHostedSwitchService()
        {
        }

        public MsvmHostedSwitchService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmVirtualEthernetSwitch Antecedent
        {
            get
            {
                MsvmVirtualEthernetSwitch result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }
    }
}