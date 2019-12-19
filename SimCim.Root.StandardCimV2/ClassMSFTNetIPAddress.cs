using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetIPAddress : CIMIPProtocolEndpoint
    {
        public MSFTNetIPAddress()
        {
        }

        public MSFTNetIPAddress(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AddressFamily
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AddressFamily", out result);
                return result;
            }
        }

        public System.UInt16? AddressState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AddressState", out result);
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

        public System.String IPAddress
        {
            get
            {
                System.String result;
                this.GetProperty("IPAddress", out result);
                return result;
            }
        }

        public System.DateTime? PreferredLifetime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("PreferredLifetime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PreferredLifetime", value);
            }
        }

        public System.UInt16? PrefixOrigin
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PrefixOrigin", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrefixOrigin", value);
            }
        }

        public System.Boolean? SkipAsSource
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SkipAsSource", out result);
                return result;
            }

            set
            {
                this.SetProperty("SkipAsSource", value);
            }
        }

        public System.Byte? Store
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Store", out result);
                return result;
            }
        }

        public System.UInt16? SuffixOrigin
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SuffixOrigin", out result);
                return result;
            }

            set
            {
                this.SetProperty("SuffixOrigin", value);
            }
        }

        public System.Byte? Type
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Type", out result);
                return result;
            }
        }

        public System.DateTime? ValidLifetime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("ValidLifetime", out result);
                return result;
            }

            set
            {
                this.SetProperty("ValidLifetime", value);
            }
        }

        public (System.UInt32 retval, IEnumerable<MSFTNetIPAddress> outCmdletOutput) Create(System.UInt16? inAddressFamily, System.UInt16? inAddressState, System.String inDefaultGateway, System.String inInterfaceAlias, System.UInt32? inInterfaceIndex, System.String inIPAddress, System.Boolean? inPassThru, System.String inPolicyStore, System.DateTime? inPreferredLifetime, System.Byte? inPrefixLength, System.UInt16? inPrefixOrigin, System.Boolean? inSkipAsSource, System.UInt16? inSuffixOrigin, System.Byte? inType, System.DateTime? inValidLifetime)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAddressFamily.HasValue)
                parameters.Add(CimMethodParameter.Create("AddressFamily", inAddressFamily.Value, CimFlags.None));
            if (inAddressState.HasValue)
                parameters.Add(CimMethodParameter.Create("AddressState", inAddressState.Value, CimFlags.None));
            if (inDefaultGateway != null)
                parameters.Add(CimMethodParameter.Create("DefaultGateway", inDefaultGateway, CimType.String, inDefaultGateway == null ? CimFlags.NullValue : CimFlags.None));
            if (inInterfaceAlias != null)
                parameters.Add(CimMethodParameter.Create("InterfaceAlias", inInterfaceAlias, CimType.String, inInterfaceAlias == null ? CimFlags.NullValue : CimFlags.None));
            if (inInterfaceIndex.HasValue)
                parameters.Add(CimMethodParameter.Create("InterfaceIndex", inInterfaceIndex.Value, CimFlags.None));
            if (inIPAddress != null)
                parameters.Add(CimMethodParameter.Create("IPAddress", inIPAddress, CimType.String, inIPAddress == null ? CimFlags.NullValue : CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            if (inPolicyStore != null)
                parameters.Add(CimMethodParameter.Create("PolicyStore", inPolicyStore, CimType.String, inPolicyStore == null ? CimFlags.NullValue : CimFlags.None));
            if (inPreferredLifetime.HasValue)
                parameters.Add(CimMethodParameter.Create("PreferredLifetime", inPreferredLifetime.Value, CimFlags.None));
            if (inPrefixLength.HasValue)
                parameters.Add(CimMethodParameter.Create("PrefixLength", inPrefixLength.Value, CimFlags.None));
            if (inPrefixOrigin.HasValue)
                parameters.Add(CimMethodParameter.Create("PrefixOrigin", inPrefixOrigin.Value, CimFlags.None));
            if (inSkipAsSource.HasValue)
                parameters.Add(CimMethodParameter.Create("SkipAsSource", inSkipAsSource.Value, CimFlags.None));
            if (inSuffixOrigin.HasValue)
                parameters.Add(CimMethodParameter.Create("SuffixOrigin", inSuffixOrigin.Value, CimFlags.None));
            if (inType.HasValue)
                parameters.Add(CimMethodParameter.Create("Type", inType.Value, CimFlags.None));
            if (inValidLifetime.HasValue)
                parameters.Add(CimMethodParameter.Create("ValidLifetime", inValidLifetime.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Create", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<MSFTNetIPAddress>)InfrastuctureObjectScope.Mapper.CreateMany<MSFTNetIPAddress>(InfrastuctureObjectScope, (IEnumerable<CimInstance>)result.OutParameters["CmdletOutput"].Value));
        }
    }
}