using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMTransparentBridgingDynamicForwarding : CIMDependency
    {
        protected CIMTransparentBridgingDynamicForwarding()
        {
        }

        protected CIMTransparentBridgingDynamicForwarding(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMTransparentBridgingService Antecedent
        {
            get
            {
                CIMTransparentBridgingService result;
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