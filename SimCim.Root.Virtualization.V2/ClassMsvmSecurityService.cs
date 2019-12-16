using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSecurityService : CIMService
    {
        public MsvmSecurityService()
        {
        }

        public MsvmSecurityService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ModifySecuritySettings(System.String inSecuritySettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inSecuritySettingData != null)
                parameters.Add(CimMethodParameter.Create("SecuritySettingData", inSecuritySettingData, CimType.String, inSecuritySettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifySecuritySettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) SetSecurityPolicy(System.Byte[] inSecurityPolicy, System.String inSecuritySettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inSecurityPolicy != null)
                parameters.Add(CimMethodParameter.Create("SecurityPolicy", inSecurityPolicy, CimType.UInt8Array, inSecurityPolicy == null ? CimFlags.NullValue : CimFlags.None));
            if (inSecuritySettingData != null)
                parameters.Add(CimMethodParameter.Create("SecuritySettingData", inSecuritySettingData, CimType.String, inSecuritySettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetSecurityPolicy", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) SetKeyProtector(System.Byte[] inKeyProtector, System.String inSecuritySettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inKeyProtector != null)
                parameters.Add(CimMethodParameter.Create("KeyProtector", inKeyProtector, CimType.UInt8Array, inKeyProtector == null ? CimFlags.NullValue : CimFlags.None));
            if (inSecuritySettingData != null)
                parameters.Add(CimMethodParameter.Create("SecuritySettingData", inSecuritySettingData, CimType.String, inSecuritySettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetKeyProtector", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, System.Byte[] outKeyProtector) GetKeyProtector(System.String inSecuritySettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inSecuritySettingData != null)
                parameters.Add(CimMethodParameter.Create("SecuritySettingData", inSecuritySettingData, CimType.String, inSecuritySettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetKeyProtector", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Byte[])result.OutParameters["KeyProtector"].Value);
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RestoreLastKnownGoodKeyProtector(System.String inSecuritySettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inSecuritySettingData != null)
                parameters.Add(CimMethodParameter.Create("SecuritySettingData", inSecuritySettingData, CimType.String, inSecuritySettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RestoreLastKnownGoodKeyProtector", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }
    }
}