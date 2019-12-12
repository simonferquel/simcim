using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMProtocolEndpoint : CIMServiceAccessPoint
    {
        protected CIMProtocolEndpoint()
        {
        }

        protected CIMProtocolEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String NameFormat
        {
            get
            {
                System.String result;
                this.GetProperty("NameFormat", out result);
                return result;
            }

            set
            {
                this.SetProperty("NameFormat", value);
            }
        }

        public System.String OtherTypeDescription
        {
            get
            {
                System.String result;
                this.GetProperty("OtherTypeDescription", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherTypeDescription", value);
            }
        }

        public System.UInt16? ProtocolIFType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ProtocolIFType", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProtocolIFType", value);
            }
        }

        public System.UInt16? ProtocolType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ProtocolType", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProtocolType", value);
            }
        }

        public CIMServiceAccessPoint ResolveCIMBindsToDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_BindsTo", "CIM_ServiceAccessPoint", "Antecedent", "Dependent");
            return instances.Select(i => (CIMServiceAccessPoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMForwardingService ResolveCIMForwardsAmongDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ForwardsAmong", "CIM_ForwardingService", "Antecedent", "Dependent");
            return instances.Select(i => (CIMForwardingService)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}