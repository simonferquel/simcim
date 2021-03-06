﻿using Microsoft.Management.Infrastructure;
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
            if (inAffectedSystem != null)
                parameters.Add(CimMethodParameter.Create("AffectedSystem", inAffectedSystem.AsCimInstance(), CimType.Reference, inAffectedSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inResultingSnapshot != null)
                parameters.Add(CimMethodParameter.Create("ResultingSnapshot", inResultingSnapshot.AsCimInstance(), CimType.Reference, inResultingSnapshot == null ? CimFlags.NullValue : CimFlags.None));
            if (inSnapshotSettings != null)
                parameters.Add(CimMethodParameter.Create("SnapshotSettings", inSnapshotSettings, CimType.String, inSnapshotSettings == null ? CimFlags.NullValue : CimFlags.None));
            if (inSnapshotType.HasValue)
                parameters.Add(CimMethodParameter.Create("SnapshotType", inSnapshotType.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CreateSnapshot", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMVirtualSystemSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ResultingSnapshot"].Value), (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) DestroySnapshot(CIMVirtualSystemSettingData inAffectedSnapshot)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedSnapshot != null)
                parameters.Add(CimMethodParameter.Create("AffectedSnapshot", inAffectedSnapshot.AsCimInstance(), CimType.Reference, inAffectedSnapshot == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DestroySnapshot", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ApplySnapshot(CIMVirtualSystemSettingData inSnapshot)
        {
            var parameters = new CimMethodParametersCollection();
            if (inSnapshot != null)
                parameters.Add(CimMethodParameter.Create("Snapshot", inSnapshot.AsCimInstance(), CimType.Reference, inSnapshot == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ApplySnapshot", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }
    }
}