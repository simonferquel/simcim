using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmGuestCommunicationServiceSettingData : CIMSettingData
    {
        public MsvmGuestCommunicationServiceSettingData()
        {
        }

        public MsvmGuestCommunicationServiceSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? EnabledStatePolicy
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EnabledStatePolicy", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnabledStatePolicy", value);
            }
        }

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
                return result;
            }
        }
    }
}