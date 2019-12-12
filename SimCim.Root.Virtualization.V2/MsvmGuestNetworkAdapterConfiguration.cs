using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmGuestNetworkAdapterConfiguration : GenericInfrastructureObject
    {
        public MsvmGuestNetworkAdapterConfiguration()
        {
        }

        public MsvmGuestNetworkAdapterConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] DefaultGateways
        {
            get
            {
                System.String[] result;
                this.GetProperty("DefaultGateways", out result);
                return result;
            }
        }

        public System.Boolean? DHCPEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DHCPEnabled", out result);
                return result;
            }
        }

        public System.String[] DNSServers
        {
            get
            {
                System.String[] result;
                this.GetProperty("DNSServers", out result);
                return result;
            }
        }

        public System.String InstanceID
        {
            get
            {
                System.String result;
                this.GetProperty("InstanceID", out result);
                return result;
            }
        }

        public System.String[] IPAddresses
        {
            get
            {
                System.String[] result;
                this.GetProperty("IPAddresses", out result);
                return result;
            }
        }

        public System.UInt16[] IPAddressOrigins
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("IPAddressOrigins", out result);
                return result;
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
        }

        public System.String[] Subnets
        {
            get
            {
                System.String[] result;
                this.GetProperty("Subnets", out result);
                return result;
            }
        }

        public CIMResourceAllocationSettingData ResolveMsvmSettingDataComponentGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SettingDataComponent", "CIM_ResourceAllocationSettingData", "PartComponent", "GroupComponent");
            return instances.Select(i => (CIMResourceAllocationSettingData)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}