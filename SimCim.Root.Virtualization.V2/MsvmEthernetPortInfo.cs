using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetPortInfo : CIMDependency
    {
        public MsvmEthernetPortInfo()
        {
        }

        public MsvmEthernetPortInfo(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmEthernetSwitchPort Antecedent
        {
            get
            {
                MsvmEthernetSwitchPort result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new MsvmEthernetPortData Dependent
        {
            get
            {
                MsvmEthernetPortData result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}