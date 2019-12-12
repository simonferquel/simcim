using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmExternalEthernetPort : CIMEthernetPort
    {
        public MsvmExternalEthernetPort()
        {
        }

        public MsvmExternalEthernetPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? IsBound
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsBound", out result);
                return result;
            }
        }

        public MsvmExternalEthernetPort ResolveMsvmVirtualEthernetSwitchNicTeamingMemberDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_VirtualEthernetSwitchNicTeamingMember", "Msvm_ExternalEthernetPort", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmExternalEthernetPort)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public MsvmExternalEthernetPort ResolveMsvmVirtualEthernetSwitchNicTeamingMemberAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_VirtualEthernetSwitchNicTeamingMember", "Msvm_ExternalEthernetPort", "Dependent", "Antecedent");
            return instances.Select(i => (MsvmExternalEthernetPort)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}