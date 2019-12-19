using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterPowerManagementOffloadArp : MSFTNetAdapterPowerManagementOffload
    {
        public MSFTNetAdapterPowerManagementOffloadArp()
        {
        }

        public MSFTNetAdapterPowerManagementOffloadArp(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String HostIPv4Address
        {
            get
            {
                System.String result;
                this.GetProperty("HostIPv4Address", out result);
                return result;
            }

            set
            {
                this.SetProperty("HostIPv4Address", value);
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

        public System.String RemoteIPv4Address
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteIPv4Address", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteIPv4Address", value);
            }
        }
    }
}