using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class InfrastructureObjectMapper : IInfrastructureObjectMapper
    {
        private readonly IInfrastructureObjectScope _scope;
        public InfrastructureObjectMapper(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IInfrastructureObject Create(CimInstance cimInstance)
        {
            switch (cimInstance.CimSystemProperties.ClassName)
            {
                case "__thisNAMESPACE":
                    return new ThisNAMESPACE(_scope, cimInstance);
                case "__NAMESPACE":
                    return new NAMESPACE(_scope, cimInstance);
                case "__Win32Provider":
                    return new Win32Provider(_scope, cimInstance);
                case "__EventProviderRegistration":
                    return new EventProviderRegistration(_scope, cimInstance);
                case "__ClassProviderRegistration":
                    return new ClassProviderRegistration(_scope, cimInstance);
                case "__InstanceProviderRegistration":
                    return new InstanceProviderRegistration(_scope, cimInstance);
                case "__MethodProviderRegistration":
                    return new MethodProviderRegistration(_scope, cimInstance);
                case "__PropertyProviderRegistration":
                    return new PropertyProviderRegistration(_scope, cimInstance);
                case "__EventConsumerProviderRegistration":
                    return new EventConsumerProviderRegistration(_scope, cimInstance);
                case "__EventFilter":
                    return new EventFilter(_scope, cimInstance);
                case "__FilterToConsumerBinding":
                    return new FilterToConsumerBinding(_scope, cimInstance);
                case "__InstanceOperationEvent":
                    return new InstanceOperationEvent(_scope, cimInstance);
                case "__InstanceCreationEvent":
                    return new InstanceCreationEvent(_scope, cimInstance);
                case "__InstanceDeletionEvent":
                    return new InstanceDeletionEvent(_scope, cimInstance);
                case "__InstanceModificationEvent":
                    return new InstanceModificationEvent(_scope, cimInstance);
                case "__MethodInvocationEvent":
                    return new MethodInvocationEvent(_scope, cimInstance);
                case "__ExtrinsicEvent":
                    return new ExtrinsicEvent(_scope, cimInstance);
                case "CIM_Indication":
                    return new CIMIndication(_scope, cimInstance);
                case "CIM_ProcessIndication":
                    return new CIMProcessIndication(_scope, cimInstance);
                case "CIM_AlertIndication":
                    return new CIMAlertIndication(_scope, cimInstance);
                case "Msvm_StorageAlert":
                    return new MsvmStorageAlert(_scope, cimInstance);
                case "CIM_ClassDeletion":
                    return new CIMClassDeletion(_scope, cimInstance);
                case "CIM_ClassCreation":
                    return new CIMClassCreation(_scope, cimInstance);
                case "CIM_ClassModification":
                    return new CIMClassModification(_scope, cimInstance);
                case "CIM_InstCreation":
                    return new CIMInstCreation(_scope, cimInstance);
                case "CIM_InstModification":
                    return new CIMInstModification(_scope, cimInstance);
                case "CIM_InstDeletion":
                    return new CIMInstDeletion(_scope, cimInstance);
                case "__SystemEvent":
                    return new SystemEvent(_scope, cimInstance);
                case "__EventDroppedEvent":
                    return new EventDroppedEvent(_scope, cimInstance);
                case "__EventQueueOverflowEvent":
                    return new EventQueueOverflowEvent(_scope, cimInstance);
                case "__QOSFailureEvent":
                    return new QOSFailureEvent(_scope, cimInstance);
                case "__ConsumerFailureEvent":
                    return new ConsumerFailureEvent(_scope, cimInstance);
                case "__ClassOperationEvent":
                    return new ClassOperationEvent(_scope, cimInstance);
                case "__ClassDeletionEvent":
                    return new ClassDeletionEvent(_scope, cimInstance);
                case "__ClassModificationEvent":
                    return new ClassModificationEvent(_scope, cimInstance);
                case "__ClassCreationEvent":
                    return new ClassCreationEvent(_scope, cimInstance);
                case "__NamespaceOperationEvent":
                    return new NamespaceOperationEvent(_scope, cimInstance);
                case "__NamespaceModificationEvent":
                    return new NamespaceModificationEvent(_scope, cimInstance);
                case "__NamespaceDeletionEvent":
                    return new NamespaceDeletionEvent(_scope, cimInstance);
                case "__NamespaceCreationEvent":
                    return new NamespaceCreationEvent(_scope, cimInstance);
                case "__TimerEvent":
                    return new TimerEvent(_scope, cimInstance);
                case "__AggregateEvent":
                    return new AggregateEvent(_scope, cimInstance);
                case "__TimerNextFiring":
                    return new TimerNextFiring(_scope, cimInstance);
                case "__AbsoluteTimerInstruction":
                    return new AbsoluteTimerInstruction(_scope, cimInstance);
                case "__IntervalTimerInstruction":
                    return new IntervalTimerInstruction(_scope, cimInstance);
                case "__SystemSecurity":
                    return new SystemSecurity(_scope, cimInstance);
                case "Msvm_VirtualEthernetSwitchNicTeamingSettingData":
                    return new MsvmVirtualEthernetSwitchNicTeamingSettingData(_scope, cimInstance);
                case "Msvm_VirtualEthernetSwitchBandwidthSettingData":
                    return new MsvmVirtualEthernetSwitchBandwidthSettingData(_scope, cimInstance);
                case "Msvm_EthernetSwitchHardwareOffloadSettingData":
                    return new MsvmEthernetSwitchHardwareOffloadSettingData(_scope, cimInstance);
                case "Msvm_EthernetSwitchPortTeamMappingSettingData":
                    return new MsvmEthernetSwitchPortTeamMappingSettingData(_scope, cimInstance);
                case "Msvm_EthernetSwitchPortIsolationSettingData":
                    return new MsvmEthernetSwitchPortIsolationSettingData(_scope, cimInstance);
                case "Msvm_EthernetSwitchPortVlanSettingData":
                    return new MsvmEthernetSwitchPortVlanSettingData(_scope, cimInstance);
                case "Msvm_EthernetSwitchPortAclSettingData":
                    return new MsvmEthernetSwitchPortAclSettingData(_scope, cimInstance);
                case "Msvm_EthernetSwitchPortRdmaSettingData":
                    return new MsvmEthernetSwitchPortRdmaSettingData(_scope, cimInstance);
                case "Msvm_EthernetSwitchPortBandwidthSettingData":
                    return new MsvmEthernetSwitchPortBandwidthSettingData(_scope, cimInstance);
                case "Msvm_EthernetSwitchPortExtendedAclSettingData":
                    return new MsvmEthernetSwitchPortExtendedAclSettingData(_scope, cimInstance);
                case "Msvm_EthernetSwitchPortRoutingDomainSettingData":
                    return new MsvmEthernetSwitchPortRoutingDomainSettingData(_scope, cimInstance);
                case "Msvm_EthernetSwitchPortProfileSettingData":
                    return new MsvmEthernetSwitchPortProfileSettingData(_scope, cimInstance);
                case "Msvm_EthernetSwitchPortOffloadSettingData":
                    return new MsvmEthernetSwitchPortOffloadSettingData(_scope, cimInstance);
                case "Msvm_EthernetSwitchPortSecuritySettingData":
                    return new MsvmEthernetSwitchPortSecuritySettingData(_scope, cimInstance);
                case "Msvm_ReplicationSettingData":
                    return new MsvmReplicationSettingData(_scope, cimInstance);
                case "Msvm_VirtualSystemSettingData":
                    return new MsvmVirtualSystemSettingData(_scope, cimInstance);
                case "Msvm_VirtualEthernetSwitchSettingData":
                    return new MsvmVirtualEthernetSwitchSettingData(_scope, cimInstance);
                case "Msvm_VirtualFcSwitchSettingData":
                    return new MsvmVirtualFcSwitchSettingData(_scope, cimInstance);
                case "Msvm_DiskMergeSettingData":
                    return new MsvmDiskMergeSettingData(_scope, cimInstance);
                case "Msvm_ResourceAllocationSettingData":
                    return new MsvmResourceAllocationSettingData(_scope, cimInstance);
                case "Msvm_SerialPortSettingData":
                    return new MsvmSerialPortSettingData(_scope, cimInstance);
                case "Msvm_GuestServiceInterfaceComponentSettingData":
                    return new MsvmGuestServiceInterfaceComponentSettingData(_scope, cimInstance);
                case "Msvm_HeartbeatComponentSettingData":
                    return new MsvmHeartbeatComponentSettingData(_scope, cimInstance);
                case "Msvm_KvpExchangeComponentSettingData":
                    return new MsvmKvpExchangeComponentSettingData(_scope, cimInstance);
                case "Msvm_ShutdownComponentSettingData":
                    return new MsvmShutdownComponentSettingData(_scope, cimInstance);
                case "Msvm_TimeSyncComponentSettingData":
                    return new MsvmTimeSyncComponentSettingData(_scope, cimInstance);
                case "Msvm_VssComponentSettingData":
                    return new MsvmVssComponentSettingData(_scope, cimInstance);
                case "Msvm_RdvComponentSettingData":
                    return new MsvmRdvComponentSettingData(_scope, cimInstance);
                case "Msvm_BatterySettingData":
                    return new MsvmBatterySettingData(_scope, cimInstance);
                case "Msvm_StorageAllocationSettingData":
                    return new MsvmStorageAllocationSettingData(_scope, cimInstance);
                case "Msvm_MemorySettingData":
                    return new MsvmMemorySettingData(_scope, cimInstance);
                case "Msvm_ProcessorSettingData":
                    return new MsvmProcessorSettingData(_scope, cimInstance);
                case "Msvm_VirtualLogicalUnitSettingData":
                    return new MsvmVirtualLogicalUnitSettingData(_scope, cimInstance);
                case "Msvm_SyntheticDisplayControllerSettingData":
                    return new MsvmSyntheticDisplayControllerSettingData(_scope, cimInstance);
                case "Msvm_PciExpressSettingData":
                    return new MsvmPciExpressSettingData(_scope, cimInstance);
                case "Msvm_GpuPartitionSettingData":
                    return new MsvmGpuPartitionSettingData(_scope, cimInstance);
                case "Msvm_SyntheticEthernetPortSettingData":
                    return new MsvmSyntheticEthernetPortSettingData(_scope, cimInstance);
                case "Msvm_EthernetPortAllocationSettingData":
                    return new MsvmEthernetPortAllocationSettingData(_scope, cimInstance);
                case "Msvm_EmulatedEthernetPortSettingData":
                    return new MsvmEmulatedEthernetPortSettingData(_scope, cimInstance);
                case "Msvm_Synthetic3DDisplayControllerSettingData":
                    return new MsvmSynthetic3DDisplayControllerSettingData(_scope, cimInstance);
                case "Msvm_FcPortAllocationSettingData":
                    return new MsvmFcPortAllocationSettingData(_scope, cimInstance);
                case "Msvm_FlexIoDeviceSettingData":
                    return new MsvmFlexIoDeviceSettingData(_scope, cimInstance);
                case "Msvm_SyntheticFcPortSettingData":
                    return new MsvmSyntheticFcPortSettingData(_scope, cimInstance);
                case "Msvm_BootSourceSettingData":
                    return new MsvmBootSourceSettingData(_scope, cimInstance);
                case "Msvm_VirtualSystemManagementServiceSettingData":
                    return new MsvmVirtualSystemManagementServiceSettingData(_scope, cimInstance);
                case "Msvm_VirtualSystemMigrationServiceSettingData":
                    return new MsvmVirtualSystemMigrationServiceSettingData(_scope, cimInstance);
                case "Msvm_MetricServiceSettingData":
                    return new MsvmMetricServiceSettingData(_scope, cimInstance);
                case "Msvm_VirtualHardDiskSettingData":
                    return new MsvmVirtualHardDiskSettingData(_scope, cimInstance);
                case "Msvm_CopyFileToGuestSettingData":
                    return new MsvmCopyFileToGuestSettingData(_scope, cimInstance);
                case "Msvm_SecuritySettingData":
                    return new MsvmSecuritySettingData(_scope, cimInstance);
                case "Msvm_StorageSettingData":
                    return new MsvmStorageSettingData(_scope, cimInstance);
                case "Msvm_VirtualSystemExportSettingData":
                    return new MsvmVirtualSystemExportSettingData(_scope, cimInstance);
                case "Msvm_FailoverNetworkAdapterSettingData":
                    return new MsvmFailoverNetworkAdapterSettingData(_scope, cimInstance);
                case "Msvm_CollectionReferencePointSettingData":
                    return new MsvmCollectionReferencePointSettingData(_scope, cimInstance);
                case "Msvm_CollectionSnapshotExportSettingData":
                    return new MsvmCollectionSnapshotExportSettingData(_scope, cimInstance);
                case "Msvm_TerminalServiceSettingData":
                    return new MsvmTerminalServiceSettingData(_scope, cimInstance);
                case "Msvm_AssignableDeviceDismountSettingData":
                    return new MsvmAssignableDeviceDismountSettingData(_scope, cimInstance);
                case "Msvm_VirtualSystemMigrationSettingData":
                    return new MsvmVirtualSystemMigrationSettingData(_scope, cimInstance);
                case "Msvm_ResourcePoolSettingData":
                    return new MsvmResourcePoolSettingData(_scope, cimInstance);
                case "Msvm_VirtualSystemReferencePointExportSettingData":
                    return new MsvmVirtualSystemReferencePointExportSettingData(_scope, cimInstance);
                case "Msvm_ReplicationAuthorizationSettingData":
                    return new MsvmReplicationAuthorizationSettingData(_scope, cimInstance);
                case "Msvm_Synthetic3DServiceSettingData":
                    return new MsvmSynthetic3DServiceSettingData(_scope, cimInstance);
                case "Msvm_VirtualSystemMigrationNetworkSettingData":
                    return new MsvmVirtualSystemMigrationNetworkSettingData(_scope, cimInstance);
                case "Msvm_GuestCommunicationServiceSettingData":
                    return new MsvmGuestCommunicationServiceSettingData(_scope, cimInstance);
                case "Msvm_NetworkConnectionDiagnosticSettingData":
                    return new MsvmNetworkConnectionDiagnosticSettingData(_scope, cimInstance);
                case "Msvm_VirtualSystemReferencePointSettingData":
                    return new MsvmVirtualSystemReferencePointSettingData(_scope, cimInstance);
                case "Msvm_CollectionReferencePointExportSettingData":
                    return new MsvmCollectionReferencePointExportSettingData(_scope, cimInstance);
                case "Msvm_VirtualSystemSnapshotSettingData":
                    return new MsvmVirtualSystemSnapshotSettingData(_scope, cimInstance);
                case "Msvm_ReplicationServiceSettingData":
                    return new MsvmReplicationServiceSettingData(_scope, cimInstance);
                case "Msvm_EthernetSwitchPortOffloadData":
                    return new MsvmEthernetSwitchPortOffloadData(_scope, cimInstance);
                case "Msvm_EthernetSwitchPortBandwidthData":
                    return new MsvmEthernetSwitchPortBandwidthData(_scope, cimInstance);
                case "Msvm_EthernetSwitchOperationalData":
                    return new MsvmEthernetSwitchOperationalData(_scope, cimInstance);
                case "Msvm_EthernetSwitchHardwareOffloadData":
                    return new MsvmEthernetSwitchHardwareOffloadData(_scope, cimInstance);
                case "Msvm_EthernetSwitchBandwidthData":
                    return new MsvmEthernetSwitchBandwidthData(_scope, cimInstance);
                case "Msvm_ComputerSystem":
                    return new MsvmComputerSystem(_scope, cimInstance);
                case "Msvm_PlannedComputerSystem":
                    return new MsvmPlannedComputerSystem(_scope, cimInstance);
                case "Msvm_VirtualEthernetSwitch":
                    return new MsvmVirtualEthernetSwitch(_scope, cimInstance);
                case "Msvm_VirtualFcSwitch":
                    return new MsvmVirtualFcSwitch(_scope, cimInstance);
                case "Msvm_PartitionableGpu":
                    return new MsvmPartitionableGpu(_scope, cimInstance);
                case "Msvm_AssignableDeviceService":
                    return new MsvmAssignableDeviceService(_scope, cimInstance);
                case "Msvm_VirtualSystemManagementService":
                    return new MsvmVirtualSystemManagementService(_scope, cimInstance);
                case "Msvm_VirtualEthernetSwitchManagementService":
                    return new MsvmVirtualEthernetSwitchManagementService(_scope, cimInstance);
                case "Msvm_ImageManagementService":
                    return new MsvmImageManagementService(_scope, cimInstance);
                case "Msvm_VirtualSystemMigrationService":
                    return new MsvmVirtualSystemMigrationService(_scope, cimInstance);
                case "Msvm_MetricService":
                    return new MsvmMetricService(_scope, cimInstance);
                case "Msvm_VirtualSystemSnapshotService":
                    return new MsvmVirtualSystemSnapshotService(_scope, cimInstance);
                case "Msvm_CollectionReferencePointService":
                    return new MsvmCollectionReferencePointService(_scope, cimInstance);
                case "Msvm_VirtualSystemReferencePointService":
                    return new MsvmVirtualSystemReferencePointService(_scope, cimInstance);
                case "Msvm_TransparentBridgingService":
                    return new MsvmTransparentBridgingService(_scope, cimInstance);
                case "Msvm_VssService":
                    return new MsvmVssService(_scope, cimInstance);
                case "Msvm_GuestFileService":
                    return new MsvmGuestFileService(_scope, cimInstance);
                case "Msvm_GuestCommunicationService":
                    return new MsvmGuestCommunicationService(_scope, cimInstance);
                case "Msvm_CollectionSnapshotService":
                    return new MsvmCollectionSnapshotService(_scope, cimInstance);
                case "Msvm_ResourcePoolConfigurationService":
                    return new MsvmResourcePoolConfigurationService(_scope, cimInstance);
                case "Msvm_Synthetic3DService":
                    return new MsvmSynthetic3DService(_scope, cimInstance);
                case "Msvm_ReplicationService":
                    return new MsvmReplicationService(_scope, cimInstance);
                case "Msvm_CollectionManagementService":
                    return new MsvmCollectionManagementService(_scope, cimInstance);
                case "Msvm_SecurityService":
                    return new MsvmSecurityService(_scope, cimInstance);
                case "Msvm_TerminalService":
                    return new MsvmTerminalService(_scope, cimInstance);
                case "Msvm_ShutdownComponent":
                    return new MsvmShutdownComponent(_scope, cimInstance);
                case "Msvm_TimeSyncComponent":
                    return new MsvmTimeSyncComponent(_scope, cimInstance);
                case "Msvm_GpuPartition":
                    return new MsvmGpuPartition(_scope, cimInstance);
                case "Msvm_HeartbeatComponent":
                    return new MsvmHeartbeatComponent(_scope, cimInstance);
                case "Msvm_Keyboard":
                    return new MsvmKeyboard(_scope, cimInstance);
                case "Msvm_Ps2Mouse":
                    return new MsvmPs2Mouse(_scope, cimInstance);
                case "Msvm_SyntheticMouse":
                    return new MsvmSyntheticMouse(_scope, cimInstance);
                case "Msvm_SyntheticKeyboard":
                    return new MsvmSyntheticKeyboard(_scope, cimInstance);
                case "Msvm_TPM":
                    return new MsvmTPM(_scope, cimInstance);
                case "Msvm_FlexIoDevice":
                    return new MsvmFlexIoDevice(_scope, cimInstance);
                case "Msvm_PciExpress":
                    return new MsvmPciExpress(_scope, cimInstance);
                case "Msvm_SCSIProtocolController":
                    return new MsvmSCSIProtocolController(_scope, cimInstance);
                case "Msvm_KvpExchangeComponent":
                    return new MsvmKvpExchangeComponent(_scope, cimInstance);
                case "Msvm_Physical3dGraphicsProcessor":
                    return new MsvmPhysical3dGraphicsProcessor(_scope, cimInstance);
                case "Msvm_VssComponent":
                    return new MsvmVssComponent(_scope, cimInstance);
                case "Msvm_DiskDrive":
                    return new MsvmDiskDrive(_scope, cimInstance);
                case "Msvm_DisketteDrive":
                    return new MsvmDisketteDrive(_scope, cimInstance);
                case "Msvm_DVDDrive":
                    return new MsvmDVDDrive(_scope, cimInstance);
                case "Msvm_Battery":
                    return new MsvmBattery(_scope, cimInstance);
                case "Msvm_VideoHead":
                    return new MsvmVideoHead(_scope, cimInstance);
                case "Msvm_IDEController":
                    return new MsvmIDEController(_scope, cimInstance);
                case "Msvm_S3DisplayController":
                    return new MsvmS3DisplayController(_scope, cimInstance);
                case "Msvm_Synthetic3DDisplayController":
                    return new MsvmSynthetic3DDisplayController(_scope, cimInstance);
                case "Msvm_SyntheticDisplayController":
                    return new MsvmSyntheticDisplayController(_scope, cimInstance);
                case "Msvm_PersistentMemoryController":
                    return new MsvmPersistentMemoryController(_scope, cimInstance);
                case "Msvm_SerialController":
                    return new MsvmSerialController(_scope, cimInstance);
                case "Msvm_DisketteController":
                    return new MsvmDisketteController(_scope, cimInstance);
                case "Msvm_RdvComponent":
                    return new MsvmRdvComponent(_scope, cimInstance);
                case "Msvm_EthernetSwitchPort":
                    return new MsvmEthernetSwitchPort(_scope, cimInstance);
                case "Msvm_InternalEthernetPort":
                    return new MsvmInternalEthernetPort(_scope, cimInstance);
                case "Msvm_SyntheticEthernetPort":
                    return new MsvmSyntheticEthernetPort(_scope, cimInstance);
                case "Msvm_ExternalEthernetPort":
                    return new MsvmExternalEthernetPort(_scope, cimInstance);
                case "Msvm_EmulatedEthernetPort":
                    return new MsvmEmulatedEthernetPort(_scope, cimInstance);
                case "Msvm_SyntheticFcPort":
                    return new MsvmSyntheticFcPort(_scope, cimInstance);
                case "Msvm_FcSwitchPort":
                    return new MsvmFcSwitchPort(_scope, cimInstance);
                case "Msvm_ExternalFcPort":
                    return new MsvmExternalFcPort(_scope, cimInstance);
                case "Msvm_WiFiPort":
                    return new MsvmWiFiPort(_scope, cimInstance);
                case "Msvm_SerialPort":
                    return new MsvmSerialPort(_scope, cimInstance);
                case "Msvm_GuestServiceInterfaceComponent":
                    return new MsvmGuestServiceInterfaceComponent(_scope, cimInstance);
                case "Msvm_Memory":
                    return new MsvmMemory(_scope, cimInstance);
                case "Msvm_LogicalDisk":
                    return new MsvmLogicalDisk(_scope, cimInstance);
                case "Msvm_Processor":
                    return new MsvmProcessor(_scope, cimInstance);
                case "Msvm_TerminalConnection":
                    return new MsvmTerminalConnection(_scope, cimInstance);
                case "Msvm_EthernetSwitchExtension":
                    return new MsvmEthernetSwitchExtension(_scope, cimInstance);
                case "Msvm_FcEndpoint":
                    return new MsvmFcEndpoint(_scope, cimInstance);
                case "Msvm_WiFiEndpoint":
                    return new MsvmWiFiEndpoint(_scope, cimInstance);
                case "Msvm_LANEndpoint":
                    return new MsvmLANEndpoint(_scope, cimInstance);
                case "Msvm_VLANEndpoint":
                    return new MsvmVLANEndpoint(_scope, cimInstance);
                case "Msvm_NumaNode":
                    return new MsvmNumaNode(_scope, cimInstance);
                case "Msvm_SecurityElement":
                    return new MsvmSecurityElement(_scope, cimInstance);
                case "Msvm_ConcreteJob":
                    return new MsvmConcreteJob(_scope, cimInstance);
                case "Msvm_MigrationJob":
                    return new MsvmMigrationJob(_scope, cimInstance);
                case "Msvm_CopyFileToGuestJob":
                    return new MsvmCopyFileToGuestJob(_scope, cimInstance);
                case "Msvm_StorageJob":
                    return new MsvmStorageJob(_scope, cimInstance);
                case "Msvm_CollectionReferencePointExportJob":
                    return new MsvmCollectionReferencePointExportJob(_scope, cimInstance);
                case "Msvm_VirtualSystemReferencePointExportJob":
                    return new MsvmVirtualSystemReferencePointExportJob(_scope, cimInstance);
                case "Msvm_Synth3dVideoPool":
                    return new MsvmSynth3dVideoPool(_scope, cimInstance);
                case "Msvm_ProcessorPool":
                    return new MsvmProcessorPool(_scope, cimInstance);
                case "Msvm_ResourcePool":
                    return new MsvmResourcePool(_scope, cimInstance);
                case "Msvm_DynamicForwardingEntry":
                    return new MsvmDynamicForwardingEntry(_scope, cimInstance);
                case "Msvm_MountedStorageImage":
                    return new MsvmMountedStorageImage(_scope, cimInstance);
                case "Msvm_BIOSElement":
                    return new MsvmBIOSElement(_scope, cimInstance);
                case "Msvm_ReplicationRelationship":
                    return new MsvmReplicationRelationship(_scope, cimInstance);
                case "Msvm_ReplicationProvider":
                    return new MsvmReplicationProvider(_scope, cimInstance);
                case "Msvm_InstalledEthernetSwitchExtension":
                    return new MsvmInstalledEthernetSwitchExtension(_scope, cimInstance);
                case "Msvm_SummaryInformation":
                    return new MsvmSummaryInformation(_scope, cimInstance);
                case "Msvm_VirtualSystemManagementCapabilities":
                    return new MsvmVirtualSystemManagementCapabilities(_scope, cimInstance);
                case "Msvm_VirtualEthernetSwitchManagementCapabilities":
                    return new MsvmVirtualEthernetSwitchManagementCapabilities(_scope, cimInstance);
                case "Msvm_VirtualSystemCapabilities":
                    return new MsvmVirtualSystemCapabilities(_scope, cimInstance);
                case "Msvm_MetricServiceCapabilities":
                    return new MsvmMetricServiceCapabilities(_scope, cimInstance);
                case "Msvm_AllocationCapabilities":
                    return new MsvmAllocationCapabilities(_scope, cimInstance);
                case "Msvm_ExternalEthernetPortCapabilities":
                    return new MsvmExternalEthernetPortCapabilities(_scope, cimInstance);
                case "Msvm_ResourcePoolConfigurationCapabilities":
                    return new MsvmResourcePoolConfigurationCapabilities(_scope, cimInstance);
                case "Msvm_VirtualSystemMigrationCapabilities":
                    return new MsvmVirtualSystemMigrationCapabilities(_scope, cimInstance);
                case "Msvm_EthernetSwitchFeatureCapabilities":
                    return new MsvmEthernetSwitchFeatureCapabilities(_scope, cimInstance);
                case "Msvm_VirtualSystemReferencePoint":
                    return new MsvmVirtualSystemReferencePoint(_scope, cimInstance);
                case "Msvm_ReplicationStatistics":
                    return new MsvmReplicationStatistics(_scope, cimInstance);
                case "Msvm_PhysicalGPUInfo":
                    return new MsvmPhysicalGPUInfo(_scope, cimInstance);
                case "Msvm_AggregationMetricDefinition":
                    return new MsvmAggregationMetricDefinition(_scope, cimInstance);
                case "Msvm_BaseMetricDefinition":
                    return new MsvmBaseMetricDefinition(_scope, cimInstance);
                case "Msvm_NumaNodeTopology":
                    return new MsvmNumaNodeTopology(_scope, cimInstance);
                case "Msvm_SnapshotCollection":
                    return new MsvmSnapshotCollection(_scope, cimInstance);
                case "Msvm_VirtualSystemCollection":
                    return new MsvmVirtualSystemCollection(_scope, cimInstance);
                case "Msvm_ManagementCollection":
                    return new MsvmManagementCollection(_scope, cimInstance);
                case "Msvm_ReferencePointCollection":
                    return new MsvmReferencePointCollection(_scope, cimInstance);
                case "Msvm_AggregationMetricValue":
                    return new MsvmAggregationMetricValue(_scope, cimInstance);
                case "Msvm_BaseMetricValue":
                    return new MsvmBaseMetricValue(_scope, cimInstance);
                case "Msvm_MoveUnmanagedVhd":
                    return new MsvmMoveUnmanagedVhd(_scope, cimInstance);
                case "Msvm_KvpExchangeDataItem":
                    return new MsvmKvpExchangeDataItem(_scope, cimInstance);
                case "Msvm_CollectedVirtualSystems":
                    return new MsvmCollectedVirtualSystems(_scope, cimInstance);
                case "Msvm_CollectedSnapshots":
                    return new MsvmCollectedSnapshots(_scope, cimInstance);
                case "Msvm_CollectedCollections":
                    return new MsvmCollectedCollections(_scope, cimInstance);
                case "Msvm_CollectedReferencePoints":
                    return new MsvmCollectedReferencePoints(_scope, cimInstance);
                case "Msvm_HostedResourcePool":
                    return new MsvmHostedResourcePool(_scope, cimInstance);
                case "Msvm_SystemBIOS":
                    return new MsvmSystemBIOS(_scope, cimInstance);
                case "Msvm_SystemComponent":
                    return new MsvmSystemComponent(_scope, cimInstance);
                case "Msvm_SystemDevice":
                    return new MsvmSystemDevice(_scope, cimInstance);
                case "Msvm_BootSourceComponent":
                    return new MsvmBootSourceComponent(_scope, cimInstance);
                case "Msvm_ConcreteComponent":
                    return new MsvmConcreteComponent(_scope, cimInstance);
                case "Msvm_SettingsDefineCapabilities":
                    return new MsvmSettingsDefineCapabilities(_scope, cimInstance);
                case "Msvm_FeatureSettingsDefineCapabilities":
                    return new MsvmFeatureSettingsDefineCapabilities(_scope, cimInstance);
                case "Msvm_VirtualSystemSettingDataComponent":
                    return new MsvmVirtualSystemSettingDataComponent(_scope, cimInstance);
                case "Msvm_GuestServiceInterfaceSettingDataComponent":
                    return new MsvmGuestServiceInterfaceSettingDataComponent(_scope, cimInstance);
                case "Msvm_SettingDataComponent":
                    return new MsvmSettingDataComponent(_scope, cimInstance);
                case "Msvm_EthernetPortFailoverSettingDataComponent":
                    return new MsvmEthernetPortFailoverSettingDataComponent(_scope, cimInstance);
                case "Msvm_EthernetPortSettingDataComponent":
                    return new MsvmEthernetPortSettingDataComponent(_scope, cimInstance);
                case "Msvm_VirtualEthernetSwitchSettingDataComponent":
                    return new MsvmVirtualEthernetSwitchSettingDataComponent(_scope, cimInstance);
                case "Msvm_VirtualSystemMigrationServiceSettingDataComponent":
                    return new MsvmVirtualSystemMigrationServiceSettingDataComponent(_scope, cimInstance);
                case "Msvm_SystemTerminalConnection":
                    return new MsvmSystemTerminalConnection(_scope, cimInstance);
                case "Msvm_HostedService":
                    return new MsvmHostedService(_scope, cimInstance);
                case "Msvm_HostedSwitchService":
                    return new MsvmHostedSwitchService(_scope, cimInstance);
                case "Msvm_HostedDependency":
                    return new MsvmHostedDependency(_scope, cimInstance);
                case "Msvm_SerialPortOnSerialController":
                    return new MsvmSerialPortOnSerialController(_scope, cimInstance);
                case "Msvm_VideoHeadOnController":
                    return new MsvmVideoHeadOnController(_scope, cimInstance);
                case "Msvm_HostedEthernetSwitchExtension":
                    return new MsvmHostedEthernetSwitchExtension(_scope, cimInstance);
                case "Msvm_ReferencePointOfVirtualSystem":
                    return new MsvmReferencePointOfVirtualSystem(_scope, cimInstance);
                case "Msvm_SystemReplicationRelationship":
                    return new MsvmSystemReplicationRelationship(_scope, cimInstance);
                case "Msvm_SnapshotOfVirtualSystem":
                    return new MsvmSnapshotOfVirtualSystem(_scope, cimInstance);
                case "Msvm_ComputerSystemSummaryInformation":
                    return new MsvmComputerSystemSummaryInformation(_scope, cimInstance);
                case "Msvm_LastAppliedSnapshot":
                    return new MsvmLastAppliedSnapshot(_scope, cimInstance);
                case "CIM_MostCurrentSnapshotInBranch":
                    return new CIMMostCurrentSnapshotInBranch(_scope, cimInstance);
                case "Msvm_MostCurrentSnapshotInBranch":
                    return new MsvmMostCurrentSnapshotInBranch(_scope, cimInstance);
                case "Msvm_ReplicaSystemDependency":
                    return new MsvmReplicaSystemDependency(_scope, cimInstance);
                case "Msvm_ElementAllocatedFromNumaNode":
                    return new MsvmElementAllocatedFromNumaNode(_scope, cimInstance);
                case "Msvm_ElementAllocatedFromPool":
                    return new MsvmElementAllocatedFromPool(_scope, cimInstance);
                case "Msvm_MetricDefForME":
                    return new MsvmMetricDefForME(_scope, cimInstance);
                case "Msvm_MetricCollectionDependency":
                    return new MsvmMetricCollectionDependency(_scope, cimInstance);
                case "Msvm_MetricForME":
                    return new MsvmMetricForME(_scope, cimInstance);
                case "Msvm_ConcreteDependency":
                    return new MsvmConcreteDependency(_scope, cimInstance);
                case "Msvm_ParentChildSettingData":
                    return new MsvmParentChildSettingData(_scope, cimInstance);
                case "Msvm_ResourceAllocationFromPool":
                    return new MsvmResourceAllocationFromPool(_scope, cimInstance);
                case "Msvm_ResourceDependentOnResource":
                    return new MsvmResourceDependentOnResource(_scope, cimInstance);
                case "Msvm_ActiveConnection":
                    return new MsvmActiveConnection(_scope, cimInstance);
                case "Msvm_FcActiveConnection":
                    return new MsvmFcActiveConnection(_scope, cimInstance);
                case "Msvm_BindsToLANEndpoint":
                    return new MsvmBindsToLANEndpoint(_scope, cimInstance);
                case "Msvm_SwitchPortDynamicForwarding":
                    return new MsvmSwitchPortDynamicForwarding(_scope, cimInstance);
                case "Msvm_ServiceOfVssComponent":
                    return new MsvmServiceOfVssComponent(_scope, cimInstance);
                case "Msvm_ProtocolControllerForUnit":
                    return new MsvmProtocolControllerForUnit(_scope, cimInstance);
                case "Msvm_ReferencePointOfVirtualSystemCollection":
                    return new MsvmReferencePointOfVirtualSystemCollection(_scope, cimInstance);
                case "Msvm_VirtualEthernetSwitchNicTeamingMember":
                    return new MsvmVirtualEthernetSwitchNicTeamingMember(_scope, cimInstance);
                case "Msvm_EthernetDeviceSAPImplementation":
                    return new MsvmEthernetDeviceSAPImplementation(_scope, cimInstance);
                case "Msvm_WiFiDeviceSAPImplementation":
                    return new MsvmWiFiDeviceSAPImplementation(_scope, cimInstance);
                case "Msvm_FcDeviceSAPImplementation":
                    return new MsvmFcDeviceSAPImplementation(_scope, cimInstance);
                case "Msvm_DeviceSAPImplementation":
                    return new MsvmDeviceSAPImplementation(_scope, cimInstance);
                case "Msvm_MetricInstance":
                    return new MsvmMetricInstance(_scope, cimInstance);
                case "Msvm_ParentEthernetSwitchExtension":
                    return new MsvmParentEthernetSwitchExtension(_scope, cimInstance);
                case "Msvm_EthernetSwitchInfo":
                    return new MsvmEthernetSwitchInfo(_scope, cimInstance);
                case "Msvm_BasedOn":
                    return new MsvmBasedOn(_scope, cimInstance);
                case "Msvm_RegisteredGuestService":
                    return new MsvmRegisteredGuestService(_scope, cimInstance);
                case "Msvm_ControlledBy":
                    return new MsvmControlledBy(_scope, cimInstance);
                case "Msvm_SnapshotOfVirtualSystemCollection":
                    return new MsvmSnapshotOfVirtualSystemCollection(_scope, cimInstance);
                case "Msvm_EthernetPortInfo":
                    return new MsvmEthernetPortInfo(_scope, cimInstance);
                case "Msvm_MediaPresent":
                    return new MsvmMediaPresent(_scope, cimInstance);
                case "Msvm_TransparentBridgingDynamicForwarding":
                    return new MsvmTransparentBridgingDynamicForwarding(_scope, cimInstance);
                case "Msvm_ElementConformsToProfile":
                    return new MsvmElementConformsToProfile(_scope, cimInstance);
                case "Msvm_SystemExportSettingData":
                    return new MsvmSystemExportSettingData(_scope, cimInstance);
                case "Msvm_ElementSettingData":
                    return new MsvmElementSettingData(_scope, cimInstance);
                case "Msvm_AffectedStorageJobElement":
                    return new MsvmAffectedStorageJobElement(_scope, cimInstance);
                case "Msvm_AffectedJobElement":
                    return new MsvmAffectedJobElement(_scope, cimInstance);
                case "Msvm_LogicalIdentity":
                    return new MsvmLogicalIdentity(_scope, cimInstance);
                case "Msvm_SettingsDefineState":
                    return new MsvmSettingsDefineState(_scope, cimInstance);
                case "Msvm_ServiceAffectsElement":
                    return new MsvmServiceAffectsElement(_scope, cimInstance);
                case "Msvm_ElementCapabilities":
                    return new MsvmElementCapabilities(_scope, cimInstance);
                case "Msvm_EthernetSwitchExtensionCapabilities":
                    return new MsvmEthernetSwitchExtensionCapabilities(_scope, cimInstance);
                case "Msvm_OwningJobElement":
                    return new MsvmOwningJobElement(_scope, cimInstance);
                case "MSFT_WmiError":
                    return new MSFTWmiError(_scope, cimInstance);
                case "MSFT_ExtendedStatus":
                    return new MSFTExtendedStatus(_scope, cimInstance);
                case "Msvm_Error":
                    return new MsvmError(_scope, cimInstance);
                case "Msvm_VirtualHardDiskState":
                    return new MsvmVirtualHardDiskState(_scope, cimInstance);
                case "Msvm_GuestNetworkAdapterConfiguration":
                    return new MsvmGuestNetworkAdapterConfiguration(_scope, cimInstance);
                case "__ExtendedStatus":
                    return new ExtendedStatus(_scope, cimInstance);
                case "__NTLMUser9X":
                    return new NTLMUser9X(_scope, cimInstance);
                case "Msvm_GuestClusterInformation":
                    return new MsvmGuestClusterInformation(_scope, cimInstance);
                case "Msvm_CompatibilityVector":
                    return new MsvmCompatibilityVector(_scope, cimInstance);
                case "Msvm_VHDSetInformation":
                    return new MsvmVHDSetInformation(_scope, cimInstance);
                case "Msvm_VHDSnapshotInformation":
                    return new MsvmVHDSnapshotInformation(_scope, cimInstance);
                case "Msvm_InteractiveSessionACE":
                    return new MsvmInteractiveSessionACE(_scope, cimInstance);
                case "Msvm_VirtualMachineToDisks":
                    return new MsvmVirtualMachineToDisks(_scope, cimInstance);
                case "Msvm_NetworkConnectionDiagnosticInformation":
                    return new MsvmNetworkConnectionDiagnosticInformation(_scope, cimInstance);
                case "Msvm_ServicingSettings":
                    return new MsvmServicingSettings(_scope, cimInstance);
                default:
                    throw new KeyNotFoundException();
            }
        }

        private static Dictionary<Type, (string, string)> _typeMap = new Dictionary<Type, (string, string)>{ { typeof ( SystemClass ) ,  ( "root/virtualization/v2" ,  "__SystemClass" ) }
        ,  { typeof ( ThisNAMESPACE ) ,  ( "root/virtualization/v2" ,  "__thisNAMESPACE" ) }
        ,  { typeof ( NAMESPACE ) ,  ( "root/virtualization/v2" ,  "__NAMESPACE" ) }
        ,  { typeof ( Provider ) ,  ( "root/virtualization/v2" ,  "__Provider" ) }
        ,  { typeof ( Win32Provider ) ,  ( "root/virtualization/v2" ,  "__Win32Provider" ) }
        ,  { typeof ( ProviderRegistration ) ,  ( "root/virtualization/v2" ,  "__ProviderRegistration" ) }
        ,  { typeof ( EventProviderRegistration ) ,  ( "root/virtualization/v2" ,  "__EventProviderRegistration" ) }
        ,  { typeof ( ObjectProviderRegistration ) ,  ( "root/virtualization/v2" ,  "__ObjectProviderRegistration" ) }
        ,  { typeof ( ClassProviderRegistration ) ,  ( "root/virtualization/v2" ,  "__ClassProviderRegistration" ) }
        ,  { typeof ( InstanceProviderRegistration ) ,  ( "root/virtualization/v2" ,  "__InstanceProviderRegistration" ) }
        ,  { typeof ( MethodProviderRegistration ) ,  ( "root/virtualization/v2" ,  "__MethodProviderRegistration" ) }
        ,  { typeof ( PropertyProviderRegistration ) ,  ( "root/virtualization/v2" ,  "__PropertyProviderRegistration" ) }
        ,  { typeof ( EventConsumerProviderRegistration ) ,  ( "root/virtualization/v2" ,  "__EventConsumerProviderRegistration" ) }
        ,  { typeof ( IndicationRelated ) ,  ( "root/virtualization/v2" ,  "__IndicationRelated" ) }
        ,  { typeof ( EventFilter ) ,  ( "root/virtualization/v2" ,  "__EventFilter" ) }
        ,  { typeof ( EventConsumer ) ,  ( "root/virtualization/v2" ,  "__EventConsumer" ) }
        ,  { typeof ( FilterToConsumerBinding ) ,  ( "root/virtualization/v2" ,  "__FilterToConsumerBinding" ) }
        ,  { typeof ( Event ) ,  ( "root/virtualization/v2" ,  "__Event" ) }
        ,  { typeof ( InstanceOperationEvent ) ,  ( "root/virtualization/v2" ,  "__InstanceOperationEvent" ) }
        ,  { typeof ( InstanceCreationEvent ) ,  ( "root/virtualization/v2" ,  "__InstanceCreationEvent" ) }
        ,  { typeof ( InstanceDeletionEvent ) ,  ( "root/virtualization/v2" ,  "__InstanceDeletionEvent" ) }
        ,  { typeof ( InstanceModificationEvent ) ,  ( "root/virtualization/v2" ,  "__InstanceModificationEvent" ) }
        ,  { typeof ( MethodInvocationEvent ) ,  ( "root/virtualization/v2" ,  "__MethodInvocationEvent" ) }
        ,  { typeof ( ExtrinsicEvent ) ,  ( "root/virtualization/v2" ,  "__ExtrinsicEvent" ) }
        ,  { typeof ( CIMIndication ) ,  ( "root/virtualization/v2" ,  "CIM_Indication" ) }
        ,  { typeof ( CIMProcessIndication ) ,  ( "root/virtualization/v2" ,  "CIM_ProcessIndication" ) }
        ,  { typeof ( CIMAlertIndication ) ,  ( "root/virtualization/v2" ,  "CIM_AlertIndication" ) }
        ,  { typeof ( MsvmStorageAlert ) ,  ( "root/virtualization/v2" ,  "Msvm_StorageAlert" ) }
        ,  { typeof ( CIMClassIndication ) ,  ( "root/virtualization/v2" ,  "CIM_ClassIndication" ) }
        ,  { typeof ( CIMClassDeletion ) ,  ( "root/virtualization/v2" ,  "CIM_ClassDeletion" ) }
        ,  { typeof ( CIMClassCreation ) ,  ( "root/virtualization/v2" ,  "CIM_ClassCreation" ) }
        ,  { typeof ( CIMClassModification ) ,  ( "root/virtualization/v2" ,  "CIM_ClassModification" ) }
        ,  { typeof ( CIMInstIndication ) ,  ( "root/virtualization/v2" ,  "CIM_InstIndication" ) }
        ,  { typeof ( CIMInstCreation ) ,  ( "root/virtualization/v2" ,  "CIM_InstCreation" ) }
        ,  { typeof ( CIMInstModification ) ,  ( "root/virtualization/v2" ,  "CIM_InstModification" ) }
        ,  { typeof ( CIMInstDeletion ) ,  ( "root/virtualization/v2" ,  "CIM_InstDeletion" ) }
        ,  { typeof ( SystemEvent ) ,  ( "root/virtualization/v2" ,  "__SystemEvent" ) }
        ,  { typeof ( EventDroppedEvent ) ,  ( "root/virtualization/v2" ,  "__EventDroppedEvent" ) }
        ,  { typeof ( EventQueueOverflowEvent ) ,  ( "root/virtualization/v2" ,  "__EventQueueOverflowEvent" ) }
        ,  { typeof ( QOSFailureEvent ) ,  ( "root/virtualization/v2" ,  "__QOSFailureEvent" ) }
        ,  { typeof ( ConsumerFailureEvent ) ,  ( "root/virtualization/v2" ,  "__ConsumerFailureEvent" ) }
        ,  { typeof ( ClassOperationEvent ) ,  ( "root/virtualization/v2" ,  "__ClassOperationEvent" ) }
        ,  { typeof ( ClassDeletionEvent ) ,  ( "root/virtualization/v2" ,  "__ClassDeletionEvent" ) }
        ,  { typeof ( ClassModificationEvent ) ,  ( "root/virtualization/v2" ,  "__ClassModificationEvent" ) }
        ,  { typeof ( ClassCreationEvent ) ,  ( "root/virtualization/v2" ,  "__ClassCreationEvent" ) }
        ,  { typeof ( NamespaceOperationEvent ) ,  ( "root/virtualization/v2" ,  "__NamespaceOperationEvent" ) }
        ,  { typeof ( NamespaceModificationEvent ) ,  ( "root/virtualization/v2" ,  "__NamespaceModificationEvent" ) }
        ,  { typeof ( NamespaceDeletionEvent ) ,  ( "root/virtualization/v2" ,  "__NamespaceDeletionEvent" ) }
        ,  { typeof ( NamespaceCreationEvent ) ,  ( "root/virtualization/v2" ,  "__NamespaceCreationEvent" ) }
        ,  { typeof ( TimerEvent ) ,  ( "root/virtualization/v2" ,  "__TimerEvent" ) }
        ,  { typeof ( AggregateEvent ) ,  ( "root/virtualization/v2" ,  "__AggregateEvent" ) }
        ,  { typeof ( TimerNextFiring ) ,  ( "root/virtualization/v2" ,  "__TimerNextFiring" ) }
        ,  { typeof ( EventGenerator ) ,  ( "root/virtualization/v2" ,  "__EventGenerator" ) }
        ,  { typeof ( TimerInstruction ) ,  ( "root/virtualization/v2" ,  "__TimerInstruction" ) }
        ,  { typeof ( AbsoluteTimerInstruction ) ,  ( "root/virtualization/v2" ,  "__AbsoluteTimerInstruction" ) }
        ,  { typeof ( IntervalTimerInstruction ) ,  ( "root/virtualization/v2" ,  "__IntervalTimerInstruction" ) }
        ,  { typeof ( SystemSecurity ) ,  ( "root/virtualization/v2" ,  "__SystemSecurity" ) }
        ,  { typeof ( CIMManagedElement ) ,  ( "root/virtualization/v2" ,  "CIM_ManagedElement" ) }
        ,  { typeof ( CIMSettingData ) ,  ( "root/virtualization/v2" ,  "CIM_SettingData" ) }
        ,  { typeof ( MsvmFeatureSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_FeatureSettingData" ) }
        ,  { typeof ( MsvmEthernetSwitchFeatureSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchFeatureSettingData" ) }
        ,  { typeof ( MsvmVirtualEthernetSwitchNicTeamingSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualEthernetSwitchNicTeamingSettingData" ) }
        ,  { typeof ( MsvmVirtualEthernetSwitchBandwidthSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualEthernetSwitchBandwidthSettingData" ) }
        ,  { typeof ( MsvmEthernetSwitchHardwareOffloadSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchHardwareOffloadSettingData" ) }
        ,  { typeof ( MsvmEthernetSwitchPortFeatureSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchPortFeatureSettingData" ) }
        ,  { typeof ( MsvmEthernetSwitchPortTeamMappingSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchPortTeamMappingSettingData" ) }
        ,  { typeof ( MsvmEthernetSwitchPortIsolationSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchPortIsolationSettingData" ) }
        ,  { typeof ( MsvmEthernetSwitchPortVlanSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchPortVlanSettingData" ) }
        ,  { typeof ( MsvmEthernetSwitchPortAclSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchPortAclSettingData" ) }
        ,  { typeof ( MsvmEthernetSwitchPortRdmaSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchPortRdmaSettingData" ) }
        ,  { typeof ( MsvmEthernetSwitchPortBandwidthSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchPortBandwidthSettingData" ) }
        ,  { typeof ( MsvmEthernetSwitchPortExtendedAclSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchPortExtendedAclSettingData" ) }
        ,  { typeof ( MsvmEthernetSwitchPortRoutingDomainSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchPortRoutingDomainSettingData" ) }
        ,  { typeof ( MsvmEthernetSwitchPortProfileSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchPortProfileSettingData" ) }
        ,  { typeof ( MsvmEthernetSwitchPortOffloadSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchPortOffloadSettingData" ) }
        ,  { typeof ( MsvmEthernetSwitchPortSecuritySettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchPortSecuritySettingData" ) }
        ,  { typeof ( CIMVirtualSystemSettingData ) ,  ( "root/virtualization/v2" ,  "CIM_VirtualSystemSettingData" ) }
        ,  { typeof ( MsvmReplicationSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_ReplicationSettingData" ) }
        ,  { typeof ( MsvmVirtualSystemSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemSettingData" ) }
        ,  { typeof ( CIMVirtualEthernetSwitchSettingData ) ,  ( "root/virtualization/v2" ,  "CIM_VirtualEthernetSwitchSettingData" ) }
        ,  { typeof ( MsvmVirtualEthernetSwitchSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualEthernetSwitchSettingData" ) }
        ,  { typeof ( MsvmVirtualFcSwitchSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualFcSwitchSettingData" ) }
        ,  { typeof ( MsvmDiskMergeSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_DiskMergeSettingData" ) }
        ,  { typeof ( CIMResourceAllocationSettingData ) ,  ( "root/virtualization/v2" ,  "CIM_ResourceAllocationSettingData" ) }
        ,  { typeof ( MsvmResourceAllocationSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_ResourceAllocationSettingData" ) }
        ,  { typeof ( MsvmSerialPortSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_SerialPortSettingData" ) }
        ,  { typeof ( MsvmGuestServiceInterfaceComponentSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_GuestServiceInterfaceComponentSettingData" ) }
        ,  { typeof ( MsvmHeartbeatComponentSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_HeartbeatComponentSettingData" ) }
        ,  { typeof ( MsvmKvpExchangeComponentSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_KvpExchangeComponentSettingData" ) }
        ,  { typeof ( MsvmShutdownComponentSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_ShutdownComponentSettingData" ) }
        ,  { typeof ( MsvmTimeSyncComponentSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_TimeSyncComponentSettingData" ) }
        ,  { typeof ( MsvmVssComponentSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_VssComponentSettingData" ) }
        ,  { typeof ( MsvmRdvComponentSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_RdvComponentSettingData" ) }
        ,  { typeof ( MsvmBatterySettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_BatterySettingData" ) }
        ,  { typeof ( CIMStorageAllocationSettingData ) ,  ( "root/virtualization/v2" ,  "CIM_StorageAllocationSettingData" ) }
        ,  { typeof ( MsvmStorageAllocationSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_StorageAllocationSettingData" ) }
        ,  { typeof ( MsvmMemorySettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_MemorySettingData" ) }
        ,  { typeof ( MsvmProcessorSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_ProcessorSettingData" ) }
        ,  { typeof ( MsvmVirtualLogicalUnitSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualLogicalUnitSettingData" ) }
        ,  { typeof ( MsvmSyntheticDisplayControllerSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_SyntheticDisplayControllerSettingData" ) }
        ,  { typeof ( MsvmPciExpressSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_PciExpressSettingData" ) }
        ,  { typeof ( MsvmGpuPartitionSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_GpuPartitionSettingData" ) }
        ,  { typeof ( CIMEthernetPortAllocationSettingData ) ,  ( "root/virtualization/v2" ,  "CIM_EthernetPortAllocationSettingData" ) }
        ,  { typeof ( MsvmSyntheticEthernetPortSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_SyntheticEthernetPortSettingData" ) }
        ,  { typeof ( MsvmEthernetPortAllocationSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetPortAllocationSettingData" ) }
        ,  { typeof ( MsvmEmulatedEthernetPortSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_EmulatedEthernetPortSettingData" ) }
        ,  { typeof ( MsvmSynthetic3DDisplayControllerSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_Synthetic3DDisplayControllerSettingData" ) }
        ,  { typeof ( MsvmFcPortAllocationSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_FcPortAllocationSettingData" ) }
        ,  { typeof ( MsvmFlexIoDeviceSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_FlexIoDeviceSettingData" ) }
        ,  { typeof ( MsvmSyntheticFcPortSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_SyntheticFcPortSettingData" ) }
        ,  { typeof ( MsvmBootSourceSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_BootSourceSettingData" ) }
        ,  { typeof ( MsvmVirtualSystemManagementServiceSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemManagementServiceSettingData" ) }
        ,  { typeof ( MsvmVirtualSystemMigrationServiceSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemMigrationServiceSettingData" ) }
        ,  { typeof ( MsvmMetricServiceSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_MetricServiceSettingData" ) }
        ,  { typeof ( MsvmVirtualHardDiskSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualHardDiskSettingData" ) }
        ,  { typeof ( CIMVLANEndpointSettingData ) ,  ( "root/virtualization/v2" ,  "CIM_VLANEndpointSettingData" ) }
        ,  { typeof ( MsvmCopyFileToGuestSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_CopyFileToGuestSettingData" ) }
        ,  { typeof ( MsvmSecuritySettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_SecuritySettingData" ) }
        ,  { typeof ( MsvmSystemComponentSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_SystemComponentSettingData" ) }
        ,  { typeof ( MsvmStorageSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_StorageSettingData" ) }
        ,  { typeof ( MsvmVirtualSystemExportSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemExportSettingData" ) }
        ,  { typeof ( MsvmFailoverNetworkAdapterSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_FailoverNetworkAdapterSettingData" ) }
        ,  { typeof ( MsvmCollectionReferencePointSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_CollectionReferencePointSettingData" ) }
        ,  { typeof ( MsvmCollectionSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_CollectionSettingData" ) }
        ,  { typeof ( MsvmCollectionSnapshotExportSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_CollectionSnapshotExportSettingData" ) }
        ,  { typeof ( MsvmTerminalServiceSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_TerminalServiceSettingData" ) }
        ,  { typeof ( MsvmAssignableDeviceDismountSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_AssignableDeviceDismountSettingData" ) }
        ,  { typeof ( CIMVirtualSystemMigrationSettingData ) ,  ( "root/virtualization/v2" ,  "CIM_VirtualSystemMigrationSettingData" ) }
        ,  { typeof ( MsvmVirtualSystemMigrationSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemMigrationSettingData" ) }
        ,  { typeof ( MsvmAbstractResourcePoolSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_AbstractResourcePoolSettingData" ) }
        ,  { typeof ( MsvmResourcePoolSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_ResourcePoolSettingData" ) }
        ,  { typeof ( MsvmVirtualSystemReferencePointExportSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemReferencePointExportSettingData" ) }
        ,  { typeof ( MsvmReplicationAuthorizationSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_ReplicationAuthorizationSettingData" ) }
        ,  { typeof ( MsvmSynthetic3DServiceSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_Synthetic3DServiceSettingData" ) }
        ,  { typeof ( MsvmVirtualSystemMigrationNetworkSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemMigrationNetworkSettingData" ) }
        ,  { typeof ( MsvmGuestCommunicationServiceSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_GuestCommunicationServiceSettingData" ) }
        ,  { typeof ( MsvmNetworkConnectionDiagnosticSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_NetworkConnectionDiagnosticSettingData" ) }
        ,  { typeof ( MsvmVirtualSystemReferencePointSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemReferencePointSettingData" ) }
        ,  { typeof ( MsvmCollectionReferencePointExportSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_CollectionReferencePointExportSettingData" ) }
        ,  { typeof ( MsvmVirtualSystemSnapshotSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemSnapshotSettingData" ) }
        ,  { typeof ( MsvmReplicationServiceSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_ReplicationServiceSettingData" ) }
        ,  { typeof ( MsvmEthernetPortData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetPortData" ) }
        ,  { typeof ( MsvmEthernetSwitchPortOffloadData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchPortOffloadData" ) }
        ,  { typeof ( MsvmEthernetSwitchPortBandwidthData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchPortBandwidthData" ) }
        ,  { typeof ( MsvmEthernetSwitchData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchData" ) }
        ,  { typeof ( MsvmEthernetSwitchOperationalData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchOperationalData" ) }
        ,  { typeof ( MsvmEthernetSwitchHardwareOffloadData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchHardwareOffloadData" ) }
        ,  { typeof ( MsvmEthernetSwitchBandwidthData ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchBandwidthData" ) }
        ,  { typeof ( CIMManagedSystemElement ) ,  ( "root/virtualization/v2" ,  "CIM_ManagedSystemElement" ) }
        ,  { typeof ( CIMLogicalElement ) ,  ( "root/virtualization/v2" ,  "CIM_LogicalElement" ) }
        ,  { typeof ( CIMEnabledLogicalElement ) ,  ( "root/virtualization/v2" ,  "CIM_EnabledLogicalElement" ) }
        ,  { typeof ( CIMSystem ) ,  ( "root/virtualization/v2" ,  "CIM_System" ) }
        ,  { typeof ( CIMComputerSystem ) ,  ( "root/virtualization/v2" ,  "CIM_ComputerSystem" ) }
        ,  { typeof ( MsvmComputerSystem ) ,  ( "root/virtualization/v2" ,  "Msvm_ComputerSystem" ) }
        ,  { typeof ( MsvmPlannedComputerSystem ) ,  ( "root/virtualization/v2" ,  "Msvm_PlannedComputerSystem" ) }
        ,  { typeof ( MsvmVirtualEthernetSwitch ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualEthernetSwitch" ) }
        ,  { typeof ( MsvmVirtualFcSwitch ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualFcSwitch" ) }
        ,  { typeof ( MsvmPartitionableGpu ) ,  ( "root/virtualization/v2" ,  "Msvm_PartitionableGpu" ) }
        ,  { typeof ( CIMService ) ,  ( "root/virtualization/v2" ,  "CIM_Service" ) }
        ,  { typeof ( MsvmAssignableDeviceService ) ,  ( "root/virtualization/v2" ,  "Msvm_AssignableDeviceService" ) }
        ,  { typeof ( CIMVirtualSystemManagementService ) ,  ( "root/virtualization/v2" ,  "CIM_VirtualSystemManagementService" ) }
        ,  { typeof ( MsvmVirtualSystemManagementService ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemManagementService" ) }
        ,  { typeof ( MsvmVirtualEthernetSwitchManagementService ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualEthernetSwitchManagementService" ) }
        ,  { typeof ( MsvmImageManagementService ) ,  ( "root/virtualization/v2" ,  "Msvm_ImageManagementService" ) }
        ,  { typeof ( CIMVirtualSystemMigrationService ) ,  ( "root/virtualization/v2" ,  "CIM_VirtualSystemMigrationService" ) }
        ,  { typeof ( MsvmVirtualSystemMigrationService ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemMigrationService" ) }
        ,  { typeof ( CIMMetricService ) ,  ( "root/virtualization/v2" ,  "CIM_MetricService" ) }
        ,  { typeof ( MsvmMetricService ) ,  ( "root/virtualization/v2" ,  "Msvm_MetricService" ) }
        ,  { typeof ( CIMVirtualSystemSnapshotService ) ,  ( "root/virtualization/v2" ,  "CIM_VirtualSystemSnapshotService" ) }
        ,  { typeof ( MsvmVirtualSystemSnapshotService ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemSnapshotService" ) }
        ,  { typeof ( MsvmCollectionReferencePointService ) ,  ( "root/virtualization/v2" ,  "Msvm_CollectionReferencePointService" ) }
        ,  { typeof ( MsvmVirtualSystemReferencePointService ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemReferencePointService" ) }
        ,  { typeof ( CIMNetworkService ) ,  ( "root/virtualization/v2" ,  "CIM_NetworkService" ) }
        ,  { typeof ( CIMForwardingService ) ,  ( "root/virtualization/v2" ,  "CIM_ForwardingService" ) }
        ,  { typeof ( CIMSwitchService ) ,  ( "root/virtualization/v2" ,  "CIM_SwitchService" ) }
        ,  { typeof ( CIMTransparentBridgingService ) ,  ( "root/virtualization/v2" ,  "CIM_TransparentBridgingService" ) }
        ,  { typeof ( MsvmTransparentBridgingService ) ,  ( "root/virtualization/v2" ,  "Msvm_TransparentBridgingService" ) }
        ,  { typeof ( MsvmGuestService ) ,  ( "root/virtualization/v2" ,  "Msvm_GuestService" ) }
        ,  { typeof ( MsvmVssService ) ,  ( "root/virtualization/v2" ,  "Msvm_VssService" ) }
        ,  { typeof ( MsvmGuestFileService ) ,  ( "root/virtualization/v2" ,  "Msvm_GuestFileService" ) }
        ,  { typeof ( MsvmGuestCommunicationService ) ,  ( "root/virtualization/v2" ,  "Msvm_GuestCommunicationService" ) }
        ,  { typeof ( MsvmCollectionSnapshotService ) ,  ( "root/virtualization/v2" ,  "Msvm_CollectionSnapshotService" ) }
        ,  { typeof ( MsvmResourcePoolConfigurationService ) ,  ( "root/virtualization/v2" ,  "Msvm_ResourcePoolConfigurationService" ) }
        ,  { typeof ( MsvmSynthetic3DService ) ,  ( "root/virtualization/v2" ,  "Msvm_Synthetic3DService" ) }
        ,  { typeof ( MsvmReplicationService ) ,  ( "root/virtualization/v2" ,  "Msvm_ReplicationService" ) }
        ,  { typeof ( MsvmCollectionManagementService ) ,  ( "root/virtualization/v2" ,  "Msvm_CollectionManagementService" ) }
        ,  { typeof ( MsvmSecurityService ) ,  ( "root/virtualization/v2" ,  "Msvm_SecurityService" ) }
        ,  { typeof ( MsvmTerminalService ) ,  ( "root/virtualization/v2" ,  "Msvm_TerminalService" ) }
        ,  { typeof ( CIMResourcePoolConfigurationService ) ,  ( "root/virtualization/v2" ,  "CIM_ResourcePoolConfigurationService" ) }
        ,  { typeof ( CIMLogicalDevice ) ,  ( "root/virtualization/v2" ,  "CIM_LogicalDevice" ) }
        ,  { typeof ( MsvmShutdownComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_ShutdownComponent" ) }
        ,  { typeof ( MsvmTimeSyncComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_TimeSyncComponent" ) }
        ,  { typeof ( MsvmGpuPartition ) ,  ( "root/virtualization/v2" ,  "Msvm_GpuPartition" ) }
        ,  { typeof ( MsvmHeartbeatComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_HeartbeatComponent" ) }
        ,  { typeof ( CIMUserDevice ) ,  ( "root/virtualization/v2" ,  "CIM_UserDevice" ) }
        ,  { typeof ( CIMDisplay ) ,  ( "root/virtualization/v2" ,  "CIM_Display" ) }
        ,  { typeof ( CIMDesktopMonitor ) ,  ( "root/virtualization/v2" ,  "CIM_DesktopMonitor" ) }
        ,  { typeof ( MsvmKeyboard ) ,  ( "root/virtualization/v2" ,  "Msvm_Keyboard" ) }
        ,  { typeof ( CIMPointingDevice ) ,  ( "root/virtualization/v2" ,  "CIM_PointingDevice" ) }
        ,  { typeof ( MsvmPs2Mouse ) ,  ( "root/virtualization/v2" ,  "Msvm_Ps2Mouse" ) }
        ,  { typeof ( MsvmSyntheticMouse ) ,  ( "root/virtualization/v2" ,  "Msvm_SyntheticMouse" ) }
        ,  { typeof ( MsvmSyntheticKeyboard ) ,  ( "root/virtualization/v2" ,  "Msvm_SyntheticKeyboard" ) }
        ,  { typeof ( CIMUSBDevice ) ,  ( "root/virtualization/v2" ,  "CIM_USBDevice" ) }
        ,  { typeof ( CIMTPM ) ,  ( "root/virtualization/v2" ,  "CIM_TPM" ) }
        ,  { typeof ( MsvmTPM ) ,  ( "root/virtualization/v2" ,  "Msvm_TPM" ) }
        ,  { typeof ( MsvmFlexIoDevice ) ,  ( "root/virtualization/v2" ,  "Msvm_FlexIoDevice" ) }
        ,  { typeof ( MsvmPciExpress ) ,  ( "root/virtualization/v2" ,  "Msvm_PciExpress" ) }
        ,  { typeof ( CIMProtocolController ) ,  ( "root/virtualization/v2" ,  "CIM_ProtocolController" ) }
        ,  { typeof ( CIMSCSIProtocolController ) ,  ( "root/virtualization/v2" ,  "CIM_SCSIProtocolController" ) }
        ,  { typeof ( MsvmSCSIProtocolController ) ,  ( "root/virtualization/v2" ,  "Msvm_SCSIProtocolController" ) }
        ,  { typeof ( MsvmKvpExchangeComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_KvpExchangeComponent" ) }
        ,  { typeof ( MsvmPhysical3dGraphicsProcessor ) ,  ( "root/virtualization/v2" ,  "Msvm_Physical3dGraphicsProcessor" ) }
        ,  { typeof ( MsvmVssComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_VssComponent" ) }
        ,  { typeof ( CIMMediaAccessDevice ) ,  ( "root/virtualization/v2" ,  "CIM_MediaAccessDevice" ) }
        ,  { typeof ( CIMDiskDrive ) ,  ( "root/virtualization/v2" ,  "CIM_DiskDrive" ) }
        ,  { typeof ( MsvmDiskDrive ) ,  ( "root/virtualization/v2" ,  "Msvm_DiskDrive" ) }
        ,  { typeof ( CIMDisketteDrive ) ,  ( "root/virtualization/v2" ,  "CIM_DisketteDrive" ) }
        ,  { typeof ( MsvmDisketteDrive ) ,  ( "root/virtualization/v2" ,  "Msvm_DisketteDrive" ) }
        ,  { typeof ( CIMTapeDrive ) ,  ( "root/virtualization/v2" ,  "CIM_TapeDrive" ) }
        ,  { typeof ( CIMCDROMDrive ) ,  ( "root/virtualization/v2" ,  "CIM_CDROMDrive" ) }
        ,  { typeof ( CIMDVDDrive ) ,  ( "root/virtualization/v2" ,  "CIM_DVDDrive" ) }
        ,  { typeof ( MsvmDVDDrive ) ,  ( "root/virtualization/v2" ,  "Msvm_DVDDrive" ) }
        ,  { typeof ( MsvmBattery ) ,  ( "root/virtualization/v2" ,  "Msvm_Battery" ) }
        ,  { typeof ( CIMVideoHead ) ,  ( "root/virtualization/v2" ,  "CIM_VideoHead" ) }
        ,  { typeof ( MsvmVideoHead ) ,  ( "root/virtualization/v2" ,  "Msvm_VideoHead" ) }
        ,  { typeof ( CIMController ) ,  ( "root/virtualization/v2" ,  "CIM_Controller" ) }
        ,  { typeof ( CIMIDEController ) ,  ( "root/virtualization/v2" ,  "CIM_IDEController" ) }
        ,  { typeof ( MsvmIDEController ) ,  ( "root/virtualization/v2" ,  "Msvm_IDEController" ) }
        ,  { typeof ( CIMDisplayController ) ,  ( "root/virtualization/v2" ,  "CIM_DisplayController" ) }
        ,  { typeof ( MsvmS3DisplayController ) ,  ( "root/virtualization/v2" ,  "Msvm_S3DisplayController" ) }
        ,  { typeof ( MsvmSynthetic3DDisplayController ) ,  ( "root/virtualization/v2" ,  "Msvm_Synthetic3DDisplayController" ) }
        ,  { typeof ( MsvmSyntheticDisplayController ) ,  ( "root/virtualization/v2" ,  "Msvm_SyntheticDisplayController" ) }
        ,  { typeof ( MsvmPersistentMemoryController ) ,  ( "root/virtualization/v2" ,  "Msvm_PersistentMemoryController" ) }
        ,  { typeof ( CIMSerialController ) ,  ( "root/virtualization/v2" ,  "CIM_SerialController" ) }
        ,  { typeof ( MsvmSerialController ) ,  ( "root/virtualization/v2" ,  "Msvm_SerialController" ) }
        ,  { typeof ( MsvmDisketteController ) ,  ( "root/virtualization/v2" ,  "Msvm_DisketteController" ) }
        ,  { typeof ( MsvmRdvComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_RdvComponent" ) }
        ,  { typeof ( CIMLogicalPort ) ,  ( "root/virtualization/v2" ,  "CIM_LogicalPort" ) }
        ,  { typeof ( CIMNetworkPort ) ,  ( "root/virtualization/v2" ,  "CIM_NetworkPort" ) }
        ,  { typeof ( CIMEthernetPort ) ,  ( "root/virtualization/v2" ,  "CIM_EthernetPort" ) }
        ,  { typeof ( MsvmEthernetSwitchPort ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchPort" ) }
        ,  { typeof ( MsvmInternalEthernetPort ) ,  ( "root/virtualization/v2" ,  "Msvm_InternalEthernetPort" ) }
        ,  { typeof ( MsvmSyntheticEthernetPort ) ,  ( "root/virtualization/v2" ,  "Msvm_SyntheticEthernetPort" ) }
        ,  { typeof ( MsvmExternalEthernetPort ) ,  ( "root/virtualization/v2" ,  "Msvm_ExternalEthernetPort" ) }
        ,  { typeof ( MsvmEmulatedEthernetPort ) ,  ( "root/virtualization/v2" ,  "Msvm_EmulatedEthernetPort" ) }
        ,  { typeof ( CIMFCPort ) ,  ( "root/virtualization/v2" ,  "CIM_FCPort" ) }
        ,  { typeof ( MsvmSyntheticFcPort ) ,  ( "root/virtualization/v2" ,  "Msvm_SyntheticFcPort" ) }
        ,  { typeof ( MsvmFcSwitchPort ) ,  ( "root/virtualization/v2" ,  "Msvm_FcSwitchPort" ) }
        ,  { typeof ( MsvmExternalFcPort ) ,  ( "root/virtualization/v2" ,  "Msvm_ExternalFcPort" ) }
        ,  { typeof ( CIMWiFiPort ) ,  ( "root/virtualization/v2" ,  "CIM_WiFiPort" ) }
        ,  { typeof ( MsvmWiFiPort ) ,  ( "root/virtualization/v2" ,  "Msvm_WiFiPort" ) }
        ,  { typeof ( MsvmSerialPort ) ,  ( "root/virtualization/v2" ,  "Msvm_SerialPort" ) }
        ,  { typeof ( MsvmGuestServiceInterfaceComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_GuestServiceInterfaceComponent" ) }
        ,  { typeof ( CIMStorageExtent ) ,  ( "root/virtualization/v2" ,  "CIM_StorageExtent" ) }
        ,  { typeof ( CIMMemory ) ,  ( "root/virtualization/v2" ,  "CIM_Memory" ) }
        ,  { typeof ( MsvmMemory ) ,  ( "root/virtualization/v2" ,  "Msvm_Memory" ) }
        ,  { typeof ( CIMLogicalDisk ) ,  ( "root/virtualization/v2" ,  "CIM_LogicalDisk" ) }
        ,  { typeof ( MsvmLogicalDisk ) ,  ( "root/virtualization/v2" ,  "Msvm_LogicalDisk" ) }
        ,  { typeof ( CIMProcessor ) ,  ( "root/virtualization/v2" ,  "CIM_Processor" ) }
        ,  { typeof ( MsvmProcessor ) ,  ( "root/virtualization/v2" ,  "Msvm_Processor" ) }
        ,  { typeof ( MsvmTerminalConnection ) ,  ( "root/virtualization/v2" ,  "Msvm_TerminalConnection" ) }
        ,  { typeof ( MsvmEthernetSwitchExtension ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchExtension" ) }
        ,  { typeof ( CIMServiceAccessPoint ) ,  ( "root/virtualization/v2" ,  "CIM_ServiceAccessPoint" ) }
        ,  { typeof ( CIMProtocolEndpoint ) ,  ( "root/virtualization/v2" ,  "CIM_ProtocolEndpoint" ) }
        ,  { typeof ( MsvmFcEndpoint ) ,  ( "root/virtualization/v2" ,  "Msvm_FcEndpoint" ) }
        ,  { typeof ( CIMLANEndpoint ) ,  ( "root/virtualization/v2" ,  "CIM_LANEndpoint" ) }
        ,  { typeof ( CIMWiFiEndpoint ) ,  ( "root/virtualization/v2" ,  "CIM_WiFiEndpoint" ) }
        ,  { typeof ( MsvmWiFiEndpoint ) ,  ( "root/virtualization/v2" ,  "Msvm_WiFiEndpoint" ) }
        ,  { typeof ( MsvmLANEndpoint ) ,  ( "root/virtualization/v2" ,  "Msvm_LANEndpoint" ) }
        ,  { typeof ( CIMSwitchPort ) ,  ( "root/virtualization/v2" ,  "CIM_SwitchPort" ) }
        ,  { typeof ( CIMVLANEndpoint ) ,  ( "root/virtualization/v2" ,  "CIM_VLANEndpoint" ) }
        ,  { typeof ( MsvmVLANEndpoint ) ,  ( "root/virtualization/v2" ,  "Msvm_VLANEndpoint" ) }
        ,  { typeof ( MsvmNumaNode ) ,  ( "root/virtualization/v2" ,  "Msvm_NumaNode" ) }
        ,  { typeof ( MsvmSecurityElement ) ,  ( "root/virtualization/v2" ,  "Msvm_SecurityElement" ) }
        ,  { typeof ( CIMJob ) ,  ( "root/virtualization/v2" ,  "CIM_Job" ) }
        ,  { typeof ( CIMConcreteJob ) ,  ( "root/virtualization/v2" ,  "CIM_ConcreteJob" ) }
        ,  { typeof ( MsvmConcreteJob ) ,  ( "root/virtualization/v2" ,  "Msvm_ConcreteJob" ) }
        ,  { typeof ( MsvmMigrationJob ) ,  ( "root/virtualization/v2" ,  "Msvm_MigrationJob" ) }
        ,  { typeof ( MsvmCopyFileToGuestJob ) ,  ( "root/virtualization/v2" ,  "Msvm_CopyFileToGuestJob" ) }
        ,  { typeof ( MsvmStorageJob ) ,  ( "root/virtualization/v2" ,  "Msvm_StorageJob" ) }
        ,  { typeof ( MsvmCollectionReferencePointExportJob ) ,  ( "root/virtualization/v2" ,  "Msvm_CollectionReferencePointExportJob" ) }
        ,  { typeof ( MsvmVirtualSystemReferencePointExportJob ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemReferencePointExportJob" ) }
        ,  { typeof ( CIMResourcePool ) ,  ( "root/virtualization/v2" ,  "CIM_ResourcePool" ) }
        ,  { typeof ( MsvmSynth3dVideoPool ) ,  ( "root/virtualization/v2" ,  "Msvm_Synth3dVideoPool" ) }
        ,  { typeof ( MsvmProcessorPool ) ,  ( "root/virtualization/v2" ,  "Msvm_ProcessorPool" ) }
        ,  { typeof ( MsvmResourcePool ) ,  ( "root/virtualization/v2" ,  "Msvm_ResourcePool" ) }
        ,  { typeof ( CIMDynamicForwardingEntry ) ,  ( "root/virtualization/v2" ,  "CIM_DynamicForwardingEntry" ) }
        ,  { typeof ( MsvmDynamicForwardingEntry ) ,  ( "root/virtualization/v2" ,  "Msvm_DynamicForwardingEntry" ) }
        ,  { typeof ( MsvmMountedStorageImage ) ,  ( "root/virtualization/v2" ,  "Msvm_MountedStorageImage" ) }
        ,  { typeof ( CIMSoftwareElement ) ,  ( "root/virtualization/v2" ,  "CIM_SoftwareElement" ) }
        ,  { typeof ( CIMBIOSElement ) ,  ( "root/virtualization/v2" ,  "CIM_BIOSElement" ) }
        ,  { typeof ( MsvmBIOSElement ) ,  ( "root/virtualization/v2" ,  "Msvm_BIOSElement" ) }
        ,  { typeof ( MsvmReplicationRelationship ) ,  ( "root/virtualization/v2" ,  "Msvm_ReplicationRelationship" ) }
        ,  { typeof ( MsvmReplicationProvider ) ,  ( "root/virtualization/v2" ,  "Msvm_ReplicationProvider" ) }
        ,  { typeof ( MsvmInstalledEthernetSwitchExtension ) ,  ( "root/virtualization/v2" ,  "Msvm_InstalledEthernetSwitchExtension" ) }
        ,  { typeof ( CIMView ) ,  ( "root/virtualization/v2" ,  "CIM_View" ) }
        ,  { typeof ( MsvmSummaryInformationBase ) ,  ( "root/virtualization/v2" ,  "Msvm_SummaryInformationBase" ) }
        ,  { typeof ( MsvmSummaryInformation ) ,  ( "root/virtualization/v2" ,  "Msvm_SummaryInformation" ) }
        ,  { typeof ( CIMCapabilities ) ,  ( "root/virtualization/v2" ,  "CIM_Capabilities" ) }
        ,  { typeof ( CIMEnabledLogicalElementCapabilities ) ,  ( "root/virtualization/v2" ,  "CIM_EnabledLogicalElementCapabilities" ) }
        ,  { typeof ( CIMVirtualSystemManagementCapabilities ) ,  ( "root/virtualization/v2" ,  "CIM_VirtualSystemManagementCapabilities" ) }
        ,  { typeof ( MsvmVirtualSystemManagementCapabilities ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemManagementCapabilities" ) }
        ,  { typeof ( MsvmVirtualEthernetSwitchManagementCapabilities ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualEthernetSwitchManagementCapabilities" ) }
        ,  { typeof ( MsvmVirtualSystemCapabilities ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemCapabilities" ) }
        ,  { typeof ( CIMMetricServiceCapabilities ) ,  ( "root/virtualization/v2" ,  "CIM_MetricServiceCapabilities" ) }
        ,  { typeof ( MsvmMetricServiceCapabilities ) ,  ( "root/virtualization/v2" ,  "Msvm_MetricServiceCapabilities" ) }
        ,  { typeof ( CIMAllocationCapabilities ) ,  ( "root/virtualization/v2" ,  "CIM_AllocationCapabilities" ) }
        ,  { typeof ( MsvmAllocationCapabilities ) ,  ( "root/virtualization/v2" ,  "Msvm_AllocationCapabilities" ) }
        ,  { typeof ( CIMResourcePoolConfigurationCapabilities ) ,  ( "root/virtualization/v2" ,  "CIM_ResourcePoolConfigurationCapabilities" ) }
        ,  { typeof ( MsvmExternalEthernetPortCapabilities ) ,  ( "root/virtualization/v2" ,  "Msvm_ExternalEthernetPortCapabilities" ) }
        ,  { typeof ( MsvmResourcePoolConfigurationCapabilities ) ,  ( "root/virtualization/v2" ,  "Msvm_ResourcePoolConfigurationCapabilities" ) }
        ,  { typeof ( CIMVirtualSystemMigrationCapabilities ) ,  ( "root/virtualization/v2" ,  "CIM_VirtualSystemMigrationCapabilities" ) }
        ,  { typeof ( MsvmVirtualSystemMigrationCapabilities ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemMigrationCapabilities" ) }
        ,  { typeof ( MsvmEthernetSwitchFeatureCapabilities ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchFeatureCapabilities" ) }
        ,  { typeof ( MsvmVirtualSystemReferencePoint ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemReferencePoint" ) }
        ,  { typeof ( MsvmReplicationStatistics ) ,  ( "root/virtualization/v2" ,  "Msvm_ReplicationStatistics" ) }
        ,  { typeof ( MsvmPhysicalGPUInfo ) ,  ( "root/virtualization/v2" ,  "Msvm_PhysicalGPUInfo" ) }
        ,  { typeof ( CIMBaseMetricDefinition ) ,  ( "root/virtualization/v2" ,  "CIM_BaseMetricDefinition" ) }
        ,  { typeof ( CIMAggregationMetricDefinition ) ,  ( "root/virtualization/v2" ,  "CIM_AggregationMetricDefinition" ) }
        ,  { typeof ( MsvmAggregationMetricDefinition ) ,  ( "root/virtualization/v2" ,  "Msvm_AggregationMetricDefinition" ) }
        ,  { typeof ( MsvmBaseMetricDefinition ) ,  ( "root/virtualization/v2" ,  "Msvm_BaseMetricDefinition" ) }
        ,  { typeof ( MsvmNumaNodeTopology ) ,  ( "root/virtualization/v2" ,  "Msvm_NumaNodeTopology" ) }
        ,  { typeof ( CIMCollection ) ,  ( "root/virtualization/v2" ,  "CIM_Collection" ) }
        ,  { typeof ( MsvmSnapshotCollection ) ,  ( "root/virtualization/v2" ,  "Msvm_SnapshotCollection" ) }
        ,  { typeof ( CIMCollectionOfMSEs ) ,  ( "root/virtualization/v2" ,  "CIM_CollectionOfMSEs" ) }
        ,  { typeof ( MsvmVirtualSystemCollection ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemCollection" ) }
        ,  { typeof ( MsvmManagementCollection ) ,  ( "root/virtualization/v2" ,  "Msvm_ManagementCollection" ) }
        ,  { typeof ( MsvmReferencePointCollection ) ,  ( "root/virtualization/v2" ,  "Msvm_ReferencePointCollection" ) }
        ,  { typeof ( CIMBaseMetricValue ) ,  ( "root/virtualization/v2" ,  "CIM_BaseMetricValue" ) }
        ,  { typeof ( CIMAggregationMetricValue ) ,  ( "root/virtualization/v2" ,  "CIM_AggregationMetricValue" ) }
        ,  { typeof ( MsvmAggregationMetricValue ) ,  ( "root/virtualization/v2" ,  "Msvm_AggregationMetricValue" ) }
        ,  { typeof ( MsvmBaseMetricValue ) ,  ( "root/virtualization/v2" ,  "Msvm_BaseMetricValue" ) }
        ,  { typeof ( MsvmMoveUnmanagedVhd ) ,  ( "root/virtualization/v2" ,  "Msvm_MoveUnmanagedVhd" ) }
        ,  { typeof ( MsvmKvpExchangeDataItem ) ,  ( "root/virtualization/v2" ,  "Msvm_KvpExchangeDataItem" ) }
        ,  { typeof ( CIMMemberOfCollection ) ,  ( "root/virtualization/v2" ,  "CIM_MemberOfCollection" ) }
        ,  { typeof ( CIMCollectedMSEs ) ,  ( "root/virtualization/v2" ,  "CIM_CollectedMSEs" ) }
        ,  { typeof ( MsvmCollectedVirtualSystems ) ,  ( "root/virtualization/v2" ,  "Msvm_CollectedVirtualSystems" ) }
        ,  { typeof ( MsvmCollectedSnapshots ) ,  ( "root/virtualization/v2" ,  "Msvm_CollectedSnapshots" ) }
        ,  { typeof ( MsvmCollectedCollections ) ,  ( "root/virtualization/v2" ,  "Msvm_CollectedCollections" ) }
        ,  { typeof ( MsvmCollectedReferencePoints ) ,  ( "root/virtualization/v2" ,  "Msvm_CollectedReferencePoints" ) }
        ,  { typeof ( CIMComponent ) ,  ( "root/virtualization/v2" ,  "CIM_Component" ) }
        ,  { typeof ( CIMSystemComponent ) ,  ( "root/virtualization/v2" ,  "CIM_SystemComponent" ) }
        ,  { typeof ( MsvmHostedResourcePool ) ,  ( "root/virtualization/v2" ,  "Msvm_HostedResourcePool" ) }
        ,  { typeof ( CIMSystemBIOS ) ,  ( "root/virtualization/v2" ,  "CIM_SystemBIOS" ) }
        ,  { typeof ( MsvmSystemBIOS ) ,  ( "root/virtualization/v2" ,  "Msvm_SystemBIOS" ) }
        ,  { typeof ( MsvmSystemComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_SystemComponent" ) }
        ,  { typeof ( CIMSystemDevice ) ,  ( "root/virtualization/v2" ,  "CIM_SystemDevice" ) }
        ,  { typeof ( MsvmSystemDevice ) ,  ( "root/virtualization/v2" ,  "Msvm_SystemDevice" ) }
        ,  { typeof ( CIMHostedResourcePool ) ,  ( "root/virtualization/v2" ,  "CIM_HostedResourcePool" ) }
        ,  { typeof ( MsvmBootSourceComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_BootSourceComponent" ) }
        ,  { typeof ( CIMConcreteComponent ) ,  ( "root/virtualization/v2" ,  "CIM_ConcreteComponent" ) }
        ,  { typeof ( MsvmConcreteComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_ConcreteComponent" ) }
        ,  { typeof ( CIMServiceComponent ) ,  ( "root/virtualization/v2" ,  "CIM_ServiceComponent" ) }
        ,  { typeof ( CIMSwitchServiceTransparentBridging ) ,  ( "root/virtualization/v2" ,  "CIM_SwitchServiceTransparentBridging" ) }
        ,  { typeof ( CIMSettingsDefineCapabilities ) ,  ( "root/virtualization/v2" ,  "CIM_SettingsDefineCapabilities" ) }
        ,  { typeof ( MsvmSettingsDefineCapabilities ) ,  ( "root/virtualization/v2" ,  "Msvm_SettingsDefineCapabilities" ) }
        ,  { typeof ( MsvmFeatureSettingsDefineCapabilities ) ,  ( "root/virtualization/v2" ,  "Msvm_FeatureSettingsDefineCapabilities" ) }
        ,  { typeof ( CIMVirtualSystemSettingDataComponent ) ,  ( "root/virtualization/v2" ,  "CIM_VirtualSystemSettingDataComponent" ) }
        ,  { typeof ( MsvmVirtualSystemSettingDataComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemSettingDataComponent" ) }
        ,  { typeof ( MsvmGuestServiceInterfaceSettingDataComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_GuestServiceInterfaceSettingDataComponent" ) }
        ,  { typeof ( MsvmSettingDataComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_SettingDataComponent" ) }
        ,  { typeof ( MsvmEthernetPortFailoverSettingDataComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetPortFailoverSettingDataComponent" ) }
        ,  { typeof ( MsvmEthernetPortSettingDataComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetPortSettingDataComponent" ) }
        ,  { typeof ( MsvmVirtualEthernetSwitchSettingDataComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualEthernetSwitchSettingDataComponent" ) }
        ,  { typeof ( MsvmVirtualSystemMigrationServiceSettingDataComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualSystemMigrationServiceSettingDataComponent" ) }
        ,  { typeof ( CIMDependency ) ,  ( "root/virtualization/v2" ,  "CIM_Dependency" ) }
        ,  { typeof ( CIMHostedDependency ) ,  ( "root/virtualization/v2" ,  "CIM_HostedDependency" ) }
        ,  { typeof ( MsvmSystemTerminalConnection ) ,  ( "root/virtualization/v2" ,  "Msvm_SystemTerminalConnection" ) }
        ,  { typeof ( CIMHostedService ) ,  ( "root/virtualization/v2" ,  "CIM_HostedService" ) }
        ,  { typeof ( MsvmHostedService ) ,  ( "root/virtualization/v2" ,  "Msvm_HostedService" ) }
        ,  { typeof ( MsvmHostedSwitchService ) ,  ( "root/virtualization/v2" ,  "Msvm_HostedSwitchService" ) }
        ,  { typeof ( CIMHostedAccessPoint ) ,  ( "root/virtualization/v2" ,  "CIM_HostedAccessPoint" ) }
        ,  { typeof ( MsvmHostedDependency ) ,  ( "root/virtualization/v2" ,  "Msvm_HostedDependency" ) }
        ,  { typeof ( CIMPortOnDevice ) ,  ( "root/virtualization/v2" ,  "CIM_PortOnDevice" ) }
        ,  { typeof ( MsvmSerialPortOnSerialController ) ,  ( "root/virtualization/v2" ,  "Msvm_SerialPortOnSerialController" ) }
        ,  { typeof ( CIMVideoHeadOnController ) ,  ( "root/virtualization/v2" ,  "CIM_VideoHeadOnController" ) }
        ,  { typeof ( MsvmVideoHeadOnController ) ,  ( "root/virtualization/v2" ,  "Msvm_VideoHeadOnController" ) }
        ,  { typeof ( MsvmHostedEthernetSwitchExtension ) ,  ( "root/virtualization/v2" ,  "Msvm_HostedEthernetSwitchExtension" ) }
        ,  { typeof ( MsvmReferencePointOfVirtualSystem ) ,  ( "root/virtualization/v2" ,  "Msvm_ReferencePointOfVirtualSystem" ) }
        ,  { typeof ( MsvmSystemReplicationRelationship ) ,  ( "root/virtualization/v2" ,  "Msvm_SystemReplicationRelationship" ) }
        ,  { typeof ( CIMSnapshotOfVirtualSystem ) ,  ( "root/virtualization/v2" ,  "CIM_SnapshotOfVirtualSystem" ) }
        ,  { typeof ( MsvmSnapshotOfVirtualSystem ) ,  ( "root/virtualization/v2" ,  "Msvm_SnapshotOfVirtualSystem" ) }
        ,  { typeof ( CIMElementView ) ,  ( "root/virtualization/v2" ,  "CIM_ElementView" ) }
        ,  { typeof ( MsvmComputerSystemSummaryInformation ) ,  ( "root/virtualization/v2" ,  "Msvm_ComputerSystemSummaryInformation" ) }
        ,  { typeof ( CIMLastAppliedSnapshot ) ,  ( "root/virtualization/v2" ,  "CIM_LastAppliedSnapshot" ) }
        ,  { typeof ( MsvmLastAppliedSnapshot ) ,  ( "root/virtualization/v2" ,  "Msvm_LastAppliedSnapshot" ) }
        ,  { typeof ( CIMMostCurrentSnapshotInBranch ) ,  ( "root/virtualization/v2" ,  "CIM_MostCurrentSnapshotInBranch" ) }
        ,  { typeof ( MsvmMostCurrentSnapshotInBranch ) ,  ( "root/virtualization/v2" ,  "Msvm_MostCurrentSnapshotInBranch" ) }
        ,  { typeof ( MsvmReplicaSystemDependency ) ,  ( "root/virtualization/v2" ,  "Msvm_ReplicaSystemDependency" ) }
        ,  { typeof ( MsvmElementAllocatedFromNumaNode ) ,  ( "root/virtualization/v2" ,  "Msvm_ElementAllocatedFromNumaNode" ) }
        ,  { typeof ( CIMElementAllocatedFromPool ) ,  ( "root/virtualization/v2" ,  "CIM_ElementAllocatedFromPool" ) }
        ,  { typeof ( MsvmElementAllocatedFromPool ) ,  ( "root/virtualization/v2" ,  "Msvm_ElementAllocatedFromPool" ) }
        ,  { typeof ( CIMMetricDefForME ) ,  ( "root/virtualization/v2" ,  "CIM_MetricDefForME" ) }
        ,  { typeof ( MsvmMetricDefForME ) ,  ( "root/virtualization/v2" ,  "Msvm_MetricDefForME" ) }
        ,  { typeof ( MsvmMetricCollectionDependency ) ,  ( "root/virtualization/v2" ,  "Msvm_MetricCollectionDependency" ) }
        ,  { typeof ( CIMMetricForME ) ,  ( "root/virtualization/v2" ,  "CIM_MetricForME" ) }
        ,  { typeof ( MsvmMetricForME ) ,  ( "root/virtualization/v2" ,  "Msvm_MetricForME" ) }
        ,  { typeof ( CIMConcreteDependency ) ,  ( "root/virtualization/v2" ,  "CIM_ConcreteDependency" ) }
        ,  { typeof ( MsvmConcreteDependency ) ,  ( "root/virtualization/v2" ,  "Msvm_ConcreteDependency" ) }
        ,  { typeof ( CIMServiceSAPDependency ) ,  ( "root/virtualization/v2" ,  "CIM_ServiceSAPDependency" ) }
        ,  { typeof ( CIMForwardsAmong ) ,  ( "root/virtualization/v2" ,  "CIM_ForwardsAmong" ) }
        ,  { typeof ( CIMSwitchesAmong ) ,  ( "root/virtualization/v2" ,  "CIM_SwitchesAmong" ) }
        ,  { typeof ( MsvmParentChildSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_ParentChildSettingData" ) }
        ,  { typeof ( CIMResourceAllocationFromPool ) ,  ( "root/virtualization/v2" ,  "CIM_ResourceAllocationFromPool" ) }
        ,  { typeof ( MsvmResourceAllocationFromPool ) ,  ( "root/virtualization/v2" ,  "Msvm_ResourceAllocationFromPool" ) }
        ,  { typeof ( MsvmResourceDependentOnResource ) ,  ( "root/virtualization/v2" ,  "Msvm_ResourceDependentOnResource" ) }
        ,  { typeof ( CIMSAPSAPDependency ) ,  ( "root/virtualization/v2" ,  "CIM_SAPSAPDependency" ) }
        ,  { typeof ( CIMActiveConnection ) ,  ( "root/virtualization/v2" ,  "CIM_ActiveConnection" ) }
        ,  { typeof ( MsvmActiveConnection ) ,  ( "root/virtualization/v2" ,  "Msvm_ActiveConnection" ) }
        ,  { typeof ( MsvmFcActiveConnection ) ,  ( "root/virtualization/v2" ,  "Msvm_FcActiveConnection" ) }
        ,  { typeof ( CIMBindsTo ) ,  ( "root/virtualization/v2" ,  "CIM_BindsTo" ) }
        ,  { typeof ( CIMBindsToLANEndpoint ) ,  ( "root/virtualization/v2" ,  "CIM_BindsToLANEndpoint" ) }
        ,  { typeof ( MsvmBindsToLANEndpoint ) ,  ( "root/virtualization/v2" ,  "Msvm_BindsToLANEndpoint" ) }
        ,  { typeof ( CIMSwitchPortDynamicForwarding ) ,  ( "root/virtualization/v2" ,  "CIM_SwitchPortDynamicForwarding" ) }
        ,  { typeof ( MsvmSwitchPortDynamicForwarding ) ,  ( "root/virtualization/v2" ,  "Msvm_SwitchPortDynamicForwarding" ) }
        ,  { typeof ( MsvmServiceOfVssComponent ) ,  ( "root/virtualization/v2" ,  "Msvm_ServiceOfVssComponent" ) }
        ,  { typeof ( CIMProtocolControllerForDevice ) ,  ( "root/virtualization/v2" ,  "CIM_ProtocolControllerForDevice" ) }
        ,  { typeof ( CIMProtocolControllerForUnit ) ,  ( "root/virtualization/v2" ,  "CIM_ProtocolControllerForUnit" ) }
        ,  { typeof ( MsvmProtocolControllerForUnit ) ,  ( "root/virtualization/v2" ,  "Msvm_ProtocolControllerForUnit" ) }
        ,  { typeof ( MsvmReferencePointOfVirtualSystemCollection ) ,  ( "root/virtualization/v2" ,  "Msvm_ReferencePointOfVirtualSystemCollection" ) }
        ,  { typeof ( MsvmVirtualEthernetSwitchNicTeamingMember ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualEthernetSwitchNicTeamingMember" ) }
        ,  { typeof ( CIMDeviceSAPImplementation ) ,  ( "root/virtualization/v2" ,  "CIM_DeviceSAPImplementation" ) }
        ,  { typeof ( MsvmEthernetDeviceSAPImplementation ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetDeviceSAPImplementation" ) }
        ,  { typeof ( MsvmWiFiDeviceSAPImplementation ) ,  ( "root/virtualization/v2" ,  "Msvm_WiFiDeviceSAPImplementation" ) }
        ,  { typeof ( MsvmFcDeviceSAPImplementation ) ,  ( "root/virtualization/v2" ,  "Msvm_FcDeviceSAPImplementation" ) }
        ,  { typeof ( MsvmDeviceSAPImplementation ) ,  ( "root/virtualization/v2" ,  "Msvm_DeviceSAPImplementation" ) }
        ,  { typeof ( CIMMetricInstance ) ,  ( "root/virtualization/v2" ,  "CIM_MetricInstance" ) }
        ,  { typeof ( MsvmMetricInstance ) ,  ( "root/virtualization/v2" ,  "Msvm_MetricInstance" ) }
        ,  { typeof ( MsvmParentEthernetSwitchExtension ) ,  ( "root/virtualization/v2" ,  "Msvm_ParentEthernetSwitchExtension" ) }
        ,  { typeof ( MsvmEthernetSwitchInfo ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchInfo" ) }
        ,  { typeof ( CIMBasedOn ) ,  ( "root/virtualization/v2" ,  "CIM_BasedOn" ) }
        ,  { typeof ( MsvmBasedOn ) ,  ( "root/virtualization/v2" ,  "Msvm_BasedOn" ) }
        ,  { typeof ( MsvmRegisteredGuestService ) ,  ( "root/virtualization/v2" ,  "Msvm_RegisteredGuestService" ) }
        ,  { typeof ( CIMDeviceConnection ) ,  ( "root/virtualization/v2" ,  "CIM_DeviceConnection" ) }
        ,  { typeof ( CIMControlledBy ) ,  ( "root/virtualization/v2" ,  "CIM_ControlledBy" ) }
        ,  { typeof ( MsvmControlledBy ) ,  ( "root/virtualization/v2" ,  "Msvm_ControlledBy" ) }
        ,  { typeof ( MsvmSnapshotOfVirtualSystemCollection ) ,  ( "root/virtualization/v2" ,  "Msvm_SnapshotOfVirtualSystemCollection" ) }
        ,  { typeof ( MsvmEthernetPortInfo ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetPortInfo" ) }
        ,  { typeof ( CIMMediaPresent ) ,  ( "root/virtualization/v2" ,  "CIM_MediaPresent" ) }
        ,  { typeof ( MsvmMediaPresent ) ,  ( "root/virtualization/v2" ,  "Msvm_MediaPresent" ) }
        ,  { typeof ( CIMTransparentBridgingDynamicForwarding ) ,  ( "root/virtualization/v2" ,  "CIM_TransparentBridgingDynamicForwarding" ) }
        ,  { typeof ( MsvmTransparentBridgingDynamicForwarding ) ,  ( "root/virtualization/v2" ,  "Msvm_TransparentBridgingDynamicForwarding" ) }
        ,  { typeof ( CIMElementConformsToProfile ) ,  ( "root/virtualization/v2" ,  "CIM_ElementConformsToProfile" ) }
        ,  { typeof ( MsvmElementConformsToProfile ) ,  ( "root/virtualization/v2" ,  "Msvm_ElementConformsToProfile" ) }
        ,  { typeof ( CIMElementSettingData ) ,  ( "root/virtualization/v2" ,  "CIM_ElementSettingData" ) }
        ,  { typeof ( MsvmSystemExportSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_SystemExportSettingData" ) }
        ,  { typeof ( MsvmElementSettingData ) ,  ( "root/virtualization/v2" ,  "Msvm_ElementSettingData" ) }
        ,  { typeof ( CIMAffectedJobElement ) ,  ( "root/virtualization/v2" ,  "CIM_AffectedJobElement" ) }
        ,  { typeof ( MsvmAffectedStorageJobElement ) ,  ( "root/virtualization/v2" ,  "Msvm_AffectedStorageJobElement" ) }
        ,  { typeof ( MsvmAffectedJobElement ) ,  ( "root/virtualization/v2" ,  "Msvm_AffectedJobElement" ) }
        ,  { typeof ( CIMLogicalIdentity ) ,  ( "root/virtualization/v2" ,  "CIM_LogicalIdentity" ) }
        ,  { typeof ( MsvmLogicalIdentity ) ,  ( "root/virtualization/v2" ,  "Msvm_LogicalIdentity" ) }
        ,  { typeof ( CIMSettingsDefineState ) ,  ( "root/virtualization/v2" ,  "CIM_SettingsDefineState" ) }
        ,  { typeof ( MsvmSettingsDefineState ) ,  ( "root/virtualization/v2" ,  "Msvm_SettingsDefineState" ) }
        ,  { typeof ( CIMServiceAffectsElement ) ,  ( "root/virtualization/v2" ,  "CIM_ServiceAffectsElement" ) }
        ,  { typeof ( MsvmServiceAffectsElement ) ,  ( "root/virtualization/v2" ,  "Msvm_ServiceAffectsElement" ) }
        ,  { typeof ( CIMElementCapabilities ) ,  ( "root/virtualization/v2" ,  "CIM_ElementCapabilities" ) }
        ,  { typeof ( MsvmElementCapabilities ) ,  ( "root/virtualization/v2" ,  "Msvm_ElementCapabilities" ) }
        ,  { typeof ( MsvmEthernetSwitchExtensionCapabilities ) ,  ( "root/virtualization/v2" ,  "Msvm_EthernetSwitchExtensionCapabilities" ) }
        ,  { typeof ( CIMOwningJobElement ) ,  ( "root/virtualization/v2" ,  "CIM_OwningJobElement" ) }
        ,  { typeof ( MsvmOwningJobElement ) ,  ( "root/virtualization/v2" ,  "Msvm_OwningJobElement" ) }
        ,  { typeof ( CIMError ) ,  ( "root/virtualization/v2" ,  "CIM_Error" ) }
        ,  { typeof ( MSFTWmiError ) ,  ( "root/virtualization/v2" ,  "MSFT_WmiError" ) }
        ,  { typeof ( MSFTExtendedStatus ) ,  ( "root/virtualization/v2" ,  "MSFT_ExtendedStatus" ) }
        ,  { typeof ( MsvmError ) ,  ( "root/virtualization/v2" ,  "Msvm_Error" ) }
        ,  { typeof ( MsvmVirtualHardDiskState ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualHardDiskState" ) }
        ,  { typeof ( MsvmGuestNetworkAdapterConfiguration ) ,  ( "root/virtualization/v2" ,  "Msvm_GuestNetworkAdapterConfiguration" ) }
        ,  { typeof ( NotifyStatus ) ,  ( "root/virtualization/v2" ,  "__NotifyStatus" ) }
        ,  { typeof ( ExtendedStatus ) ,  ( "root/virtualization/v2" ,  "__ExtendedStatus" ) }
        ,  { typeof ( SecurityRelatedClass ) ,  ( "root/virtualization/v2" ,  "__SecurityRelatedClass" ) }
        ,  { typeof ( Trustee ) ,  ( "root/virtualization/v2" ,  "__Trustee" ) }
        ,  { typeof ( NTLMUser9X ) ,  ( "root/virtualization/v2" ,  "__NTLMUser9X" ) }
        ,  { typeof ( ACE ) ,  ( "root/virtualization/v2" ,  "__ACE" ) }
        ,  { typeof ( SecurityDescriptor ) ,  ( "root/virtualization/v2" ,  "__SecurityDescriptor" ) }
        ,  { typeof ( PARAMETERS ) ,  ( "root/virtualization/v2" ,  "__PARAMETERS" ) }
        ,  { typeof ( MsvmGuestClusterInformation ) ,  ( "root/virtualization/v2" ,  "Msvm_GuestClusterInformation" ) }
        ,  { typeof ( MsvmCompatibilityVector ) ,  ( "root/virtualization/v2" ,  "Msvm_CompatibilityVector" ) }
        ,  { typeof ( MsvmVHDSetInformation ) ,  ( "root/virtualization/v2" ,  "Msvm_VHDSetInformation" ) }
        ,  { typeof ( MsvmVHDSnapshotInformation ) ,  ( "root/virtualization/v2" ,  "Msvm_VHDSnapshotInformation" ) }
        ,  { typeof ( MsvmInteractiveSessionACE ) ,  ( "root/virtualization/v2" ,  "Msvm_InteractiveSessionACE" ) }
        ,  { typeof ( MsvmVirtualMachineToDisks ) ,  ( "root/virtualization/v2" ,  "Msvm_VirtualMachineToDisks" ) }
        ,  { typeof ( MsvmNetworkConnectionDiagnosticInformation ) ,  ( "root/virtualization/v2" ,  "Msvm_NetworkConnectionDiagnosticInformation" ) }
        ,  { typeof ( MsvmServicingSettings ) ,  ( "root/virtualization/v2" ,  "Msvm_ServicingSettings" ) }
        };
        public (string cimNamespace, string cimClassName) TryResolveType(Type type)
        {
            if (_typeMap.TryGetValue(type, out var result))
            {
                return result;
            }

            return (null, null);
        }
    }
}