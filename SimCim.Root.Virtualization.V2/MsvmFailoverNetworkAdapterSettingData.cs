using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmFailoverNetworkAdapterSettingData : CIMSettingData
    {
        public MsvmFailoverNetworkAdapterSettingData()
        {
        }

        public MsvmFailoverNetworkAdapterSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.String[] IPAddresses
        {
            get
            {
                System.String[] result;
                this.GetProperty("IPAddresses", out result);
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

        public CIMResourceAllocationSettingData ResolveMsvmEthernetPortFailoverSettingDataComponentGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_EthernetPortFailoverSettingDataComponent", "CIM_ResourceAllocationSettingData", "PartComponent", "GroupComponent");
            return instances.Select(i => (CIMResourceAllocationSettingData)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}