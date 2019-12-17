using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;

namespace SimCim.Root.V2
{
    public static class SimCimScopeExtensions
    {
        public struct AllAssociations
        {
            private IInfrastructureObjectScope _scope;
            public AllAssociations(IInfrastructureObjectScope scope)
            {
                _scope = scope;
            }

            public FilterToConsumerBindingAssociation FilterToConsumerBinding => new FilterToConsumerBindingAssociation(_scope);
            public Win32LogicalDiskRootDirectoryAssociation Win32LogicalDiskRootDirectory => new Win32LogicalDiskRootDirectoryAssociation(_scope);
            public Win32SystemDevicesAssociation Win32SystemDevices => new Win32SystemDevicesAssociation(_scope);
            public Win32SystemPartitionsAssociation Win32SystemPartitions => new Win32SystemPartitionsAssociation(_scope);
            public Win32ComputerSystemProcessorAssociation Win32ComputerSystemProcessor => new Win32ComputerSystemProcessorAssociation(_scope);
            public Win32SystemServicesAssociation Win32SystemServices => new Win32SystemServicesAssociation(_scope);
            public Win32SystemNetworkConnectionsAssociation Win32SystemNetworkConnections => new Win32SystemNetworkConnectionsAssociation(_scope);
            public Win32SystemResourcesAssociation Win32SystemResources => new Win32SystemResourcesAssociation(_scope);
            public Win32SystemBIOSAssociation Win32SystemBIOS => new Win32SystemBIOSAssociation(_scope);
            public Win32SystemLoadOrderGroupsAssociation Win32SystemLoadOrderGroups => new Win32SystemLoadOrderGroupsAssociation(_scope);
            public Win32SystemUsersAssociation Win32SystemUsers => new Win32SystemUsersAssociation(_scope);
            public Win32SystemOperatingSystemAssociation Win32SystemOperatingSystem => new Win32SystemOperatingSystemAssociation(_scope);
            public Win32SystemSystemDriverAssociation Win32SystemSystemDriver => new Win32SystemSystemDriverAssociation(_scope);
            public Win32SystemProcessesAssociation Win32SystemProcesses => new Win32SystemProcessesAssociation(_scope);
            public Win32ClassicCOMApplicationClassesAssociation Win32ClassicCOMApplicationClasses => new Win32ClassicCOMApplicationClassesAssociation(_scope);
            public CIMDirectoryContainsFileAssociation CIMDirectoryContainsFile => new CIMDirectoryContainsFileAssociation(_scope);
            public Win32UserInDomainAssociation Win32UserInDomain => new Win32UserInDomainAssociation(_scope);
            public Win32LoadOrderGroupServiceMembersAssociation Win32LoadOrderGroupServiceMembers => new Win32LoadOrderGroupServiceMembersAssociation(_scope);
            public Win32SoftwareFeatureSoftwareElementsAssociation Win32SoftwareFeatureSoftwareElements => new Win32SoftwareFeatureSoftwareElementsAssociation(_scope);
            public Win32MemoryDeviceArrayAssociation Win32MemoryDeviceArray => new Win32MemoryDeviceArrayAssociation(_scope);
            public Win32GroupInDomainAssociation Win32GroupInDomain => new Win32GroupInDomainAssociation(_scope);
            public Win32GroupUserAssociation Win32GroupUser => new Win32GroupUserAssociation(_scope);
            public Win32ProgramGroupContentsAssociation Win32ProgramGroupContents => new Win32ProgramGroupContentsAssociation(_scope);
            public Win32SubDirectoryAssociation Win32SubDirectory => new Win32SubDirectoryAssociation(_scope);
            public Win32PhysicalMemoryLocationAssociation Win32PhysicalMemoryLocation => new Win32PhysicalMemoryLocationAssociation(_scope);
            public Win32LogicalDiskToPartitionAssociation Win32LogicalDiskToPartition => new Win32LogicalDiskToPartitionAssociation(_scope);
            public Win32DiskDriveToDiskPartitionAssociation Win32DiskDriveToDiskPartition => new Win32DiskDriveToDiskPartitionAssociation(_scope);
            public Win32DeviceBusAssociation Win32DeviceBus => new Win32DeviceBusAssociation(_scope);
            public Win32SCSIControllerDeviceAssociation Win32SCSIControllerDevice => new Win32SCSIControllerDeviceAssociation(_scope);
            public Win32USBControllerDeviceAssociation Win32USBControllerDevice => new Win32USBControllerDeviceAssociation(_scope);
            public Win32IDEControllerDeviceAssociation Win32IDEControllerDevice => new Win32IDEControllerDeviceAssociation(_scope);
            public Win321394ControllerDeviceAssociation Win321394ControllerDevice => new Win321394ControllerDeviceAssociation(_scope);
            public Win32POTSModemToSerialPortAssociation Win32POTSModemToSerialPort => new Win32POTSModemToSerialPortAssociation(_scope);
            public Win32PrinterControllerAssociation Win32PrinterController => new Win32PrinterControllerAssociation(_scope);
            public CIMUSBControllerHasHubAssociation CIMUSBControllerHasHub => new CIMUSBControllerHasHubAssociation(_scope);
            public Win32ControllerHasHubAssociation Win32ControllerHasHub => new Win32ControllerHasHubAssociation(_scope);
            public Win32AssociatedProcessorMemoryAssociation Win32AssociatedProcessorMemory => new Win32AssociatedProcessorMemoryAssociation(_scope);
            public Win32CIMLogicalDeviceCIMDataFileAssociation Win32CIMLogicalDeviceCIMDataFile => new Win32CIMLogicalDeviceCIMDataFileAssociation(_scope);
            public Win32PNPAllocatedResourceAssociation Win32PNPAllocatedResource => new Win32PNPAllocatedResourceAssociation(_scope);
            public Win32DiskDrivePhysicalMediaAssociation Win32DiskDrivePhysicalMedia => new Win32DiskDrivePhysicalMediaAssociation(_scope);
            public Win32MemoryDeviceLocationAssociation Win32MemoryDeviceLocation => new Win32MemoryDeviceLocationAssociation(_scope);
            public Win32MemoryArrayLocationAssociation Win32MemoryArrayLocation => new Win32MemoryArrayLocationAssociation(_scope);
            public Win32AllocatedResourceAssociation Win32AllocatedResource => new Win32AllocatedResourceAssociation(_scope);
            public Win32ApplicationCommandLineAssociation Win32ApplicationCommandLine => new Win32ApplicationCommandLineAssociation(_scope);
            public Win32ShadowVolumeSupportAssociation Win32ShadowVolumeSupport => new Win32ShadowVolumeSupportAssociation(_scope);
            public Win32SessionConnectionAssociation Win32SessionConnection => new Win32SessionConnectionAssociation(_scope);
            public Win32ShadowForAssociation Win32ShadowFor => new Win32ShadowForAssociation(_scope);
            public Win32LogonSessionMappedDiskAssociation Win32LogonSessionMappedDisk => new Win32LogonSessionMappedDiskAssociation(_scope);
            public Win32PrinterShareAssociation Win32PrinterShare => new Win32PrinterShareAssociation(_scope);
            public Win32PnPSignedDriverCIMDataFileAssociation Win32PnPSignedDriverCIMDataFile => new Win32PnPSignedDriverCIMDataFileAssociation(_scope);
            public Win32ConnectionShareAssociation Win32ConnectionShare => new Win32ConnectionShareAssociation(_scope);
            public Win32LoadOrderGroupServiceDependenciesAssociation Win32LoadOrderGroupServiceDependencies => new Win32LoadOrderGroupServiceDependenciesAssociation(_scope);
            public CIMProcessExecutableAssociation CIMProcessExecutable => new CIMProcessExecutableAssociation(_scope);
            public Win32SessionProcessAssociation Win32SessionProcess => new Win32SessionProcessAssociation(_scope);
            public Win32SoftwareFeatureParentAssociation Win32SoftwareFeatureParent => new Win32SoftwareFeatureParentAssociation(_scope);
            public Win32ShadowOnAssociation Win32ShadowOn => new Win32ShadowOnAssociation(_scope);
            public Win32PrinterDriverDllAssociation Win32PrinterDriverDll => new Win32PrinterDriverDllAssociation(_scope);
            public Win32DependentServiceAssociation Win32DependentService => new Win32DependentServiceAssociation(_scope);
            public Win32OperatingSystemQFEAssociation Win32OperatingSystemQFE => new Win32OperatingSystemQFEAssociation(_scope);
            public Win32LoggedOnUserAssociation Win32LoggedOnUser => new Win32LoggedOnUserAssociation(_scope);
            public Win32SystemDriverPNPEntityAssociation Win32SystemDriverPNPEntity => new Win32SystemDriverPNPEntityAssociation(_scope);
            public Win32DfsNodeTargetAssociation Win32DfsNodeTarget => new Win32DfsNodeTargetAssociation(_scope);
            public Win32DriverForDeviceAssociation Win32DriverForDevice => new Win32DriverForDeviceAssociation(_scope);
            public Win32LogicalProgramGroupItemDataFileAssociation Win32LogicalProgramGroupItemDataFile => new Win32LogicalProgramGroupItemDataFileAssociation(_scope);
            public Win32ShadowByAssociation Win32ShadowBy => new Win32ShadowByAssociation(_scope);
            public Win32LogicalProgramGroupDirectoryAssociation Win32LogicalProgramGroupDirectory => new Win32LogicalProgramGroupDirectoryAssociation(_scope);
            public Win32ShadowDiffVolumeSupportAssociation Win32ShadowDiffVolumeSupport => new Win32ShadowDiffVolumeSupportAssociation(_scope);
            public Win32DiskQuotaAssociation Win32DiskQuota => new Win32DiskQuotaAssociation(_scope);
            public Win32VolumeQuotaSettingAssociation Win32VolumeQuotaSetting => new Win32VolumeQuotaSettingAssociation(_scope);
            public Win32PrinterSettingAssociation Win32PrinterSetting => new Win32PrinterSettingAssociation(_scope);
            public Win32NetworkAdapterSettingAssociation Win32NetworkAdapterSetting => new Win32NetworkAdapterSettingAssociation(_scope);
            public Win32SerialPortSettingAssociation Win32SerialPortSetting => new Win32SerialPortSettingAssociation(_scope);
            public Win32SecuritySettingOfLogicalShareAssociation Win32SecuritySettingOfLogicalShare => new Win32SecuritySettingOfLogicalShareAssociation(_scope);
            public Win32SecuritySettingOfLogicalFileAssociation Win32SecuritySettingOfLogicalFile => new Win32SecuritySettingOfLogicalFileAssociation(_scope);
            public Win32UserDesktopAssociation Win32UserDesktop => new Win32UserDesktopAssociation(_scope);
            public Win32SystemProgramGroupsAssociation Win32SystemProgramGroups => new Win32SystemProgramGroupsAssociation(_scope);
            public Win32SystemBootConfigurationAssociation Win32SystemBootConfiguration => new Win32SystemBootConfigurationAssociation(_scope);
            public Win32SystemTimeZoneAssociation Win32SystemTimeZone => new Win32SystemTimeZoneAssociation(_scope);
            public Win32SystemDesktopAssociation Win32SystemDesktop => new Win32SystemDesktopAssociation(_scope);
            public Win32ClassicCOMClassSettingsAssociation Win32ClassicCOMClassSettings => new Win32ClassicCOMClassSettingsAssociation(_scope);
            public Win32VolumeQuotaAssociation Win32VolumeQuota => new Win32VolumeQuotaAssociation(_scope);
            public Win32WMIElementSettingAssociation Win32WMIElementSetting => new Win32WMIElementSettingAssociation(_scope);
            public Win32COMApplicationSettingsAssociation Win32COMApplicationSettings => new Win32COMApplicationSettingsAssociation(_scope);
            public Win32VideoSettingsAssociation Win32VideoSettings => new Win32VideoSettingsAssociation(_scope);
            public Win32PageFileElementSettingAssociation Win32PageFileElementSetting => new Win32PageFileElementSettingAssociation(_scope);
            public Win32OperatingSystemAutochkSettingAssociation Win32OperatingSystemAutochkSetting => new Win32OperatingSystemAutochkSettingAssociation(_scope);
            public Win32PnPDeviceAssociation Win32PnPDevice => new Win32PnPDeviceAssociation(_scope);
            public Win32ActiveRouteAssociation Win32ActiveRoute => new Win32ActiveRouteAssociation(_scope);
            public Win32NamedJobObjectProcessAssociation Win32NamedJobObjectProcess => new Win32NamedJobObjectProcessAssociation(_scope);
            public Win32NamedJobObjectStatisticsAssociation Win32NamedJobObjectStatistics => new Win32NamedJobObjectStatisticsAssociation(_scope);
            public Win32AccountSIDAssociation Win32AccountSID => new Win32AccountSIDAssociation(_scope);
            public Win32ProductResourceAssociation Win32ProductResource => new Win32ProductResourceAssociation(_scope);
            public Win32MountPointAssociation Win32MountPoint => new Win32MountPointAssociation(_scope);
            public Win32SoftwareElementResourceAssociation Win32SoftwareElementResource => new Win32SoftwareElementResourceAssociation(_scope);
            public Win32ActionCheckAssociation Win32ActionCheck => new Win32ActionCheckAssociation(_scope);
            public Win32ProductSoftwareFeaturesAssociation Win32ProductSoftwareFeatures => new Win32ProductSoftwareFeaturesAssociation(_scope);
            public Win32ImplementedCategoryAssociation Win32ImplementedCategory => new Win32ImplementedCategoryAssociation(_scope);
            public Win32InstalledSoftwareElementAssociation Win32InstalledSoftwareElement => new Win32InstalledSoftwareElementAssociation(_scope);
            public Win32SoftwareFeatureCheckAssociation Win32SoftwareFeatureCheck => new Win32SoftwareFeatureCheckAssociation(_scope);
            public Win32VolumeUserQuotaAssociation Win32VolumeUserQuota => new Win32VolumeUserQuotaAssociation(_scope);
            public Win32ShadowStorageAssociation Win32ShadowStorage => new Win32ShadowStorageAssociation(_scope);
            public Win32DCOMApplicationAccessAllowedSettingAssociation Win32DCOMApplicationAccessAllowedSetting => new Win32DCOMApplicationAccessAllowedSettingAssociation(_scope);
            public Win32ServiceSpecificationServiceAssociation Win32ServiceSpecificationService => new Win32ServiceSpecificationServiceAssociation(_scope);
            public Win32ShareToDirectoryAssociation Win32ShareToDirectory => new Win32ShareToDirectoryAssociation(_scope);
            public Win32PatchFileAssociation Win32PatchFile => new Win32PatchFileAssociation(_scope);
            public Win32ODBCDriverAttributeAssociation Win32ODBCDriverAttribute => new Win32ODBCDriverAttributeAssociation(_scope);
            public Win32ODBCDataSourceAttributeAssociation Win32ODBCDataSourceAttribute => new Win32ODBCDataSourceAttributeAssociation(_scope);
            public Win32ClientApplicationSettingAssociation Win32ClientApplicationSetting => new Win32ClientApplicationSettingAssociation(_scope);
            public Win32LogicalFileOwnerAssociation Win32LogicalFileOwner => new Win32LogicalFileOwnerAssociation(_scope);
            public Win32ShortcutSAPAssociation Win32ShortcutSAP => new Win32ShortcutSAPAssociation(_scope);
            public Win32SoftwareElementCheckAssociation Win32SoftwareElementCheck => new Win32SoftwareElementCheckAssociation(_scope);
            public Win32ODBCDriverSoftwareElementAssociation Win32ODBCDriverSoftwareElement => new Win32ODBCDriverSoftwareElementAssociation(_scope);
            public Win32NTLogEventLogAssociation Win32NTLogEventLog => new Win32NTLogEventLogAssociation(_scope);
            public Win32ComClassAutoEmulatorAssociation Win32ComClassAutoEmulator => new Win32ComClassAutoEmulatorAssociation(_scope);
            public Win32ComClassEmulatorAssociation Win32ComClassEmulator => new Win32ComClassEmulatorAssociation(_scope);
            public Win32SoftwareFeatureActionAssociation Win32SoftwareFeatureAction => new Win32SoftwareFeatureActionAssociation(_scope);
            public Win32LogicalFileGroupAssociation Win32LogicalFileGroup => new Win32LogicalFileGroupAssociation(_scope);
            public Win32DCOMApplicationLaunchAllowedSettingAssociation Win32DCOMApplicationLaunchAllowedSetting => new Win32DCOMApplicationLaunchAllowedSettingAssociation(_scope);
            public Win32LogicalFileAuditingAssociation Win32LogicalFileAuditing => new Win32LogicalFileAuditingAssociation(_scope);
            public Win32LogicalShareAuditingAssociation Win32LogicalShareAuditing => new Win32LogicalShareAuditingAssociation(_scope);
            public Win32SoftwareElementActionAssociation Win32SoftwareElementAction => new Win32SoftwareElementActionAssociation(_scope);
            public Win32ProductCheckAssociation Win32ProductCheck => new Win32ProductCheckAssociation(_scope);
            public Win32NTLogEventUserAssociation Win32NTLogEventUser => new Win32NTLogEventUserAssociation(_scope);
            public Win32ProtocolBindingAssociation Win32ProtocolBinding => new Win32ProtocolBindingAssociation(_scope);
            public Win32NamedJobObjectLimitAssociation Win32NamedJobObjectLimit => new Win32NamedJobObjectLimitAssociation(_scope);
            public Win32NamedJobObjectSecLimitAssociation Win32NamedJobObjectSecLimit => new Win32NamedJobObjectSecLimitAssociation(_scope);
            public Win32NTLogEventComputerAssociation Win32NTLogEventComputer => new Win32NTLogEventComputerAssociation(_scope);
            public Win32CheckCheckAssociation Win32CheckCheck => new Win32CheckCheckAssociation(_scope);
            public Win32LogicalFileAccessAssociation Win32LogicalFileAccess => new Win32LogicalFileAccessAssociation(_scope);
            public Win32LogicalShareAccessAssociation Win32LogicalShareAccess => new Win32LogicalShareAccessAssociation(_scope);
        }

