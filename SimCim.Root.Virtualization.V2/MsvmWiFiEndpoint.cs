using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmWiFiEndpoint : CIMWiFiEndpoint
    {
        public MsvmWiFiEndpoint()
        {
        }

        public MsvmWiFiEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Connected
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Connected", out result);
                return result;
            }
        }

        public MsvmWiFiPort ResolveMsvmWiFiDeviceSAPImplementationAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_WiFiDeviceSAPImplementation", "Msvm_WiFiPort", "Dependent", "Antecedent");
            return instances.Select(i => (MsvmWiFiPort)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}