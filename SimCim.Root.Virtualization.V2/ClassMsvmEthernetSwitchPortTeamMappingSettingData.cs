using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchPortTeamMappingSettingData : MsvmEthernetSwitchPortFeatureSettingData
    {
        public MsvmEthernetSwitchPortTeamMappingSettingData()
        {
        }

        public MsvmEthernetSwitchPortTeamMappingSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? DisableOnFailover
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DisableOnFailover", out result);
                return result;
            }

            set
            {
                this.SetProperty("DisableOnFailover", value);
            }
        }

        public System.String NetAdapterDeviceId
        {
            get
            {
                System.String result;
                this.GetProperty("NetAdapterDeviceId", out result);
                return result;
            }

            set
            {
                this.SetProperty("NetAdapterDeviceId", value);
            }
        }

        public System.String NetAdapterName
        {
            get
            {
                System.String result;
                this.GetProperty("NetAdapterName", out result);
                return result;
            }

            set
            {
                this.SetProperty("NetAdapterName", value);
            }
        }
    }
}