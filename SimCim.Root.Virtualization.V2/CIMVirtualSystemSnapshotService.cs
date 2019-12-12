using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMVirtualSystemSnapshotService : CIMService
    {
        protected CIMVirtualSystemSnapshotService()
        {
        }

        protected CIMVirtualSystemSnapshotService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMVirtualSystemSettingData outResultingSnapshot, CIMConcreteJob outJob) CreateSnapshot(CIMComputerSystem inAffectedSystem, CIMVirtualSystemSettingData inResultingSnapshot, System.String inSnapshotSettings, System.UInt16? inSnapshotType)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("AffectedSystem", inAffectedSystem.AsCimInstance(), inAffectedSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ResultingSnapshot", inResultingSnapshot.AsCimInstance(), inResultingSnapshot == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("SnapshotSettings", inSnapshotSettings, inSnapshotSettings == null ? CimFlags.NullValue : CimFlags.None));
            if (inSnapshotType.HasValue)
                parameters.Add(CimMethodParameter.Create("SnapshotType", inSnapshotType.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("SnapshotType", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CreateSnapshot", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMVirtualSystemSettingData)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["ResultingSnapshot"].Value), (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) DestroySnapshot(CIMVirtualSystemSettingData inAffectedSnapshot)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("AffectedSnapshot", inAffectedSnapshot.AsCimInstance(), inAffectedSnapshot == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DestroySnapshot", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ApplySnapshot(CIMVirtualSystemSettingData inSnapshot)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Snapshot", inSnapshot.AsCimInstance(), inSnapshot == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ApplySnapshot", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }
    }
}