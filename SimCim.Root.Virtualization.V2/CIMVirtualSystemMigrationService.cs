using Microsoft.Management.Infrastructure;
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
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("DestinationHost", inDestinationHost, inDestinationHost == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("MigrationSettingData", inMigrationSettingData, inMigrationSettingData == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("NewResourceSettingData", inNewResourceSettingData, inNewResourceSettingData == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("NewSystemSettingData", inNewSystemSettingData, inNewSystemSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "MigrateVirtualSystemToHost", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, CIMComputerSystem outNewComputerSystem) MigrateVirtualSystemToSystem(CIMComputerSystem inComputerSystem, CIMSystem inDestinationSystem, System.String inMigrationSettingData, System.String[] inNewResourceSettingData, System.String inNewSystemSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("DestinationSystem", inDestinationSystem.AsCimInstance(), inDestinationSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("MigrationSettingData", inMigrationSettingData, inMigrationSettingData == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("NewResourceSettingData", inNewResourceSettingData, inNewResourceSettingData == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("NewSystemSettingData", inNewSystemSettingData, inNewSystemSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "MigrateVirtualSystemToSystem", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value), (CIMComputerSystem)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["NewComputerSystem"].Value));
        }

        public (System.UInt32 retval, System.Boolean? outIsMigratable) CheckVirtualSystemIsMigratableToHost(CIMComputerSystem inComputerSystem, System.String inDestinationHost, System.String inMigrationSettingData, System.String[] inNewResourceSettingData, System.String inNewSystemSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("DestinationHost", inDestinationHost, inDestinationHost == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("MigrationSettingData", inMigrationSettingData, inMigrationSettingData == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("NewResourceSettingData", inNewResourceSettingData, inNewResourceSettingData == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("NewSystemSettingData", inNewSystemSettingData, inNewSystemSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CheckVirtualSystemIsMigratableToHost", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Boolean? )result.OutParameters["IsMigratable"].Value);
        }

        public (System.UInt32 retval, System.Boolean? outIsMigratable) CheckVirtualSystemIsMigratableToSystem(CIMComputerSystem inComputerSystem, CIMSystem inDestinationSystem, System.String inMigrationSettingData, System.String[] inNewResourceSettingData, System.String inNewSystemSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("DestinationSystem", inDestinationSystem.AsCimInstance(), inDestinationSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("MigrationSettingData", inMigrationSettingData, inMigrationSettingData == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("NewResourceSettingData", inNewResourceSettingData, inNewResourceSettingData == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("NewSystemSettingData", inNewSystemSettingData, inNewSystemSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CheckVirtualSystemIsMigratableToSystem", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Boolean? )result.OutParameters["IsMigratable"].Value);
        }
    }
}