        public static AllAssociations Associations(this IInfrastructureObjectScope scope)
        {
            return new AllAssociations(scope);
        }

        public static ThisNAMESPACE GetThisNAMESPACE(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<ThisNAMESPACE>().Single();
        }

        public static Task<ThisNAMESPACE> GetThisNAMESPACEAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<ThisNAMESPACE>(options).ToTask();
        }

        public static IObservable<BookmarkedEvent<ExtrinsicEvent>> SubscribeToExtrinsicEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<ExtrinsicEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<Win32DeviceChangeEvent>> SubscribeToWin32DeviceChangeEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<Win32DeviceChangeEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<Win32SystemConfigurationChangeEvent>> SubscribeToWin32SystemConfigurationChangeEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<Win32SystemConfigurationChangeEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<Win32VolumeChangeEvent>> SubscribeToWin32VolumeChangeEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<Win32VolumeChangeEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWMIGenericNonCOMEvent>> SubscribeToMSFTWMIGenericNonCOMEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWMIGenericNonCOMEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNCProvEvent>> SubscribeToMSFTNCProvEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNCProvEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNCProvCancelQuery>> SubscribeToMSFTNCProvCancelQuery(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNCProvCancelQuery>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNCProvClientConnected>> SubscribeToMSFTNCProvClientConnected(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNCProvClientConnected>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNCProvNewQuery>> SubscribeToMSFTNCProvNewQuery(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNCProvNewQuery>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNCProvAccessCheck>> SubscribeToMSFTNCProvAccessCheck(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNCProvAccessCheck>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<Win32SystemTrace>> SubscribeToWin32SystemTrace(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<Win32SystemTrace>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<Win32ProcessTrace>> SubscribeToWin32ProcessTrace(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<Win32ProcessTrace>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<Win32ProcessStartTrace>> SubscribeToWin32ProcessStartTrace(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<Win32ProcessStartTrace>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<Win32ProcessStopTrace>> SubscribeToWin32ProcessStopTrace(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<Win32ProcessStopTrace>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<Win32ThreadTrace>> SubscribeToWin32ThreadTrace(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<Win32ThreadTrace>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<Win32ThreadStartTrace>> SubscribeToWin32ThreadStartTrace(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<Win32ThreadStartTrace>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<Win32ThreadStopTrace>> SubscribeToWin32ThreadStopTrace(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<Win32ThreadStopTrace>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<Win32ModuleTrace>> SubscribeToWin32ModuleTrace(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<Win32ModuleTrace>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<Win32ModuleLoadTrace>> SubscribeToWin32ModuleLoadTrace(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<Win32ModuleLoadTrace>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<Win32PowerManagementEvent>> SubscribeToWin32PowerManagementEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<Win32PowerManagementEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<Win32ComputerSystemEvent>> SubscribeToWin32ComputerSystemEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<Win32ComputerSystemEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<Win32ComputerShutdownEvent>> SubscribeToWin32ComputerShutdownEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<Win32ComputerShutdownEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTSCMEvent>> SubscribeToMSFTSCMEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTSCMEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTSCMEventLogEvent>> SubscribeToMSFTSCMEventLogEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTSCMEventLogEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetSevereServiceFailed>> SubscribeToMSFTNetSevereServiceFailed(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetSevereServiceFailed>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetTransactInvalid>> SubscribeToMSFTNetTransactInvalid(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetTransactInvalid>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceNotInteractive>> SubscribeToMSFTNetServiceNotInteractive(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceNotInteractive>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetTakeOwnership>> SubscribeToMSFTNetTakeOwnership(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetTakeOwnership>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceConfigBackoutFailed>> SubscribeToMSFTNetServiceConfigBackoutFailed(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceConfigBackoutFailed>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceShutdownFailed>> SubscribeToMSFTNetServiceShutdownFailed(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceShutdownFailed>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceStartHung>> SubscribeToMSFTNetServiceStartHung(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceStartHung>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceStopControlSuccess>> SubscribeToMSFTNetServiceStopControlSuccess(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceStopControlSuccess>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceSlowStartup>> SubscribeToMSFTNetServiceSlowStartup(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceSlowStartup>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetCallToFunctionFailed>> SubscribeToMSFTNetCallToFunctionFailed(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetCallToFunctionFailed>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetBadAccount>> SubscribeToMSFTNetBadAccount(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetBadAccount>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetBadServiceState>> SubscribeToMSFTNetBadServiceState(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetBadServiceState>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetConnectionTimeout>> SubscribeToMSFTNetConnectionTimeout(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetConnectionTimeout>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetCircularDependencyAuto>> SubscribeToMSFTNetCircularDependencyAuto(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetCircularDependencyAuto>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceStartTypeChanged>> SubscribeToMSFTNetServiceStartTypeChanged(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceStartTypeChanged>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceLogonTypeNotGranted>> SubscribeToMSFTNetServiceLogonTypeNotGranted(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceLogonTypeNotGranted>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceStartFailedGroup>> SubscribeToMSFTNetServiceStartFailedGroup(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceStartFailedGroup>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetDependOnLaterService>> SubscribeToMSFTNetDependOnLaterService(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetDependOnLaterService>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetFirstLogonFailedII>> SubscribeToMSFTNetFirstLogonFailedII(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetFirstLogonFailedII>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceDifferentPIDConnected>> SubscribeToMSFTNetServiceDifferentPIDConnected(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceDifferentPIDConnected>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceCrashNoAction>> SubscribeToMSFTNetServiceCrashNoAction(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceCrashNoAction>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetCircularDependencyDemand>> SubscribeToMSFTNetCircularDependencyDemand(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetCircularDependencyDemand>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceExitFailed>> SubscribeToMSFTNetServiceExitFailed(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceExitFailed>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceStartFailedII>> SubscribeToMSFTNetServiceStartFailedII(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceStartFailedII>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceExitFailedSpecific>> SubscribeToMSFTNetServiceExitFailedSpecific(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceExitFailedSpecific>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetBootSystemDriversFailed>> SubscribeToMSFTNetBootSystemDriversFailed(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetBootSystemDriversFailed>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceCrash>> SubscribeToMSFTNetServiceCrash(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceCrash>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceRecoveryFailed>> SubscribeToMSFTNetServiceRecoveryFailed(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceRecoveryFailed>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceStatusSuccess>> SubscribeToMSFTNetServiceStatusSuccess(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceStatusSuccess>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetTransactTimeout>> SubscribeToMSFTNetTransactTimeout(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetTransactTimeout>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetFirstLogonFailed>> SubscribeToMSFTNetFirstLogonFailed(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetFirstLogonFailed>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceControlSuccess>> SubscribeToMSFTNetServiceControlSuccess(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceControlSuccess>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceStartFailed>> SubscribeToMSFTNetServiceStartFailed(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceStartFailed>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetServiceStartFailedNone>> SubscribeToMSFTNetServiceStartFailedNone(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetServiceStartFailedNone>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetReadfileTimeout>> SubscribeToMSFTNetReadfileTimeout(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetReadfileTimeout>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetRevertedToLastKnownGood>> SubscribeToMSFTNetRevertedToLastKnownGood(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetRevertedToLastKnownGood>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetCallToFunctionFailedII>> SubscribeToMSFTNetCallToFunctionFailedII(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetCallToFunctionFailedII>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTNetDependOnLaterGroup>> SubscribeToMSFTNetDependOnLaterGroup(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTNetDependOnLaterGroup>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWmiSelfEvent>> SubscribeToMSFTWmiSelfEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWmiSelfEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWmiEssEvent>> SubscribeToMSFTWmiEssEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWmiEssEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWmiThreadPoolEvent>> SubscribeToMSFTWmiThreadPoolEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWmiThreadPoolEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWmiThreadPoolThreadCreated>> SubscribeToMSFTWmiThreadPoolThreadCreated(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWmiThreadPoolThreadCreated>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWmiThreadPoolThreadDeleted>> SubscribeToMSFTWmiThreadPoolThreadDeleted(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWmiThreadPoolThreadDeleted>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWmiRegisterNotificationSink>> SubscribeToMSFTWmiRegisterNotificationSink(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWmiRegisterNotificationSink>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWmiFilterEvent>> SubscribeToMSFTWmiFilterEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWmiFilterEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWmiFilterDeactivated>> SubscribeToMSFTWmiFilterDeactivated(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWmiFilterDeactivated>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWmiFilterActivated>> SubscribeToMSFTWmiFilterActivated(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWmiFilterActivated>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWmiCancelNotificationSink>> SubscribeToMSFTWmiCancelNotificationSink(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWmiCancelNotificationSink>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWmiProviderEvent>> SubscribeToMSFTWmiProviderEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWmiProviderEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWmiConsumerProviderEvent>> SubscribeToMSFTWmiConsumerProviderEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWmiConsumerProviderEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWmiConsumerProviderSinkLoaded>> SubscribeToMSFTWmiConsumerProviderSinkLoaded(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWmiConsumerProviderSinkLoaded>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWmiConsumerProviderSinkUnloaded>> SubscribeToMSFTWmiConsumerProviderSinkUnloaded(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWmiConsumerProviderSinkUnloaded>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWmiConsumerProviderUnloaded>> SubscribeToMSFTWmiConsumerProviderUnloaded(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWmiConsumerProviderUnloaded>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MSFTWmiConsumerProviderLoaded>> SubscribeToMSFTWmiConsumerProviderLoaded(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MSFTWmiConsumerProviderLoaded>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderOperationEvent>> SubscribeToMsftWmiProviderOperationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderOperationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderComServerLoadOperationEvent>> SubscribeToMsftWmiProviderComServerLoadOperationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderComServerLoadOperationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderOperationEventPost>> SubscribeToMsftWmiProviderOperationEventPost(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderOperationEventPost>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderPutInstanceAsyncEventPost>> SubscribeToMsftWmiProviderPutInstanceAsyncEventPost(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderPutInstanceAsyncEventPost>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderCreateInstanceEnumAsyncEventPost>> SubscribeToMsftWmiProviderCreateInstanceEnumAsyncEventPost(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderCreateInstanceEnumAsyncEventPost>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderDeleteInstanceAsyncEventPost>> SubscribeToMsftWmiProviderDeleteInstanceAsyncEventPost(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderDeleteInstanceAsyncEventPost>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderCancelQueryPost>> SubscribeToMsftWmiProviderCancelQueryPost(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderCancelQueryPost>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderNewQueryPost>> SubscribeToMsftWmiProviderNewQueryPost(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderNewQueryPost>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderProvideEventsPost>> SubscribeToMsftWmiProviderProvideEventsPost(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderProvideEventsPost>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderExecQueryAsyncEventPost>> SubscribeToMsftWmiProviderExecQueryAsyncEventPost(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderExecQueryAsyncEventPost>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderAccessCheckPost>> SubscribeToMsftWmiProviderAccessCheckPost(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderAccessCheckPost>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderCreateClassEnumAsyncEventPost>> SubscribeToMsftWmiProviderCreateClassEnumAsyncEventPost(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderCreateClassEnumAsyncEventPost>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderDeleteClassAsyncEventPost>> SubscribeToMsftWmiProviderDeleteClassAsyncEventPost(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderDeleteClassAsyncEventPost>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderExecMethodAsyncEventPost>> SubscribeToMsftWmiProviderExecMethodAsyncEventPost(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderExecMethodAsyncEventPost>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderGetObjectAsyncEventPost>> SubscribeToMsftWmiProviderGetObjectAsyncEventPost(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderGetObjectAsyncEventPost>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderPutClassAsyncEventPost>> SubscribeToMsftWmiProviderPutClassAsyncEventPost(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderPutClassAsyncEventPost>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderInitializationOperationFailureEvent>> SubscribeToMsftWmiProviderInitializationOperationFailureEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderInitializationOperationFailureEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderInitializationOperationEvent>> SubscribeToMsftWmiProviderInitializationOperationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderInitializationOperationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderLoadOperationFailureEvent>> SubscribeToMsftWmiProviderLoadOperationFailureEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderLoadOperationFailureEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderComServerLoadOperationFailureEvent>> SubscribeToMsftWmiProviderComServerLoadOperationFailureEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderComServerLoadOperationFailureEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderUnLoadOperationEvent>> SubscribeToMsftWmiProviderUnLoadOperationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderUnLoadOperationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderLoadOperationEvent>> SubscribeToMsftWmiProviderLoadOperationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderLoadOperationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderOperationEventPre>> SubscribeToMsftWmiProviderOperationEventPre(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderOperationEventPre>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderDeleteInstanceAsyncEventPre>> SubscribeToMsftWmiProviderDeleteInstanceAsyncEventPre(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderDeleteInstanceAsyncEventPre>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderAccessCheckPre>> SubscribeToMsftWmiProviderAccessCheckPre(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderAccessCheckPre>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderExecQueryAsyncEventPre>> SubscribeToMsftWmiProviderExecQueryAsyncEventPre(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderExecQueryAsyncEventPre>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderDeleteClassAsyncEventPre>> SubscribeToMsftWmiProviderDeleteClassAsyncEventPre(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderDeleteClassAsyncEventPre>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderNewQueryPre>> SubscribeToMsftWmiProviderNewQueryPre(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderNewQueryPre>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderPutInstanceAsyncEventPre>> SubscribeToMsftWmiProviderPutInstanceAsyncEventPre(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderPutInstanceAsyncEventPre>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderCreateClassEnumAsyncEventPre>> SubscribeToMsftWmiProviderCreateClassEnumAsyncEventPre(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderCreateClassEnumAsyncEventPre>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderExecMethodAsyncEventPre>> SubscribeToMsftWmiProviderExecMethodAsyncEventPre(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderExecMethodAsyncEventPre>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderProvideEventsPre>> SubscribeToMsftWmiProviderProvideEventsPre(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderProvideEventsPre>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderCancelQueryPre>> SubscribeToMsftWmiProviderCancelQueryPre(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderCancelQueryPre>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderPutClassAsyncEventPre>> SubscribeToMsftWmiProviderPutClassAsyncEventPre(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderPutClassAsyncEventPre>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderGetObjectAsyncEventPre>> SubscribeToMsftWmiProviderGetObjectAsyncEventPre(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderGetObjectAsyncEventPre>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsftWmiProviderCreateInstanceEnumAsyncEventPre>> SubscribeToMsftWmiProviderCreateInstanceEnumAsyncEventPre(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsftWmiProviderCreateInstanceEnumAsyncEventPre>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<Win32IP4RouteTableEvent>> SubscribeToWin32IP4RouteTableEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<Win32IP4RouteTableEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<RegistryEvent>> SubscribeToRegistryEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<RegistryEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<RegistryKeyChangeEvent>> SubscribeToRegistryKeyChangeEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<RegistryKeyChangeEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<RegistryTreeChangeEvent>> SubscribeToRegistryTreeChangeEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<RegistryTreeChangeEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<RegistryValueChangeEvent>> SubscribeToRegistryValueChangeEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<RegistryValueChangeEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<SystemEvent>> SubscribeToSystemEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<SystemEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<EventDroppedEvent>> SubscribeToEventDroppedEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<EventDroppedEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<EventQueueOverflowEvent>> SubscribeToEventQueueOverflowEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<EventQueueOverflowEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<QOSFailureEvent>> SubscribeToQOSFailureEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<QOSFailureEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<ConsumerFailureEvent>> SubscribeToConsumerFailureEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<ConsumerFailureEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<InstanceOperationEvent>> SubscribeToInstanceOperationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<InstanceOperationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<InstanceModificationEvent>> SubscribeToInstanceModificationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<InstanceModificationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<InstanceCreationEvent>> SubscribeToInstanceCreationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<InstanceCreationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MethodInvocationEvent>> SubscribeToMethodInvocationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MethodInvocationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<InstanceDeletionEvent>> SubscribeToInstanceDeletionEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<InstanceDeletionEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<ClassOperationEvent>> SubscribeToClassOperationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<ClassOperationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<ClassDeletionEvent>> SubscribeToClassDeletionEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<ClassDeletionEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<ClassModificationEvent>> SubscribeToClassModificationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<ClassModificationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<ClassCreationEvent>> SubscribeToClassCreationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<ClassCreationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<NamespaceOperationEvent>> SubscribeToNamespaceOperationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<NamespaceOperationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<NamespaceModificationEvent>> SubscribeToNamespaceModificationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<NamespaceModificationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<NamespaceDeletionEvent>> SubscribeToNamespaceDeletionEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<NamespaceDeletionEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<NamespaceCreationEvent>> SubscribeToNamespaceCreationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<NamespaceCreationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<TimerEvent>> SubscribeToTimerEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<TimerEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static SystemSecurity GetSystemSecurity(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<SystemSecurity>().Single();
        }

        public static Task<SystemSecurity> GetSystemSecurityAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<SystemSecurity>(options).ToTask();
        }

        public static Win32OperatingSystem GetWin32OperatingSystem(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32OperatingSystem>().Single();
        }

        public static Task<Win32OperatingSystem> GetWin32OperatingSystemAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32OperatingSystem>(options).ToTask();
        }

        public static Win32WMISetting GetWin32WMISetting(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32WMISetting>().Single();
        }

        public static Task<Win32WMISetting> GetWin32WMISettingAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32WMISetting>(options).ToTask();
        }

        public static ScriptingStandardConsumerSetting GetScriptingStandardConsumerSetting(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<ScriptingStandardConsumerSetting>().Single();
        }

        public static Task<ScriptingStandardConsumerSetting> GetScriptingStandardConsumerSettingAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<ScriptingStandardConsumerSetting>(options).ToTask();
        }

        public static Win32CurrentTime GetWin32CurrentTime(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32CurrentTime>().Single();
        }

        public static Task<Win32CurrentTime> GetWin32CurrentTimeAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32CurrentTime>(options).ToTask();
        }

        public static Win32LocalTime GetWin32LocalTime(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32LocalTime>().Single();
        }

        public static Task<Win32LocalTime> GetWin32LocalTimeAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32LocalTime>(options).ToTask();
        }

        public static Win32UTCTime GetWin32UTCTime(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32UTCTime>().Single();
        }

        public static Task<Win32UTCTime> GetWin32UTCTimeAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32UTCTime>(options).ToTask();
        }

        public static Win32FolderRedirectionHealth GetWin32FolderRedirectionHealth(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32FolderRedirectionHealth>().Single();
        }

        public static Task<Win32FolderRedirectionHealth> GetWin32FolderRedirectionHealthAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32FolderRedirectionHealth>(options).ToTask();
        }

        public static Win32OfflineFilesUserConfiguration GetWin32OfflineFilesUserConfiguration(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32OfflineFilesUserConfiguration>().Single();
        }

        public static Task<Win32OfflineFilesUserConfiguration> GetWin32OfflineFilesUserConfigurationAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32OfflineFilesUserConfiguration>(options).ToTask();
        }

        public static Win32RoamingProfileMachineConfiguration GetWin32RoamingProfileMachineConfiguration(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32RoamingProfileMachineConfiguration>().Single();
        }

        public static Task<Win32RoamingProfileMachineConfiguration> GetWin32RoamingProfileMachineConfigurationAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32RoamingProfileMachineConfiguration>(options).ToTask();
        }

        public static Win32RoamingProfileUserConfiguration GetWin32RoamingProfileUserConfiguration(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32RoamingProfileUserConfiguration>().Single();
        }

        public static Task<Win32RoamingProfileUserConfiguration> GetWin32RoamingProfileUserConfigurationAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32RoamingProfileUserConfiguration>(options).ToTask();
        }

        public static Win32RoamingUserHealthConfiguration GetWin32RoamingUserHealthConfiguration(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32RoamingUserHealthConfiguration>().Single();
        }

        public static Task<Win32RoamingUserHealthConfiguration> GetWin32RoamingUserHealthConfigurationAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32RoamingUserHealthConfiguration>(options).ToTask();
        }

        public static Win32UserStateConfigurationControls GetWin32UserStateConfigurationControls(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32UserStateConfigurationControls>().Single();
        }

        public static Task<Win32UserStateConfigurationControls> GetWin32UserStateConfigurationControlsAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32UserStateConfigurationControls>(options).ToTask();
        }

        public static Win32FolderRedirectionUserConfiguration GetWin32FolderRedirectionUserConfiguration(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32FolderRedirectionUserConfiguration>().Single();
        }

        public static Task<Win32FolderRedirectionUserConfiguration> GetWin32FolderRedirectionUserConfigurationAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32FolderRedirectionUserConfiguration>(options).ToTask();
        }

        public static Win32FolderRedirectionHealthConfiguration GetWin32FolderRedirectionHealthConfiguration(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32FolderRedirectionHealthConfiguration>().Single();
        }

        public static Task<Win32FolderRedirectionHealthConfiguration> GetWin32FolderRedirectionHealthConfigurationAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32FolderRedirectionHealthConfiguration>(options).ToTask();
        }

        public static Win32OfflineFilesMachineConfiguration GetWin32OfflineFilesMachineConfiguration(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32OfflineFilesMachineConfiguration>().Single();
        }

        public static Task<Win32OfflineFilesMachineConfiguration> GetWin32OfflineFilesMachineConfigurationAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32OfflineFilesMachineConfiguration>(options).ToTask();
        }

        public static Win32OfflineFilesHealth GetWin32OfflineFilesHealth(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32OfflineFilesHealth>().Single();
        }

        public static Task<Win32OfflineFilesHealth> GetWin32OfflineFilesHealthAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32OfflineFilesHealth>(options).ToTask();
        }

        public static MsftWmiProviderCounters GetMsftWmiProviderCounters(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<MsftWmiProviderCounters>().Single();
        }

        public static Task<MsftWmiProviderCounters> GetMsftWmiProviderCountersAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<MsftWmiProviderCounters>(options).ToTask();
        }

        public static NTEventlogProviderConfig GetNTEventlogProviderConfig(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<NTEventlogProviderConfig>().Single();
        }

        public static Task<NTEventlogProviderConfig> GetNTEventlogProviderConfigAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<NTEventlogProviderConfig>(options).ToTask();
        }

        public static Win32OfflineFilesCache GetWin32OfflineFilesCache(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32OfflineFilesCache>().Single();
        }

        public static Task<Win32OfflineFilesCache> GetWin32OfflineFilesCacheAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32OfflineFilesCache>(options).ToTask();
        }

        public static Win32PerfFormattedDataAFDCountersMicrosoftWinsockBSP GetWin32PerfFormattedDataAFDCountersMicrosoftWinsockBSP(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataAFDCountersMicrosoftWinsockBSP>().Single();
        }

        public static Task<Win32PerfFormattedDataAFDCountersMicrosoftWinsockBSP> GetWin32PerfFormattedDataAFDCountersMicrosoftWinsockBSPAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataAFDCountersMicrosoftWinsockBSP>(options).ToTask();
        }

        public static Win32PerfRawDataAFDCountersMicrosoftWinsockBSP GetWin32PerfRawDataAFDCountersMicrosoftWinsockBSP(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataAFDCountersMicrosoftWinsockBSP>().Single();
        }

        public static Task<Win32PerfRawDataAFDCountersMicrosoftWinsockBSP> GetWin32PerfRawDataAFDCountersMicrosoftWinsockBSPAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataAFDCountersMicrosoftWinsockBSP>(options).ToTask();
        }

        public static Win32PerfFormattedDataASPNET4030319ASPNETv4030319 GetWin32PerfFormattedDataASPNET4030319ASPNETv4030319(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataASPNET4030319ASPNETv4030319>().Single();
        }

        public static Task<Win32PerfFormattedDataASPNET4030319ASPNETv4030319> GetWin32PerfFormattedDataASPNET4030319ASPNETv4030319Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataASPNET4030319ASPNETv4030319>(options).ToTask();
        }

        public static Win32PerfRawDataASPNET4030319ASPNETv4030319 GetWin32PerfRawDataASPNET4030319ASPNETv4030319(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataASPNET4030319ASPNETv4030319>().Single();
        }

        public static Task<Win32PerfRawDataASPNET4030319ASPNETv4030319> GetWin32PerfRawDataASPNET4030319ASPNETv4030319Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataASPNET4030319ASPNETv4030319>(options).ToTask();
        }

        public static Win32PerfFormattedDataASPNETASPNET GetWin32PerfFormattedDataASPNETASPNET(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataASPNETASPNET>().Single();
        }

        public static Task<Win32PerfFormattedDataASPNETASPNET> GetWin32PerfFormattedDataASPNETASPNETAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataASPNETASPNET>(options).ToTask();
        }

        public static Win32PerfRawDataASPNETASPNET GetWin32PerfRawDataASPNETASPNET(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataASPNETASPNET>().Single();
        }

        public static Task<Win32PerfRawDataASPNETASPNET> GetWin32PerfRawDataASPNETASPNETAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataASPNETASPNET>(options).ToTask();
        }

        public static Win32PerfFormattedDataAspnetstateASPNETStateService GetWin32PerfFormattedDataAspnetstateASPNETStateService(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataAspnetstateASPNETStateService>().Single();
        }

        public static Task<Win32PerfFormattedDataAspnetstateASPNETStateService> GetWin32PerfFormattedDataAspnetstateASPNETStateServiceAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataAspnetstateASPNETStateService>(options).ToTask();
        }

        public static Win32PerfRawDataAspnetstateASPNETStateService GetWin32PerfRawDataAspnetstateASPNETStateService(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataAspnetstateASPNETStateService>().Single();
        }

        public static Task<Win32PerfRawDataAspnetstateASPNETStateService> GetWin32PerfRawDataAspnetstateASPNETStateServiceAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataAspnetstateASPNETStateService>(options).ToTask();
        }

        public static Win32PerfFormattedDataBITSBITSNetUtilization GetWin32PerfFormattedDataBITSBITSNetUtilization(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataBITSBITSNetUtilization>().Single();
        }

        public static Task<Win32PerfFormattedDataBITSBITSNetUtilization> GetWin32PerfFormattedDataBITSBITSNetUtilizationAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataBITSBITSNetUtilization>(options).ToTask();
        }

        public static Win32PerfRawDataBITSBITSNetUtilization GetWin32PerfRawDataBITSBITSNetUtilization(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataBITSBITSNetUtilization>().Single();
        }

        public static Task<Win32PerfRawDataBITSBITSNetUtilization> GetWin32PerfRawDataBITSBITSNetUtilizationAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataBITSBITSNetUtilization>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersEventLog GetWin32PerfFormattedDataCountersEventLog(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersEventLog>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersEventLog> GetWin32PerfFormattedDataCountersEventLogAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersEventLog>(options).ToTask();
        }

        public static Win32PerfRawDataCountersEventLog GetWin32PerfRawDataCountersEventLog(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersEventLog>().Single();
        }

        public static Task<Win32PerfRawDataCountersEventLog> GetWin32PerfRawDataCountersEventLogAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersEventLog>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersEventTracingforWindows GetWin32PerfFormattedDataCountersEventTracingforWindows(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersEventTracingforWindows>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersEventTracingforWindows> GetWin32PerfFormattedDataCountersEventTracingforWindowsAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersEventTracingforWindows>(options).ToTask();
        }

        public static Win32PerfRawDataCountersEventTracingforWindows GetWin32PerfRawDataCountersEventTracingforWindows(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersEventTracingforWindows>().Single();
        }

        public static Task<Win32PerfRawDataCountersEventTracingforWindows> GetWin32PerfRawDataCountersEventTracingforWindowsAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersEventTracingforWindows>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersGenericIKEv1AuthIPandIKEv2 GetWin32PerfFormattedDataCountersGenericIKEv1AuthIPandIKEv2(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersGenericIKEv1AuthIPandIKEv2>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersGenericIKEv1AuthIPandIKEv2> GetWin32PerfFormattedDataCountersGenericIKEv1AuthIPandIKEv2Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersGenericIKEv1AuthIPandIKEv2>(options).ToTask();
        }

        public static Win32PerfRawDataCountersGenericIKEv1AuthIPandIKEv2 GetWin32PerfRawDataCountersGenericIKEv1AuthIPandIKEv2(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersGenericIKEv1AuthIPandIKEv2>().Single();
        }

        public static Task<Win32PerfRawDataCountersGenericIKEv1AuthIPandIKEv2> GetWin32PerfRawDataCountersGenericIKEv1AuthIPandIKEv2Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersGenericIKEv1AuthIPandIKEv2>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersHTTPService GetWin32PerfFormattedDataCountersHTTPService(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersHTTPService>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersHTTPService> GetWin32PerfFormattedDataCountersHTTPServiceAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersHTTPService>(options).ToTask();
        }

        public static Win32PerfRawDataCountersHTTPService GetWin32PerfRawDataCountersHTTPService(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersHTTPService>().Single();
        }

        public static Task<Win32PerfRawDataCountersHTTPService> GetWin32PerfRawDataCountersHTTPServiceAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersHTTPService>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersHyperVDynamicMemoryIntegrationService GetWin32PerfFormattedDataCountersHyperVDynamicMemoryIntegrationService(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersHyperVDynamicMemoryIntegrationService>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersHyperVDynamicMemoryIntegrationService> GetWin32PerfFormattedDataCountersHyperVDynamicMemoryIntegrationServiceAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersHyperVDynamicMemoryIntegrationService>(options).ToTask();
        }

        public static Win32PerfRawDataCountersHyperVDynamicMemoryIntegrationService GetWin32PerfRawDataCountersHyperVDynamicMemoryIntegrationService(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersHyperVDynamicMemoryIntegrationService>().Single();
        }

        public static Task<Win32PerfRawDataCountersHyperVDynamicMemoryIntegrationService> GetWin32PerfRawDataCountersHyperVDynamicMemoryIntegrationServiceAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersHyperVDynamicMemoryIntegrationService>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersHyperVVirtualMachineBus GetWin32PerfFormattedDataCountersHyperVVirtualMachineBus(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersHyperVVirtualMachineBus>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersHyperVVirtualMachineBus> GetWin32PerfFormattedDataCountersHyperVVirtualMachineBusAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersHyperVVirtualMachineBus>(options).ToTask();
        }

        public static Win32PerfRawDataCountersHyperVVirtualMachineBus GetWin32PerfRawDataCountersHyperVVirtualMachineBus(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersHyperVVirtualMachineBus>().Single();
        }

        public static Task<Win32PerfRawDataCountersHyperVVirtualMachineBus> GetWin32PerfRawDataCountersHyperVVirtualMachineBusAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersHyperVVirtualMachineBus>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersIPsecAuthIPIPv4 GetWin32PerfFormattedDataCountersIPsecAuthIPIPv4(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersIPsecAuthIPIPv4>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersIPsecAuthIPIPv4> GetWin32PerfFormattedDataCountersIPsecAuthIPIPv4Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersIPsecAuthIPIPv4>(options).ToTask();
        }

        public static Win32PerfRawDataCountersIPsecAuthIPIPv4 GetWin32PerfRawDataCountersIPsecAuthIPIPv4(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersIPsecAuthIPIPv4>().Single();
        }

        public static Task<Win32PerfRawDataCountersIPsecAuthIPIPv4> GetWin32PerfRawDataCountersIPsecAuthIPIPv4Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersIPsecAuthIPIPv4>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersIPsecAuthIPIPv6 GetWin32PerfFormattedDataCountersIPsecAuthIPIPv6(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersIPsecAuthIPIPv6>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersIPsecAuthIPIPv6> GetWin32PerfFormattedDataCountersIPsecAuthIPIPv6Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersIPsecAuthIPIPv6>(options).ToTask();
        }

        public static Win32PerfRawDataCountersIPsecAuthIPIPv6 GetWin32PerfRawDataCountersIPsecAuthIPIPv6(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersIPsecAuthIPIPv6>().Single();
        }

        public static Task<Win32PerfRawDataCountersIPsecAuthIPIPv6> GetWin32PerfRawDataCountersIPsecAuthIPIPv6Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersIPsecAuthIPIPv6>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersIPsecConnections GetWin32PerfFormattedDataCountersIPsecConnections(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersIPsecConnections>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersIPsecConnections> GetWin32PerfFormattedDataCountersIPsecConnectionsAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersIPsecConnections>(options).ToTask();
        }

        public static Win32PerfRawDataCountersIPsecConnections GetWin32PerfRawDataCountersIPsecConnections(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersIPsecConnections>().Single();
        }

        public static Task<Win32PerfRawDataCountersIPsecConnections> GetWin32PerfRawDataCountersIPsecConnectionsAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersIPsecConnections>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersIPsecDriver GetWin32PerfFormattedDataCountersIPsecDriver(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersIPsecDriver>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersIPsecDriver> GetWin32PerfFormattedDataCountersIPsecDriverAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersIPsecDriver>(options).ToTask();
        }

        public static Win32PerfRawDataCountersIPsecDriver GetWin32PerfRawDataCountersIPsecDriver(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersIPsecDriver>().Single();
        }

        public static Task<Win32PerfRawDataCountersIPsecDriver> GetWin32PerfRawDataCountersIPsecDriverAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersIPsecDriver>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersIPsecIKEv1IPv4 GetWin32PerfFormattedDataCountersIPsecIKEv1IPv4(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersIPsecIKEv1IPv4>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersIPsecIKEv1IPv4> GetWin32PerfFormattedDataCountersIPsecIKEv1IPv4Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersIPsecIKEv1IPv4>(options).ToTask();
        }

        public static Win32PerfRawDataCountersIPsecIKEv1IPv4 GetWin32PerfRawDataCountersIPsecIKEv1IPv4(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersIPsecIKEv1IPv4>().Single();
        }

        public static Task<Win32PerfRawDataCountersIPsecIKEv1IPv4> GetWin32PerfRawDataCountersIPsecIKEv1IPv4Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersIPsecIKEv1IPv4>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersIPsecIKEv1IPv6 GetWin32PerfFormattedDataCountersIPsecIKEv1IPv6(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersIPsecIKEv1IPv6>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersIPsecIKEv1IPv6> GetWin32PerfFormattedDataCountersIPsecIKEv1IPv6Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersIPsecIKEv1IPv6>(options).ToTask();
        }

        public static Win32PerfRawDataCountersIPsecIKEv1IPv6 GetWin32PerfRawDataCountersIPsecIKEv1IPv6(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersIPsecIKEv1IPv6>().Single();
        }

        public static Task<Win32PerfRawDataCountersIPsecIKEv1IPv6> GetWin32PerfRawDataCountersIPsecIKEv1IPv6Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersIPsecIKEv1IPv6>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersIPsecIKEv2IPv4 GetWin32PerfFormattedDataCountersIPsecIKEv2IPv4(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersIPsecIKEv2IPv4>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersIPsecIKEv2IPv4> GetWin32PerfFormattedDataCountersIPsecIKEv2IPv4Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersIPsecIKEv2IPv4>(options).ToTask();
        }

        public static Win32PerfRawDataCountersIPsecIKEv2IPv4 GetWin32PerfRawDataCountersIPsecIKEv2IPv4(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersIPsecIKEv2IPv4>().Single();
        }

        public static Task<Win32PerfRawDataCountersIPsecIKEv2IPv4> GetWin32PerfRawDataCountersIPsecIKEv2IPv4Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersIPsecIKEv2IPv4>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersIPsecIKEv2IPv6 GetWin32PerfFormattedDataCountersIPsecIKEv2IPv6(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersIPsecIKEv2IPv6>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersIPsecIKEv2IPv6> GetWin32PerfFormattedDataCountersIPsecIKEv2IPv6Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersIPsecIKEv2IPv6>(options).ToTask();
        }

        public static Win32PerfRawDataCountersIPsecIKEv2IPv6 GetWin32PerfRawDataCountersIPsecIKEv2IPv6(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersIPsecIKEv2IPv6>().Single();
        }

        public static Task<Win32PerfRawDataCountersIPsecIKEv2IPv6> GetWin32PerfRawDataCountersIPsecIKEv2IPv6Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersIPsecIKEv2IPv6>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersSMBServer GetWin32PerfFormattedDataCountersSMBServer(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersSMBServer>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersSMBServer> GetWin32PerfFormattedDataCountersSMBServerAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersSMBServer>(options).ToTask();
        }

        public static Win32PerfRawDataCountersSMBServer GetWin32PerfRawDataCountersSMBServer(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersSMBServer>().Single();
        }

        public static Task<Win32PerfRawDataCountersSMBServer> GetWin32PerfRawDataCountersSMBServerAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersSMBServer>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersWFP GetWin32PerfFormattedDataCountersWFP(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersWFP>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersWFP> GetWin32PerfFormattedDataCountersWFPAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersWFP>(options).ToTask();
        }

        public static Win32PerfRawDataCountersWFP GetWin32PerfRawDataCountersWFP(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersWFP>().Single();
        }

        public static Task<Win32PerfRawDataCountersWFP> GetWin32PerfRawDataCountersWFPAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersWFP>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersWFPClassify GetWin32PerfFormattedDataCountersWFPClassify(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersWFPClassify>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersWFPClassify> GetWin32PerfFormattedDataCountersWFPClassifyAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersWFPClassify>(options).ToTask();
        }

        public static Win32PerfRawDataCountersWFPClassify GetWin32PerfRawDataCountersWFPClassify(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersWFPClassify>().Single();
        }

        public static Task<Win32PerfRawDataCountersWFPClassify> GetWin32PerfRawDataCountersWFPClassifyAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersWFPClassify>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersWFPReauthorization GetWin32PerfFormattedDataCountersWFPReauthorization(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersWFPReauthorization>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersWFPReauthorization> GetWin32PerfFormattedDataCountersWFPReauthorizationAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersWFPReauthorization>(options).ToTask();
        }

        public static Win32PerfRawDataCountersWFPReauthorization GetWin32PerfRawDataCountersWFPReauthorization(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersWFPReauthorization>().Single();
        }

        public static Task<Win32PerfRawDataCountersWFPReauthorization> GetWin32PerfRawDataCountersWFPReauthorizationAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersWFPReauthorization>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersWFPv4 GetWin32PerfFormattedDataCountersWFPv4(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersWFPv4>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersWFPv4> GetWin32PerfFormattedDataCountersWFPv4Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersWFPv4>(options).ToTask();
        }

        public static Win32PerfRawDataCountersWFPv4 GetWin32PerfRawDataCountersWFPv4(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersWFPv4>().Single();
        }

        public static Task<Win32PerfRawDataCountersWFPv4> GetWin32PerfRawDataCountersWFPv4Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersWFPv4>(options).ToTask();
        }

        public static Win32PerfFormattedDataCountersWFPv6 GetWin32PerfFormattedDataCountersWFPv6(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataCountersWFPv6>().Single();
        }

        public static Task<Win32PerfFormattedDataCountersWFPv6> GetWin32PerfFormattedDataCountersWFPv6Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataCountersWFPv6>(options).ToTask();
        }

        public static Win32PerfRawDataCountersWFPv6 GetWin32PerfRawDataCountersWFPv6(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataCountersWFPv6>().Single();
        }

        public static Task<Win32PerfRawDataCountersWFPv6> GetWin32PerfRawDataCountersWFPv6Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataCountersWFPv6>(options).ToTask();
        }

        public static Win32PerfFormattedDataDdmCounterProviderRAS GetWin32PerfFormattedDataDdmCounterProviderRAS(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataDdmCounterProviderRAS>().Single();
        }

        public static Task<Win32PerfFormattedDataDdmCounterProviderRAS> GetWin32PerfFormattedDataDdmCounterProviderRASAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataDdmCounterProviderRAS>(options).ToTask();
        }

        public static Win32PerfRawDataDdmCounterProviderRAS GetWin32PerfRawDataDdmCounterProviderRAS(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataDdmCounterProviderRAS>().Single();
        }

        public static Task<Win32PerfRawDataDdmCounterProviderRAS> GetWin32PerfRawDataDdmCounterProviderRASAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataDdmCounterProviderRAS>(options).ToTask();
        }

        public static Win32PerfFormattedDataFaxServiceFaxService GetWin32PerfFormattedDataFaxServiceFaxService(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataFaxServiceFaxService>().Single();
        }

        public static Task<Win32PerfFormattedDataFaxServiceFaxService> GetWin32PerfFormattedDataFaxServiceFaxServiceAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataFaxServiceFaxService>(options).ToTask();
        }

        public static Win32PerfRawDataFaxServiceFaxService GetWin32PerfRawDataFaxServiceFaxService(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataFaxServiceFaxService>().Single();
        }

        public static Task<Win32PerfRawDataFaxServiceFaxService> GetWin32PerfRawDataFaxServiceFaxServiceAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataFaxServiceFaxService>(options).ToTask();
        }

        public static Win32PerfFormattedDataHvStatsHyperVHypervisor GetWin32PerfFormattedDataHvStatsHyperVHypervisor(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataHvStatsHyperVHypervisor>().Single();
        }

        public static Task<Win32PerfFormattedDataHvStatsHyperVHypervisor> GetWin32PerfFormattedDataHvStatsHyperVHypervisorAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataHvStatsHyperVHypervisor>(options).ToTask();
        }

        public static Win32PerfRawDataHvStatsHyperVHypervisor GetWin32PerfRawDataHvStatsHyperVHypervisor(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataHvStatsHyperVHypervisor>().Single();
        }

        public static Task<Win32PerfRawDataHvStatsHyperVHypervisor> GetWin32PerfRawDataHvStatsHyperVHypervisorAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataHvStatsHyperVHypervisor>(options).ToTask();
        }

        public static Win32PerfFormattedDataIntelStorageCountersIntelStorageCounters GetWin32PerfFormattedDataIntelStorageCountersIntelStorageCounters(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataIntelStorageCountersIntelStorageCounters>().Single();
        }

        public static Task<Win32PerfFormattedDataIntelStorageCountersIntelStorageCounters> GetWin32PerfFormattedDataIntelStorageCountersIntelStorageCountersAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataIntelStorageCountersIntelStorageCounters>(options).ToTask();
        }

        public static Win32PerfRawDataIntelStorageCountersIntelStorageCounters GetWin32PerfRawDataIntelStorageCountersIntelStorageCounters(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataIntelStorageCountersIntelStorageCounters>().Single();
        }

        public static Task<Win32PerfRawDataIntelStorageCountersIntelStorageCounters> GetWin32PerfRawDataIntelStorageCountersIntelStorageCountersAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataIntelStorageCountersIntelStorageCounters>(options).ToTask();
        }

        public static Win32PerfFormattedDataLocalSessionManagerTerminalServices GetWin32PerfFormattedDataLocalSessionManagerTerminalServices(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataLocalSessionManagerTerminalServices>().Single();
        }

        public static Task<Win32PerfFormattedDataLocalSessionManagerTerminalServices> GetWin32PerfFormattedDataLocalSessionManagerTerminalServicesAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataLocalSessionManagerTerminalServices>(options).ToTask();
        }

        public static Win32PerfRawDataLocalSessionManagerTerminalServices GetWin32PerfRawDataLocalSessionManagerTerminalServices(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataLocalSessionManagerTerminalServices>().Single();
        }

        public static Task<Win32PerfRawDataLocalSessionManagerTerminalServices> GetWin32PerfRawDataLocalSessionManagerTerminalServicesAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataLocalSessionManagerTerminalServices>(options).ToTask();
        }

        public static Win32PerfFormattedDataLsaSecuritySystemWideStatistics GetWin32PerfFormattedDataLsaSecuritySystemWideStatistics(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataLsaSecuritySystemWideStatistics>().Single();
        }

        public static Task<Win32PerfFormattedDataLsaSecuritySystemWideStatistics> GetWin32PerfFormattedDataLsaSecuritySystemWideStatisticsAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataLsaSecuritySystemWideStatistics>(options).ToTask();
        }

        public static Win32PerfRawDataLsaSecuritySystemWideStatistics GetWin32PerfRawDataLsaSecuritySystemWideStatistics(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataLsaSecuritySystemWideStatistics>().Single();
        }

        public static Task<Win32PerfRawDataLsaSecuritySystemWideStatistics> GetWin32PerfRawDataLsaSecuritySystemWideStatisticsAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataLsaSecuritySystemWideStatistics>(options).ToTask();
        }

        public static Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice GetWin32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice>().Single();
        }

        public static Task<Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice> GetWin32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDeviceAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice>(options).ToTask();
        }

        public static Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice GetWin32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice>().Single();
        }

        public static Task<Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice> GetWin32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDeviceAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice>(options).ToTask();
        }

        public static Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP GetWin32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP>().Single();
        }

        public static Task<Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP> GetWin32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP>(options).ToTask();
        }

        public static Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP GetWin32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP>().Single();
        }

        public static Task<Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP> GetWin32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP>(options).ToTask();
        }

        public static Win32PerfFormattedDataMicrosoftWindowsW32TimePerfWindowsTimeService GetWin32PerfFormattedDataMicrosoftWindowsW32TimePerfWindowsTimeService(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataMicrosoftWindowsW32TimePerfWindowsTimeService>().Single();
        }

        public static Task<Win32PerfFormattedDataMicrosoftWindowsW32TimePerfWindowsTimeService> GetWin32PerfFormattedDataMicrosoftWindowsW32TimePerfWindowsTimeServiceAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataMicrosoftWindowsW32TimePerfWindowsTimeService>(options).ToTask();
        }

        public static Win32PerfRawDataMicrosoftWindowsW32TimePerfWindowsTimeService GetWin32PerfRawDataMicrosoftWindowsW32TimePerfWindowsTimeService(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataMicrosoftWindowsW32TimePerfWindowsTimeService>().Single();
        }

        public static Task<Win32PerfRawDataMicrosoftWindowsW32TimePerfWindowsTimeService> GetWin32PerfRawDataMicrosoftWindowsW32TimePerfWindowsTimeServiceAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataMicrosoftWindowsW32TimePerfWindowsTimeService>(options).ToTask();
        }

        public static Win32PerfFormattedDataMSDTCDistributedTransactionCoordinator GetWin32PerfFormattedDataMSDTCDistributedTransactionCoordinator(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataMSDTCDistributedTransactionCoordinator>().Single();
        }

        public static Task<Win32PerfFormattedDataMSDTCDistributedTransactionCoordinator> GetWin32PerfFormattedDataMSDTCDistributedTransactionCoordinatorAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataMSDTCDistributedTransactionCoordinator>(options).ToTask();
        }

        public static Win32PerfRawDataMSDTCDistributedTransactionCoordinator GetWin32PerfRawDataMSDTCDistributedTransactionCoordinator(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataMSDTCDistributedTransactionCoordinator>().Single();
        }

        public static Task<Win32PerfRawDataMSDTCDistributedTransactionCoordinator> GetWin32PerfRawDataMSDTCDistributedTransactionCoordinatorAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataMSDTCDistributedTransactionCoordinator>(options).ToTask();
        }

        public static Win32PerfFormattedDataMSDTCBridge4000MSDTCBridge4000 GetWin32PerfFormattedDataMSDTCBridge4000MSDTCBridge4000(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataMSDTCBridge4000MSDTCBridge4000>().Single();
        }

        public static Task<Win32PerfFormattedDataMSDTCBridge4000MSDTCBridge4000> GetWin32PerfFormattedDataMSDTCBridge4000MSDTCBridge4000Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataMSDTCBridge4000MSDTCBridge4000>(options).ToTask();
        }

        public static Win32PerfRawDataMSDTCBridge4000MSDTCBridge4000 GetWin32PerfRawDataMSDTCBridge4000MSDTCBridge4000(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataMSDTCBridge4000MSDTCBridge4000>().Single();
        }

        public static Task<Win32PerfRawDataMSDTCBridge4000MSDTCBridge4000> GetWin32PerfRawDataMSDTCBridge4000MSDTCBridge4000Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataMSDTCBridge4000MSDTCBridge4000>(options).ToTask();
        }

        public static Win32PerfFormattedDataNETCLRDataNETCLRData GetWin32PerfFormattedDataNETCLRDataNETCLRData(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataNETCLRDataNETCLRData>().Single();
        }

        public static Task<Win32PerfFormattedDataNETCLRDataNETCLRData> GetWin32PerfFormattedDataNETCLRDataNETCLRDataAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataNETCLRDataNETCLRData>(options).ToTask();
        }

        public static Win32PerfRawDataNETCLRDataNETCLRData GetWin32PerfRawDataNETCLRDataNETCLRData(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataNETCLRDataNETCLRData>().Single();
        }

        public static Task<Win32PerfRawDataNETCLRDataNETCLRData> GetWin32PerfRawDataNETCLRDataNETCLRDataAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataNETCLRDataNETCLRData>(options).ToTask();
        }

        public static Win32PerfFormattedDataNETCLRNetworkingNETCLRNetworking GetWin32PerfFormattedDataNETCLRNetworkingNETCLRNetworking(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataNETCLRNetworkingNETCLRNetworking>().Single();
        }

        public static Task<Win32PerfFormattedDataNETCLRNetworkingNETCLRNetworking> GetWin32PerfFormattedDataNETCLRNetworkingNETCLRNetworkingAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataNETCLRNetworkingNETCLRNetworking>(options).ToTask();
        }

        public static Win32PerfRawDataNETCLRNetworkingNETCLRNetworking GetWin32PerfRawDataNETCLRNetworkingNETCLRNetworking(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataNETCLRNetworkingNETCLRNetworking>().Single();
        }

        public static Task<Win32PerfRawDataNETCLRNetworkingNETCLRNetworking> GetWin32PerfRawDataNETCLRNetworkingNETCLRNetworkingAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataNETCLRNetworkingNETCLRNetworking>(options).ToTask();
        }

        public static Win32PerfFormattedDataOfflineFilesClientSideCaching GetWin32PerfFormattedDataOfflineFilesClientSideCaching(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataOfflineFilesClientSideCaching>().Single();
        }

        public static Task<Win32PerfFormattedDataOfflineFilesClientSideCaching> GetWin32PerfFormattedDataOfflineFilesClientSideCachingAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataOfflineFilesClientSideCaching>(options).ToTask();
        }

        public static Win32PerfRawDataOfflineFilesClientSideCaching GetWin32PerfRawDataOfflineFilesClientSideCaching(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataOfflineFilesClientSideCaching>().Single();
        }

        public static Task<Win32PerfRawDataOfflineFilesClientSideCaching> GetWin32PerfRawDataOfflineFilesClientSideCachingAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataOfflineFilesClientSideCaching>(options).ToTask();
        }

        public static Win32PerfFormattedDataOfflineFilesOfflineFiles GetWin32PerfFormattedDataOfflineFilesOfflineFiles(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataOfflineFilesOfflineFiles>().Single();
        }

        public static Task<Win32PerfFormattedDataOfflineFilesOfflineFiles> GetWin32PerfFormattedDataOfflineFilesOfflineFilesAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataOfflineFilesOfflineFiles>(options).ToTask();
        }

        public static Win32PerfRawDataOfflineFilesOfflineFiles GetWin32PerfRawDataOfflineFilesOfflineFiles(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataOfflineFilesOfflineFiles>().Single();
        }

        public static Task<Win32PerfRawDataOfflineFilesOfflineFiles> GetWin32PerfRawDataOfflineFilesOfflineFilesAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataOfflineFilesOfflineFiles>(options).ToTask();
        }

        public static Win32PerfFormattedDataPeerDistSvcBranchCache GetWin32PerfFormattedDataPeerDistSvcBranchCache(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataPeerDistSvcBranchCache>().Single();
        }

        public static Task<Win32PerfFormattedDataPeerDistSvcBranchCache> GetWin32PerfFormattedDataPeerDistSvcBranchCacheAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataPeerDistSvcBranchCache>(options).ToTask();
        }

        public static Win32PerfRawDataPeerDistSvcBranchCache GetWin32PerfRawDataPeerDistSvcBranchCache(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataPeerDistSvcBranchCache>().Single();
        }

        public static Task<Win32PerfRawDataPeerDistSvcBranchCache> GetWin32PerfRawDataPeerDistSvcBranchCacheAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataPeerDistSvcBranchCache>(options).ToTask();
        }

        public static Win32PerfFormattedDataPerfNetBrowser GetWin32PerfFormattedDataPerfNetBrowser(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataPerfNetBrowser>().Single();
        }

        public static Task<Win32PerfFormattedDataPerfNetBrowser> GetWin32PerfFormattedDataPerfNetBrowserAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataPerfNetBrowser>(options).ToTask();
        }

        public static Win32PerfRawDataPerfNetBrowser GetWin32PerfRawDataPerfNetBrowser(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataPerfNetBrowser>().Single();
        }

        public static Task<Win32PerfRawDataPerfNetBrowser> GetWin32PerfRawDataPerfNetBrowserAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataPerfNetBrowser>(options).ToTask();
        }

        public static Win32PerfFormattedDataPerfNetRedirector GetWin32PerfFormattedDataPerfNetRedirector(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataPerfNetRedirector>().Single();
        }

        public static Task<Win32PerfFormattedDataPerfNetRedirector> GetWin32PerfFormattedDataPerfNetRedirectorAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataPerfNetRedirector>(options).ToTask();
        }

        public static Win32PerfRawDataPerfNetRedirector GetWin32PerfRawDataPerfNetRedirector(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataPerfNetRedirector>().Single();
        }

        public static Task<Win32PerfRawDataPerfNetRedirector> GetWin32PerfRawDataPerfNetRedirectorAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataPerfNetRedirector>(options).ToTask();
        }

        public static Win32PerfFormattedDataPerfNetServer GetWin32PerfFormattedDataPerfNetServer(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataPerfNetServer>().Single();
        }

        public static Task<Win32PerfFormattedDataPerfNetServer> GetWin32PerfFormattedDataPerfNetServerAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataPerfNetServer>(options).ToTask();
        }

        public static Win32PerfRawDataPerfNetServer GetWin32PerfRawDataPerfNetServer(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataPerfNetServer>().Single();
        }

        public static Task<Win32PerfRawDataPerfNetServer> GetWin32PerfRawDataPerfNetServerAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataPerfNetServer>(options).ToTask();
        }

        public static Win32PerfFormattedDataPerfOSCache GetWin32PerfFormattedDataPerfOSCache(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataPerfOSCache>().Single();
        }

        public static Task<Win32PerfFormattedDataPerfOSCache> GetWin32PerfFormattedDataPerfOSCacheAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataPerfOSCache>(options).ToTask();
        }

        public static Win32PerfRawDataPerfOSCache GetWin32PerfRawDataPerfOSCache(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataPerfOSCache>().Single();
        }

        public static Task<Win32PerfRawDataPerfOSCache> GetWin32PerfRawDataPerfOSCacheAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataPerfOSCache>(options).ToTask();
        }

        public static Win32PerfFormattedDataPerfOSMemory GetWin32PerfFormattedDataPerfOSMemory(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataPerfOSMemory>().Single();
        }

        public static Task<Win32PerfFormattedDataPerfOSMemory> GetWin32PerfFormattedDataPerfOSMemoryAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataPerfOSMemory>(options).ToTask();
        }

        public static Win32PerfRawDataPerfOSMemory GetWin32PerfRawDataPerfOSMemory(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataPerfOSMemory>().Single();
        }

        public static Task<Win32PerfRawDataPerfOSMemory> GetWin32PerfRawDataPerfOSMemoryAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataPerfOSMemory>(options).ToTask();
        }

        public static Win32PerfFormattedDataPerfOSObjects GetWin32PerfFormattedDataPerfOSObjects(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataPerfOSObjects>().Single();
        }

        public static Task<Win32PerfFormattedDataPerfOSObjects> GetWin32PerfFormattedDataPerfOSObjectsAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataPerfOSObjects>(options).ToTask();
        }

        public static Win32PerfRawDataPerfOSObjects GetWin32PerfRawDataPerfOSObjects(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataPerfOSObjects>().Single();
        }

        public static Task<Win32PerfRawDataPerfOSObjects> GetWin32PerfRawDataPerfOSObjectsAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataPerfOSObjects>(options).ToTask();
        }

        public static Win32PerfFormattedDataPerfOSSystem GetWin32PerfFormattedDataPerfOSSystem(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataPerfOSSystem>().Single();
        }

        public static Task<Win32PerfFormattedDataPerfOSSystem> GetWin32PerfFormattedDataPerfOSSystemAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataPerfOSSystem>(options).ToTask();
        }

        public static Win32PerfRawDataPerfOSSystem GetWin32PerfRawDataPerfOSSystem(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataPerfOSSystem>().Single();
        }

        public static Task<Win32PerfRawDataPerfOSSystem> GetWin32PerfRawDataPerfOSSystemAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataPerfOSSystem>(options).ToTask();
        }

        public static Win32PerfFormattedDataRdyboostReadyBoostCache GetWin32PerfFormattedDataRdyboostReadyBoostCache(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataRdyboostReadyBoostCache>().Single();
        }

        public static Task<Win32PerfFormattedDataRdyboostReadyBoostCache> GetWin32PerfFormattedDataRdyboostReadyBoostCacheAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataRdyboostReadyBoostCache>(options).ToTask();
        }

        public static Win32PerfRawDataRdyboostReadyBoostCache GetWin32PerfRawDataRdyboostReadyBoostCache(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataRdyboostReadyBoostCache>().Single();
        }

        public static Task<Win32PerfRawDataRdyboostReadyBoostCache> GetWin32PerfRawDataRdyboostReadyBoostCacheAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataRdyboostReadyBoostCache>(options).ToTask();
        }

        public static Win32PerfFormattedDataRemoteAccessRASTotal GetWin32PerfFormattedDataRemoteAccessRASTotal(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataRemoteAccessRASTotal>().Single();
        }

        public static Task<Win32PerfFormattedDataRemoteAccessRASTotal> GetWin32PerfFormattedDataRemoteAccessRASTotalAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataRemoteAccessRASTotal>(options).ToTask();
        }

        public static Win32PerfRawDataRemoteAccessRASTotal GetWin32PerfRawDataRemoteAccessRASTotal(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataRemoteAccessRASTotal>().Single();
        }

        public static Task<Win32PerfRawDataRemoteAccessRASTotal> GetWin32PerfRawDataRemoteAccessRASTotalAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataRemoteAccessRASTotal>(options).ToTask();
        }

        public static Win32PerfFormattedDataSMSvcHost4000SMSvcHost4000 GetWin32PerfFormattedDataSMSvcHost4000SMSvcHost4000(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataSMSvcHost4000SMSvcHost4000>().Single();
        }

        public static Task<Win32PerfFormattedDataSMSvcHost4000SMSvcHost4000> GetWin32PerfFormattedDataSMSvcHost4000SMSvcHost4000Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataSMSvcHost4000SMSvcHost4000>(options).ToTask();
        }

        public static Win32PerfRawDataSMSvcHost4000SMSvcHost4000 GetWin32PerfRawDataSMSvcHost4000SMSvcHost4000(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataSMSvcHost4000SMSvcHost4000>().Single();
        }

        public static Task<Win32PerfRawDataSMSvcHost4000SMSvcHost4000> GetWin32PerfRawDataSMSvcHost4000SMSvcHost4000Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataSMSvcHost4000SMSvcHost4000>(options).ToTask();
        }

        public static Win32PerfFormattedDataTapiSrvTelephony GetWin32PerfFormattedDataTapiSrvTelephony(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataTapiSrvTelephony>().Single();
        }

        public static Task<Win32PerfFormattedDataTapiSrvTelephony> GetWin32PerfFormattedDataTapiSrvTelephonyAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataTapiSrvTelephony>(options).ToTask();
        }

