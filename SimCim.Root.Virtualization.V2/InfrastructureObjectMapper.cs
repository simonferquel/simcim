using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class InfrastructureObjectMapper : IInfrastructureObjectMapper
    {
        public string CimNamespace => "root/virtualization/v2";
        public IInfrastructureObject Create(IInfrastructureObjectScope scope, CimInstance cimInstance)
        {
            switch (cimInstance.CimSystemProperties.ClassName)
            {
                case "__thisNAMESPACE":
                    return new ThisNAMESPACE(scope, cimInstance);
                case "__NAMESPACE":
                    return new NAMESPACE(scope, cimInstance);
                case "__Win32Provider":
                    return new Win32Provider(scope, cimInstance);
                case "__EventProviderRegistration":
                    return new EventProviderRegistration(scope, cimInstance);
                case "__ClassProviderRegistration":
                    return new ClassProviderRegistration(scope, cimInstance);
                case "__InstanceProviderRegistration":
                    return new InstanceProviderRegistration(scope, cimInstance);
                case "__MethodProviderRegistration":
                    return new MethodProviderRegistration(scope, cimInstance);
                case "__PropertyProviderRegistration":
                    return new PropertyProviderRegistration(scope, cimInstance);
                case "__EventConsumerProviderRegistration":
                    return new EventConsumerProviderRegistration(scope, cimInstance);
                case "__EventFilter":
                    return new EventFilter(scope, cimInstance);
                case "__InstanceOperationEvent":
                    return new InstanceOperationEvent(scope, cimInstance);
                case "__InstanceCreationEvent":
                    return new InstanceCreationEvent(scope, cimInstance);
                case "__InstanceDeletionEvent":
                    return new InstanceDeletionEvent(scope, cimInstance);
                case "__InstanceModificationEvent":
                    return new InstanceModificationEvent(scope, cimInstance);
                case "__MethodInvocationEvent":
                    return new MethodInvocationEvent(scope, cimInstance);
                case "__ExtrinsicEvent":
                    return new ExtrinsicEvent(scope, cimInstance);
                case "CIM_Indication":
                    return new CIMIndication(scope, cimInstance);
                case "CIM_ProcessIndication":
                    return new CIMProcessIndication(scope, cimInstance);
                case "CIM_AlertIndication":
                    return new CIMAlertIndication(scope, cimInstance);
                case "Msvm_StorageAlert":
                    return new MsvmStorageAlert(scope, cimInstance);
                case "CIM_ClassDeletion":
                    return new CIMClassDeletion(scope, cimInstance);
                case "CIM_ClassCreation":
                    return new CIMClassCreation(scope, cimInstance);
                case "CIM_ClassModification":
                    return new CIMClassModification(scope, cimInstance);
                case "CIM_InstCreation":
                    return new CIMInstCreation(scope, cimInstance);
                case "CIM_InstModification":
                    return new CIMInstModification(scope, cimInstance);
                case "CIM_InstDeletion":
                    return new CIMInstDeletion(scope, cimInstance);
                case "__SystemEvent":
                    return new SystemEvent(scope, cimInstance);
                case "__EventDroppedEvent":
                    return new EventDroppedEvent(scope, cimInstance);
                case "__EventQueueOverflowEvent":
                    return new EventQueueOverflowEvent(scope, cimInstance);
                case "__QOSFailureEvent":
                    return new QOSFailureEvent(scope, cimInstance);
                case "__ConsumerFailureEvent":
                    return new ConsumerFailureEvent(scope, cimInstance);
                case "__ClassOperationEvent":
                    return new ClassOperationEvent(scope, cimInstance);
                case "__ClassDeletionEvent":
                    return new ClassDeletionEvent(scope, cimInstance);
                case "__ClassModificationEvent":
                    return new ClassModificationEvent(scope, cimInstance);
                case "__ClassCreationEvent":
                    return new ClassCreationEvent(scope, cimInstance);
                case "__NamespaceOperationEvent":
                    return new NamespaceOperationEvent(scope, cimInstance);
                case "__NamespaceModificationEvent":
                    return new NamespaceModificationEvent(scope, cimInstance);
                case "__NamespaceDeletionEvent":
                    return new NamespaceDeletionEvent(scope, cimInstance);
                case "__NamespaceCreationEvent":
                    return new NamespaceCreationEvent(scope, cimInstance);
                case "__TimerEvent":
                    return new TimerEvent(scope, cimInstance);
                case "__AggregateEvent":
                    return new AggregateEvent(scope, cimInstance);
                case "__TimerNextFiring":
                    return new TimerNextFiring(scope, cimInstance);
                case "__AbsoluteTimerInstruction":
                    return new AbsoluteTimerInstruction(scope, cimInstance);
                case "__IntervalTimerInstruction":
                    return new IntervalTimerInstruction(scope, cimInstance);
                case "__SystemSecurity":
                    return new SystemSecurity(scope, cimInstance);
                case "Msvm_VirtualEthernetSwitchNicTeamingSettingData":
                    return new MsvmVirtualEthernetSwitchNicTeamingSettingData(scope, cimInstance);
                case "Msvm_VirtualEthernetSwitchBandwidthSettingData":
                    return new MsvmVirtualEthernetSwitchBandwidthSettingData(scope, cimInstance);
                case "Msvm_EthernetSwitchHardwareOffloadSettingData":
                    return new MsvmEthernetSwitchHardwareOffloadSettingData(scope, cimInstance);
                case "Msvm_EthernetSwitchPortTeamMappingSettingData":
                    return new MsvmEthernetSwitchPortTeamMappingSettingData(scope, cimInstance);
                case "Msvm_EthernetSwitchPortIsolationSettingData":
                    return new MsvmEthernetSwitchPortIsolationSettingData(scope, cimInstance);
                case "Msvm_EthernetSwitchPortVlanSettingData":
                    return new MsvmEthernetSwitchPortVlanSettingData(scope, cimInstance);
                case "Msvm_EthernetSwitchPortAclSettingData":
                    return new MsvmEthernetSwitchPortAclSettingData(scope, cimInstance);
                case "Msvm_EthernetSwitchPortRdmaSettingData":
                    return new MsvmEthernetSwitchPortRdmaSettingData(scope, cimInstance);
                case "Msvm_EthernetSwitchPortBandwidthSettingData":
                    return new MsvmEthernetSwitchPortBandwidthSettingData(scope, cimInstance);
                case "Msvm_EthernetSwitchPortExtendedAclSettingData":
                    return new MsvmEthernetSwitchPortExtendedAclSettingData(scope, cimInstance);
                case "Msvm_EthernetSwitchPortRoutingDomainSettingData":
                    return new MsvmEthernetSwitchPortRoutingDomainSettingData(scope, cimInstance);
                case "Msvm_EthernetSwitchPortProfileSettingData":
                    return new MsvmEthernetSwitchPortProfileSettingData(scope, cimInstance);
                case "Msvm_EthernetSwitchPortOffloadSettingData":
                    return new MsvmEthernetSwitchPortOffloadSettingData(scope, cimInstance);
                case "Msvm_EthernetSwitchPortSecuritySettingData":
                    return new MsvmEthernetSwitchPortSecuritySettingData(scope, cimInstance);
                case "Msvm_ReplicationSettingData":
                    return new MsvmReplicationSettingData(scope, cimInstance);
                case "Msvm_VirtualSystemSettingData":
                    return new MsvmVirtualSystemSettingData(scope, cimInstance);
                case "Msvm_VirtualEthernetSwitchSettingData":
                    return new MsvmVirtualEthernetSwitchSettingData(scope, cimInstance);
                case "Msvm_VirtualFcSwitchSettingData":
                    return new MsvmVirtualFcSwitchSettingData(scope, cimInstance);
                case "Msvm_DiskMergeSettingData":
                    return new MsvmDiskMergeSettingData(scope, cimInstance);
                case "Msvm_ResourceAllocationSettingData":
                    return new MsvmResourceAllocationSettingData(scope, cimInstance);
                case "Msvm_SerialPortSettingData":
                    return new MsvmSerialPortSettingData(scope, cimInstance);
                case "Msvm_GuestServiceInterfaceComponentSettingData":
                    return new MsvmGuestServiceInterfaceComponentSettingData(scope, cimInstance);
                case "Msvm_HeartbeatComponentSettingData":
                    return new MsvmHeartbeatComponentSettingData(scope, cimInstance);
                case "Msvm_KvpExchangeComponentSettingData":
                    return new MsvmKvpExchangeComponentSettingData(scope, cimInstance);
                case "Msvm_ShutdownComponentSettingData":
                    return new MsvmShutdownComponentSettingData(scope, cimInstance);
                case "Msvm_TimeSyncComponentSettingData":
                    return new MsvmTimeSyncComponentSettingData(scope, cimInstance);
                case "Msvm_VssComponentSettingData":
                    return new MsvmVssComponentSettingData(scope, cimInstance);
                case "Msvm_RdvComponentSettingData":
                    return new MsvmRdvComponentSettingData(scope, cimInstance);
                case "Msvm_BatterySettingData":
                    return new MsvmBatterySettingData(scope, cimInstance);
                case "Msvm_StorageAllocationSettingData":
                    return new MsvmStorageAllocationSettingData(scope, cimInstance);
                case "Msvm_MemorySettingData":
                    return new MsvmMemorySettingData(scope, cimInstance);
                case "Msvm_ProcessorSettingData":
                    return new MsvmProcessorSettingData(scope, cimInstance);
                case "Msvm_VirtualLogicalUnitSettingData":
                    return new MsvmVirtualLogicalUnitSettingData(scope, cimInstance);
                case "Msvm_SyntheticDisplayControllerSettingData":
                    return new MsvmSyntheticDisplayControllerSettingData(scope, cimInstance);
                case "Msvm_PciExpressSettingData":
                    return new MsvmPciExpressSettingData(scope, cimInstance);
                case "Msvm_GpuPartitionSettingData":
                    return new MsvmGpuPartitionSettingData(scope, cimInstance);
                case "Msvm_SyntheticEthernetPortSettingData":
                    return new MsvmSyntheticEthernetPortSettingData(scope, cimInstance);
                case "Msvm_EthernetPortAllocationSettingData":
                    return new MsvmEthernetPortAllocationSettingData(scope, cimInstance);
                case "Msvm_EmulatedEthernetPortSettingData":
                    return new MsvmEmulatedEthernetPortSettingData(scope, cimInstance);
                case "Msvm_Synthetic3DDisplayControllerSettingData":
                    return new MsvmSynthetic3DDisplayControllerSettingData(scope, cimInstance);
                case "Msvm_FcPortAllocationSettingData":
                    return new MsvmFcPortAllocationSettingData(scope, cimInstance);
                case "Msvm_FlexIoDeviceSettingData":
                    return new MsvmFlexIoDeviceSettingData(scope, cimInstance);
                case "Msvm_SyntheticFcPortSettingData":
                    return new MsvmSyntheticFcPortSettingData(scope, cimInstance);
                case "Msvm_BootSourceSettingData":
                    return new MsvmBootSourceSettingData(scope, cimInstance);
                case "Msvm_VirtualSystemManagementServiceSettingData":
                    return new MsvmVirtualSystemManagementServiceSettingData(scope, cimInstance);
                case "Msvm_VirtualSystemMigrationServiceSettingData":
                    return new MsvmVirtualSystemMigrationServiceSettingData(scope, cimInstance);
                case "Msvm_MetricServiceSettingData":
                    return new MsvmMetricServiceSettingData(scope, cimInstance);
                case "Msvm_VirtualHardDiskSettingData":
                    return new MsvmVirtualHardDiskSettingData(scope, cimInstance);
                case "Msvm_CopyFileToGuestSettingData":
                    return new MsvmCopyFileToGuestSettingData(scope, cimInstance);
                case "Msvm_SecuritySettingData":
                    return new MsvmSecuritySettingData(scope, cimInstance);
                case "Msvm_StorageSettingData":
                    return new MsvmStorageSettingData(scope, cimInstance);
                case "Msvm_VirtualSystemExportSettingData":
                    return new MsvmVirtualSystemExportSettingData(scope, cimInstance);
                case "Msvm_FailoverNetworkAdapterSettingData":
                    return new MsvmFailoverNetworkAdapterSettingData(scope, cimInstance);
                case "Msvm_CollectionReferencePointSettingData":
                    return new MsvmCollectionReferencePointSettingData(scope, cimInstance);
                case "Msvm_CollectionSnapshotExportSettingData":
                    return new MsvmCollectionSnapshotExportSettingData(scope, cimInstance);
                case "Msvm_TerminalServiceSettingData":
                    return new MsvmTerminalServiceSettingData(scope, cimInstance);
                case "Msvm_AssignableDeviceDismountSettingData":
                    return new MsvmAssignableDeviceDismountSettingData(scope, cimInstance);
                case "Msvm_VirtualSystemMigrationSettingData":
                    return new MsvmVirtualSystemMigrationSettingData(scope, cimInstance);
                case "Msvm_ResourcePoolSettingData":
                    return new MsvmResourcePoolSettingData(scope, cimInstance);
                case "Msvm_VirtualSystemReferencePointExportSettingData":
                    return new MsvmVirtualSystemReferencePointExportSettingData(scope, cimInstance);
                case "Msvm_ReplicationAuthorizationSettingData":
                    return new MsvmReplicationAuthorizationSettingData(scope, cimInstance);
                case "Msvm_Synthetic3DServiceSettingData":
                    return new MsvmSynthetic3DServiceSettingData(scope, cimInstance);
                case "Msvm_VirtualSystemMigrationNetworkSettingData":
                    return new MsvmVirtualSystemMigrationNetworkSettingData(scope, cimInstance);
                case "Msvm_GuestCommunicationServiceSettingData":
                    return new MsvmGuestCommunicationServiceSettingData(scope, cimInstance);
                case "Msvm_NetworkConnectionDiagnosticSettingData":
                    return new MsvmNetworkConnectionDiagnosticSettingData(scope, cimInstance);
                case "Msvm_VirtualSystemReferencePointSettingData":
                    return new MsvmVirtualSystemReferencePointSettingData(scope, cimInstance);
                case "Msvm_CollectionReferencePointExportSettingData":
                    return new MsvmCollectionReferencePointExportSettingData(scope, cimInstance);
                case "Msvm_VirtualSystemSnapshotSettingData":
                    return new MsvmVirtualSystemSnapshotSettingData(scope, cimInstance);
                case "Msvm_ReplicationServiceSettingData":
                    return new MsvmReplicationServiceSettingData(scope, cimInstance);
                case "Msvm_EthernetSwitchPortOffloadData":
                    return new MsvmEthernetSwitchPortOffloadData(scope, cimInstance);
                case "Msvm_EthernetSwitchPortBandwidthData":
                    return new MsvmEthernetSwitchPortBandwidthData(scope, cimInstance);
                case "Msvm_EthernetSwitchOperationalData":
                    return new MsvmEthernetSwitchOperationalData(scope, cimInstance);
                case "Msvm_EthernetSwitchHardwareOffloadData":
                    return new MsvmEthernetSwitchHardwareOffloadData(scope, cimInstance);
                case "Msvm_EthernetSwitchBandwidthData":
                    return new MsvmEthernetSwitchBandwidthData(scope, cimInstance);
                case "Msvm_ComputerSystem":
                    return new MsvmComputerSystem(scope, cimInstance);
                case "Msvm_PlannedComputerSystem":
                    return new MsvmPlannedComputerSystem(scope, cimInstance);
                case "Msvm_VirtualEthernetSwitch":
                    return new MsvmVirtualEthernetSwitch(scope, cimInstance);
                case "Msvm_VirtualFcSwitch":
                    return new MsvmVirtualFcSwitch(scope, cimInstance);
                case "Msvm_PartitionableGpu":
                    return new MsvmPartitionableGpu(scope, cimInstance);
                case "Msvm_AssignableDeviceService":
                    return new MsvmAssignableDeviceService(scope, cimInstance);
                case "Msvm_VirtualSystemManagementService":
                    return new MsvmVirtualSystemManagementService(scope, cimInstance);
                case "Msvm_VirtualEthernetSwitchManagementService":
                    return new MsvmVirtualEthernetSwitchManagementService(scope, cimInstance);
                case "Msvm_ImageManagementService":
                    return new MsvmImageManagementService(scope, cimInstance);
                case "Msvm_VirtualSystemMigrationService":
                    return new MsvmVirtualSystemMigrationService(scope, cimInstance);
                case "Msvm_MetricService":
                    return new MsvmMetricService(scope, cimInstance);
                case "Msvm_VirtualSystemSnapshotService":
                    return new MsvmVirtualSystemSnapshotService(scope, cimInstance);
                case "Msvm_CollectionReferencePointService":
                    return new MsvmCollectionReferencePointService(scope, cimInstance);
                case "Msvm_VirtualSystemReferencePointService":
                    return new MsvmVirtualSystemReferencePointService(scope, cimInstance);
                case "Msvm_TransparentBridgingService":
                    return new MsvmTransparentBridgingService(scope, cimInstance);
                case "Msvm_VssService":
                    return new MsvmVssService(scope, cimInstance);
                case "Msvm_GuestFileService":
                    return new MsvmGuestFileService(scope, cimInstance);
                case "Msvm_GuestCommunicationService":
                    return new MsvmGuestCommunicationService(scope, cimInstance);
                case "Msvm_CollectionSnapshotService":
                    return new MsvmCollectionSnapshotService(scope, cimInstance);
                case "Msvm_ResourcePoolConfigurationService":
                    return new MsvmResourcePoolConfigurationService(scope, cimInstance);
                case "Msvm_Synthetic3DService":
                    return new MsvmSynthetic3DService(scope, cimInstance);
                case "Msvm_ReplicationService":
                    return new MsvmReplicationService(scope, cimInstance);
                case "Msvm_CollectionManagementService":
                    return new MsvmCollectionManagementService(scope, cimInstance);
                case "Msvm_SecurityService":
                    return new MsvmSecurityService(scope, cimInstance);
                case "Msvm_TerminalService":
                    return new MsvmTerminalService(scope, cimInstance);
                case "Msvm_ShutdownComponent":
                    return new MsvmShutdownComponent(scope, cimInstance);
                case "Msvm_TimeSyncComponent":
                    return new MsvmTimeSyncComponent(scope, cimInstance);
                case "Msvm_GpuPartition":
                    return new MsvmGpuPartition(scope, cimInstance);
                case "Msvm_HeartbeatComponent":
                    return new MsvmHeartbeatComponent(scope, cimInstance);
                case "Msvm_Keyboard":
                    return new MsvmKeyboard(scope, cimInstance);
                case "Msvm_Ps2Mouse":
                    return new MsvmPs2Mouse(scope, cimInstance);
                case "Msvm_SyntheticMouse":
                    return new MsvmSyntheticMouse(scope, cimInstance);
                case "Msvm_SyntheticKeyboard":
                    return new MsvmSyntheticKeyboard(scope, cimInstance);
                case "Msvm_TPM":
                    return new MsvmTPM(scope, cimInstance);
                case "Msvm_FlexIoDevice":
                    return new MsvmFlexIoDevice(scope, cimInstance);
                case "Msvm_PciExpress":
                    return new MsvmPciExpress(scope, cimInstance);
                case "Msvm_SCSIProtocolController":
                    return new MsvmSCSIProtocolController(scope, cimInstance);
                case "Msvm_KvpExchangeComponent":
                    return new MsvmKvpExchangeComponent(scope, cimInstance);
                case "Msvm_Physical3dGraphicsProcessor":
                    return new MsvmPhysical3dGraphicsProcessor(scope, cimInstance);
                case "Msvm_VssComponent":
                    return new MsvmVssComponent(scope, cimInstance);
                case "Msvm_DiskDrive":
                    return new MsvmDiskDrive(scope, cimInstance);
                case "Msvm_DisketteDrive":
                    return new MsvmDisketteDrive(scope, cimInstance);
                case "Msvm_DVDDrive":
                    return new MsvmDVDDrive(scope, cimInstance);
                case "Msvm_Battery":
                    return new MsvmBattery(scope, cimInstance);
                case "Msvm_VideoHead":
                    return new MsvmVideoHead(scope, cimInstance);
                case "Msvm_IDEController":
                    return new MsvmIDEController(scope, cimInstance);
                case "Msvm_S3DisplayController":
                    return new MsvmS3DisplayController(scope, cimInstance);
                case "Msvm_Synthetic3DDisplayController":
                    return new MsvmSynthetic3DDisplayController(scope, cimInstance);
                case "Msvm_SyntheticDisplayController":
                    return new MsvmSyntheticDisplayController(scope, cimInstance);
                case "Msvm_PersistentMemoryController":
                    return new MsvmPersistentMemoryController(scope, cimInstance);
                case "Msvm_SerialController":
                    return new MsvmSerialController(scope, cimInstance);
                case "Msvm_DisketteController":
                    return new MsvmDisketteController(scope, cimInstance);
                case "Msvm_RdvComponent":
                    return new MsvmRdvComponent(scope, cimInstance);
                case "Msvm_EthernetSwitchPort":
                    return new MsvmEthernetSwitchPort(scope, cimInstance);
                case "Msvm_InternalEthernetPort":
                    return new MsvmInternalEthernetPort(scope, cimInstance);
                case "Msvm_SyntheticEthernetPort":
                    return new MsvmSyntheticEthernetPort(scope, cimInstance);
                case "Msvm_ExternalEthernetPort":
                    return new MsvmExternalEthernetPort(scope, cimInstance);
                case "Msvm_EmulatedEthernetPort":
                    return new MsvmEmulatedEthernetPort(scope, cimInstance);
                case "Msvm_SyntheticFcPort":
                    return new MsvmSyntheticFcPort(scope, cimInstance);
                case "Msvm_FcSwitchPort":
                    return new MsvmFcSwitchPort(scope, cimInstance);
                case "Msvm_ExternalFcPort":
                    return new MsvmExternalFcPort(scope, cimInstance);
                case "Msvm_WiFiPort":
                    return new MsvmWiFiPort(scope, cimInstance);
                case "Msvm_SerialPort":
                    return new MsvmSerialPort(scope, cimInstance);
                case "Msvm_GuestServiceInterfaceComponent":
                    return new MsvmGuestServiceInterfaceComponent(scope, cimInstance);
                case "Msvm_Memory":
                    return new MsvmMemory(scope, cimInstance);
                case "Msvm_LogicalDisk":
                    return new MsvmLogicalDisk(scope, cimInstance);
                case "Msvm_Processor":
                    return new MsvmProcessor(scope, cimInstance);
                case "Msvm_TerminalConnection":
                    return new MsvmTerminalConnection(scope, cimInstance);
                case "Msvm_EthernetSwitchExtension":
                    return new MsvmEthernetSwitchExtension(scope, cimInstance);
                case "Msvm_FcEndpoint":
                    return new MsvmFcEndpoint(scope, cimInstance);
                case "Msvm_WiFiEndpoint":
                    return new MsvmWiFiEndpoint(scope, cimInstance);
                case "Msvm_LANEndpoint":
                    return new MsvmLANEndpoint(scope, cimInstance);
                case "Msvm_VLANEndpoint":
                    return new MsvmVLANEndpoint(scope, cimInstance);
                case "Msvm_NumaNode":
                    return new MsvmNumaNode(scope, cimInstance);
                case "Msvm_SecurityElement":
                    return new MsvmSecurityElement(scope, cimInstance);
                case "Msvm_ConcreteJob":
                    return new MsvmConcreteJob(scope, cimInstance);
                case "Msvm_MigrationJob":
                    return new MsvmMigrationJob(scope, cimInstance);
                case "Msvm_CopyFileToGuestJob":
                    return new MsvmCopyFileToGuestJob(scope, cimInstance);
                case "Msvm_StorageJob":
                    return new MsvmStorageJob(scope, cimInstance);
                case "Msvm_CollectionReferencePointExportJob":
                    return new MsvmCollectionReferencePointExportJob(scope, cimInstance);
                case "Msvm_VirtualSystemReferencePointExportJob":
                    return new MsvmVirtualSystemReferencePointExportJob(scope, cimInstance);
                case "Msvm_Synth3dVideoPool":
                    return new MsvmSynth3dVideoPool(scope, cimInstance);
                case "Msvm_ProcessorPool":
                    return new MsvmProcessorPool(scope, cimInstance);
                case "Msvm_ResourcePool":
                    return new MsvmResourcePool(scope, cimInstance);
                case "Msvm_DynamicForwardingEntry":
                    return new MsvmDynamicForwardingEntry(scope, cimInstance);
                case "Msvm_MountedStorageImage":
                    return new MsvmMountedStorageImage(scope, cimInstance);
                case "Msvm_BIOSElement":
                    return new MsvmBIOSElement(scope, cimInstance);
                case "Msvm_ReplicationRelationship":
                    return new MsvmReplicationRelationship(scope, cimInstance);
                case "Msvm_ReplicationProvider":
                    return new MsvmReplicationProvider(scope, cimInstance);
                case "Msvm_InstalledEthernetSwitchExtension":
                    return new MsvmInstalledEthernetSwitchExtension(scope, cimInstance);
                case "Msvm_SummaryInformation":
                    return new MsvmSummaryInformation(scope, cimInstance);
                case "Msvm_VirtualSystemManagementCapabilities":
                    return new MsvmVirtualSystemManagementCapabilities(scope, cimInstance);
                case "Msvm_VirtualEthernetSwitchManagementCapabilities":
                    return new MsvmVirtualEthernetSwitchManagementCapabilities(scope, cimInstance);
                case "Msvm_VirtualSystemCapabilities":
                    return new MsvmVirtualSystemCapabilities(scope, cimInstance);
                case "Msvm_MetricServiceCapabilities":
                    return new MsvmMetricServiceCapabilities(scope, cimInstance);
                case "Msvm_AllocationCapabilities":
                    return new MsvmAllocationCapabilities(scope, cimInstance);
                case "Msvm_ExternalEthernetPortCapabilities":
                    return new MsvmExternalEthernetPortCapabilities(scope, cimInstance);
                case "Msvm_ResourcePoolConfigurationCapabilities":
                    return new MsvmResourcePoolConfigurationCapabilities(scope, cimInstance);
                case "Msvm_VirtualSystemMigrationCapabilities":
                    return new MsvmVirtualSystemMigrationCapabilities(scope, cimInstance);
                case "Msvm_EthernetSwitchFeatureCapabilities":
                    return new MsvmEthernetSwitchFeatureCapabilities(scope, cimInstance);
                case "Msvm_VirtualSystemReferencePoint":
                    return new MsvmVirtualSystemReferencePoint(scope, cimInstance);
                case "Msvm_ReplicationStatistics":
                    return new MsvmReplicationStatistics(scope, cimInstance);
                case "Msvm_PhysicalGPUInfo":
                    return new MsvmPhysicalGPUInfo(scope, cimInstance);
                case "Msvm_AggregationMetricDefinition":
                    return new MsvmAggregationMetricDefinition(scope, cimInstance);
                case "Msvm_BaseMetricDefinition":
                    return new MsvmBaseMetricDefinition(scope, cimInstance);
                case "Msvm_NumaNodeTopology":
                    return new MsvmNumaNodeTopology(scope, cimInstance);
                case "Msvm_SnapshotCollection":
                    return new MsvmSnapshotCollection(scope, cimInstance);
                case "Msvm_VirtualSystemCollection":
                    return new MsvmVirtualSystemCollection(scope, cimInstance);
                case "Msvm_ManagementCollection":
                    return new MsvmManagementCollection(scope, cimInstance);
                case "Msvm_ReferencePointCollection":
                    return new MsvmReferencePointCollection(scope, cimInstance);
                case "Msvm_AggregationMetricValue":
                    return new MsvmAggregationMetricValue(scope, cimInstance);
                case "Msvm_BaseMetricValue":
                    return new MsvmBaseMetricValue(scope, cimInstance);
                case "Msvm_MoveUnmanagedVhd":
                    return new MsvmMoveUnmanagedVhd(scope, cimInstance);
                case "Msvm_KvpExchangeDataItem":
                    return new MsvmKvpExchangeDataItem(scope, cimInstance);
                case "MSFT_WmiError":
                    return new MSFTWmiError(scope, cimInstance);
                case "MSFT_ExtendedStatus":
                    return new MSFTExtendedStatus(scope, cimInstance);
                case "Msvm_Error":
                    return new MsvmError(scope, cimInstance);
                case "Msvm_VirtualHardDiskState":
                    return new MsvmVirtualHardDiskState(scope, cimInstance);
                case "Msvm_GuestNetworkAdapterConfiguration":
                    return new MsvmGuestNetworkAdapterConfiguration(scope, cimInstance);
                case "__ExtendedStatus":
                    return new ExtendedStatus(scope, cimInstance);
                case "__NTLMUser9X":
                    return new NTLMUser9X(scope, cimInstance);
                case "Msvm_GuestClusterInformation":
                    return new MsvmGuestClusterInformation(scope, cimInstance);
                case "Msvm_CompatibilityVector":
                    return new MsvmCompatibilityVector(scope, cimInstance);
                case "Msvm_VHDSetInformation":
                    return new MsvmVHDSetInformation(scope, cimInstance);
                case "Msvm_VHDSnapshotInformation":
                    return new MsvmVHDSnapshotInformation(scope, cimInstance);
                case "Msvm_InteractiveSessionACE":
                    return new MsvmInteractiveSessionACE(scope, cimInstance);
                case "Msvm_VirtualMachineToDisks":
                    return new MsvmVirtualMachineToDisks(scope, cimInstance);
                case "Msvm_NetworkConnectionDiagnosticInformation":
                    return new MsvmNetworkConnectionDiagnosticInformation(scope, cimInstance);
                case "Msvm_ServicingSettings":
                    return new MsvmServicingSettings(scope, cimInstance);
                default:
                    throw new KeyNotFoundException();
            }
        }

        private static Dictionary<Type, string> _typeMap = new Dictionary<Type, string>{ { typeof ( SystemClass ) ,  "__SystemClass" }
        ,  { typeof ( ThisNAMESPACE ) ,  "__thisNAMESPACE" }
        ,  { typeof ( NAMESPACE ) ,  "__NAMESPACE" }
        ,  { typeof ( Provider ) ,  "__Provider" }
        ,  { typeof ( Win32Provider ) ,  "__Win32Provider" }
        ,  { typeof ( ProviderRegistration ) ,  "__ProviderRegistration" }
        ,  { typeof ( EventProviderRegistration ) ,  "__EventProviderRegistration" }
        ,  { typeof ( ObjectProviderRegistration ) ,  "__ObjectProviderRegistration" }
        ,  { typeof ( ClassProviderRegistration ) ,  "__ClassProviderRegistration" }
        ,  { typeof ( InstanceProviderRegistration ) ,  "__InstanceProviderRegistration" }
        ,  { typeof ( MethodProviderRegistration ) ,  "__MethodProviderRegistration" }
        ,  { typeof ( PropertyProviderRegistration ) ,  "__PropertyProviderRegistration" }
        ,  { typeof ( EventConsumerProviderRegistration ) ,  "__EventConsumerProviderRegistration" }
        ,  { typeof ( IndicationRelated ) ,  "__IndicationRelated" }
        ,  { typeof ( EventFilter ) ,  "__EventFilter" }
        ,  { typeof ( EventConsumer ) ,  "__EventConsumer" }
        ,  { typeof ( Event ) ,  "__Event" }
        ,  { typeof ( InstanceOperationEvent ) ,  "__InstanceOperationEvent" }
        ,  { typeof ( InstanceCreationEvent ) ,  "__InstanceCreationEvent" }
        ,  { typeof ( InstanceDeletionEvent ) ,  "__InstanceDeletionEvent" }
        ,  { typeof ( InstanceModificationEvent ) ,  "__InstanceModificationEvent" }
        ,  { typeof ( MethodInvocationEvent ) ,  "__MethodInvocationEvent" }
        ,  { typeof ( ExtrinsicEvent ) ,  "__ExtrinsicEvent" }
        ,  { typeof ( CIMIndication ) ,  "CIM_Indication" }
        ,  { typeof ( CIMProcessIndication ) ,  "CIM_ProcessIndication" }
        ,  { typeof ( CIMAlertIndication ) ,  "CIM_AlertIndication" }
        ,  { typeof ( MsvmStorageAlert ) ,  "Msvm_StorageAlert" }
        ,  { typeof ( CIMClassIndication ) ,  "CIM_ClassIndication" }
        ,  { typeof ( CIMClassDeletion ) ,  "CIM_ClassDeletion" }
        ,  { typeof ( CIMClassCreation ) ,  "CIM_ClassCreation" }
        ,  { typeof ( CIMClassModification ) ,  "CIM_ClassModification" }
        ,  { typeof ( CIMInstIndication ) ,  "CIM_InstIndication" }
        ,  { typeof ( CIMInstCreation ) ,  "CIM_InstCreation" }
        ,  { typeof ( CIMInstModification ) ,  "CIM_InstModification" }
        ,  { typeof ( CIMInstDeletion ) ,  "CIM_InstDeletion" }
        ,  { typeof ( SystemEvent ) ,  "__SystemEvent" }
        ,  { typeof ( EventDroppedEvent ) ,  "__EventDroppedEvent" }
        ,  { typeof ( EventQueueOverflowEvent ) ,  "__EventQueueOverflowEvent" }
        ,  { typeof ( QOSFailureEvent ) ,  "__QOSFailureEvent" }
        ,  { typeof ( ConsumerFailureEvent ) ,  "__ConsumerFailureEvent" }
        ,  { typeof ( ClassOperationEvent ) ,  "__ClassOperationEvent" }
        ,  { typeof ( ClassDeletionEvent ) ,  "__ClassDeletionEvent" }
        ,  { typeof ( ClassModificationEvent ) ,  "__ClassModificationEvent" }
        ,  { typeof ( ClassCreationEvent ) ,  "__ClassCreationEvent" }
        ,  { typeof ( NamespaceOperationEvent ) ,  "__NamespaceOperationEvent" }
        ,  { typeof ( NamespaceModificationEvent ) ,  "__NamespaceModificationEvent" }
        ,  { typeof ( NamespaceDeletionEvent ) ,  "__NamespaceDeletionEvent" }
        ,  { typeof ( NamespaceCreationEvent ) ,  "__NamespaceCreationEvent" }
        ,  { typeof ( TimerEvent ) ,  "__TimerEvent" }
        ,  { typeof ( AggregateEvent ) ,  "__AggregateEvent" }
        ,  { typeof ( TimerNextFiring ) ,  "__TimerNextFiring" }
        ,  { typeof ( EventGenerator ) ,  "__EventGenerator" }
        ,  { typeof ( TimerInstruction ) ,  "__TimerInstruction" }
        ,  { typeof ( AbsoluteTimerInstruction ) ,  "__AbsoluteTimerInstruction" }
        ,  { typeof ( IntervalTimerInstruction ) ,  "__IntervalTimerInstruction" }
        ,  { typeof ( SystemSecurity ) ,  "__SystemSecurity" }
        ,  { typeof ( CIMManagedElement ) ,  "CIM_ManagedElement" }
        ,  { typeof ( CIMSettingData ) ,  "CIM_SettingData" }
        ,  { typeof ( MsvmFeatureSettingData ) ,  "Msvm_FeatureSettingData" }
        ,  { typeof ( MsvmEthernetSwitchFeatureSettingData ) ,  "Msvm_EthernetSwitchFeatureSettingData" }
        ,  { typeof ( MsvmVirtualEthernetSwitchNicTeamingSettingData ) ,  "Msvm_VirtualEthernetSwitchNicTeamingSettingData" }
        ,  { typeof ( MsvmVirtualEthernetSwitchBandwidthSettingData ) ,  "Msvm_VirtualEthernetSwitchBandwidthSettingData" }
        ,  { typeof ( MsvmEthernetSwitchHardwareOffloadSettingData ) ,  "Msvm_EthernetSwitchHardwareOffloadSettingData" }
        ,  { typeof ( MsvmEthernetSwitchPortFeatureSettingData ) ,  "Msvm_EthernetSwitchPortFeatureSettingData" }
        ,  { typeof ( MsvmEthernetSwitchPortTeamMappingSettingData ) ,  "Msvm_EthernetSwitchPortTeamMappingSettingData" }
        ,  { typeof ( MsvmEthernetSwitchPortIsolationSettingData ) ,  "Msvm_EthernetSwitchPortIsolationSettingData" }
        ,  { typeof ( MsvmEthernetSwitchPortVlanSettingData ) ,  "Msvm_EthernetSwitchPortVlanSettingData" }
        ,  { typeof ( MsvmEthernetSwitchPortAclSettingData ) ,  "Msvm_EthernetSwitchPortAclSettingData" }
        ,  { typeof ( MsvmEthernetSwitchPortRdmaSettingData ) ,  "Msvm_EthernetSwitchPortRdmaSettingData" }
        ,  { typeof ( MsvmEthernetSwitchPortBandwidthSettingData ) ,  "Msvm_EthernetSwitchPortBandwidthSettingData" }
        ,  { typeof ( MsvmEthernetSwitchPortExtendedAclSettingData ) ,  "Msvm_EthernetSwitchPortExtendedAclSettingData" }
        ,  { typeof ( MsvmEthernetSwitchPortRoutingDomainSettingData ) ,  "Msvm_EthernetSwitchPortRoutingDomainSettingData" }
        ,  { typeof ( MsvmEthernetSwitchPortProfileSettingData ) ,  "Msvm_EthernetSwitchPortProfileSettingData" }
        ,  { typeof ( MsvmEthernetSwitchPortOffloadSettingData ) ,  "Msvm_EthernetSwitchPortOffloadSettingData" }
        ,  { typeof ( MsvmEthernetSwitchPortSecuritySettingData ) ,  "Msvm_EthernetSwitchPortSecuritySettingData" }
        ,  { typeof ( CIMVirtualSystemSettingData ) ,  "CIM_VirtualSystemSettingData" }
        ,  { typeof ( MsvmReplicationSettingData ) ,  "Msvm_ReplicationSettingData" }
        ,  { typeof ( MsvmVirtualSystemSettingData ) ,  "Msvm_VirtualSystemSettingData" }
        ,  { typeof ( CIMVirtualEthernetSwitchSettingData ) ,  "CIM_VirtualEthernetSwitchSettingData" }
        ,  { typeof ( MsvmVirtualEthernetSwitchSettingData ) ,  "Msvm_VirtualEthernetSwitchSettingData" }
        ,  { typeof ( MsvmVirtualFcSwitchSettingData ) ,  "Msvm_VirtualFcSwitchSettingData" }
        ,  { typeof ( MsvmDiskMergeSettingData ) ,  "Msvm_DiskMergeSettingData" }
        ,  { typeof ( CIMResourceAllocationSettingData ) ,  "CIM_ResourceAllocationSettingData" }
        ,  { typeof ( MsvmResourceAllocationSettingData ) ,  "Msvm_ResourceAllocationSettingData" }
        ,  { typeof ( MsvmSerialPortSettingData ) ,  "Msvm_SerialPortSettingData" }
        ,  { typeof ( MsvmGuestServiceInterfaceComponentSettingData ) ,  "Msvm_GuestServiceInterfaceComponentSettingData" }
        ,  { typeof ( MsvmHeartbeatComponentSettingData ) ,  "Msvm_HeartbeatComponentSettingData" }
        ,  { typeof ( MsvmKvpExchangeComponentSettingData ) ,  "Msvm_KvpExchangeComponentSettingData" }
        ,  { typeof ( MsvmShutdownComponentSettingData ) ,  "Msvm_ShutdownComponentSettingData" }
        ,  { typeof ( MsvmTimeSyncComponentSettingData ) ,  "Msvm_TimeSyncComponentSettingData" }
        ,  { typeof ( MsvmVssComponentSettingData ) ,  "Msvm_VssComponentSettingData" }
        ,  { typeof ( MsvmRdvComponentSettingData ) ,  "Msvm_RdvComponentSettingData" }
        ,  { typeof ( MsvmBatterySettingData ) ,  "Msvm_BatterySettingData" }
        ,  { typeof ( CIMStorageAllocationSettingData ) ,  "CIM_StorageAllocationSettingData" }
        ,  { typeof ( MsvmStorageAllocationSettingData ) ,  "Msvm_StorageAllocationSettingData" }
        ,  { typeof ( MsvmMemorySettingData ) ,  "Msvm_MemorySettingData" }
        ,  { typeof ( MsvmProcessorSettingData ) ,  "Msvm_ProcessorSettingData" }
        ,  { typeof ( MsvmVirtualLogicalUnitSettingData ) ,  "Msvm_VirtualLogicalUnitSettingData" }
        ,  { typeof ( MsvmSyntheticDisplayControllerSettingData ) ,  "Msvm_SyntheticDisplayControllerSettingData" }
        ,  { typeof ( MsvmPciExpressSettingData ) ,  "Msvm_PciExpressSettingData" }
        ,  { typeof ( MsvmGpuPartitionSettingData ) ,  "Msvm_GpuPartitionSettingData" }
        ,  { typeof ( CIMEthernetPortAllocationSettingData ) ,  "CIM_EthernetPortAllocationSettingData" }
        ,  { typeof ( MsvmSyntheticEthernetPortSettingData ) ,  "Msvm_SyntheticEthernetPortSettingData" }
        ,  { typeof ( MsvmEthernetPortAllocationSettingData ) ,  "Msvm_EthernetPortAllocationSettingData" }
        ,  { typeof ( MsvmEmulatedEthernetPortSettingData ) ,  "Msvm_EmulatedEthernetPortSettingData" }
        ,  { typeof ( MsvmSynthetic3DDisplayControllerSettingData ) ,  "Msvm_Synthetic3DDisplayControllerSettingData" }
        ,  { typeof ( MsvmFcPortAllocationSettingData ) ,  "Msvm_FcPortAllocationSettingData" }
        ,  { typeof ( MsvmFlexIoDeviceSettingData ) ,  "Msvm_FlexIoDeviceSettingData" }
        ,  { typeof ( MsvmSyntheticFcPortSettingData ) ,  "Msvm_SyntheticFcPortSettingData" }
        ,  { typeof ( MsvmBootSourceSettingData ) ,  "Msvm_BootSourceSettingData" }
        ,  { typeof ( MsvmVirtualSystemManagementServiceSettingData ) ,  "Msvm_VirtualSystemManagementServiceSettingData" }
        ,  { typeof ( MsvmVirtualSystemMigrationServiceSettingData ) ,  "Msvm_VirtualSystemMigrationServiceSettingData" }
        ,  { typeof ( MsvmMetricServiceSettingData ) ,  "Msvm_MetricServiceSettingData" }
        ,  { typeof ( MsvmVirtualHardDiskSettingData ) ,  "Msvm_VirtualHardDiskSettingData" }
        ,  { typeof ( CIMVLANEndpointSettingData ) ,  "CIM_VLANEndpointSettingData" }
        ,  { typeof ( MsvmCopyFileToGuestSettingData ) ,  "Msvm_CopyFileToGuestSettingData" }
        ,  { typeof ( MsvmSecuritySettingData ) ,  "Msvm_SecuritySettingData" }
        ,  { typeof ( MsvmSystemComponentSettingData ) ,  "Msvm_SystemComponentSettingData" }
        ,  { typeof ( MsvmStorageSettingData ) ,  "Msvm_StorageSettingData" }
        ,  { typeof ( MsvmVirtualSystemExportSettingData ) ,  "Msvm_VirtualSystemExportSettingData" }
        ,  { typeof ( MsvmFailoverNetworkAdapterSettingData ) ,  "Msvm_FailoverNetworkAdapterSettingData" }
        ,  { typeof ( MsvmCollectionReferencePointSettingData ) ,  "Msvm_CollectionReferencePointSettingData" }
        ,  { typeof ( MsvmCollectionSettingData ) ,  "Msvm_CollectionSettingData" }
        ,  { typeof ( MsvmCollectionSnapshotExportSettingData ) ,  "Msvm_CollectionSnapshotExportSettingData" }
        ,  { typeof ( MsvmTerminalServiceSettingData ) ,  "Msvm_TerminalServiceSettingData" }
        ,  { typeof ( MsvmAssignableDeviceDismountSettingData ) ,  "Msvm_AssignableDeviceDismountSettingData" }
        ,  { typeof ( CIMVirtualSystemMigrationSettingData ) ,  "CIM_VirtualSystemMigrationSettingData" }
        ,  { typeof ( MsvmVirtualSystemMigrationSettingData ) ,  "Msvm_VirtualSystemMigrationSettingData" }
        ,  { typeof ( MsvmAbstractResourcePoolSettingData ) ,  "Msvm_AbstractResourcePoolSettingData" }
        ,  { typeof ( MsvmResourcePoolSettingData ) ,  "Msvm_ResourcePoolSettingData" }
        ,  { typeof ( MsvmVirtualSystemReferencePointExportSettingData ) ,  "Msvm_VirtualSystemReferencePointExportSettingData" }
        ,  { typeof ( MsvmReplicationAuthorizationSettingData ) ,  "Msvm_ReplicationAuthorizationSettingData" }
        ,  { typeof ( MsvmSynthetic3DServiceSettingData ) ,  "Msvm_Synthetic3DServiceSettingData" }
        ,  { typeof ( MsvmVirtualSystemMigrationNetworkSettingData ) ,  "Msvm_VirtualSystemMigrationNetworkSettingData" }
        ,  { typeof ( MsvmGuestCommunicationServiceSettingData ) ,  "Msvm_GuestCommunicationServiceSettingData" }
        ,  { typeof ( MsvmNetworkConnectionDiagnosticSettingData ) ,  "Msvm_NetworkConnectionDiagnosticSettingData" }
        ,  { typeof ( MsvmVirtualSystemReferencePointSettingData ) ,  "Msvm_VirtualSystemReferencePointSettingData" }
        ,  { typeof ( MsvmCollectionReferencePointExportSettingData ) ,  "Msvm_CollectionReferencePointExportSettingData" }
        ,  { typeof ( MsvmVirtualSystemSnapshotSettingData ) ,  "Msvm_VirtualSystemSnapshotSettingData" }
        ,  { typeof ( MsvmReplicationServiceSettingData ) ,  "Msvm_ReplicationServiceSettingData" }
        ,  { typeof ( MsvmEthernetPortData ) ,  "Msvm_EthernetPortData" }
        ,  { typeof ( MsvmEthernetSwitchPortOffloadData ) ,  "Msvm_EthernetSwitchPortOffloadData" }
        ,  { typeof ( MsvmEthernetSwitchPortBandwidthData ) ,  "Msvm_EthernetSwitchPortBandwidthData" }
        ,  { typeof ( MsvmEthernetSwitchData ) ,  "Msvm_EthernetSwitchData" }
        ,  { typeof ( MsvmEthernetSwitchOperationalData ) ,  "Msvm_EthernetSwitchOperationalData" }
        ,  { typeof ( MsvmEthernetSwitchHardwareOffloadData ) ,  "Msvm_EthernetSwitchHardwareOffloadData" }
        ,  { typeof ( MsvmEthernetSwitchBandwidthData ) ,  "Msvm_EthernetSwitchBandwidthData" }
        ,  { typeof ( CIMManagedSystemElement ) ,  "CIM_ManagedSystemElement" }
        ,  { typeof ( CIMLogicalElement ) ,  "CIM_LogicalElement" }
        ,  { typeof ( CIMEnabledLogicalElement ) ,  "CIM_EnabledLogicalElement" }
        ,  { typeof ( CIMSystem ) ,  "CIM_System" }
        ,  { typeof ( CIMComputerSystem ) ,  "CIM_ComputerSystem" }
        ,  { typeof ( MsvmComputerSystem ) ,  "Msvm_ComputerSystem" }
        ,  { typeof ( MsvmPlannedComputerSystem ) ,  "Msvm_PlannedComputerSystem" }
        ,  { typeof ( MsvmVirtualEthernetSwitch ) ,  "Msvm_VirtualEthernetSwitch" }
        ,  { typeof ( MsvmVirtualFcSwitch ) ,  "Msvm_VirtualFcSwitch" }
        ,  { typeof ( MsvmPartitionableGpu ) ,  "Msvm_PartitionableGpu" }
        ,  { typeof ( CIMService ) ,  "CIM_Service" }
        ,  { typeof ( MsvmAssignableDeviceService ) ,  "Msvm_AssignableDeviceService" }
        ,  { typeof ( CIMVirtualSystemManagementService ) ,  "CIM_VirtualSystemManagementService" }
        ,  { typeof ( MsvmVirtualSystemManagementService ) ,  "Msvm_VirtualSystemManagementService" }
        ,  { typeof ( MsvmVirtualEthernetSwitchManagementService ) ,  "Msvm_VirtualEthernetSwitchManagementService" }
        ,  { typeof ( MsvmImageManagementService ) ,  "Msvm_ImageManagementService" }
        ,  { typeof ( CIMVirtualSystemMigrationService ) ,  "CIM_VirtualSystemMigrationService" }
        ,  { typeof ( MsvmVirtualSystemMigrationService ) ,  "Msvm_VirtualSystemMigrationService" }
        ,  { typeof ( CIMMetricService ) ,  "CIM_MetricService" }
        ,  { typeof ( MsvmMetricService ) ,  "Msvm_MetricService" }
        ,  { typeof ( CIMVirtualSystemSnapshotService ) ,  "CIM_VirtualSystemSnapshotService" }
        ,  { typeof ( MsvmVirtualSystemSnapshotService ) ,  "Msvm_VirtualSystemSnapshotService" }
        ,  { typeof ( MsvmCollectionReferencePointService ) ,  "Msvm_CollectionReferencePointService" }
        ,  { typeof ( MsvmVirtualSystemReferencePointService ) ,  "Msvm_VirtualSystemReferencePointService" }
        ,  { typeof ( CIMNetworkService ) ,  "CIM_NetworkService" }
        ,  { typeof ( CIMForwardingService ) ,  "CIM_ForwardingService" }
        ,  { typeof ( CIMSwitchService ) ,  "CIM_SwitchService" }
        ,  { typeof ( CIMTransparentBridgingService ) ,  "CIM_TransparentBridgingService" }
        ,  { typeof ( MsvmTransparentBridgingService ) ,  "Msvm_TransparentBridgingService" }
        ,  { typeof ( MsvmGuestService ) ,  "Msvm_GuestService" }
        ,  { typeof ( MsvmVssService ) ,  "Msvm_VssService" }
        ,  { typeof ( MsvmGuestFileService ) ,  "Msvm_GuestFileService" }
        ,  { typeof ( MsvmGuestCommunicationService ) ,  "Msvm_GuestCommunicationService" }
        ,  { typeof ( MsvmCollectionSnapshotService ) ,  "Msvm_CollectionSnapshotService" }
        ,  { typeof ( MsvmResourcePoolConfigurationService ) ,  "Msvm_ResourcePoolConfigurationService" }
        ,  { typeof ( MsvmSynthetic3DService ) ,  "Msvm_Synthetic3DService" }
        ,  { typeof ( MsvmReplicationService ) ,  "Msvm_ReplicationService" }
        ,  { typeof ( MsvmCollectionManagementService ) ,  "Msvm_CollectionManagementService" }
        ,  { typeof ( MsvmSecurityService ) ,  "Msvm_SecurityService" }
        ,  { typeof ( MsvmTerminalService ) ,  "Msvm_TerminalService" }
        ,  { typeof ( CIMResourcePoolConfigurationService ) ,  "CIM_ResourcePoolConfigurationService" }
        ,  { typeof ( CIMLogicalDevice ) ,  "CIM_LogicalDevice" }
        ,  { typeof ( MsvmShutdownComponent ) ,  "Msvm_ShutdownComponent" }
        ,  { typeof ( MsvmTimeSyncComponent ) ,  "Msvm_TimeSyncComponent" }
        ,  { typeof ( MsvmGpuPartition ) ,  "Msvm_GpuPartition" }
        ,  { typeof ( MsvmHeartbeatComponent ) ,  "Msvm_HeartbeatComponent" }
        ,  { typeof ( CIMUserDevice ) ,  "CIM_UserDevice" }
        ,  { typeof ( CIMDisplay ) ,  "CIM_Display" }
        ,  { typeof ( CIMDesktopMonitor ) ,  "CIM_DesktopMonitor" }
        ,  { typeof ( MsvmKeyboard ) ,  "Msvm_Keyboard" }
        ,  { typeof ( CIMPointingDevice ) ,  "CIM_PointingDevice" }
        ,  { typeof ( MsvmPs2Mouse ) ,  "Msvm_Ps2Mouse" }
        ,  { typeof ( MsvmSyntheticMouse ) ,  "Msvm_SyntheticMouse" }
        ,  { typeof ( MsvmSyntheticKeyboard ) ,  "Msvm_SyntheticKeyboard" }
        ,  { typeof ( CIMUSBDevice ) ,  "CIM_USBDevice" }
        ,  { typeof ( CIMTPM ) ,  "CIM_TPM" }
        ,  { typeof ( MsvmTPM ) ,  "Msvm_TPM" }
        ,  { typeof ( MsvmFlexIoDevice ) ,  "Msvm_FlexIoDevice" }
        ,  { typeof ( MsvmPciExpress ) ,  "Msvm_PciExpress" }
        ,  { typeof ( CIMProtocolController ) ,  "CIM_ProtocolController" }
        ,  { typeof ( CIMSCSIProtocolController ) ,  "CIM_SCSIProtocolController" }
        ,  { typeof ( MsvmSCSIProtocolController ) ,  "Msvm_SCSIProtocolController" }
        ,  { typeof ( MsvmKvpExchangeComponent ) ,  "Msvm_KvpExchangeComponent" }
        ,  { typeof ( MsvmPhysical3dGraphicsProcessor ) ,  "Msvm_Physical3dGraphicsProcessor" }
        ,  { typeof ( MsvmVssComponent ) ,  "Msvm_VssComponent" }
        ,  { typeof ( CIMMediaAccessDevice ) ,  "CIM_MediaAccessDevice" }
        ,  { typeof ( CIMDiskDrive ) ,  "CIM_DiskDrive" }
        ,  { typeof ( MsvmDiskDrive ) ,  "Msvm_DiskDrive" }
        ,  { typeof ( CIMDisketteDrive ) ,  "CIM_DisketteDrive" }
        ,  { typeof ( MsvmDisketteDrive ) ,  "Msvm_DisketteDrive" }
        ,  { typeof ( CIMTapeDrive ) ,  "CIM_TapeDrive" }
        ,  { typeof ( CIMCDROMDrive ) ,  "CIM_CDROMDrive" }
        ,  { typeof ( CIMDVDDrive ) ,  "CIM_DVDDrive" }
        ,  { typeof ( MsvmDVDDrive ) ,  "Msvm_DVDDrive" }
        ,  { typeof ( MsvmBattery ) ,  "Msvm_Battery" }
        ,  { typeof ( CIMVideoHead ) ,  "CIM_VideoHead" }
        ,  { typeof ( MsvmVideoHead ) ,  "Msvm_VideoHead" }
        ,  { typeof ( CIMController ) ,  "CIM_Controller" }
        ,  { typeof ( CIMIDEController ) ,  "CIM_IDEController" }
        ,  { typeof ( MsvmIDEController ) ,  "Msvm_IDEController" }
        ,  { typeof ( CIMDisplayController ) ,  "CIM_DisplayController" }
        ,  { typeof ( MsvmS3DisplayController ) ,  "Msvm_S3DisplayController" }
        ,  { typeof ( MsvmSynthetic3DDisplayController ) ,  "Msvm_Synthetic3DDisplayController" }
        ,  { typeof ( MsvmSyntheticDisplayController ) ,  "Msvm_SyntheticDisplayController" }
        ,  { typeof ( MsvmPersistentMemoryController ) ,  "Msvm_PersistentMemoryController" }
        ,  { typeof ( CIMSerialController ) ,  "CIM_SerialController" }
        ,  { typeof ( MsvmSerialController ) ,  "Msvm_SerialController" }
        ,  { typeof ( MsvmDisketteController ) ,  "Msvm_DisketteController" }
        ,  { typeof ( MsvmRdvComponent ) ,  "Msvm_RdvComponent" }
        ,  { typeof ( CIMLogicalPort ) ,  "CIM_LogicalPort" }
        ,  { typeof ( CIMNetworkPort ) ,  "CIM_NetworkPort" }
        ,  { typeof ( CIMEthernetPort ) ,  "CIM_EthernetPort" }
        ,  { typeof ( MsvmEthernetSwitchPort ) ,  "Msvm_EthernetSwitchPort" }
        ,  { typeof ( MsvmInternalEthernetPort ) ,  "Msvm_InternalEthernetPort" }
        ,  { typeof ( MsvmSyntheticEthernetPort ) ,  "Msvm_SyntheticEthernetPort" }
        ,  { typeof ( MsvmExternalEthernetPort ) ,  "Msvm_ExternalEthernetPort" }
        ,  { typeof ( MsvmEmulatedEthernetPort ) ,  "Msvm_EmulatedEthernetPort" }
        ,  { typeof ( CIMFCPort ) ,  "CIM_FCPort" }
        ,  { typeof ( MsvmSyntheticFcPort ) ,  "Msvm_SyntheticFcPort" }
        ,  { typeof ( MsvmFcSwitchPort ) ,  "Msvm_FcSwitchPort" }
        ,  { typeof ( MsvmExternalFcPort ) ,  "Msvm_ExternalFcPort" }
        ,  { typeof ( CIMWiFiPort ) ,  "CIM_WiFiPort" }
        ,  { typeof ( MsvmWiFiPort ) ,  "Msvm_WiFiPort" }
        ,  { typeof ( MsvmSerialPort ) ,  "Msvm_SerialPort" }
        ,  { typeof ( MsvmGuestServiceInterfaceComponent ) ,  "Msvm_GuestServiceInterfaceComponent" }
        ,  { typeof ( CIMStorageExtent ) ,  "CIM_StorageExtent" }
        ,  { typeof ( CIMMemory ) ,  "CIM_Memory" }
        ,  { typeof ( MsvmMemory ) ,  "Msvm_Memory" }
        ,  { typeof ( CIMLogicalDisk ) ,  "CIM_LogicalDisk" }
        ,  { typeof ( MsvmLogicalDisk ) ,  "Msvm_LogicalDisk" }
        ,  { typeof ( CIMProcessor ) ,  "CIM_Processor" }
        ,  { typeof ( MsvmProcessor ) ,  "Msvm_Processor" }
        ,  { typeof ( MsvmTerminalConnection ) ,  "Msvm_TerminalConnection" }
        ,  { typeof ( MsvmEthernetSwitchExtension ) ,  "Msvm_EthernetSwitchExtension" }
        ,  { typeof ( CIMServiceAccessPoint ) ,  "CIM_ServiceAccessPoint" }
        ,  { typeof ( CIMProtocolEndpoint ) ,  "CIM_ProtocolEndpoint" }
        ,  { typeof ( MsvmFcEndpoint ) ,  "Msvm_FcEndpoint" }
        ,  { typeof ( CIMLANEndpoint ) ,  "CIM_LANEndpoint" }
        ,  { typeof ( CIMWiFiEndpoint ) ,  "CIM_WiFiEndpoint" }
        ,  { typeof ( MsvmWiFiEndpoint ) ,  "Msvm_WiFiEndpoint" }
        ,  { typeof ( MsvmLANEndpoint ) ,  "Msvm_LANEndpoint" }
        ,  { typeof ( CIMSwitchPort ) ,  "CIM_SwitchPort" }
        ,  { typeof ( CIMVLANEndpoint ) ,  "CIM_VLANEndpoint" }
        ,  { typeof ( MsvmVLANEndpoint ) ,  "Msvm_VLANEndpoint" }
        ,  { typeof ( MsvmNumaNode ) ,  "Msvm_NumaNode" }
        ,  { typeof ( MsvmSecurityElement ) ,  "Msvm_SecurityElement" }
        ,  { typeof ( CIMJob ) ,  "CIM_Job" }
        ,  { typeof ( CIMConcreteJob ) ,  "CIM_ConcreteJob" }
        ,  { typeof ( MsvmConcreteJob ) ,  "Msvm_ConcreteJob" }
        ,  { typeof ( MsvmMigrationJob ) ,  "Msvm_MigrationJob" }
        ,  { typeof ( MsvmCopyFileToGuestJob ) ,  "Msvm_CopyFileToGuestJob" }
        ,  { typeof ( MsvmStorageJob ) ,  "Msvm_StorageJob" }
        ,  { typeof ( MsvmCollectionReferencePointExportJob ) ,  "Msvm_CollectionReferencePointExportJob" }
        ,  { typeof ( MsvmVirtualSystemReferencePointExportJob ) ,  "Msvm_VirtualSystemReferencePointExportJob" }
        ,  { typeof ( CIMResourcePool ) ,  "CIM_ResourcePool" }
        ,  { typeof ( MsvmSynth3dVideoPool ) ,  "Msvm_Synth3dVideoPool" }
        ,  { typeof ( MsvmProcessorPool ) ,  "Msvm_ProcessorPool" }
        ,  { typeof ( MsvmResourcePool ) ,  "Msvm_ResourcePool" }
        ,  { typeof ( CIMDynamicForwardingEntry ) ,  "CIM_DynamicForwardingEntry" }
        ,  { typeof ( MsvmDynamicForwardingEntry ) ,  "Msvm_DynamicForwardingEntry" }
        ,  { typeof ( MsvmMountedStorageImage ) ,  "Msvm_MountedStorageImage" }
        ,  { typeof ( CIMSoftwareElement ) ,  "CIM_SoftwareElement" }
        ,  { typeof ( CIMBIOSElement ) ,  "CIM_BIOSElement" }
        ,  { typeof ( MsvmBIOSElement ) ,  "Msvm_BIOSElement" }
        ,  { typeof ( MsvmReplicationRelationship ) ,  "Msvm_ReplicationRelationship" }
        ,  { typeof ( MsvmReplicationProvider ) ,  "Msvm_ReplicationProvider" }
        ,  { typeof ( MsvmInstalledEthernetSwitchExtension ) ,  "Msvm_InstalledEthernetSwitchExtension" }
        ,  { typeof ( CIMView ) ,  "CIM_View" }
        ,  { typeof ( MsvmSummaryInformationBase ) ,  "Msvm_SummaryInformationBase" }
        ,  { typeof ( MsvmSummaryInformation ) ,  "Msvm_SummaryInformation" }
        ,  { typeof ( CIMCapabilities ) ,  "CIM_Capabilities" }
        ,  { typeof ( CIMEnabledLogicalElementCapabilities ) ,  "CIM_EnabledLogicalElementCapabilities" }
        ,  { typeof ( CIMVirtualSystemManagementCapabilities ) ,  "CIM_VirtualSystemManagementCapabilities" }
        ,  { typeof ( MsvmVirtualSystemManagementCapabilities ) ,  "Msvm_VirtualSystemManagementCapabilities" }
        ,  { typeof ( MsvmVirtualEthernetSwitchManagementCapabilities ) ,  "Msvm_VirtualEthernetSwitchManagementCapabilities" }
        ,  { typeof ( MsvmVirtualSystemCapabilities ) ,  "Msvm_VirtualSystemCapabilities" }
        ,  { typeof ( CIMMetricServiceCapabilities ) ,  "CIM_MetricServiceCapabilities" }
        ,  { typeof ( MsvmMetricServiceCapabilities ) ,  "Msvm_MetricServiceCapabilities" }
        ,  { typeof ( CIMAllocationCapabilities ) ,  "CIM_AllocationCapabilities" }
        ,  { typeof ( MsvmAllocationCapabilities ) ,  "Msvm_AllocationCapabilities" }
        ,  { typeof ( CIMResourcePoolConfigurationCapabilities ) ,  "CIM_ResourcePoolConfigurationCapabilities" }
        ,  { typeof ( MsvmExternalEthernetPortCapabilities ) ,  "Msvm_ExternalEthernetPortCapabilities" }
        ,  { typeof ( MsvmResourcePoolConfigurationCapabilities ) ,  "Msvm_ResourcePoolConfigurationCapabilities" }
        ,  { typeof ( CIMVirtualSystemMigrationCapabilities ) ,  "CIM_VirtualSystemMigrationCapabilities" }
        ,  { typeof ( MsvmVirtualSystemMigrationCapabilities ) ,  "Msvm_VirtualSystemMigrationCapabilities" }
        ,  { typeof ( MsvmEthernetSwitchFeatureCapabilities ) ,  "Msvm_EthernetSwitchFeatureCapabilities" }
        ,  { typeof ( MsvmVirtualSystemReferencePoint ) ,  "Msvm_VirtualSystemReferencePoint" }
        ,  { typeof ( MsvmReplicationStatistics ) ,  "Msvm_ReplicationStatistics" }
        ,  { typeof ( MsvmPhysicalGPUInfo ) ,  "Msvm_PhysicalGPUInfo" }
        ,  { typeof ( CIMBaseMetricDefinition ) ,  "CIM_BaseMetricDefinition" }
        ,  { typeof ( CIMAggregationMetricDefinition ) ,  "CIM_AggregationMetricDefinition" }
        ,  { typeof ( MsvmAggregationMetricDefinition ) ,  "Msvm_AggregationMetricDefinition" }
        ,  { typeof ( MsvmBaseMetricDefinition ) ,  "Msvm_BaseMetricDefinition" }
        ,  { typeof ( MsvmNumaNodeTopology ) ,  "Msvm_NumaNodeTopology" }
        ,  { typeof ( CIMCollection ) ,  "CIM_Collection" }
        ,  { typeof ( MsvmSnapshotCollection ) ,  "Msvm_SnapshotCollection" }
        ,  { typeof ( CIMCollectionOfMSEs ) ,  "CIM_CollectionOfMSEs" }
        ,  { typeof ( MsvmVirtualSystemCollection ) ,  "Msvm_VirtualSystemCollection" }
        ,  { typeof ( MsvmManagementCollection ) ,  "Msvm_ManagementCollection" }
        ,  { typeof ( MsvmReferencePointCollection ) ,  "Msvm_ReferencePointCollection" }
        ,  { typeof ( CIMBaseMetricValue ) ,  "CIM_BaseMetricValue" }
        ,  { typeof ( CIMAggregationMetricValue ) ,  "CIM_AggregationMetricValue" }
        ,  { typeof ( MsvmAggregationMetricValue ) ,  "Msvm_AggregationMetricValue" }
        ,  { typeof ( MsvmBaseMetricValue ) ,  "Msvm_BaseMetricValue" }
        ,  { typeof ( MsvmMoveUnmanagedVhd ) ,  "Msvm_MoveUnmanagedVhd" }
        ,  { typeof ( MsvmKvpExchangeDataItem ) ,  "Msvm_KvpExchangeDataItem" }
        ,  { typeof ( CIMError ) ,  "CIM_Error" }
        ,  { typeof ( MSFTWmiError ) ,  "MSFT_WmiError" }
        ,  { typeof ( MSFTExtendedStatus ) ,  "MSFT_ExtendedStatus" }
        ,  { typeof ( MsvmError ) ,  "Msvm_Error" }
        ,  { typeof ( MsvmVirtualHardDiskState ) ,  "Msvm_VirtualHardDiskState" }
        ,  { typeof ( MsvmGuestNetworkAdapterConfiguration ) ,  "Msvm_GuestNetworkAdapterConfiguration" }
        ,  { typeof ( NotifyStatus ) ,  "__NotifyStatus" }
        ,  { typeof ( ExtendedStatus ) ,  "__ExtendedStatus" }
        ,  { typeof ( SecurityRelatedClass ) ,  "__SecurityRelatedClass" }
        ,  { typeof ( Trustee ) ,  "__Trustee" }
        ,  { typeof ( NTLMUser9X ) ,  "__NTLMUser9X" }
        ,  { typeof ( ACE ) ,  "__ACE" }
        ,  { typeof ( SecurityDescriptor ) ,  "__SecurityDescriptor" }
        ,  { typeof ( PARAMETERS ) ,  "__PARAMETERS" }
        ,  { typeof ( MsvmGuestClusterInformation ) ,  "Msvm_GuestClusterInformation" }
        ,  { typeof ( MsvmCompatibilityVector ) ,  "Msvm_CompatibilityVector" }
        ,  { typeof ( MsvmVHDSetInformation ) ,  "Msvm_VHDSetInformation" }
        ,  { typeof ( MsvmVHDSnapshotInformation ) ,  "Msvm_VHDSnapshotInformation" }
        ,  { typeof ( MsvmInteractiveSessionACE ) ,  "Msvm_InteractiveSessionACE" }
        ,  { typeof ( MsvmVirtualMachineToDisks ) ,  "Msvm_VirtualMachineToDisks" }
        ,  { typeof ( MsvmNetworkConnectionDiagnosticInformation ) ,  "Msvm_NetworkConnectionDiagnosticInformation" }
        ,  { typeof ( MsvmServicingSettings ) ,  "Msvm_ServicingSettings" }
        };
        public string TryResolveType(Type type)
        {
            if (_typeMap.TryGetValue(type, out var result))
            {
                return result;
            }

            return null;
        }
    }
}