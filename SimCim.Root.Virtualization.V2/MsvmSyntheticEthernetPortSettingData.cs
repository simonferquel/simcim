using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSyntheticEthernetPortSettingData : CIMEthernetPortAllocationSettingData
    {
        public MsvmSyntheticEthernetPortSettingData()
        {
        }

        public MsvmSyntheticEthernetPortSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AllowPacketDirect
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AllowPacketDirect", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowPacketDirect", value);
            }
        }

        public System.Boolean? ClusterMonitored
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ClusterMonitored", out result);
                return result;
            }
        }

        public System.Boolean? DeviceNamingEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DeviceNamingEnabled", out result);
                return result;
            }
        }

        public System.Boolean? InterruptModeration
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("InterruptModeration", out result);
                return result;
            }
        }

        public System.UInt32? MediaType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MediaType", out result);
                return result;
            }
        }

        public System.Boolean? NumaAwarePlacement
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NumaAwarePlacement", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumaAwarePlacement", value);
            }
        }

        public System.Boolean? StaticMacAddress
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("StaticMacAddress", out result);
                return result;
            }
        }

        public System.String[] VirtualSystemIdentifiers
        {
            get
            {
                System.String[] result;
                this.GetProperty("VirtualSystemIdentifiers", out result);
                return result;
            }
        }
    }
}