        public static Win32PerfRawDataTapiSrvTelephony GetWin32PerfRawDataTapiSrvTelephony(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataTapiSrvTelephony>().Single();
        }

        public static Task<Win32PerfRawDataTapiSrvTelephony> GetWin32PerfRawDataTapiSrvTelephonyAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataTapiSrvTelephony>(options).ToTask();
        }

        public static Win32PerfFormattedDataTcpipICMP GetWin32PerfFormattedDataTcpipICMP(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataTcpipICMP>().Single();
        }

        public static Task<Win32PerfFormattedDataTcpipICMP> GetWin32PerfFormattedDataTcpipICMPAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataTcpipICMP>(options).ToTask();
        }

        public static Win32PerfRawDataTcpipICMP GetWin32PerfRawDataTcpipICMP(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataTcpipICMP>().Single();
        }

        public static Task<Win32PerfRawDataTcpipICMP> GetWin32PerfRawDataTcpipICMPAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataTcpipICMP>(options).ToTask();
        }

        public static Win32PerfFormattedDataTcpipICMPv6 GetWin32PerfFormattedDataTcpipICMPv6(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataTcpipICMPv6>().Single();
        }

        public static Task<Win32PerfFormattedDataTcpipICMPv6> GetWin32PerfFormattedDataTcpipICMPv6Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataTcpipICMPv6>(options).ToTask();
        }

        public static Win32PerfRawDataTcpipICMPv6 GetWin32PerfRawDataTcpipICMPv6(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataTcpipICMPv6>().Single();
        }

        public static Task<Win32PerfRawDataTcpipICMPv6> GetWin32PerfRawDataTcpipICMPv6Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataTcpipICMPv6>(options).ToTask();
        }

        public static Win32PerfFormattedDataTcpipIPv4 GetWin32PerfFormattedDataTcpipIPv4(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataTcpipIPv4>().Single();
        }

        public static Task<Win32PerfFormattedDataTcpipIPv4> GetWin32PerfFormattedDataTcpipIPv4Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataTcpipIPv4>(options).ToTask();
        }

        public static Win32PerfRawDataTcpipIPv4 GetWin32PerfRawDataTcpipIPv4(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataTcpipIPv4>().Single();
        }

        public static Task<Win32PerfRawDataTcpipIPv4> GetWin32PerfRawDataTcpipIPv4Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataTcpipIPv4>(options).ToTask();
        }

        public static Win32PerfFormattedDataTcpipIPv6 GetWin32PerfFormattedDataTcpipIPv6(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataTcpipIPv6>().Single();
        }

        public static Task<Win32PerfFormattedDataTcpipIPv6> GetWin32PerfFormattedDataTcpipIPv6Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataTcpipIPv6>(options).ToTask();
        }

        public static Win32PerfRawDataTcpipIPv6 GetWin32PerfRawDataTcpipIPv6(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataTcpipIPv6>().Single();
        }

        public static Task<Win32PerfRawDataTcpipIPv6> GetWin32PerfRawDataTcpipIPv6Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataTcpipIPv6>(options).ToTask();
        }

        public static Win32PerfFormattedDataTcpipTCPv4 GetWin32PerfFormattedDataTcpipTCPv4(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataTcpipTCPv4>().Single();
        }

        public static Task<Win32PerfFormattedDataTcpipTCPv4> GetWin32PerfFormattedDataTcpipTCPv4Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataTcpipTCPv4>(options).ToTask();
        }

        public static Win32PerfRawDataTcpipTCPv4 GetWin32PerfRawDataTcpipTCPv4(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataTcpipTCPv4>().Single();
        }

        public static Task<Win32PerfRawDataTcpipTCPv4> GetWin32PerfRawDataTcpipTCPv4Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataTcpipTCPv4>(options).ToTask();
        }

        public static Win32PerfFormattedDataTcpipTCPv6 GetWin32PerfFormattedDataTcpipTCPv6(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataTcpipTCPv6>().Single();
        }

        public static Task<Win32PerfFormattedDataTcpipTCPv6> GetWin32PerfFormattedDataTcpipTCPv6Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataTcpipTCPv6>(options).ToTask();
        }

        public static Win32PerfRawDataTcpipTCPv6 GetWin32PerfRawDataTcpipTCPv6(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataTcpipTCPv6>().Single();
        }

        public static Task<Win32PerfRawDataTcpipTCPv6> GetWin32PerfRawDataTcpipTCPv6Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataTcpipTCPv6>(options).ToTask();
        }

        public static Win32PerfFormattedDataTcpipUDPv4 GetWin32PerfFormattedDataTcpipUDPv4(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataTcpipUDPv4>().Single();
        }

        public static Task<Win32PerfFormattedDataTcpipUDPv4> GetWin32PerfFormattedDataTcpipUDPv4Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataTcpipUDPv4>(options).ToTask();
        }

        public static Win32PerfRawDataTcpipUDPv4 GetWin32PerfRawDataTcpipUDPv4(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataTcpipUDPv4>().Single();
        }

        public static Task<Win32PerfRawDataTcpipUDPv4> GetWin32PerfRawDataTcpipUDPv4Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataTcpipUDPv4>(options).ToTask();
        }

        public static Win32PerfFormattedDataTcpipUDPv6 GetWin32PerfFormattedDataTcpipUDPv6(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataTcpipUDPv6>().Single();
        }

        public static Task<Win32PerfFormattedDataTcpipUDPv6> GetWin32PerfFormattedDataTcpipUDPv6Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataTcpipUDPv6>(options).ToTask();
        }

        public static Win32PerfRawDataTcpipUDPv6 GetWin32PerfRawDataTcpipUDPv6(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataTcpipUDPv6>().Single();
        }

        public static Task<Win32PerfRawDataTcpipUDPv6> GetWin32PerfRawDataTcpipUDPv6Async(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataTcpipUDPv6>(options).ToTask();
        }

        public static Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnostics GetWin32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnostics(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnostics>().Single();
        }

        public static Task<Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnostics> GetWin32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnosticsAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnostics>(options).ToTask();
        }

        public static Win32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnostics GetWin32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnostics(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnostics>().Single();
        }

        public static Task<Win32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnostics> GetWin32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnosticsAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnostics>(options).ToTask();
        }

        public static Win32PerfFormattedDataUGTHRSVCSearchGatherer GetWin32PerfFormattedDataUGTHRSVCSearchGatherer(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataUGTHRSVCSearchGatherer>().Single();
        }

        public static Task<Win32PerfFormattedDataUGTHRSVCSearchGatherer> GetWin32PerfFormattedDataUGTHRSVCSearchGathererAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataUGTHRSVCSearchGatherer>(options).ToTask();
        }

        public static Win32PerfRawDataUGTHRSVCSearchGatherer GetWin32PerfRawDataUGTHRSVCSearchGatherer(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataUGTHRSVCSearchGatherer>().Single();
        }

        public static Task<Win32PerfRawDataUGTHRSVCSearchGatherer> GetWin32PerfRawDataUGTHRSVCSearchGathererAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataUGTHRSVCSearchGatherer>(options).ToTask();
        }

        public static Win32PerfFormattedDataVidPerfProviderHyperVVMVidDriver GetWin32PerfFormattedDataVidPerfProviderHyperVVMVidDriver(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataVidPerfProviderHyperVVMVidDriver>().Single();
        }

        public static Task<Win32PerfFormattedDataVidPerfProviderHyperVVMVidDriver> GetWin32PerfFormattedDataVidPerfProviderHyperVVMVidDriverAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataVidPerfProviderHyperVVMVidDriver>(options).ToTask();
        }

        public static Win32PerfRawDataVidPerfProviderHyperVVMVidDriver GetWin32PerfRawDataVidPerfProviderHyperVVMVidDriver(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataVidPerfProviderHyperVVMVidDriver>().Single();
        }

        public static Task<Win32PerfRawDataVidPerfProviderHyperVVMVidDriver> GetWin32PerfRawDataVidPerfProviderHyperVVMVidDriverAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataVidPerfProviderHyperVVMVidDriver>(options).ToTask();
        }

        public static Win32PerfFormattedDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary GetWin32PerfFormattedDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary>().Single();
        }

        public static Task<Win32PerfFormattedDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary> GetWin32PerfFormattedDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummaryAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary>(options).ToTask();
        }

        public static Win32PerfRawDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary GetWin32PerfRawDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary>().Single();
        }

        public static Task<Win32PerfRawDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary> GetWin32PerfRawDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummaryAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary>(options).ToTask();
        }

        public static Win32PerfFormattedDataWinNatCountersWinNAT GetWin32PerfFormattedDataWinNatCountersWinNAT(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataWinNatCountersWinNAT>().Single();
        }

        public static Task<Win32PerfFormattedDataWinNatCountersWinNAT> GetWin32PerfFormattedDataWinNatCountersWinNATAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataWinNatCountersWinNAT>(options).ToTask();
        }

        public static Win32PerfRawDataWinNatCountersWinNAT GetWin32PerfRawDataWinNatCountersWinNAT(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataWinNatCountersWinNAT>().Single();
        }

        public static Task<Win32PerfRawDataWinNatCountersWinNAT> GetWin32PerfRawDataWinNatCountersWinNATAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataWinNatCountersWinNAT>(options).ToTask();
        }

        public static Win32PerfFormattedDataWinNatCountersWinNATICMP GetWin32PerfFormattedDataWinNatCountersWinNATICMP(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataWinNatCountersWinNATICMP>().Single();
        }

        public static Task<Win32PerfFormattedDataWinNatCountersWinNATICMP> GetWin32PerfFormattedDataWinNatCountersWinNATICMPAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataWinNatCountersWinNATICMP>(options).ToTask();
        }

        public static Win32PerfRawDataWinNatCountersWinNATICMP GetWin32PerfRawDataWinNatCountersWinNATICMP(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataWinNatCountersWinNATICMP>().Single();
        }

        public static Task<Win32PerfRawDataWinNatCountersWinNATICMP> GetWin32PerfRawDataWinNatCountersWinNATICMPAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataWinNatCountersWinNATICMP>(options).ToTask();
        }

        public static Win32PerfFormattedDataWinNatCountersWinNATTCP GetWin32PerfFormattedDataWinNatCountersWinNATTCP(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataWinNatCountersWinNATTCP>().Single();
        }

        public static Task<Win32PerfFormattedDataWinNatCountersWinNATTCP> GetWin32PerfFormattedDataWinNatCountersWinNATTCPAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataWinNatCountersWinNATTCP>(options).ToTask();
        }

        public static Win32PerfRawDataWinNatCountersWinNATTCP GetWin32PerfRawDataWinNatCountersWinNATTCP(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataWinNatCountersWinNATTCP>().Single();
        }

        public static Task<Win32PerfRawDataWinNatCountersWinNATTCP> GetWin32PerfRawDataWinNatCountersWinNATTCPAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataWinNatCountersWinNATTCP>(options).ToTask();
        }

        public static Win32PerfFormattedDataWinNatCountersWinNATUDP GetWin32PerfFormattedDataWinNatCountersWinNATUDP(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfFormattedDataWinNatCountersWinNATUDP>().Single();
        }

        public static Task<Win32PerfFormattedDataWinNatCountersWinNATUDP> GetWin32PerfFormattedDataWinNatCountersWinNATUDPAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfFormattedDataWinNatCountersWinNATUDP>(options).ToTask();
        }

        public static Win32PerfRawDataWinNatCountersWinNATUDP GetWin32PerfRawDataWinNatCountersWinNATUDP(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<Win32PerfRawDataWinNatCountersWinNATUDP>().Single();
        }

        public static Task<Win32PerfRawDataWinNatCountersWinNATUDP> GetWin32PerfRawDataWinNatCountersWinNATUDPAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<Win32PerfRawDataWinNatCountersWinNATUDP>(options).ToTask();
        }
    }
}