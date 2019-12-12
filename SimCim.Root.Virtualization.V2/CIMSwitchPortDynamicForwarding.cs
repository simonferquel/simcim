using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMSwitchPortDynamicForwarding : CIMDependency
    {
        protected CIMSwitchPortDynamicForwarding()
        {
        }

        protected CIMSwitchPortDynamicForwarding(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMSwitchPort Antecedent
        {
            get
            {
                CIMSwitchPort result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new CIMDynamicForwardingEntry Dependent
        {
            get
            {
                CIMDynamicForwardingEntry result;
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