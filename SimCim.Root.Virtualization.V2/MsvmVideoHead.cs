using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVideoHead : CIMVideoHead
    {
        public MsvmVideoHead()
        {
        }

        public MsvmVideoHead(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public IEnumerable<CIMDisplayController> ResolveMsvmVideoHeadOnControllerAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_VideoHeadOnController", "CIM_DisplayController", "Dependent", "Antecedent");
            return instances.Select(i => (CIMDisplayController)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}