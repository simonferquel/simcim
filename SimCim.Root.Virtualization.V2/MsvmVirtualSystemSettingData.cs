using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualSystemSettingData : CIMVirtualSystemSettingData
    {
        public MsvmVirtualSystemSettingData()
        {
        }

        public MsvmVirtualSystemSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AdditionalRecoveryInformation
        {
            get
            {
                System.String result;
                this.GetProperty("AdditionalRecoveryInformation", out result);
                return result;
            }

            set
            {
                this.SetProperty("AdditionalRecoveryInformation", value);
            }
        }

        public System.Boolean? AllowFullSCSICommandSet
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AllowFullSCSICommandSet", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowFullSCSICommandSet", value);
            }
        }

        public System.Boolean? AllowReducedFcRedundancy
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AllowReducedFcRedundancy", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowReducedFcRedundancy", value);
            }
        }

        public System.String Architecture
        {
            get
            {
                System.String result;
                this.GetProperty("Architecture", out result);
                return result;
            }
        }

        public System.UInt16? AutomaticCriticalErrorAction
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AutomaticCriticalErrorAction", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutomaticCriticalErrorAction", value);
            }
        }

        public System.DateTime? AutomaticCriticalErrorActionTimeout
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("AutomaticCriticalErrorActionTimeout", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutomaticCriticalErrorActionTimeout", value);
            }
        }

        public System.Boolean? AutomaticSnapshotsEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AutomaticSnapshotsEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutomaticSnapshotsEnabled", value);
            }
        }

        public System.String BaseBoardSerialNumber
        {
            get
            {
                System.String result;
                this.GetProperty("BaseBoardSerialNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("BaseBoardSerialNumber", value);
            }
        }

        public System.String BIOSGUID
        {
            get
            {
                System.String result;
                this.GetProperty("BIOSGUID", out result);
                return result;
            }

            set
            {
                this.SetProperty("BIOSGUID", value);
            }
        }

        public System.Boolean? BIOSNumLock
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("BIOSNumLock", out result);
                return result;
            }

            set
            {
                this.SetProperty("BIOSNumLock", value);
            }
        }

        public System.String BIOSSerialNumber
        {
            get
            {
                System.String result;
                this.GetProperty("BIOSSerialNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("BIOSSerialNumber", value);
            }
        }

        public System.UInt16[] BootOrder
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("BootOrder", out result);
                return result;
            }

            set
            {
                this.SetProperty("BootOrder", value);
            }
        }

        public System.Boolean? BootPciExpress
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("BootPciExpress", out result);
                return result;
            }

            set
            {
                this.SetProperty("BootPciExpress", value);
            }
        }

        public System.String BootPciExpressInstanceFilter
        {
            get
            {
                System.String result;
                this.GetProperty("BootPciExpressInstanceFilter", out result);
                return result;
            }

            set
            {
                this.SetProperty("BootPciExpressInstanceFilter", value);
            }
        }

        public System.String[] BootSourceOrder
        {
            get
            {
                System.String[] result;
                this.GetProperty("BootSourceOrder", out result);
                return result;
            }

            set
            {
                this.SetProperty("BootSourceOrder", value);
            }
        }

        public System.String ChassisAssetTag
        {
            get
            {
                System.String result;
                this.GetProperty("ChassisAssetTag", out result);
                return result;
            }

            set
            {
                this.SetProperty("ChassisAssetTag", value);
            }
        }

        public System.String ChassisSerialNumber
        {
            get
            {
                System.String result;
                this.GetProperty("ChassisSerialNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("ChassisSerialNumber", value);
            }
        }

        public System.UInt16? ConsoleMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ConsoleMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConsoleMode", value);
            }
        }

        public System.UInt32? DebugChannelId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DebugChannelId", out result);
                return result;
            }

            set
            {
                this.SetProperty("DebugChannelId", value);
            }
        }

        public System.UInt32? DebugPort
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DebugPort", out result);
                return result;
            }

            set
            {
                this.SetProperty("DebugPort", value);
            }
        }

        public System.UInt16? DebugPortEnabled
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DebugPortEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("DebugPortEnabled", value);
            }
        }

        public System.Boolean? EnableHibernation
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableHibernation", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableHibernation", value);
            }
        }

        public System.UInt16? EnhancedSessionTransportType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EnhancedSessionTransportType", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnhancedSessionTransportType", value);
            }
        }

        public System.Boolean? GuestControlledCacheTypes
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("GuestControlledCacheTypes", out result);
                return result;
            }

            set
            {
                this.SetProperty("GuestControlledCacheTypes", value);
            }
        }

        public System.String GuestStateDataRoot
        {
            get
            {
                System.String result;
                this.GetProperty("GuestStateDataRoot", out result);
                return result;
            }

            set
            {
                this.SetProperty("GuestStateDataRoot", value);
            }
        }

        public System.String GuestStateFile
        {
            get
            {
                System.String result;
                this.GetProperty("GuestStateFile", out result);
                return result;
            }

            set
            {
                this.SetProperty("GuestStateFile", value);
            }
        }

        public System.Boolean? GuestStateIsolationEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("GuestStateIsolationEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("GuestStateIsolationEnabled", value);
            }
        }

        public System.UInt64? HighMmioGapBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HighMmioGapBase", out result);
                return result;
            }

            set
            {
                this.SetProperty("HighMmioGapBase", value);
            }
        }

        public System.UInt64? HighMmioGapSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HighMmioGapSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("HighMmioGapSize", value);
            }
        }

        public System.Boolean? IncrementalBackupEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IncrementalBackupEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncrementalBackupEnabled", value);
            }
        }

        public System.Boolean? IsAutomaticSnapshot
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsAutomaticSnapshot", out result);
                return result;
            }
        }

        public System.Boolean? IsSaved
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsSaved", out result);
                return result;
            }
        }

        public System.Boolean? LockOnDisconnect
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("LockOnDisconnect", out result);
                return result;
            }

            set
            {
                this.SetProperty("LockOnDisconnect", value);
            }
        }

        public System.UInt64? LowMmioGapSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LowMmioGapSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("LowMmioGapSize", value);
            }
        }

        public System.UInt16? NetworkBootPreferredProtocol
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NetworkBootPreferredProtocol", out result);
                return result;
            }

            set
            {
                this.SetProperty("NetworkBootPreferredProtocol", value);
            }
        }

        public System.String[] NumaNodeTopologyArray
        {
            get
            {
                System.String[] result;
                this.GetProperty("NumaNodeTopologyArray", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumaNodeTopologyArray", value);
            }
        }

        public System.String Parent
        {
            get
            {
                System.String result;
                this.GetProperty("Parent", out result);
                return result;
            }
        }

        public System.Boolean? PauseAfterBootFailure
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PauseAfterBootFailure", out result);
                return result;
            }

            set
            {
                this.SetProperty("PauseAfterBootFailure", value);
            }
        }

        public System.Boolean? SecureBootEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SecureBootEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("SecureBootEnabled", value);
            }
        }

        public System.String SecureBootTemplateId
        {
            get
            {
                System.String result;
                this.GetProperty("SecureBootTemplateId", out result);
                return result;
            }

            set
            {
                this.SetProperty("SecureBootTemplateId", value);
            }
        }

        public System.Boolean? TurnOffOnGuestRestart
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TurnOffOnGuestRestart", out result);
                return result;
            }

            set
            {
                this.SetProperty("TurnOffOnGuestRestart", value);
            }
        }

        public System.UInt16? UserSnapshotType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("UserSnapshotType", out result);
                return result;
            }

            set
            {
                this.SetProperty("UserSnapshotType", value);
            }
        }

        public System.String Version
        {
            get
            {
                System.String result;
                this.GetProperty("Version", out result);
                return result;
            }
        }

        public System.Boolean? VirtualNumaEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VirtualNumaEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualNumaEnabled", value);
            }
        }

        public System.String VirtualSystemSubType
        {
            get
            {
                System.String result;
                this.GetProperty("VirtualSystemSubType", out result);
                return result;
            }
        }

        public MsvmSnapshotCollection ResolveMsvmCollectedSnapshotsCollection()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_CollectedSnapshots", "Msvm_SnapshotCollection", "Member", "Collection");
            return instances.Select(i => (MsvmSnapshotCollection)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public MsvmVirtualSystemSettingData ResolveMsvmParentChildSettingDataDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ParentChildSettingData", "Msvm_VirtualSystemSettingData", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmVirtualSystemSettingData)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public MsvmVirtualSystemSettingData ResolveMsvmParentChildSettingDataAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ParentChildSettingData", "Msvm_VirtualSystemSettingData", "Dependent", "Antecedent");
            return instances.Select(i => (MsvmVirtualSystemSettingData)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMComputerSystem ResolveMsvmMostCurrentSnapshotInBranchAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_MostCurrentSnapshotInBranch", "CIM_ComputerSystem", "Dependent", "Antecedent");
            return instances.Select(i => (CIMComputerSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}