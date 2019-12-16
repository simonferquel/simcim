using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmHostedEthernetSwitchExtension : CIMHostedDependency
    {
        public MsvmHostedEthernetSwitchExtension()
        {
        }

        public MsvmHostedEthernetSwitchExtension(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new MsvmEthernetSwitchExtension Dependent
        {
            get
            {
                MsvmEthernetSwitchExtension result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Dependent", value);
            }
        }
    }
}