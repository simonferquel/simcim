using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTDNSClient : CIMDNSProtocolEndpoint
    {
        public MSFTDNSClient()
        {
        }

        public MSFTDNSClient(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ConnectionSpecificSuffix
        {
            get
            {
                System.String result;
                this.GetProperty("ConnectionSpecificSuffix", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectionSpecificSuffix", value);
            }
        }

        public System.String[] ConnectionSpecificSuffixSearchList
        {
            get
            {
                System.String[] result;
                this.GetProperty("ConnectionSpecificSuffixSearchList", out result);
                return result;
            }
        }

        public System.String InterfaceAlias
        {
            get
            {
                System.String result;
                this.GetProperty("InterfaceAlias", out result);
                return result;
            }
        }

        public System.UInt32? InterfaceIndex
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterfaceIndex", out result);
                return result;
            }
        }

        public System.Boolean? RegisterThisConnectionsAddress
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RegisterThisConnectionsAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("RegisterThisConnectionsAddress", value);
            }
        }

        public System.Boolean? UseSuffixWhenRegistering
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("UseSuffixWhenRegistering", out result);
                return result;
            }

            set
            {
                this.SetProperty("UseSuffixWhenRegistering", value);
            }
        }

        public System.UInt32 Register()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Register", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}