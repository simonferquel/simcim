using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterPowerManagementOffloadNS : MSFTNetAdapterPowerManagementOffload
    {
        public MSFTNetAdapterPowerManagementOffloadNS()
        {
        }

        public MSFTNetAdapterPowerManagementOffloadNS(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String MacAddress
        {
            get
            {
                System.String result;
                this.GetProperty("MacAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("MacAddress", value);
            }
        }

        public System.String RemoteIPv6Address
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteIPv6Address", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteIPv6Address", value);
            }
        }

        public System.String SolicitedNodeIPv6Address
        {
            get
            {
                System.String result;
                this.GetProperty("SolicitedNodeIPv6Address", out result);
                return result;
            }

            set
            {
                this.SetProperty("SolicitedNodeIPv6Address", value);
            }
        }

        public System.String[] TargetIPv6Addresses
        {
            get
            {
                System.String[] result;
                this.GetProperty("TargetIPv6Addresses", out result);
                return result;
            }

            set
            {
                this.SetProperty("TargetIPv6Addresses", value);
            }
        }
    }
}