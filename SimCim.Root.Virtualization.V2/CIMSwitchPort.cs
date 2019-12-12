using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMSwitchPort : CIMProtocolEndpoint
    {
        protected CIMSwitchPort()
        {
        }

        protected CIMSwitchPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? PortNumber
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PortNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("PortNumber", value);
            }
        }

        public CIMDynamicForwardingEntry ResolveCIMSwitchPortDynamicForwardingDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SwitchPortDynamicForwarding", "CIM_DynamicForwardingEntry", "Antecedent", "Dependent");
            return instances.Select(i => (CIMDynamicForwardingEntry)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMSwitchService ResolveCIMSwitchesAmongDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SwitchesAmong", "CIM_SwitchService", "Antecedent", "Dependent");
            return instances.Select(i => (CIMSwitchService)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}