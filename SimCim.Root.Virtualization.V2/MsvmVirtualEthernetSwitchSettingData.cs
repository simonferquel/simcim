using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualEthernetSwitchSettingData : CIMVirtualEthernetSwitchSettingData
    {
        public MsvmVirtualEthernetSwitchSettingData()
        {
        }

        public MsvmVirtualEthernetSwitchSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BandwidthReservationMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BandwidthReservationMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("BandwidthReservationMode", value);
            }
        }

        public System.String[] ExtensionOrder
        {
            get
            {
                System.String[] result;
                this.GetProperty("ExtensionOrder", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExtensionOrder", value);
            }
        }

        public System.Boolean? IOVPreferred
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IOVPreferred", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOVPreferred", value);
            }
        }

        public System.Boolean? PacketDirectEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PacketDirectEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketDirectEnabled", value);
            }
        }

        public System.Boolean? TeamingEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TeamingEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("TeamingEnabled", value);
            }
        }

        public IEnumerable<MsvmEthernetSwitchFeatureSettingData> ResolveMsvmVirtualEthernetSwitchSettingDataComponentPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_VirtualEthernetSwitchSettingDataComponent", "Msvm_EthernetSwitchFeatureSettingData", "GroupComponent", "PartComponent");
            return instances.Select(i => (MsvmEthernetSwitchFeatureSettingData)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}