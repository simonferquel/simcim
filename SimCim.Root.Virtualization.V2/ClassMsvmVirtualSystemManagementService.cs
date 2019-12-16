using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualSystemManagementService : CIMVirtualSystemManagementService
    {
        public MsvmVirtualSystemManagementService()
        {
        }

        public MsvmVirtualSystemManagementService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, CIMComputerSystem outResultingSystem) DefinePlannedSystem(CIMVirtualSystemSettingData inReferenceConfiguration, System.String[] inResourceSettings, System.String inSystemSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inReferenceConfiguration != null)
                parameters.Add(CimMethodParameter.Create("ReferenceConfiguration", inReferenceConfiguration.AsCimInstance(), CimType.Reference, inReferenceConfiguration == null ? CimFlags.NullValue : CimFlags.None));
            if (inResourceSettings != null)
                parameters.Add(CimMethodParameter.Create("ResourceSettings", inResourceSettings, CimType.StringArray, inResourceSettings == null ? CimFlags.NullValue : CimFlags.None));
            if (inSystemSettings != null)
                parameters.Add(CimMethodParameter.Create("SystemSettings", inSystemSettings, CimType.String, inSystemSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DefinePlannedSystem", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value), (CIMComputerSystem)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ResultingSystem"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ValidatePlannedSystem(MsvmPlannedComputerSystem inPlannedSystem)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPlannedSystem != null)
                parameters.Add(CimMethodParameter.Create("PlannedSystem", inPlannedSystem.AsCimInstance(), CimType.Reference, inPlannedSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ValidatePlannedSystem", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) UpgradeSystemVersion(CIMComputerSystem inComputerSystem, System.String inUpgradeSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerSystem != null)
                parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), CimType.Reference, inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inUpgradeSettingData != null)
                parameters.Add(CimMethodParameter.Create("UpgradeSettingData", inUpgradeSettingData, CimType.String, inUpgradeSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "UpgradeSystemVersion", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, MsvmPlannedComputerSystem outImportedSystem, CIMConcreteJob outJob) ImportSystemDefinition(System.Boolean? inGenerateNewSystemIdentifier, System.String inSnapshotFolder, System.String inSystemDefinitionFile)
        {
            var parameters = new CimMethodParametersCollection();
            if (inGenerateNewSystemIdentifier.HasValue)
                parameters.Add(CimMethodParameter.Create("GenerateNewSystemIdentifier", inGenerateNewSystemIdentifier.Value, CimFlags.None));
            if (inSnapshotFolder != null)
                parameters.Add(CimMethodParameter.Create("SnapshotFolder", inSnapshotFolder, CimType.String, inSnapshotFolder == null ? CimFlags.NullValue : CimFlags.None));
            if (inSystemDefinitionFile != null)
                parameters.Add(CimMethodParameter.Create("SystemDefinitionFile", inSystemDefinitionFile, CimType.String, inSystemDefinitionFile == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ImportSystemDefinition", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MsvmPlannedComputerSystem)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ImportedSystem"].Value), (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, IEnumerable<MsvmVirtualSystemSettingData> outImportedSnapshots, CIMConcreteJob outJob) ImportSnapshotDefinitions(MsvmPlannedComputerSystem inPlannedSystem, System.String inSnapshotFolder)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPlannedSystem != null)
                parameters.Add(CimMethodParameter.Create("PlannedSystem", inPlannedSystem.AsCimInstance(), CimType.Reference, inPlannedSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inSnapshotFolder != null)
                parameters.Add(CimMethodParameter.Create("SnapshotFolder", inSnapshotFolder, CimType.String, inSnapshotFolder == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ImportSnapshotDefinitions", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<MsvmVirtualSystemSettingData>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ImportedSnapshots"].Value), (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, CIMComputerSystem outResultingSystem) RealizePlannedSystem(MsvmPlannedComputerSystem inPlannedSystem)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPlannedSystem != null)
                parameters.Add(CimMethodParameter.Create("PlannedSystem", inPlannedSystem.AsCimInstance(), CimType.Reference, inPlannedSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RealizePlannedSystem", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value), (CIMComputerSystem)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ResultingSystem"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ExportSystemDefinition(CIMComputerSystem inComputerSystem, System.String inExportDirectory, System.String inExportSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerSystem != null)
                parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), CimType.Reference, inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inExportDirectory != null)
                parameters.Add(CimMethodParameter.Create("ExportDirectory", inExportDirectory, CimType.String, inExportDirectory == null ? CimFlags.NullValue : CimFlags.None));
            if (inExportSettingData != null)
                parameters.Add(CimMethodParameter.Create("ExportSettingData", inExportSettingData, CimType.String, inExportSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ExportSystemDefinition", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, IEnumerable<MsvmEthernetSwitchPortFeatureSettingData> outResultingFeatureSettings) AddFeatureSettings(MsvmEthernetPortAllocationSettingData inAffectedConfiguration, System.String[] inFeatureSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedConfiguration != null)
                parameters.Add(CimMethodParameter.Create("AffectedConfiguration", inAffectedConfiguration.AsCimInstance(), CimType.Reference, inAffectedConfiguration == null ? CimFlags.NullValue : CimFlags.None));
            if (inFeatureSettings != null)
                parameters.Add(CimMethodParameter.Create("FeatureSettings", inFeatureSettings, CimType.StringArray, inFeatureSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddFeatureSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value), (IEnumerable<MsvmEthernetSwitchPortFeatureSettingData>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ResultingFeatureSettings"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, IEnumerable<MsvmEthernetSwitchPortFeatureSettingData> outResultingFeatureSettings) ModifyFeatureSettings(System.String[] inFeatureSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFeatureSettings != null)
                parameters.Add(CimMethodParameter.Create("FeatureSettings", inFeatureSettings, CimType.StringArray, inFeatureSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyFeatureSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value), (IEnumerable<MsvmEthernetSwitchPortFeatureSettingData>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ResultingFeatureSettings"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveFeatureSettings(IEnumerable<MsvmEthernetSwitchPortFeatureSettingData> inFeatureSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFeatureSettings != null)
                parameters.Add(CimMethodParameter.Create("FeatureSettings", inFeatureSettings.AsCimInstance(), CimType.ReferenceArray, inFeatureSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveFeatureSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, IEnumerable<CIMSettingData> outResultingBootSourceSettings) AddBootSourceSettings(CIMVirtualSystemSettingData inAffectedConfiguration, System.String[] inBootSourceSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedConfiguration != null)
                parameters.Add(CimMethodParameter.Create("AffectedConfiguration", inAffectedConfiguration.AsCimInstance(), CimType.Reference, inAffectedConfiguration == null ? CimFlags.NullValue : CimFlags.None));
            if (inBootSourceSettings != null)
                parameters.Add(CimMethodParameter.Create("BootSourceSettings", inBootSourceSettings, CimType.StringArray, inBootSourceSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddBootSourceSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value), (IEnumerable<CIMSettingData>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ResultingBootSourceSettings"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, IEnumerable<CIMSettingData> outResultingGuestServiceSettings) AddGuestServiceSettings(CIMVirtualSystemSettingData inAffectedConfiguration, System.String[] inGuestServiceSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedConfiguration != null)
                parameters.Add(CimMethodParameter.Create("AffectedConfiguration", inAffectedConfiguration.AsCimInstance(), CimType.Reference, inAffectedConfiguration == null ? CimFlags.NullValue : CimFlags.None));
            if (inGuestServiceSettings != null)
                parameters.Add(CimMethodParameter.Create("GuestServiceSettings", inGuestServiceSettings, CimType.StringArray, inGuestServiceSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddGuestServiceSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value), (IEnumerable<CIMSettingData>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ResultingGuestServiceSettings"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, IEnumerable<CIMSettingData> outResultingGuestServiceSettings) ModifyGuestServiceSettings(System.String[] inGuestServiceSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inGuestServiceSettings != null)
                parameters.Add(CimMethodParameter.Create("GuestServiceSettings", inGuestServiceSettings, CimType.StringArray, inGuestServiceSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyGuestServiceSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value), (IEnumerable<CIMSettingData>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ResultingGuestServiceSettings"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveBootSourceSettings(IEnumerable<CIMSettingData> inBootSourceSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inBootSourceSettings != null)
                parameters.Add(CimMethodParameter.Create("BootSourceSettings", inBootSourceSettings.AsCimInstance(), CimType.ReferenceArray, inBootSourceSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveBootSourceSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveGuestServiceSettings(IEnumerable<CIMSettingData> inGuestServiceSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inGuestServiceSettings != null)
                parameters.Add(CimMethodParameter.Create("GuestServiceSettings", inGuestServiceSettings.AsCimInstance(), CimType.ReferenceArray, inGuestServiceSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveGuestServiceSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, System.Byte[] outImageData) GetVirtualSystemThumbnailImage(System.UInt16? inHeightPixels, CIMVirtualSystemSettingData inTargetSystem, System.UInt16? inWidthPixels)
        {
            var parameters = new CimMethodParametersCollection();
            if (inHeightPixels.HasValue)
                parameters.Add(CimMethodParameter.Create("HeightPixels", inHeightPixels.Value, CimFlags.None));
            if (inTargetSystem != null)
                parameters.Add(CimMethodParameter.Create("TargetSystem", inTargetSystem.AsCimInstance(), CimType.Reference, inTargetSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inWidthPixels.HasValue)
                parameters.Add(CimMethodParameter.Create("WidthPixels", inWidthPixels.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetVirtualSystemThumbnailImage", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Byte[])result.OutParameters["ImageData"].Value);
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ModifyServiceSettings(System.String inSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inSettingData != null)
                parameters.Add(CimMethodParameter.Create("SettingData", inSettingData, CimType.String, inSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyServiceSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, IEnumerable<MsvmSummaryInformationBase> outSummaryInformation) GetSummaryInformation(System.UInt32[] inRequestedInformation, IEnumerable<CIMVirtualSystemSettingData> inSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inRequestedInformation != null)
                parameters.Add(CimMethodParameter.Create("RequestedInformation", inRequestedInformation, CimType.UInt32Array, inRequestedInformation == null ? CimFlags.NullValue : CimFlags.None));
            if (inSettingData != null)
                parameters.Add(CimMethodParameter.Create("SettingData", inSettingData.AsCimInstance(), CimType.ReferenceArray, inSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetSummaryInformation", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<MsvmSummaryInformationBase>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["SummaryInformation"].Value));
        }

        public (System.UInt32 retval, IEnumerable<MsvmSummaryInformationBase> outSummaryInformation) GetDefinitionFileSummaryInformation(System.String[] inDefinitionFiles)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDefinitionFiles != null)
                parameters.Add(CimMethodParameter.Create("DefinitionFiles", inDefinitionFiles, CimType.StringArray, inDefinitionFiles == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetDefinitionFileSummaryInformation", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<MsvmSummaryInformationBase>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["SummaryInformation"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) AddKvpItems(System.String[] inDataItems, CIMComputerSystem inTargetSystem)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDataItems != null)
                parameters.Add(CimMethodParameter.Create("DataItems", inDataItems, CimType.StringArray, inDataItems == null ? CimFlags.NullValue : CimFlags.None));
            if (inTargetSystem != null)
                parameters.Add(CimMethodParameter.Create("TargetSystem", inTargetSystem.AsCimInstance(), CimType.Reference, inTargetSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddKvpItems", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ModifyKvpItems(System.String[] inDataItems, CIMComputerSystem inTargetSystem)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDataItems != null)
                parameters.Add(CimMethodParameter.Create("DataItems", inDataItems, CimType.StringArray, inDataItems == null ? CimFlags.NullValue : CimFlags.None));
            if (inTargetSystem != null)
                parameters.Add(CimMethodParameter.Create("TargetSystem", inTargetSystem.AsCimInstance(), CimType.Reference, inTargetSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyKvpItems", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveKvpItems(System.String[] inDataItems, CIMComputerSystem inTargetSystem)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDataItems != null)
                parameters.Add(CimMethodParameter.Create("DataItems", inDataItems, CimType.StringArray, inDataItems == null ? CimFlags.NullValue : CimFlags.None));
            if (inTargetSystem != null)
                parameters.Add(CimMethodParameter.Create("TargetSystem", inTargetSystem.AsCimInstance(), CimType.Reference, inTargetSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveKvpItems", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, System.String outErrorMessage) FormatError(System.String[] inErrors)
        {
            var parameters = new CimMethodParametersCollection();
            if (inErrors != null)
                parameters.Add(CimMethodParameter.Create("Errors", inErrors, CimType.StringArray, inErrors == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "FormatError", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["ErrorMessage"].Value);
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ModifyDiskMergeSettings(System.String inSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            if (inSettingData != null)
                parameters.Add(CimMethodParameter.Create("SettingData", inSettingData, CimType.String, inSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyDiskMergeSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, System.String[] outGeneratedWwpn) GenerateWwpn(System.UInt32? inNumberOfWwpns)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNumberOfWwpns.HasValue)
                parameters.Add(CimMethodParameter.Create("NumberOfWwpns", inNumberOfWwpns.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GenerateWwpn", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String[])result.OutParameters["GeneratedWwpn"].Value);
        }

        public System.UInt32 AddFibreChannelChap(System.String[] inFcPortSettings, System.Byte? inSecretEncoding, System.Byte[] inSharedSecret)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFcPortSettings != null)
                parameters.Add(CimMethodParameter.Create("FcPortSettings", inFcPortSettings, CimType.StringArray, inFcPortSettings == null ? CimFlags.NullValue : CimFlags.None));
            if (inSecretEncoding.HasValue)
                parameters.Add(CimMethodParameter.Create("SecretEncoding", inSecretEncoding.Value, CimFlags.None));
            if (inSharedSecret != null)
                parameters.Add(CimMethodParameter.Create("SharedSecret", inSharedSecret, CimType.UInt8Array, inSharedSecret == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddFibreChannelChap", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 RemoveFibreChannelChap(System.String[] inFcPortSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFcPortSettings != null)
                parameters.Add(CimMethodParameter.Create("FcPortSettings", inFcPortSettings, CimType.StringArray, inFcPortSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveFibreChannelChap", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) SetGuestNetworkAdapterConfiguration(CIMComputerSystem inComputerSystem, System.String[] inNetworkConfiguration)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerSystem != null)
                parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), CimType.Reference, inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inNetworkConfiguration != null)
                parameters.Add(CimMethodParameter.Create("NetworkConfiguration", inNetworkConfiguration, CimType.StringArray, inNetworkConfiguration == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetGuestNetworkAdapterConfiguration", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, System.UInt64? outSize) GetSizeOfSystemFiles(CIMVirtualSystemSettingData inVssd)
        {
            var parameters = new CimMethodParametersCollection();
            if (inVssd != null)
                parameters.Add(CimMethodParameter.Create("Vssd", inVssd.AsCimInstance(), CimType.Reference, inVssd == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetSizeOfSystemFiles", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.UInt64? )result.OutParameters["Size"].Value);
        }

        public (System.UInt32 retval, System.String outCurrentWwpn) GetCurrentWwpnFromGenerator()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetCurrentWwpnFromGenerator", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["CurrentWwpn"].Value);
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, System.UInt32? outRoundTripTime) TestNetworkConnection(System.UInt32? inIsolationId, System.Boolean? inIsSender, System.String inReceiverIP, System.String inReceiverMac, System.String inSenderIP, System.UInt32? inSequenceNumber, MsvmEthernetPortAllocationSettingData inTargetNetworkAdapter)
        {
            var parameters = new CimMethodParametersCollection();
            if (inIsolationId.HasValue)
                parameters.Add(CimMethodParameter.Create("IsolationId", inIsolationId.Value, CimFlags.None));
            if (inIsSender.HasValue)
                parameters.Add(CimMethodParameter.Create("IsSender", inIsSender.Value, CimFlags.None));
            if (inReceiverIP != null)
                parameters.Add(CimMethodParameter.Create("ReceiverIP", inReceiverIP, CimType.String, inReceiverIP == null ? CimFlags.NullValue : CimFlags.None));
            if (inReceiverMac != null)
                parameters.Add(CimMethodParameter.Create("ReceiverMac", inReceiverMac, CimType.String, inReceiverMac == null ? CimFlags.NullValue : CimFlags.None));
            if (inSenderIP != null)
                parameters.Add(CimMethodParameter.Create("SenderIP", inSenderIP, CimType.String, inSenderIP == null ? CimFlags.NullValue : CimFlags.None));
            if (inSequenceNumber.HasValue)
                parameters.Add(CimMethodParameter.Create("SequenceNumber", inSequenceNumber.Value, CimFlags.None));
            if (inTargetNetworkAdapter != null)
                parameters.Add(CimMethodParameter.Create("TargetNetworkAdapter", inTargetNetworkAdapter.AsCimInstance(), CimType.Reference, inTargetNetworkAdapter == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "TestNetworkConnection", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value), (System.UInt32? )result.OutParameters["RoundTripTime"].Value);
        }

        public (System.UInt32 retval, System.String outDiagnosticInformation, CIMConcreteJob outJob) DiagnoseNetworkConnection(System.String inDiagnosticSettings, MsvmEthernetPortAllocationSettingData inTargetNetworkAdapter)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDiagnosticSettings != null)
                parameters.Add(CimMethodParameter.Create("DiagnosticSettings", inDiagnosticSettings, CimType.String, inDiagnosticSettings == null ? CimFlags.NullValue : CimFlags.None));
            if (inTargetNetworkAdapter != null)
                parameters.Add(CimMethodParameter.Create("TargetNetworkAdapter", inTargetNetworkAdapter.AsCimInstance(), CimType.Reference, inTargetNetworkAdapter == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DiagnoseNetworkConnection", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["DiagnosticInformation"].Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) SetInitialMachineConfigurationData(System.Byte[] inImcData, CIMComputerSystem inTargetSystem)
        {
            var parameters = new CimMethodParametersCollection();
            if (inImcData != null)
                parameters.Add(CimMethodParameter.Create("ImcData", inImcData, CimType.UInt8Array, inImcData == null ? CimFlags.NullValue : CimFlags.None));
            if (inTargetSystem != null)
                parameters.Add(CimMethodParameter.Create("TargetSystem", inTargetSystem.AsCimInstance(), CimType.Reference, inTargetSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetInitialMachineConfigurationData", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, IEnumerable<MsvmSystemComponentSettingData> outResultingComponentSettings) AddSystemComponentSettings(MsvmVirtualSystemSettingData inAffectedConfiguration, System.String[] inComponentSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAffectedConfiguration != null)
                parameters.Add(CimMethodParameter.Create("AffectedConfiguration", inAffectedConfiguration.AsCimInstance(), CimType.Reference, inAffectedConfiguration == null ? CimFlags.NullValue : CimFlags.None));
            if (inComponentSettings != null)
                parameters.Add(CimMethodParameter.Create("ComponentSettings", inComponentSettings, CimType.StringArray, inComponentSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddSystemComponentSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value), (IEnumerable<MsvmSystemComponentSettingData>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ResultingComponentSettings"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, IEnumerable<MsvmSystemComponentSettingData> outResultingComponentSettings) ModifySystemComponentSettings(System.String[] inComponentSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComponentSettings != null)
                parameters.Add(CimMethodParameter.Create("ComponentSettings", inComponentSettings, CimType.StringArray, inComponentSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifySystemComponentSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value), (IEnumerable<MsvmSystemComponentSettingData>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["ResultingComponentSettings"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveSystemComponentSettings(IEnumerable<MsvmSystemComponentSettingData> inComponentSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComponentSettings != null)
                parameters.Add(CimMethodParameter.Create("ComponentSettings", inComponentSettings.AsCimInstance(), CimType.ReferenceArray, inComponentSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveSystemComponentSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }
    }
}