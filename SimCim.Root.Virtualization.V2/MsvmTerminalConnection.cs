using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmTerminalConnection : CIMEnabledLogicalElement
    {
        public MsvmTerminalConnection()
        {
        }

        public MsvmTerminalConnection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ConnectionID
        {
            get
            {
                System.String result;
                this.GetProperty("ConnectionID", out result);
                return result;
            }
        }

        public MsvmComputerSystem ResolveMsvmSystemTerminalConnectionAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SystemTerminalConnection", "Msvm_ComputerSystem", "Dependent", "Antecedent");
            return instances.Select(i => (MsvmComputerSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}