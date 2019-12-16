using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmTransparentBridgingDynamicForwarding : CIMTransparentBridgingDynamicForwarding
    {
        public MsvmTransparentBridgingDynamicForwarding()
        {
        }

        public MsvmTransparentBridgingDynamicForwarding(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmTransparentBridgingService Antecedent
        {
            get
            {
                MsvmTransparentBridgingService result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new MsvmDynamicForwardingEntry Dependent
        {
            get
            {
                MsvmDynamicForwardingEntry result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}