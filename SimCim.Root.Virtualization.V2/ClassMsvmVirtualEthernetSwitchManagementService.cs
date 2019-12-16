using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualEthernetSwitchManagementService : CIMVirtualSystemManagementService
    {
        public MsvmVirtualEthernetSwitchManagementService()
        {
        }

        public MsvmVirtualEthernetSwitchManagementService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, IEnumerable<MsvmFeatureSettingData> outResultingFeatureSettings) AddFeatureSettings(CIMSettingData inAffectedConfiguration, System.String[] inFeatureSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedConfiguration != null)
                parameters.Add(CimMethodParameter.Create("AffectedConfiguration", inAffectedConfiguration.AsCimInstance(), CimType.Reference, inAffectedConfiguration == null ? CimFlags.NullValue : CimFlags.None));
            if (inFeatureSettings != null)
                parameters.Add(CimMethodParameter.Create("FeatureSettings", inFeatureSettings, CimType.StringArray, inFeatureSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddFeatureSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value), (IEnumerable<MsvmFeatureSettingData>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ResultingFeatureSettings"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, IEnumerable<MsvmFeatureSettingData> outResultingFeatureSettings) ModifyFeatureSettings(System.String[] inFeatureSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFeatureSettings != null)
                parameters.Add(CimMethodParameter.Create("FeatureSettings", inFeatureSettings, CimType.StringArray, inFeatureSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyFeatureSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value), (IEnumerable<MsvmFeatureSettingData>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ResultingFeatureSettings"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveFeatureSettings(IEnumerable<MsvmFeatureSettingData> inFeatureSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFeatureSettings != null)
                parameters.Add(CimMethodParameter.Create("FeatureSettings", inFeatureSettings.AsCimInstance(), CimType.ReferenceArray, inFeatureSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveFeatureSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }
    }
}