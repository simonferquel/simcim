using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using SimCim.Core;

namespace SimCim.Root.V2
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
                case "__NAMESPACE":
                    return new NAMESPACE(_scope, cimInstance);
                case "__FilterToConsumerBinding":
                    return new FilterToConsumerBinding(_scope, cimInstance);
                case "__AggregateEvent":
                    return new AggregateEvent(_scope, cimInstance);
                case "__TimerNextFiring":
                    return new TimerNextFiring(_scope, cimInstance);
                case "__EventFilter":
                    return new EventFilter(_scope, cimInstance);
                case "__NamespaceOperationEvent":
                    return new NamespaceOperationEvent(_scope, cimInstance);
                case "__NamespaceModificationEvent":
                    return new NamespaceModificationEvent(_scope, cimInstance);
                case "__NamespaceDeletionEvent":
                    return new NamespaceDeletionEvent(_scope, cimInstance);
                case "__NamespaceCreationEvent":
                    return new NamespaceCreationEvent(_scope, cimInstance);
                case "__ClassOperationEvent":
                    return new ClassOperationEvent(_scope, cimInstance);
                case "__ClassDeletionEvent":
                    return new ClassDeletionEvent(_scope, cimInstance);
                case "__ClassModificationEvent":
                    return new ClassModificationEvent(_scope, cimInstance);
                case "__ClassCreationEvent":
                    return new ClassCreationEvent(_scope, cimInstance);
                case "__InstanceOperationEvent":
                    return new InstanceOperationEvent(_scope, cimInstance);
                case "__InstanceCreationEvent":
                    return new InstanceCreationEvent(_scope, cimInstance);
                case "__MethodInvocationEvent":
                    return new MethodInvocationEvent(_scope, cimInstance);
                case "__InstanceModificationEvent":
                    return new InstanceModificationEvent(_scope, cimInstance);
                case "__InstanceDeletionEvent":
                    return new InstanceDeletionEvent(_scope, cimInstance);
                case "__TimerEvent":
                    return new TimerEvent(_scope, cimInstance);
                case "__ExtrinsicEvent":
                    return new ExtrinsicEvent(_scope, cimInstance);
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
                case "MSFT_SCMEvent":
                    return new MSFTSCMEvent(_scope, cimInstance);
                case "MSFT_SCMEventLogEvent":
                    return new MSFTSCMEventLogEvent(_scope, cimInstance);
                case "MSFT_NetSevereServiceFailed":
                    return new MSFTNetSevereServiceFailed(_scope, cimInstance);
                case "MSFT_NetTransactInvalid":
                    return new MSFTNetTransactInvalid(_scope, cimInstance);
                case "MSFT_NetServiceNotInteractive":
                    return new MSFTNetServiceNotInteractive(_scope, cimInstance);
                case "MSFT_NetTakeOwnership":
                    return new MSFTNetTakeOwnership(_scope, cimInstance);
                case "MSFT_NetServiceConfigBackoutFailed":
                    return new MSFTNetServiceConfigBackoutFailed(_scope, cimInstance);
                case "MSFT_NetServiceShutdownFailed":
                    return new MSFTNetServiceShutdownFailed(_scope, cimInstance);
                case "MSFT_NetServiceStartHung":
                    return new MSFTNetServiceStartHung(_scope, cimInstance);
                case "MSFT_NetServiceStopControlSuccess":
                    return new MSFTNetServiceStopControlSuccess(_scope, cimInstance);
                case "MSFT_NetServiceSlowStartup":
                    return new MSFTNetServiceSlowStartup(_scope, cimInstance);
                case "MSFT_NetCallToFunctionFailed":
                    return new MSFTNetCallToFunctionFailed(_scope, cimInstance);
                case "MSFT_NetBadAccount":
                    return new MSFTNetBadAccount(_scope, cimInstance);
                case "MSFT_NetBadServiceState":
                    return new MSFTNetBadServiceState(_scope, cimInstance);
                case "MSFT_NetConnectionTimeout":
                    return new MSFTNetConnectionTimeout(_scope, cimInstance);
                case "MSFT_NetCircularDependencyAuto":
                    return new MSFTNetCircularDependencyAuto(_scope, cimInstance);
                case "MSFT_NetServiceStartTypeChanged":
                    return new MSFTNetServiceStartTypeChanged(_scope, cimInstance);
                case "MSFT_NetServiceLogonTypeNotGranted":
                    return new MSFTNetServiceLogonTypeNotGranted(_scope, cimInstance);
                case "MSFT_NetServiceStartFailedGroup":
                    return new MSFTNetServiceStartFailedGroup(_scope, cimInstance);
                case "MSFT_NetDependOnLaterService":
                    return new MSFTNetDependOnLaterService(_scope, cimInstance);
                case "MSFT_NetFirstLogonFailedII":
                    return new MSFTNetFirstLogonFailedII(_scope, cimInstance);
                case "MSFT_NetServiceDifferentPIDConnected":
                    return new MSFTNetServiceDifferentPIDConnected(_scope, cimInstance);
                case "MSFT_NetServiceCrashNoAction":
                    return new MSFTNetServiceCrashNoAction(_scope, cimInstance);
                case "MSFT_NetCircularDependencyDemand":
                    return new MSFTNetCircularDependencyDemand(_scope, cimInstance);
                case "MSFT_NetServiceExitFailed":
                    return new MSFTNetServiceExitFailed(_scope, cimInstance);
                case "MSFT_NetServiceStartFailedII":
                    return new MSFTNetServiceStartFailedII(_scope, cimInstance);
                case "MSFT_NetServiceExitFailedSpecific":
                    return new MSFTNetServiceExitFailedSpecific(_scope, cimInstance);
                case "MSFT_NetBootSystemDriversFailed":
                    return new MSFTNetBootSystemDriversFailed(_scope, cimInstance);
                case "MSFT_NetServiceCrash":
                    return new MSFTNetServiceCrash(_scope, cimInstance);
                case "MSFT_NetServiceRecoveryFailed":
                    return new MSFTNetServiceRecoveryFailed(_scope, cimInstance);
                case "MSFT_NetServiceStatusSuccess":
                    return new MSFTNetServiceStatusSuccess(_scope, cimInstance);
                case "MSFT_NetTransactTimeout":
                    return new MSFTNetTransactTimeout(_scope, cimInstance);
                case "MSFT_NetFirstLogonFailed":
                    return new MSFTNetFirstLogonFailed(_scope, cimInstance);
                case "MSFT_NetServiceControlSuccess":
                    return new MSFTNetServiceControlSuccess(_scope, cimInstance);
                case "MSFT_NetServiceStartFailed":
                    return new MSFTNetServiceStartFailed(_scope, cimInstance);
                case "MSFT_NetServiceStartFailedNone":
                    return new MSFTNetServiceStartFailedNone(_scope, cimInstance);
                case "MSFT_NetReadfileTimeout":
                    return new MSFTNetReadfileTimeout(_scope, cimInstance);
                case "MSFT_NetRevertedToLastKnownGood":
                    return new MSFTNetRevertedToLastKnownGood(_scope, cimInstance);
                case "MSFT_NetCallToFunctionFailedII":
                    return new MSFTNetCallToFunctionFailedII(_scope, cimInstance);
                case "MSFT_NetDependOnLaterGroup":
                    return new MSFTNetDependOnLaterGroup(_scope, cimInstance);
                case "MSFT_WmiSelfEvent":
                    return new MSFTWmiSelfEvent(_scope, cimInstance);
                case "MSFT_WmiEssEvent":
                    return new MSFTWmiEssEvent(_scope, cimInstance);
                case "MSFT_WmiThreadPoolEvent":
                    return new MSFTWmiThreadPoolEvent(_scope, cimInstance);
                case "MSFT_WmiThreadPoolThreadCreated":
                    return new MSFTWmiThreadPoolThreadCreated(_scope, cimInstance);
                case "MSFT_WmiThreadPoolThreadDeleted":
                    return new MSFTWmiThreadPoolThreadDeleted(_scope, cimInstance);
                case "MSFT_WmiRegisterNotificationSink":
                    return new MSFTWmiRegisterNotificationSink(_scope, cimInstance);
                case "MSFT_WmiFilterEvent":
                    return new MSFTWmiFilterEvent(_scope, cimInstance);
                case "MSFT_WmiFilterDeactivated":
                    return new MSFTWmiFilterDeactivated(_scope, cimInstance);
                case "MSFT_WmiFilterActivated":
                    return new MSFTWmiFilterActivated(_scope, cimInstance);
                case "MSFT_WmiCancelNotificationSink":
                    return new MSFTWmiCancelNotificationSink(_scope, cimInstance);
                case "MSFT_WmiProviderEvent":
                    return new MSFTWmiProviderEvent(_scope, cimInstance);
                case "MSFT_WmiConsumerProviderEvent":
                    return new MSFTWmiConsumerProviderEvent(_scope, cimInstance);
                case "MSFT_WmiConsumerProviderSinkLoaded":
                    return new MSFTWmiConsumerProviderSinkLoaded(_scope, cimInstance);
                case "MSFT_WmiConsumerProviderSinkUnloaded":
                    return new MSFTWmiConsumerProviderSinkUnloaded(_scope, cimInstance);
                case "MSFT_WmiConsumerProviderUnloaded":
                    return new MSFTWmiConsumerProviderUnloaded(_scope, cimInstance);
                case "MSFT_WmiConsumerProviderLoaded":
                    return new MSFTWmiConsumerProviderLoaded(_scope, cimInstance);
                case "Msft_WmiProvider_OperationEvent":
                    return new MsftWmiProviderOperationEvent(_scope, cimInstance);
                case "Msft_WmiProvider_ComServerLoadOperationEvent":
                    return new MsftWmiProviderComServerLoadOperationEvent(_scope, cimInstance);
                case "Msft_WmiProvider_OperationEvent_Post":
                    return new MsftWmiProviderOperationEventPost(_scope, cimInstance);
                case "Msft_WmiProvider_PutInstanceAsyncEvent_Post":
                    return new MsftWmiProviderPutInstanceAsyncEventPost(_scope, cimInstance);
                case "Msft_WmiProvider_CreateInstanceEnumAsyncEvent_Post":
                    return new MsftWmiProviderCreateInstanceEnumAsyncEventPost(_scope, cimInstance);
                case "Msft_WmiProvider_DeleteInstanceAsyncEvent_Post":
                    return new MsftWmiProviderDeleteInstanceAsyncEventPost(_scope, cimInstance);
                case "Msft_WmiProvider_CancelQuery_Post":
                    return new MsftWmiProviderCancelQueryPost(_scope, cimInstance);
                case "Msft_WmiProvider_NewQuery_Post":
                    return new MsftWmiProviderNewQueryPost(_scope, cimInstance);
                case "Msft_WmiProvider_ProvideEvents_Post":
                    return new MsftWmiProviderProvideEventsPost(_scope, cimInstance);
                case "Msft_WmiProvider_ExecQueryAsyncEvent_Post":
                    return new MsftWmiProviderExecQueryAsyncEventPost(_scope, cimInstance);
                case "Msft_WmiProvider_AccessCheck_Post":
                    return new MsftWmiProviderAccessCheckPost(_scope, cimInstance);
                case "Msft_WmiProvider_CreateClassEnumAsyncEvent_Post":
                    return new MsftWmiProviderCreateClassEnumAsyncEventPost(_scope, cimInstance);
                case "Msft_WmiProvider_DeleteClassAsyncEvent_Post":
                    return new MsftWmiProviderDeleteClassAsyncEventPost(_scope, cimInstance);
                case "Msft_WmiProvider_ExecMethodAsyncEvent_Post":
                    return new MsftWmiProviderExecMethodAsyncEventPost(_scope, cimInstance);
                case "Msft_WmiProvider_GetObjectAsyncEvent_Post":
                    return new MsftWmiProviderGetObjectAsyncEventPost(_scope, cimInstance);
                case "Msft_WmiProvider_PutClassAsyncEvent_Post":
                    return new MsftWmiProviderPutClassAsyncEventPost(_scope, cimInstance);
                case "Msft_WmiProvider_InitializationOperationFailureEvent":
                    return new MsftWmiProviderInitializationOperationFailureEvent(_scope, cimInstance);
                case "Msft_WmiProvider_InitializationOperationEvent":
                    return new MsftWmiProviderInitializationOperationEvent(_scope, cimInstance);
                case "Msft_WmiProvider_LoadOperationFailureEvent":
                    return new MsftWmiProviderLoadOperationFailureEvent(_scope, cimInstance);
                case "Msft_WmiProvider_ComServerLoadOperationFailureEvent":
                    return new MsftWmiProviderComServerLoadOperationFailureEvent(_scope, cimInstance);
                case "Msft_WmiProvider_UnLoadOperationEvent":
                    return new MsftWmiProviderUnLoadOperationEvent(_scope, cimInstance);
                case "Msft_WmiProvider_LoadOperationEvent":
                    return new MsftWmiProviderLoadOperationEvent(_scope, cimInstance);
                case "Msft_WmiProvider_OperationEvent_Pre":
                    return new MsftWmiProviderOperationEventPre(_scope, cimInstance);
                case "Msft_WmiProvider_DeleteInstanceAsyncEvent_Pre":
                    return new MsftWmiProviderDeleteInstanceAsyncEventPre(_scope, cimInstance);
                case "Msft_WmiProvider_AccessCheck_Pre":
                    return new MsftWmiProviderAccessCheckPre(_scope, cimInstance);
                case "Msft_WmiProvider_ExecQueryAsyncEvent_Pre":
                    return new MsftWmiProviderExecQueryAsyncEventPre(_scope, cimInstance);
                case "Msft_WmiProvider_DeleteClassAsyncEvent_Pre":
                    return new MsftWmiProviderDeleteClassAsyncEventPre(_scope, cimInstance);
                case "Msft_WmiProvider_NewQuery_Pre":
                    return new MsftWmiProviderNewQueryPre(_scope, cimInstance);
                case "Msft_WmiProvider_PutInstanceAsyncEvent_Pre":
                    return new MsftWmiProviderPutInstanceAsyncEventPre(_scope, cimInstance);
                case "Msft_WmiProvider_CreateClassEnumAsyncEvent_Pre":
                    return new MsftWmiProviderCreateClassEnumAsyncEventPre(_scope, cimInstance);
                case "Msft_WmiProvider_ExecMethodAsyncEvent_Pre":
                    return new MsftWmiProviderExecMethodAsyncEventPre(_scope, cimInstance);
                case "Msft_WmiProvider_ProvideEvents_Pre":
                    return new MsftWmiProviderProvideEventsPre(_scope, cimInstance);
                case "Msft_WmiProvider_CancelQuery_Pre":
                    return new MsftWmiProviderCancelQueryPre(_scope, cimInstance);
                case "Msft_WmiProvider_PutClassAsyncEvent_Pre":
                    return new MsftWmiProviderPutClassAsyncEventPre(_scope, cimInstance);
                case "Msft_WmiProvider_GetObjectAsyncEvent_Pre":
                    return new MsftWmiProviderGetObjectAsyncEventPre(_scope, cimInstance);
                case "Msft_WmiProvider_CreateInstanceEnumAsyncEvent_Pre":
                    return new MsftWmiProviderCreateInstanceEnumAsyncEventPre(_scope, cimInstance);
                case "MSFT_WMI_GenericNonCOMEvent":
                    return new MSFTWMIGenericNonCOMEvent(_scope, cimInstance);
                case "Win32_ComputerSystemEvent":
                    return new Win32ComputerSystemEvent(_scope, cimInstance);
                case "Win32_ComputerShutdownEvent":
                    return new Win32ComputerShutdownEvent(_scope, cimInstance);
                case "Win32_IP4RouteTableEvent":
                    return new Win32IP4RouteTableEvent(_scope, cimInstance);
                case "MSFT_NCProvEvent":
                    return new MSFTNCProvEvent(_scope, cimInstance);
                case "MSFT_NCProvCancelQuery":
                    return new MSFTNCProvCancelQuery(_scope, cimInstance);
                case "MSFT_NCProvClientConnected":
                    return new MSFTNCProvClientConnected(_scope, cimInstance);
                case "MSFT_NCProvNewQuery":
                    return new MSFTNCProvNewQuery(_scope, cimInstance);
                case "MSFT_NCProvAccessCheck":
                    return new MSFTNCProvAccessCheck(_scope, cimInstance);
                case "RegistryEvent":
                    return new RegistryEvent(_scope, cimInstance);
                case "RegistryKeyChangeEvent":
                    return new RegistryKeyChangeEvent(_scope, cimInstance);
                case "RegistryTreeChangeEvent":
                    return new RegistryTreeChangeEvent(_scope, cimInstance);
                case "RegistryValueChangeEvent":
                    return new RegistryValueChangeEvent(_scope, cimInstance);
                case "Win32_SystemTrace":
                    return new Win32SystemTrace(_scope, cimInstance);
                case "Win32_ProcessTrace":
                    return new Win32ProcessTrace(_scope, cimInstance);
                case "Win32_ProcessStartTrace":
                    return new Win32ProcessStartTrace(_scope, cimInstance);
                case "Win32_ProcessStopTrace":
                    return new Win32ProcessStopTrace(_scope, cimInstance);
                case "Win32_ModuleTrace":
                    return new Win32ModuleTrace(_scope, cimInstance);
                case "Win32_ModuleLoadTrace":
                    return new Win32ModuleLoadTrace(_scope, cimInstance);
                case "Win32_ThreadTrace":
                    return new Win32ThreadTrace(_scope, cimInstance);
                case "Win32_ThreadStartTrace":
                    return new Win32ThreadStartTrace(_scope, cimInstance);
                case "Win32_ThreadStopTrace":
                    return new Win32ThreadStopTrace(_scope, cimInstance);
                case "Win32_PowerManagementEvent":
                    return new Win32PowerManagementEvent(_scope, cimInstance);
                case "Win32_DeviceChangeEvent":
                    return new Win32DeviceChangeEvent(_scope, cimInstance);
                case "Win32_SystemConfigurationChangeEvent":
                    return new Win32SystemConfigurationChangeEvent(_scope, cimInstance);
                case "Win32_VolumeChangeEvent":
                    return new Win32VolumeChangeEvent(_scope, cimInstance);
                case "__AbsoluteTimerInstruction":
                    return new AbsoluteTimerInstruction(_scope, cimInstance);
                case "__IntervalTimerInstruction":
                    return new IntervalTimerInstruction(_scope, cimInstance);
                case "__SystemSecurity":
                    return new SystemSecurity(_scope, cimInstance);
                case "Win32_BaseBoard":
                    return new Win32BaseBoard(_scope, cimInstance);
                case "Win32_SystemEnclosure":
                    return new Win32SystemEnclosure(_scope, cimInstance);
                case "Win32_PhysicalMemoryArray":
                    return new Win32PhysicalMemoryArray(_scope, cimInstance);
                case "Win32_PhysicalMedia":
                    return new Win32PhysicalMedia(_scope, cimInstance);
                case "Win32_PhysicalMemory":
                    return new Win32PhysicalMemory(_scope, cimInstance);
                case "Win32_OnBoardDevice":
                    return new Win32OnBoardDevice(_scope, cimInstance);
                case "Win32_SystemSlot":
                    return new Win32SystemSlot(_scope, cimInstance);
                case "Win32_PortConnector":
                    return new Win32PortConnector(_scope, cimInstance);
                case "Win32_OperatingSystem":
                    return new Win32OperatingSystem(_scope, cimInstance);
                case "Win32_Process":
                    return new Win32Process(_scope, cimInstance);
                case "Win32_LogicalDisk":
                    return new Win32LogicalDisk(_scope, cimInstance);
                case "Win32_MappedLogicalDisk":
                    return new Win32MappedLogicalDisk(_scope, cimInstance);
                case "Win32_DiskPartition":
                    return new Win32DiskPartition(_scope, cimInstance);
                case "Win32_CacheMemory":
                    return new Win32CacheMemory(_scope, cimInstance);
                case "CIM_StorageVolume":
                    return new CIMStorageVolume(_scope, cimInstance);
                case "Win32_Volume":
                    return new Win32Volume(_scope, cimInstance);
                case "Win32_MemoryArray":
                    return new Win32MemoryArray(_scope, cimInstance);
                case "Win32_MemoryDevice":
                    return new Win32MemoryDevice(_scope, cimInstance);
                case "Win32_DiskDrive":
                    return new Win32DiskDrive(_scope, cimInstance);
                case "Win32_TapeDrive":
                    return new Win32TapeDrive(_scope, cimInstance);
                case "Win32_CDROMDrive":
                    return new Win32CDROMDrive(_scope, cimInstance);
                case "Win32_PnPEntity":
                    return new Win32PnPEntity(_scope, cimInstance);
                case "Win32_1394Controller":
                    return new Win321394Controller(_scope, cimInstance);
                case "Win32_VideoController":
                    return new Win32VideoController(_scope, cimInstance);
                case "Win32_SCSIController":
                    return new Win32SCSIController(_scope, cimInstance);
                case "Win32_InfraredDevice":
                    return new Win32InfraredDevice(_scope, cimInstance);
                case "Win32_PCMCIAController":
                    return new Win32PCMCIAController(_scope, cimInstance);
                case "Win32_USBController":
                    return new Win32USBController(_scope, cimInstance);
                case "Win32_SerialPort":
                    return new Win32SerialPort(_scope, cimInstance);
                case "Win32_ParallelPort":
                    return new Win32ParallelPort(_scope, cimInstance);
                case "Win32_IDEController":
                    return new Win32IDEController(_scope, cimInstance);
                case "Win32_Processor":
                    return new Win32Processor(_scope, cimInstance);
                case "Win32_Battery":
                    return new Win32Battery(_scope, cimInstance);
                case "Win32_PortableBattery":
                    return new Win32PortableBattery(_scope, cimInstance);
                case "Win32_NetworkAdapter":
                    return new Win32NetworkAdapter(_scope, cimInstance);
                case "Win32_Printer":
                    return new Win32Printer(_scope, cimInstance);
                case "Win32_TemperatureProbe":
                    return new Win32TemperatureProbe(_scope, cimInstance);
                case "Win32_VoltageProbe":
                    return new Win32VoltageProbe(_scope, cimInstance);
                case "Win32_CurrentProbe":
                    return new Win32CurrentProbe(_scope, cimInstance);
                case "Win32_Bus":
                    return new Win32Bus(_scope, cimInstance);
                case "Win32_Keyboard":
                    return new Win32Keyboard(_scope, cimInstance);
                case "Win32_DesktopMonitor":
                    return new Win32DesktopMonitor(_scope, cimInstance);
                case "Win32_PointingDevice":
                    return new Win32PointingDevice(_scope, cimInstance);
                case "CIM_USBDevice":
                    return new CIMUSBDevice(_scope, cimInstance);
                case "CIM_USBHub":
                    return new CIMUSBHub(_scope, cimInstance);
                case "Win32_USBHub":
                    return new Win32USBHub(_scope, cimInstance);
                case "Win32_SoundDevice":
                    return new Win32SoundDevice(_scope, cimInstance);
                case "Win32_MotherboardDevice":
                    return new Win32MotherboardDevice(_scope, cimInstance);
                case "Win32_POTSModem":
                    return new Win32POTSModem(_scope, cimInstance);
                case "Win32_HeatPipe":
                    return new Win32HeatPipe(_scope, cimInstance);
                case "Win32_Refrigeration":
                    return new Win32Refrigeration(_scope, cimInstance);
                case "Win32_Fan":
                    return new Win32Fan(_scope, cimInstance);
                case "Win32_ComputerSystem":
                    return new Win32ComputerSystem(_scope, cimInstance);
                case "Win32_NTDomain":
                    return new Win32NTDomain(_scope, cimInstance);
                case "Win32_OptionalFeature":
                    return new Win32OptionalFeature(_scope, cimInstance);
                case "Win32_BIOS":
                    return new Win32BIOS(_scope, cimInstance);
                case "Win32_SoftwareElement":
                    return new Win32SoftwareElement(_scope, cimInstance);
                case "Win32_Service":
                    return new Win32Service(_scope, cimInstance);
                case "Win32_TerminalService":
                    return new Win32TerminalService(_scope, cimInstance);
                case "Win32_SystemDriver":
                    return new Win32SystemDriver(_scope, cimInstance);
                case "Win32_PnPSignedDriver":
                    return new Win32PnPSignedDriver(_scope, cimInstance);
                case "Win32_ApplicationService":
                    return new Win32ApplicationService(_scope, cimInstance);
                case "Win32_PrinterDriver":
                    return new Win32PrinterDriver(_scope, cimInstance);
                case "Win32_QuickFixEngineering":
                    return new Win32QuickFixEngineering(_scope, cimInstance);
                case "Win32_Thread":
                    return new Win32Thread(_scope, cimInstance);
                case "Win32_DCOMApplication":
                    return new Win32DCOMApplication(_scope, cimInstance);
                case "Win32_ScheduledJob":
                    return new Win32ScheduledJob(_scope, cimInstance);
                case "Win32_PrintJob":
                    return new Win32PrintJob(_scope, cimInstance);
                case "Win32_ServerSession":
                    return new Win32ServerSession(_scope, cimInstance);
                case "Win32_SoftwareFeature":
                    return new Win32SoftwareFeature(_scope, cimInstance);
                case "Win32_DfsNode":
                    return new Win32DfsNode(_scope, cimInstance);
                case "Win32_ComponentCategory":
                    return new Win32ComponentCategory(_scope, cimInstance);
                case "Win32_LogicalProgramGroupItem":
                    return new Win32LogicalProgramGroupItem(_scope, cimInstance);
                case "Win32_LogicalProgramGroup":
                    return new Win32LogicalProgramGroup(_scope, cimInstance);
                case "Win32_NetworkConnection":
                    return new Win32NetworkConnection(_scope, cimInstance);
                case "Win32_ClassicCOMClass":
                    return new Win32ClassicCOMClass(_scope, cimInstance);
                case "Win32_UserAccount":
                    return new Win32UserAccount(_scope, cimInstance);
                case "Win32_Group":
                    return new Win32Group(_scope, cimInstance);
                case "Win32_SystemAccount":
                    return new Win32SystemAccount(_scope, cimInstance);
                case "Win32_TCPIPPrinterPort":
                    return new Win32TCPIPPrinterPort(_scope, cimInstance);
                case "Win32_CommandLineAccess":
                    return new Win32CommandLineAccess(_scope, cimInstance);
                case "Win32_PortResource":
                    return new Win32PortResource(_scope, cimInstance);
                case "Win32_DeviceMemoryAddress":
                    return new Win32DeviceMemoryAddress(_scope, cimInstance);
                case "Win32_IRQResource":
                    return new Win32IRQResource(_scope, cimInstance);
                case "Win32_Environment":
                    return new Win32Environment(_scope, cimInstance);
                case "Win32_DMAChannel":
                    return new Win32DMAChannel(_scope, cimInstance);
                case "Win32_Share":
                    return new Win32Share(_scope, cimInstance);
                case "Win32_ClusterShare":
                    return new Win32ClusterShare(_scope, cimInstance);
                case "Win32_NetworkProtocol":
                    return new Win32NetworkProtocol(_scope, cimInstance);
                case "Win32_ShadowProvider":
                    return new Win32ShadowProvider(_scope, cimInstance);
                case "Win32_IP4RouteTable":
                    return new Win32IP4RouteTable(_scope, cimInstance);
                case "Win32_ShadowCopy":
                    return new Win32ShadowCopy(_scope, cimInstance);
                case "Win32_LoadOrderGroup":
                    return new Win32LoadOrderGroup(_scope, cimInstance);
                case "Win32_LogonSession":
                    return new Win32LogonSession(_scope, cimInstance);
                case "Win32_ServerConnection":
                    return new Win32ServerConnection(_scope, cimInstance);
                case "Win32_DfsTarget":
                    return new Win32DfsTarget(_scope, cimInstance);
                case "Win32_NetworkClient":
                    return new Win32NetworkClient(_scope, cimInstance);
                case "Win32_PageFileUsage":
                    return new Win32PageFileUsage(_scope, cimInstance);
                case "Win32_Directory":
                    return new Win32Directory(_scope, cimInstance);
                case "CIM_DataFile":
                    return new CIMDataFile(_scope, cimInstance);
                case "Win32_ShortcutFile":
                    return new Win32ShortcutFile(_scope, cimInstance);
                case "Win32_CodecFile":
                    return new Win32CodecFile(_scope, cimInstance);
                case "Win32_NTEventlogFile":
                    return new Win32NTEventlogFile(_scope, cimInstance);
                case "Win32_PageFile":
                    return new Win32PageFile(_scope, cimInstance);
                case "Win32_IP4PersistedRouteTable":
                    return new Win32IP4PersistedRouteTable(_scope, cimInstance);
                case "Win32_Registry":
                    return new Win32Registry(_scope, cimInstance);
                case "Win32_LogicalDiskRootDirectory":
                    return new Win32LogicalDiskRootDirectory(_scope, cimInstance);
                case "Win32_SystemDevices":
                    return new Win32SystemDevices(_scope, cimInstance);
                case "Win32_SystemPartitions":
                    return new Win32SystemPartitions(_scope, cimInstance);
                case "Win32_ComputerSystemProcessor":
                    return new Win32ComputerSystemProcessor(_scope, cimInstance);
                case "Win32_SystemServices":
                    return new Win32SystemServices(_scope, cimInstance);
                case "Win32_SystemNetworkConnections":
                    return new Win32SystemNetworkConnections(_scope, cimInstance);
                case "Win32_SystemResources":
                    return new Win32SystemResources(_scope, cimInstance);
                case "Win32_SystemBIOS":
                    return new Win32SystemBIOS(_scope, cimInstance);
                case "Win32_SystemLoadOrderGroups":
                    return new Win32SystemLoadOrderGroups(_scope, cimInstance);
                case "Win32_SystemUsers":
                    return new Win32SystemUsers(_scope, cimInstance);
                case "Win32_SystemOperatingSystem":
                    return new Win32SystemOperatingSystem(_scope, cimInstance);
                case "Win32_SystemSystemDriver":
                    return new Win32SystemSystemDriver(_scope, cimInstance);
                case "Win32_SystemProcesses":
                    return new Win32SystemProcesses(_scope, cimInstance);
                case "Win32_ClassicCOMApplicationClasses":
                    return new Win32ClassicCOMApplicationClasses(_scope, cimInstance);
                case "CIM_DirectoryContainsFile":
                    return new CIMDirectoryContainsFile(_scope, cimInstance);
                case "Win32_UserInDomain":
                    return new Win32UserInDomain(_scope, cimInstance);
                case "Win32_LoadOrderGroupServiceMembers":
                    return new Win32LoadOrderGroupServiceMembers(_scope, cimInstance);
                case "Win32_SoftwareFeatureSoftwareElements":
                    return new Win32SoftwareFeatureSoftwareElements(_scope, cimInstance);
                case "Win32_MemoryDeviceArray":
                    return new Win32MemoryDeviceArray(_scope, cimInstance);
                case "Win32_GroupInDomain":
                    return new Win32GroupInDomain(_scope, cimInstance);
                case "Win32_GroupUser":
                    return new Win32GroupUser(_scope, cimInstance);
                case "Win32_ProgramGroupContents":
                    return new Win32ProgramGroupContents(_scope, cimInstance);
                case "Win32_SubDirectory":
                    return new Win32SubDirectory(_scope, cimInstance);
                case "Win32_PhysicalMemoryLocation":
                    return new Win32PhysicalMemoryLocation(_scope, cimInstance);
                case "Win32_LogicalDiskToPartition":
                    return new Win32LogicalDiskToPartition(_scope, cimInstance);
                case "Win32_DiskDriveToDiskPartition":
                    return new Win32DiskDriveToDiskPartition(_scope, cimInstance);
                case "Win32_DeviceBus":
                    return new Win32DeviceBus(_scope, cimInstance);
                case "Win32_SCSIControllerDevice":
                    return new Win32SCSIControllerDevice(_scope, cimInstance);
                case "Win32_USBControllerDevice":
                    return new Win32USBControllerDevice(_scope, cimInstance);
                case "Win32_IDEControllerDevice":
                    return new Win32IDEControllerDevice(_scope, cimInstance);
                case "Win32_1394ControllerDevice":
                    return new Win321394ControllerDevice(_scope, cimInstance);
                case "Win32_POTSModemToSerialPort":
                    return new Win32POTSModemToSerialPort(_scope, cimInstance);
                case "Win32_PrinterController":
                    return new Win32PrinterController(_scope, cimInstance);
                case "CIM_USBControllerHasHub":
                    return new CIMUSBControllerHasHub(_scope, cimInstance);
                case "Win32_ControllerHasHub":
                    return new Win32ControllerHasHub(_scope, cimInstance);
                case "Win32_AssociatedProcessorMemory":
                    return new Win32AssociatedProcessorMemory(_scope, cimInstance);
                case "Win32_CIMLogicalDeviceCIMDataFile":
                    return new Win32CIMLogicalDeviceCIMDataFile(_scope, cimInstance);
                case "Win32_PNPAllocatedResource":
                    return new Win32PNPAllocatedResource(_scope, cimInstance);
                case "Win32_DiskDrivePhysicalMedia":
                    return new Win32DiskDrivePhysicalMedia(_scope, cimInstance);
                case "Win32_MemoryDeviceLocation":
                    return new Win32MemoryDeviceLocation(_scope, cimInstance);
                case "Win32_MemoryArrayLocation":
                    return new Win32MemoryArrayLocation(_scope, cimInstance);
                case "Win32_AllocatedResource":
                    return new Win32AllocatedResource(_scope, cimInstance);
                case "Win32_PrinterDriverDll":
                    return new Win32PrinterDriverDll(_scope, cimInstance);
                case "Win32_ApplicationCommandLine":
                    return new Win32ApplicationCommandLine(_scope, cimInstance);
                case "Win32_ShadowVolumeSupport":
                    return new Win32ShadowVolumeSupport(_scope, cimInstance);
                case "Win32_SessionConnection":
                    return new Win32SessionConnection(_scope, cimInstance);
                case "Win32_ShadowFor":
                    return new Win32ShadowFor(_scope, cimInstance);
                case "Win32_LogonSessionMappedDisk":
                    return new Win32LogonSessionMappedDisk(_scope, cimInstance);
                case "Win32_PrinterShare":
                    return new Win32PrinterShare(_scope, cimInstance);
                case "Win32_PnPSignedDriverCIMDataFile":
                    return new Win32PnPSignedDriverCIMDataFile(_scope, cimInstance);
                case "Win32_ConnectionShare":
                    return new Win32ConnectionShare(_scope, cimInstance);
                case "Win32_LoadOrderGroupServiceDependencies":
                    return new Win32LoadOrderGroupServiceDependencies(_scope, cimInstance);
                case "CIM_ProcessExecutable":
                    return new CIMProcessExecutable(_scope, cimInstance);
                case "Win32_SessionProcess":
                    return new Win32SessionProcess(_scope, cimInstance);
                case "Win32_SoftwareFeatureParent":
                    return new Win32SoftwareFeatureParent(_scope, cimInstance);
                case "Win32_ShadowOn":
                    return new Win32ShadowOn(_scope, cimInstance);
                case "Win32_DependentService":
                    return new Win32DependentService(_scope, cimInstance);
                case "Win32_OperatingSystemQFE":
                    return new Win32OperatingSystemQFE(_scope, cimInstance);
                case "Win32_LoggedOnUser":
                    return new Win32LoggedOnUser(_scope, cimInstance);
                case "Win32_SystemDriverPNPEntity":
                    return new Win32SystemDriverPNPEntity(_scope, cimInstance);
                case "Win32_DfsNodeTarget":
                    return new Win32DfsNodeTarget(_scope, cimInstance);
                case "Win32_DriverForDevice":
                    return new Win32DriverForDevice(_scope, cimInstance);
                case "Win32_LogicalProgramGroupItemDataFile":
                    return new Win32LogicalProgramGroupItemDataFile(_scope, cimInstance);
                case "Win32_ShadowBy":
                    return new Win32ShadowBy(_scope, cimInstance);
                case "Win32_LogicalProgramGroupDirectory":
                    return new Win32LogicalProgramGroupDirectory(_scope, cimInstance);
                case "Win32_ShadowDiffVolumeSupport":
                    return new Win32ShadowDiffVolumeSupport(_scope, cimInstance);
                case "Win32_DiskQuota":
                    return new Win32DiskQuota(_scope, cimInstance);
                case "Win32_VolumeQuotaSetting":
                    return new Win32VolumeQuotaSetting(_scope, cimInstance);
                case "Win32_PrinterSetting":
                    return new Win32PrinterSetting(_scope, cimInstance);
                case "Win32_NetworkAdapterSetting":
                    return new Win32NetworkAdapterSetting(_scope, cimInstance);
                case "Win32_SerialPortSetting":
                    return new Win32SerialPortSetting(_scope, cimInstance);
                case "Win32_SecuritySettingOfLogicalShare":
                    return new Win32SecuritySettingOfLogicalShare(_scope, cimInstance);
                case "Win32_SecuritySettingOfLogicalFile":
                    return new Win32SecuritySettingOfLogicalFile(_scope, cimInstance);
                case "Win32_UserDesktop":
                    return new Win32UserDesktop(_scope, cimInstance);
                case "Win32_SystemProgramGroups":
                    return new Win32SystemProgramGroups(_scope, cimInstance);
                case "Win32_SystemBootConfiguration":
                    return new Win32SystemBootConfiguration(_scope, cimInstance);
                case "Win32_SystemTimeZone":
                    return new Win32SystemTimeZone(_scope, cimInstance);
                case "Win32_SystemDesktop":
                    return new Win32SystemDesktop(_scope, cimInstance);
                case "Win32_ClassicCOMClassSettings":
                    return new Win32ClassicCOMClassSettings(_scope, cimInstance);
                case "Win32_VolumeQuota":
                    return new Win32VolumeQuota(_scope, cimInstance);
                case "Win32_WMIElementSetting":
                    return new Win32WMIElementSetting(_scope, cimInstance);
                case "Win32_COMApplicationSettings":
                    return new Win32COMApplicationSettings(_scope, cimInstance);
                case "Win32_VideoSettings":
                    return new Win32VideoSettings(_scope, cimInstance);
                case "Win32_PageFileElementSetting":
                    return new Win32PageFileElementSetting(_scope, cimInstance);
                case "Win32_OperatingSystemAutochkSetting":
                    return new Win32OperatingSystemAutochkSetting(_scope, cimInstance);
                case "Win32_PnPDevice":
                    return new Win32PnPDevice(_scope, cimInstance);
                case "Win32_ActiveRoute":
                    return new Win32ActiveRoute(_scope, cimInstance);
                case "Win32_NamedJobObjectProcess":
                    return new Win32NamedJobObjectProcess(_scope, cimInstance);
                case "Win32_NetworkAdapterConfiguration":
                    return new Win32NetworkAdapterConfiguration(_scope, cimInstance);
                case "Win32_TimeZone":
                    return new Win32TimeZone(_scope, cimInstance);
                case "Win32_PageFileSetting":
                    return new Win32PageFileSetting(_scope, cimInstance);
                case "Win32_Desktop":
                    return new Win32Desktop(_scope, cimInstance);
                case "Win32_ShadowContext":
                    return new Win32ShadowContext(_scope, cimInstance);
                case "Win32_ServiceControl":
                    return new Win32ServiceControl(_scope, cimInstance);
                case "Win32_Property":
                    return new Win32Property(_scope, cimInstance);
                case "Win32_Patch":
                    return new Win32Patch(_scope, cimInstance);
                case "Win32_PatchPackage":
                    return new Win32PatchPackage(_scope, cimInstance);
                case "Win32_Binary":
                    return new Win32Binary(_scope, cimInstance);
                case "Win32_AutochkSetting":
                    return new Win32AutochkSetting(_scope, cimInstance);
                case "Win32_SerialPortConfiguration":
                    return new Win32SerialPortConfiguration(_scope, cimInstance);
                case "Win32_StartupCommand":
                    return new Win32StartupCommand(_scope, cimInstance);
                case "Win32_BootConfiguration":
                    return new Win32BootConfiguration(_scope, cimInstance);
                case "Win32_NetworkLoginProfile":
                    return new Win32NetworkLoginProfile(_scope, cimInstance);
                case "Win32_NamedJobObjectLimitSetting":
                    return new Win32NamedJobObjectLimitSetting(_scope, cimInstance);
                case "CIM_VideoControllerResolution":
                    return new CIMVideoControllerResolution(_scope, cimInstance);
                case "Win32_NamedJobObjectSecLimitSetting":
                    return new Win32NamedJobObjectSecLimitSetting(_scope, cimInstance);
                case "Win32_DisplayConfiguration":
                    return new Win32DisplayConfiguration(_scope, cimInstance);
                case "Win32_QuotaSetting":
                    return new Win32QuotaSetting(_scope, cimInstance);
                case "Win32_LogicalFileSecuritySetting":
                    return new Win32LogicalFileSecuritySetting(_scope, cimInstance);
                case "Win32_LogicalShareSecuritySetting":
                    return new Win32LogicalShareSecuritySetting(_scope, cimInstance);
                case "Win32_DisplayControllerConfiguration":
                    return new Win32DisplayControllerConfiguration(_scope, cimInstance);
                case "Win32_WMISetting":
                    return new Win32WMISetting(_scope, cimInstance);
                case "Win32_OSRecoveryConfiguration":
                    return new Win32OSRecoveryConfiguration(_scope, cimInstance);
                case "Win32_ClassicCOMClassSetting":
                    return new Win32ClassicCOMClassSetting(_scope, cimInstance);
                case "Win32_DCOMApplicationSetting":
                    return new Win32DCOMApplicationSetting(_scope, cimInstance);
                case "Win32_VideoConfiguration":
                    return new Win32VideoConfiguration(_scope, cimInstance);
                case "Win32_ODBCAttribute":
                    return new Win32ODBCAttribute(_scope, cimInstance);
                case "Win32_ODBCSourceAttribute":
                    return new Win32ODBCSourceAttribute(_scope, cimInstance);
                case "ScriptingStandardConsumerSetting":
                    return new ScriptingStandardConsumerSetting(_scope, cimInstance);
                case "Win32_PrinterConfiguration":
                    return new Win32PrinterConfiguration(_scope, cimInstance);
                case "Win32_NamedJobObjectActgInfo":
                    return new Win32NamedJobObjectActgInfo(_scope, cimInstance);
                case "Win32_NTLogEvent":
                    return new Win32NTLogEvent(_scope, cimInstance);
                case "Win32_UserProfile":
                    return new Win32UserProfile(_scope, cimInstance);
                case "Win32_FolderRedirectionHealth":
                    return new Win32FolderRedirectionHealth(_scope, cimInstance);
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
                case "__ExtendedStatus":
                    return new ExtendedStatus(_scope, cimInstance);
                case "Win32_PrivilegesStatus":
                    return new Win32PrivilegesStatus(_scope, cimInstance);
                case "Win32_JobObjectStatus":
                    return new Win32JobObjectStatus(_scope, cimInstance);
                case "CIM_Error":
                    return new CIMError(_scope, cimInstance);
                case "MSFT_WmiError":
                    return new MSFTWmiError(_scope, cimInstance);
                case "MSFT_ExtendedStatus":
                    return new MSFTExtendedStatus(_scope, cimInstance);
                case "__NTLMUser9X":
                    return new NTLMUser9X(_scope, cimInstance);
                case "Win32_NamedJobObjectStatistics":
                    return new Win32NamedJobObjectStatistics(_scope, cimInstance);
                case "Win32_OfflineFilesUserConfiguration":
                    return new Win32OfflineFilesUserConfiguration(_scope, cimInstance);
                case "Win32_AccountSID":
                    return new Win32AccountSID(_scope, cimInstance);
                case "Win32_WinSAT":
                    return new Win32WinSAT(_scope, cimInstance);
                case "Win32_SecurityDescriptorHelper":
                    return new Win32SecurityDescriptorHelper(_scope, cimInstance);
                case "Win32_UTCTime":
                    return new Win32UTCTime(_scope, cimInstance);
                case "Win32_LocalTime":
                    return new Win32LocalTime(_scope, cimInstance);
                case "Win32_ShortcutAction":
                    return new Win32ShortcutAction(_scope, cimInstance);
                case "Win32_ExtensionInfoAction":
                    return new Win32ExtensionInfoAction(_scope, cimInstance);
                case "Win32_CreateFolderAction":
                    return new Win32CreateFolderAction(_scope, cimInstance);
                case "Win32_RegistryAction":
                    return new Win32RegistryAction(_scope, cimInstance);
                case "Win32_ClassInfoAction":
                    return new Win32ClassInfoAction(_scope, cimInstance);
                case "Win32_SelfRegModuleAction":
                    return new Win32SelfRegModuleAction(_scope, cimInstance);
                case "Win32_TypeLibraryAction":
                    return new Win32TypeLibraryAction(_scope, cimInstance);
                case "Win32_BindImageAction":
                    return new Win32BindImageAction(_scope, cimInstance);
                case "Win32_RemoveIniAction":
                    return new Win32RemoveIniAction(_scope, cimInstance);
                case "Win32_MIMEInfoAction":
                    return new Win32MIMEInfoAction(_scope, cimInstance);
                case "Win32_FontInfoAction":
                    return new Win32FontInfoAction(_scope, cimInstance);
                case "Win32_PublishComponentAction":
                    return new Win32PublishComponentAction(_scope, cimInstance);
                case "Win32_MoveFileAction":
                    return new Win32MoveFileAction(_scope, cimInstance);
                case "Win32_DuplicateFileAction":
                    return new Win32DuplicateFileAction(_scope, cimInstance);
                case "Win32_RemoveFileAction":
                    return new Win32RemoveFileAction(_scope, cimInstance);
                case "Win32_ProductResource":
                    return new Win32ProductResource(_scope, cimInstance);
                case "Win32_MountPoint":
                    return new Win32MountPoint(_scope, cimInstance);
                case "Win32_OfflineFilesAssociatedItems":
                    return new Win32OfflineFilesAssociatedItems(_scope, cimInstance);
                case "Msft_Providers":
                    return new MsftProviders(_scope, cimInstance);
                case "Win32_OfflineFilesChangeInfo":
                    return new Win32OfflineFilesChangeInfo(_scope, cimInstance);
                case "Win32_RoamingProfileMachineConfiguration":
                    return new Win32RoamingProfileMachineConfiguration(_scope, cimInstance);
                case "Win32_SoftwareElementResource":
                    return new Win32SoftwareElementResource(_scope, cimInstance);
                case "Win32_SID":
                    return new Win32SID(_scope, cimInstance);
                case "Win32_ActionCheck":
                    return new Win32ActionCheck(_scope, cimInstance);
                case "Win32_ProductSoftwareFeatures":
                    return new Win32ProductSoftwareFeatures(_scope, cimInstance);
                case "Win32_ImplementedCategory":
                    return new Win32ImplementedCategory(_scope, cimInstance);
                case "Win32_RoamingProfileUserConfiguration":
                    return new Win32RoamingProfileUserConfiguration(_scope, cimInstance);
                case "Win32_InstalledSoftwareElement":
                    return new Win32InstalledSoftwareElement(_scope, cimInstance);
                case "Win32_SoftwareFeatureCheck":
                    return new Win32SoftwareFeatureCheck(_scope, cimInstance);
                case "Win32_VolumeUserQuota":
                    return new Win32VolumeUserQuota(_scope, cimInstance);
                case "Msft_WmiProvider_Counters":
                    return new MsftWmiProviderCounters(_scope, cimInstance);
                case "Win32_DirectorySpecification":
                    return new Win32DirectorySpecification(_scope, cimInstance);
                case "Win32_SoftwareElementCondition":
                    return new Win32SoftwareElementCondition(_scope, cimInstance);
                case "Win32_ODBCDriverSpecification":
                    return new Win32ODBCDriverSpecification(_scope, cimInstance);
                case "Win32_ServiceSpecification":
                    return new Win32ServiceSpecification(_scope, cimInstance);
                case "Win32_FileSpecification":
                    return new Win32FileSpecification(_scope, cimInstance);
                case "Win32_IniFileSpecification":
                    return new Win32IniFileSpecification(_scope, cimInstance);
                case "Win32_LaunchCondition":
                    return new Win32LaunchCondition(_scope, cimInstance);
                case "Win32_ODBCDataSourceSpecification":
                    return new Win32ODBCDataSourceSpecification(_scope, cimInstance);
                case "Win32_ODBCTranslatorSpecification":
                    return new Win32ODBCTranslatorSpecification(_scope, cimInstance);
                case "Win32_ProgIDSpecification":
                    return new Win32ProgIDSpecification(_scope, cimInstance);
                case "Win32_EnvironmentSpecification":
                    return new Win32EnvironmentSpecification(_scope, cimInstance);
                case "Win32_ReserveCost":
                    return new Win32ReserveCost(_scope, cimInstance);
                case "Win32_Condition":
                    return new Win32Condition(_scope, cimInstance);
                case "Win32_ShadowStorage":
                    return new Win32ShadowStorage(_scope, cimInstance);
                case "Win32_DCOMApplicationAccessAllowedSetting":
                    return new Win32DCOMApplicationAccessAllowedSetting(_scope, cimInstance);
                case "StdRegProv":
                    return new StdRegProv(_scope, cimInstance);
                case "Win32_FolderRedirection":
                    return new Win32FolderRedirection(_scope, cimInstance);
                case "Win32_NamedJobObject":
                    return new Win32NamedJobObject(_scope, cimInstance);
                case "Win32_ServiceSpecificationService":
                    return new Win32ServiceSpecificationService(_scope, cimInstance);
                case "Win32_OfflineFilesItem":
                    return new Win32OfflineFilesItem(_scope, cimInstance);
                case "Win32_OfflineFilesBackgroundSync":
                    return new Win32OfflineFilesBackgroundSync(_scope, cimInstance);
                case "Win32_InstalledWin32Program":
                    return new Win32InstalledWin32Program(_scope, cimInstance);
                case "Win32_ShareToDirectory":
                    return new Win32ShareToDirectory(_scope, cimInstance);
                case "Win32_PatchFile":
                    return new Win32PatchFile(_scope, cimInstance);
                case "Win32_ODBCDriverAttribute":
                    return new Win32ODBCDriverAttribute(_scope, cimInstance);
                case "Win32_ODBCDataSourceAttribute":
                    return new Win32ODBCDataSourceAttribute(_scope, cimInstance);
                case "Win32_ClientApplicationSetting":
                    return new Win32ClientApplicationSetting(_scope, cimInstance);
                case "Win32_RoamingUserHealthConfiguration":
                    return new Win32RoamingUserHealthConfiguration(_scope, cimInstance);
                case "Win32_UserStateConfigurationControls":
                    return new Win32UserStateConfigurationControls(_scope, cimInstance);
                case "Win32_OfflineFilesPinInfo":
                    return new Win32OfflineFilesPinInfo(_scope, cimInstance);
                case "Win32_LogicalFileOwner":
                    return new Win32LogicalFileOwner(_scope, cimInstance);
                case "Win32_OfflineFilesFileSysInfo":
                    return new Win32OfflineFilesFileSysInfo(_scope, cimInstance);
                case "NTEventlogProviderConfig":
                    return new NTEventlogProviderConfig(_scope, cimInstance);
                case "Win32_ShortcutSAP":
                    return new Win32ShortcutSAP(_scope, cimInstance);
                case "Win32_OfflineFilesSuspendInfo":
                    return new Win32OfflineFilesSuspendInfo(_scope, cimInstance);
                case "Win32_PingStatus":
                    return new Win32PingStatus(_scope, cimInstance);
                case "Win32_SoftwareElementCheck":
                    return new Win32SoftwareElementCheck(_scope, cimInstance);
                case "Win32_ODBCDriverSoftwareElement":
                    return new Win32ODBCDriverSoftwareElement(_scope, cimInstance);
                case "Win32_FolderRedirectionUserConfiguration":
                    return new Win32FolderRedirectionUserConfiguration(_scope, cimInstance);
                case "Win32_ReliabilityStabilityMetrics":
                    return new Win32ReliabilityStabilityMetrics(_scope, cimInstance);
                case "Win32_ReliabilityRecords":
                    return new Win32ReliabilityRecords(_scope, cimInstance);
                case "Win32_InstalledProgramFramework":
                    return new Win32InstalledProgramFramework(_scope, cimInstance);
                case "Win32_NTLogEventLog":
                    return new Win32NTLogEventLog(_scope, cimInstance);
                case "Win32_ComClassAutoEmulator":
                    return new Win32ComClassAutoEmulator(_scope, cimInstance);
                case "Win32_FolderRedirectionHealthConfiguration":
                    return new Win32FolderRedirectionHealthConfiguration(_scope, cimInstance);
                case "Win32_ComClassEmulator":
                    return new Win32ComClassEmulator(_scope, cimInstance);
                case "Win32_SoftwareFeatureAction":
                    return new Win32SoftwareFeatureAction(_scope, cimInstance);
                case "Win32_OfflineFilesMachineConfiguration":
                    return new Win32OfflineFilesMachineConfiguration(_scope, cimInstance);
                case "Win32_LogicalFileGroup":
                    return new Win32LogicalFileGroup(_scope, cimInstance);
                case "Win32_DCOMApplicationLaunchAllowedSetting":
                    return new Win32DCOMApplicationLaunchAllowedSetting(_scope, cimInstance);
                case "Win32_LogicalFileAuditing":
                    return new Win32LogicalFileAuditing(_scope, cimInstance);
                case "Win32_LogicalShareAuditing":
                    return new Win32LogicalShareAuditing(_scope, cimInstance);
                case "SoftwareLicensingProduct":
                    return new SoftwareLicensingProduct(_scope, cimInstance);
                case "Win32_PnPDevicePropertyString":
                    return new Win32PnPDevicePropertyString(_scope, cimInstance);
                case "Win32_PnPDevicePropertyReal32Array":
                    return new Win32PnPDevicePropertyReal32Array(_scope, cimInstance);
                case "Win32_PnPDevicePropertyReal64":
                    return new Win32PnPDevicePropertyReal64(_scope, cimInstance);
                case "Win32_PnPDevicePropertyUint16":
                    return new Win32PnPDevicePropertyUint16(_scope, cimInstance);
                case "Win32_PnPDevicePropertySint16Array":
                    return new Win32PnPDevicePropertySint16Array(_scope, cimInstance);
                case "Win32_PnPDevicePropertySint64":
                    return new Win32PnPDevicePropertySint64(_scope, cimInstance);
                case "Win32_PnPDevicePropertyUint8":
                    return new Win32PnPDevicePropertyUint8(_scope, cimInstance);
                case "Win32_PnPDevicePropertySint8":
                    return new Win32PnPDevicePropertySint8(_scope, cimInstance);
                case "Win32_PnPDevicePropertySecurityDescriptor":
                    return new Win32PnPDevicePropertySecurityDescriptor(_scope, cimInstance);
                case "Win32_PnPDevicePropertyReal32":
                    return new Win32PnPDevicePropertyReal32(_scope, cimInstance);
                case "Win32_PnPDevicePropertySint32":
                    return new Win32PnPDevicePropertySint32(_scope, cimInstance);
                case "Win32_PnPDevicePropertyStringArray":
                    return new Win32PnPDevicePropertyStringArray(_scope, cimInstance);
                case "Win32_PnPDevicePropertyUint32":
                    return new Win32PnPDevicePropertyUint32(_scope, cimInstance);
                case "Win32_PnPDevicePropertyUint64":
                    return new Win32PnPDevicePropertyUint64(_scope, cimInstance);
                case "Win32_PnPDevicePropertyBoolean":
                    return new Win32PnPDevicePropertyBoolean(_scope, cimInstance);
                case "Win32_PnPDevicePropertyUint16Array":
                    return new Win32PnPDevicePropertyUint16Array(_scope, cimInstance);
                case "Win32_PnPDevicePropertyBinary":
                    return new Win32PnPDevicePropertyBinary(_scope, cimInstance);
                case "Win32_PnPDevicePropertySint32Array":
                    return new Win32PnPDevicePropertySint32Array(_scope, cimInstance);
                case "Win32_PnPDevicePropertySint16":
                    return new Win32PnPDevicePropertySint16(_scope, cimInstance);
                case "Win32_PnPDevicePropertyReal64Array":
                    return new Win32PnPDevicePropertyReal64Array(_scope, cimInstance);
                case "Win32_PnPDevicePropertyBooleanArray":
                    return new Win32PnPDevicePropertyBooleanArray(_scope, cimInstance);
                case "Win32_PnPDevicePropertyUint32Array":
                    return new Win32PnPDevicePropertyUint32Array(_scope, cimInstance);
                case "Win32_PnPDevicePropertyDateTime":
                    return new Win32PnPDevicePropertyDateTime(_scope, cimInstance);
                case "Win32_PnPDevicePropertySecurityDescriptorArray":
                    return new Win32PnPDevicePropertySecurityDescriptorArray(_scope, cimInstance);
                case "Win32_PnPDevicePropertySint8Array":
                    return new Win32PnPDevicePropertySint8Array(_scope, cimInstance);
                case "Win32_OfflineFilesCache":
                    return new Win32OfflineFilesCache(_scope, cimInstance);
                case "Win32_SoftwareElementAction":
                    return new Win32SoftwareElementAction(_scope, cimInstance);
                case "Win32_Product":
                    return new Win32Product(_scope, cimInstance);
                case "Win32_ComputerSystemProduct":
                    return new Win32ComputerSystemProduct(_scope, cimInstance);
                case "Win32_ProductCheck":
                    return new Win32ProductCheck(_scope, cimInstance);
                case "SoftwareLicensingService":
                    return new SoftwareLicensingService(_scope, cimInstance);
                case "Win32_NTLogEventUser":
                    return new Win32NTLogEventUser(_scope, cimInstance);
                case "Win32_ProtocolBinding":
                    return new Win32ProtocolBinding(_scope, cimInstance);
                case "Win32_NamedJobObjectLimit":
                    return new Win32NamedJobObjectLimit(_scope, cimInstance);
                case "Win32_NamedJobObjectSecLimit":
                    return new Win32NamedJobObjectSecLimit(_scope, cimInstance);
                case "Win32_OfflineFilesConnectionInfo":
                    return new Win32OfflineFilesConnectionInfo(_scope, cimInstance);
                case "Win32_InstalledStoreProgram":
                    return new Win32InstalledStoreProgram(_scope, cimInstance);
                case "Win32_NTLogEventComputer":
                    return new Win32NTLogEventComputer(_scope, cimInstance);
                case "SoftwareLicensingTokenActivationLicense":
                    return new SoftwareLicensingTokenActivationLicense(_scope, cimInstance);
                case "Win32_DefragAnalysis":
                    return new Win32DefragAnalysis(_scope, cimInstance);
                case "Win32_CheckCheck":
                    return new Win32CheckCheck(_scope, cimInstance);
                case "Win32_RoamingProfileBackgroundUploadParams":
                    return new Win32RoamingProfileBackgroundUploadParams(_scope, cimInstance);
                case "Win32_RoamingProfileSlowLinkParams":
                    return new Win32RoamingProfileSlowLinkParams(_scope, cimInstance);
                case "Win32_OfflineFilesDiskSpaceLimit":
                    return new Win32OfflineFilesDiskSpaceLimit(_scope, cimInstance);
                case "Win32_LogicalFileAccess":
                    return new Win32LogicalFileAccess(_scope, cimInstance);
                case "Win32_LogicalShareAccess":
                    return new Win32LogicalShareAccess(_scope, cimInstance);
                case "Win32_OfflineFilesDirtyInfo":
                    return new Win32OfflineFilesDirtyInfo(_scope, cimInstance);
                case "Win32_OfflineFilesHealth":
                    return new Win32OfflineFilesHealth(_scope, cimInstance);
                case "Win32_PerfFormattedData_AFDCounters_MicrosoftWinsockBSP":
                    return new Win32PerfFormattedDataAFDCountersMicrosoftWinsockBSP(_scope, cimInstance);
                case "Win32_PerfRawData_AFDCounters_MicrosoftWinsockBSP":
                    return new Win32PerfRawDataAFDCountersMicrosoftWinsockBSP(_scope, cimInstance);
                case "Win32_PerfFormattedData_ASPNET4030319_ASPNETAppsv4030319":
                    return new Win32PerfFormattedDataASPNET4030319ASPNETAppsv4030319(_scope, cimInstance);
                case "Win32_PerfRawData_ASPNET4030319_ASPNETAppsv4030319":
                    return new Win32PerfRawDataASPNET4030319ASPNETAppsv4030319(_scope, cimInstance);
                case "Win32_PerfFormattedData_ASPNET4030319_ASPNETv4030319":
                    return new Win32PerfFormattedDataASPNET4030319ASPNETv4030319(_scope, cimInstance);
                case "Win32_PerfRawData_ASPNET4030319_ASPNETv4030319":
                    return new Win32PerfRawDataASPNET4030319ASPNETv4030319(_scope, cimInstance);
                case "Win32_PerfFormattedData_ASPNET_ASPNET":
                    return new Win32PerfFormattedDataASPNETASPNET(_scope, cimInstance);
                case "Win32_PerfRawData_ASPNET_ASPNET":
                    return new Win32PerfRawDataASPNETASPNET(_scope, cimInstance);
                case "Win32_PerfFormattedData_ASPNET_ASPNETApplications":
                    return new Win32PerfFormattedDataASPNETASPNETApplications(_scope, cimInstance);
                case "Win32_PerfRawData_ASPNET_ASPNETApplications":
                    return new Win32PerfRawDataASPNETASPNETApplications(_scope, cimInstance);
                case "Win32_PerfFormattedData_aspnetstate_ASPNETStateService":
                    return new Win32PerfFormattedDataAspnetstateASPNETStateService(_scope, cimInstance);
                case "Win32_PerfRawData_aspnetstate_ASPNETStateService":
                    return new Win32PerfRawDataAspnetstateASPNETStateService(_scope, cimInstance);
                case "Win32_PerfFormattedData_AuthorizationManager_AuthorizationManagerApplications":
                    return new Win32PerfFormattedDataAuthorizationManagerAuthorizationManagerApplications(_scope, cimInstance);
                case "Win32_PerfRawData_AuthorizationManager_AuthorizationManagerApplications":
                    return new Win32PerfRawDataAuthorizationManagerAuthorizationManagerApplications(_scope, cimInstance);
                case "Win32_PerfFormattedData_BalancerStats_HyperVDynamicMemoryBalancer":
                    return new Win32PerfFormattedDataBalancerStatsHyperVDynamicMemoryBalancer(_scope, cimInstance);
                case "Win32_PerfRawData_BalancerStats_HyperVDynamicMemoryBalancer":
                    return new Win32PerfRawDataBalancerStatsHyperVDynamicMemoryBalancer(_scope, cimInstance);
                case "Win32_PerfFormattedData_BalancerStats_HyperVDynamicMemoryVM":
                    return new Win32PerfFormattedDataBalancerStatsHyperVDynamicMemoryVM(_scope, cimInstance);
                case "Win32_PerfRawData_BalancerStats_HyperVDynamicMemoryVM":
                    return new Win32PerfRawDataBalancerStatsHyperVDynamicMemoryVM(_scope, cimInstance);
                case "Win32_PerfFormattedData_BITS_BITSNetUtilization":
                    return new Win32PerfFormattedDataBITSBITSNetUtilization(_scope, cimInstance);
                case "Win32_PerfRawData_BITS_BITSNetUtilization":
                    return new Win32PerfRawDataBITSBITSNetUtilization(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_AppVClientStreamedDataPercentage":
                    return new Win32PerfFormattedDataCountersAppVClientStreamedDataPercentage(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_AppVClientStreamedDataPercentage":
                    return new Win32PerfRawDataCountersAppVClientStreamedDataPercentage(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_BluetoothDevice":
                    return new Win32PerfFormattedDataCountersBluetoothDevice(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_BluetoothDevice":
                    return new Win32PerfRawDataCountersBluetoothDevice(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_BluetoothRadio":
                    return new Win32PerfFormattedDataCountersBluetoothRadio(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_BluetoothRadio":
                    return new Win32PerfRawDataCountersBluetoothRadio(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_DNS64Global":
                    return new Win32PerfFormattedDataCountersDNS64Global(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_DNS64Global":
                    return new Win32PerfRawDataCountersDNS64Global(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_EventLog":
                    return new Win32PerfFormattedDataCountersEventLog(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_EventLog":
                    return new Win32PerfRawDataCountersEventLog(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_EventTracingforWindows":
                    return new Win32PerfFormattedDataCountersEventTracingforWindows(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_EventTracingforWindows":
                    return new Win32PerfRawDataCountersEventTracingforWindows(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_EventTracingforWindowsSession":
                    return new Win32PerfFormattedDataCountersEventTracingforWindowsSession(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_EventTracingforWindowsSession":
                    return new Win32PerfRawDataCountersEventTracingforWindowsSession(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_FileSystemDiskActivity":
                    return new Win32PerfFormattedDataCountersFileSystemDiskActivity(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_FileSystemDiskActivity":
                    return new Win32PerfRawDataCountersFileSystemDiskActivity(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_GenericIKEv1AuthIPandIKEv2":
                    return new Win32PerfFormattedDataCountersGenericIKEv1AuthIPandIKEv2(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_GenericIKEv1AuthIPandIKEv2":
                    return new Win32PerfRawDataCountersGenericIKEv1AuthIPandIKEv2(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_HTTPService":
                    return new Win32PerfFormattedDataCountersHTTPService(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_HTTPService":
                    return new Win32PerfRawDataCountersHTTPService(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_HTTPServiceRequestQueues":
                    return new Win32PerfFormattedDataCountersHTTPServiceRequestQueues(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_HTTPServiceRequestQueues":
                    return new Win32PerfRawDataCountersHTTPServiceRequestQueues(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_HTTPServiceUrlGroups":
                    return new Win32PerfFormattedDataCountersHTTPServiceUrlGroups(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_HTTPServiceUrlGroups":
                    return new Win32PerfRawDataCountersHTTPServiceUrlGroups(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_HyperVDynamicMemoryIntegrationService":
                    return new Win32PerfFormattedDataCountersHyperVDynamicMemoryIntegrationService(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_HyperVDynamicMemoryIntegrationService":
                    return new Win32PerfRawDataCountersHyperVDynamicMemoryIntegrationService(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_HyperVVirtualMachineBus":
                    return new Win32PerfFormattedDataCountersHyperVVirtualMachineBus(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_HyperVVirtualMachineBus":
                    return new Win32PerfRawDataCountersHyperVVirtualMachineBus(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_HyperVVirtualMachineBusPipes":
                    return new Win32PerfFormattedDataCountersHyperVVirtualMachineBusPipes(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_HyperVVirtualMachineBusPipes":
                    return new Win32PerfRawDataCountersHyperVVirtualMachineBusPipes(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_HyperVVirtualMachineBusProviderPipes":
                    return new Win32PerfFormattedDataCountersHyperVVirtualMachineBusProviderPipes(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_HyperVVirtualMachineBusProviderPipes":
                    return new Win32PerfRawDataCountersHyperVVirtualMachineBusProviderPipes(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_HyperVVirtualStorageDevice":
                    return new Win32PerfFormattedDataCountersHyperVVirtualStorageDevice(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_HyperVVirtualStorageDevice":
                    return new Win32PerfRawDataCountersHyperVVirtualStorageDevice(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPHTTPSGlobal":
                    return new Win32PerfFormattedDataCountersIPHTTPSGlobal(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPHTTPSGlobal":
                    return new Win32PerfRawDataCountersIPHTTPSGlobal(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPHTTPSSession":
                    return new Win32PerfFormattedDataCountersIPHTTPSSession(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPHTTPSSession":
                    return new Win32PerfRawDataCountersIPHTTPSSession(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPsecAuthIPIPv4":
                    return new Win32PerfFormattedDataCountersIPsecAuthIPIPv4(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPsecAuthIPIPv4":
                    return new Win32PerfRawDataCountersIPsecAuthIPIPv4(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPsecAuthIPIPv6":
                    return new Win32PerfFormattedDataCountersIPsecAuthIPIPv6(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPsecAuthIPIPv6":
                    return new Win32PerfRawDataCountersIPsecAuthIPIPv6(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPsecConnections":
                    return new Win32PerfFormattedDataCountersIPsecConnections(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPsecConnections":
                    return new Win32PerfRawDataCountersIPsecConnections(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPsecDriver":
                    return new Win32PerfFormattedDataCountersIPsecDriver(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPsecDriver":
                    return new Win32PerfRawDataCountersIPsecDriver(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPsecIKEv1IPv4":
                    return new Win32PerfFormattedDataCountersIPsecIKEv1IPv4(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPsecIKEv1IPv4":
                    return new Win32PerfRawDataCountersIPsecIKEv1IPv4(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPsecIKEv1IPv6":
                    return new Win32PerfFormattedDataCountersIPsecIKEv1IPv6(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPsecIKEv1IPv6":
                    return new Win32PerfRawDataCountersIPsecIKEv1IPv6(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPsecIKEv2IPv4":
                    return new Win32PerfFormattedDataCountersIPsecIKEv2IPv4(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPsecIKEv2IPv4":
                    return new Win32PerfRawDataCountersIPsecIKEv2IPv4(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPsecIKEv2IPv6":
                    return new Win32PerfFormattedDataCountersIPsecIKEv2IPv6(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPsecIKEv2IPv6":
                    return new Win32PerfRawDataCountersIPsecIKEv2IPv6(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_Netlogon":
                    return new Win32PerfFormattedDataCountersNetlogon(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_Netlogon":
                    return new Win32PerfRawDataCountersNetlogon(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_NetworkQoSPolicy":
                    return new Win32PerfFormattedDataCountersNetworkQoSPolicy(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_NetworkQoSPolicy":
                    return new Win32PerfRawDataCountersNetworkQoSPolicy(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_Nodejs":
                    return new Win32PerfFormattedDataCountersNodejs(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_Nodejs":
                    return new Win32PerfRawDataCountersNodejs(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PacerFlow":
                    return new Win32PerfFormattedDataCountersPacerFlow(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_PacerFlow":
                    return new Win32PerfRawDataCountersPacerFlow(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PacerPipe":
                    return new Win32PerfFormattedDataCountersPacerPipe(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_PacerPipe":
                    return new Win32PerfRawDataCountersPacerPipe(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PacketDirectECUtilization":
                    return new Win32PerfFormattedDataCountersPacketDirectECUtilization(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_PacketDirectECUtilization":
                    return new Win32PerfRawDataCountersPacketDirectECUtilization(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PacketDirectQueueDepth":
                    return new Win32PerfFormattedDataCountersPacketDirectQueueDepth(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_PacketDirectQueueDepth":
                    return new Win32PerfRawDataCountersPacketDirectQueueDepth(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PacketDirectReceiveCounters":
                    return new Win32PerfFormattedDataCountersPacketDirectReceiveCounters(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_PacketDirectReceiveCounters":
                    return new Win32PerfRawDataCountersPacketDirectReceiveCounters(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PacketDirectReceiveFilters":
                    return new Win32PerfFormattedDataCountersPacketDirectReceiveFilters(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_PacketDirectReceiveFilters":
                    return new Win32PerfRawDataCountersPacketDirectReceiveFilters(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PacketDirectTransmitCounters":
                    return new Win32PerfFormattedDataCountersPacketDirectTransmitCounters(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_PacketDirectTransmitCounters":
                    return new Win32PerfRawDataCountersPacketDirectTransmitCounters(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PerProcessorNetworkActivityCycles":
                    return new Win32PerfFormattedDataCountersPerProcessorNetworkActivityCycles(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_PerProcessorNetworkActivityCycles":
                    return new Win32PerfRawDataCountersPerProcessorNetworkActivityCycles(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PerProcessorNetworkInterfaceCardActivity":
                    return new Win32PerfFormattedDataCountersPerProcessorNetworkInterfaceCardActivity(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_PerProcessorNetworkInterfaceCardActivity":
                    return new Win32PerfRawDataCountersPerProcessorNetworkInterfaceCardActivity(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PhysicalNetworkInterfaceCardActivity":
                    return new Win32PerfFormattedDataCountersPhysicalNetworkInterfaceCardActivity(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_PhysicalNetworkInterfaceCardActivity":
                    return new Win32PerfRawDataCountersPhysicalNetworkInterfaceCardActivity(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PowerShellWorkflow":
                    return new Win32PerfFormattedDataCountersPowerShellWorkflow(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_PowerShellWorkflow":
                    return new Win32PerfRawDataCountersPowerShellWorkflow(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_ProcessorInformation":
                    return new Win32PerfFormattedDataCountersProcessorInformation(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_ProcessorInformation":
                    return new Win32PerfRawDataCountersProcessorInformation(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_RDMAActivity":
                    return new Win32PerfFormattedDataCountersRDMAActivity(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_RDMAActivity":
                    return new Win32PerfRawDataCountersRDMAActivity(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_ReFS":
                    return new Win32PerfFormattedDataCountersReFS(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_ReFS":
                    return new Win32PerfRawDataCountersReFS(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_RemoteFXGraphics":
                    return new Win32PerfFormattedDataCountersRemoteFXGraphics(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_RemoteFXGraphics":
                    return new Win32PerfRawDataCountersRemoteFXGraphics(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_RemoteFXNetwork":
                    return new Win32PerfFormattedDataCountersRemoteFXNetwork(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_RemoteFXNetwork":
                    return new Win32PerfRawDataCountersRemoteFXNetwork(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_SMBClientShares":
                    return new Win32PerfFormattedDataCountersSMBClientShares(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_SMBClientShares":
                    return new Win32PerfRawDataCountersSMBClientShares(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_SMBDirectConnection":
                    return new Win32PerfFormattedDataCountersSMBDirectConnection(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_SMBDirectConnection":
                    return new Win32PerfRawDataCountersSMBDirectConnection(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_SMBServer":
                    return new Win32PerfFormattedDataCountersSMBServer(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_SMBServer":
                    return new Win32PerfRawDataCountersSMBServer(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_SMBServerSessions":
                    return new Win32PerfFormattedDataCountersSMBServerSessions(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_SMBServerSessions":
                    return new Win32PerfRawDataCountersSMBServerSessions(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_SMBServerShares":
                    return new Win32PerfFormattedDataCountersSMBServerShares(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_SMBServerShares":
                    return new Win32PerfRawDataCountersSMBServerShares(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_StorageQoSFilterFlow":
                    return new Win32PerfFormattedDataCountersStorageQoSFilterFlow(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_StorageQoSFilterFlow":
                    return new Win32PerfRawDataCountersStorageQoSFilterFlow(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_StorageQoSFilterVolume":
                    return new Win32PerfFormattedDataCountersStorageQoSFilterVolume(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_StorageQoSFilterVolume":
                    return new Win32PerfRawDataCountersStorageQoSFilterVolume(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_StorageSpacesDrt":
                    return new Win32PerfFormattedDataCountersStorageSpacesDrt(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_StorageSpacesDrt":
                    return new Win32PerfRawDataCountersStorageSpacesDrt(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_StorageSpacesTier":
                    return new Win32PerfFormattedDataCountersStorageSpacesTier(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_StorageSpacesTier":
                    return new Win32PerfRawDataCountersStorageSpacesTier(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_StorageSpacesVirtualDisk":
                    return new Win32PerfFormattedDataCountersStorageSpacesVirtualDisk(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_StorageSpacesVirtualDisk":
                    return new Win32PerfRawDataCountersStorageSpacesVirtualDisk(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_StorageSpacesWriteCache":
                    return new Win32PerfFormattedDataCountersStorageSpacesWriteCache(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_StorageSpacesWriteCache":
                    return new Win32PerfRawDataCountersStorageSpacesWriteCache(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_Synchronization":
                    return new Win32PerfFormattedDataCountersSynchronization(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_Synchronization":
                    return new Win32PerfRawDataCountersSynchronization(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_SynchronizationNuma":
                    return new Win32PerfFormattedDataCountersSynchronizationNuma(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_SynchronizationNuma":
                    return new Win32PerfRawDataCountersSynchronizationNuma(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_TeredoClient":
                    return new Win32PerfFormattedDataCountersTeredoClient(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_TeredoClient":
                    return new Win32PerfRawDataCountersTeredoClient(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_TeredoRelay":
                    return new Win32PerfFormattedDataCountersTeredoRelay(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_TeredoRelay":
                    return new Win32PerfRawDataCountersTeredoRelay(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_TeredoServer":
                    return new Win32PerfFormattedDataCountersTeredoServer(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_TeredoServer":
                    return new Win32PerfRawDataCountersTeredoServer(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_ThermalZoneInformation":
                    return new Win32PerfFormattedDataCountersThermalZoneInformation(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_ThermalZoneInformation":
                    return new Win32PerfRawDataCountersThermalZoneInformation(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPPortAverageInboundNetworkTraffic":
                    return new Win32PerfFormattedDataCountersVFPPortAverageInboundNetworkTraffic(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPPortAverageInboundNetworkTraffic":
                    return new Win32PerfRawDataCountersVFPPortAverageInboundNetworkTraffic(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPPortAverageOutboundNetworkTraffic":
                    return new Win32PerfFormattedDataCountersVFPPortAverageOutboundNetworkTraffic(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPPortAverageOutboundNetworkTraffic":
                    return new Win32PerfRawDataCountersVFPPortAverageOutboundNetworkTraffic(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPPortTotalInboundDroppedNetworkPackets":
                    return new Win32PerfFormattedDataCountersVFPPortTotalInboundDroppedNetworkPackets(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPPortTotalInboundDroppedNetworkPackets":
                    return new Win32PerfRawDataCountersVFPPortTotalInboundDroppedNetworkPackets(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPPortTotalInboundNetworkTraffic":
                    return new Win32PerfFormattedDataCountersVFPPortTotalInboundNetworkTraffic(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPPortTotalInboundNetworkTraffic":
                    return new Win32PerfRawDataCountersVFPPortTotalInboundNetworkTraffic(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPPortTotalOutboundDroppedNetworkPackets":
                    return new Win32PerfFormattedDataCountersVFPPortTotalOutboundDroppedNetworkPackets(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPPortTotalOutboundDroppedNetworkPackets":
                    return new Win32PerfRawDataCountersVFPPortTotalOutboundDroppedNetworkPackets(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPPortTotalOutboundNetworkTraffic":
                    return new Win32PerfFormattedDataCountersVFPPortTotalOutboundNetworkTraffic(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPPortTotalOutboundNetworkTraffic":
                    return new Win32PerfRawDataCountersVFPPortTotalOutboundNetworkTraffic(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPQoSQueueAverageInboundNetworkTraffic":
                    return new Win32PerfFormattedDataCountersVFPQoSQueueAverageInboundNetworkTraffic(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPQoSQueueAverageInboundNetworkTraffic":
                    return new Win32PerfRawDataCountersVFPQoSQueueAverageInboundNetworkTraffic(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPQoSQueueAverageOutboundNetworkTraffic":
                    return new Win32PerfFormattedDataCountersVFPQoSQueueAverageOutboundNetworkTraffic(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPQoSQueueAverageOutboundNetworkTraffic":
                    return new Win32PerfRawDataCountersVFPQoSQueueAverageOutboundNetworkTraffic(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPQoSQueueTotalInboundNetworkTraffic":
                    return new Win32PerfFormattedDataCountersVFPQoSQueueTotalInboundNetworkTraffic(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPQoSQueueTotalInboundNetworkTraffic":
                    return new Win32PerfRawDataCountersVFPQoSQueueTotalInboundNetworkTraffic(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPQoSQueueTotalOutboundNetworkTraffic":
                    return new Win32PerfFormattedDataCountersVFPQoSQueueTotalOutboundNetworkTraffic(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPQoSQueueTotalOutboundNetworkTraffic":
                    return new Win32PerfRawDataCountersVFPQoSQueueTotalOutboundNetworkTraffic(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_WFP":
                    return new Win32PerfFormattedDataCountersWFP(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_WFP":
                    return new Win32PerfRawDataCountersWFP(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_WFPClassify":
                    return new Win32PerfFormattedDataCountersWFPClassify(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_WFPClassify":
                    return new Win32PerfRawDataCountersWFPClassify(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_WFPReauthorization":
                    return new Win32PerfFormattedDataCountersWFPReauthorization(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_WFPReauthorization":
                    return new Win32PerfRawDataCountersWFPReauthorization(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_WFPv4":
                    return new Win32PerfFormattedDataCountersWFPv4(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_WFPv4":
                    return new Win32PerfRawDataCountersWFPv4(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_WFPv6":
                    return new Win32PerfFormattedDataCountersWFPv6(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_WFPv6":
                    return new Win32PerfRawDataCountersWFPv6(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_WSManQuotaStatistics":
                    return new Win32PerfFormattedDataCountersWSManQuotaStatistics(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_WSManQuotaStatistics":
                    return new Win32PerfRawDataCountersWSManQuotaStatistics(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_XHCICommonBuffer":
                    return new Win32PerfFormattedDataCountersXHCICommonBuffer(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_XHCICommonBuffer":
                    return new Win32PerfRawDataCountersXHCICommonBuffer(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_XHCIInterrupter":
                    return new Win32PerfFormattedDataCountersXHCIInterrupter(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_XHCIInterrupter":
                    return new Win32PerfRawDataCountersXHCIInterrupter(_scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_XHCITransferRing":
                    return new Win32PerfFormattedDataCountersXHCITransferRing(_scope, cimInstance);
                case "Win32_PerfRawData_Counters_XHCITransferRing":
                    return new Win32PerfRawDataCountersXHCITransferRing(_scope, cimInstance);
                case "Win32_PerfFormattedData_DdmCounterProvider_RAS":
                    return new Win32PerfFormattedDataDdmCounterProviderRAS(_scope, cimInstance);
                case "Win32_PerfRawData_DdmCounterProvider_RAS":
                    return new Win32PerfRawDataDdmCounterProviderRAS(_scope, cimInstance);
                case "Win32_PerfFormattedData_DistributedRoutingTablePerf_DistributedRoutingTable":
                    return new Win32PerfFormattedDataDistributedRoutingTablePerfDistributedRoutingTable(_scope, cimInstance);
                case "Win32_PerfRawData_DistributedRoutingTablePerf_DistributedRoutingTable":
                    return new Win32PerfRawDataDistributedRoutingTablePerfDistributedRoutingTable(_scope, cimInstance);
                case "Win32_PerfFormattedData_ESENT_Database":
                    return new Win32PerfFormattedDataESENTDatabase(_scope, cimInstance);
                case "Win32_PerfRawData_ESENT_Database":
                    return new Win32PerfRawDataESENTDatabase(_scope, cimInstance);
                case "Win32_PerfFormattedData_ESENT_DatabaseDatabases":
                    return new Win32PerfFormattedDataESENTDatabaseDatabases(_scope, cimInstance);
                case "Win32_PerfRawData_ESENT_DatabaseDatabases":
                    return new Win32PerfRawDataESENTDatabaseDatabases(_scope, cimInstance);
                case "Win32_PerfFormattedData_ESENT_DatabaseInstances":
                    return new Win32PerfFormattedDataESENTDatabaseInstances(_scope, cimInstance);
                case "Win32_PerfRawData_ESENT_DatabaseInstances":
                    return new Win32PerfRawDataESENTDatabaseInstances(_scope, cimInstance);
                case "Win32_PerfFormattedData_ESENT_DatabaseTableClasses":
                    return new Win32PerfFormattedDataESENTDatabaseTableClasses(_scope, cimInstance);
                case "Win32_PerfRawData_ESENT_DatabaseTableClasses":
                    return new Win32PerfRawDataESENTDatabaseTableClasses(_scope, cimInstance);
                case "Win32_PerfFormattedData_EthernetPerfProvider_HyperVLegacyNetworkAdapter":
                    return new Win32PerfFormattedDataEthernetPerfProviderHyperVLegacyNetworkAdapter(_scope, cimInstance);
                case "Win32_PerfRawData_EthernetPerfProvider_HyperVLegacyNetworkAdapter":
                    return new Win32PerfRawDataEthernetPerfProviderHyperVLegacyNetworkAdapter(_scope, cimInstance);
                case "Win32_PerfFormattedData_FaxService_FaxService":
                    return new Win32PerfFormattedDataFaxServiceFaxService(_scope, cimInstance);
                case "Win32_PerfRawData_FaxService_FaxService":
                    return new Win32PerfRawDataFaxServiceFaxService(_scope, cimInstance);
                case "Win32_PerfFormattedData_GmoPerfProvider_HyperVVMSaveSnapshotandRestore":
                    return new Win32PerfFormattedDataGmoPerfProviderHyperVVMSaveSnapshotandRestore(_scope, cimInstance);
                case "Win32_PerfRawData_GmoPerfProvider_HyperVVMSaveSnapshotandRestore":
                    return new Win32PerfRawDataGmoPerfProviderHyperVVMSaveSnapshotandRestore(_scope, cimInstance);
                case "Win32_PerfFormattedData_GPUPerformanceCounters_GPUAdapterMemory":
                    return new Win32PerfFormattedDataGPUPerformanceCountersGPUAdapterMemory(_scope, cimInstance);
                case "Win32_PerfRawData_GPUPerformanceCounters_GPUAdapterMemory":
                    return new Win32PerfRawDataGPUPerformanceCountersGPUAdapterMemory(_scope, cimInstance);
                case "Win32_PerfFormattedData_GPUPerformanceCounters_GPUEngine":
                    return new Win32PerfFormattedDataGPUPerformanceCountersGPUEngine(_scope, cimInstance);
                case "Win32_PerfRawData_GPUPerformanceCounters_GPUEngine":
                    return new Win32PerfRawDataGPUPerformanceCountersGPUEngine(_scope, cimInstance);
                case "Win32_PerfFormattedData_GPUPerformanceCounters_GPULocalAdapterMemory":
                    return new Win32PerfFormattedDataGPUPerformanceCountersGPULocalAdapterMemory(_scope, cimInstance);
                case "Win32_PerfRawData_GPUPerformanceCounters_GPULocalAdapterMemory":
                    return new Win32PerfRawDataGPUPerformanceCountersGPULocalAdapterMemory(_scope, cimInstance);
                case "Win32_PerfFormattedData_GPUPerformanceCounters_GPUNonLocalAdapterMemory":
                    return new Win32PerfFormattedDataGPUPerformanceCountersGPUNonLocalAdapterMemory(_scope, cimInstance);
                case "Win32_PerfRawData_GPUPerformanceCounters_GPUNonLocalAdapterMemory":
                    return new Win32PerfRawDataGPUPerformanceCountersGPUNonLocalAdapterMemory(_scope, cimInstance);
                case "Win32_PerfFormattedData_GPUPerformanceCounters_GPUProcessMemory":
                    return new Win32PerfFormattedDataGPUPerformanceCountersGPUProcessMemory(_scope, cimInstance);
                case "Win32_PerfRawData_GPUPerformanceCounters_GPUProcessMemory":
                    return new Win32PerfRawDataGPUPerformanceCountersGPUProcessMemory(_scope, cimInstance);
                case "Win32_PerfFormattedData_HvStats_HyperVHypervisor":
                    return new Win32PerfFormattedDataHvStatsHyperVHypervisor(_scope, cimInstance);
                case "Win32_PerfRawData_HvStats_HyperVHypervisor":
                    return new Win32PerfRawDataHvStatsHyperVHypervisor(_scope, cimInstance);
                case "Win32_PerfFormattedData_HvStats_HyperVHypervisorLogicalProcessor":
                    return new Win32PerfFormattedDataHvStatsHyperVHypervisorLogicalProcessor(_scope, cimInstance);
                case "Win32_PerfRawData_HvStats_HyperVHypervisorLogicalProcessor":
                    return new Win32PerfRawDataHvStatsHyperVHypervisorLogicalProcessor(_scope, cimInstance);
                case "Win32_PerfFormattedData_HvStats_HyperVHypervisorPartition":
                    return new Win32PerfFormattedDataHvStatsHyperVHypervisorPartition(_scope, cimInstance);
                case "Win32_PerfRawData_HvStats_HyperVHypervisorPartition":
                    return new Win32PerfRawDataHvStatsHyperVHypervisorPartition(_scope, cimInstance);
                case "Win32_PerfFormattedData_HvStats_HyperVHypervisorRootPartition":
                    return new Win32PerfFormattedDataHvStatsHyperVHypervisorRootPartition(_scope, cimInstance);
                case "Win32_PerfRawData_HvStats_HyperVHypervisorRootPartition":
                    return new Win32PerfRawDataHvStatsHyperVHypervisorRootPartition(_scope, cimInstance);
                case "Win32_PerfFormattedData_HvStats_HyperVHypervisorRootVirtualProcessor":
                    return new Win32PerfFormattedDataHvStatsHyperVHypervisorRootVirtualProcessor(_scope, cimInstance);
                case "Win32_PerfRawData_HvStats_HyperVHypervisorRootVirtualProcessor":
                    return new Win32PerfRawDataHvStatsHyperVHypervisorRootVirtualProcessor(_scope, cimInstance);
                case "Win32_PerfFormattedData_HvStats_HyperVHypervisorVirtualProcessor":
                    return new Win32PerfFormattedDataHvStatsHyperVHypervisorVirtualProcessor(_scope, cimInstance);
                case "Win32_PerfRawData_HvStats_HyperVHypervisorVirtualProcessor":
                    return new Win32PerfRawDataHvStatsHyperVHypervisorVirtualProcessor(_scope, cimInstance);
                case "Win32_PerfFormattedData_HyperVReplicaStats_HyperVReplicaVM":
                    return new Win32PerfFormattedDataHyperVReplicaStatsHyperVReplicaVM(_scope, cimInstance);
                case "Win32_PerfRawData_HyperVReplicaStats_HyperVReplicaVM":
                    return new Win32PerfRawDataHyperVReplicaStatsHyperVReplicaVM(_scope, cimInstance);
                case "Win32_PerfFormattedData_HyperVStorageStats_HyperVConfiguration":
                    return new Win32PerfFormattedDataHyperVStorageStatsHyperVConfiguration(_scope, cimInstance);
                case "Win32_PerfRawData_HyperVStorageStats_HyperVConfiguration":
                    return new Win32PerfRawDataHyperVStorageStatsHyperVConfiguration(_scope, cimInstance);
                case "Win32_PerfFormattedData_IdePerfProvider_HyperVVirtualIDEControllerEmulated":
                    return new Win32PerfFormattedDataIdePerfProviderHyperVVirtualIDEControllerEmulated(_scope, cimInstance);
                case "Win32_PerfRawData_IdePerfProvider_HyperVVirtualIDEControllerEmulated":
                    return new Win32PerfRawDataIdePerfProviderHyperVVirtualIDEControllerEmulated(_scope, cimInstance);
                case "Win32_PerfFormattedData_IntelStorageCounters_IntelStorageCounters":
                    return new Win32PerfFormattedDataIntelStorageCountersIntelStorageCounters(_scope, cimInstance);
                case "Win32_PerfRawData_IntelStorageCounters_IntelStorageCounters":
                    return new Win32PerfRawDataIntelStorageCountersIntelStorageCounters(_scope, cimInstance);
                case "Win32_PerfFormattedData_LmPerfProvider_HyperVVMLiveMigration":
                    return new Win32PerfFormattedDataLmPerfProviderHyperVVMLiveMigration(_scope, cimInstance);
                case "Win32_PerfRawData_LmPerfProvider_HyperVVMLiveMigration":
                    return new Win32PerfRawDataLmPerfProviderHyperVVMLiveMigration(_scope, cimInstance);
                case "Win32_PerfFormattedData_LocalSessionManager_TerminalServices":
                    return new Win32PerfFormattedDataLocalSessionManagerTerminalServices(_scope, cimInstance);
                case "Win32_PerfRawData_LocalSessionManager_TerminalServices":
                    return new Win32PerfRawDataLocalSessionManagerTerminalServices(_scope, cimInstance);
                case "Win32_PerfFormattedData_Lsa_SecurityPerProcessStatistics":
                    return new Win32PerfFormattedDataLsaSecurityPerProcessStatistics(_scope, cimInstance);
                case "Win32_PerfRawData_Lsa_SecurityPerProcessStatistics":
                    return new Win32PerfRawDataLsaSecurityPerProcessStatistics(_scope, cimInstance);
                case "Win32_PerfFormattedData_Lsa_SecuritySystemWideStatistics":
                    return new Win32PerfFormattedDataLsaSecuritySystemWideStatistics(_scope, cimInstance);
                case "Win32_PerfRawData_Lsa_SecuritySystemWideStatistics":
                    return new Win32PerfRawDataLsaSecuritySystemWideStatistics(_scope, cimInstance);
                case "Win32_PerfFormattedData_LSM_UserInputDelayperProcess":
                    return new Win32PerfFormattedDataLSMUserInputDelayperProcess(_scope, cimInstance);
                case "Win32_PerfRawData_LSM_UserInputDelayperProcess":
                    return new Win32PerfRawDataLSMUserInputDelayperProcess(_scope, cimInstance);
                case "Win32_PerfFormattedData_LSM_UserInputDelayperSession":
                    return new Win32PerfFormattedDataLSMUserInputDelayperSession(_scope, cimInstance);
                case "Win32_PerfRawData_LSM_UserInputDelayperSession":
                    return new Win32PerfRawDataLSMUserInputDelayperSession(_scope, cimInstance);
                case "Win32_PerfFormattedData_MicrosoftWindowsBitLockerDriverCountersProvider_BitLocker":
                    return new Win32PerfFormattedDataMicrosoftWindowsBitLockerDriverCountersProviderBitLocker(_scope, cimInstance);
                case "Win32_PerfRawData_MicrosoftWindowsBitLockerDriverCountersProvider_BitLocker":
                    return new Win32PerfRawDataMicrosoftWindowsBitLockerDriverCountersProviderBitLocker(_scope, cimInstance);
                case "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMDevice":
                    return new Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice(_scope, cimInstance);
                case "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMDevice":
                    return new Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice(_scope, cimInstance);
                case "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMTransportChannel":
                    return new Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMTransportChannel(_scope, cimInstance);
                case "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMTransportChannel":
                    return new Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMTransportChannel(_scope, cimInstance);
                case "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSP":
                    return new Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP(_scope, cimInstance);
                case "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSP":
                    return new Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP(_scope, cimInstance);
                case "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSPVMDevice":
                    return new Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMDevice(_scope, cimInstance);
                case "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSPVMDevice":
                    return new Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMDevice(_scope, cimInstance);
                case "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSPVMTransportChannel":
                    return new Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMTransportChannel(_scope, cimInstance);
                case "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSPVMTransportChannel":
                    return new Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMTransportChannel(_scope, cimInstance);
                case "Win32_PerfFormattedData_MicrosoftWindowsW32TimePerf_WindowsTimeService":
                    return new Win32PerfFormattedDataMicrosoftWindowsW32TimePerfWindowsTimeService(_scope, cimInstance);
                case "Win32_PerfRawData_MicrosoftWindowsW32TimePerf_WindowsTimeService":
                    return new Win32PerfRawDataMicrosoftWindowsW32TimePerfWindowsTimeService(_scope, cimInstance);
                case "Win32_PerfFormattedData_MmPerfProvider_HyperVVMWorkerProcessMemoryManager":
                    return new Win32PerfFormattedDataMmPerfProviderHyperVVMWorkerProcessMemoryManager(_scope, cimInstance);
                case "Win32_PerfRawData_MmPerfProvider_HyperVVMWorkerProcessMemoryManager":
                    return new Win32PerfRawDataMmPerfProviderHyperVVMWorkerProcessMemoryManager(_scope, cimInstance);
                case "Win32_PerfFormattedData_MSDTC_DistributedTransactionCoordinator":
                    return new Win32PerfFormattedDataMSDTCDistributedTransactionCoordinator(_scope, cimInstance);
                case "Win32_PerfRawData_MSDTC_DistributedTransactionCoordinator":
                    return new Win32PerfRawDataMSDTCDistributedTransactionCoordinator(_scope, cimInstance);
                case "Win32_PerfFormattedData_MSDTCBridge4000_MSDTCBridge4000":
                    return new Win32PerfFormattedDataMSDTCBridge4000MSDTCBridge4000(_scope, cimInstance);
                case "Win32_PerfRawData_MSDTCBridge4000_MSDTCBridge4000":
                    return new Win32PerfRawDataMSDTCBridge4000MSDTCBridge4000(_scope, cimInstance);
                case "Win32_PerfFormattedData_NETCLRData_NETCLRData":
                    return new Win32PerfFormattedDataNETCLRDataNETCLRData(_scope, cimInstance);
                case "Win32_PerfRawData_NETCLRData_NETCLRData":
                    return new Win32PerfRawDataNETCLRDataNETCLRData(_scope, cimInstance);
                case "Win32_PerfFormattedData_NETCLRNetworking4000_NETCLRNetworking4000":
                    return new Win32PerfFormattedDataNETCLRNetworking4000NETCLRNetworking4000(_scope, cimInstance);
                case "Win32_PerfRawData_NETCLRNetworking4000_NETCLRNetworking4000":
                    return new Win32PerfRawDataNETCLRNetworking4000NETCLRNetworking4000(_scope, cimInstance);
                case "Win32_PerfFormattedData_NETCLRNetworking_NETCLRNetworking":
                    return new Win32PerfFormattedDataNETCLRNetworkingNETCLRNetworking(_scope, cimInstance);
                case "Win32_PerfRawData_NETCLRNetworking_NETCLRNetworking":
                    return new Win32PerfRawDataNETCLRNetworkingNETCLRNetworking(_scope, cimInstance);
                case "Win32_PerfFormattedData_NETDataProviderforOracle_NETDataProviderforOracle":
                    return new Win32PerfFormattedDataNETDataProviderforOracleNETDataProviderforOracle(_scope, cimInstance);
                case "Win32_PerfRawData_NETDataProviderforOracle_NETDataProviderforOracle":
                    return new Win32PerfRawDataNETDataProviderforOracleNETDataProviderforOracle(_scope, cimInstance);
                case "Win32_PerfFormattedData_NETDataProviderforSqlServer_NETDataProviderforSqlServer":
                    return new Win32PerfFormattedDataNETDataProviderforSqlServerNETDataProviderforSqlServer(_scope, cimInstance);
                case "Win32_PerfRawData_NETDataProviderforSqlServer_NETDataProviderforSqlServer":
                    return new Win32PerfRawDataNETDataProviderforSqlServerNETDataProviderforSqlServer(_scope, cimInstance);
                case "Win32_PerfFormattedData_NETFramework_NETCLRExceptions":
                    return new Win32PerfFormattedDataNETFrameworkNETCLRExceptions(_scope, cimInstance);
                case "Win32_PerfRawData_NETFramework_NETCLRExceptions":
                    return new Win32PerfRawDataNETFrameworkNETCLRExceptions(_scope, cimInstance);
                case "Win32_PerfFormattedData_NETFramework_NETCLRInterop":
                    return new Win32PerfFormattedDataNETFrameworkNETCLRInterop(_scope, cimInstance);
                case "Win32_PerfRawData_NETFramework_NETCLRInterop":
                    return new Win32PerfRawDataNETFrameworkNETCLRInterop(_scope, cimInstance);
                case "Win32_PerfFormattedData_NETFramework_NETCLRJit":
                    return new Win32PerfFormattedDataNETFrameworkNETCLRJit(_scope, cimInstance);
                case "Win32_PerfRawData_NETFramework_NETCLRJit":
                    return new Win32PerfRawDataNETFrameworkNETCLRJit(_scope, cimInstance);
                case "Win32_PerfFormattedData_NETFramework_NETCLRLoading":
                    return new Win32PerfFormattedDataNETFrameworkNETCLRLoading(_scope, cimInstance);
                case "Win32_PerfRawData_NETFramework_NETCLRLoading":
                    return new Win32PerfRawDataNETFrameworkNETCLRLoading(_scope, cimInstance);
                case "Win32_PerfFormattedData_NETFramework_NETCLRLocksAndThreads":
                    return new Win32PerfFormattedDataNETFrameworkNETCLRLocksAndThreads(_scope, cimInstance);
                case "Win32_PerfRawData_NETFramework_NETCLRLocksAndThreads":
                    return new Win32PerfRawDataNETFrameworkNETCLRLocksAndThreads(_scope, cimInstance);
                case "Win32_PerfFormattedData_NETFramework_NETCLRMemory":
                    return new Win32PerfFormattedDataNETFrameworkNETCLRMemory(_scope, cimInstance);
                case "Win32_PerfRawData_NETFramework_NETCLRMemory":
                    return new Win32PerfRawDataNETFrameworkNETCLRMemory(_scope, cimInstance);
                case "Win32_PerfFormattedData_NETFramework_NETCLRRemoting":
                    return new Win32PerfFormattedDataNETFrameworkNETCLRRemoting(_scope, cimInstance);
                case "Win32_PerfRawData_NETFramework_NETCLRRemoting":
                    return new Win32PerfRawDataNETFrameworkNETCLRRemoting(_scope, cimInstance);
                case "Win32_PerfFormattedData_NETFramework_NETCLRSecurity":
                    return new Win32PerfFormattedDataNETFrameworkNETCLRSecurity(_scope, cimInstance);
                case "Win32_PerfRawData_NETFramework_NETCLRSecurity":
                    return new Win32PerfRawDataNETFrameworkNETCLRSecurity(_scope, cimInstance);
                case "Win32_PerfFormattedData_NETMemoryCache40_NETMemoryCache40":
                    return new Win32PerfFormattedDataNETMemoryCache40NETMemoryCache40(_scope, cimInstance);
                case "Win32_PerfRawData_NETMemoryCache40_NETMemoryCache40":
                    return new Win32PerfRawDataNETMemoryCache40NETMemoryCache40(_scope, cimInstance);
                case "Win32_PerfFormattedData_NvspNicDropReasonsStats_HyperVVirtualNetworkAdapterDropReasons":
                    return new Win32PerfFormattedDataNvspNicDropReasonsStatsHyperVVirtualNetworkAdapterDropReasons(_scope, cimInstance);
                case "Win32_PerfRawData_NvspNicDropReasonsStats_HyperVVirtualNetworkAdapterDropReasons":
                    return new Win32PerfRawDataNvspNicDropReasonsStatsHyperVVirtualNetworkAdapterDropReasons(_scope, cimInstance);
                case "Win32_PerfFormattedData_NvspNicStats_HyperVVirtualNetworkAdapter":
                    return new Win32PerfFormattedDataNvspNicStatsHyperVVirtualNetworkAdapter(_scope, cimInstance);
                case "Win32_PerfRawData_NvspNicStats_HyperVVirtualNetworkAdapter":
                    return new Win32PerfRawDataNvspNicStatsHyperVVirtualNetworkAdapter(_scope, cimInstance);
                case "Win32_PerfFormattedData_NvspNicVRSSStats_HyperVVirtualNetworkAdapterVRSS":
                    return new Win32PerfFormattedDataNvspNicVRSSStatsHyperVVirtualNetworkAdapterVRSS(_scope, cimInstance);
                case "Win32_PerfRawData_NvspNicVRSSStats_HyperVVirtualNetworkAdapterVRSS":
                    return new Win32PerfRawDataNvspNicVRSSStatsHyperVVirtualNetworkAdapterVRSS(_scope, cimInstance);
                case "Win32_PerfFormattedData_NvspPortStats_HyperVVirtualSwitchPort":
                    return new Win32PerfFormattedDataNvspPortStatsHyperVVirtualSwitchPort(_scope, cimInstance);
                case "Win32_PerfRawData_NvspPortStats_HyperVVirtualSwitchPort":
                    return new Win32PerfRawDataNvspPortStatsHyperVVirtualSwitchPort(_scope, cimInstance);
                case "Win32_PerfFormattedData_NvspSwitchProcStats_HyperVVirtualSwitchProcessor":
                    return new Win32PerfFormattedDataNvspSwitchProcStatsHyperVVirtualSwitchProcessor(_scope, cimInstance);
                case "Win32_PerfRawData_NvspSwitchProcStats_HyperVVirtualSwitchProcessor":
                    return new Win32PerfRawDataNvspSwitchProcStatsHyperVVirtualSwitchProcessor(_scope, cimInstance);
                case "Win32_PerfFormattedData_NvspSwitchStats_HyperVVirtualSwitch":
                    return new Win32PerfFormattedDataNvspSwitchStatsHyperVVirtualSwitch(_scope, cimInstance);
                case "Win32_PerfRawData_NvspSwitchStats_HyperVVirtualSwitch":
                    return new Win32PerfRawDataNvspSwitchStatsHyperVVirtualSwitch(_scope, cimInstance);
                case "Win32_PerfFormattedData_OfflineFiles_ClientSideCaching":
                    return new Win32PerfFormattedDataOfflineFilesClientSideCaching(_scope, cimInstance);
                case "Win32_PerfRawData_OfflineFiles_ClientSideCaching":
                    return new Win32PerfRawDataOfflineFilesClientSideCaching(_scope, cimInstance);
                case "Win32_PerfFormattedData_OfflineFiles_OfflineFiles":
                    return new Win32PerfFormattedDataOfflineFilesOfflineFiles(_scope, cimInstance);
                case "Win32_PerfRawData_OfflineFiles_OfflineFiles":
                    return new Win32PerfRawDataOfflineFilesOfflineFiles(_scope, cimInstance);
                case "Win32_PerfFormattedData_PeerDistSvc_BranchCache":
                    return new Win32PerfFormattedDataPeerDistSvcBranchCache(_scope, cimInstance);
                case "Win32_PerfRawData_PeerDistSvc_BranchCache":
                    return new Win32PerfRawDataPeerDistSvcBranchCache(_scope, cimInstance);
                case "Win32_PerfFormattedData_PeerNameResolutionProtocolPerf_PeerNameResolutionProtocol":
                    return new Win32PerfFormattedDataPeerNameResolutionProtocolPerfPeerNameResolutionProtocol(_scope, cimInstance);
                case "Win32_PerfRawData_PeerNameResolutionProtocolPerf_PeerNameResolutionProtocol":
                    return new Win32PerfRawDataPeerNameResolutionProtocolPerfPeerNameResolutionProtocol(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfDisk_LogicalDisk":
                    return new Win32PerfFormattedDataPerfDiskLogicalDisk(_scope, cimInstance);
                case "Win32_PerfRawData_PerfDisk_LogicalDisk":
                    return new Win32PerfRawDataPerfDiskLogicalDisk(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfDisk_PhysicalDisk":
                    return new Win32PerfFormattedDataPerfDiskPhysicalDisk(_scope, cimInstance);
                case "Win32_PerfRawData_PerfDisk_PhysicalDisk":
                    return new Win32PerfRawDataPerfDiskPhysicalDisk(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfNet_Browser":
                    return new Win32PerfFormattedDataPerfNetBrowser(_scope, cimInstance);
                case "Win32_PerfRawData_PerfNet_Browser":
                    return new Win32PerfRawDataPerfNetBrowser(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfNet_Redirector":
                    return new Win32PerfFormattedDataPerfNetRedirector(_scope, cimInstance);
                case "Win32_PerfRawData_PerfNet_Redirector":
                    return new Win32PerfRawDataPerfNetRedirector(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfNet_Server":
                    return new Win32PerfFormattedDataPerfNetServer(_scope, cimInstance);
                case "Win32_PerfRawData_PerfNet_Server":
                    return new Win32PerfRawDataPerfNetServer(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfNet_ServerWorkQueues":
                    return new Win32PerfFormattedDataPerfNetServerWorkQueues(_scope, cimInstance);
                case "Win32_PerfRawData_PerfNet_ServerWorkQueues":
                    return new Win32PerfRawDataPerfNetServerWorkQueues(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfOS_Cache":
                    return new Win32PerfFormattedDataPerfOSCache(_scope, cimInstance);
                case "Win32_PerfRawData_PerfOS_Cache":
                    return new Win32PerfRawDataPerfOSCache(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfOS_Memory":
                    return new Win32PerfFormattedDataPerfOSMemory(_scope, cimInstance);
                case "Win32_PerfRawData_PerfOS_Memory":
                    return new Win32PerfRawDataPerfOSMemory(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfOS_NUMANodeMemory":
                    return new Win32PerfFormattedDataPerfOSNUMANodeMemory(_scope, cimInstance);
                case "Win32_PerfRawData_PerfOS_NUMANodeMemory":
                    return new Win32PerfRawDataPerfOSNUMANodeMemory(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfOS_Objects":
                    return new Win32PerfFormattedDataPerfOSObjects(_scope, cimInstance);
                case "Win32_PerfRawData_PerfOS_Objects":
                    return new Win32PerfRawDataPerfOSObjects(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfOS_PagingFile":
                    return new Win32PerfFormattedDataPerfOSPagingFile(_scope, cimInstance);
                case "Win32_PerfRawData_PerfOS_PagingFile":
                    return new Win32PerfRawDataPerfOSPagingFile(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfOS_Processor":
                    return new Win32PerfFormattedDataPerfOSProcessor(_scope, cimInstance);
                case "Win32_PerfRawData_PerfOS_Processor":
                    return new Win32PerfRawDataPerfOSProcessor(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfOS_System":
                    return new Win32PerfFormattedDataPerfOSSystem(_scope, cimInstance);
                case "Win32_PerfRawData_PerfOS_System":
                    return new Win32PerfRawDataPerfOSSystem(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfProc_JobObject":
                    return new Win32PerfFormattedDataPerfProcJobObject(_scope, cimInstance);
                case "Win32_PerfRawData_PerfProc_JobObject":
                    return new Win32PerfRawDataPerfProcJobObject(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfProc_JobObjectDetails":
                    return new Win32PerfFormattedDataPerfProcJobObjectDetails(_scope, cimInstance);
                case "Win32_PerfRawData_PerfProc_JobObjectDetails":
                    return new Win32PerfRawDataPerfProcJobObjectDetails(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfProc_Process":
                    return new Win32PerfFormattedDataPerfProcProcess(_scope, cimInstance);
                case "Win32_PerfRawData_PerfProc_Process":
                    return new Win32PerfRawDataPerfProcProcess(_scope, cimInstance);
                case "Win32_PerfFormattedData_PerfProc_Thread":
                    return new Win32PerfFormattedDataPerfProcThread(_scope, cimInstance);
                case "Win32_PerfRawData_PerfProc_Thread":
                    return new Win32PerfRawDataPerfProcThread(_scope, cimInstance);
                case "Win32_PerfFormattedData_PowerMeterCounter_EnergyMeter":
                    return new Win32PerfFormattedDataPowerMeterCounterEnergyMeter(_scope, cimInstance);
                case "Win32_PerfRawData_PowerMeterCounter_EnergyMeter":
                    return new Win32PerfRawDataPowerMeterCounterEnergyMeter(_scope, cimInstance);
                case "Win32_PerfFormattedData_PowerMeterCounter_PowerMeter":
                    return new Win32PerfFormattedDataPowerMeterCounterPowerMeter(_scope, cimInstance);
                case "Win32_PerfRawData_PowerMeterCounter_PowerMeter":
                    return new Win32PerfRawDataPowerMeterCounterPowerMeter(_scope, cimInstance);
                case "Win32_PerfFormattedData_rdyboost_ReadyBoostCache":
                    return new Win32PerfFormattedDataRdyboostReadyBoostCache(_scope, cimInstance);
                case "Win32_PerfRawData_rdyboost_ReadyBoostCache":
                    return new Win32PerfRawDataRdyboostReadyBoostCache(_scope, cimInstance);
                case "Win32_PerfFormattedData_RemoteAccess_RASPort":
                    return new Win32PerfFormattedDataRemoteAccessRASPort(_scope, cimInstance);
                case "Win32_PerfRawData_RemoteAccess_RASPort":
                    return new Win32PerfRawDataRemoteAccessRASPort(_scope, cimInstance);
                case "Win32_PerfFormattedData_RemoteAccess_RASTotal":
                    return new Win32PerfFormattedDataRemoteAccessRASTotal(_scope, cimInstance);
                case "Win32_PerfRawData_RemoteAccess_RASTotal":
                    return new Win32PerfRawDataRemoteAccessRASTotal(_scope, cimInstance);
                case "Win32_PerfFormattedData_RemoteFXPerformanceCounterProvider_RemoteFXSoftware":
                    return new Win32PerfFormattedDataRemoteFXPerformanceCounterProviderRemoteFXSoftware(_scope, cimInstance);
                case "Win32_PerfRawData_RemoteFXPerformanceCounterProvider_RemoteFXSoftware":
                    return new Win32PerfRawDataRemoteFXPerformanceCounterProviderRemoteFXSoftware(_scope, cimInstance);
                case "Win32_PerfFormattedData_RemotePerfProvider_HyperVVMRemoting":
                    return new Win32PerfFormattedDataRemotePerfProviderHyperVVMRemoting(_scope, cimInstance);
                case "Win32_PerfRawData_RemotePerfProvider_HyperVVMRemoting":
                    return new Win32PerfRawDataRemotePerfProviderHyperVVMRemoting(_scope, cimInstance);
                case "Win32_PerfFormattedData_ServiceModel4000_ServiceModelEndpoint4000":
                    return new Win32PerfFormattedDataServiceModel4000ServiceModelEndpoint4000(_scope, cimInstance);
                case "Win32_PerfRawData_ServiceModel4000_ServiceModelEndpoint4000":
                    return new Win32PerfRawDataServiceModel4000ServiceModelEndpoint4000(_scope, cimInstance);
                case "Win32_PerfFormattedData_ServiceModel4000_ServiceModelOperation4000":
                    return new Win32PerfFormattedDataServiceModel4000ServiceModelOperation4000(_scope, cimInstance);
                case "Win32_PerfRawData_ServiceModel4000_ServiceModelOperation4000":
                    return new Win32PerfRawDataServiceModel4000ServiceModelOperation4000(_scope, cimInstance);
                case "Win32_PerfFormattedData_ServiceModel4000_ServiceModelService4000":
                    return new Win32PerfFormattedDataServiceModel4000ServiceModelService4000(_scope, cimInstance);
                case "Win32_PerfRawData_ServiceModel4000_ServiceModelService4000":
                    return new Win32PerfRawDataServiceModel4000ServiceModelService4000(_scope, cimInstance);
                case "Win32_PerfFormattedData_SMSvcHost4000_SMSvcHost4000":
                    return new Win32PerfFormattedDataSMSvcHost4000SMSvcHost4000(_scope, cimInstance);
                case "Win32_PerfRawData_SMSvcHost4000_SMSvcHost4000":
                    return new Win32PerfRawDataSMSvcHost4000SMSvcHost4000(_scope, cimInstance);
                case "Win32_PerfFormattedData_Spooler_PrintQueue":
                    return new Win32PerfFormattedDataSpoolerPrintQueue(_scope, cimInstance);
                case "Win32_PerfRawData_Spooler_PrintQueue":
                    return new Win32PerfRawDataSpoolerPrintQueue(_scope, cimInstance);
                case "Win32_PerfFormattedData_Synth3dVideoPerfProvider_RemoteFXRootGPUManagement":
                    return new Win32PerfFormattedDataSynth3dVideoPerfProviderRemoteFXRootGPUManagement(_scope, cimInstance);
                case "Win32_PerfRawData_Synth3dVideoPerfProvider_RemoteFXRootGPUManagement":
                    return new Win32PerfRawDataSynth3dVideoPerfProviderRemoteFXRootGPUManagement(_scope, cimInstance);
                case "Win32_PerfFormattedData_TapiSrv_Telephony":
                    return new Win32PerfFormattedDataTapiSrvTelephony(_scope, cimInstance);
                case "Win32_PerfRawData_TapiSrv_Telephony":
                    return new Win32PerfRawDataTapiSrvTelephony(_scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_ICMP":
                    return new Win32PerfFormattedDataTcpipICMP(_scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_ICMP":
                    return new Win32PerfRawDataTcpipICMP(_scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_ICMPv6":
                    return new Win32PerfFormattedDataTcpipICMPv6(_scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_ICMPv6":
                    return new Win32PerfRawDataTcpipICMPv6(_scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_IPv4":
                    return new Win32PerfFormattedDataTcpipIPv4(_scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_IPv4":
                    return new Win32PerfRawDataTcpipIPv4(_scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_IPv6":
                    return new Win32PerfFormattedDataTcpipIPv6(_scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_IPv6":
                    return new Win32PerfRawDataTcpipIPv6(_scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_NBTConnection":
                    return new Win32PerfFormattedDataTcpipNBTConnection(_scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_NBTConnection":
                    return new Win32PerfRawDataTcpipNBTConnection(_scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_NetworkAdapter":
                    return new Win32PerfFormattedDataTcpipNetworkAdapter(_scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_NetworkAdapter":
                    return new Win32PerfRawDataTcpipNetworkAdapter(_scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_NetworkInterface":
                    return new Win32PerfFormattedDataTcpipNetworkInterface(_scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_NetworkInterface":
                    return new Win32PerfRawDataTcpipNetworkInterface(_scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_TCPv4":
                    return new Win32PerfFormattedDataTcpipTCPv4(_scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_TCPv4":
                    return new Win32PerfRawDataTcpipTCPv4(_scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_TCPv6":
                    return new Win32PerfFormattedDataTcpipTCPv6(_scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_TCPv6":
                    return new Win32PerfRawDataTcpipTCPv6(_scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_UDPv4":
                    return new Win32PerfFormattedDataTcpipUDPv4(_scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_UDPv4":
                    return new Win32PerfRawDataTcpipUDPv4(_scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_UDPv6":
                    return new Win32PerfFormattedDataTcpipUDPv6(_scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_UDPv6":
                    return new Win32PerfRawDataTcpipUDPv6(_scope, cimInstance);
                case "Win32_PerfFormattedData_TCPIPCounters_TCPIPPerformanceDiagnostics":
                    return new Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnostics(_scope, cimInstance);
                case "Win32_PerfRawData_TCPIPCounters_TCPIPPerformanceDiagnostics":
                    return new Win32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnostics(_scope, cimInstance);
                case "Win32_PerfFormattedData_TCPIPCounters_TCPIPPerformanceDiagnosticsPerCPU":
                    return new Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnosticsPerCPU(_scope, cimInstance);
                case "Win32_PerfRawData_TCPIPCounters_TCPIPPerformanceDiagnosticsPerCPU":
                    return new Win32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnosticsPerCPU(_scope, cimInstance);
                case "Win32_PerfFormattedData_TermService_TerminalServicesSession":
                    return new Win32PerfFormattedDataTermServiceTerminalServicesSession(_scope, cimInstance);
                case "Win32_PerfRawData_TermService_TerminalServicesSession":
                    return new Win32PerfRawDataTermServiceTerminalServicesSession(_scope, cimInstance);
                case "Win32_PerfFormattedData_UGatherer_SearchGathererProjects":
                    return new Win32PerfFormattedDataUGathererSearchGathererProjects(_scope, cimInstance);
                case "Win32_PerfRawData_UGatherer_SearchGathererProjects":
                    return new Win32PerfRawDataUGathererSearchGathererProjects(_scope, cimInstance);
                case "Win32_PerfFormattedData_UGTHRSVC_SearchGatherer":
                    return new Win32PerfFormattedDataUGTHRSVCSearchGatherer(_scope, cimInstance);
                case "Win32_PerfRawData_UGTHRSVC_SearchGatherer":
                    return new Win32PerfRawDataUGTHRSVCSearchGatherer(_scope, cimInstance);
                case "Win32_PerfFormattedData_usbhub_Noname":
                    return new Win32PerfFormattedDataUsbhubNoname(_scope, cimInstance);
                case "Win32_PerfRawData_usbhub_Noname":
                    return new Win32PerfRawDataUsbhubNoname(_scope, cimInstance);
                case "Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidDriver":
                    return new Win32PerfFormattedDataVidPerfProviderHyperVVMVidDriver(_scope, cimInstance);
                case "Win32_PerfRawData_VidPerfProvider_HyperVVMVidDriver":
                    return new Win32PerfRawDataVidPerfProviderHyperVVMVidDriver(_scope, cimInstance);
                case "Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidNumaNode":
                    return new Win32PerfFormattedDataVidPerfProviderHyperVVMVidNumaNode(_scope, cimInstance);
                case "Win32_PerfRawData_VidPerfProvider_HyperVVMVidNumaNode":
                    return new Win32PerfRawDataVidPerfProviderHyperVVMVidNumaNode(_scope, cimInstance);
                case "Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidPartition":
                    return new Win32PerfFormattedDataVidPerfProviderHyperVVMVidPartition(_scope, cimInstance);
                case "Win32_PerfRawData_VidPerfProvider_HyperVVMVidPartition":
                    return new Win32PerfRawDataVidPerfProviderHyperVVMVidPartition(_scope, cimInstance);
                case "Win32_PerfFormattedData_VMBusPipeIOPerfProvider_HyperVVMVirtualDevicePipeIO":
                    return new Win32PerfFormattedDataVMBusPipeIOPerfProviderHyperVVMVirtualDevicePipeIO(_scope, cimInstance);
                case "Win32_PerfRawData_VMBusPipeIOPerfProvider_HyperVVMVirtualDevicePipeIO":
                    return new Win32PerfRawDataVMBusPipeIOPerfProviderHyperVVMVirtualDevicePipeIO(_scope, cimInstance);
                case "Win32_PerfFormattedData_VmmsVirtualMachineStats_HyperVVirtualMachineHealthSummary":
                    return new Win32PerfFormattedDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary(_scope, cimInstance);
                case "Win32_PerfRawData_VmmsVirtualMachineStats_HyperVVirtualMachineHealthSummary":
                    return new Win32PerfRawDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary(_scope, cimInstance);
                case "Win32_PerfFormattedData_VSmbPerfProvider_HyperVVirtualSMB":
                    return new Win32PerfFormattedDataVSmbPerfProviderHyperVVirtualSMB(_scope, cimInstance);
                case "Win32_PerfRawData_VSmbPerfProvider_HyperVVirtualSMB":
                    return new Win32PerfRawDataVSmbPerfProviderHyperVVirtualSMB(_scope, cimInstance);
                case "Win32_PerfFormattedData_WindowsMediaPlayer_WindowsMediaPlayerMetadata":
                    return new Win32PerfFormattedDataWindowsMediaPlayerWindowsMediaPlayerMetadata(_scope, cimInstance);
                case "Win32_PerfRawData_WindowsMediaPlayer_WindowsMediaPlayerMetadata":
                    return new Win32PerfRawDataWindowsMediaPlayerWindowsMediaPlayerMetadata(_scope, cimInstance);
                case "Win32_PerfFormattedData_WindowsWorkflowFoundation4000_WFSystemWorkflow4000":
                    return new Win32PerfFormattedDataWindowsWorkflowFoundation4000WFSystemWorkflow4000(_scope, cimInstance);
                case "Win32_PerfRawData_WindowsWorkflowFoundation4000_WFSystemWorkflow4000":
                    return new Win32PerfRawDataWindowsWorkflowFoundation4000WFSystemWorkflow4000(_scope, cimInstance);
                case "Win32_PerfFormattedData_WinNatCounters_WinNAT":
                    return new Win32PerfFormattedDataWinNatCountersWinNAT(_scope, cimInstance);
                case "Win32_PerfRawData_WinNatCounters_WinNAT":
                    return new Win32PerfRawDataWinNatCountersWinNAT(_scope, cimInstance);
                case "Win32_PerfFormattedData_WinNatCounters_WinNATICMP":
                    return new Win32PerfFormattedDataWinNatCountersWinNATICMP(_scope, cimInstance);
                case "Win32_PerfRawData_WinNatCounters_WinNATICMP":
                    return new Win32PerfRawDataWinNatCountersWinNATICMP(_scope, cimInstance);
                case "Win32_PerfFormattedData_WinNatCounters_WinNATInstance":
                    return new Win32PerfFormattedDataWinNatCountersWinNATInstance(_scope, cimInstance);
                case "Win32_PerfRawData_WinNatCounters_WinNATInstance":
                    return new Win32PerfRawDataWinNatCountersWinNATInstance(_scope, cimInstance);
                case "Win32_PerfFormattedData_WinNatCounters_WinNATTCP":
                    return new Win32PerfFormattedDataWinNatCountersWinNATTCP(_scope, cimInstance);
                case "Win32_PerfRawData_WinNatCounters_WinNATTCP":
                    return new Win32PerfRawDataWinNatCountersWinNATTCP(_scope, cimInstance);
                case "Win32_PerfFormattedData_WinNatCounters_WinNATUDP":
                    return new Win32PerfFormattedDataWinNatCountersWinNATUDP(_scope, cimInstance);
                case "Win32_PerfRawData_WinNatCounters_WinNATUDP":
                    return new Win32PerfRawDataWinNatCountersWinNATUDP(_scope, cimInstance);
                case "Win32_PerfFormattedData_WorkerVpProvider_HyperVWorkerVirtualProcessor":
                    return new Win32PerfFormattedDataWorkerVpProviderHyperVWorkerVirtualProcessor(_scope, cimInstance);
                case "Win32_PerfRawData_WorkerVpProvider_HyperVWorkerVirtualProcessor":
                    return new Win32PerfRawDataWorkerVpProviderHyperVWorkerVirtualProcessor(_scope, cimInstance);
                case "Win32_PerfFormattedData_WorkflowServiceHost4000_WorkflowServiceHost4000":
                    return new Win32PerfFormattedDataWorkflowServiceHost4000WorkflowServiceHost4000(_scope, cimInstance);
                case "Win32_PerfRawData_WorkflowServiceHost4000_WorkflowServiceHost4000":
                    return new Win32PerfRawDataWorkflowServiceHost4000WorkflowServiceHost4000(_scope, cimInstance);
                case "Win32_PerfFormattedData_WSearchIdxPi_SearchIndexer":
                    return new Win32PerfFormattedDataWSearchIdxPiSearchIndexer(_scope, cimInstance);
                case "Win32_PerfRawData_WSearchIdxPi_SearchIndexer":
                    return new Win32PerfRawDataWSearchIdxPiSearchIndexer(_scope, cimInstance);
                default:
                    throw new KeyNotFoundException();
            }
        }

        private static Dictionary<Type, (string, string)> _typeMap = new Dictionary<Type, (string, string)>{ { typeof ( SystemClass ) ,  ( "root/cimv2" ,  "__SystemClass" ) }
        ,  { typeof ( ThisNAMESPACE ) ,  ( "root/cimv2" ,  "__thisNAMESPACE" ) }
        ,  { typeof ( Provider ) ,  ( "root/cimv2" ,  "__Provider" ) }
        ,  { typeof ( Win32Provider ) ,  ( "root/cimv2" ,  "__Win32Provider" ) }
        ,  { typeof ( ProviderRegistration ) ,  ( "root/cimv2" ,  "__ProviderRegistration" ) }
        ,  { typeof ( EventProviderRegistration ) ,  ( "root/cimv2" ,  "__EventProviderRegistration" ) }
        ,  { typeof ( ObjectProviderRegistration ) ,  ( "root/cimv2" ,  "__ObjectProviderRegistration" ) }
        ,  { typeof ( ClassProviderRegistration ) ,  ( "root/cimv2" ,  "__ClassProviderRegistration" ) }
        ,  { typeof ( InstanceProviderRegistration ) ,  ( "root/cimv2" ,  "__InstanceProviderRegistration" ) }
        ,  { typeof ( MethodProviderRegistration ) ,  ( "root/cimv2" ,  "__MethodProviderRegistration" ) }
        ,  { typeof ( PropertyProviderRegistration ) ,  ( "root/cimv2" ,  "__PropertyProviderRegistration" ) }
        ,  { typeof ( EventConsumerProviderRegistration ) ,  ( "root/cimv2" ,  "__EventConsumerProviderRegistration" ) }
        ,  { typeof ( NAMESPACE ) ,  ( "root/cimv2" ,  "__NAMESPACE" ) }
        ,  { typeof ( IndicationRelated ) ,  ( "root/cimv2" ,  "__IndicationRelated" ) }
        ,  { typeof ( FilterToConsumerBinding ) ,  ( "root/cimv2" ,  "__FilterToConsumerBinding" ) }
        ,  { typeof ( EventConsumer ) ,  ( "root/cimv2" ,  "__EventConsumer" ) }
        ,  { typeof ( AggregateEvent ) ,  ( "root/cimv2" ,  "__AggregateEvent" ) }
        ,  { typeof ( TimerNextFiring ) ,  ( "root/cimv2" ,  "__TimerNextFiring" ) }
        ,  { typeof ( EventFilter ) ,  ( "root/cimv2" ,  "__EventFilter" ) }
        ,  { typeof ( Event ) ,  ( "root/cimv2" ,  "__Event" ) }
        ,  { typeof ( NamespaceOperationEvent ) ,  ( "root/cimv2" ,  "__NamespaceOperationEvent" ) }
        ,  { typeof ( NamespaceModificationEvent ) ,  ( "root/cimv2" ,  "__NamespaceModificationEvent" ) }
        ,  { typeof ( NamespaceDeletionEvent ) ,  ( "root/cimv2" ,  "__NamespaceDeletionEvent" ) }
        ,  { typeof ( NamespaceCreationEvent ) ,  ( "root/cimv2" ,  "__NamespaceCreationEvent" ) }
        ,  { typeof ( ClassOperationEvent ) ,  ( "root/cimv2" ,  "__ClassOperationEvent" ) }
        ,  { typeof ( ClassDeletionEvent ) ,  ( "root/cimv2" ,  "__ClassDeletionEvent" ) }
        ,  { typeof ( ClassModificationEvent ) ,  ( "root/cimv2" ,  "__ClassModificationEvent" ) }
        ,  { typeof ( ClassCreationEvent ) ,  ( "root/cimv2" ,  "__ClassCreationEvent" ) }
        ,  { typeof ( InstanceOperationEvent ) ,  ( "root/cimv2" ,  "__InstanceOperationEvent" ) }
        ,  { typeof ( InstanceCreationEvent ) ,  ( "root/cimv2" ,  "__InstanceCreationEvent" ) }
        ,  { typeof ( MethodInvocationEvent ) ,  ( "root/cimv2" ,  "__MethodInvocationEvent" ) }
        ,  { typeof ( InstanceModificationEvent ) ,  ( "root/cimv2" ,  "__InstanceModificationEvent" ) }
        ,  { typeof ( InstanceDeletionEvent ) ,  ( "root/cimv2" ,  "__InstanceDeletionEvent" ) }
        ,  { typeof ( TimerEvent ) ,  ( "root/cimv2" ,  "__TimerEvent" ) }
        ,  { typeof ( ExtrinsicEvent ) ,  ( "root/cimv2" ,  "__ExtrinsicEvent" ) }
        ,  { typeof ( SystemEvent ) ,  ( "root/cimv2" ,  "__SystemEvent" ) }
        ,  { typeof ( EventDroppedEvent ) ,  ( "root/cimv2" ,  "__EventDroppedEvent" ) }
        ,  { typeof ( EventQueueOverflowEvent ) ,  ( "root/cimv2" ,  "__EventQueueOverflowEvent" ) }
        ,  { typeof ( QOSFailureEvent ) ,  ( "root/cimv2" ,  "__QOSFailureEvent" ) }
        ,  { typeof ( ConsumerFailureEvent ) ,  ( "root/cimv2" ,  "__ConsumerFailureEvent" ) }
        ,  { typeof ( MSFTSCMEvent ) ,  ( "root/cimv2" ,  "MSFT_SCMEvent" ) }
        ,  { typeof ( MSFTSCMEventLogEvent ) ,  ( "root/cimv2" ,  "MSFT_SCMEventLogEvent" ) }
        ,  { typeof ( MSFTNetSevereServiceFailed ) ,  ( "root/cimv2" ,  "MSFT_NetSevereServiceFailed" ) }
        ,  { typeof ( MSFTNetTransactInvalid ) ,  ( "root/cimv2" ,  "MSFT_NetTransactInvalid" ) }
        ,  { typeof ( MSFTNetServiceNotInteractive ) ,  ( "root/cimv2" ,  "MSFT_NetServiceNotInteractive" ) }
        ,  { typeof ( MSFTNetTakeOwnership ) ,  ( "root/cimv2" ,  "MSFT_NetTakeOwnership" ) }
        ,  { typeof ( MSFTNetServiceConfigBackoutFailed ) ,  ( "root/cimv2" ,  "MSFT_NetServiceConfigBackoutFailed" ) }
        ,  { typeof ( MSFTNetServiceShutdownFailed ) ,  ( "root/cimv2" ,  "MSFT_NetServiceShutdownFailed" ) }
        ,  { typeof ( MSFTNetServiceStartHung ) ,  ( "root/cimv2" ,  "MSFT_NetServiceStartHung" ) }
        ,  { typeof ( MSFTNetServiceStopControlSuccess ) ,  ( "root/cimv2" ,  "MSFT_NetServiceStopControlSuccess" ) }
        ,  { typeof ( MSFTNetServiceSlowStartup ) ,  ( "root/cimv2" ,  "MSFT_NetServiceSlowStartup" ) }
        ,  { typeof ( MSFTNetCallToFunctionFailed ) ,  ( "root/cimv2" ,  "MSFT_NetCallToFunctionFailed" ) }
        ,  { typeof ( MSFTNetBadAccount ) ,  ( "root/cimv2" ,  "MSFT_NetBadAccount" ) }
        ,  { typeof ( MSFTNetBadServiceState ) ,  ( "root/cimv2" ,  "MSFT_NetBadServiceState" ) }
        ,  { typeof ( MSFTNetConnectionTimeout ) ,  ( "root/cimv2" ,  "MSFT_NetConnectionTimeout" ) }
        ,  { typeof ( MSFTNetCircularDependencyAuto ) ,  ( "root/cimv2" ,  "MSFT_NetCircularDependencyAuto" ) }
        ,  { typeof ( MSFTNetServiceStartTypeChanged ) ,  ( "root/cimv2" ,  "MSFT_NetServiceStartTypeChanged" ) }
        ,  { typeof ( MSFTNetServiceLogonTypeNotGranted ) ,  ( "root/cimv2" ,  "MSFT_NetServiceLogonTypeNotGranted" ) }
        ,  { typeof ( MSFTNetServiceStartFailedGroup ) ,  ( "root/cimv2" ,  "MSFT_NetServiceStartFailedGroup" ) }
        ,  { typeof ( MSFTNetDependOnLaterService ) ,  ( "root/cimv2" ,  "MSFT_NetDependOnLaterService" ) }
        ,  { typeof ( MSFTNetFirstLogonFailedII ) ,  ( "root/cimv2" ,  "MSFT_NetFirstLogonFailedII" ) }
        ,  { typeof ( MSFTNetServiceDifferentPIDConnected ) ,  ( "root/cimv2" ,  "MSFT_NetServiceDifferentPIDConnected" ) }
        ,  { typeof ( MSFTNetServiceCrashNoAction ) ,  ( "root/cimv2" ,  "MSFT_NetServiceCrashNoAction" ) }
        ,  { typeof ( MSFTNetCircularDependencyDemand ) ,  ( "root/cimv2" ,  "MSFT_NetCircularDependencyDemand" ) }
        ,  { typeof ( MSFTNetServiceExitFailed ) ,  ( "root/cimv2" ,  "MSFT_NetServiceExitFailed" ) }
        ,  { typeof ( MSFTNetServiceStartFailedII ) ,  ( "root/cimv2" ,  "MSFT_NetServiceStartFailedII" ) }
        ,  { typeof ( MSFTNetServiceExitFailedSpecific ) ,  ( "root/cimv2" ,  "MSFT_NetServiceExitFailedSpecific" ) }
        ,  { typeof ( MSFTNetBootSystemDriversFailed ) ,  ( "root/cimv2" ,  "MSFT_NetBootSystemDriversFailed" ) }
        ,  { typeof ( MSFTNetServiceCrash ) ,  ( "root/cimv2" ,  "MSFT_NetServiceCrash" ) }
        ,  { typeof ( MSFTNetServiceRecoveryFailed ) ,  ( "root/cimv2" ,  "MSFT_NetServiceRecoveryFailed" ) }
        ,  { typeof ( MSFTNetServiceStatusSuccess ) ,  ( "root/cimv2" ,  "MSFT_NetServiceStatusSuccess" ) }
        ,  { typeof ( MSFTNetTransactTimeout ) ,  ( "root/cimv2" ,  "MSFT_NetTransactTimeout" ) }
        ,  { typeof ( MSFTNetFirstLogonFailed ) ,  ( "root/cimv2" ,  "MSFT_NetFirstLogonFailed" ) }
        ,  { typeof ( MSFTNetServiceControlSuccess ) ,  ( "root/cimv2" ,  "MSFT_NetServiceControlSuccess" ) }
        ,  { typeof ( MSFTNetServiceStartFailed ) ,  ( "root/cimv2" ,  "MSFT_NetServiceStartFailed" ) }
        ,  { typeof ( MSFTNetServiceStartFailedNone ) ,  ( "root/cimv2" ,  "MSFT_NetServiceStartFailedNone" ) }
        ,  { typeof ( MSFTNetReadfileTimeout ) ,  ( "root/cimv2" ,  "MSFT_NetReadfileTimeout" ) }
        ,  { typeof ( MSFTNetRevertedToLastKnownGood ) ,  ( "root/cimv2" ,  "MSFT_NetRevertedToLastKnownGood" ) }
        ,  { typeof ( MSFTNetCallToFunctionFailedII ) ,  ( "root/cimv2" ,  "MSFT_NetCallToFunctionFailedII" ) }
        ,  { typeof ( MSFTNetDependOnLaterGroup ) ,  ( "root/cimv2" ,  "MSFT_NetDependOnLaterGroup" ) }
        ,  { typeof ( MSFTWmiSelfEvent ) ,  ( "root/cimv2" ,  "MSFT_WmiSelfEvent" ) }
        ,  { typeof ( MSFTWmiEssEvent ) ,  ( "root/cimv2" ,  "MSFT_WmiEssEvent" ) }
        ,  { typeof ( MSFTWmiThreadPoolEvent ) ,  ( "root/cimv2" ,  "MSFT_WmiThreadPoolEvent" ) }
        ,  { typeof ( MSFTWmiThreadPoolThreadCreated ) ,  ( "root/cimv2" ,  "MSFT_WmiThreadPoolThreadCreated" ) }
        ,  { typeof ( MSFTWmiThreadPoolThreadDeleted ) ,  ( "root/cimv2" ,  "MSFT_WmiThreadPoolThreadDeleted" ) }
        ,  { typeof ( MSFTWmiRegisterNotificationSink ) ,  ( "root/cimv2" ,  "MSFT_WmiRegisterNotificationSink" ) }
        ,  { typeof ( MSFTWmiFilterEvent ) ,  ( "root/cimv2" ,  "MSFT_WmiFilterEvent" ) }
        ,  { typeof ( MSFTWmiFilterDeactivated ) ,  ( "root/cimv2" ,  "MSFT_WmiFilterDeactivated" ) }
        ,  { typeof ( MSFTWmiFilterActivated ) ,  ( "root/cimv2" ,  "MSFT_WmiFilterActivated" ) }
        ,  { typeof ( MSFTWmiCancelNotificationSink ) ,  ( "root/cimv2" ,  "MSFT_WmiCancelNotificationSink" ) }
        ,  { typeof ( MSFTWmiProviderEvent ) ,  ( "root/cimv2" ,  "MSFT_WmiProviderEvent" ) }
        ,  { typeof ( MSFTWmiConsumerProviderEvent ) ,  ( "root/cimv2" ,  "MSFT_WmiConsumerProviderEvent" ) }
        ,  { typeof ( MSFTWmiConsumerProviderSinkLoaded ) ,  ( "root/cimv2" ,  "MSFT_WmiConsumerProviderSinkLoaded" ) }
        ,  { typeof ( MSFTWmiConsumerProviderSinkUnloaded ) ,  ( "root/cimv2" ,  "MSFT_WmiConsumerProviderSinkUnloaded" ) }
        ,  { typeof ( MSFTWmiConsumerProviderUnloaded ) ,  ( "root/cimv2" ,  "MSFT_WmiConsumerProviderUnloaded" ) }
        ,  { typeof ( MSFTWmiConsumerProviderLoaded ) ,  ( "root/cimv2" ,  "MSFT_WmiConsumerProviderLoaded" ) }
        ,  { typeof ( MsftWmiProviderOperationEvent ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_OperationEvent" ) }
        ,  { typeof ( MsftWmiProviderComServerLoadOperationEvent ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_ComServerLoadOperationEvent" ) }
        ,  { typeof ( MsftWmiProviderOperationEventPost ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_OperationEvent_Post" ) }
        ,  { typeof ( MsftWmiProviderPutInstanceAsyncEventPost ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_PutInstanceAsyncEvent_Post" ) }
        ,  { typeof ( MsftWmiProviderCreateInstanceEnumAsyncEventPost ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_CreateInstanceEnumAsyncEvent_Post" ) }
        ,  { typeof ( MsftWmiProviderDeleteInstanceAsyncEventPost ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_DeleteInstanceAsyncEvent_Post" ) }
        ,  { typeof ( MsftWmiProviderCancelQueryPost ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_CancelQuery_Post" ) }
        ,  { typeof ( MsftWmiProviderNewQueryPost ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_NewQuery_Post" ) }
        ,  { typeof ( MsftWmiProviderProvideEventsPost ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_ProvideEvents_Post" ) }
        ,  { typeof ( MsftWmiProviderExecQueryAsyncEventPost ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_ExecQueryAsyncEvent_Post" ) }
        ,  { typeof ( MsftWmiProviderAccessCheckPost ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_AccessCheck_Post" ) }
        ,  { typeof ( MsftWmiProviderCreateClassEnumAsyncEventPost ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_CreateClassEnumAsyncEvent_Post" ) }
        ,  { typeof ( MsftWmiProviderDeleteClassAsyncEventPost ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_DeleteClassAsyncEvent_Post" ) }
        ,  { typeof ( MsftWmiProviderExecMethodAsyncEventPost ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_ExecMethodAsyncEvent_Post" ) }
        ,  { typeof ( MsftWmiProviderGetObjectAsyncEventPost ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_GetObjectAsyncEvent_Post" ) }
        ,  { typeof ( MsftWmiProviderPutClassAsyncEventPost ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_PutClassAsyncEvent_Post" ) }
        ,  { typeof ( MsftWmiProviderInitializationOperationFailureEvent ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_InitializationOperationFailureEvent" ) }
        ,  { typeof ( MsftWmiProviderInitializationOperationEvent ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_InitializationOperationEvent" ) }
        ,  { typeof ( MsftWmiProviderLoadOperationFailureEvent ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_LoadOperationFailureEvent" ) }
        ,  { typeof ( MsftWmiProviderComServerLoadOperationFailureEvent ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_ComServerLoadOperationFailureEvent" ) }
        ,  { typeof ( MsftWmiProviderUnLoadOperationEvent ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_UnLoadOperationEvent" ) }
        ,  { typeof ( MsftWmiProviderLoadOperationEvent ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_LoadOperationEvent" ) }
        ,  { typeof ( MsftWmiProviderOperationEventPre ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_OperationEvent_Pre" ) }
        ,  { typeof ( MsftWmiProviderDeleteInstanceAsyncEventPre ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_DeleteInstanceAsyncEvent_Pre" ) }
        ,  { typeof ( MsftWmiProviderAccessCheckPre ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_AccessCheck_Pre" ) }
        ,  { typeof ( MsftWmiProviderExecQueryAsyncEventPre ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_ExecQueryAsyncEvent_Pre" ) }
        ,  { typeof ( MsftWmiProviderDeleteClassAsyncEventPre ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_DeleteClassAsyncEvent_Pre" ) }
        ,  { typeof ( MsftWmiProviderNewQueryPre ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_NewQuery_Pre" ) }
        ,  { typeof ( MsftWmiProviderPutInstanceAsyncEventPre ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_PutInstanceAsyncEvent_Pre" ) }
        ,  { typeof ( MsftWmiProviderCreateClassEnumAsyncEventPre ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_CreateClassEnumAsyncEvent_Pre" ) }
        ,  { typeof ( MsftWmiProviderExecMethodAsyncEventPre ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_ExecMethodAsyncEvent_Pre" ) }
        ,  { typeof ( MsftWmiProviderProvideEventsPre ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_ProvideEvents_Pre" ) }
        ,  { typeof ( MsftWmiProviderCancelQueryPre ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_CancelQuery_Pre" ) }
        ,  { typeof ( MsftWmiProviderPutClassAsyncEventPre ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_PutClassAsyncEvent_Pre" ) }
        ,  { typeof ( MsftWmiProviderGetObjectAsyncEventPre ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_GetObjectAsyncEvent_Pre" ) }
        ,  { typeof ( MsftWmiProviderCreateInstanceEnumAsyncEventPre ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_CreateInstanceEnumAsyncEvent_Pre" ) }
        ,  { typeof ( MSFTWMIGenericNonCOMEvent ) ,  ( "root/cimv2" ,  "MSFT_WMI_GenericNonCOMEvent" ) }
        ,  { typeof ( Win32ComputerSystemEvent ) ,  ( "root/cimv2" ,  "Win32_ComputerSystemEvent" ) }
        ,  { typeof ( Win32ComputerShutdownEvent ) ,  ( "root/cimv2" ,  "Win32_ComputerShutdownEvent" ) }
        ,  { typeof ( Win32IP4RouteTableEvent ) ,  ( "root/cimv2" ,  "Win32_IP4RouteTableEvent" ) }
        ,  { typeof ( MSFTNCProvEvent ) ,  ( "root/cimv2" ,  "MSFT_NCProvEvent" ) }
        ,  { typeof ( MSFTNCProvCancelQuery ) ,  ( "root/cimv2" ,  "MSFT_NCProvCancelQuery" ) }
        ,  { typeof ( MSFTNCProvClientConnected ) ,  ( "root/cimv2" ,  "MSFT_NCProvClientConnected" ) }
        ,  { typeof ( MSFTNCProvNewQuery ) ,  ( "root/cimv2" ,  "MSFT_NCProvNewQuery" ) }
        ,  { typeof ( MSFTNCProvAccessCheck ) ,  ( "root/cimv2" ,  "MSFT_NCProvAccessCheck" ) }
        ,  { typeof ( RegistryEvent ) ,  ( "root/cimv2" ,  "RegistryEvent" ) }
        ,  { typeof ( RegistryKeyChangeEvent ) ,  ( "root/cimv2" ,  "RegistryKeyChangeEvent" ) }
        ,  { typeof ( RegistryTreeChangeEvent ) ,  ( "root/cimv2" ,  "RegistryTreeChangeEvent" ) }
        ,  { typeof ( RegistryValueChangeEvent ) ,  ( "root/cimv2" ,  "RegistryValueChangeEvent" ) }
        ,  { typeof ( Win32SystemTrace ) ,  ( "root/cimv2" ,  "Win32_SystemTrace" ) }
        ,  { typeof ( Win32ProcessTrace ) ,  ( "root/cimv2" ,  "Win32_ProcessTrace" ) }
        ,  { typeof ( Win32ProcessStartTrace ) ,  ( "root/cimv2" ,  "Win32_ProcessStartTrace" ) }
        ,  { typeof ( Win32ProcessStopTrace ) ,  ( "root/cimv2" ,  "Win32_ProcessStopTrace" ) }
        ,  { typeof ( Win32ModuleTrace ) ,  ( "root/cimv2" ,  "Win32_ModuleTrace" ) }
        ,  { typeof ( Win32ModuleLoadTrace ) ,  ( "root/cimv2" ,  "Win32_ModuleLoadTrace" ) }
        ,  { typeof ( Win32ThreadTrace ) ,  ( "root/cimv2" ,  "Win32_ThreadTrace" ) }
        ,  { typeof ( Win32ThreadStartTrace ) ,  ( "root/cimv2" ,  "Win32_ThreadStartTrace" ) }
        ,  { typeof ( Win32ThreadStopTrace ) ,  ( "root/cimv2" ,  "Win32_ThreadStopTrace" ) }
        ,  { typeof ( Win32PowerManagementEvent ) ,  ( "root/cimv2" ,  "Win32_PowerManagementEvent" ) }
        ,  { typeof ( Win32DeviceChangeEvent ) ,  ( "root/cimv2" ,  "Win32_DeviceChangeEvent" ) }
        ,  { typeof ( Win32SystemConfigurationChangeEvent ) ,  ( "root/cimv2" ,  "Win32_SystemConfigurationChangeEvent" ) }
        ,  { typeof ( Win32VolumeChangeEvent ) ,  ( "root/cimv2" ,  "Win32_VolumeChangeEvent" ) }
        ,  { typeof ( EventGenerator ) ,  ( "root/cimv2" ,  "__EventGenerator" ) }
        ,  { typeof ( TimerInstruction ) ,  ( "root/cimv2" ,  "__TimerInstruction" ) }
        ,  { typeof ( AbsoluteTimerInstruction ) ,  ( "root/cimv2" ,  "__AbsoluteTimerInstruction" ) }
        ,  { typeof ( IntervalTimerInstruction ) ,  ( "root/cimv2" ,  "__IntervalTimerInstruction" ) }
        ,  { typeof ( SystemSecurity ) ,  ( "root/cimv2" ,  "__SystemSecurity" ) }
        ,  { typeof ( CIMManagedSystemElement ) ,  ( "root/cimv2" ,  "CIM_ManagedSystemElement" ) }
        ,  { typeof ( CIMPhysicalElement ) ,  ( "root/cimv2" ,  "CIM_PhysicalElement" ) }
        ,  { typeof ( CIMPhysicalPackage ) ,  ( "root/cimv2" ,  "CIM_PhysicalPackage" ) }
        ,  { typeof ( CIMCard ) ,  ( "root/cimv2" ,  "CIM_Card" ) }
        ,  { typeof ( Win32BaseBoard ) ,  ( "root/cimv2" ,  "Win32_BaseBoard" ) }
        ,  { typeof ( CIMPhysicalFrame ) ,  ( "root/cimv2" ,  "CIM_PhysicalFrame" ) }
        ,  { typeof ( CIMChassis ) ,  ( "root/cimv2" ,  "CIM_Chassis" ) }
        ,  { typeof ( Win32SystemEnclosure ) ,  ( "root/cimv2" ,  "Win32_SystemEnclosure" ) }
        ,  { typeof ( CIMRack ) ,  ( "root/cimv2" ,  "CIM_Rack" ) }
        ,  { typeof ( Win32PhysicalMemoryArray ) ,  ( "root/cimv2" ,  "Win32_PhysicalMemoryArray" ) }
        ,  { typeof ( CIMPhysicalComponent ) ,  ( "root/cimv2" ,  "CIM_PhysicalComponent" ) }
        ,  { typeof ( CIMPhysicalMedia ) ,  ( "root/cimv2" ,  "CIM_PhysicalMedia" ) }
        ,  { typeof ( Win32PhysicalMedia ) ,  ( "root/cimv2" ,  "Win32_PhysicalMedia" ) }
        ,  { typeof ( CIMChip ) ,  ( "root/cimv2" ,  "CIM_Chip" ) }
        ,  { typeof ( CIMPhysicalMemory ) ,  ( "root/cimv2" ,  "CIM_PhysicalMemory" ) }
        ,  { typeof ( Win32PhysicalMemory ) ,  ( "root/cimv2" ,  "Win32_PhysicalMemory" ) }
        ,  { typeof ( Win32OnBoardDevice ) ,  ( "root/cimv2" ,  "Win32_OnBoardDevice" ) }
        ,  { typeof ( CIMPhysicalConnector ) ,  ( "root/cimv2" ,  "CIM_PhysicalConnector" ) }
        ,  { typeof ( CIMSlot ) ,  ( "root/cimv2" ,  "CIM_Slot" ) }
        ,  { typeof ( Win32SystemSlot ) ,  ( "root/cimv2" ,  "Win32_SystemSlot" ) }
        ,  { typeof ( Win32PortConnector ) ,  ( "root/cimv2" ,  "Win32_PortConnector" ) }
        ,  { typeof ( CIMPhysicalLink ) ,  ( "root/cimv2" ,  "CIM_PhysicalLink" ) }
        ,  { typeof ( CIMLogicalElement ) ,  ( "root/cimv2" ,  "CIM_LogicalElement" ) }
        ,  { typeof ( CIMOperatingSystem ) ,  ( "root/cimv2" ,  "CIM_OperatingSystem" ) }
        ,  { typeof ( Win32OperatingSystem ) ,  ( "root/cimv2" ,  "Win32_OperatingSystem" ) }
        ,  { typeof ( CIMProcess ) ,  ( "root/cimv2" ,  "CIM_Process" ) }
        ,  { typeof ( Win32Process ) ,  ( "root/cimv2" ,  "Win32_Process" ) }
        ,  { typeof ( CIMLogicalDevice ) ,  ( "root/cimv2" ,  "CIM_LogicalDevice" ) }
        ,  { typeof ( CIMStorageExtent ) ,  ( "root/cimv2" ,  "CIM_StorageExtent" ) }
        ,  { typeof ( CIMLogicalDisk ) ,  ( "root/cimv2" ,  "CIM_LogicalDisk" ) }
        ,  { typeof ( Win32LogicalDisk ) ,  ( "root/cimv2" ,  "Win32_LogicalDisk" ) }
        ,  { typeof ( Win32MappedLogicalDisk ) ,  ( "root/cimv2" ,  "Win32_MappedLogicalDisk" ) }
        ,  { typeof ( CIMDiskPartition ) ,  ( "root/cimv2" ,  "CIM_DiskPartition" ) }
        ,  { typeof ( Win32DiskPartition ) ,  ( "root/cimv2" ,  "Win32_DiskPartition" ) }
        ,  { typeof ( CIMMemory ) ,  ( "root/cimv2" ,  "CIM_Memory" ) }
        ,  { typeof ( CIMVolatileStorage ) ,  ( "root/cimv2" ,  "CIM_VolatileStorage" ) }
        ,  { typeof ( CIMNonVolatileStorage ) ,  ( "root/cimv2" ,  "CIM_NonVolatileStorage" ) }
        ,  { typeof ( CIMCacheMemory ) ,  ( "root/cimv2" ,  "CIM_CacheMemory" ) }
        ,  { typeof ( Win32CacheMemory ) ,  ( "root/cimv2" ,  "Win32_CacheMemory" ) }
        ,  { typeof ( CIMStorageVolume ) ,  ( "root/cimv2" ,  "CIM_StorageVolume" ) }
        ,  { typeof ( Win32Volume ) ,  ( "root/cimv2" ,  "Win32_Volume" ) }
        ,  { typeof ( CIMPhysicalExtent ) ,  ( "root/cimv2" ,  "CIM_PhysicalExtent" ) }
        ,  { typeof ( Win32SMBIOSMemory ) ,  ( "root/cimv2" ,  "Win32_SMBIOSMemory" ) }
        ,  { typeof ( Win32MemoryArray ) ,  ( "root/cimv2" ,  "Win32_MemoryArray" ) }
        ,  { typeof ( Win32MemoryDevice ) ,  ( "root/cimv2" ,  "Win32_MemoryDevice" ) }
        ,  { typeof ( CIMProtectedSpaceExtent ) ,  ( "root/cimv2" ,  "CIM_ProtectedSpaceExtent" ) }
        ,  { typeof ( CIMAggregatePSExtent ) ,  ( "root/cimv2" ,  "CIM_AggregatePSExtent" ) }
        ,  { typeof ( CIMAggregatePExtent ) ,  ( "root/cimv2" ,  "CIM_AggregatePExtent" ) }
        ,  { typeof ( CIMVolumeSet ) ,  ( "root/cimv2" ,  "CIM_VolumeSet" ) }
        ,  { typeof ( CIMMediaAccessDevice ) ,  ( "root/cimv2" ,  "CIM_MediaAccessDevice" ) }
        ,  { typeof ( CIMDiskDrive ) ,  ( "root/cimv2" ,  "CIM_DiskDrive" ) }
        ,  { typeof ( Win32DiskDrive ) ,  ( "root/cimv2" ,  "Win32_DiskDrive" ) }
        ,  { typeof ( CIMDisketteDrive ) ,  ( "root/cimv2" ,  "CIM_DisketteDrive" ) }
        ,  { typeof ( CIMTapeDrive ) ,  ( "root/cimv2" ,  "CIM_TapeDrive" ) }
        ,  { typeof ( Win32TapeDrive ) ,  ( "root/cimv2" ,  "Win32_TapeDrive" ) }
        ,  { typeof ( CIMMagnetoOpticalDrive ) ,  ( "root/cimv2" ,  "CIM_MagnetoOpticalDrive" ) }
        ,  { typeof ( CIMCDROMDrive ) ,  ( "root/cimv2" ,  "CIM_CDROMDrive" ) }
        ,  { typeof ( Win32CDROMDrive ) ,  ( "root/cimv2" ,  "Win32_CDROMDrive" ) }
        ,  { typeof ( CIMWORMDrive ) ,  ( "root/cimv2" ,  "CIM_WORMDrive" ) }
        ,  { typeof ( Win32PnPEntity ) ,  ( "root/cimv2" ,  "Win32_PnPEntity" ) }
        ,  { typeof ( CIMController ) ,  ( "root/cimv2" ,  "CIM_Controller" ) }
        ,  { typeof ( Win321394Controller ) ,  ( "root/cimv2" ,  "Win32_1394Controller" ) }
        ,  { typeof ( CIMVideoController ) ,  ( "root/cimv2" ,  "CIM_VideoController" ) }
        ,  { typeof ( CIMPCVideoController ) ,  ( "root/cimv2" ,  "CIM_PCVideoController" ) }
        ,  { typeof ( Win32VideoController ) ,  ( "root/cimv2" ,  "Win32_VideoController" ) }
        ,  { typeof ( CIMManagementController ) ,  ( "root/cimv2" ,  "CIM_ManagementController" ) }
        ,  { typeof ( CIMSCSIController ) ,  ( "root/cimv2" ,  "CIM_SCSIController" ) }
        ,  { typeof ( Win32SCSIController ) ,  ( "root/cimv2" ,  "Win32_SCSIController" ) }
        ,  { typeof ( CIMInfraredController ) ,  ( "root/cimv2" ,  "CIM_InfraredController" ) }
        ,  { typeof ( Win32InfraredDevice ) ,  ( "root/cimv2" ,  "Win32_InfraredDevice" ) }
        ,  { typeof ( CIMPCIController ) ,  ( "root/cimv2" ,  "CIM_PCIController" ) }
        ,  { typeof ( CIMPCMCIAController ) ,  ( "root/cimv2" ,  "CIM_PCMCIAController" ) }
        ,  { typeof ( Win32PCMCIAController ) ,  ( "root/cimv2" ,  "Win32_PCMCIAController" ) }
        ,  { typeof ( CIMUSBController ) ,  ( "root/cimv2" ,  "CIM_USBController" ) }
        ,  { typeof ( Win32USBController ) ,  ( "root/cimv2" ,  "Win32_USBController" ) }
        ,  { typeof ( CIMSerialController ) ,  ( "root/cimv2" ,  "CIM_SerialController" ) }
        ,  { typeof ( Win32SerialPort ) ,  ( "root/cimv2" ,  "Win32_SerialPort" ) }
        ,  { typeof ( CIMParallelController ) ,  ( "root/cimv2" ,  "CIM_ParallelController" ) }
        ,  { typeof ( Win32ParallelPort ) ,  ( "root/cimv2" ,  "Win32_ParallelPort" ) }
        ,  { typeof ( Win32IDEController ) ,  ( "root/cimv2" ,  "Win32_IDEController" ) }
        ,  { typeof ( CIMProcessor ) ,  ( "root/cimv2" ,  "CIM_Processor" ) }
        ,  { typeof ( Win32Processor ) ,  ( "root/cimv2" ,  "Win32_Processor" ) }
        ,  { typeof ( CIMBattery ) ,  ( "root/cimv2" ,  "CIM_Battery" ) }
        ,  { typeof ( Win32Battery ) ,  ( "root/cimv2" ,  "Win32_Battery" ) }
        ,  { typeof ( Win32PortableBattery ) ,  ( "root/cimv2" ,  "Win32_PortableBattery" ) }
        ,  { typeof ( CIMNetworkAdapter ) ,  ( "root/cimv2" ,  "CIM_NetworkAdapter" ) }
        ,  { typeof ( Win32NetworkAdapter ) ,  ( "root/cimv2" ,  "Win32_NetworkAdapter" ) }
        ,  { typeof ( CIMPrinter ) ,  ( "root/cimv2" ,  "CIM_Printer" ) }
        ,  { typeof ( Win32Printer ) ,  ( "root/cimv2" ,  "Win32_Printer" ) }
        ,  { typeof ( CIMSensor ) ,  ( "root/cimv2" ,  "CIM_Sensor" ) }
        ,  { typeof ( CIMBinarySensor ) ,  ( "root/cimv2" ,  "CIM_BinarySensor" ) }
        ,  { typeof ( CIMMultiStateSensor ) ,  ( "root/cimv2" ,  "CIM_MultiStateSensor" ) }
        ,  { typeof ( CIMDiscreteSensor ) ,  ( "root/cimv2" ,  "CIM_DiscreteSensor" ) }
        ,  { typeof ( CIMNumericSensor ) ,  ( "root/cimv2" ,  "CIM_NumericSensor" ) }
        ,  { typeof ( CIMTemperatureSensor ) ,  ( "root/cimv2" ,  "CIM_TemperatureSensor" ) }
        ,  { typeof ( Win32TemperatureProbe ) ,  ( "root/cimv2" ,  "Win32_TemperatureProbe" ) }
        ,  { typeof ( CIMTachometer ) ,  ( "root/cimv2" ,  "CIM_Tachometer" ) }
        ,  { typeof ( CIMVoltageSensor ) ,  ( "root/cimv2" ,  "CIM_VoltageSensor" ) }
        ,  { typeof ( Win32VoltageProbe ) ,  ( "root/cimv2" ,  "Win32_VoltageProbe" ) }
        ,  { typeof ( CIMCurrentSensor ) ,  ( "root/cimv2" ,  "CIM_CurrentSensor" ) }
        ,  { typeof ( Win32CurrentProbe ) ,  ( "root/cimv2" ,  "Win32_CurrentProbe" ) }
        ,  { typeof ( Win32Bus ) ,  ( "root/cimv2" ,  "Win32_Bus" ) }
        ,  { typeof ( CIMUserDevice ) ,  ( "root/cimv2" ,  "CIM_UserDevice" ) }
        ,  { typeof ( CIMKeyboard ) ,  ( "root/cimv2" ,  "CIM_Keyboard" ) }
        ,  { typeof ( Win32Keyboard ) ,  ( "root/cimv2" ,  "Win32_Keyboard" ) }
        ,  { typeof ( CIMDisplay ) ,  ( "root/cimv2" ,  "CIM_Display" ) }
        ,  { typeof ( CIMFlatPanel ) ,  ( "root/cimv2" ,  "CIM_FlatPanel" ) }
        ,  { typeof ( CIMDesktopMonitor ) ,  ( "root/cimv2" ,  "CIM_DesktopMonitor" ) }
        ,  { typeof ( Win32DesktopMonitor ) ,  ( "root/cimv2" ,  "Win32_DesktopMonitor" ) }
        ,  { typeof ( CIMPointingDevice ) ,  ( "root/cimv2" ,  "CIM_PointingDevice" ) }
        ,  { typeof ( Win32PointingDevice ) ,  ( "root/cimv2" ,  "Win32_PointingDevice" ) }
        ,  { typeof ( CIMUSBDevice ) ,  ( "root/cimv2" ,  "CIM_USBDevice" ) }
        ,  { typeof ( CIMUSBHub ) ,  ( "root/cimv2" ,  "CIM_USBHub" ) }
        ,  { typeof ( Win32USBHub ) ,  ( "root/cimv2" ,  "Win32_USBHub" ) }
        ,  { typeof ( CIMAlarmDevice ) ,  ( "root/cimv2" ,  "CIM_AlarmDevice" ) }
        ,  { typeof ( Win32SoundDevice ) ,  ( "root/cimv2" ,  "Win32_SoundDevice" ) }
        ,  { typeof ( Win32MotherboardDevice ) ,  ( "root/cimv2" ,  "Win32_MotherboardDevice" ) }
        ,  { typeof ( CIMPowerSupply ) ,  ( "root/cimv2" ,  "CIM_PowerSupply" ) }
        ,  { typeof ( CIMUninterruptiblePowerSupply ) ,  ( "root/cimv2" ,  "CIM_UninterruptiblePowerSupply" ) }
        ,  { typeof ( CIMScanner ) ,  ( "root/cimv2" ,  "CIM_Scanner" ) }
        ,  { typeof ( CIMPotsModem ) ,  ( "root/cimv2" ,  "CIM_PotsModem" ) }
        ,  { typeof ( Win32POTSModem ) ,  ( "root/cimv2" ,  "Win32_POTSModem" ) }
        ,  { typeof ( CIMCoolingDevice ) ,  ( "root/cimv2" ,  "CIM_CoolingDevice" ) }
        ,  { typeof ( CIMHeatPipe ) ,  ( "root/cimv2" ,  "CIM_HeatPipe" ) }
        ,  { typeof ( Win32HeatPipe ) ,  ( "root/cimv2" ,  "Win32_HeatPipe" ) }
        ,  { typeof ( CIMRefrigeration ) ,  ( "root/cimv2" ,  "CIM_Refrigeration" ) }
        ,  { typeof ( Win32Refrigeration ) ,  ( "root/cimv2" ,  "Win32_Refrigeration" ) }
        ,  { typeof ( CIMFan ) ,  ( "root/cimv2" ,  "CIM_Fan" ) }
        ,  { typeof ( Win32Fan ) ,  ( "root/cimv2" ,  "Win32_Fan" ) }
        ,  { typeof ( CIMSystem ) ,  ( "root/cimv2" ,  "CIM_System" ) }
        ,  { typeof ( CIMComputerSystem ) ,  ( "root/cimv2" ,  "CIM_ComputerSystem" ) }
        ,  { typeof ( CIMUnitaryComputerSystem ) ,  ( "root/cimv2" ,  "CIM_UnitaryComputerSystem" ) }
        ,  { typeof ( Win32ComputerSystem ) ,  ( "root/cimv2" ,  "Win32_ComputerSystem" ) }
        ,  { typeof ( CIMApplicationSystem ) ,  ( "root/cimv2" ,  "CIM_ApplicationSystem" ) }
        ,  { typeof ( Win32NTDomain ) ,  ( "root/cimv2" ,  "Win32_NTDomain" ) }
        ,  { typeof ( Win32OptionalFeature ) ,  ( "root/cimv2" ,  "Win32_OptionalFeature" ) }
        ,  { typeof ( CIMSoftwareElement ) ,  ( "root/cimv2" ,  "CIM_SoftwareElement" ) }
        ,  { typeof ( CIMBIOSElement ) ,  ( "root/cimv2" ,  "CIM_BIOSElement" ) }
        ,  { typeof ( Win32BIOS ) ,  ( "root/cimv2" ,  "Win32_BIOS" ) }
        ,  { typeof ( Win32SoftwareElement ) ,  ( "root/cimv2" ,  "Win32_SoftwareElement" ) }
        ,  { typeof ( CIMVideoBIOSElement ) ,  ( "root/cimv2" ,  "CIM_VideoBIOSElement" ) }
        ,  { typeof ( CIMService ) ,  ( "root/cimv2" ,  "CIM_Service" ) }
        ,  { typeof ( Win32BaseService ) ,  ( "root/cimv2" ,  "Win32_BaseService" ) }
        ,  { typeof ( Win32Service ) ,  ( "root/cimv2" ,  "Win32_Service" ) }
        ,  { typeof ( Win32TerminalService ) ,  ( "root/cimv2" ,  "Win32_TerminalService" ) }
        ,  { typeof ( Win32SystemDriver ) ,  ( "root/cimv2" ,  "Win32_SystemDriver" ) }
        ,  { typeof ( Win32PnPSignedDriver ) ,  ( "root/cimv2" ,  "Win32_PnPSignedDriver" ) }
        ,  { typeof ( CIMBootService ) ,  ( "root/cimv2" ,  "CIM_BootService" ) }
        ,  { typeof ( CIMClusteringService ) ,  ( "root/cimv2" ,  "CIM_ClusteringService" ) }
        ,  { typeof ( Win32ApplicationService ) ,  ( "root/cimv2" ,  "Win32_ApplicationService" ) }
        ,  { typeof ( Win32PrinterDriver ) ,  ( "root/cimv2" ,  "Win32_PrinterDriver" ) }
        ,  { typeof ( Win32QuickFixEngineering ) ,  ( "root/cimv2" ,  "Win32_QuickFixEngineering" ) }
        ,  { typeof ( CIMThread ) ,  ( "root/cimv2" ,  "CIM_Thread" ) }
        ,  { typeof ( Win32Thread ) ,  ( "root/cimv2" ,  "Win32_Thread" ) }
        ,  { typeof ( Win32COMApplication ) ,  ( "root/cimv2" ,  "Win32_COMApplication" ) }
        ,  { typeof ( Win32DCOMApplication ) ,  ( "root/cimv2" ,  "Win32_DCOMApplication" ) }
        ,  { typeof ( CIMJob ) ,  ( "root/cimv2" ,  "CIM_Job" ) }
        ,  { typeof ( Win32ScheduledJob ) ,  ( "root/cimv2" ,  "Win32_ScheduledJob" ) }
        ,  { typeof ( Win32PrintJob ) ,  ( "root/cimv2" ,  "Win32_PrintJob" ) }
        ,  { typeof ( Win32ServerSession ) ,  ( "root/cimv2" ,  "Win32_ServerSession" ) }
        ,  { typeof ( CIMSoftwareFeature ) ,  ( "root/cimv2" ,  "CIM_SoftwareFeature" ) }
        ,  { typeof ( Win32SoftwareFeature ) ,  ( "root/cimv2" ,  "Win32_SoftwareFeature" ) }
        ,  { typeof ( CIMVideoBIOSFeature ) ,  ( "root/cimv2" ,  "CIM_VideoBIOSFeature" ) }
        ,  { typeof ( CIMBIOSFeature ) ,  ( "root/cimv2" ,  "CIM_BIOSFeature" ) }
        ,  { typeof ( Win32DfsNode ) ,  ( "root/cimv2" ,  "Win32_DfsNode" ) }
        ,  { typeof ( Win32ComponentCategory ) ,  ( "root/cimv2" ,  "Win32_ComponentCategory" ) }
        ,  { typeof ( Win32ProgramGroupOrItem ) ,  ( "root/cimv2" ,  "Win32_ProgramGroupOrItem" ) }
        ,  { typeof ( Win32LogicalProgramGroupItem ) ,  ( "root/cimv2" ,  "Win32_LogicalProgramGroupItem" ) }
        ,  { typeof ( Win32LogicalProgramGroup ) ,  ( "root/cimv2" ,  "Win32_LogicalProgramGroup" ) }
        ,  { typeof ( Win32NetworkConnection ) ,  ( "root/cimv2" ,  "Win32_NetworkConnection" ) }
        ,  { typeof ( Win32COMClass ) ,  ( "root/cimv2" ,  "Win32_COMClass" ) }
        ,  { typeof ( Win32ClassicCOMClass ) ,  ( "root/cimv2" ,  "Win32_ClassicCOMClass" ) }
        ,  { typeof ( Win32Account ) ,  ( "root/cimv2" ,  "Win32_Account" ) }
        ,  { typeof ( Win32UserAccount ) ,  ( "root/cimv2" ,  "Win32_UserAccount" ) }
        ,  { typeof ( Win32Group ) ,  ( "root/cimv2" ,  "Win32_Group" ) }
        ,  { typeof ( Win32SystemAccount ) ,  ( "root/cimv2" ,  "Win32_SystemAccount" ) }
        ,  { typeof ( CIMServiceAccessPoint ) ,  ( "root/cimv2" ,  "CIM_ServiceAccessPoint" ) }
        ,  { typeof ( Win32TCPIPPrinterPort ) ,  ( "root/cimv2" ,  "Win32_TCPIPPrinterPort" ) }
        ,  { typeof ( CIMClusteringSAP ) ,  ( "root/cimv2" ,  "CIM_ClusteringSAP" ) }
        ,  { typeof ( CIMBootSAP ) ,  ( "root/cimv2" ,  "CIM_BootSAP" ) }
        ,  { typeof ( Win32CommandLineAccess ) ,  ( "root/cimv2" ,  "Win32_CommandLineAccess" ) }
        ,  { typeof ( CIMSystemResource ) ,  ( "root/cimv2" ,  "CIM_SystemResource" ) }
        ,  { typeof ( CIMMemoryMappedIO ) ,  ( "root/cimv2" ,  "CIM_MemoryMappedIO" ) }
        ,  { typeof ( Win32SystemMemoryResource ) ,  ( "root/cimv2" ,  "Win32_SystemMemoryResource" ) }
        ,  { typeof ( Win32PortResource ) ,  ( "root/cimv2" ,  "Win32_PortResource" ) }
        ,  { typeof ( Win32DeviceMemoryAddress ) ,  ( "root/cimv2" ,  "Win32_DeviceMemoryAddress" ) }
        ,  { typeof ( CIMIRQ ) ,  ( "root/cimv2" ,  "CIM_IRQ" ) }
        ,  { typeof ( Win32IRQResource ) ,  ( "root/cimv2" ,  "Win32_IRQResource" ) }
        ,  { typeof ( Win32Environment ) ,  ( "root/cimv2" ,  "Win32_Environment" ) }
        ,  { typeof ( CIMDMA ) ,  ( "root/cimv2" ,  "CIM_DMA" ) }
        ,  { typeof ( Win32DMAChannel ) ,  ( "root/cimv2" ,  "Win32_DMAChannel" ) }
        ,  { typeof ( Win32Share ) ,  ( "root/cimv2" ,  "Win32_Share" ) }
        ,  { typeof ( Win32ClusterShare ) ,  ( "root/cimv2" ,  "Win32_ClusterShare" ) }
        ,  { typeof ( CIMFileSystem ) ,  ( "root/cimv2" ,  "CIM_FileSystem" ) }
        ,  { typeof ( CIMRemoteFileSystem ) ,  ( "root/cimv2" ,  "CIM_RemoteFileSystem" ) }
        ,  { typeof ( CIMNFS ) ,  ( "root/cimv2" ,  "CIM_NFS" ) }
        ,  { typeof ( CIMLocalFileSystem ) ,  ( "root/cimv2" ,  "CIM_LocalFileSystem" ) }
        ,  { typeof ( Win32NetworkProtocol ) ,  ( "root/cimv2" ,  "Win32_NetworkProtocol" ) }
        ,  { typeof ( Win32ShadowProvider ) ,  ( "root/cimv2" ,  "Win32_ShadowProvider" ) }
        ,  { typeof ( CIMRedundancyGroup ) ,  ( "root/cimv2" ,  "CIM_RedundancyGroup" ) }
        ,  { typeof ( CIMExtraCapacityGroup ) ,  ( "root/cimv2" ,  "CIM_ExtraCapacityGroup" ) }
        ,  { typeof ( CIMStorageRedundancyGroup ) ,  ( "root/cimv2" ,  "CIM_StorageRedundancyGroup" ) }
        ,  { typeof ( CIMSpareGroup ) ,  ( "root/cimv2" ,  "CIM_SpareGroup" ) }
        ,  { typeof ( Win32IP4RouteTable ) ,  ( "root/cimv2" ,  "Win32_IP4RouteTable" ) }
        ,  { typeof ( Win32ShadowCopy ) ,  ( "root/cimv2" ,  "Win32_ShadowCopy" ) }
        ,  { typeof ( Win32LoadOrderGroup ) ,  ( "root/cimv2" ,  "Win32_LoadOrderGroup" ) }
        ,  { typeof ( Win32Session ) ,  ( "root/cimv2" ,  "Win32_Session" ) }
        ,  { typeof ( Win32LogonSession ) ,  ( "root/cimv2" ,  "Win32_LogonSession" ) }
        ,  { typeof ( Win32ServerConnection ) ,  ( "root/cimv2" ,  "Win32_ServerConnection" ) }
        ,  { typeof ( CIMJobDestination ) ,  ( "root/cimv2" ,  "CIM_JobDestination" ) }
        ,  { typeof ( Win32DfsTarget ) ,  ( "root/cimv2" ,  "Win32_DfsTarget" ) }
        ,  { typeof ( Win32NetworkClient ) ,  ( "root/cimv2" ,  "Win32_NetworkClient" ) }
        ,  { typeof ( Win32PageFileUsage ) ,  ( "root/cimv2" ,  "Win32_PageFileUsage" ) }
        ,  { typeof ( CIMLogicalFile ) ,  ( "root/cimv2" ,  "CIM_LogicalFile" ) }
        ,  { typeof ( CIMDirectory ) ,  ( "root/cimv2" ,  "CIM_Directory" ) }
        ,  { typeof ( Win32Directory ) ,  ( "root/cimv2" ,  "Win32_Directory" ) }
        ,  { typeof ( CIMDeviceFile ) ,  ( "root/cimv2" ,  "CIM_DeviceFile" ) }
        ,  { typeof ( CIMDataFile ) ,  ( "root/cimv2" ,  "CIM_DataFile" ) }
        ,  { typeof ( Win32ShortcutFile ) ,  ( "root/cimv2" ,  "Win32_ShortcutFile" ) }
        ,  { typeof ( Win32CodecFile ) ,  ( "root/cimv2" ,  "Win32_CodecFile" ) }
        ,  { typeof ( Win32NTEventlogFile ) ,  ( "root/cimv2" ,  "Win32_NTEventlogFile" ) }
        ,  { typeof ( Win32PageFile ) ,  ( "root/cimv2" ,  "Win32_PageFile" ) }
        ,  { typeof ( Win32IP4PersistedRouteTable ) ,  ( "root/cimv2" ,  "Win32_IP4PersistedRouteTable" ) }
        ,  { typeof ( Win32Registry ) ,  ( "root/cimv2" ,  "Win32_Registry" ) }
        ,  { typeof ( CIMComponent ) ,  ( "root/cimv2" ,  "CIM_Component" ) }
        ,  { typeof ( Win32LogicalDiskRootDirectory ) ,  ( "root/cimv2" ,  "Win32_LogicalDiskRootDirectory" ) }
        ,  { typeof ( CIMSystemComponent ) ,  ( "root/cimv2" ,  "CIM_SystemComponent" ) }
        ,  { typeof ( CIMSystemDevice ) ,  ( "root/cimv2" ,  "CIM_SystemDevice" ) }
        ,  { typeof ( Win32SystemDevices ) ,  ( "root/cimv2" ,  "Win32_SystemDevices" ) }
        ,  { typeof ( Win32SystemPartitions ) ,  ( "root/cimv2" ,  "Win32_SystemPartitions" ) }
        ,  { typeof ( Win32ComputerSystemProcessor ) ,  ( "root/cimv2" ,  "Win32_ComputerSystemProcessor" ) }
        ,  { typeof ( Win32SystemServices ) ,  ( "root/cimv2" ,  "Win32_SystemServices" ) }
        ,  { typeof ( Win32SystemNetworkConnections ) ,  ( "root/cimv2" ,  "Win32_SystemNetworkConnections" ) }
        ,  { typeof ( CIMHostedFileSystem ) ,  ( "root/cimv2" ,  "CIM_HostedFileSystem" ) }
        ,  { typeof ( CIMComputerSystemResource ) ,  ( "root/cimv2" ,  "CIM_ComputerSystemResource" ) }
        ,  { typeof ( Win32SystemResources ) ,  ( "root/cimv2" ,  "Win32_SystemResources" ) }
        ,  { typeof ( CIMComputerSystemMappedIO ) ,  ( "root/cimv2" ,  "CIM_ComputerSystemMappedIO" ) }
        ,  { typeof ( CIMComputerSystemDMA ) ,  ( "root/cimv2" ,  "CIM_ComputerSystemDMA" ) }
        ,  { typeof ( CIMComputerSystemIRQ ) ,  ( "root/cimv2" ,  "CIM_ComputerSystemIRQ" ) }
        ,  { typeof ( Win32SystemBIOS ) ,  ( "root/cimv2" ,  "Win32_SystemBIOS" ) }
        ,  { typeof ( Win32SystemLoadOrderGroups ) ,  ( "root/cimv2" ,  "Win32_SystemLoadOrderGroups" ) }
        ,  { typeof ( Win32SystemUsers ) ,  ( "root/cimv2" ,  "Win32_SystemUsers" ) }
        ,  { typeof ( CIMInstalledOS ) ,  ( "root/cimv2" ,  "CIM_InstalledOS" ) }
        ,  { typeof ( Win32SystemOperatingSystem ) ,  ( "root/cimv2" ,  "Win32_SystemOperatingSystem" ) }
        ,  { typeof ( Win32SystemSystemDriver ) ,  ( "root/cimv2" ,  "Win32_SystemSystemDriver" ) }
        ,  { typeof ( CIMApplicationSystemSoftwareFeature ) ,  ( "root/cimv2" ,  "CIM_ApplicationSystemSoftwareFeature" ) }
        ,  { typeof ( Win32SystemProcesses ) ,  ( "root/cimv2" ,  "Win32_SystemProcesses" ) }
        ,  { typeof ( CIMRedundancyComponent ) ,  ( "root/cimv2" ,  "CIM_RedundancyComponent" ) }
        ,  { typeof ( CIMAggregateRedundancyComponent ) ,  ( "root/cimv2" ,  "CIM_AggregateRedundancyComponent" ) }
        ,  { typeof ( CIMPExtentRedundancyComponent ) ,  ( "root/cimv2" ,  "CIM_PExtentRedundancyComponent" ) }
        ,  { typeof ( CIMLinkHasConnector ) ,  ( "root/cimv2" ,  "CIM_LinkHasConnector" ) }
        ,  { typeof ( CIMCollectionOfSensors ) ,  ( "root/cimv2" ,  "CIM_CollectionOfSensors" ) }
        ,  { typeof ( CIMProcessThread ) ,  ( "root/cimv2" ,  "CIM_ProcessThread" ) }
        ,  { typeof ( Win32COMApplicationClasses ) ,  ( "root/cimv2" ,  "Win32_COMApplicationClasses" ) }
        ,  { typeof ( Win32ClassicCOMApplicationClasses ) ,  ( "root/cimv2" ,  "Win32_ClassicCOMApplicationClasses" ) }
        ,  { typeof ( CIMDirectoryContainsFile ) ,  ( "root/cimv2" ,  "CIM_DirectoryContainsFile" ) }
        ,  { typeof ( CIMFileStorage ) ,  ( "root/cimv2" ,  "CIM_FileStorage" ) }
        ,  { typeof ( Win32UserInDomain ) ,  ( "root/cimv2" ,  "Win32_UserInDomain" ) }
        ,  { typeof ( Win32LoadOrderGroupServiceMembers ) ,  ( "root/cimv2" ,  "Win32_LoadOrderGroupServiceMembers" ) }
        ,  { typeof ( CIMOperatingSystemSoftwareFeature ) ,  ( "root/cimv2" ,  "CIM_OperatingSystemSoftwareFeature" ) }
        ,  { typeof ( CIMSoftwareFeatureSoftwareElements ) ,  ( "root/cimv2" ,  "CIM_SoftwareFeatureSoftwareElements" ) }
        ,  { typeof ( Win32SoftwareFeatureSoftwareElements ) ,  ( "root/cimv2" ,  "Win32_SoftwareFeatureSoftwareElements" ) }
        ,  { typeof ( CIMVideoBIOSFeatureVideoBIOSElements ) ,  ( "root/cimv2" ,  "CIM_VideoBIOSFeatureVideoBIOSElements" ) }
        ,  { typeof ( CIMBIOSFeatureBIOSElements ) ,  ( "root/cimv2" ,  "CIM_BIOSFeatureBIOSElements" ) }
        ,  { typeof ( Win32MemoryDeviceArray ) ,  ( "root/cimv2" ,  "Win32_MemoryDeviceArray" ) }
        ,  { typeof ( Win32GroupInDomain ) ,  ( "root/cimv2" ,  "Win32_GroupInDomain" ) }
        ,  { typeof ( CIMOSProcess ) ,  ( "root/cimv2" ,  "CIM_OSProcess" ) }
        ,  { typeof ( Win32GroupUser ) ,  ( "root/cimv2" ,  "Win32_GroupUser" ) }
        ,  { typeof ( Win32ProgramGroupContents ) ,  ( "root/cimv2" ,  "Win32_ProgramGroupContents" ) }
        ,  { typeof ( Win32SubDirectory ) ,  ( "root/cimv2" ,  "Win32_SubDirectory" ) }
        ,  { typeof ( CIMContainer ) ,  ( "root/cimv2" ,  "CIM_Container" ) }
        ,  { typeof ( CIMConnectorOnPackage ) ,  ( "root/cimv2" ,  "CIM_ConnectorOnPackage" ) }
        ,  { typeof ( CIMPackageInChassis ) ,  ( "root/cimv2" ,  "CIM_PackageInChassis" ) }
        ,  { typeof ( CIMChassisInRack ) ,  ( "root/cimv2" ,  "CIM_ChassisInRack" ) }
        ,  { typeof ( CIMPackagedComponent ) ,  ( "root/cimv2" ,  "CIM_PackagedComponent" ) }
        ,  { typeof ( CIMMemoryOnCard ) ,  ( "root/cimv2" ,  "CIM_MemoryOnCard" ) }
        ,  { typeof ( Win32PhysicalMemoryLocation ) ,  ( "root/cimv2" ,  "Win32_PhysicalMemoryLocation" ) }
        ,  { typeof ( CIMCardOnCard ) ,  ( "root/cimv2" ,  "CIM_CardOnCard" ) }
        ,  { typeof ( CIMDependency ) ,  ( "root/cimv2" ,  "CIM_Dependency" ) }
        ,  { typeof ( CIMBasedOn ) ,  ( "root/cimv2" ,  "CIM_BasedOn" ) }
        ,  { typeof ( CIMLogicalDiskBasedOnPartition ) ,  ( "root/cimv2" ,  "CIM_LogicalDiskBasedOnPartition" ) }
        ,  { typeof ( Win32LogicalDiskToPartition ) ,  ( "root/cimv2" ,  "Win32_LogicalDiskToPartition" ) }
        ,  { typeof ( CIMLogicalDiskBasedOnVolumeSet ) ,  ( "root/cimv2" ,  "CIM_LogicalDiskBasedOnVolumeSet" ) }
        ,  { typeof ( CIMPSExtentBasedOnPExtent ) ,  ( "root/cimv2" ,  "CIM_PSExtentBasedOnPExtent" ) }
        ,  { typeof ( CIMResidesOnExtent ) ,  ( "root/cimv2" ,  "CIM_ResidesOnExtent" ) }
        ,  { typeof ( CIMMediaPresent ) ,  ( "root/cimv2" ,  "CIM_MediaPresent" ) }
        ,  { typeof ( Win32DiskDriveToDiskPartition ) ,  ( "root/cimv2" ,  "Win32_DiskDriveToDiskPartition" ) }
        ,  { typeof ( CIMAssociatedCooling ) ,  ( "root/cimv2" ,  "CIM_AssociatedCooling" ) }
        ,  { typeof ( Win32DeviceBus ) ,  ( "root/cimv2" ,  "Win32_DeviceBus" ) }
        ,  { typeof ( CIMDeviceConnection ) ,  ( "root/cimv2" ,  "CIM_DeviceConnection" ) }
        ,  { typeof ( CIMControlledBy ) ,  ( "root/cimv2" ,  "CIM_ControlledBy" ) }
        ,  { typeof ( Win32SCSIControllerDevice ) ,  ( "root/cimv2" ,  "Win32_SCSIControllerDevice" ) }
        ,  { typeof ( Win32USBControllerDevice ) ,  ( "root/cimv2" ,  "Win32_USBControllerDevice" ) }
        ,  { typeof ( CIMSCSIInterface ) ,  ( "root/cimv2" ,  "CIM_SCSIInterface" ) }
        ,  { typeof ( Win32IDEControllerDevice ) ,  ( "root/cimv2" ,  "Win32_IDEControllerDevice" ) }
        ,  { typeof ( CIMSerialInterface ) ,  ( "root/cimv2" ,  "CIM_SerialInterface" ) }
        ,  { typeof ( Win321394ControllerDevice ) ,  ( "root/cimv2" ,  "Win32_1394ControllerDevice" ) }
        ,  { typeof ( Win32POTSModemToSerialPort ) ,  ( "root/cimv2" ,  "Win32_POTSModemToSerialPort" ) }
        ,  { typeof ( Win32PrinterController ) ,  ( "root/cimv2" ,  "Win32_PrinterController" ) }
        ,  { typeof ( CIMUSBControllerHasHub ) ,  ( "root/cimv2" ,  "CIM_USBControllerHasHub" ) }
        ,  { typeof ( Win32ControllerHasHub ) ,  ( "root/cimv2" ,  "Win32_ControllerHasHub" ) }
        ,  { typeof ( CIMAssociatedAlarm ) ,  ( "root/cimv2" ,  "CIM_AssociatedAlarm" ) }
        ,  { typeof ( CIMDeviceSAPImplementation ) ,  ( "root/cimv2" ,  "CIM_DeviceSAPImplementation" ) }
        ,  { typeof ( CIMAssociatedSensor ) ,  ( "root/cimv2" ,  "CIM_AssociatedSensor" ) }
        ,  { typeof ( CIMAssociatedSupplyCurrentSensor ) ,  ( "root/cimv2" ,  "CIM_AssociatedSupplyCurrentSensor" ) }
        ,  { typeof ( CIMAssociatedSupplyVoltageSensor ) ,  ( "root/cimv2" ,  "CIM_AssociatedSupplyVoltageSensor" ) }
        ,  { typeof ( CIMDeviceAccessedByFile ) ,  ( "root/cimv2" ,  "CIM_DeviceAccessedByFile" ) }
        ,  { typeof ( CIMAssociatedMemory ) ,  ( "root/cimv2" ,  "CIM_AssociatedMemory" ) }
        ,  { typeof ( CIMAssociatedProcessorMemory ) ,  ( "root/cimv2" ,  "CIM_AssociatedProcessorMemory" ) }
        ,  { typeof ( Win32AssociatedProcessorMemory ) ,  ( "root/cimv2" ,  "Win32_AssociatedProcessorMemory" ) }
        ,  { typeof ( CIMDeviceServiceImplementation ) ,  ( "root/cimv2" ,  "CIM_DeviceServiceImplementation" ) }
        ,  { typeof ( CIMAssociatedBattery ) ,  ( "root/cimv2" ,  "CIM_AssociatedBattery" ) }
        ,  { typeof ( Win32CIMLogicalDeviceCIMDataFile ) ,  ( "root/cimv2" ,  "Win32_CIMLogicalDeviceCIMDataFile" ) }
        ,  { typeof ( CIMAllocatedResource ) ,  ( "root/cimv2" ,  "CIM_AllocatedResource" ) }
        ,  { typeof ( Win32PNPAllocatedResource ) ,  ( "root/cimv2" ,  "Win32_PNPAllocatedResource" ) }
        ,  { typeof ( CIMDeviceSoftware ) ,  ( "root/cimv2" ,  "CIM_DeviceSoftware" ) }
        ,  { typeof ( CIMRealizes ) ,  ( "root/cimv2" ,  "CIM_Realizes" ) }
        ,  { typeof ( CIMRealizesDiskPartition ) ,  ( "root/cimv2" ,  "CIM_RealizesDiskPartition" ) }
        ,  { typeof ( Win32DiskDrivePhysicalMedia ) ,  ( "root/cimv2" ,  "Win32_DiskDrivePhysicalMedia" ) }
        ,  { typeof ( CIMRealizesPExtent ) ,  ( "root/cimv2" ,  "CIM_RealizesPExtent" ) }
        ,  { typeof ( Win32MemoryDeviceLocation ) ,  ( "root/cimv2" ,  "Win32_MemoryDeviceLocation" ) }
        ,  { typeof ( Win32MemoryArrayLocation ) ,  ( "root/cimv2" ,  "Win32_MemoryArrayLocation" ) }
        ,  { typeof ( CIMRealizesAggregatePExtent ) ,  ( "root/cimv2" ,  "CIM_RealizesAggregatePExtent" ) }
        ,  { typeof ( Win32AllocatedResource ) ,  ( "root/cimv2" ,  "Win32_AllocatedResource" ) }
        ,  { typeof ( Win32PrinterDriverDll ) ,  ( "root/cimv2" ,  "Win32_PrinterDriverDll" ) }
        ,  { typeof ( CIMServiceAccessBySAP ) ,  ( "root/cimv2" ,  "CIM_ServiceAccessBySAP" ) }
        ,  { typeof ( CIMBootServiceAccessBySAP ) ,  ( "root/cimv2" ,  "CIM_BootServiceAccessBySAP" ) }
        ,  { typeof ( Win32ApplicationCommandLine ) ,  ( "root/cimv2" ,  "Win32_ApplicationCommandLine" ) }
        ,  { typeof ( CIMClusterServiceAccessBySAP ) ,  ( "root/cimv2" ,  "CIM_ClusterServiceAccessBySAP" ) }
        ,  { typeof ( Win32SubSession ) ,  ( "root/cimv2" ,  "Win32_SubSession" ) }
        ,  { typeof ( Win32ShadowVolumeSupport ) ,  ( "root/cimv2" ,  "Win32_ShadowVolumeSupport" ) }
        ,  { typeof ( CIMSAPSAPDependency ) ,  ( "root/cimv2" ,  "CIM_SAPSAPDependency" ) }
        ,  { typeof ( CIMPackageTempSensor ) ,  ( "root/cimv2" ,  "CIM_PackageTempSensor" ) }
        ,  { typeof ( CIMJobDestinationJobs ) ,  ( "root/cimv2" ,  "CIM_JobDestinationJobs" ) }
        ,  { typeof ( CIMBIOSLoadedInNV ) ,  ( "root/cimv2" ,  "CIM_BIOSLoadedInNV" ) }
        ,  { typeof ( Win32SessionConnection ) ,  ( "root/cimv2" ,  "Win32_SessionConnection" ) }
        ,  { typeof ( Win32ShadowFor ) ,  ( "root/cimv2" ,  "Win32_ShadowFor" ) }
        ,  { typeof ( Win32LogonSessionMappedDisk ) ,  ( "root/cimv2" ,  "Win32_LogonSessionMappedDisk" ) }
        ,  { typeof ( CIMConnectedTo ) ,  ( "root/cimv2" ,  "CIM_ConnectedTo" ) }
        ,  { typeof ( CIMSlotInSlot ) ,  ( "root/cimv2" ,  "CIM_SlotInSlot" ) }
        ,  { typeof ( Win32PrinterShare ) ,  ( "root/cimv2" ,  "Win32_PrinterShare" ) }
        ,  { typeof ( CIMBootOSFromFS ) ,  ( "root/cimv2" ,  "CIM_BootOSFromFS" ) }
        ,  { typeof ( Win32PnPSignedDriverCIMDataFile ) ,  ( "root/cimv2" ,  "Win32_PnPSignedDriverCIMDataFile" ) }
        ,  { typeof ( CIMElementsLinked ) ,  ( "root/cimv2" ,  "CIM_ElementsLinked" ) }
        ,  { typeof ( Win32ConnectionShare ) ,  ( "root/cimv2" ,  "Win32_ConnectionShare" ) }
        ,  { typeof ( Win32LoadOrderGroupServiceDependencies ) ,  ( "root/cimv2" ,  "Win32_LoadOrderGroupServiceDependencies" ) }
        ,  { typeof ( CIMMount ) ,  ( "root/cimv2" ,  "CIM_Mount" ) }
        ,  { typeof ( CIMComputerSystemPackage ) ,  ( "root/cimv2" ,  "CIM_ComputerSystemPackage" ) }
        ,  { typeof ( CIMPackageCooling ) ,  ( "root/cimv2" ,  "CIM_PackageCooling" ) }
        ,  { typeof ( CIMProcessExecutable ) ,  ( "root/cimv2" ,  "CIM_ProcessExecutable" ) }
        ,  { typeof ( CIMHostedService ) ,  ( "root/cimv2" ,  "CIM_HostedService" ) }
        ,  { typeof ( CIMHostedBootService ) ,  ( "root/cimv2" ,  "CIM_HostedBootService" ) }
        ,  { typeof ( Win32SessionResource ) ,  ( "root/cimv2" ,  "Win32_SessionResource" ) }
        ,  { typeof ( Win32SessionProcess ) ,  ( "root/cimv2" ,  "Win32_SessionProcess" ) }
        ,  { typeof ( Win32SoftwareFeatureParent ) ,  ( "root/cimv2" ,  "Win32_SoftwareFeatureParent" ) }
        ,  { typeof ( Win32ShadowOn ) ,  ( "root/cimv2" ,  "Win32_ShadowOn" ) }
        ,  { typeof ( CIMPackageInSlot ) ,  ( "root/cimv2" ,  "CIM_PackageInSlot" ) }
        ,  { typeof ( CIMCardInSlot ) ,  ( "root/cimv2" ,  "CIM_CardInSlot" ) }
        ,  { typeof ( CIMMemoryWithMedia ) ,  ( "root/cimv2" ,  "CIM_MemoryWithMedia" ) }
        ,  { typeof ( CIMServiceServiceDependency ) ,  ( "root/cimv2" ,  "CIM_ServiceServiceDependency" ) }
        ,  { typeof ( Win32DependentService ) ,  ( "root/cimv2" ,  "Win32_DependentService" ) }
        ,  { typeof ( Win32OperatingSystemQFE ) ,  ( "root/cimv2" ,  "Win32_OperatingSystemQFE" ) }
        ,  { typeof ( Win32LoggedOnUser ) ,  ( "root/cimv2" ,  "Win32_LoggedOnUser" ) }
        ,  { typeof ( CIMRunningOS ) ,  ( "root/cimv2" ,  "CIM_RunningOS" ) }
        ,  { typeof ( Win32SystemDriverPNPEntity ) ,  ( "root/cimv2" ,  "Win32_SystemDriverPNPEntity" ) }
        ,  { typeof ( CIMSoftwareFeatureServiceImplementation ) ,  ( "root/cimv2" ,  "CIM_SoftwareFeatureServiceImplementation" ) }
        ,  { typeof ( CIMServiceSAPDependency ) ,  ( "root/cimv2" ,  "CIM_ServiceSAPDependency" ) }
        ,  { typeof ( Win32DfsNodeTarget ) ,  ( "root/cimv2" ,  "Win32_DfsNodeTarget" ) }
        ,  { typeof ( Win32DriverForDevice ) ,  ( "root/cimv2" ,  "Win32_DriverForDevice" ) }
        ,  { typeof ( Win32LogicalProgramGroupItemDataFile ) ,  ( "root/cimv2" ,  "Win32_LogicalProgramGroupItemDataFile" ) }
        ,  { typeof ( CIMSoftwareFeatureSAPImplementation ) ,  ( "root/cimv2" ,  "CIM_SoftwareFeatureSAPImplementation" ) }
        ,  { typeof ( Win32ShadowBy ) ,  ( "root/cimv2" ,  "Win32_ShadowBy" ) }
        ,  { typeof ( CIMHostedAccessPoint ) ,  ( "root/cimv2" ,  "CIM_HostedAccessPoint" ) }
        ,  { typeof ( CIMHostedBootSAP ) ,  ( "root/cimv2" ,  "CIM_HostedBootSAP" ) }
        ,  { typeof ( CIMHostedJobDestination ) ,  ( "root/cimv2" ,  "CIM_HostedJobDestination" ) }
        ,  { typeof ( Win32LogicalProgramGroupDirectory ) ,  ( "root/cimv2" ,  "Win32_LogicalProgramGroupDirectory" ) }
        ,  { typeof ( Win32ShadowDiffVolumeSupport ) ,  ( "root/cimv2" ,  "Win32_ShadowDiffVolumeSupport" ) }
        ,  { typeof ( CIMPackageAlarm ) ,  ( "root/cimv2" ,  "CIM_PackageAlarm" ) }
        ,  { typeof ( CIMDocked ) ,  ( "root/cimv2" ,  "CIM_Docked" ) }
        ,  { typeof ( Win32DiskQuota ) ,  ( "root/cimv2" ,  "Win32_DiskQuota" ) }
        ,  { typeof ( CIMElementSetting ) ,  ( "root/cimv2" ,  "CIM_ElementSetting" ) }
        ,  { typeof ( Win32VolumeQuotaSetting ) ,  ( "root/cimv2" ,  "Win32_VolumeQuotaSetting" ) }
        ,  { typeof ( Win32DeviceSettings ) ,  ( "root/cimv2" ,  "Win32_DeviceSettings" ) }
        ,  { typeof ( Win32PrinterSetting ) ,  ( "root/cimv2" ,  "Win32_PrinterSetting" ) }
        ,  { typeof ( Win32NetworkAdapterSetting ) ,  ( "root/cimv2" ,  "Win32_NetworkAdapterSetting" ) }
        ,  { typeof ( Win32SerialPortSetting ) ,  ( "root/cimv2" ,  "Win32_SerialPortSetting" ) }
        ,  { typeof ( Win32SecuritySettingOfObject ) ,  ( "root/cimv2" ,  "Win32_SecuritySettingOfObject" ) }
        ,  { typeof ( Win32SecuritySettingOfLogicalShare ) ,  ( "root/cimv2" ,  "Win32_SecuritySettingOfLogicalShare" ) }
        ,  { typeof ( Win32SecuritySettingOfLogicalFile ) ,  ( "root/cimv2" ,  "Win32_SecuritySettingOfLogicalFile" ) }
        ,  { typeof ( Win32UserDesktop ) ,  ( "root/cimv2" ,  "Win32_UserDesktop" ) }
        ,  { typeof ( CIMMonitorSetting ) ,  ( "root/cimv2" ,  "CIM_MonitorSetting" ) }
        ,  { typeof ( Win32SystemSetting ) ,  ( "root/cimv2" ,  "Win32_SystemSetting" ) }
        ,  { typeof ( Win32SystemProgramGroups ) ,  ( "root/cimv2" ,  "Win32_SystemProgramGroups" ) }
        ,  { typeof ( Win32SystemBootConfiguration ) ,  ( "root/cimv2" ,  "Win32_SystemBootConfiguration" ) }
        ,  { typeof ( Win32SystemTimeZone ) ,  ( "root/cimv2" ,  "Win32_SystemTimeZone" ) }
        ,  { typeof ( Win32SystemDesktop ) ,  ( "root/cimv2" ,  "Win32_SystemDesktop" ) }
        ,  { typeof ( Win32ClassicCOMClassSettings ) ,  ( "root/cimv2" ,  "Win32_ClassicCOMClassSettings" ) }
        ,  { typeof ( Win32VolumeQuota ) ,  ( "root/cimv2" ,  "Win32_VolumeQuota" ) }
        ,  { typeof ( Win32WMIElementSetting ) ,  ( "root/cimv2" ,  "Win32_WMIElementSetting" ) }
        ,  { typeof ( Win32COMApplicationSettings ) ,  ( "root/cimv2" ,  "Win32_COMApplicationSettings" ) }
        ,  { typeof ( CIMVideoSetting ) ,  ( "root/cimv2" ,  "CIM_VideoSetting" ) }
        ,  { typeof ( Win32VideoSettings ) ,  ( "root/cimv2" ,  "Win32_VideoSettings" ) }
        ,  { typeof ( Win32PageFileElementSetting ) ,  ( "root/cimv2" ,  "Win32_PageFileElementSetting" ) }
        ,  { typeof ( Win32OperatingSystemAutochkSetting ) ,  ( "root/cimv2" ,  "Win32_OperatingSystemAutochkSetting" ) }
        ,  { typeof ( CIMStorageDefect ) ,  ( "root/cimv2" ,  "CIM_StorageDefect" ) }
        ,  { typeof ( CIMStatistics ) ,  ( "root/cimv2" ,  "CIM_Statistics" ) }
        ,  { typeof ( CIMErrorCountersForDevice ) ,  ( "root/cimv2" ,  "CIM_ErrorCountersForDevice" ) }
        ,  { typeof ( Win32PnPDevice ) ,  ( "root/cimv2" ,  "Win32_PnPDevice" ) }
        ,  { typeof ( CIMLogicalIdentity ) ,  ( "root/cimv2" ,  "CIM_LogicalIdentity" ) }
        ,  { typeof ( Win32ActiveRoute ) ,  ( "root/cimv2" ,  "Win32_ActiveRoute" ) }
        ,  { typeof ( CIMCollectedMSEs ) ,  ( "root/cimv2" ,  "CIM_CollectedMSEs" ) }
        ,  { typeof ( Win32NamedJobObjectProcess ) ,  ( "root/cimv2" ,  "Win32_NamedJobObjectProcess" ) }
        ,  { typeof ( CIMElementConfiguration ) ,  ( "root/cimv2" ,  "CIM_ElementConfiguration" ) }
        ,  { typeof ( CIMActsAsSpare ) ,  ( "root/cimv2" ,  "CIM_ActsAsSpare" ) }
        ,  { typeof ( CIMSetting ) ,  ( "root/cimv2" ,  "CIM_Setting" ) }
        ,  { typeof ( Win32NetworkAdapterConfiguration ) ,  ( "root/cimv2" ,  "Win32_NetworkAdapterConfiguration" ) }
        ,  { typeof ( Win32TimeZone ) ,  ( "root/cimv2" ,  "Win32_TimeZone" ) }
        ,  { typeof ( Win32PageFileSetting ) ,  ( "root/cimv2" ,  "Win32_PageFileSetting" ) }
        ,  { typeof ( Win32Desktop ) ,  ( "root/cimv2" ,  "Win32_Desktop" ) }
        ,  { typeof ( Win32ShadowContext ) ,  ( "root/cimv2" ,  "Win32_ShadowContext" ) }
        ,  { typeof ( Win32MSIResource ) ,  ( "root/cimv2" ,  "Win32_MSIResource" ) }
        ,  { typeof ( Win32ServiceControl ) ,  ( "root/cimv2" ,  "Win32_ServiceControl" ) }
        ,  { typeof ( Win32Property ) ,  ( "root/cimv2" ,  "Win32_Property" ) }
        ,  { typeof ( Win32Patch ) ,  ( "root/cimv2" ,  "Win32_Patch" ) }
        ,  { typeof ( Win32PatchPackage ) ,  ( "root/cimv2" ,  "Win32_PatchPackage" ) }
        ,  { typeof ( Win32Binary ) ,  ( "root/cimv2" ,  "Win32_Binary" ) }
        ,  { typeof ( Win32AutochkSetting ) ,  ( "root/cimv2" ,  "Win32_AutochkSetting" ) }
        ,  { typeof ( Win32SerialPortConfiguration ) ,  ( "root/cimv2" ,  "Win32_SerialPortConfiguration" ) }
        ,  { typeof ( CIMMonitorResolution ) ,  ( "root/cimv2" ,  "CIM_MonitorResolution" ) }
        ,  { typeof ( Win32StartupCommand ) ,  ( "root/cimv2" ,  "Win32_StartupCommand" ) }
        ,  { typeof ( Win32BootConfiguration ) ,  ( "root/cimv2" ,  "Win32_BootConfiguration" ) }
        ,  { typeof ( Win32NetworkLoginProfile ) ,  ( "root/cimv2" ,  "Win32_NetworkLoginProfile" ) }
        ,  { typeof ( Win32NamedJobObjectLimitSetting ) ,  ( "root/cimv2" ,  "Win32_NamedJobObjectLimitSetting" ) }
        ,  { typeof ( CIMVideoControllerResolution ) ,  ( "root/cimv2" ,  "CIM_VideoControllerResolution" ) }
        ,  { typeof ( Win32NamedJobObjectSecLimitSetting ) ,  ( "root/cimv2" ,  "Win32_NamedJobObjectSecLimitSetting" ) }
        ,  { typeof ( Win32DisplayConfiguration ) ,  ( "root/cimv2" ,  "Win32_DisplayConfiguration" ) }
        ,  { typeof ( Win32QuotaSetting ) ,  ( "root/cimv2" ,  "Win32_QuotaSetting" ) }
        ,  { typeof ( Win32SecuritySetting ) ,  ( "root/cimv2" ,  "Win32_SecuritySetting" ) }
        ,  { typeof ( Win32LogicalFileSecuritySetting ) ,  ( "root/cimv2" ,  "Win32_LogicalFileSecuritySetting" ) }
        ,  { typeof ( Win32LogicalShareSecuritySetting ) ,  ( "root/cimv2" ,  "Win32_LogicalShareSecuritySetting" ) }
        ,  { typeof ( Win32DisplayControllerConfiguration ) ,  ( "root/cimv2" ,  "Win32_DisplayControllerConfiguration" ) }
        ,  { typeof ( Win32WMISetting ) ,  ( "root/cimv2" ,  "Win32_WMISetting" ) }
        ,  { typeof ( Win32OSRecoveryConfiguration ) ,  ( "root/cimv2" ,  "Win32_OSRecoveryConfiguration" ) }
        ,  { typeof ( Win32COMSetting ) ,  ( "root/cimv2" ,  "Win32_COMSetting" ) }
        ,  { typeof ( Win32ClassicCOMClassSetting ) ,  ( "root/cimv2" ,  "Win32_ClassicCOMClassSetting" ) }
        ,  { typeof ( Win32DCOMApplicationSetting ) ,  ( "root/cimv2" ,  "Win32_DCOMApplicationSetting" ) }
        ,  { typeof ( Win32VideoConfiguration ) ,  ( "root/cimv2" ,  "Win32_VideoConfiguration" ) }
        ,  { typeof ( Win32ODBCAttribute ) ,  ( "root/cimv2" ,  "Win32_ODBCAttribute" ) }
        ,  { typeof ( Win32ODBCSourceAttribute ) ,  ( "root/cimv2" ,  "Win32_ODBCSourceAttribute" ) }
        ,  { typeof ( ScriptingStandardConsumerSetting ) ,  ( "root/cimv2" ,  "ScriptingStandardConsumerSetting" ) }
        ,  { typeof ( Win32PrinterConfiguration ) ,  ( "root/cimv2" ,  "Win32_PrinterConfiguration" ) }
        ,  { typeof ( CIMStatisticalInformation ) ,  ( "root/cimv2" ,  "CIM_StatisticalInformation" ) }
        ,  { typeof ( Win32Perf ) ,  ( "root/cimv2" ,  "Win32_Perf" ) }
        ,  { typeof ( Win32PerfFormattedData ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData" ) }
        ,  { typeof ( Win32PerfRawData ) ,  ( "root/cimv2" ,  "Win32_PerfRawData" ) }
        ,  { typeof ( Win32NamedJobObjectActgInfo ) ,  ( "root/cimv2" ,  "Win32_NamedJobObjectActgInfo" ) }
        ,  { typeof ( CIMDeviceErrorCounts ) ,  ( "root/cimv2" ,  "CIM_DeviceErrorCounts" ) }
        ,  { typeof ( Win32NTLogEvent ) ,  ( "root/cimv2" ,  "Win32_NTLogEvent" ) }
        ,  { typeof ( Win32UserProfile ) ,  ( "root/cimv2" ,  "Win32_UserProfile" ) }
        ,  { typeof ( Win32FolderRedirectionHealth ) ,  ( "root/cimv2" ,  "Win32_FolderRedirectionHealth" ) }
        ,  { typeof ( CIMIndication ) ,  ( "root/cimv2" ,  "CIM_Indication" ) }
        ,  { typeof ( CIMClassIndication ) ,  ( "root/cimv2" ,  "CIM_ClassIndication" ) }
        ,  { typeof ( CIMClassDeletion ) ,  ( "root/cimv2" ,  "CIM_ClassDeletion" ) }
        ,  { typeof ( CIMClassCreation ) ,  ( "root/cimv2" ,  "CIM_ClassCreation" ) }
        ,  { typeof ( CIMClassModification ) ,  ( "root/cimv2" ,  "CIM_ClassModification" ) }
        ,  { typeof ( CIMInstIndication ) ,  ( "root/cimv2" ,  "CIM_InstIndication" ) }
        ,  { typeof ( CIMInstCreation ) ,  ( "root/cimv2" ,  "CIM_InstCreation" ) }
        ,  { typeof ( CIMInstModification ) ,  ( "root/cimv2" ,  "CIM_InstModification" ) }
        ,  { typeof ( CIMInstDeletion ) ,  ( "root/cimv2" ,  "CIM_InstDeletion" ) }
        ,  { typeof ( NotifyStatus ) ,  ( "root/cimv2" ,  "__NotifyStatus" ) }
        ,  { typeof ( ExtendedStatus ) ,  ( "root/cimv2" ,  "__ExtendedStatus" ) }
        ,  { typeof ( Win32PrivilegesStatus ) ,  ( "root/cimv2" ,  "Win32_PrivilegesStatus" ) }
        ,  { typeof ( Win32JobObjectStatus ) ,  ( "root/cimv2" ,  "Win32_JobObjectStatus" ) }
        ,  { typeof ( CIMError ) ,  ( "root/cimv2" ,  "CIM_Error" ) }
        ,  { typeof ( MSFTWmiError ) ,  ( "root/cimv2" ,  "MSFT_WmiError" ) }
        ,  { typeof ( MSFTExtendedStatus ) ,  ( "root/cimv2" ,  "MSFT_ExtendedStatus" ) }
        ,  { typeof ( SecurityRelatedClass ) ,  ( "root/cimv2" ,  "__SecurityRelatedClass" ) }
        ,  { typeof ( Trustee ) ,  ( "root/cimv2" ,  "__Trustee" ) }
        ,  { typeof ( Win32Trustee ) ,  ( "root/cimv2" ,  "Win32_Trustee" ) }
        ,  { typeof ( NTLMUser9X ) ,  ( "root/cimv2" ,  "__NTLMUser9X" ) }
        ,  { typeof ( ACE ) ,  ( "root/cimv2" ,  "__ACE" ) }
        ,  { typeof ( Win32ACE ) ,  ( "root/cimv2" ,  "Win32_ACE" ) }
        ,  { typeof ( SecurityDescriptor ) ,  ( "root/cimv2" ,  "__SecurityDescriptor" ) }
        ,  { typeof ( Win32SecurityDescriptor ) ,  ( "root/cimv2" ,  "Win32_SecurityDescriptor" ) }
        ,  { typeof ( PARAMETERS ) ,  ( "root/cimv2" ,  "__PARAMETERS" ) }
        ,  { typeof ( Win32CollectionStatistics ) ,  ( "root/cimv2" ,  "Win32_CollectionStatistics" ) }
        ,  { typeof ( Win32NamedJobObjectStatistics ) ,  ( "root/cimv2" ,  "Win32_NamedJobObjectStatistics" ) }
        ,  { typeof ( CIMConfiguration ) ,  ( "root/cimv2" ,  "CIM_Configuration" ) }
        ,  { typeof ( Win32OfflineFilesUserConfiguration ) ,  ( "root/cimv2" ,  "Win32_OfflineFilesUserConfiguration" ) }
        ,  { typeof ( Win32AccountSID ) ,  ( "root/cimv2" ,  "Win32_AccountSID" ) }
        ,  { typeof ( CIMLocation ) ,  ( "root/cimv2" ,  "CIM_Location" ) }
        ,  { typeof ( CIMDependencyContext ) ,  ( "root/cimv2" ,  "CIM_DependencyContext" ) }
        ,  { typeof ( Win32WinSAT ) ,  ( "root/cimv2" ,  "Win32_WinSAT" ) }
        ,  { typeof ( Win32SecurityDescriptorHelper ) ,  ( "root/cimv2" ,  "Win32_SecurityDescriptorHelper" ) }
        ,  { typeof ( Win32CurrentTime ) ,  ( "root/cimv2" ,  "Win32_CurrentTime" ) }
        ,  { typeof ( Win32UTCTime ) ,  ( "root/cimv2" ,  "Win32_UTCTime" ) }
        ,  { typeof ( Win32LocalTime ) ,  ( "root/cimv2" ,  "Win32_LocalTime" ) }
        ,  { typeof ( CIMFRU ) ,  ( "root/cimv2" ,  "CIM_FRU" ) }
        ,  { typeof ( CIMAction ) ,  ( "root/cimv2" ,  "CIM_Action" ) }
        ,  { typeof ( Win32ShortcutAction ) ,  ( "root/cimv2" ,  "Win32_ShortcutAction" ) }
        ,  { typeof ( CIMRebootAction ) ,  ( "root/cimv2" ,  "CIM_RebootAction" ) }
        ,  { typeof ( Win32ExtensionInfoAction ) ,  ( "root/cimv2" ,  "Win32_ExtensionInfoAction" ) }
        ,  { typeof ( CIMDirectoryAction ) ,  ( "root/cimv2" ,  "CIM_DirectoryAction" ) }
        ,  { typeof ( CIMCreateDirectoryAction ) ,  ( "root/cimv2" ,  "CIM_CreateDirectoryAction" ) }
        ,  { typeof ( Win32CreateFolderAction ) ,  ( "root/cimv2" ,  "Win32_CreateFolderAction" ) }
        ,  { typeof ( CIMRemoveDirectoryAction ) ,  ( "root/cimv2" ,  "CIM_RemoveDirectoryAction" ) }
        ,  { typeof ( Win32RegistryAction ) ,  ( "root/cimv2" ,  "Win32_RegistryAction" ) }
        ,  { typeof ( Win32ClassInfoAction ) ,  ( "root/cimv2" ,  "Win32_ClassInfoAction" ) }
        ,  { typeof ( CIMModifySettingAction ) ,  ( "root/cimv2" ,  "CIM_ModifySettingAction" ) }
        ,  { typeof ( Win32SelfRegModuleAction ) ,  ( "root/cimv2" ,  "Win32_SelfRegModuleAction" ) }
        ,  { typeof ( Win32TypeLibraryAction ) ,  ( "root/cimv2" ,  "Win32_TypeLibraryAction" ) }
        ,  { typeof ( CIMExecuteProgram ) ,  ( "root/cimv2" ,  "CIM_ExecuteProgram" ) }
        ,  { typeof ( Win32BindImageAction ) ,  ( "root/cimv2" ,  "Win32_BindImageAction" ) }
        ,  { typeof ( Win32RemoveIniAction ) ,  ( "root/cimv2" ,  "Win32_RemoveIniAction" ) }
        ,  { typeof ( Win32MIMEInfoAction ) ,  ( "root/cimv2" ,  "Win32_MIMEInfoAction" ) }
        ,  { typeof ( Win32FontInfoAction ) ,  ( "root/cimv2" ,  "Win32_FontInfoAction" ) }
        ,  { typeof ( Win32PublishComponentAction ) ,  ( "root/cimv2" ,  "Win32_PublishComponentAction" ) }
        ,  { typeof ( CIMFileAction ) ,  ( "root/cimv2" ,  "CIM_FileAction" ) }
        ,  { typeof ( Win32MoveFileAction ) ,  ( "root/cimv2" ,  "Win32_MoveFileAction" ) }
        ,  { typeof ( CIMCopyFileAction ) ,  ( "root/cimv2" ,  "CIM_CopyFileAction" ) }
        ,  { typeof ( Win32DuplicateFileAction ) ,  ( "root/cimv2" ,  "Win32_DuplicateFileAction" ) }
        ,  { typeof ( CIMRemoveFileAction ) ,  ( "root/cimv2" ,  "CIM_RemoveFileAction" ) }
        ,  { typeof ( Win32RemoveFileAction ) ,  ( "root/cimv2" ,  "Win32_RemoveFileAction" ) }
        ,  { typeof ( Win32ProductResource ) ,  ( "root/cimv2" ,  "Win32_ProductResource" ) }
        ,  { typeof ( Win32MountPoint ) ,  ( "root/cimv2" ,  "Win32_MountPoint" ) }
        ,  { typeof ( Win32OfflineFilesAssociatedItems ) ,  ( "root/cimv2" ,  "Win32_OfflineFilesAssociatedItems" ) }
        ,  { typeof ( MsftProviders ) ,  ( "root/cimv2" ,  "Msft_Providers" ) }
        ,  { typeof ( CIMRelatedStatistics ) ,  ( "root/cimv2" ,  "CIM_RelatedStatistics" ) }
        ,  { typeof ( Win32OfflineFilesChangeInfo ) ,  ( "root/cimv2" ,  "Win32_OfflineFilesChangeInfo" ) }
        ,  { typeof ( CIMExport ) ,  ( "root/cimv2" ,  "CIM_Export" ) }
        ,  { typeof ( Win32RoamingProfileMachineConfiguration ) ,  ( "root/cimv2" ,  "Win32_RoamingProfileMachineConfiguration" ) }
        ,  { typeof ( Win32ManagedSystemElementResource ) ,  ( "root/cimv2" ,  "Win32_ManagedSystemElementResource" ) }
        ,  { typeof ( Win32SoftwareElementResource ) ,  ( "root/cimv2" ,  "Win32_SoftwareElementResource" ) }
        ,  { typeof ( CIMFRUPhysicalElements ) ,  ( "root/cimv2" ,  "CIM_FRUPhysicalElements" ) }
        ,  { typeof ( CIMParticipatesInSet ) ,  ( "root/cimv2" ,  "CIM_ParticipatesInSet" ) }
        ,  { typeof ( CIMFromDirectoryAction ) ,  ( "root/cimv2" ,  "CIM_FromDirectoryAction" ) }
        ,  { typeof ( Win32SID ) ,  ( "root/cimv2" ,  "Win32_SID" ) }
        ,  { typeof ( CIMElementCapacity ) ,  ( "root/cimv2" ,  "CIM_ElementCapacity" ) }
        ,  { typeof ( Win32ActionCheck ) ,  ( "root/cimv2" ,  "Win32_ActionCheck" ) }
        ,  { typeof ( CIMToDirectorySpecification ) ,  ( "root/cimv2" ,  "CIM_ToDirectorySpecification" ) }
        ,  { typeof ( CIMProductSoftwareFeatures ) ,  ( "root/cimv2" ,  "CIM_ProductSoftwareFeatures" ) }
        ,  { typeof ( Win32ProductSoftwareFeatures ) ,  ( "root/cimv2" ,  "Win32_ProductSoftwareFeatures" ) }
        ,  { typeof ( Win32ImplementedCategory ) ,  ( "root/cimv2" ,  "Win32_ImplementedCategory" ) }
        ,  { typeof ( Win32RoamingProfileUserConfiguration ) ,  ( "root/cimv2" ,  "Win32_RoamingProfileUserConfiguration" ) }
        ,  { typeof ( CIMInstalledSoftwareElement ) ,  ( "root/cimv2" ,  "CIM_InstalledSoftwareElement" ) }
        ,  { typeof ( Win32InstalledSoftwareElement ) ,  ( "root/cimv2" ,  "Win32_InstalledSoftwareElement" ) }
        ,  { typeof ( Win32SoftwareFeatureCheck ) ,  ( "root/cimv2" ,  "Win32_SoftwareFeatureCheck" ) }
        ,  { typeof ( Win32LUIDandAttributes ) ,  ( "root/cimv2" ,  "Win32_LUIDandAttributes" ) }
        ,  { typeof ( Win32VolumeUserQuota ) ,  ( "root/cimv2" ,  "Win32_VolumeUserQuota" ) }
        ,  { typeof ( MsftWmiProviderCounters ) ,  ( "root/cimv2" ,  "Msft_WmiProvider_Counters" ) }
        ,  { typeof ( Win32LUID ) ,  ( "root/cimv2" ,  "Win32_LUID" ) }
        ,  { typeof ( CIMCheck ) ,  ( "root/cimv2" ,  "CIM_Check" ) }
        ,  { typeof ( CIMDiskSpaceCheck ) ,  ( "root/cimv2" ,  "CIM_DiskSpaceCheck" ) }
        ,  { typeof ( CIMDirectorySpecification ) ,  ( "root/cimv2" ,  "CIM_DirectorySpecification" ) }
        ,  { typeof ( Win32DirectorySpecification ) ,  ( "root/cimv2" ,  "Win32_DirectorySpecification" ) }
        ,  { typeof ( Win32SoftwareElementCondition ) ,  ( "root/cimv2" ,  "Win32_SoftwareElementCondition" ) }
        ,  { typeof ( Win32ODBCDriverSpecification ) ,  ( "root/cimv2" ,  "Win32_ODBCDriverSpecification" ) }
        ,  { typeof ( CIMMemoryCheck ) ,  ( "root/cimv2" ,  "CIM_MemoryCheck" ) }
        ,  { typeof ( Win32ServiceSpecification ) ,  ( "root/cimv2" ,  "Win32_ServiceSpecification" ) }
        ,  { typeof ( CIMFileSpecification ) ,  ( "root/cimv2" ,  "CIM_FileSpecification" ) }
        ,  { typeof ( Win32FileSpecification ) ,  ( "root/cimv2" ,  "Win32_FileSpecification" ) }
        ,  { typeof ( Win32IniFileSpecification ) ,  ( "root/cimv2" ,  "Win32_IniFileSpecification" ) }
        ,  { typeof ( CIMSoftwareElementVersionCheck ) ,  ( "root/cimv2" ,  "CIM_SoftwareElementVersionCheck" ) }
        ,  { typeof ( CIMSettingCheck ) ,  ( "root/cimv2" ,  "CIM_SettingCheck" ) }
        ,  { typeof ( Win32LaunchCondition ) ,  ( "root/cimv2" ,  "Win32_LaunchCondition" ) }
        ,  { typeof ( Win32ODBCDataSourceSpecification ) ,  ( "root/cimv2" ,  "Win32_ODBCDataSourceSpecification" ) }
        ,  { typeof ( Win32ODBCTranslatorSpecification ) ,  ( "root/cimv2" ,  "Win32_ODBCTranslatorSpecification" ) }
        ,  { typeof ( Win32ProgIDSpecification ) ,  ( "root/cimv2" ,  "Win32_ProgIDSpecification" ) }
        ,  { typeof ( CIMSwapSpaceCheck ) ,  ( "root/cimv2" ,  "CIM_SwapSpaceCheck" ) }
        ,  { typeof ( Win32EnvironmentSpecification ) ,  ( "root/cimv2" ,  "Win32_EnvironmentSpecification" ) }
        ,  { typeof ( Win32ReserveCost ) ,  ( "root/cimv2" ,  "Win32_ReserveCost" ) }
        ,  { typeof ( CIMVersionCompatibilityCheck ) ,  ( "root/cimv2" ,  "CIM_VersionCompatibilityCheck" ) }
        ,  { typeof ( CIMOSVersionCheck ) ,  ( "root/cimv2" ,  "CIM_OSVersionCheck" ) }
        ,  { typeof ( Win32Condition ) ,  ( "root/cimv2" ,  "Win32_Condition" ) }
        ,  { typeof ( CIMProductFRU ) ,  ( "root/cimv2" ,  "CIM_ProductFRU" ) }
        ,  { typeof ( Win32ShadowStorage ) ,  ( "root/cimv2" ,  "Win32_ShadowStorage" ) }
        ,  { typeof ( Win32DCOMApplicationAccessAllowedSetting ) ,  ( "root/cimv2" ,  "Win32_DCOMApplicationAccessAllowedSetting" ) }
        ,  { typeof ( StdRegProv ) ,  ( "root/cimv2" ,  "StdRegProv" ) }
        ,  { typeof ( CIMFRUIncludesProduct ) ,  ( "root/cimv2" ,  "CIM_FRUIncludesProduct" ) }
        ,  { typeof ( Win32FolderRedirection ) ,  ( "root/cimv2" ,  "Win32_FolderRedirection" ) }
        ,  { typeof ( CIMProductPhysicalElements ) ,  ( "root/cimv2" ,  "CIM_ProductPhysicalElements" ) }
        ,  { typeof ( CIMPhysicalElementLocation ) ,  ( "root/cimv2" ,  "CIM_PhysicalElementLocation" ) }
        ,  { typeof ( Win32TokenPrivileges ) ,  ( "root/cimv2" ,  "Win32_TokenPrivileges" ) }
        ,  { typeof ( CIMCollectionOfMSEs ) ,  ( "root/cimv2" ,  "CIM_CollectionOfMSEs" ) }
        ,  { typeof ( Win32NamedJobObject ) ,  ( "root/cimv2" ,  "Win32_NamedJobObject" ) }
        ,  { typeof ( CIMFromDirectorySpecification ) ,  ( "root/cimv2" ,  "CIM_FromDirectorySpecification" ) }
        ,  { typeof ( CIMStorageError ) ,  ( "root/cimv2" ,  "CIM_StorageError" ) }
        ,  { typeof ( Win32ServiceSpecificationService ) ,  ( "root/cimv2" ,  "Win32_ServiceSpecificationService" ) }
        ,  { typeof ( Win32OfflineFilesItem ) ,  ( "root/cimv2" ,  "Win32_OfflineFilesItem" ) }
        ,  { typeof ( Win32OfflineFilesBackgroundSync ) ,  ( "root/cimv2" ,  "Win32_OfflineFilesBackgroundSync" ) }
        ,  { typeof ( Win32InstalledWin32Program ) ,  ( "root/cimv2" ,  "Win32_InstalledWin32Program" ) }
        ,  { typeof ( Win32ShareToDirectory ) ,  ( "root/cimv2" ,  "Win32_ShareToDirectory" ) }
        ,  { typeof ( Win32SettingCheck ) ,  ( "root/cimv2" ,  "Win32_SettingCheck" ) }
        ,  { typeof ( Win32PatchFile ) ,  ( "root/cimv2" ,  "Win32_PatchFile" ) }
        ,  { typeof ( Win32ODBCDriverAttribute ) ,  ( "root/cimv2" ,  "Win32_ODBCDriverAttribute" ) }
        ,  { typeof ( Win32ODBCDataSourceAttribute ) ,  ( "root/cimv2" ,  "Win32_ODBCDataSourceAttribute" ) }
        ,  { typeof ( Win32ClientApplicationSetting ) ,  ( "root/cimv2" ,  "Win32_ClientApplicationSetting" ) }
        ,  { typeof ( Win32RoamingUserHealthConfiguration ) ,  ( "root/cimv2" ,  "Win32_RoamingUserHealthConfiguration" ) }
        ,  { typeof ( CIMReplacementSet ) ,  ( "root/cimv2" ,  "CIM_ReplacementSet" ) }
        ,  { typeof ( Win32UserStateConfigurationControls ) ,  ( "root/cimv2" ,  "Win32_UserStateConfigurationControls" ) }
        ,  { typeof ( Win32OfflineFilesPinInfo ) ,  ( "root/cimv2" ,  "Win32_OfflineFilesPinInfo" ) }
        ,  { typeof ( CIMDirectorySpecificationFile ) ,  ( "root/cimv2" ,  "CIM_DirectorySpecificationFile" ) }
        ,  { typeof ( CIMSettingContext ) ,  ( "root/cimv2" ,  "CIM_SettingContext" ) }
        ,  { typeof ( Win32SecuritySettingOwner ) ,  ( "root/cimv2" ,  "Win32_SecuritySettingOwner" ) }
        ,  { typeof ( Win32LogicalFileOwner ) ,  ( "root/cimv2" ,  "Win32_LogicalFileOwner" ) }
        ,  { typeof ( Win32OfflineFilesFileSysInfo ) ,  ( "root/cimv2" ,  "Win32_OfflineFilesFileSysInfo" ) }
        ,  { typeof ( NTEventlogProviderConfig ) ,  ( "root/cimv2" ,  "NTEventlogProviderConfig" ) }
        ,  { typeof ( Win32ShortcutSAP ) ,  ( "root/cimv2" ,  "Win32_ShortcutSAP" ) }
        ,  { typeof ( Win32OfflineFilesSuspendInfo ) ,  ( "root/cimv2" ,  "Win32_OfflineFilesSuspendInfo" ) }
        ,  { typeof ( Win32MethodParameterClass ) ,  ( "root/cimv2" ,  "Win32_MethodParameterClass" ) }
        ,  { typeof ( Win32ProcessStartup ) ,  ( "root/cimv2" ,  "Win32_ProcessStartup" ) }
        ,  { typeof ( Win32PingStatus ) ,  ( "root/cimv2" ,  "Win32_PingStatus" ) }
        ,  { typeof ( CIMProductSupport ) ,  ( "root/cimv2" ,  "CIM_ProductSupport" ) }
        ,  { typeof ( CIMAdjacentSlots ) ,  ( "root/cimv2" ,  "CIM_AdjacentSlots" ) }
        ,  { typeof ( CIMSoftwareElementChecks ) ,  ( "root/cimv2" ,  "CIM_SoftwareElementChecks" ) }
        ,  { typeof ( Win32SoftwareElementCheck ) ,  ( "root/cimv2" ,  "Win32_SoftwareElementCheck" ) }
        ,  { typeof ( Win32ODBCDriverSoftwareElement ) ,  ( "root/cimv2" ,  "Win32_ODBCDriverSoftwareElement" ) }
        ,  { typeof ( Win32FolderRedirectionUserConfiguration ) ,  ( "root/cimv2" ,  "Win32_FolderRedirectionUserConfiguration" ) }
        ,  { typeof ( Win32Reliability ) ,  ( "root/cimv2" ,  "Win32_Reliability" ) }
        ,  { typeof ( Win32ReliabilityStabilityMetrics ) ,  ( "root/cimv2" ,  "Win32_ReliabilityStabilityMetrics" ) }
        ,  { typeof ( Win32ReliabilityRecords ) ,  ( "root/cimv2" ,  "Win32_ReliabilityRecords" ) }
        ,  { typeof ( Win32InstalledProgramFramework ) ,  ( "root/cimv2" ,  "Win32_InstalledProgramFramework" ) }
        ,  { typeof ( Win32NTLogEventLog ) ,  ( "root/cimv2" ,  "Win32_NTLogEventLog" ) }
        ,  { typeof ( Win32ComClassAutoEmulator ) ,  ( "root/cimv2" ,  "Win32_ComClassAutoEmulator" ) }
        ,  { typeof ( Win32FolderRedirectionHealthConfiguration ) ,  ( "root/cimv2" ,  "Win32_FolderRedirectionHealthConfiguration" ) }
        ,  { typeof ( Win32ComClassEmulator ) ,  ( "root/cimv2" ,  "Win32_ComClassEmulator" ) }
        ,  { typeof ( Win32SoftwareFeatureAction ) ,  ( "root/cimv2" ,  "Win32_SoftwareFeatureAction" ) }
        ,  { typeof ( Win32OfflineFilesMachineConfiguration ) ,  ( "root/cimv2" ,  "Win32_OfflineFilesMachineConfiguration" ) }
        ,  { typeof ( Win32SecuritySettingGroup ) ,  ( "root/cimv2" ,  "Win32_SecuritySettingGroup" ) }
        ,  { typeof ( Win32LogicalFileGroup ) ,  ( "root/cimv2" ,  "Win32_LogicalFileGroup" ) }
        ,  { typeof ( Win32DCOMApplicationLaunchAllowedSetting ) ,  ( "root/cimv2" ,  "Win32_DCOMApplicationLaunchAllowedSetting" ) }
        ,  { typeof ( Win32SecuritySettingAuditing ) ,  ( "root/cimv2" ,  "Win32_SecuritySettingAuditing" ) }
        ,  { typeof ( Win32LogicalFileAuditing ) ,  ( "root/cimv2" ,  "Win32_LogicalFileAuditing" ) }
        ,  { typeof ( Win32LogicalShareAuditing ) ,  ( "root/cimv2" ,  "Win32_LogicalShareAuditing" ) }
        ,  { typeof ( SoftwareLicensingProduct ) ,  ( "root/cimv2" ,  "SoftwareLicensingProduct" ) }
        ,  { typeof ( Win32PnPDeviceProperty ) ,  ( "root/cimv2" ,  "Win32_PnPDeviceProperty" ) }
        ,  { typeof ( Win32PnPDevicePropertyString ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertyString" ) }
        ,  { typeof ( Win32PnPDevicePropertyReal32Array ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertyReal32Array" ) }
        ,  { typeof ( Win32PnPDevicePropertyReal64 ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertyReal64" ) }
        ,  { typeof ( Win32PnPDevicePropertyUint16 ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertyUint16" ) }
        ,  { typeof ( Win32PnPDevicePropertySint16Array ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertySint16Array" ) }
        ,  { typeof ( Win32PnPDevicePropertySint64 ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertySint64" ) }
        ,  { typeof ( Win32PnPDevicePropertyUint8 ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertyUint8" ) }
        ,  { typeof ( Win32PnPDevicePropertySint8 ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertySint8" ) }
        ,  { typeof ( Win32PnPDevicePropertySecurityDescriptor ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertySecurityDescriptor" ) }
        ,  { typeof ( Win32PnPDevicePropertyReal32 ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertyReal32" ) }
        ,  { typeof ( Win32PnPDevicePropertySint32 ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertySint32" ) }
        ,  { typeof ( Win32PnPDevicePropertyStringArray ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertyStringArray" ) }
        ,  { typeof ( Win32PnPDevicePropertyUint32 ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertyUint32" ) }
        ,  { typeof ( Win32PnPDevicePropertyUint64 ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertyUint64" ) }
        ,  { typeof ( Win32PnPDevicePropertyBoolean ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertyBoolean" ) }
        ,  { typeof ( Win32PnPDevicePropertyUint16Array ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertyUint16Array" ) }
        ,  { typeof ( Win32PnPDevicePropertyBinary ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertyBinary" ) }
        ,  { typeof ( Win32PnPDevicePropertySint32Array ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertySint32Array" ) }
        ,  { typeof ( Win32PnPDevicePropertySint16 ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertySint16" ) }
        ,  { typeof ( Win32PnPDevicePropertyReal64Array ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertyReal64Array" ) }
        ,  { typeof ( Win32PnPDevicePropertyBooleanArray ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertyBooleanArray" ) }
        ,  { typeof ( Win32PnPDevicePropertyUint32Array ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertyUint32Array" ) }
        ,  { typeof ( Win32PnPDevicePropertyDateTime ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertyDateTime" ) }
        ,  { typeof ( Win32PnPDevicePropertySecurityDescriptorArray ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertySecurityDescriptorArray" ) }
        ,  { typeof ( Win32PnPDevicePropertySint8Array ) ,  ( "root/cimv2" ,  "Win32_PnPDevicePropertySint8Array" ) }
        ,  { typeof ( Win32OfflineFilesCache ) ,  ( "root/cimv2" ,  "Win32_OfflineFilesCache" ) }
        ,  { typeof ( CIMSoftwareElementActions ) ,  ( "root/cimv2" ,  "CIM_SoftwareElementActions" ) }
        ,  { typeof ( Win32SoftwareElementAction ) ,  ( "root/cimv2" ,  "Win32_SoftwareElementAction" ) }
        ,  { typeof ( CIMProduct ) ,  ( "root/cimv2" ,  "CIM_Product" ) }
        ,  { typeof ( Win32Product ) ,  ( "root/cimv2" ,  "Win32_Product" ) }
        ,  { typeof ( Win32ComputerSystemProduct ) ,  ( "root/cimv2" ,  "Win32_ComputerSystemProduct" ) }
        ,  { typeof ( CIMActionSequence ) ,  ( "root/cimv2" ,  "CIM_ActionSequence" ) }
        ,  { typeof ( CIMCollectedCollections ) ,  ( "root/cimv2" ,  "CIM_CollectedCollections" ) }
        ,  { typeof ( Win32ProductCheck ) ,  ( "root/cimv2" ,  "Win32_ProductCheck" ) }
        ,  { typeof ( SoftwareLicensingService ) ,  ( "root/cimv2" ,  "SoftwareLicensingService" ) }
        ,  { typeof ( Win32NTLogEventUser ) ,  ( "root/cimv2" ,  "Win32_NTLogEventUser" ) }
        ,  { typeof ( CIMProductParentChild ) ,  ( "root/cimv2" ,  "CIM_ProductParentChild" ) }
        ,  { typeof ( Win32ProtocolBinding ) ,  ( "root/cimv2" ,  "Win32_ProtocolBinding" ) }
        ,  { typeof ( CIMSupportAccess ) ,  ( "root/cimv2" ,  "CIM_SupportAccess" ) }
        ,  { typeof ( CIMCollectionSetting ) ,  ( "root/cimv2" ,  "CIM_CollectionSetting" ) }
        ,  { typeof ( Win32NamedJobObjectLimit ) ,  ( "root/cimv2" ,  "Win32_NamedJobObjectLimit" ) }
        ,  { typeof ( Win32NamedJobObjectSecLimit ) ,  ( "root/cimv2" ,  "Win32_NamedJobObjectSecLimit" ) }
        ,  { typeof ( Win32OfflineFilesConnectionInfo ) ,  ( "root/cimv2" ,  "Win32_OfflineFilesConnectionInfo" ) }
        ,  { typeof ( Win32InstalledStoreProgram ) ,  ( "root/cimv2" ,  "Win32_InstalledStoreProgram" ) }
        ,  { typeof ( Win32NTLogEventComputer ) ,  ( "root/cimv2" ,  "Win32_NTLogEventComputer" ) }
        ,  { typeof ( Win32TokenGroups ) ,  ( "root/cimv2" ,  "Win32_TokenGroups" ) }
        ,  { typeof ( SoftwareLicensingTokenActivationLicense ) ,  ( "root/cimv2" ,  "SoftwareLicensingTokenActivationLicense" ) }
        ,  { typeof ( CIMPhysicalCapacity ) ,  ( "root/cimv2" ,  "CIM_PhysicalCapacity" ) }
        ,  { typeof ( CIMMemoryCapacity ) ,  ( "root/cimv2" ,  "CIM_MemoryCapacity" ) }
        ,  { typeof ( Win32DefragAnalysis ) ,  ( "root/cimv2" ,  "Win32_DefragAnalysis" ) }
        ,  { typeof ( CIMProductProductDependency ) ,  ( "root/cimv2" ,  "CIM_ProductProductDependency" ) }
        ,  { typeof ( Win32SIDandAttributes ) ,  ( "root/cimv2" ,  "Win32_SIDandAttributes" ) }
        ,  { typeof ( Win32CheckCheck ) ,  ( "root/cimv2" ,  "Win32_CheckCheck" ) }
        ,  { typeof ( CIMCompatibleProduct ) ,  ( "root/cimv2" ,  "CIM_CompatibleProduct" ) }
        ,  { typeof ( Win32RoamingProfileBackgroundUploadParams ) ,  ( "root/cimv2" ,  "Win32_RoamingProfileBackgroundUploadParams" ) }
        ,  { typeof ( CIMToDirectoryAction ) ,  ( "root/cimv2" ,  "CIM_ToDirectoryAction" ) }
        ,  { typeof ( Win32RoamingProfileSlowLinkParams ) ,  ( "root/cimv2" ,  "Win32_RoamingProfileSlowLinkParams" ) }
        ,  { typeof ( Win32OfflineFilesDiskSpaceLimit ) ,  ( "root/cimv2" ,  "Win32_OfflineFilesDiskSpaceLimit" ) }
        ,  { typeof ( Win32SecuritySettingAccess ) ,  ( "root/cimv2" ,  "Win32_SecuritySettingAccess" ) }
        ,  { typeof ( Win32LogicalFileAccess ) ,  ( "root/cimv2" ,  "Win32_LogicalFileAccess" ) }
        ,  { typeof ( Win32LogicalShareAccess ) ,  ( "root/cimv2" ,  "Win32_LogicalShareAccess" ) }
        ,  { typeof ( Win32OfflineFilesDirtyInfo ) ,  ( "root/cimv2" ,  "Win32_OfflineFilesDirtyInfo" ) }
        ,  { typeof ( Win32OfflineFilesHealth ) ,  ( "root/cimv2" ,  "Win32_OfflineFilesHealth" ) }
        ,  { typeof ( Win32PerfFormattedDataAFDCountersMicrosoftWinsockBSP ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_AFDCounters_MicrosoftWinsockBSP" ) }
        ,  { typeof ( Win32PerfRawDataAFDCountersMicrosoftWinsockBSP ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_AFDCounters_MicrosoftWinsockBSP" ) }
        ,  { typeof ( Win32PerfFormattedDataASPNET4030319ASPNETAppsv4030319 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_ASPNET4030319_ASPNETAppsv4030319" ) }
        ,  { typeof ( Win32PerfRawDataASPNET4030319ASPNETAppsv4030319 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_ASPNET4030319_ASPNETAppsv4030319" ) }
        ,  { typeof ( Win32PerfFormattedDataASPNET4030319ASPNETv4030319 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_ASPNET4030319_ASPNETv4030319" ) }
        ,  { typeof ( Win32PerfRawDataASPNET4030319ASPNETv4030319 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_ASPNET4030319_ASPNETv4030319" ) }
        ,  { typeof ( Win32PerfFormattedDataASPNETASPNET ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_ASPNET_ASPNET" ) }
        ,  { typeof ( Win32PerfRawDataASPNETASPNET ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_ASPNET_ASPNET" ) }
        ,  { typeof ( Win32PerfFormattedDataASPNETASPNETApplications ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_ASPNET_ASPNETApplications" ) }
        ,  { typeof ( Win32PerfRawDataASPNETASPNETApplications ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_ASPNET_ASPNETApplications" ) }
        ,  { typeof ( Win32PerfFormattedDataAspnetstateASPNETStateService ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_aspnetstate_ASPNETStateService" ) }
        ,  { typeof ( Win32PerfRawDataAspnetstateASPNETStateService ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_aspnetstate_ASPNETStateService" ) }
        ,  { typeof ( Win32PerfFormattedDataAuthorizationManagerAuthorizationManagerApplications ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_AuthorizationManager_AuthorizationManagerApplications" ) }
        ,  { typeof ( Win32PerfRawDataAuthorizationManagerAuthorizationManagerApplications ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_AuthorizationManager_AuthorizationManagerApplications" ) }
        ,  { typeof ( Win32PerfFormattedDataBalancerStatsHyperVDynamicMemoryBalancer ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_BalancerStats_HyperVDynamicMemoryBalancer" ) }
        ,  { typeof ( Win32PerfRawDataBalancerStatsHyperVDynamicMemoryBalancer ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_BalancerStats_HyperVDynamicMemoryBalancer" ) }
        ,  { typeof ( Win32PerfFormattedDataBalancerStatsHyperVDynamicMemoryVM ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_BalancerStats_HyperVDynamicMemoryVM" ) }
        ,  { typeof ( Win32PerfRawDataBalancerStatsHyperVDynamicMemoryVM ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_BalancerStats_HyperVDynamicMemoryVM" ) }
        ,  { typeof ( Win32PerfFormattedDataBITSBITSNetUtilization ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_BITS_BITSNetUtilization" ) }
        ,  { typeof ( Win32PerfRawDataBITSBITSNetUtilization ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_BITS_BITSNetUtilization" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersAppVClientStreamedDataPercentage ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_AppVClientStreamedDataPercentage" ) }
        ,  { typeof ( Win32PerfRawDataCountersAppVClientStreamedDataPercentage ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_AppVClientStreamedDataPercentage" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersBluetoothDevice ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_BluetoothDevice" ) }
        ,  { typeof ( Win32PerfRawDataCountersBluetoothDevice ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_BluetoothDevice" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersBluetoothRadio ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_BluetoothRadio" ) }
        ,  { typeof ( Win32PerfRawDataCountersBluetoothRadio ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_BluetoothRadio" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersDNS64Global ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_DNS64Global" ) }
        ,  { typeof ( Win32PerfRawDataCountersDNS64Global ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_DNS64Global" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersEventLog ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_EventLog" ) }
        ,  { typeof ( Win32PerfRawDataCountersEventLog ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_EventLog" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersEventTracingforWindows ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_EventTracingforWindows" ) }
        ,  { typeof ( Win32PerfRawDataCountersEventTracingforWindows ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_EventTracingforWindows" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersEventTracingforWindowsSession ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_EventTracingforWindowsSession" ) }
        ,  { typeof ( Win32PerfRawDataCountersEventTracingforWindowsSession ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_EventTracingforWindowsSession" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersFileSystemDiskActivity ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_FileSystemDiskActivity" ) }
        ,  { typeof ( Win32PerfRawDataCountersFileSystemDiskActivity ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_FileSystemDiskActivity" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersGenericIKEv1AuthIPandIKEv2 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_GenericIKEv1AuthIPandIKEv2" ) }
        ,  { typeof ( Win32PerfRawDataCountersGenericIKEv1AuthIPandIKEv2 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_GenericIKEv1AuthIPandIKEv2" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersHTTPService ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_HTTPService" ) }
        ,  { typeof ( Win32PerfRawDataCountersHTTPService ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_HTTPService" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersHTTPServiceRequestQueues ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_HTTPServiceRequestQueues" ) }
        ,  { typeof ( Win32PerfRawDataCountersHTTPServiceRequestQueues ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_HTTPServiceRequestQueues" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersHTTPServiceUrlGroups ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_HTTPServiceUrlGroups" ) }
        ,  { typeof ( Win32PerfRawDataCountersHTTPServiceUrlGroups ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_HTTPServiceUrlGroups" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersHyperVDynamicMemoryIntegrationService ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_HyperVDynamicMemoryIntegrationService" ) }
        ,  { typeof ( Win32PerfRawDataCountersHyperVDynamicMemoryIntegrationService ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_HyperVDynamicMemoryIntegrationService" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersHyperVVirtualMachineBus ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_HyperVVirtualMachineBus" ) }
        ,  { typeof ( Win32PerfRawDataCountersHyperVVirtualMachineBus ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_HyperVVirtualMachineBus" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersHyperVVirtualMachineBusPipes ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_HyperVVirtualMachineBusPipes" ) }
        ,  { typeof ( Win32PerfRawDataCountersHyperVVirtualMachineBusPipes ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_HyperVVirtualMachineBusPipes" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersHyperVVirtualMachineBusProviderPipes ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_HyperVVirtualMachineBusProviderPipes" ) }
        ,  { typeof ( Win32PerfRawDataCountersHyperVVirtualMachineBusProviderPipes ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_HyperVVirtualMachineBusProviderPipes" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersHyperVVirtualStorageDevice ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_HyperVVirtualStorageDevice" ) }
        ,  { typeof ( Win32PerfRawDataCountersHyperVVirtualStorageDevice ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_HyperVVirtualStorageDevice" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersIPHTTPSGlobal ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_IPHTTPSGlobal" ) }
        ,  { typeof ( Win32PerfRawDataCountersIPHTTPSGlobal ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_IPHTTPSGlobal" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersIPHTTPSSession ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_IPHTTPSSession" ) }
        ,  { typeof ( Win32PerfRawDataCountersIPHTTPSSession ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_IPHTTPSSession" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersIPsecAuthIPIPv4 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_IPsecAuthIPIPv4" ) }
        ,  { typeof ( Win32PerfRawDataCountersIPsecAuthIPIPv4 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_IPsecAuthIPIPv4" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersIPsecAuthIPIPv6 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_IPsecAuthIPIPv6" ) }
        ,  { typeof ( Win32PerfRawDataCountersIPsecAuthIPIPv6 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_IPsecAuthIPIPv6" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersIPsecConnections ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_IPsecConnections" ) }
        ,  { typeof ( Win32PerfRawDataCountersIPsecConnections ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_IPsecConnections" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersIPsecDriver ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_IPsecDriver" ) }
        ,  { typeof ( Win32PerfRawDataCountersIPsecDriver ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_IPsecDriver" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersIPsecIKEv1IPv4 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_IPsecIKEv1IPv4" ) }
        ,  { typeof ( Win32PerfRawDataCountersIPsecIKEv1IPv4 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_IPsecIKEv1IPv4" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersIPsecIKEv1IPv6 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_IPsecIKEv1IPv6" ) }
        ,  { typeof ( Win32PerfRawDataCountersIPsecIKEv1IPv6 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_IPsecIKEv1IPv6" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersIPsecIKEv2IPv4 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_IPsecIKEv2IPv4" ) }
        ,  { typeof ( Win32PerfRawDataCountersIPsecIKEv2IPv4 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_IPsecIKEv2IPv4" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersIPsecIKEv2IPv6 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_IPsecIKEv2IPv6" ) }
        ,  { typeof ( Win32PerfRawDataCountersIPsecIKEv2IPv6 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_IPsecIKEv2IPv6" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersNetlogon ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_Netlogon" ) }
        ,  { typeof ( Win32PerfRawDataCountersNetlogon ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_Netlogon" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersNetworkQoSPolicy ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_NetworkQoSPolicy" ) }
        ,  { typeof ( Win32PerfRawDataCountersNetworkQoSPolicy ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_NetworkQoSPolicy" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersNodejs ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_Nodejs" ) }
        ,  { typeof ( Win32PerfRawDataCountersNodejs ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_Nodejs" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersPacerFlow ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_PacerFlow" ) }
        ,  { typeof ( Win32PerfRawDataCountersPacerFlow ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_PacerFlow" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersPacerPipe ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_PacerPipe" ) }
        ,  { typeof ( Win32PerfRawDataCountersPacerPipe ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_PacerPipe" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersPacketDirectECUtilization ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_PacketDirectECUtilization" ) }
        ,  { typeof ( Win32PerfRawDataCountersPacketDirectECUtilization ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_PacketDirectECUtilization" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersPacketDirectQueueDepth ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_PacketDirectQueueDepth" ) }
        ,  { typeof ( Win32PerfRawDataCountersPacketDirectQueueDepth ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_PacketDirectQueueDepth" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersPacketDirectReceiveCounters ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_PacketDirectReceiveCounters" ) }
        ,  { typeof ( Win32PerfRawDataCountersPacketDirectReceiveCounters ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_PacketDirectReceiveCounters" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersPacketDirectReceiveFilters ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_PacketDirectReceiveFilters" ) }
        ,  { typeof ( Win32PerfRawDataCountersPacketDirectReceiveFilters ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_PacketDirectReceiveFilters" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersPacketDirectTransmitCounters ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_PacketDirectTransmitCounters" ) }
        ,  { typeof ( Win32PerfRawDataCountersPacketDirectTransmitCounters ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_PacketDirectTransmitCounters" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersPerProcessorNetworkActivityCycles ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_PerProcessorNetworkActivityCycles" ) }
        ,  { typeof ( Win32PerfRawDataCountersPerProcessorNetworkActivityCycles ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_PerProcessorNetworkActivityCycles" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersPerProcessorNetworkInterfaceCardActivity ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_PerProcessorNetworkInterfaceCardActivity" ) }
        ,  { typeof ( Win32PerfRawDataCountersPerProcessorNetworkInterfaceCardActivity ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_PerProcessorNetworkInterfaceCardActivity" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersPhysicalNetworkInterfaceCardActivity ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_PhysicalNetworkInterfaceCardActivity" ) }
        ,  { typeof ( Win32PerfRawDataCountersPhysicalNetworkInterfaceCardActivity ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_PhysicalNetworkInterfaceCardActivity" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersPowerShellWorkflow ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_PowerShellWorkflow" ) }
        ,  { typeof ( Win32PerfRawDataCountersPowerShellWorkflow ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_PowerShellWorkflow" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersProcessorInformation ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_ProcessorInformation" ) }
        ,  { typeof ( Win32PerfRawDataCountersProcessorInformation ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_ProcessorInformation" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersRDMAActivity ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_RDMAActivity" ) }
        ,  { typeof ( Win32PerfRawDataCountersRDMAActivity ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_RDMAActivity" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersReFS ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_ReFS" ) }
        ,  { typeof ( Win32PerfRawDataCountersReFS ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_ReFS" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersRemoteFXGraphics ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_RemoteFXGraphics" ) }
        ,  { typeof ( Win32PerfRawDataCountersRemoteFXGraphics ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_RemoteFXGraphics" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersRemoteFXNetwork ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_RemoteFXNetwork" ) }
        ,  { typeof ( Win32PerfRawDataCountersRemoteFXNetwork ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_RemoteFXNetwork" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersSMBClientShares ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_SMBClientShares" ) }
        ,  { typeof ( Win32PerfRawDataCountersSMBClientShares ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_SMBClientShares" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersSMBDirectConnection ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_SMBDirectConnection" ) }
        ,  { typeof ( Win32PerfRawDataCountersSMBDirectConnection ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_SMBDirectConnection" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersSMBServer ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_SMBServer" ) }
        ,  { typeof ( Win32PerfRawDataCountersSMBServer ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_SMBServer" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersSMBServerSessions ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_SMBServerSessions" ) }
        ,  { typeof ( Win32PerfRawDataCountersSMBServerSessions ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_SMBServerSessions" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersSMBServerShares ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_SMBServerShares" ) }
        ,  { typeof ( Win32PerfRawDataCountersSMBServerShares ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_SMBServerShares" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersStorageQoSFilterFlow ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_StorageQoSFilterFlow" ) }
        ,  { typeof ( Win32PerfRawDataCountersStorageQoSFilterFlow ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_StorageQoSFilterFlow" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersStorageQoSFilterVolume ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_StorageQoSFilterVolume" ) }
        ,  { typeof ( Win32PerfRawDataCountersStorageQoSFilterVolume ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_StorageQoSFilterVolume" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersStorageSpacesDrt ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_StorageSpacesDrt" ) }
        ,  { typeof ( Win32PerfRawDataCountersStorageSpacesDrt ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_StorageSpacesDrt" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersStorageSpacesTier ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_StorageSpacesTier" ) }
        ,  { typeof ( Win32PerfRawDataCountersStorageSpacesTier ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_StorageSpacesTier" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersStorageSpacesVirtualDisk ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_StorageSpacesVirtualDisk" ) }
        ,  { typeof ( Win32PerfRawDataCountersStorageSpacesVirtualDisk ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_StorageSpacesVirtualDisk" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersStorageSpacesWriteCache ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_StorageSpacesWriteCache" ) }
        ,  { typeof ( Win32PerfRawDataCountersStorageSpacesWriteCache ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_StorageSpacesWriteCache" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersSynchronization ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_Synchronization" ) }
        ,  { typeof ( Win32PerfRawDataCountersSynchronization ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_Synchronization" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersSynchronizationNuma ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_SynchronizationNuma" ) }
        ,  { typeof ( Win32PerfRawDataCountersSynchronizationNuma ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_SynchronizationNuma" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersTeredoClient ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_TeredoClient" ) }
        ,  { typeof ( Win32PerfRawDataCountersTeredoClient ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_TeredoClient" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersTeredoRelay ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_TeredoRelay" ) }
        ,  { typeof ( Win32PerfRawDataCountersTeredoRelay ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_TeredoRelay" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersTeredoServer ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_TeredoServer" ) }
        ,  { typeof ( Win32PerfRawDataCountersTeredoServer ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_TeredoServer" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersThermalZoneInformation ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_ThermalZoneInformation" ) }
        ,  { typeof ( Win32PerfRawDataCountersThermalZoneInformation ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_ThermalZoneInformation" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPPortAverageInboundNetworkTraffic ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_VFPPortAverageInboundNetworkTraffic" ) }
        ,  { typeof ( Win32PerfRawDataCountersVFPPortAverageInboundNetworkTraffic ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_VFPPortAverageInboundNetworkTraffic" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPPortAverageOutboundNetworkTraffic ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_VFPPortAverageOutboundNetworkTraffic" ) }
        ,  { typeof ( Win32PerfRawDataCountersVFPPortAverageOutboundNetworkTraffic ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_VFPPortAverageOutboundNetworkTraffic" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPPortTotalInboundDroppedNetworkPackets ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_VFPPortTotalInboundDroppedNetworkPackets" ) }
        ,  { typeof ( Win32PerfRawDataCountersVFPPortTotalInboundDroppedNetworkPackets ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_VFPPortTotalInboundDroppedNetworkPackets" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPPortTotalInboundNetworkTraffic ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_VFPPortTotalInboundNetworkTraffic" ) }
        ,  { typeof ( Win32PerfRawDataCountersVFPPortTotalInboundNetworkTraffic ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_VFPPortTotalInboundNetworkTraffic" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPPortTotalOutboundDroppedNetworkPackets ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_VFPPortTotalOutboundDroppedNetworkPackets" ) }
        ,  { typeof ( Win32PerfRawDataCountersVFPPortTotalOutboundDroppedNetworkPackets ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_VFPPortTotalOutboundDroppedNetworkPackets" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPPortTotalOutboundNetworkTraffic ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_VFPPortTotalOutboundNetworkTraffic" ) }
        ,  { typeof ( Win32PerfRawDataCountersVFPPortTotalOutboundNetworkTraffic ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_VFPPortTotalOutboundNetworkTraffic" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPQoSQueueAverageInboundNetworkTraffic ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_VFPQoSQueueAverageInboundNetworkTraffic" ) }
        ,  { typeof ( Win32PerfRawDataCountersVFPQoSQueueAverageInboundNetworkTraffic ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_VFPQoSQueueAverageInboundNetworkTraffic" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPQoSQueueAverageOutboundNetworkTraffic ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_VFPQoSQueueAverageOutboundNetworkTraffic" ) }
        ,  { typeof ( Win32PerfRawDataCountersVFPQoSQueueAverageOutboundNetworkTraffic ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_VFPQoSQueueAverageOutboundNetworkTraffic" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPQoSQueueTotalInboundNetworkTraffic ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_VFPQoSQueueTotalInboundNetworkTraffic" ) }
        ,  { typeof ( Win32PerfRawDataCountersVFPQoSQueueTotalInboundNetworkTraffic ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_VFPQoSQueueTotalInboundNetworkTraffic" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPQoSQueueTotalOutboundNetworkTraffic ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_VFPQoSQueueTotalOutboundNetworkTraffic" ) }
        ,  { typeof ( Win32PerfRawDataCountersVFPQoSQueueTotalOutboundNetworkTraffic ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_VFPQoSQueueTotalOutboundNetworkTraffic" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersWFP ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_WFP" ) }
        ,  { typeof ( Win32PerfRawDataCountersWFP ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_WFP" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersWFPClassify ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_WFPClassify" ) }
        ,  { typeof ( Win32PerfRawDataCountersWFPClassify ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_WFPClassify" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersWFPReauthorization ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_WFPReauthorization" ) }
        ,  { typeof ( Win32PerfRawDataCountersWFPReauthorization ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_WFPReauthorization" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersWFPv4 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_WFPv4" ) }
        ,  { typeof ( Win32PerfRawDataCountersWFPv4 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_WFPv4" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersWFPv6 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_WFPv6" ) }
        ,  { typeof ( Win32PerfRawDataCountersWFPv6 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_WFPv6" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersWSManQuotaStatistics ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_WSManQuotaStatistics" ) }
        ,  { typeof ( Win32PerfRawDataCountersWSManQuotaStatistics ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_WSManQuotaStatistics" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersXHCICommonBuffer ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_XHCICommonBuffer" ) }
        ,  { typeof ( Win32PerfRawDataCountersXHCICommonBuffer ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_XHCICommonBuffer" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersXHCIInterrupter ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_XHCIInterrupter" ) }
        ,  { typeof ( Win32PerfRawDataCountersXHCIInterrupter ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_XHCIInterrupter" ) }
        ,  { typeof ( Win32PerfFormattedDataCountersXHCITransferRing ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Counters_XHCITransferRing" ) }
        ,  { typeof ( Win32PerfRawDataCountersXHCITransferRing ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Counters_XHCITransferRing" ) }
        ,  { typeof ( Win32PerfFormattedDataDdmCounterProviderRAS ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_DdmCounterProvider_RAS" ) }
        ,  { typeof ( Win32PerfRawDataDdmCounterProviderRAS ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_DdmCounterProvider_RAS" ) }
        ,  { typeof ( Win32PerfFormattedDataDistributedRoutingTablePerfDistributedRoutingTable ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_DistributedRoutingTablePerf_DistributedRoutingTable" ) }
        ,  { typeof ( Win32PerfRawDataDistributedRoutingTablePerfDistributedRoutingTable ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_DistributedRoutingTablePerf_DistributedRoutingTable" ) }
        ,  { typeof ( Win32PerfFormattedDataESENTDatabase ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_ESENT_Database" ) }
        ,  { typeof ( Win32PerfRawDataESENTDatabase ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_ESENT_Database" ) }
        ,  { typeof ( Win32PerfFormattedDataESENTDatabaseDatabases ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_ESENT_DatabaseDatabases" ) }
        ,  { typeof ( Win32PerfRawDataESENTDatabaseDatabases ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_ESENT_DatabaseDatabases" ) }
        ,  { typeof ( Win32PerfFormattedDataESENTDatabaseInstances ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_ESENT_DatabaseInstances" ) }
        ,  { typeof ( Win32PerfRawDataESENTDatabaseInstances ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_ESENT_DatabaseInstances" ) }
        ,  { typeof ( Win32PerfFormattedDataESENTDatabaseTableClasses ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_ESENT_DatabaseTableClasses" ) }
        ,  { typeof ( Win32PerfRawDataESENTDatabaseTableClasses ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_ESENT_DatabaseTableClasses" ) }
        ,  { typeof ( Win32PerfFormattedDataEthernetPerfProviderHyperVLegacyNetworkAdapter ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_EthernetPerfProvider_HyperVLegacyNetworkAdapter" ) }
        ,  { typeof ( Win32PerfRawDataEthernetPerfProviderHyperVLegacyNetworkAdapter ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_EthernetPerfProvider_HyperVLegacyNetworkAdapter" ) }
        ,  { typeof ( Win32PerfFormattedDataFaxServiceFaxService ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_FaxService_FaxService" ) }
        ,  { typeof ( Win32PerfRawDataFaxServiceFaxService ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_FaxService_FaxService" ) }
        ,  { typeof ( Win32PerfFormattedDataGmoPerfProviderHyperVVMSaveSnapshotandRestore ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_GmoPerfProvider_HyperVVMSaveSnapshotandRestore" ) }
        ,  { typeof ( Win32PerfRawDataGmoPerfProviderHyperVVMSaveSnapshotandRestore ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_GmoPerfProvider_HyperVVMSaveSnapshotandRestore" ) }
        ,  { typeof ( Win32PerfFormattedDataGPUPerformanceCountersGPUAdapterMemory ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_GPUPerformanceCounters_GPUAdapterMemory" ) }
        ,  { typeof ( Win32PerfRawDataGPUPerformanceCountersGPUAdapterMemory ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_GPUPerformanceCounters_GPUAdapterMemory" ) }
        ,  { typeof ( Win32PerfFormattedDataGPUPerformanceCountersGPUEngine ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_GPUPerformanceCounters_GPUEngine" ) }
        ,  { typeof ( Win32PerfRawDataGPUPerformanceCountersGPUEngine ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_GPUPerformanceCounters_GPUEngine" ) }
        ,  { typeof ( Win32PerfFormattedDataGPUPerformanceCountersGPULocalAdapterMemory ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_GPUPerformanceCounters_GPULocalAdapterMemory" ) }
        ,  { typeof ( Win32PerfRawDataGPUPerformanceCountersGPULocalAdapterMemory ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_GPUPerformanceCounters_GPULocalAdapterMemory" ) }
        ,  { typeof ( Win32PerfFormattedDataGPUPerformanceCountersGPUNonLocalAdapterMemory ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_GPUPerformanceCounters_GPUNonLocalAdapterMemory" ) }
        ,  { typeof ( Win32PerfRawDataGPUPerformanceCountersGPUNonLocalAdapterMemory ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_GPUPerformanceCounters_GPUNonLocalAdapterMemory" ) }
        ,  { typeof ( Win32PerfFormattedDataGPUPerformanceCountersGPUProcessMemory ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_GPUPerformanceCounters_GPUProcessMemory" ) }
        ,  { typeof ( Win32PerfRawDataGPUPerformanceCountersGPUProcessMemory ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_GPUPerformanceCounters_GPUProcessMemory" ) }
        ,  { typeof ( Win32PerfFormattedDataHvStatsHyperVHypervisor ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_HvStats_HyperVHypervisor" ) }
        ,  { typeof ( Win32PerfRawDataHvStatsHyperVHypervisor ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_HvStats_HyperVHypervisor" ) }
        ,  { typeof ( Win32PerfFormattedDataHvStatsHyperVHypervisorLogicalProcessor ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_HvStats_HyperVHypervisorLogicalProcessor" ) }
        ,  { typeof ( Win32PerfRawDataHvStatsHyperVHypervisorLogicalProcessor ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_HvStats_HyperVHypervisorLogicalProcessor" ) }
        ,  { typeof ( Win32PerfFormattedDataHvStatsHyperVHypervisorPartition ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_HvStats_HyperVHypervisorPartition" ) }
        ,  { typeof ( Win32PerfRawDataHvStatsHyperVHypervisorPartition ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_HvStats_HyperVHypervisorPartition" ) }
        ,  { typeof ( Win32PerfFormattedDataHvStatsHyperVHypervisorRootPartition ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_HvStats_HyperVHypervisorRootPartition" ) }
        ,  { typeof ( Win32PerfRawDataHvStatsHyperVHypervisorRootPartition ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_HvStats_HyperVHypervisorRootPartition" ) }
        ,  { typeof ( Win32PerfFormattedDataHvStatsHyperVHypervisorRootVirtualProcessor ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_HvStats_HyperVHypervisorRootVirtualProcessor" ) }
        ,  { typeof ( Win32PerfRawDataHvStatsHyperVHypervisorRootVirtualProcessor ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_HvStats_HyperVHypervisorRootVirtualProcessor" ) }
        ,  { typeof ( Win32PerfFormattedDataHvStatsHyperVHypervisorVirtualProcessor ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_HvStats_HyperVHypervisorVirtualProcessor" ) }
        ,  { typeof ( Win32PerfRawDataHvStatsHyperVHypervisorVirtualProcessor ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_HvStats_HyperVHypervisorVirtualProcessor" ) }
        ,  { typeof ( Win32PerfFormattedDataHyperVReplicaStatsHyperVReplicaVM ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_HyperVReplicaStats_HyperVReplicaVM" ) }
        ,  { typeof ( Win32PerfRawDataHyperVReplicaStatsHyperVReplicaVM ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_HyperVReplicaStats_HyperVReplicaVM" ) }
        ,  { typeof ( Win32PerfFormattedDataHyperVStorageStatsHyperVConfiguration ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_HyperVStorageStats_HyperVConfiguration" ) }
        ,  { typeof ( Win32PerfRawDataHyperVStorageStatsHyperVConfiguration ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_HyperVStorageStats_HyperVConfiguration" ) }
        ,  { typeof ( Win32PerfFormattedDataIdePerfProviderHyperVVirtualIDEControllerEmulated ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_IdePerfProvider_HyperVVirtualIDEControllerEmulated" ) }
        ,  { typeof ( Win32PerfRawDataIdePerfProviderHyperVVirtualIDEControllerEmulated ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_IdePerfProvider_HyperVVirtualIDEControllerEmulated" ) }
        ,  { typeof ( Win32PerfFormattedDataIntelStorageCountersIntelStorageCounters ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_IntelStorageCounters_IntelStorageCounters" ) }
        ,  { typeof ( Win32PerfRawDataIntelStorageCountersIntelStorageCounters ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_IntelStorageCounters_IntelStorageCounters" ) }
        ,  { typeof ( Win32PerfFormattedDataLmPerfProviderHyperVVMLiveMigration ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_LmPerfProvider_HyperVVMLiveMigration" ) }
        ,  { typeof ( Win32PerfRawDataLmPerfProviderHyperVVMLiveMigration ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_LmPerfProvider_HyperVVMLiveMigration" ) }
        ,  { typeof ( Win32PerfFormattedDataLocalSessionManagerTerminalServices ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_LocalSessionManager_TerminalServices" ) }
        ,  { typeof ( Win32PerfRawDataLocalSessionManagerTerminalServices ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_LocalSessionManager_TerminalServices" ) }
        ,  { typeof ( Win32PerfFormattedDataLsaSecurityPerProcessStatistics ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Lsa_SecurityPerProcessStatistics" ) }
        ,  { typeof ( Win32PerfRawDataLsaSecurityPerProcessStatistics ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Lsa_SecurityPerProcessStatistics" ) }
        ,  { typeof ( Win32PerfFormattedDataLsaSecuritySystemWideStatistics ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Lsa_SecuritySystemWideStatistics" ) }
        ,  { typeof ( Win32PerfRawDataLsaSecuritySystemWideStatistics ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Lsa_SecuritySystemWideStatistics" ) }
        ,  { typeof ( Win32PerfFormattedDataLSMUserInputDelayperProcess ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_LSM_UserInputDelayperProcess" ) }
        ,  { typeof ( Win32PerfRawDataLSMUserInputDelayperProcess ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_LSM_UserInputDelayperProcess" ) }
        ,  { typeof ( Win32PerfFormattedDataLSMUserInputDelayperSession ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_LSM_UserInputDelayperSession" ) }
        ,  { typeof ( Win32PerfRawDataLSMUserInputDelayperSession ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_LSM_UserInputDelayperSession" ) }
        ,  { typeof ( Win32PerfFormattedDataMicrosoftWindowsBitLockerDriverCountersProviderBitLocker ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_MicrosoftWindowsBitLockerDriverCountersProvider_BitLocker" ) }
        ,  { typeof ( Win32PerfRawDataMicrosoftWindowsBitLockerDriverCountersProviderBitLocker ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_MicrosoftWindowsBitLockerDriverCountersProvider_BitLocker" ) }
        ,  { typeof ( Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMDevice" ) }
        ,  { typeof ( Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMDevice" ) }
        ,  { typeof ( Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMTransportChannel ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMTransportChannel" ) }
        ,  { typeof ( Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMTransportChannel ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMTransportChannel" ) }
        ,  { typeof ( Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSP" ) }
        ,  { typeof ( Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSP" ) }
        ,  { typeof ( Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMDevice ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSPVMDevice" ) }
        ,  { typeof ( Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMDevice ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSPVMDevice" ) }
        ,  { typeof ( Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMTransportChannel ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSPVMTransportChannel" ) }
        ,  { typeof ( Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMTransportChannel ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSPVMTransportChannel" ) }
        ,  { typeof ( Win32PerfFormattedDataMicrosoftWindowsW32TimePerfWindowsTimeService ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_MicrosoftWindowsW32TimePerf_WindowsTimeService" ) }
        ,  { typeof ( Win32PerfRawDataMicrosoftWindowsW32TimePerfWindowsTimeService ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_MicrosoftWindowsW32TimePerf_WindowsTimeService" ) }
        ,  { typeof ( Win32PerfFormattedDataMmPerfProviderHyperVVMWorkerProcessMemoryManager ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_MmPerfProvider_HyperVVMWorkerProcessMemoryManager" ) }
        ,  { typeof ( Win32PerfRawDataMmPerfProviderHyperVVMWorkerProcessMemoryManager ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_MmPerfProvider_HyperVVMWorkerProcessMemoryManager" ) }
        ,  { typeof ( Win32PerfFormattedDataMSDTCDistributedTransactionCoordinator ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_MSDTC_DistributedTransactionCoordinator" ) }
        ,  { typeof ( Win32PerfRawDataMSDTCDistributedTransactionCoordinator ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_MSDTC_DistributedTransactionCoordinator" ) }
        ,  { typeof ( Win32PerfFormattedDataMSDTCBridge4000MSDTCBridge4000 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_MSDTCBridge4000_MSDTCBridge4000" ) }
        ,  { typeof ( Win32PerfRawDataMSDTCBridge4000MSDTCBridge4000 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_MSDTCBridge4000_MSDTCBridge4000" ) }
        ,  { typeof ( Win32PerfFormattedDataNETCLRDataNETCLRData ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NETCLRData_NETCLRData" ) }
        ,  { typeof ( Win32PerfRawDataNETCLRDataNETCLRData ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NETCLRData_NETCLRData" ) }
        ,  { typeof ( Win32PerfFormattedDataNETCLRNetworking4000NETCLRNetworking4000 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NETCLRNetworking4000_NETCLRNetworking4000" ) }
        ,  { typeof ( Win32PerfRawDataNETCLRNetworking4000NETCLRNetworking4000 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NETCLRNetworking4000_NETCLRNetworking4000" ) }
        ,  { typeof ( Win32PerfFormattedDataNETCLRNetworkingNETCLRNetworking ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NETCLRNetworking_NETCLRNetworking" ) }
        ,  { typeof ( Win32PerfRawDataNETCLRNetworkingNETCLRNetworking ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NETCLRNetworking_NETCLRNetworking" ) }
        ,  { typeof ( Win32PerfFormattedDataNETDataProviderforOracleNETDataProviderforOracle ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NETDataProviderforOracle_NETDataProviderforOracle" ) }
        ,  { typeof ( Win32PerfRawDataNETDataProviderforOracleNETDataProviderforOracle ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NETDataProviderforOracle_NETDataProviderforOracle" ) }
        ,  { typeof ( Win32PerfFormattedDataNETDataProviderforSqlServerNETDataProviderforSqlServer ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NETDataProviderforSqlServer_NETDataProviderforSqlServer" ) }
        ,  { typeof ( Win32PerfRawDataNETDataProviderforSqlServerNETDataProviderforSqlServer ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NETDataProviderforSqlServer_NETDataProviderforSqlServer" ) }
        ,  { typeof ( Win32PerfFormattedDataNETFrameworkNETCLRExceptions ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NETFramework_NETCLRExceptions" ) }
        ,  { typeof ( Win32PerfRawDataNETFrameworkNETCLRExceptions ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NETFramework_NETCLRExceptions" ) }
        ,  { typeof ( Win32PerfFormattedDataNETFrameworkNETCLRInterop ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NETFramework_NETCLRInterop" ) }
        ,  { typeof ( Win32PerfRawDataNETFrameworkNETCLRInterop ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NETFramework_NETCLRInterop" ) }
        ,  { typeof ( Win32PerfFormattedDataNETFrameworkNETCLRJit ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NETFramework_NETCLRJit" ) }
        ,  { typeof ( Win32PerfRawDataNETFrameworkNETCLRJit ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NETFramework_NETCLRJit" ) }
        ,  { typeof ( Win32PerfFormattedDataNETFrameworkNETCLRLoading ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NETFramework_NETCLRLoading" ) }
        ,  { typeof ( Win32PerfRawDataNETFrameworkNETCLRLoading ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NETFramework_NETCLRLoading" ) }
        ,  { typeof ( Win32PerfFormattedDataNETFrameworkNETCLRLocksAndThreads ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NETFramework_NETCLRLocksAndThreads" ) }
        ,  { typeof ( Win32PerfRawDataNETFrameworkNETCLRLocksAndThreads ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NETFramework_NETCLRLocksAndThreads" ) }
        ,  { typeof ( Win32PerfFormattedDataNETFrameworkNETCLRMemory ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NETFramework_NETCLRMemory" ) }
        ,  { typeof ( Win32PerfRawDataNETFrameworkNETCLRMemory ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NETFramework_NETCLRMemory" ) }
        ,  { typeof ( Win32PerfFormattedDataNETFrameworkNETCLRRemoting ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NETFramework_NETCLRRemoting" ) }
        ,  { typeof ( Win32PerfRawDataNETFrameworkNETCLRRemoting ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NETFramework_NETCLRRemoting" ) }
        ,  { typeof ( Win32PerfFormattedDataNETFrameworkNETCLRSecurity ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NETFramework_NETCLRSecurity" ) }
        ,  { typeof ( Win32PerfRawDataNETFrameworkNETCLRSecurity ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NETFramework_NETCLRSecurity" ) }
        ,  { typeof ( Win32PerfFormattedDataNETMemoryCache40NETMemoryCache40 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NETMemoryCache40_NETMemoryCache40" ) }
        ,  { typeof ( Win32PerfRawDataNETMemoryCache40NETMemoryCache40 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NETMemoryCache40_NETMemoryCache40" ) }
        ,  { typeof ( Win32PerfFormattedDataNvspNicDropReasonsStatsHyperVVirtualNetworkAdapterDropReasons ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NvspNicDropReasonsStats_HyperVVirtualNetworkAdapterDropReasons" ) }
        ,  { typeof ( Win32PerfRawDataNvspNicDropReasonsStatsHyperVVirtualNetworkAdapterDropReasons ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NvspNicDropReasonsStats_HyperVVirtualNetworkAdapterDropReasons" ) }
        ,  { typeof ( Win32PerfFormattedDataNvspNicStatsHyperVVirtualNetworkAdapter ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NvspNicStats_HyperVVirtualNetworkAdapter" ) }
        ,  { typeof ( Win32PerfRawDataNvspNicStatsHyperVVirtualNetworkAdapter ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NvspNicStats_HyperVVirtualNetworkAdapter" ) }
        ,  { typeof ( Win32PerfFormattedDataNvspNicVRSSStatsHyperVVirtualNetworkAdapterVRSS ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NvspNicVRSSStats_HyperVVirtualNetworkAdapterVRSS" ) }
        ,  { typeof ( Win32PerfRawDataNvspNicVRSSStatsHyperVVirtualNetworkAdapterVRSS ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NvspNicVRSSStats_HyperVVirtualNetworkAdapterVRSS" ) }
        ,  { typeof ( Win32PerfFormattedDataNvspPortStatsHyperVVirtualSwitchPort ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NvspPortStats_HyperVVirtualSwitchPort" ) }
        ,  { typeof ( Win32PerfRawDataNvspPortStatsHyperVVirtualSwitchPort ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NvspPortStats_HyperVVirtualSwitchPort" ) }
        ,  { typeof ( Win32PerfFormattedDataNvspSwitchProcStatsHyperVVirtualSwitchProcessor ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NvspSwitchProcStats_HyperVVirtualSwitchProcessor" ) }
        ,  { typeof ( Win32PerfRawDataNvspSwitchProcStatsHyperVVirtualSwitchProcessor ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NvspSwitchProcStats_HyperVVirtualSwitchProcessor" ) }
        ,  { typeof ( Win32PerfFormattedDataNvspSwitchStatsHyperVVirtualSwitch ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_NvspSwitchStats_HyperVVirtualSwitch" ) }
        ,  { typeof ( Win32PerfRawDataNvspSwitchStatsHyperVVirtualSwitch ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_NvspSwitchStats_HyperVVirtualSwitch" ) }
        ,  { typeof ( Win32PerfFormattedDataOfflineFilesClientSideCaching ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_OfflineFiles_ClientSideCaching" ) }
        ,  { typeof ( Win32PerfRawDataOfflineFilesClientSideCaching ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_OfflineFiles_ClientSideCaching" ) }
        ,  { typeof ( Win32PerfFormattedDataOfflineFilesOfflineFiles ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_OfflineFiles_OfflineFiles" ) }
        ,  { typeof ( Win32PerfRawDataOfflineFilesOfflineFiles ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_OfflineFiles_OfflineFiles" ) }
        ,  { typeof ( Win32PerfFormattedDataPeerDistSvcBranchCache ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PeerDistSvc_BranchCache" ) }
        ,  { typeof ( Win32PerfRawDataPeerDistSvcBranchCache ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PeerDistSvc_BranchCache" ) }
        ,  { typeof ( Win32PerfFormattedDataPeerNameResolutionProtocolPerfPeerNameResolutionProtocol ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PeerNameResolutionProtocolPerf_PeerNameResolutionProtocol" ) }
        ,  { typeof ( Win32PerfRawDataPeerNameResolutionProtocolPerfPeerNameResolutionProtocol ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PeerNameResolutionProtocolPerf_PeerNameResolutionProtocol" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfDiskLogicalDisk ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfDisk_LogicalDisk" ) }
        ,  { typeof ( Win32PerfRawDataPerfDiskLogicalDisk ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfDisk_LogicalDisk" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfDiskPhysicalDisk ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfDisk_PhysicalDisk" ) }
        ,  { typeof ( Win32PerfRawDataPerfDiskPhysicalDisk ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfDisk_PhysicalDisk" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfNetBrowser ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfNet_Browser" ) }
        ,  { typeof ( Win32PerfRawDataPerfNetBrowser ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfNet_Browser" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfNetRedirector ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfNet_Redirector" ) }
        ,  { typeof ( Win32PerfRawDataPerfNetRedirector ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfNet_Redirector" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfNetServer ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfNet_Server" ) }
        ,  { typeof ( Win32PerfRawDataPerfNetServer ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfNet_Server" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfNetServerWorkQueues ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfNet_ServerWorkQueues" ) }
        ,  { typeof ( Win32PerfRawDataPerfNetServerWorkQueues ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfNet_ServerWorkQueues" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfOSCache ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfOS_Cache" ) }
        ,  { typeof ( Win32PerfRawDataPerfOSCache ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfOS_Cache" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfOSMemory ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfOS_Memory" ) }
        ,  { typeof ( Win32PerfRawDataPerfOSMemory ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfOS_Memory" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfOSNUMANodeMemory ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfOS_NUMANodeMemory" ) }
        ,  { typeof ( Win32PerfRawDataPerfOSNUMANodeMemory ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfOS_NUMANodeMemory" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfOSObjects ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfOS_Objects" ) }
        ,  { typeof ( Win32PerfRawDataPerfOSObjects ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfOS_Objects" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfOSPagingFile ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfOS_PagingFile" ) }
        ,  { typeof ( Win32PerfRawDataPerfOSPagingFile ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfOS_PagingFile" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfOSProcessor ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfOS_Processor" ) }
        ,  { typeof ( Win32PerfRawDataPerfOSProcessor ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfOS_Processor" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfOSSystem ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfOS_System" ) }
        ,  { typeof ( Win32PerfRawDataPerfOSSystem ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfOS_System" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfProcJobObject ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfProc_JobObject" ) }
        ,  { typeof ( Win32PerfRawDataPerfProcJobObject ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfProc_JobObject" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfProcJobObjectDetails ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfProc_JobObjectDetails" ) }
        ,  { typeof ( Win32PerfRawDataPerfProcJobObjectDetails ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfProc_JobObjectDetails" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfProcProcess ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfProc_Process" ) }
        ,  { typeof ( Win32PerfRawDataPerfProcProcess ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfProc_Process" ) }
        ,  { typeof ( Win32PerfFormattedDataPerfProcThread ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PerfProc_Thread" ) }
        ,  { typeof ( Win32PerfRawDataPerfProcThread ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PerfProc_Thread" ) }
        ,  { typeof ( Win32PerfFormattedDataPowerMeterCounterEnergyMeter ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PowerMeterCounter_EnergyMeter" ) }
        ,  { typeof ( Win32PerfRawDataPowerMeterCounterEnergyMeter ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PowerMeterCounter_EnergyMeter" ) }
        ,  { typeof ( Win32PerfFormattedDataPowerMeterCounterPowerMeter ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_PowerMeterCounter_PowerMeter" ) }
        ,  { typeof ( Win32PerfRawDataPowerMeterCounterPowerMeter ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_PowerMeterCounter_PowerMeter" ) }
        ,  { typeof ( Win32PerfFormattedDataRdyboostReadyBoostCache ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_rdyboost_ReadyBoostCache" ) }
        ,  { typeof ( Win32PerfRawDataRdyboostReadyBoostCache ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_rdyboost_ReadyBoostCache" ) }
        ,  { typeof ( Win32PerfFormattedDataRemoteAccessRASPort ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_RemoteAccess_RASPort" ) }
        ,  { typeof ( Win32PerfRawDataRemoteAccessRASPort ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_RemoteAccess_RASPort" ) }
        ,  { typeof ( Win32PerfFormattedDataRemoteAccessRASTotal ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_RemoteAccess_RASTotal" ) }
        ,  { typeof ( Win32PerfRawDataRemoteAccessRASTotal ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_RemoteAccess_RASTotal" ) }
        ,  { typeof ( Win32PerfFormattedDataRemoteFXPerformanceCounterProviderRemoteFXSoftware ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_RemoteFXPerformanceCounterProvider_RemoteFXSoftware" ) }
        ,  { typeof ( Win32PerfRawDataRemoteFXPerformanceCounterProviderRemoteFXSoftware ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_RemoteFXPerformanceCounterProvider_RemoteFXSoftware" ) }
        ,  { typeof ( Win32PerfFormattedDataRemotePerfProviderHyperVVMRemoting ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_RemotePerfProvider_HyperVVMRemoting" ) }
        ,  { typeof ( Win32PerfRawDataRemotePerfProviderHyperVVMRemoting ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_RemotePerfProvider_HyperVVMRemoting" ) }
        ,  { typeof ( Win32PerfFormattedDataServiceModel4000ServiceModelEndpoint4000 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_ServiceModel4000_ServiceModelEndpoint4000" ) }
        ,  { typeof ( Win32PerfRawDataServiceModel4000ServiceModelEndpoint4000 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_ServiceModel4000_ServiceModelEndpoint4000" ) }
        ,  { typeof ( Win32PerfFormattedDataServiceModel4000ServiceModelOperation4000 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_ServiceModel4000_ServiceModelOperation4000" ) }
        ,  { typeof ( Win32PerfRawDataServiceModel4000ServiceModelOperation4000 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_ServiceModel4000_ServiceModelOperation4000" ) }
        ,  { typeof ( Win32PerfFormattedDataServiceModel4000ServiceModelService4000 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_ServiceModel4000_ServiceModelService4000" ) }
        ,  { typeof ( Win32PerfRawDataServiceModel4000ServiceModelService4000 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_ServiceModel4000_ServiceModelService4000" ) }
        ,  { typeof ( Win32PerfFormattedDataSMSvcHost4000SMSvcHost4000 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_SMSvcHost4000_SMSvcHost4000" ) }
        ,  { typeof ( Win32PerfRawDataSMSvcHost4000SMSvcHost4000 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_SMSvcHost4000_SMSvcHost4000" ) }
        ,  { typeof ( Win32PerfFormattedDataSpoolerPrintQueue ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Spooler_PrintQueue" ) }
        ,  { typeof ( Win32PerfRawDataSpoolerPrintQueue ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Spooler_PrintQueue" ) }
        ,  { typeof ( Win32PerfFormattedDataSynth3dVideoPerfProviderRemoteFXRootGPUManagement ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Synth3dVideoPerfProvider_RemoteFXRootGPUManagement" ) }
        ,  { typeof ( Win32PerfRawDataSynth3dVideoPerfProviderRemoteFXRootGPUManagement ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Synth3dVideoPerfProvider_RemoteFXRootGPUManagement" ) }
        ,  { typeof ( Win32PerfFormattedDataTapiSrvTelephony ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_TapiSrv_Telephony" ) }
        ,  { typeof ( Win32PerfRawDataTapiSrvTelephony ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_TapiSrv_Telephony" ) }
        ,  { typeof ( Win32PerfFormattedDataTcpipICMP ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Tcpip_ICMP" ) }
        ,  { typeof ( Win32PerfRawDataTcpipICMP ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Tcpip_ICMP" ) }
        ,  { typeof ( Win32PerfFormattedDataTcpipICMPv6 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Tcpip_ICMPv6" ) }
        ,  { typeof ( Win32PerfRawDataTcpipICMPv6 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Tcpip_ICMPv6" ) }
        ,  { typeof ( Win32PerfFormattedDataTcpipIPv4 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Tcpip_IPv4" ) }
        ,  { typeof ( Win32PerfRawDataTcpipIPv4 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Tcpip_IPv4" ) }
        ,  { typeof ( Win32PerfFormattedDataTcpipIPv6 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Tcpip_IPv6" ) }
        ,  { typeof ( Win32PerfRawDataTcpipIPv6 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Tcpip_IPv6" ) }
        ,  { typeof ( Win32PerfFormattedDataTcpipNBTConnection ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Tcpip_NBTConnection" ) }
        ,  { typeof ( Win32PerfRawDataTcpipNBTConnection ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Tcpip_NBTConnection" ) }
        ,  { typeof ( Win32PerfFormattedDataTcpipNetworkAdapter ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Tcpip_NetworkAdapter" ) }
        ,  { typeof ( Win32PerfRawDataTcpipNetworkAdapter ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Tcpip_NetworkAdapter" ) }
        ,  { typeof ( Win32PerfFormattedDataTcpipNetworkInterface ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Tcpip_NetworkInterface" ) }
        ,  { typeof ( Win32PerfRawDataTcpipNetworkInterface ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Tcpip_NetworkInterface" ) }
        ,  { typeof ( Win32PerfFormattedDataTcpipTCPv4 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Tcpip_TCPv4" ) }
        ,  { typeof ( Win32PerfRawDataTcpipTCPv4 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Tcpip_TCPv4" ) }
        ,  { typeof ( Win32PerfFormattedDataTcpipTCPv6 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Tcpip_TCPv6" ) }
        ,  { typeof ( Win32PerfRawDataTcpipTCPv6 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Tcpip_TCPv6" ) }
        ,  { typeof ( Win32PerfFormattedDataTcpipUDPv4 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Tcpip_UDPv4" ) }
        ,  { typeof ( Win32PerfRawDataTcpipUDPv4 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Tcpip_UDPv4" ) }
        ,  { typeof ( Win32PerfFormattedDataTcpipUDPv6 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_Tcpip_UDPv6" ) }
        ,  { typeof ( Win32PerfRawDataTcpipUDPv6 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_Tcpip_UDPv6" ) }
        ,  { typeof ( Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnostics ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_TCPIPCounters_TCPIPPerformanceDiagnostics" ) }
        ,  { typeof ( Win32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnostics ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_TCPIPCounters_TCPIPPerformanceDiagnostics" ) }
        ,  { typeof ( Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnosticsPerCPU ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_TCPIPCounters_TCPIPPerformanceDiagnosticsPerCPU" ) }
        ,  { typeof ( Win32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnosticsPerCPU ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_TCPIPCounters_TCPIPPerformanceDiagnosticsPerCPU" ) }
        ,  { typeof ( Win32PerfFormattedDataTermServiceTerminalServicesSession ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_TermService_TerminalServicesSession" ) }
        ,  { typeof ( Win32PerfRawDataTermServiceTerminalServicesSession ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_TermService_TerminalServicesSession" ) }
        ,  { typeof ( Win32PerfFormattedDataUGathererSearchGathererProjects ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_UGatherer_SearchGathererProjects" ) }
        ,  { typeof ( Win32PerfRawDataUGathererSearchGathererProjects ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_UGatherer_SearchGathererProjects" ) }
        ,  { typeof ( Win32PerfFormattedDataUGTHRSVCSearchGatherer ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_UGTHRSVC_SearchGatherer" ) }
        ,  { typeof ( Win32PerfRawDataUGTHRSVCSearchGatherer ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_UGTHRSVC_SearchGatherer" ) }
        ,  { typeof ( Win32PerfFormattedDataUsbhubNoname ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_usbhub_Noname" ) }
        ,  { typeof ( Win32PerfRawDataUsbhubNoname ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_usbhub_Noname" ) }
        ,  { typeof ( Win32PerfFormattedDataVidPerfProviderHyperVVMVidDriver ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidDriver" ) }
        ,  { typeof ( Win32PerfRawDataVidPerfProviderHyperVVMVidDriver ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_VidPerfProvider_HyperVVMVidDriver" ) }
        ,  { typeof ( Win32PerfFormattedDataVidPerfProviderHyperVVMVidNumaNode ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidNumaNode" ) }
        ,  { typeof ( Win32PerfRawDataVidPerfProviderHyperVVMVidNumaNode ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_VidPerfProvider_HyperVVMVidNumaNode" ) }
        ,  { typeof ( Win32PerfFormattedDataVidPerfProviderHyperVVMVidPartition ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidPartition" ) }
        ,  { typeof ( Win32PerfRawDataVidPerfProviderHyperVVMVidPartition ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_VidPerfProvider_HyperVVMVidPartition" ) }
        ,  { typeof ( Win32PerfFormattedDataVMBusPipeIOPerfProviderHyperVVMVirtualDevicePipeIO ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_VMBusPipeIOPerfProvider_HyperVVMVirtualDevicePipeIO" ) }
        ,  { typeof ( Win32PerfRawDataVMBusPipeIOPerfProviderHyperVVMVirtualDevicePipeIO ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_VMBusPipeIOPerfProvider_HyperVVMVirtualDevicePipeIO" ) }
        ,  { typeof ( Win32PerfFormattedDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_VmmsVirtualMachineStats_HyperVVirtualMachineHealthSummary" ) }
        ,  { typeof ( Win32PerfRawDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_VmmsVirtualMachineStats_HyperVVirtualMachineHealthSummary" ) }
        ,  { typeof ( Win32PerfFormattedDataVSmbPerfProviderHyperVVirtualSMB ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_VSmbPerfProvider_HyperVVirtualSMB" ) }
        ,  { typeof ( Win32PerfRawDataVSmbPerfProviderHyperVVirtualSMB ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_VSmbPerfProvider_HyperVVirtualSMB" ) }
        ,  { typeof ( Win32PerfFormattedDataWindowsMediaPlayerWindowsMediaPlayerMetadata ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_WindowsMediaPlayer_WindowsMediaPlayerMetadata" ) }
        ,  { typeof ( Win32PerfRawDataWindowsMediaPlayerWindowsMediaPlayerMetadata ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_WindowsMediaPlayer_WindowsMediaPlayerMetadata" ) }
        ,  { typeof ( Win32PerfFormattedDataWindowsWorkflowFoundation4000WFSystemWorkflow4000 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_WindowsWorkflowFoundation4000_WFSystemWorkflow4000" ) }
        ,  { typeof ( Win32PerfRawDataWindowsWorkflowFoundation4000WFSystemWorkflow4000 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_WindowsWorkflowFoundation4000_WFSystemWorkflow4000" ) }
        ,  { typeof ( Win32PerfFormattedDataWinNatCountersWinNAT ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_WinNatCounters_WinNAT" ) }
        ,  { typeof ( Win32PerfRawDataWinNatCountersWinNAT ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_WinNatCounters_WinNAT" ) }
        ,  { typeof ( Win32PerfFormattedDataWinNatCountersWinNATICMP ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_WinNatCounters_WinNATICMP" ) }
        ,  { typeof ( Win32PerfRawDataWinNatCountersWinNATICMP ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_WinNatCounters_WinNATICMP" ) }
        ,  { typeof ( Win32PerfFormattedDataWinNatCountersWinNATInstance ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_WinNatCounters_WinNATInstance" ) }
        ,  { typeof ( Win32PerfRawDataWinNatCountersWinNATInstance ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_WinNatCounters_WinNATInstance" ) }
        ,  { typeof ( Win32PerfFormattedDataWinNatCountersWinNATTCP ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_WinNatCounters_WinNATTCP" ) }
        ,  { typeof ( Win32PerfRawDataWinNatCountersWinNATTCP ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_WinNatCounters_WinNATTCP" ) }
        ,  { typeof ( Win32PerfFormattedDataWinNatCountersWinNATUDP ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_WinNatCounters_WinNATUDP" ) }
        ,  { typeof ( Win32PerfRawDataWinNatCountersWinNATUDP ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_WinNatCounters_WinNATUDP" ) }
        ,  { typeof ( Win32PerfFormattedDataWorkerVpProviderHyperVWorkerVirtualProcessor ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_WorkerVpProvider_HyperVWorkerVirtualProcessor" ) }
        ,  { typeof ( Win32PerfRawDataWorkerVpProviderHyperVWorkerVirtualProcessor ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_WorkerVpProvider_HyperVWorkerVirtualProcessor" ) }
        ,  { typeof ( Win32PerfFormattedDataWorkflowServiceHost4000WorkflowServiceHost4000 ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_WorkflowServiceHost4000_WorkflowServiceHost4000" ) }
        ,  { typeof ( Win32PerfRawDataWorkflowServiceHost4000WorkflowServiceHost4000 ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_WorkflowServiceHost4000_WorkflowServiceHost4000" ) }
        ,  { typeof ( Win32PerfFormattedDataWSearchIdxPiSearchIndexer ) ,  ( "root/cimv2" ,  "Win32_PerfFormattedData_WSearchIdxPi_SearchIndexer" ) }
        ,  { typeof ( Win32PerfRawDataWSearchIdxPiSearchIndexer ) ,  ( "root/cimv2" ,  "Win32_PerfRawData_WSearchIdxPi_SearchIndexer" ) }
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