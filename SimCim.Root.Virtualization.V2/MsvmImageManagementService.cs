﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmImageManagementService : CIMService
    {
        public MsvmImageManagementService()
        {
        }

        public MsvmImageManagementService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) SetVirtualHardDiskSettingData(System.String inVirtualDiskSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("VirtualDiskSettingData", inVirtualDiskSettingData, inVirtualDiskSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetVirtualHardDiskSettingData", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) CreateVirtualHardDisk(System.String inVirtualDiskSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("VirtualDiskSettingData", inVirtualDiskSettingData, inVirtualDiskSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CreateVirtualHardDisk", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) SetParentVirtualHardDisk(System.String inChildPath, System.Boolean? inIgnoreIDMismatch, System.String inLeafPath, System.String inParentPath)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ChildPath", inChildPath, inChildPath == null ? CimFlags.NullValue : CimFlags.None));
            if (inIgnoreIDMismatch.HasValue)
                parameters.Add(CimMethodParameter.Create("IgnoreIDMismatch", inIgnoreIDMismatch.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("IgnoreIDMismatch", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("LeafPath", inLeafPath, inLeafPath == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ParentPath", inParentPath, inParentPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetParentVirtualHardDisk", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) CreateVirtualFloppyDisk(System.String inPath)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Path", inPath, inPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CreateVirtualFloppyDisk", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) MergeVirtualHardDisk(System.String inDestinationPath, System.String inSourcePath)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("DestinationPath", inDestinationPath, inDestinationPath == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("SourcePath", inSourcePath, inSourcePath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "MergeVirtualHardDisk", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) CompactVirtualHardDisk(System.UInt16? inMode, System.String inPath)
        {
            var parameters = new CimMethodParametersCollection();
            if (inMode.HasValue)
                parameters.Add(CimMethodParameter.Create("Mode", inMode.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Mode", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("Path", inPath, inPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CompactVirtualHardDisk", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ResizeVirtualHardDisk(System.UInt64? inMaxInternalSize, System.String inPath)
        {
            var parameters = new CimMethodParametersCollection();
            if (inMaxInternalSize.HasValue)
                parameters.Add(CimMethodParameter.Create("MaxInternalSize", inMaxInternalSize.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("MaxInternalSize", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("Path", inPath, inPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ResizeVirtualHardDisk", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ConvertVirtualHardDisk(System.String inSourcePath, System.String inVirtualDiskSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("SourcePath", inSourcePath, inSourcePath == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("VirtualDiskSettingData", inVirtualDiskSettingData, inVirtualDiskSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ConvertVirtualHardDisk", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, System.String outSettingData) GetVirtualHardDiskSettingData(System.String inPath)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Path", inPath, inPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetVirtualHardDiskSettingData", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value), (System.String)result.OutParameters["SettingData"].Value);
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, System.String outState) GetVirtualHardDiskState(System.String inPath)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Path", inPath, inPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetVirtualHardDiskState", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value), (System.String)result.OutParameters["State"].Value);
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) AttachVirtualHardDisk(System.Boolean? inAssignDriveLetter, System.String inPath, System.Boolean? inReadOnly)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAssignDriveLetter.HasValue)
                parameters.Add(CimMethodParameter.Create("AssignDriveLetter", inAssignDriveLetter.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("AssignDriveLetter", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("Path", inPath, inPath == null ? CimFlags.NullValue : CimFlags.None));
            if (inReadOnly.HasValue)
                parameters.Add(CimMethodParameter.Create("ReadOnly", inReadOnly.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ReadOnly", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AttachVirtualHardDisk", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ValidateVirtualHardDisk(System.String inPath)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Path", inPath, inPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ValidateVirtualHardDisk", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ValidatePersistentReservationSupport(System.String inPath)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Path", inPath, inPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ValidatePersistentReservationSupport", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, System.String outInformation, CIMConcreteJob outJob) GetVHDSetInformation(System.UInt32[] inAdditionalInformation, System.String inVHDSetPath)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("AdditionalInformation", inAdditionalInformation, inAdditionalInformation == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("VHDSetPath", inVHDSetPath, inVHDSetPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetVHDSetInformation", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["Information"].Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, System.String[] outSnapshotInformation) GetVHDSnapshotInformation(System.UInt32[] inAdditionalInformation, System.String[] inSnapshotIds, System.String inVHDSetPath)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("AdditionalInformation", inAdditionalInformation, inAdditionalInformation == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("SnapshotIds", inSnapshotIds, inSnapshotIds == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("VHDSetPath", inVHDSetPath, inVHDSetPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetVHDSnapshotInformation", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value), (System.String[])result.OutParameters["SnapshotInformation"].Value);
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) SetVHDSnapshotInformation(System.String inInformation)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Information", inInformation, inInformation == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetVHDSnapshotInformation", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) DeleteVHDSnapshot(System.Boolean? inPersistReferenceSnapshot, System.String inSnapshotId, System.String inVHDSetPath)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPersistReferenceSnapshot.HasValue)
                parameters.Add(CimMethodParameter.Create("PersistReferenceSnapshot", inPersistReferenceSnapshot.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("PersistReferenceSnapshot", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("SnapshotId", inSnapshotId, inSnapshotId == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("VHDSetPath", inVHDSetPath, inVHDSetPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DeleteVHDSnapshot", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ConvertVirtualHardDiskToVHDSet(System.String inVirtualHardDiskPath)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("VirtualHardDiskPath", inVirtualHardDiskPath, inVirtualHardDiskPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ConvertVirtualHardDiskToVHDSet", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) OptimizeVHDSet(System.String inVHDSetPath)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("VHDSetPath", inVHDSetPath, inVHDSetPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "OptimizeVHDSet", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, System.UInt64[] outChangedByteLengths, System.UInt64[] outChangedByteOffsets, CIMConcreteJob outJob, System.UInt64? outProcessedByteLength) GetVirtualDiskChanges(System.UInt64? inByteLength, System.UInt64? inByteOffset, System.String inLimitId, System.String inPath, System.String inTargetSnapshotId)
        {
            var parameters = new CimMethodParametersCollection();
            if (inByteLength.HasValue)
                parameters.Add(CimMethodParameter.Create("ByteLength", inByteLength.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ByteLength", null, CimFlags.NullValue));
            if (inByteOffset.HasValue)
                parameters.Add(CimMethodParameter.Create("ByteOffset", inByteOffset.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ByteOffset", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("LimitId", inLimitId, inLimitId == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("Path", inPath, inPath == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("TargetSnapshotId", inTargetSnapshotId, inTargetSnapshotId == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetVirtualDiskChanges", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.UInt64[])result.OutParameters["ChangedByteLengths"].Value, (System.UInt64[])result.OutParameters["ChangedByteOffsets"].Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value), (System.UInt64? )result.OutParameters["ProcessedByteLength"].Value);
        }

        public (System.UInt32 retval, MsvmMountedStorageImage outImage) FindMountedStorageImageInstance(System.UInt16? inCriterionType, System.String inSelectionCriterion)
        {
            var parameters = new CimMethodParametersCollection();
            if (inCriterionType.HasValue)
                parameters.Add(CimMethodParameter.Create("CriterionType", inCriterionType.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("CriterionType", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("SelectionCriterion", inSelectionCriterion, inSelectionCriterion == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "FindMountedStorageImageInstance", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MsvmMountedStorageImage)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Image"].Value));
        }
    }
}