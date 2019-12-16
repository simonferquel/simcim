using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmTerminalService : CIMService
    {
        public MsvmTerminalService()
        {
        }

        public MsvmTerminalService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ModifyServiceSettings(System.String inServiceSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inServiceSettingData != null)
                parameters.Add(CimMethodParameter.Create("ServiceSettingData", inServiceSettingData, CimType.String, inServiceSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyServiceSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) GrantInteractiveSessionAccess(CIMComputerSystem inComputerSystem, System.String[] inTrustees)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerSystem != null)
                parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), CimType.Reference, inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inTrustees != null)
                parameters.Add(CimMethodParameter.Create("Trustees", inTrustees, CimType.StringArray, inTrustees == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GrantInteractiveSessionAccess", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RevokeInteractiveSessionAccess(CIMComputerSystem inComputerSystem, System.String[] inTrustees)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerSystem != null)
                parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), CimType.Reference, inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inTrustees != null)
                parameters.Add(CimMethodParameter.Create("Trustees", inTrustees, CimType.StringArray, inTrustees == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RevokeInteractiveSessionAccess", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, System.String[] outAccessControlList) GetInteractiveSessionACL(CIMComputerSystem inComputerSystem)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerSystem != null)
                parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), CimType.Reference, inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetInteractiveSessionACL", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String[])result.OutParameters["AccessControlList"].Value);
        }
    }
}