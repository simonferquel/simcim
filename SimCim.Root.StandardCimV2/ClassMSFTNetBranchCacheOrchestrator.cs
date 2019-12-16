using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetBranchCacheOrchestrator : CIMManagedElement
    {
        public MSFTNetBranchCacheOrchestrator()
        {
        }

        public MSFTNetBranchCacheOrchestrator(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32 Enable_BCDistributed(System.Boolean? inForce)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable_BCDistributed", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Enable_BCHostedClientByServerNames(System.Boolean? inForce, System.String[] inServerNames, System.UInt32? inUseVersion)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inServerNames != null)
                parameters.Add(CimMethodParameter.Create("ServerNames", inServerNames, CimType.StringArray, inServerNames == null ? CimFlags.NullValue : CimFlags.None));
            if (inUseVersion.HasValue)
                parameters.Add(CimMethodParameter.Create("UseVersion", inUseVersion.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable_BCHostedClientByServerNames", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Enable_BCHostedClientByUseSCP(System.Boolean? inForce, System.Boolean? inUseSCP)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inUseSCP.HasValue)
                parameters.Add(CimMethodParameter.Create("UseSCP", inUseSCP.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable_BCHostedClientByUseSCP", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Enable_BCLocal(System.Boolean? inForce)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable_BCLocal", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Disable_BC(System.Boolean? inForce)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable_BC", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Remove_BCDataCacheExtensionByDataCacheExtension(IEnumerable<MSFTNetBranchCacheDataCacheExtension> inDataCacheExtension, System.Boolean? inForce)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDataCacheExtension != null)
                parameters.Add(CimMethodParameter.Create("DataCacheExtension", inDataCacheExtension.AsCimInstance(), CimType.InstanceArray, inDataCacheExtension == null ? CimFlags.NullValue : CimFlags.None));
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Remove_BCDataCacheExtensionByDataCacheExtension", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Remove_BCDataCacheExtensionByPath(System.Boolean? inForce, System.String inPath)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inPath != null)
                parameters.Add(CimMethodParameter.Create("Path", inPath, CimType.String, inPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Remove_BCDataCacheExtensionByPath", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, IEnumerable<MSFTNetBranchCacheCache> outcmdletOutput) Set_BCCacheByCache(IEnumerable<MSFTNetBranchCacheCache> inCache, System.Boolean? inDefragment, System.Boolean? inForce, System.String inMoveTo, System.Boolean? inPassThru, System.UInt32? inPercentage, System.UInt64? inSizeBytes)
        {
            var parameters = new CimMethodParametersCollection();
            if (inCache != null)
                parameters.Add(CimMethodParameter.Create("Cache", inCache.AsCimInstance(), CimType.InstanceArray, inCache == null ? CimFlags.NullValue : CimFlags.None));
            if (inDefragment.HasValue)
                parameters.Add(CimMethodParameter.Create("Defragment", inDefragment.Value, CimFlags.None));
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inMoveTo != null)
                parameters.Add(CimMethodParameter.Create("MoveTo", inMoveTo, CimType.String, inMoveTo == null ? CimFlags.NullValue : CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            if (inPercentage.HasValue)
                parameters.Add(CimMethodParameter.Create("Percentage", inPercentage.Value, CimFlags.None));
            if (inSizeBytes.HasValue)
                parameters.Add(CimMethodParameter.Create("SizeBytes", inSizeBytes.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Set_BCCacheByCache", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<MSFTNetBranchCacheCache>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetBranchCacheCache outcmdletOutput) Set_BCCacheByPath(System.Boolean? inDefragment, System.Boolean? inForce, System.String inMoveTo, System.Boolean? inPassThru, System.String inPath, System.UInt32? inPercentage, System.UInt64? inSizeBytes)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDefragment.HasValue)
                parameters.Add(CimMethodParameter.Create("Defragment", inDefragment.Value, CimFlags.None));
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inMoveTo != null)
                parameters.Add(CimMethodParameter.Create("MoveTo", inMoveTo, CimType.String, inMoveTo == null ? CimFlags.NullValue : CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            if (inPath != null)
                parameters.Add(CimMethodParameter.Create("Path", inPath, CimType.String, inPath == null ? CimFlags.NullValue : CimFlags.None));
            if (inPercentage.HasValue)
                parameters.Add(CimMethodParameter.Create("Percentage", inPercentage.Value, CimFlags.None));
            if (inSizeBytes.HasValue)
                parameters.Add(CimMethodParameter.Create("SizeBytes", inSizeBytes.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Set_BCCacheByPath", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetBranchCacheCache)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public System.UInt32 Clear_BCCache(System.Boolean? inForce)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Clear_BCCache", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Import_BCSecretKey(System.String inFilename, System.String inFilePassphrase, System.Boolean? inForce)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFilename != null)
                parameters.Add(CimMethodParameter.Create("Filename", inFilename, CimType.String, inFilename == null ? CimFlags.NullValue : CimFlags.None));
            if (inFilePassphrase != null)
                parameters.Add(CimMethodParameter.Create("FilePassphrase", inFilePassphrase, CimType.String, inFilePassphrase == null ? CimFlags.NullValue : CimFlags.None));
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Import_BCSecretKey", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Export_BCSecretKey(System.String inFilename, System.String inFilePassphrase, System.Boolean? inForce)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFilename != null)
                parameters.Add(CimMethodParameter.Create("Filename", inFilename, CimType.String, inFilename == null ? CimFlags.NullValue : CimFlags.None));
            if (inFilePassphrase != null)
                parameters.Add(CimMethodParameter.Create("FilePassphrase", inFilePassphrase, CimType.String, inFilePassphrase == null ? CimFlags.NullValue : CimFlags.None));
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Export_BCSecretKey", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Set_BCAuthentication(System.Boolean? inForce, System.UInt32? inMode)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inMode.HasValue)
                parameters.Add(CimMethodParameter.Create("Mode", inMode.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Set_BCAuthentication", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Enable_BCDowngrading(System.Boolean? inForce, System.UInt32? inVersion)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inVersion.HasValue)
                parameters.Add(CimMethodParameter.Create("Version", inVersion.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable_BCDowngrading", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Enable_BCServeOnBattery(System.Boolean? inForce)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable_BCServeOnBattery", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Disable_BCServeOnBattery(System.Boolean? inForce)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable_BCServeOnBattery", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Set_BCMinSMBLatency(System.Boolean? inForce, System.UInt32? inLatencyMilliseconds)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inLatencyMilliseconds.HasValue)
                parameters.Add(CimMethodParameter.Create("LatencyMilliseconds", inLatencyMilliseconds.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Set_BCMinSMBLatency", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Set_BCSecretKey(System.Boolean? inForce, System.String inPassphrase)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inPassphrase != null)
                parameters.Add(CimMethodParameter.Create("Passphrase", inPassphrase, CimType.String, inPassphrase == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Set_BCSecretKey", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, MSFTNetBranchCacheDataCacheExtension outcmdletOutput) Add_BCDataCacheExtensionByPercentage(System.Boolean? inForce, System.Boolean? inPassThru, System.String inPath, System.UInt32? inPercentage)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            if (inPath != null)
                parameters.Add(CimMethodParameter.Create("Path", inPath, CimType.String, inPath == null ? CimFlags.NullValue : CimFlags.None));
            if (inPercentage.HasValue)
                parameters.Add(CimMethodParameter.Create("Percentage", inPercentage.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Add_BCDataCacheExtensionByPercentage", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetBranchCacheDataCacheExtension)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetBranchCacheDataCacheExtension outcmdletOutput) Add_BCDataCacheExtensionBySizeBytes(System.Boolean? inForce, System.Boolean? inPassThru, System.String inPath, System.UInt64? inSizeBytes)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            if (inPath != null)
                parameters.Add(CimMethodParameter.Create("Path", inPath, CimType.String, inPath == null ? CimFlags.NullValue : CimFlags.None));
            if (inSizeBytes.HasValue)
                parameters.Add(CimMethodParameter.Create("SizeBytes", inSizeBytes.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Add_BCDataCacheExtensionBySizeBytes", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetBranchCacheDataCacheExtension)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public System.UInt32 Disable_BCDowngrading(System.Boolean? inForce)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable_BCDowngrading", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Enable_BCHostedServer(System.Boolean? inForce, System.Boolean? inRegisterSCP)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inRegisterSCP.HasValue)
                parameters.Add(CimMethodParameter.Create("RegisterSCP", inRegisterSCP.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable_BCHostedServer", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Reset_BC(System.Boolean? inForce, System.Boolean? inResetFWRulesOnly, System.Boolean? inResetPerfCountersOnly)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inResetFWRulesOnly.HasValue)
                parameters.Add(CimMethodParameter.Create("ResetFWRulesOnly", inResetFWRulesOnly.Value, CimFlags.None));
            if (inResetPerfCountersOnly.HasValue)
                parameters.Add(CimMethodParameter.Create("ResetPerfCountersOnly", inResetPerfCountersOnly.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Reset_BC", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Publish_BCWebHashes(System.Boolean? inForce, System.String[] inPath, System.Boolean? inRecurse, System.String inReferenceFile, System.Boolean? inStageData, System.String inStagingPath, System.UInt32? inUseVersion)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inPath != null)
                parameters.Add(CimMethodParameter.Create("Path", inPath, CimType.StringArray, inPath == null ? CimFlags.NullValue : CimFlags.None));
            if (inRecurse.HasValue)
                parameters.Add(CimMethodParameter.Create("Recurse", inRecurse.Value, CimFlags.None));
            if (inReferenceFile != null)
                parameters.Add(CimMethodParameter.Create("ReferenceFile", inReferenceFile, CimType.String, inReferenceFile == null ? CimFlags.NullValue : CimFlags.None));
            if (inStageData.HasValue)
                parameters.Add(CimMethodParameter.Create("StageData", inStageData.Value, CimFlags.None));
            if (inStagingPath != null)
                parameters.Add(CimMethodParameter.Create("StagingPath", inStagingPath, CimType.String, inStagingPath == null ? CimFlags.NullValue : CimFlags.None));
            if (inUseVersion.HasValue)
                parameters.Add(CimMethodParameter.Create("UseVersion", inUseVersion.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Publish_BCWebHashes", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Publish_BCFileHashes(System.Boolean? inForce, System.String[] inPath, System.Boolean? inRecurse, System.String inReferenceFile, System.Boolean? inStageData, System.String inStagingPath, System.UInt32? inUseVersion)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inPath != null)
                parameters.Add(CimMethodParameter.Create("Path", inPath, CimType.StringArray, inPath == null ? CimFlags.NullValue : CimFlags.None));
            if (inRecurse.HasValue)
                parameters.Add(CimMethodParameter.Create("Recurse", inRecurse.Value, CimFlags.None));
            if (inReferenceFile != null)
                parameters.Add(CimMethodParameter.Create("ReferenceFile", inReferenceFile, CimType.String, inReferenceFile == null ? CimFlags.NullValue : CimFlags.None));
            if (inStageData.HasValue)
                parameters.Add(CimMethodParameter.Create("StageData", inStageData.Value, CimFlags.None));
            if (inStagingPath != null)
                parameters.Add(CimMethodParameter.Create("StagingPath", inStagingPath, CimType.String, inStagingPath == null ? CimFlags.NullValue : CimFlags.None));
            if (inUseVersion.HasValue)
                parameters.Add(CimMethodParameter.Create("UseVersion", inUseVersion.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Publish_BCFileHashes", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Export_BCCachePackageByExportDataCache(System.String inDestination, System.Boolean? inExportDataCache, System.Boolean? inForce)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDestination != null)
                parameters.Add(CimMethodParameter.Create("Destination", inDestination, CimType.String, inDestination == null ? CimFlags.NullValue : CimFlags.None));
            if (inExportDataCache.HasValue)
                parameters.Add(CimMethodParameter.Create("ExportDataCache", inExportDataCache.Value, CimFlags.None));
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Export_BCCachePackageByExportDataCache", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Export_BCCachePackageByStagingPath(System.String inDestination, System.Boolean? inForce, System.String inOutputReferenceFile, System.String inStagingPath)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDestination != null)
                parameters.Add(CimMethodParameter.Create("Destination", inDestination, CimType.String, inDestination == null ? CimFlags.NullValue : CimFlags.None));
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inOutputReferenceFile != null)
                parameters.Add(CimMethodParameter.Create("OutputReferenceFile", inOutputReferenceFile, CimType.String, inOutputReferenceFile == null ? CimFlags.NullValue : CimFlags.None));
            if (inStagingPath != null)
                parameters.Add(CimMethodParameter.Create("StagingPath", inStagingPath, CimType.String, inStagingPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Export_BCCachePackageByStagingPath", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Import_BCCachePackage(System.Boolean? inForce, System.String inPath)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inPath != null)
                parameters.Add(CimMethodParameter.Create("Path", inPath, CimType.String, inPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Import_BCCachePackage", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Set_BCDataCacheEntryMaxAge(System.Boolean? inForce, System.UInt32? inTimeDays)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inTimeDays.HasValue)
                parameters.Add(CimMethodParameter.Create("TimeDays", inTimeDays.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Set_BCDataCacheEntryMaxAge", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}