using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmGuestServiceInterfaceComponent : CIMLogicalDevice
    {
        public MsvmGuestServiceInterfaceComponent()
        {
        }

        public MsvmGuestServiceInterfaceComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public IEnumerable<MsvmGuestService> ResolveMsvmRegisteredGuestServiceDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_RegisteredGuestService", "Msvm_GuestService", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmGuestService)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}