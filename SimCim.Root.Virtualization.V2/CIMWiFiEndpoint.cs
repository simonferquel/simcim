using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMWiFiEndpoint : CIMLANEndpoint
    {
        protected CIMWiFiEndpoint()
        {
        }

        protected CIMWiFiEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AccessPointAddress
        {
            get
            {
                System.String result;
                this.GetProperty("AccessPointAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("AccessPointAddress", value);
            }
        }

        public System.Boolean? Associated
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Associated", out result);
                return result;
            }

            set
            {
                this.SetProperty("Associated", value);
            }
        }

        public System.UInt16? AuthenticationMethod
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AuthenticationMethod", out result);
                return result;
            }

            set
            {
                this.SetProperty("AuthenticationMethod", value);
            }
        }

        public System.UInt16? BSSType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("BSSType", out result);
                return result;
            }

            set
            {
                this.SetProperty("BSSType", value);
            }
        }

        public System.UInt16? EncryptionMethod
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EncryptionMethod", out result);
                return result;
            }

            set
            {
                this.SetProperty("EncryptionMethod", value);
            }
        }

        public System.UInt16? IEEE8021xAuthenticationProtocol
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("IEEE8021xAuthenticationProtocol", out result);
                return result;
            }

            set
            {
                this.SetProperty("IEEE8021xAuthenticationProtocol", value);
            }
        }

        public System.String OtherAuthenticationMethod
        {
            get
            {
                System.String result;
                this.GetProperty("OtherAuthenticationMethod", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherAuthenticationMethod", value);
            }
        }

        public System.String OtherEncryptionMethod
        {
            get
            {
                System.String result;
                this.GetProperty("OtherEncryptionMethod", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherEncryptionMethod", value);
            }
        }
    }
}