using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetNatExternalAddress : MSFTNetSettingData
    {
        public MSFTNetNatExternalAddress()
        {
        }

        public MSFTNetNatExternalAddress(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt32? ExternalAddressID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExternalAddressID", out result);
                return result;
            }
        }

        public System.String IPAddress
        {
            get
            {
                System.String result;
                this.GetProperty("IPAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPAddress", value);
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

        public System.UInt16? PortEnd
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PortEnd", out result);
                return result;
            }

            set
            {
                this.SetProperty("PortEnd", value);
            }
        }

        public System.UInt16? PortStart
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PortStart", out result);
                return result;
            }

            set
            {
                this.SetProperty("PortStart", value);
            }
        }
    }
}