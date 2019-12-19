using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetSecDeltaCollection : CIMSettingData
    {
        public MSFTNetSecDeltaCollection()
        {
        }

        public MSFTNetSecDeltaCollection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Action
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Action", out result);
                return result;
            }

            set
            {
                this.SetProperty("Action", value);
            }
        }

        public System.UInt16? EndpointType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EndpointType", out result);
                return result;
            }

            set
            {
                this.SetProperty("EndpointType", value);
            }
        }

        public System.String IPsecRuleDisplayName
        {
            get
            {
                System.String result;
                this.GetProperty("IPsecRuleDisplayName", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPsecRuleDisplayName", value);
            }
        }

        public System.String IPsecRuleName
        {
            get
            {
                System.String result;
                this.GetProperty("IPsecRuleName", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPsecRuleName", value);
            }
        }

        public System.String[] IPv4Addresses
        {
            get
            {
                System.String[] result;
                this.GetProperty("IPv4Addresses", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv4Addresses", value);
            }
        }

        public System.String[] IPv6Addresses
        {
            get
            {
                System.String[] result;
                this.GetProperty("IPv6Addresses", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv6Addresses", value);
            }
        }

        public System.String[] NameResolutionFailures
        {
            get
            {
                System.String[] result;
                this.GetProperty("NameResolutionFailures", out result);
                return result;
            }

            set
            {
                this.SetProperty("NameResolutionFailures", value);
            }
        }

        public System.String PolicyStore
        {
            get
            {
                System.String result;
                this.GetProperty("PolicyStore", out result);
                return result;
            }

            set
            {
                this.SetProperty("PolicyStore", value);
            }
        }
    }
}