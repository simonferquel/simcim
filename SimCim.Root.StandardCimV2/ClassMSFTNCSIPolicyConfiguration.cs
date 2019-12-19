using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNCSIPolicyConfiguration : MSFTNetSettingData
    {
        public MSFTNCSIPolicyConfiguration()
        {
        }

        public MSFTNCSIPolicyConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CorporateDNSProbeHostAddress
        {
            get
            {
                System.String result;
                this.GetProperty("CorporateDNSProbeHostAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("CorporateDNSProbeHostAddress", value);
            }
        }

        public System.String CorporateDNSProbeHostName
        {
            get
            {
                System.String result;
                this.GetProperty("CorporateDNSProbeHostName", out result);
                return result;
            }

            set
            {
                this.SetProperty("CorporateDNSProbeHostName", value);
            }
        }

        public System.String[] CorporateSitePrefixList
        {
            get
            {
                System.String[] result;
                this.GetProperty("CorporateSitePrefixList", out result);
                return result;
            }

            set
            {
                this.SetProperty("CorporateSitePrefixList", value);
            }
        }

        public System.String CorporateWebsiteProbeURL
        {
            get
            {
                System.String result;
                this.GetProperty("CorporateWebsiteProbeURL", out result);
                return result;
            }

            set
            {
                this.SetProperty("CorporateWebsiteProbeURL", value);
            }
        }

        public System.String DomainLocationDeterminationURL
        {
            get
            {
                System.String result;
                this.GetProperty("DomainLocationDeterminationURL", out result);
                return result;
            }

            set
            {
                this.SetProperty("DomainLocationDeterminationURL", value);
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
        }

        public (System.UInt32 retval, MSFTNCSIPolicyConfiguration outOutputObject) Reset(System.Boolean? inCorporateDNSProbeHostAddress, System.Boolean? inCorporateDNSProbeHostName, System.Boolean? inCorporateSitePrefixList, System.Boolean? inCorporateWebsiteProbeURL, System.Boolean? inDomainLocationDeterminationURL, System.Boolean? inPassThru)
        {
            var parameters = new CimMethodParametersCollection();
            if (inCorporateDNSProbeHostAddress.HasValue)
                parameters.Add(CimMethodParameter.Create("CorporateDNSProbeHostAddress", inCorporateDNSProbeHostAddress.Value, CimFlags.None));
            if (inCorporateDNSProbeHostName.HasValue)
                parameters.Add(CimMethodParameter.Create("CorporateDNSProbeHostName", inCorporateDNSProbeHostName.Value, CimFlags.None));
            if (inCorporateSitePrefixList.HasValue)
                parameters.Add(CimMethodParameter.Create("CorporateSitePrefixList", inCorporateSitePrefixList.Value, CimFlags.None));
            if (inCorporateWebsiteProbeURL.HasValue)
                parameters.Add(CimMethodParameter.Create("CorporateWebsiteProbeURL", inCorporateWebsiteProbeURL.Value, CimFlags.None));
            if (inDomainLocationDeterminationURL.HasValue)
                parameters.Add(CimMethodParameter.Create("DomainLocationDeterminationURL", inDomainLocationDeterminationURL.Value, CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Reset", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNCSIPolicyConfiguration)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["OutputObject"].Value));
        }
    }
}