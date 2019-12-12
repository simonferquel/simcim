using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmWiFiPort : CIMWiFiPort
    {
        public MsvmWiFiPort()
        {
        }

        public MsvmWiFiPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public MsvmWiFiEndpoint ResolveMsvmWiFiDeviceSAPImplementationDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_WiFiDeviceSAPImplementation", "Msvm_WiFiEndpoint", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmWiFiEndpoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}