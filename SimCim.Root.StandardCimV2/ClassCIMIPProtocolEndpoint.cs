using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class CIMIPProtocolEndpoint : CIMProtocolEndpoint
    {
        public CIMIPProtocolEndpoint()
        {
        }

        public CIMIPProtocolEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Address
        {
            get
            {
                System.String result;
                this.GetProperty("Address", out result);
                return result;
            }

            set
            {
                this.SetProperty("Address", value);
            }
        }

        public System.UInt16? AddressOrigin
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AddressOrigin", out result);
                return result;
            }

            set
            {
                this.SetProperty("AddressOrigin", value);
            }
        }

        public System.UInt16? AddressType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AddressType", out result);
                return result;
            }

            set
            {
                this.SetProperty("AddressType", value);
            }
        }

        public System.String IPv4Address
        {
            get
            {
                System.String result;
                this.GetProperty("IPv4Address", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv4Address", value);
            }
        }

        public System.String IPv6Address
        {
            get
            {
                System.String result;
                this.GetProperty("IPv6Address", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv6Address", value);
            }
        }

        public System.UInt16? IPVersionSupport
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("IPVersionSupport", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPVersionSupport", value);
            }
        }

        public System.Byte? PrefixLength
        {
            get
            {
                System.Byte? result;
                this.GetProperty("PrefixLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrefixLength", value);
            }
        }

        public System.String SubnetMask
        {
            get
            {
                System.String result;
                this.GetProperty("SubnetMask", out result);
                return result;
            }

            set
            {
                this.SetProperty("SubnetMask", value);
            }
        }
    }
}