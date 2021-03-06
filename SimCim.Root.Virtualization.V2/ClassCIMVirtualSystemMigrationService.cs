﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMVirtualSystemMigrationService : CIMService
    {
        protected CIMVirtualSystemMigrationService()
        {
        }

        protected CIMVirtualSystemMigrationService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) MigrateVirtualSystemToHost(CIMComputerSystem inComputerSystem, System.String inDestinationHost, System.String inMigrationSettingData, System.String[] inNewResourceSettingData, System.String inNewSystemSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerSystem != null)
                parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), CimType.Reference, inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inDestinationHost != null)
                parameters.Add(CimMethodParameter.Create("DestinationHost", inDestinationHost, CimType.String, inDestinationHost == null ? CimFlags.NullValue : CimFlags.None));
            if (inMigrationSettingData != null)
                parameters.Add(CimMethodParameter.Create("MigrationSettingData", inMigrationSettingData, CimType.String, inMigrationSettingData == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewResourceSettingData != null)
                parameters.Add(CimMethodParameter.Create("NewResourceSettingData", inNewResourceSettingData, CimType.StringArray, inNewResourceSettingData == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewSystemSettingData != null)
                parameters.Add(CimMethodParameter.Create("NewSystemSettingData", inNewSystemSettingData, CimType.String, inNewSystemSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "MigrateVirtualSystemToHost", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, CIMComputerSystem outNewComputerSystem) MigrateVirtualSystemToSystem(CIMComputerSystem inComputerSystem, CIMSystem inDestinationSystem, System.String inMigrationSettingData, System.String[] inNewResourceSettingData, System.String inNewSystemSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerSystem != null)
                parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), CimType.Reference, inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inDestinationSystem != null)
                parameters.Add(CimMethodParameter.Create("DestinationSystem", inDestinationSystem.AsCimInstance(), CimType.Reference, inDestinationSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inMigrationSettingData != null)
                parameters.Add(CimMethodParameter.Create("MigrationSettingData", inMigrationSettingData, CimType.String, inMigrationSettingData == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewResourceSettingData != null)
                parameters.Add(CimMethodParameter.Create("NewResourceSettingData", inNewResourceSettingData, CimType.StringArray, inNewResourceSettingData == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewSystemSettingData != null)
                parameters.Add(CimMethodParameter.Create("NewSystemSettingData", inNewSystemSettingData, CimType.String, inNewSystemSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "MigrateVirtualSystemToSystem", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value), (CIMComputerSystem)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["NewComputerSystem"].Value));
        }

        public (System.UInt32 retval, System.Boolean? outIsMigratable) CheckVirtualSystemIsMigratableToHost(CIMComputerSystem inComputerSystem, System.String inDestinationHost, System.String inMigrationSettingData, System.String[] inNewResourceSettingData, System.String inNewSystemSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerSystem != null)
                parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), CimType.Reference, inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inDestinationHost != null)
                parameters.Add(CimMethodParameter.Create("DestinationHost", inDestinationHost, CimType.String, inDestinationHost == null ? CimFlags.NullValue : CimFlags.None));
            if (inMigrationSettingData != null)
                parameters.Add(CimMethodParameter.Create("MigrationSettingData", inMigrationSettingData, CimType.String, inMigrationSettingData == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewResourceSettingData != null)
                parameters.Add(CimMethodParameter.Create("NewResourceSettingData", inNewResourceSettingData, CimType.StringArray, inNewResourceSettingData == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewSystemSettingData != null)
                parameters.Add(CimMethodParameter.Create("NewSystemSettingData", inNewSystemSettingData, CimType.String, inNewSystemSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CheckVirtualSystemIsMigratableToHost", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Boolean? )result.OutParameters["IsMigratable"].Value);
        }

        public (System.UInt32 retval, System.Boolean? outIsMigratable) CheckVirtualSystemIsMigratableToSystem(CIMComputerSystem inComputerSystem, CIMSystem inDestinationSystem, System.String inMigrationSettingData, System.String[] inNewResourceSettingData, System.String inNewSystemSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerSystem != null)
                parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), CimType.Reference, inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inDestinationSystem != null)
                parameters.Add(CimMethodParameter.Create("DestinationSystem", inDestinationSystem.AsCimInstance(), CimType.Reference, inDestinationSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inMigrationSettingData != null)
                parameters.Add(CimMethodParameter.Create("MigrationSettingData", inMigrationSettingData, CimType.String, inMigrationSettingData == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewResourceSettingData != null)
                parameters.Add(CimMethodParameter.Create("NewResourceSettingData", inNewResourceSettingData, CimType.StringArray, inNewResourceSettingData == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewSystemSettingData != null)
                parameters.Add(CimMethodParameter.Create("NewSystemSettingData", inNewSystemSettingData, CimType.String, inNewSystemSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CheckVirtualSystemIsMigratableToSystem", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Boolean? )result.OutParameters["IsMigratable"].Value);
        }
    }
}