using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetISATAPConfiguration : MSFTNetSettingData
    {
        public MSFTNetISATAPConfiguration()
        {
        }

        public MSFTNetISATAPConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.UInt32? ResolutionState
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ResolutionState", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResolutionState", value);
            }
        }

        public System.String Router
        {
            get
            {
                System.String result;
                this.GetProperty("Router", out result);
                return result;
            }

            set
            {
                this.SetProperty("Router", value);
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

        public (System.UInt32 retval, MSFTNetISATAPConfiguration outOutputObject) Reset(System.Boolean? inPassThru, System.Boolean? inResolutionInterval, System.Boolean? inResolutionState, System.Boolean? inRouter, System.Boolean? inState)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            if (inResolutionInterval.HasValue)
                parameters.Add(CimMethodParameter.Create("ResolutionInterval", inResolutionInterval.Value, CimFlags.None));
            if (inResolutionState.HasValue)
                parameters.Add(CimMethodParameter.Create("ResolutionState", inResolutionState.Value, CimFlags.None));
            if (inRouter.HasValue)
                parameters.Add(CimMethodParameter.Create("Router", inRouter.Value, CimFlags.None));
            if (inState.HasValue)
                parameters.Add(CimMethodParameter.Create("State", inState.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Reset", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetISATAPConfiguration)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["OutputObject"].Value));
        }
    }
}