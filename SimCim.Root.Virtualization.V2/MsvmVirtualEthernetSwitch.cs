using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualEthernetSwitch : CIMComputerSystem
    {
        public MsvmVirtualEthernetSwitch()
        {
        }

        public MsvmVirtualEthernetSwitch(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? MaxIOVOffloads
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxIOVOffloads", out result);
                return result;
            }
        }

        public System.UInt32? MaxVMQOffloads
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxVMQOffloads", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxVMQOffloads", value);
            }
        }

        public CIMService ResolveMsvmHostedSwitchServiceDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_HostedSwitchService", "CIM_Service", "Antecedent", "Dependent");
            return instances.Select(i => (CIMService)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public MsvmEthernetSwitchExtension ResolveMsvmHostedEthernetSwitchExtensionDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_HostedEthernetSwitchExtension", "Msvm_EthernetSwitchExtension", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmEthernetSwitchExtension)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<MsvmEthernetSwitchData> ResolveMsvmEthernetSwitchInfoDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_EthernetSwitchInfo", "Msvm_EthernetSwitchData", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmEthernetSwitchData)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}