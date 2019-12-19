using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetMainModeRule : MSFTNetSARule
    {
        public MSFTNetMainModeRule()
        {
        }

        public MSFTNetMainModeRule(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32 Enable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Disable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Rename(System.String inNewName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNewName != null)
                parameters.Add(CimMethodParameter.Create("NewName", inNewName, CimType.String, inNewName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Rename", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 CloneObject(System.String inNewGPOSession, System.String inNewName, System.String inNewPolicyStore)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNewGPOSession != null)
                parameters.Add(CimMethodParameter.Create("NewGPOSession", inNewGPOSession, CimType.String, inNewGPOSession == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewName != null)
                parameters.Add(CimMethodParameter.Create("NewName", inNewName, CimType.String, inNewName == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewPolicyStore != null)
                parameters.Add(CimMethodParameter.Create("NewPolicyStore", inNewPolicyStore, CimType.String, inNewPolicyStore == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CloneObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}