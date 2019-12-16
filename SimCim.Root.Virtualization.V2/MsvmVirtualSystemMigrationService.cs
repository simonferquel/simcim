using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualSystemMigrationService : CIMVirtualSystemMigrationService
    {
        public MsvmVirtualSystemMigrationService()
        {
        }

        public MsvmVirtualSystemMigrationService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActiveStorageMigrationCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveStorageMigrationCount", out result);
                return result;
            }
        }

        public System.UInt32? ActiveVirtualSystemMigrationCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveVirtualSystemMigrationCount", out result);
                return result;
            }
        }

        public System.String[] MigrationServiceListenerIPAddressList
        {
            get
            {
                System.String[] result;
                this.GetProperty("MigrationServiceListenerIPAddressList", out result);
                return result;
            }
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) CheckVirtualSystemIsMigratable(CIMComputerSystem inComputerSystem, System.String inDestinationHost, System.String inMigrationSettingData, System.String[] inNewResourceSettingData, System.String inNewSystemSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), CimType.Reference, inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("DestinationHost", inDestinationHost, CimType.String, inDestinationHost == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("MigrationSettingData", inMigrationSettingData, CimType.String, inMigrationSettingData == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("NewResourceSettingData", inNewResourceSettingData, CimType.StringArray, inNewResourceSettingData == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("NewSystemSettingData", inNewSystemSettingData, CimType.String, inNewSystemSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CheckVirtualSystemIsMigratable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ModifyServiceSettings(System.String inServiceSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ServiceSettingData", inServiceSettingData, CimType.String, inServiceSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyServiceSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) AddNetworkSettings(System.String[] inNetworkSettings)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("NetworkSettings", inNetworkSettings, CimType.StringArray, inNetworkSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddNetworkSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveNetworkSettings(IEnumerable<MsvmVirtualSystemMigrationNetworkSettingData> inNetworkSettings)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("NetworkSettings", inNetworkSettings.AsCimInstance(), CimType.ReferenceArray, inNetworkSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveNetworkSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ModifyNetworkSettings(System.String[] inNetworkSettings)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("NetworkSettings", inNetworkSettings, CimType.StringArray, inNetworkSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyNetworkSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, System.Byte[] outCompatibilityInfo) GetSystemCompatibilityInfo(CIMComputerSystem inComputerSystem)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), CimType.Reference, inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetSystemCompatibilityInfo", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Byte[])result.OutParameters["CompatibilityInfo"].Value);
        }

        public (System.UInt32 retval, System.String[] outReasons) CheckSystemCompatibilityInfo(System.Byte[] inCompatibilityInfo)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("CompatibilityInfo", inCompatibilityInfo, CimType.UInt8Array, inCompatibilityInfo == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CheckSystemCompatibilityInfo", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String[])result.OutParameters["Reasons"].Value);
        }

        public (System.UInt32 retval, IEnumerable<MsvmCompatibilityVector> outCompatibilityVectors) GetSystemCompatibilityVectors(CIMComputerSystem inComputerSystem)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), CimType.Reference, inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetSystemCompatibilityVectors", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<MsvmCompatibilityVector>)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["CompatibilityVectors"].Value));
        }
    }
}