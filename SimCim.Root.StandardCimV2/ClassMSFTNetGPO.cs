using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetGPO : CIMSettingData
    {
        public MSFTNetGPO()
        {
        }

        public MSFTNetGPO(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, System.String outGPOSession) Open(System.String inDomainController, System.String inPolicyStore)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDomainController != null)
                parameters.Add(CimMethodParameter.Create("DomainController", inDomainController, CimType.String, inDomainController == null ? CimFlags.NullValue : CimFlags.None));
            if (inPolicyStore != null)
                parameters.Add(CimMethodParameter.Create("PolicyStore", inPolicyStore, CimType.String, inPolicyStore == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Open", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["GPOSession"].Value);
        }

        public System.UInt32 Save(System.String inGPOSession)
        {
            var parameters = new CimMethodParametersCollection();
            if (inGPOSession != null)
                parameters.Add(CimMethodParameter.Create("GPOSession", inGPOSession, CimType.String, inGPOSession == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Save", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}