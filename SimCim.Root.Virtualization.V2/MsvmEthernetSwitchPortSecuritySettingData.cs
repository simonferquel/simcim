using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchPortSecuritySettingData : MsvmEthernetSwitchPortFeatureSettingData
    {
        public MsvmEthernetSwitchPortSecuritySettingData()
        {
        }

        public MsvmEthernetSwitchPortSecuritySettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AllowIeeePriorityTag
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AllowIeeePriorityTag", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowIeeePriorityTag", value);
            }
        }

        public System.Boolean? AllowMacSpoofing
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AllowMacSpoofing", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowMacSpoofing", value);
            }
        }

        public System.Boolean? AllowTeaming
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AllowTeaming", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowTeaming", value);
            }
        }

        public System.UInt32? DynamicIPAddressLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DynamicIPAddressLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("DynamicIPAddressLimit", value);
            }
        }

        public System.Boolean? EnableDhcpGuard
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableDhcpGuard", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableDhcpGuard", value);
            }
        }

        public System.Boolean? EnableFixSpeed10G
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableFixSpeed10G", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableFixSpeed10G", value);
            }
        }

        public System.Boolean? EnableRouterGuard
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableRouterGuard", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableRouterGuard", value);
            }
        }

        public System.Byte? MonitorMode
        {
            get
            {
                System.Byte? result;
                this.GetProperty("MonitorMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("MonitorMode", value);
            }
        }

        public System.Byte? MonitorSession
        {
            get
            {
                System.Byte? result;
                this.GetProperty("MonitorSession", out result);
                return result;
            }

            set
            {
                this.SetProperty("MonitorSession", value);
            }
        }

        public System.Boolean? Reserved
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Reserved", out result);
                return result;
            }

            set
            {
                this.SetProperty("Reserved", value);
            }
        }

        public System.UInt32? StormLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StormLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("StormLimit", value);
            }
        }

        public System.String TeamName
        {
            get
            {
                System.String result;
                this.GetProperty("TeamName", out result);
                return result;
            }

            set
            {
                this.SetProperty("TeamName", value);
            }
        }

        public System.UInt32? TeamNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TeamNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("TeamNumber", value);
            }
        }

        public System.UInt32? VirtualSubnetId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VirtualSubnetId", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualSubnetId", value);
            }
        }
    }
}