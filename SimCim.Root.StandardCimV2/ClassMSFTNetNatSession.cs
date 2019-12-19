using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetNatSession : MSFTNetSettingData
    {
        public MSFTNetNatSession()
        {
        }

        public MSFTNetNatSession(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.DateTime? CreationTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("CreationTime", out result);
                return result;
            }
        }

        public System.String ExternalDestinationAddress
        {
            get
            {
                System.String result;
                this.GetProperty("ExternalDestinationAddress", out result);
                return result;
            }
        }

        public System.UInt16? ExternalDestinationPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ExternalDestinationPort", out result);
                return result;
            }
        }

        public System.String ExternalSourceAddress
        {
            get
            {
                System.String result;
                this.GetProperty("ExternalSourceAddress", out result);
                return result;
            }
        }

        public System.UInt16? ExternalSourcePort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ExternalSourcePort", out result);
                return result;
            }
        }

        public System.String InternalDestinationAddress
        {
            get
            {
                System.String result;
                this.GetProperty("InternalDestinationAddress", out result);
                return result;
            }
        }

        public System.UInt16? InternalDestinationPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("InternalDestinationPort", out result);
                return result;
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
        }

        public System.String InternalSourceAddress
        {
            get
            {
                System.String result;
                this.GetProperty("InternalSourceAddress", out result);
                return result;
            }
        }

        public System.UInt16? InternalSourcePort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("InternalSourcePort", out result);
                return result;
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
    }
}