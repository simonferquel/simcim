using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualSystemReferencePointService : CIMService
    {
        public MsvmVirtualSystemReferencePointService()
        {
        }

        public MsvmVirtualSystemReferencePointService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, MsvmVirtualSystemReferencePoint outResultingReferencePoint, CIMConcreteJob outJob) CreateReferencePoint(MsvmComputerSystem inAffectedSystem, System.String inReferencePointSettings, System.UInt16? inReferencePointType, MsvmVirtualSystemReferencePoint inResultingReferencePoint)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedSystem != null)
                parameters.Add(CimMethodParameter.Create("AffectedSystem", inAffectedSystem.AsCimInstance(), CimType.Reference, inAffectedSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inReferencePointSettings != null)
                parameters.Add(CimMethodParameter.Create("ReferencePointSettings", inReferencePointSettings, CimType.String, inReferencePointSettings == null ? CimFlags.NullValue : CimFlags.None));
            if (inReferencePointType.HasValue)
                parameters.Add(CimMethodParameter.Create("ReferencePointType", inReferencePointType.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ReferencePointType", null, CimFlags.NullValue));
            if (inResultingReferencePoint != null)
                parameters.Add(CimMethodParameter.Create("ResultingReferencePoint", inResultingReferencePoint.AsCimInstance(), CimType.Reference, inResultingReferencePoint == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CreateReferencePoint", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MsvmVirtualSystemReferencePoint)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["ResultingReferencePoint"].Value), (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ExportReferencePoint(System.String inExportDirectory, System.String inExportSettingData, MsvmVirtualSystemReferencePoint inReferencePoint)
        {
            var parameters = new CimMethodParametersCollection();
            if (inExportDirectory != null)
                parameters.Add(CimMethodParameter.Create("ExportDirectory", inExportDirectory, CimType.String, inExportDirectory == null ? CimFlags.NullValue : CimFlags.None));
            if (inExportSettingData != null)
                parameters.Add(CimMethodParameter.Create("ExportSettingData", inExportSettingData, CimType.String, inExportSettingData == null ? CimFlags.NullValue : CimFlags.None));
            if (inReferencePoint != null)
                parameters.Add(CimMethodParameter.Create("ReferencePoint", inReferencePoint.AsCimInstance(), CimType.Reference, inReferencePoint == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ExportReferencePoint", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) DestroyReferencePoint(MsvmVirtualSystemReferencePoint inAffectedReferencePoint)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedReferencePoint != null)
                parameters.Add(CimMethodParameter.Create("AffectedReferencePoint", inAffectedReferencePoint.AsCimInstance(), CimType.Reference, inAffectedReferencePoint == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DestroyReferencePoint", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveAssociatedData(MsvmVirtualSystemReferencePoint inAffectedReferencePoint)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedReferencePoint != null)
                parameters.Add(CimMethodParameter.Create("AffectedReferencePoint", inAffectedReferencePoint.AsCimInstance(), CimType.Reference, inAffectedReferencePoint == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveAssociatedData", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ImportReferencePointMetadata(MsvmComputerSystem inAffectedSystem, System.String inConfigFilePath, System.String inRuntimeStateFilePath)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedSystem != null)
                parameters.Add(CimMethodParameter.Create("AffectedSystem", inAffectedSystem.AsCimInstance(), CimType.Reference, inAffectedSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inConfigFilePath != null)
                parameters.Add(CimMethodParameter.Create("ConfigFilePath", inConfigFilePath, CimType.String, inConfigFilePath == null ? CimFlags.NullValue : CimFlags.None));
            if (inRuntimeStateFilePath != null)
                parameters.Add(CimMethodParameter.Create("RuntimeStateFilePath", inRuntimeStateFilePath, CimType.String, inRuntimeStateFilePath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ImportReferencePointMetadata", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }
    }
}