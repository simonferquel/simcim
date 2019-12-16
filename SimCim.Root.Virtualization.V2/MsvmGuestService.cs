using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class MsvmGuestService : CIMService
    {
        protected MsvmGuestService()
        {
        }

        protected MsvmGuestService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public IEnumerable<MsvmGuestServiceInterfaceComponent> ResolveMsvmRegisteredGuestServiceAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_RegisteredGuestService", "Msvm_GuestServiceInterfaceComponent", "Dependent", "Antecedent");
            return instances.Select(i => (MsvmGuestServiceInterfaceComponent)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}