using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmFcEndpoint : CIMProtocolEndpoint
    {
        public MsvmFcEndpoint()
        {
        }

        public MsvmFcEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.String WWNN
        {
            get
            {
                System.String result;
                this.GetProperty("WWNN", out result);
                return result;
            }
        }

        public System.String WWPN
        {
            get
            {
                System.String result;
                this.GetProperty("WWPN", out result);
                return result;
            }
        }

        public MsvmFcEndpoint ResolveMsvmFcActiveConnectionDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_FcActiveConnection", "Msvm_FcEndpoint", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmFcEndpoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public MsvmFcEndpoint ResolveMsvmFcActiveConnectionAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_FcActiveConnection", "Msvm_FcEndpoint", "Dependent", "Antecedent");
            return instances.Select(i => (MsvmFcEndpoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMFCPort ResolveMsvmFcDeviceSAPImplementationAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_FcDeviceSAPImplementation", "CIM_FCPort", "Dependent", "Antecedent");
            return instances.Select(i => (CIMFCPort)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}