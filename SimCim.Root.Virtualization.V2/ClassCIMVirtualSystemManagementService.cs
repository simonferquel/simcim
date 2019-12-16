using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMVirtualSystemManagementService : CIMService
    {
        protected CIMVirtualSystemManagementService()
        {
        }

        protected CIMVirtualSystemManagementService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, IEnumerable<CIMResourceAllocationSettingData> outResultingResourceSettings) AddResourceSettings(CIMVirtualSystemSettingData inAffectedConfiguration, System.String[] inResourceSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedConfiguration != null)
                parameters.Add(CimMethodParameter.Create("AffectedConfiguration", inAffectedConfiguration.AsCimInstance(), CimType.Reference, inAffectedConfiguration == null ? CimFlags.NullValue : CimFlags.None));
            if (inResourceSettings != null)
                parameters.Add(CimMethodParameter.Create("ResourceSettings", inResourceSettings, CimType.StringArray, inResourceSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddResourceSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value), (IEnumerable<CIMResourceAllocationSettingData>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ResultingResourceSettings"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, CIMComputerSystem outResultingSystem) DefineSystem(CIMVirtualSystemSettingData inReferenceConfiguration, System.String[] inResourceSettings, System.String inSystemSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inReferenceConfiguration != null)
                parameters.Add(CimMethodParameter.Create("ReferenceConfiguration", inReferenceConfiguration.AsCimInstance(), CimType.Reference, inReferenceConfiguration == null ? CimFlags.NullValue : CimFlags.None));
            if (inResourceSettings != null)
                parameters.Add(CimMethodParameter.Create("ResourceSettings", inResourceSettings, CimType.StringArray, inResourceSettings == null ? CimFlags.NullValue : CimFlags.None));
            if (inSystemSettings != null)
                parameters.Add(CimMethodParameter.Create("SystemSettings", inSystemSettings, CimType.String, inSystemSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DefineSystem", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value), (CIMComputerSystem)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ResultingSystem"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) DestroySystem(CIMComputerSystem inAffectedSystem)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedSystem != null)
                parameters.Add(CimMethodParameter.Create("AffectedSystem", inAffectedSystem.AsCimInstance(), CimType.Reference, inAffectedSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DestroySystem", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, IEnumerable<CIMResourceAllocationSettingData> outResultingResourceSettings) ModifyResourceSettings(System.String[] inResourceSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inResourceSettings != null)
                parameters.Add(CimMethodParameter.Create("ResourceSettings", inResourceSettings, CimType.StringArray, inResourceSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyResourceSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value), (IEnumerable<CIMResourceAllocationSettingData>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ResultingResourceSettings"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ModifySystemSettings(System.String inSystemSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inSystemSettings != null)
                parameters.Add(CimMethodParameter.Create("SystemSettings", inSystemSettings, CimType.String, inSystemSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifySystemSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveResourceSettings(IEnumerable<CIMResourceAllocationSettingData> inResourceSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inResourceSettings != null)
                parameters.Add(CimMethodParameter.Create("ResourceSettings", inResourceSettings.AsCimInstance(), CimType.ReferenceArray, inResourceSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveResourceSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }
    }
}