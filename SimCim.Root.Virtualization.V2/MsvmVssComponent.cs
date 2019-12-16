using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVssComponent : CIMLogicalDevice
    {
        public MsvmVssComponent()
        {
        }

        public MsvmVssComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public IEnumerable<MsvmVssService> ResolveMsvmServiceOfVssComponentDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ServiceOfVssComponent", "Msvm_VssService", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmVssService)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}