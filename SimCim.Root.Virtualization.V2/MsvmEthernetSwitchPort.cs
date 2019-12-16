using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchPort : CIMEthernetPort
    {
        public MsvmEthernetSwitchPort()
        {
        }

        public MsvmEthernetSwitchPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? IOVOffloadUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IOVOffloadUsage", out result);
                return result;
            }
        }

        public System.UInt32? VMQOffloadUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VMQOffloadUsage", out result);
                return result;
            }
        }

        public MsvmDynamicForwardingEntry ResolveMsvmSwitchPortDynamicForwardingDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SwitchPortDynamicForwarding", "Msvm_DynamicForwardingEntry", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmDynamicForwardingEntry)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<MsvmEthernetPortData> ResolveMsvmEthernetPortInfoDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_EthernetPortInfo", "Msvm_EthernetPortData", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmEthernetPortData)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}