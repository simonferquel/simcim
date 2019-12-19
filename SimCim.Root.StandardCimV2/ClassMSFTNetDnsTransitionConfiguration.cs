using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetDnsTransitionConfiguration : MSFTNetSettingData
    {
        public MSFTNetDnsTransitionConfiguration()
        {
        }

        public MSFTNetDnsTransitionConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] AcceptInterface
        {
            get
            {
                System.String[] result;
                this.GetProperty("AcceptInterface", out result);
                return result;
            }

            set
            {
                this.SetProperty("AcceptInterface", value);
            }
        }

        public System.Boolean? AlwaysSynthesize
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AlwaysSynthesize", out result);
                return result;
            }

            set
            {
                this.SetProperty("AlwaysSynthesize", value);
            }
        }

        public System.String[] ExclusionList
        {
            get
            {
                System.String[] result;
                this.GetProperty("ExclusionList", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExclusionList", value);
            }
        }

        public System.UInt32? Latency
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Latency", out result);
                return result;
            }

            set
            {
                this.SetProperty("Latency", value);
            }
        }

        public System.Boolean? OnlySendAQuery
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OnlySendAQuery", out result);
                return result;
            }

            set
            {
                this.SetProperty("OnlySendAQuery", value);
            }
        }

        public System.String[] PrefixMapping
        {
            get
            {
                System.String[] result;
                this.GetProperty("PrefixMapping", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrefixMapping", value);
            }
        }

        public System.String[] SendInterface
        {
            get
            {
                System.String[] result;
                this.GetProperty("SendInterface", out result);
                return result;
            }

            set
            {
                this.SetProperty("SendInterface", value);
            }
        }

        public System.UInt32? State
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("State", out result);
                return result;
            }

            set
            {
                this.SetProperty("State", value);
            }
        }

        public (System.UInt32 retval, MSFTNetDnsTransitionConfiguration outOutputObject) Enable(System.Boolean? inPassThru)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetDnsTransitionConfiguration)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["OutputObject"].Value));
        }

        public (System.UInt32 retval, MSFTNetDnsTransitionConfiguration outOutputObject) Disable(System.Boolean? inPassThru)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetDnsTransitionConfiguration)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["OutputObject"].Value));
        }

        public (System.UInt32 retval, MSFTNetDnsTransitionConfiguration outOutputObject) Reset(System.Boolean? inAcceptInterface, System.Boolean? inAlwaysSynthesize, System.Boolean? inExclusionList, System.Boolean? inLatency, System.Boolean? inOnlySendAQuery, System.Boolean? inPassThru, System.Boolean? inPrefixMapping, System.Boolean? inSendInterface, System.Boolean? inState)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAcceptInterface.HasValue)
                parameters.Add(CimMethodParameter.Create("AcceptInterface", inAcceptInterface.Value, CimFlags.None));
            if (inAlwaysSynthesize.HasValue)
                parameters.Add(CimMethodParameter.Create("AlwaysSynthesize", inAlwaysSynthesize.Value, CimFlags.None));
            if (inExclusionList.HasValue)
                parameters.Add(CimMethodParameter.Create("ExclusionList", inExclusionList.Value, CimFlags.None));
            if (inLatency.HasValue)
                parameters.Add(CimMethodParameter.Create("Latency", inLatency.Value, CimFlags.None));
            if (inOnlySendAQuery.HasValue)
                parameters.Add(CimMethodParameter.Create("OnlySendAQuery", inOnlySendAQuery.Value, CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            if (inPrefixMapping.HasValue)
                parameters.Add(CimMethodParameter.Create("PrefixMapping", inPrefixMapping.Value, CimFlags.None));
            if (inSendInterface.HasValue)
                parameters.Add(CimMethodParameter.Create("SendInterface", inSendInterface.Value, CimFlags.None));
            if (inState.HasValue)
                parameters.Add(CimMethodParameter.Create("State", inState.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Reset", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetDnsTransitionConfiguration)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["OutputObject"].Value));
        }
    }
}