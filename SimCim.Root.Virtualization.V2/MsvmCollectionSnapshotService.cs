using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmCollectionSnapshotService : CIMService
    {
        public MsvmCollectionSnapshotService()
        {
        }

        public MsvmCollectionSnapshotService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMCollection outResultingSnapshotCollection, CIMConcreteJob outJob) CreateSnapshot(CIMCollectionOfMSEs inCollection, CIMCollection inResultingSnapshotCollection, System.String inSnapshotSettings, System.UInt16? inSnapshotType)
        {
            var parameters = new CimMethodParametersCollection();
            if (inCollection != null)
                parameters.Add(CimMethodParameter.Create("Collection", inCollection.AsCimInstance(), CimType.Reference, inCollection == null ? CimFlags.NullValue : CimFlags.None));
            if (inResultingSnapshotCollection != null)
                parameters.Add(CimMethodParameter.Create("ResultingSnapshotCollection", inResultingSnapshotCollection.AsCimInstance(), CimType.Reference, inResultingSnapshotCollection == null ? CimFlags.NullValue : CimFlags.None));
            if (inSnapshotSettings != null)
                parameters.Add(CimMethodParameter.Create("SnapshotSettings", inSnapshotSettings, CimType.String, inSnapshotSettings == null ? CimFlags.NullValue : CimFlags.None));
            if (inSnapshotType.HasValue)
                parameters.Add(CimMethodParameter.Create("SnapshotType", inSnapshotType.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CreateSnapshot", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMCollection)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["ResultingSnapshotCollection"].Value), (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) DestroySnapshot(CIMCollection inAffectedSnapshotCollection)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedSnapshotCollection != null)
                parameters.Add(CimMethodParameter.Create("AffectedSnapshotCollection", inAffectedSnapshotCollection.AsCimInstance(), CimType.Reference, inAffectedSnapshotCollection == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DestroySnapshot", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ExportSnapshot(System.String inExportDirectory, System.String inExportSettingData, CIMCollection inSnapshotCollection)
        {
            var parameters = new CimMethodParametersCollection();
            if (inExportDirectory != null)
                parameters.Add(CimMethodParameter.Create("ExportDirectory", inExportDirectory, CimType.String, inExportDirectory == null ? CimFlags.NullValue : CimFlags.None));
            if (inExportSettingData != null)
                parameters.Add(CimMethodParameter.Create("ExportSettingData", inExportSettingData, CimType.String, inExportSettingData == null ? CimFlags.NullValue : CimFlags.None));
            if (inSnapshotCollection != null)
                parameters.Add(CimMethodParameter.Create("SnapshotCollection", inSnapshotCollection.AsCimInstance(), CimType.Reference, inSnapshotCollection == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ExportSnapshot", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ApplySnapshot(CIMCollection inSnapshotCollection)
        {
            var parameters = new CimMethodParametersCollection();
            if (inSnapshotCollection != null)
                parameters.Add(CimMethodParameter.Create("SnapshotCollection", inSnapshotCollection.AsCimInstance(), CimType.Reference, inSnapshotCollection == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ApplySnapshot", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, MsvmReferencePointCollection outResultingReferencePointCollection, CIMConcreteJob outJob) ConvertToReferencePoint(MsvmSnapshotCollection inAffectedSnapshotCollection, MsvmReferencePointCollection inResultingReferencePointCollection)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedSnapshotCollection != null)
                parameters.Add(CimMethodParameter.Create("AffectedSnapshotCollection", inAffectedSnapshotCollection.AsCimInstance(), CimType.Reference, inAffectedSnapshotCollection == null ? CimFlags.NullValue : CimFlags.None));
            if (inResultingReferencePointCollection != null)
                parameters.Add(CimMethodParameter.Create("ResultingReferencePointCollection", inResultingReferencePointCollection.AsCimInstance(), CimType.Reference, inResultingReferencePointCollection == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ConvertToReferencePoint", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MsvmReferencePointCollection)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["ResultingReferencePointCollection"].Value), (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }
    }
}