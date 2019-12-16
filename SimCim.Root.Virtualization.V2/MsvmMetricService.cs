using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmMetricService : CIMMetricService
    {
        public MsvmMetricService()
        {
        }

        public MsvmMetricService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ModifyServiceSettings(System.String inSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inSettingData != null)
                parameters.Add(CimMethodParameter.Create("SettingData", inSettingData, CimType.String, inSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyServiceSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }
    }
}