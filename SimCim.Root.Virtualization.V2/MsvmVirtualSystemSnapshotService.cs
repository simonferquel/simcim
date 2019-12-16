using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualSystemSnapshotService : CIMVirtualSystemSnapshotService
    {
        public MsvmVirtualSystemSnapshotService()
        {
        }

        public MsvmVirtualSystemSnapshotService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) DestroySnapshotTree(CIMVirtualSystemSettingData inSnapshotSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inSnapshotSettingData != null)
                parameters.Add(CimMethodParameter.Create("SnapshotSettingData", inSnapshotSettingData.AsCimInstance(), CimType.Reference, inSnapshotSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DestroySnapshotTree", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ClearSnapshotState(CIMVirtualSystemSettingData inSnapshotSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inSnapshotSettingData != null)
                parameters.Add(CimMethodParameter.Create("SnapshotSettingData", inSnapshotSettingData.AsCimInstance(), CimType.Reference, inSnapshotSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ClearSnapshotState", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, MsvmVirtualSystemReferencePoint outResultingReferencePoint, CIMConcreteJob outJob) ConvertToReferencePoint(CIMVirtualSystemSettingData inAffectedSnapshot, System.String inReferencePointSettings, MsvmVirtualSystemReferencePoint inResultingReferencePoint)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedSnapshot != null)
                parameters.Add(CimMethodParameter.Create("AffectedSnapshot", inAffectedSnapshot.AsCimInstance(), CimType.Reference, inAffectedSnapshot == null ? CimFlags.NullValue : CimFlags.None));
            if (inReferencePointSettings != null)
                parameters.Add(CimMethodParameter.Create("ReferencePointSettings", inReferencePointSettings, CimType.String, inReferencePointSettings == null ? CimFlags.NullValue : CimFlags.None));
            if (inResultingReferencePoint != null)
                parameters.Add(CimMethodParameter.Create("ResultingReferencePoint", inResultingReferencePoint.AsCimInstance(), CimType.Reference, inResultingReferencePoint == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ConvertToReferencePoint", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MsvmVirtualSystemReferencePoint)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["ResultingReferencePoint"].Value), (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }
    }
}