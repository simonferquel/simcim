using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMLANEndpoint : CIMProtocolEndpoint
    {
        protected CIMLANEndpoint()
        {
        }

        protected CIMLANEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] AliasAddresses
        {
            get
            {
                System.String[] result;
                this.GetProperty("AliasAddresses", out result);
                return result;
            }

            set
            {
                this.SetProperty("AliasAddresses", value);
            }
        }

        public System.String[] GroupAddresses
        {
            get
            {
                System.String[] result;
                this.GetProperty("GroupAddresses", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupAddresses", value);
            }
        }

        public System.String LANID
        {
            get
            {
                System.String result;
                this.GetProperty("LANID", out result);
                return result;
            }

            set
            {
                this.SetProperty("LANID", value);
            }
        }

        public System.UInt16? LANType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LANType", out result);
                return result;
            }

            set
            {
                this.SetProperty("LANType", value);
            }
        }

        public System.String MACAddress
        {
            get
            {
                System.String result;
                this.GetProperty("MACAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("MACAddress", value);
            }
        }

        public System.UInt32? MaxDataSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxDataSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxDataSize", value);
            }
        }

        public System.String OtherLANType
        {
            get
            {
                System.String result;
                this.GetProperty("OtherLANType", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherLANType", value);
            }
        }

        public MsvmLANEndpoint ResolveMsvmActiveConnectionAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ActiveConnection", "Msvm_LANEndpoint", "Dependent", "Antecedent");
            return instances.Select(i => (MsvmLANEndpoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMServiceAccessPoint ResolveCIMBindsToLANEndpointDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_BindsToLANEndpoint", "CIM_ServiceAccessPoint", "Antecedent", "Dependent");
            return instances.Select(i => (CIMServiceAccessPoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}