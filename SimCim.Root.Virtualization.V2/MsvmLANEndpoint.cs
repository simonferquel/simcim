using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmLANEndpoint : CIMLANEndpoint
    {
        public MsvmLANEndpoint()
        {
        }

        public MsvmLANEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public CIMLANEndpoint ResolveMsvmActiveConnectionDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ActiveConnection", "CIM_LANEndpoint", "Antecedent", "Dependent");
            return instances.Select(i => (CIMLANEndpoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public MsvmVLANEndpoint ResolveMsvmBindsToLANEndpointDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_BindsToLANEndpoint", "Msvm_VLANEndpoint", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmVLANEndpoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMEthernetPort ResolveMsvmEthernetDeviceSAPImplementationAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_EthernetDeviceSAPImplementation", "CIM_EthernetPort", "Dependent", "Antecedent");
            return instances.Select(i => (CIMEthernetPort)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}