using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmDynamicForwardingEntry : CIMDynamicForwardingEntry
    {
        public MsvmDynamicForwardingEntry()
        {
        }

        public MsvmDynamicForwardingEntry(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? VlanId
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("VlanId", out result);
                return result;
            }

            set
            {
                this.SetProperty("VlanId", value);
            }
        }

        public MsvmEthernetSwitchPort ResolveMsvmSwitchPortDynamicForwardingAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SwitchPortDynamicForwarding", "Msvm_EthernetSwitchPort", "Dependent", "Antecedent");
            return instances.Select(i => (MsvmEthernetSwitchPort)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public MsvmTransparentBridgingService ResolveMsvmTransparentBridgingDynamicForwardingAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_TransparentBridgingDynamicForwarding", "Msvm_TransparentBridgingService", "Dependent", "Antecedent");
            return instances.Select(i => (MsvmTransparentBridgingService)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}