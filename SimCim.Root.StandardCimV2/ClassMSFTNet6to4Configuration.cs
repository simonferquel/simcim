using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNet6to4Configuration : MSFTNetSettingData
    {
        public MSFTNet6to4Configuration()
        {
        }

        public MSFTNet6to4Configuration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AutoSharing
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AutoSharing", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutoSharing", value);
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

        public System.String RelayName
        {
            get
            {
                System.String result;
                this.GetProperty("RelayName", out result);
                return result;
            }

            set
            {
                this.SetProperty("RelayName", value);
            }
        }

        public System.UInt32? RelayState
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RelayState", out result);
                return result;
            }

            set
            {
                this.SetProperty("RelayState", value);
            }
        }

        public System.UInt32? ResolutionInterval
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ResolutionInterval", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResolutionInterval", value);
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

        public (System.UInt32 retval, MSFTNet6to4Configuration outOutputObject) Reset(System.Boolean? inAutoSharing, System.Boolean? inPassThru, System.Boolean? inRelayName, System.Boolean? inRelayState, System.Boolean? inResolutionInterval, System.Boolean? inState)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAutoSharing.HasValue)
                parameters.Add(CimMethodParameter.Create("AutoSharing", inAutoSharing.Value, CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            if (inRelayName.HasValue)
                parameters.Add(CimMethodParameter.Create("RelayName", inRelayName.Value, CimFlags.None));
            if (inRelayState.HasValue)
                parameters.Add(CimMethodParameter.Create("RelayState", inRelayState.Value, CimFlags.None));
            if (inResolutionInterval.HasValue)
                parameters.Add(CimMethodParameter.Create("ResolutionInterval", inResolutionInterval.Value, CimFlags.None));
            if (inState.HasValue)
                parameters.Add(CimMethodParameter.Create("State", inState.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Reset", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNet6to4Configuration)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["OutputObject"].Value));
        }
    }
}