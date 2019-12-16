using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMEthernetPortAllocationSettingData : CIMResourceAllocationSettingData
    {
        protected CIMEthernetPortAllocationSettingData()
        {
        }

        protected CIMEthernetPortAllocationSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? DesiredVLANEndpointMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DesiredVLANEndpointMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("DesiredVLANEndpointMode", value);
            }
        }

        public System.String OtherEndpointMode
        {
            get
            {
                System.String result;
                this.GetProperty("OtherEndpointMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherEndpointMode", value);
            }
        }
    }
}