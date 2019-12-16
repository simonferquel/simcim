using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmCollectionReferencePointService : CIMService
    {
        public MsvmCollectionReferencePointService()
        {
        }

        public MsvmCollectionReferencePointService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMCollection outResultingReferencePointCollection, CIMConcreteJob outJob) CreateReferencePoint(MsvmVirtualSystemCollection inCollection, System.String inReferencePointSettings, System.UInt16? inReferencePointType, CIMCollection inResultingReferencePointCollection)
        {
            var parameters = new CimMethodParametersCollection();
            if (inCollection != null)
                parameters.Add(CimMethodParameter.Create("Collection", inCollection.AsCimInstance(), CimType.Reference, inCollection == null ? CimFlags.NullValue : CimFlags.None));
            if (inReferencePointSettings != null)
                parameters.Add(CimMethodParameter.Create("ReferencePointSettings", inReferencePointSettings, CimType.String, inReferencePointSettings == null ? CimFlags.NullValue : CimFlags.None));
            if (inReferencePointType.HasValue)
                parameters.Add(CimMethodParameter.Create("ReferencePointType", inReferencePointType.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ReferencePointType", null, CimFlags.NullValue));
            if (inResultingReferencePointCollection != null)
                parameters.Add(CimMethodParameter.Create("ResultingReferencePointCollection", inResultingReferencePointCollection.AsCimInstance(), CimType.Reference, inResultingReferencePointCollection == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CreateReferencePoint", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMCollection)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["ResultingReferencePointCollection"].Value), (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) DestroyReferencePoint(CIMCollection inAffectedReferencePointCollection)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedReferencePointCollection != null)
                parameters.Add(CimMethodParameter.Create("AffectedReferencePointCollection", inAffectedReferencePointCollection.AsCimInstance(), CimType.Reference, inAffectedReferencePointCollection == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DestroyReferencePoint", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveAssociatedData(CIMCollection inAffectedReferencePointCollection)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedReferencePointCollection != null)
                parameters.Add(CimMethodParameter.Create("AffectedReferencePointCollection", inAffectedReferencePointCollection.AsCimInstance(), CimType.Reference, inAffectedReferencePointCollection == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveAssociatedData", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ExportReferencePoint(System.String inExportDirectory, System.String inExportSettingData, CIMCollection inReferencePointCollection)
        {
            var parameters = new CimMethodParametersCollection();
            if (inExportDirectory != null)
                parameters.Add(CimMethodParameter.Create("ExportDirectory", inExportDirectory, CimType.String, inExportDirectory == null ? CimFlags.NullValue : CimFlags.None));
            if (inExportSettingData != null)
                parameters.Add(CimMethodParameter.Create("ExportSettingData", inExportSettingData, CimType.String, inExportSettingData == null ? CimFlags.NullValue : CimFlags.None));
            if (inReferencePointCollection != null)
                parameters.Add(CimMethodParameter.Create("ReferencePointCollection", inReferencePointCollection.AsCimInstance(), CimType.Reference, inReferencePointCollection == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ExportReferencePoint", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }
    }
}