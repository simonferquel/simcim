using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmConcreteDependency : CIMConcreteDependency
    {
        public MsvmConcreteDependency()
        {
        }

        public MsvmConcreteDependency(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmInstalledEthernetSwitchExtension Antecedent
        {
            get
            {
                MsvmInstalledEthernetSwitchExtension result;
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