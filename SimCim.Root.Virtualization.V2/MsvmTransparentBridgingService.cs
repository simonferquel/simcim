using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmTransparentBridgingService : CIMTransparentBridgingService
    {
        public MsvmTransparentBridgingService()
        {
        }

        public MsvmTransparentBridgingService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public MsvmDynamicForwardingEntry ResolveMsvmTransparentBridgingDynamicForwardingDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_TransparentBridgingDynamicForwarding", "Msvm_DynamicForwardingEntry", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmDynamicForwardingEntry)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}