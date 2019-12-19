using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetNatStaticMapping : MSFTNetSettingData
    {
        public MSFTNetNatStaticMapping()
        {
        }

        public MSFTNetNatStaticMapping(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? Active
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Active", out result);
                return result;
            }
        }

        public System.String ExternalIPAddress
        {
            get
            {
                System.String result;
                this.GetProperty("ExternalIPAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExternalIPAddress", value);
            }
        }

        public System.UInt16? ExternalPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ExternalPort", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExternalPort", value);
            }
        }

        public System.String InternalIPAddress
        {
            get
            {
                System.String result;
                this.GetProperty("InternalIPAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("InternalIPAddress", value);
            }
        }

        public System.UInt16? InternalPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("InternalPort", out result);
                return result;
            }

            set
            {
                this.SetProperty("InternalPort", value);
            }
        }

        public System.String InternalRoutingDomainId
        {
            get
            {
                System.String result;
                this.GetProperty("InternalRoutingDomainId", out result);
                return result;
            }

            set
            {
                this.SetProperty("InternalRoutingDomainId", value);
            }
        }

        public System.String NatName
        {
            get
            {
                System.String result;
                this.GetProperty("NatName", out result);
                return result;
            }
        }

        public System.UInt32? Protocol
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Protocol", out result);
                return result;
            }
        }

        public System.String RemoteExternalIPAddressPrefix
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteExternalIPAddressPrefix", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteExternalIPAddressPrefix", value);
            }
        }

        public System.UInt32? StaticMappingID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StaticMappingID", out result);
                return result;
            }
        }
    }
}