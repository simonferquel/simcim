using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class InfrastructureObjectMapper : IInfrastructureObjectMapper
    {
        public string CimNamespace => "root/cimv2";
        public IInfrastructureObject Create(IInfrastructureObjectScope scope, CimInstance cimInstance)
        {
            switch (cimInstance.CimSystemProperties.ClassName)
            {
                case "__thisNAMESPACE":
                    return new ThisNAMESPACE(scope, cimInstance);
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
                case "__NAMESPACE":
                    return new NAMESPACE(scope, cimInstance);
                case "__AggregateEvent":
                    return new AggregateEvent(scope, cimInstance);
                case "__TimerNextFiring":
                    return new TimerNextFiring(scope, cimInstance);
                case "__EventFilter":
                    return new EventFilter(scope, cimInstance);
                case "__NamespaceOperationEvent":
                    return new NamespaceOperationEvent(scope, cimInstance);
                case "__NamespaceModificationEvent":
                    return new NamespaceModificationEvent(scope, cimInstance);
                case "__NamespaceDeletionEvent":
                    return new NamespaceDeletionEvent(scope, cimInstance);
                case "__NamespaceCreationEvent":
                    return new NamespaceCreationEvent(scope, cimInstance);
                case "__ClassOperationEvent":
                    return new ClassOperationEvent(scope, cimInstance);
                case "__ClassDeletionEvent":
                    return new ClassDeletionEvent(scope, cimInstance);
                case "__ClassModificationEvent":
                    return new ClassModificationEvent(scope, cimInstance);
                case "__ClassCreationEvent":
                    return new ClassCreationEvent(scope, cimInstance);
                case "__InstanceOperationEvent":
                    return new InstanceOperationEvent(scope, cimInstance);
                case "__InstanceCreationEvent":
                    return new InstanceCreationEvent(scope, cimInstance);
                case "__MethodInvocationEvent":
                    return new MethodInvocationEvent(scope, cimInstance);
                case "__InstanceModificationEvent":
                    return new InstanceModificationEvent(scope, cimInstance);
                case "__InstanceDeletionEvent":
                    return new InstanceDeletionEvent(scope, cimInstance);
                case "__TimerEvent":
                    return new TimerEvent(scope, cimInstance);
                case "__ExtrinsicEvent":
                    return new ExtrinsicEvent(scope, cimInstance);
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
                case "MSFT_SCMEvent":
                    return new MSFTSCMEvent(scope, cimInstance);
                case "MSFT_SCMEventLogEvent":
                    return new MSFTSCMEventLogEvent(scope, cimInstance);
                case "MSFT_NetSevereServiceFailed":
                    return new MSFTNetSevereServiceFailed(scope, cimInstance);
                case "MSFT_NetTransactInvalid":
                    return new MSFTNetTransactInvalid(scope, cimInstance);
                case "MSFT_NetServiceNotInteractive":
                    return new MSFTNetServiceNotInteractive(scope, cimInstance);
                case "MSFT_NetTakeOwnership":
                    return new MSFTNetTakeOwnership(scope, cimInstance);
                case "MSFT_NetServiceConfigBackoutFailed":
                    return new MSFTNetServiceConfigBackoutFailed(scope, cimInstance);
                case "MSFT_NetServiceShutdownFailed":
                    return new MSFTNetServiceShutdownFailed(scope, cimInstance);
                case "MSFT_NetServiceStartHung":
                    return new MSFTNetServiceStartHung(scope, cimInstance);
                case "MSFT_NetServiceStopControlSuccess":
                    return new MSFTNetServiceStopControlSuccess(scope, cimInstance);
                case "MSFT_NetServiceSlowStartup":
                    return new MSFTNetServiceSlowStartup(scope, cimInstance);
                case "MSFT_NetCallToFunctionFailed":
                    return new MSFTNetCallToFunctionFailed(scope, cimInstance);
                case "MSFT_NetBadAccount":
                    return new MSFTNetBadAccount(scope, cimInstance);
                case "MSFT_NetBadServiceState":
                    return new MSFTNetBadServiceState(scope, cimInstance);
                case "MSFT_NetConnectionTimeout":
                    return new MSFTNetConnectionTimeout(scope, cimInstance);
                case "MSFT_NetCircularDependencyAuto":
                    return new MSFTNetCircularDependencyAuto(scope, cimInstance);
                case "MSFT_NetServiceStartTypeChanged":
                    return new MSFTNetServiceStartTypeChanged(scope, cimInstance);
                case "MSFT_NetServiceLogonTypeNotGranted":
                    return new MSFTNetServiceLogonTypeNotGranted(scope, cimInstance);
                case "MSFT_NetServiceStartFailedGroup":
                    return new MSFTNetServiceStartFailedGroup(scope, cimInstance);
                case "MSFT_NetDependOnLaterService":
                    return new MSFTNetDependOnLaterService(scope, cimInstance);
                case "MSFT_NetFirstLogonFailedII":
                    return new MSFTNetFirstLogonFailedII(scope, cimInstance);
                case "MSFT_NetServiceDifferentPIDConnected":
                    return new MSFTNetServiceDifferentPIDConnected(scope, cimInstance);
                case "MSFT_NetServiceCrashNoAction":
                    return new MSFTNetServiceCrashNoAction(scope, cimInstance);
                case "MSFT_NetCircularDependencyDemand":
                    return new MSFTNetCircularDependencyDemand(scope, cimInstance);
                case "MSFT_NetServiceExitFailed":
                    return new MSFTNetServiceExitFailed(scope, cimInstance);
                case "MSFT_NetServiceStartFailedII":
                    return new MSFTNetServiceStartFailedII(scope, cimInstance);
                case "MSFT_NetServiceExitFailedSpecific":
                    return new MSFTNetServiceExitFailedSpecific(scope, cimInstance);
                case "MSFT_NetBootSystemDriversFailed":
                    return new MSFTNetBootSystemDriversFailed(scope, cimInstance);
                case "MSFT_NetServiceCrash":
                    return new MSFTNetServiceCrash(scope, cimInstance);
                case "MSFT_NetServiceRecoveryFailed":
                    return new MSFTNetServiceRecoveryFailed(scope, cimInstance);
                case "MSFT_NetServiceStatusSuccess":
                    return new MSFTNetServiceStatusSuccess(scope, cimInstance);
                case "MSFT_NetTransactTimeout":
                    return new MSFTNetTransactTimeout(scope, cimInstance);
                case "MSFT_NetFirstLogonFailed":
                    return new MSFTNetFirstLogonFailed(scope, cimInstance);
                case "MSFT_NetServiceControlSuccess":
                    return new MSFTNetServiceControlSuccess(scope, cimInstance);
                case "MSFT_NetServiceStartFailed":
                    return new MSFTNetServiceStartFailed(scope, cimInstance);
                case "MSFT_NetServiceStartFailedNone":
                    return new MSFTNetServiceStartFailedNone(scope, cimInstance);
                case "MSFT_NetReadfileTimeout":
                    return new MSFTNetReadfileTimeout(scope, cimInstance);
                case "MSFT_NetRevertedToLastKnownGood":
                    return new MSFTNetRevertedToLastKnownGood(scope, cimInstance);
                case "MSFT_NetCallToFunctionFailedII":
                    return new MSFTNetCallToFunctionFailedII(scope, cimInstance);
                case "MSFT_NetDependOnLaterGroup":
                    return new MSFTNetDependOnLaterGroup(scope, cimInstance);
                case "MSFT_WmiSelfEvent":
                    return new MSFTWmiSelfEvent(scope, cimInstance);
                case "MSFT_WmiEssEvent":
                    return new MSFTWmiEssEvent(scope, cimInstance);
                case "MSFT_WmiThreadPoolEvent":
                    return new MSFTWmiThreadPoolEvent(scope, cimInstance);
                case "MSFT_WmiThreadPoolThreadCreated":
                    return new MSFTWmiThreadPoolThreadCreated(scope, cimInstance);
                case "MSFT_WmiThreadPoolThreadDeleted":
                    return new MSFTWmiThreadPoolThreadDeleted(scope, cimInstance);
                case "MSFT_WmiRegisterNotificationSink":
                    return new MSFTWmiRegisterNotificationSink(scope, cimInstance);
                case "MSFT_WmiFilterEvent":
                    return new MSFTWmiFilterEvent(scope, cimInstance);
                case "MSFT_WmiFilterDeactivated":
                    return new MSFTWmiFilterDeactivated(scope, cimInstance);
                case "MSFT_WmiFilterActivated":
                    return new MSFTWmiFilterActivated(scope, cimInstance);
                case "MSFT_WmiCancelNotificationSink":
                    return new MSFTWmiCancelNotificationSink(scope, cimInstance);
                case "MSFT_WmiProviderEvent":
                    return new MSFTWmiProviderEvent(scope, cimInstance);
                case "MSFT_WmiConsumerProviderEvent":
                    return new MSFTWmiConsumerProviderEvent(scope, cimInstance);
                case "MSFT_WmiConsumerProviderSinkLoaded":
                    return new MSFTWmiConsumerProviderSinkLoaded(scope, cimInstance);
                case "MSFT_WmiConsumerProviderSinkUnloaded":
                    return new MSFTWmiConsumerProviderSinkUnloaded(scope, cimInstance);
                case "MSFT_WmiConsumerProviderUnloaded":
                    return new MSFTWmiConsumerProviderUnloaded(scope, cimInstance);
                case "MSFT_WmiConsumerProviderLoaded":
                    return new MSFTWmiConsumerProviderLoaded(scope, cimInstance);
                case "Msft_WmiProvider_OperationEvent":
                    return new MsftWmiProviderOperationEvent(scope, cimInstance);
                case "Msft_WmiProvider_ComServerLoadOperationEvent":
                    return new MsftWmiProviderComServerLoadOperationEvent(scope, cimInstance);
                case "Msft_WmiProvider_OperationEvent_Post":
                    return new MsftWmiProviderOperationEventPost(scope, cimInstance);
                case "Msft_WmiProvider_PutInstanceAsyncEvent_Post":
                    return new MsftWmiProviderPutInstanceAsyncEventPost(scope, cimInstance);
                case "Msft_WmiProvider_CreateInstanceEnumAsyncEvent_Post":
                    return new MsftWmiProviderCreateInstanceEnumAsyncEventPost(scope, cimInstance);
                case "Msft_WmiProvider_DeleteInstanceAsyncEvent_Post":
                    return new MsftWmiProviderDeleteInstanceAsyncEventPost(scope, cimInstance);
                case "Msft_WmiProvider_CancelQuery_Post":
                    return new MsftWmiProviderCancelQueryPost(scope, cimInstance);
                case "Msft_WmiProvider_NewQuery_Post":
                    return new MsftWmiProviderNewQueryPost(scope, cimInstance);
                case "Msft_WmiProvider_ProvideEvents_Post":
                    return new MsftWmiProviderProvideEventsPost(scope, cimInstance);
                case "Msft_WmiProvider_ExecQueryAsyncEvent_Post":
                    return new MsftWmiProviderExecQueryAsyncEventPost(scope, cimInstance);
                case "Msft_WmiProvider_AccessCheck_Post":
                    return new MsftWmiProviderAccessCheckPost(scope, cimInstance);
                case "Msft_WmiProvider_CreateClassEnumAsyncEvent_Post":
                    return new MsftWmiProviderCreateClassEnumAsyncEventPost(scope, cimInstance);
                case "Msft_WmiProvider_DeleteClassAsyncEvent_Post":
                    return new MsftWmiProviderDeleteClassAsyncEventPost(scope, cimInstance);
                case "Msft_WmiProvider_ExecMethodAsyncEvent_Post":
                    return new MsftWmiProviderExecMethodAsyncEventPost(scope, cimInstance);
                case "Msft_WmiProvider_GetObjectAsyncEvent_Post":
                    return new MsftWmiProviderGetObjectAsyncEventPost(scope, cimInstance);
                case "Msft_WmiProvider_PutClassAsyncEvent_Post":
                    return new MsftWmiProviderPutClassAsyncEventPost(scope, cimInstance);
                case "Msft_WmiProvider_InitializationOperationFailureEvent":
                    return new MsftWmiProviderInitializationOperationFailureEvent(scope, cimInstance);
                case "Msft_WmiProvider_InitializationOperationEvent":
                    return new MsftWmiProviderInitializationOperationEvent(scope, cimInstance);
                case "Msft_WmiProvider_LoadOperationFailureEvent":
                    return new MsftWmiProviderLoadOperationFailureEvent(scope, cimInstance);
                case "Msft_WmiProvider_ComServerLoadOperationFailureEvent":
                    return new MsftWmiProviderComServerLoadOperationFailureEvent(scope, cimInstance);
                case "Msft_WmiProvider_UnLoadOperationEvent":
                    return new MsftWmiProviderUnLoadOperationEvent(scope, cimInstance);
                case "Msft_WmiProvider_LoadOperationEvent":
                    return new MsftWmiProviderLoadOperationEvent(scope, cimInstance);
                case "Msft_WmiProvider_OperationEvent_Pre":
                    return new MsftWmiProviderOperationEventPre(scope, cimInstance);
                case "Msft_WmiProvider_DeleteInstanceAsyncEvent_Pre":
                    return new MsftWmiProviderDeleteInstanceAsyncEventPre(scope, cimInstance);
                case "Msft_WmiProvider_AccessCheck_Pre":
                    return new MsftWmiProviderAccessCheckPre(scope, cimInstance);
                case "Msft_WmiProvider_ExecQueryAsyncEvent_Pre":
                    return new MsftWmiProviderExecQueryAsyncEventPre(scope, cimInstance);
                case "Msft_WmiProvider_DeleteClassAsyncEvent_Pre":
                    return new MsftWmiProviderDeleteClassAsyncEventPre(scope, cimInstance);
                case "Msft_WmiProvider_NewQuery_Pre":
                    return new MsftWmiProviderNewQueryPre(scope, cimInstance);
                case "Msft_WmiProvider_PutInstanceAsyncEvent_Pre":
                    return new MsftWmiProviderPutInstanceAsyncEventPre(scope, cimInstance);
                case "Msft_WmiProvider_CreateClassEnumAsyncEvent_Pre":
                    return new MsftWmiProviderCreateClassEnumAsyncEventPre(scope, cimInstance);
                case "Msft_WmiProvider_ExecMethodAsyncEvent_Pre":
                    return new MsftWmiProviderExecMethodAsyncEventPre(scope, cimInstance);
                case "Msft_WmiProvider_ProvideEvents_Pre":
                    return new MsftWmiProviderProvideEventsPre(scope, cimInstance);
                case "Msft_WmiProvider_CancelQuery_Pre":
                    return new MsftWmiProviderCancelQueryPre(scope, cimInstance);
                case "Msft_WmiProvider_PutClassAsyncEvent_Pre":
                    return new MsftWmiProviderPutClassAsyncEventPre(scope, cimInstance);
                case "Msft_WmiProvider_GetObjectAsyncEvent_Pre":
                    return new MsftWmiProviderGetObjectAsyncEventPre(scope, cimInstance);
                case "Msft_WmiProvider_CreateInstanceEnumAsyncEvent_Pre":
                    return new MsftWmiProviderCreateInstanceEnumAsyncEventPre(scope, cimInstance);
                case "MSFT_WMI_GenericNonCOMEvent":
                    return new MSFTWMIGenericNonCOMEvent(scope, cimInstance);
                case "Win32_ComputerSystemEvent":
                    return new Win32ComputerSystemEvent(scope, cimInstance);
                case "Win32_ComputerShutdownEvent":
                    return new Win32ComputerShutdownEvent(scope, cimInstance);
                case "Win32_IP4RouteTableEvent":
                    return new Win32IP4RouteTableEvent(scope, cimInstance);
                case "MSFT_NCProvEvent":
                    return new MSFTNCProvEvent(scope, cimInstance);
                case "MSFT_NCProvCancelQuery":
                    return new MSFTNCProvCancelQuery(scope, cimInstance);
                case "MSFT_NCProvClientConnected":
                    return new MSFTNCProvClientConnected(scope, cimInstance);
                case "MSFT_NCProvNewQuery":
                    return new MSFTNCProvNewQuery(scope, cimInstance);
                case "MSFT_NCProvAccessCheck":
                    return new MSFTNCProvAccessCheck(scope, cimInstance);
                case "RegistryEvent":
                    return new RegistryEvent(scope, cimInstance);
                case "RegistryKeyChangeEvent":
                    return new RegistryKeyChangeEvent(scope, cimInstance);
                case "RegistryTreeChangeEvent":
                    return new RegistryTreeChangeEvent(scope, cimInstance);
                case "RegistryValueChangeEvent":
                    return new RegistryValueChangeEvent(scope, cimInstance);
                case "Win32_SystemTrace":
                    return new Win32SystemTrace(scope, cimInstance);
                case "Win32_ProcessTrace":
                    return new Win32ProcessTrace(scope, cimInstance);
                case "Win32_ProcessStartTrace":
                    return new Win32ProcessStartTrace(scope, cimInstance);
                case "Win32_ProcessStopTrace":
                    return new Win32ProcessStopTrace(scope, cimInstance);
                case "Win32_ModuleTrace":
                    return new Win32ModuleTrace(scope, cimInstance);
                case "Win32_ModuleLoadTrace":
                    return new Win32ModuleLoadTrace(scope, cimInstance);
                case "Win32_ThreadTrace":
                    return new Win32ThreadTrace(scope, cimInstance);
                case "Win32_ThreadStartTrace":
                    return new Win32ThreadStartTrace(scope, cimInstance);
                case "Win32_ThreadStopTrace":
                    return new Win32ThreadStopTrace(scope, cimInstance);
                case "Win32_PowerManagementEvent":
                    return new Win32PowerManagementEvent(scope, cimInstance);
                case "Win32_DeviceChangeEvent":
                    return new Win32DeviceChangeEvent(scope, cimInstance);
                case "Win32_SystemConfigurationChangeEvent":
                    return new Win32SystemConfigurationChangeEvent(scope, cimInstance);
                case "Win32_VolumeChangeEvent":
                    return new Win32VolumeChangeEvent(scope, cimInstance);
                case "__AbsoluteTimerInstruction":
                    return new AbsoluteTimerInstruction(scope, cimInstance);
                case "__IntervalTimerInstruction":
                    return new IntervalTimerInstruction(scope, cimInstance);
                case "__SystemSecurity":
                    return new SystemSecurity(scope, cimInstance);
                case "Win32_BaseBoard":
                    return new Win32BaseBoard(scope, cimInstance);
                case "Win32_SystemEnclosure":
                    return new Win32SystemEnclosure(scope, cimInstance);
                case "Win32_PhysicalMemoryArray":
                    return new Win32PhysicalMemoryArray(scope, cimInstance);
                case "Win32_PhysicalMedia":
                    return new Win32PhysicalMedia(scope, cimInstance);
                case "Win32_PhysicalMemory":
                    return new Win32PhysicalMemory(scope, cimInstance);
                case "Win32_OnBoardDevice":
                    return new Win32OnBoardDevice(scope, cimInstance);
                case "Win32_SystemSlot":
                    return new Win32SystemSlot(scope, cimInstance);
                case "Win32_PortConnector":
                    return new Win32PortConnector(scope, cimInstance);
                case "Win32_OperatingSystem":
                    return new Win32OperatingSystem(scope, cimInstance);
                case "Win32_Process":
                    return new Win32Process(scope, cimInstance);
                case "Win32_DiskPartition":
                    return new Win32DiskPartition(scope, cimInstance);
                case "Win32_LogicalDisk":
                    return new Win32LogicalDisk(scope, cimInstance);
                case "Win32_MappedLogicalDisk":
                    return new Win32MappedLogicalDisk(scope, cimInstance);
                case "CIM_StorageVolume":
                    return new CIMStorageVolume(scope, cimInstance);
                case "Win32_Volume":
                    return new Win32Volume(scope, cimInstance);
                case "Win32_CacheMemory":
                    return new Win32CacheMemory(scope, cimInstance);
                case "Win32_MemoryArray":
                    return new Win32MemoryArray(scope, cimInstance);
                case "Win32_MemoryDevice":
                    return new Win32MemoryDevice(scope, cimInstance);
                case "Win32_DiskDrive":
                    return new Win32DiskDrive(scope, cimInstance);
                case "Win32_CDROMDrive":
                    return new Win32CDROMDrive(scope, cimInstance);
                case "Win32_TapeDrive":
                    return new Win32TapeDrive(scope, cimInstance);
                case "Win32_Processor":
                    return new Win32Processor(scope, cimInstance);
                case "Win32_VideoController":
                    return new Win32VideoController(scope, cimInstance);
                case "Win32_SCSIController":
                    return new Win32SCSIController(scope, cimInstance);
                case "Win32_InfraredDevice":
                    return new Win32InfraredDevice(scope, cimInstance);
                case "Win32_PCMCIAController":
                    return new Win32PCMCIAController(scope, cimInstance);
                case "Win32_USBController":
                    return new Win32USBController(scope, cimInstance);
                case "Win32_SerialPort":
                    return new Win32SerialPort(scope, cimInstance);
                case "Win32_ParallelPort":
                    return new Win32ParallelPort(scope, cimInstance);
                case "Win32_IDEController":
                    return new Win32IDEController(scope, cimInstance);
                case "Win32_1394Controller":
                    return new Win321394Controller(scope, cimInstance);
                case "Win32_Battery":
                    return new Win32Battery(scope, cimInstance);
                case "Win32_PortableBattery":
                    return new Win32PortableBattery(scope, cimInstance);
                case "Win32_NetworkAdapter":
                    return new Win32NetworkAdapter(scope, cimInstance);
                case "Win32_PnPEntity":
                    return new Win32PnPEntity(scope, cimInstance);
                case "Win32_Printer":
                    return new Win32Printer(scope, cimInstance);
                case "Win32_TemperatureProbe":
                    return new Win32TemperatureProbe(scope, cimInstance);
                case "Win32_VoltageProbe":
                    return new Win32VoltageProbe(scope, cimInstance);
                case "Win32_CurrentProbe":
                    return new Win32CurrentProbe(scope, cimInstance);
                case "Win32_Bus":
                    return new Win32Bus(scope, cimInstance);
                case "Win32_Keyboard":
                    return new Win32Keyboard(scope, cimInstance);
                case "Win32_DesktopMonitor":
                    return new Win32DesktopMonitor(scope, cimInstance);
                case "Win32_PointingDevice":
                    return new Win32PointingDevice(scope, cimInstance);
                case "CIM_USBDevice":
                    return new CIMUSBDevice(scope, cimInstance);
                case "CIM_USBHub":
                    return new CIMUSBHub(scope, cimInstance);
                case "Win32_USBHub":
                    return new Win32USBHub(scope, cimInstance);
                case "Win32_SoundDevice":
                    return new Win32SoundDevice(scope, cimInstance);
                case "Win32_MotherboardDevice":
                    return new Win32MotherboardDevice(scope, cimInstance);
                case "Win32_POTSModem":
                    return new Win32POTSModem(scope, cimInstance);
                case "Win32_HeatPipe":
                    return new Win32HeatPipe(scope, cimInstance);
                case "Win32_Refrigeration":
                    return new Win32Refrigeration(scope, cimInstance);
                case "Win32_Fan":
                    return new Win32Fan(scope, cimInstance);
                case "Win32_OptionalFeature":
                    return new Win32OptionalFeature(scope, cimInstance);
                case "Win32_ComputerSystem":
                    return new Win32ComputerSystem(scope, cimInstance);
                case "Win32_NTDomain":
                    return new Win32NTDomain(scope, cimInstance);
                case "Win32_BIOS":
                    return new Win32BIOS(scope, cimInstance);
                case "Win32_SoftwareElement":
                    return new Win32SoftwareElement(scope, cimInstance);
                case "Win32_Service":
                    return new Win32Service(scope, cimInstance);
                case "Win32_TerminalService":
                    return new Win32TerminalService(scope, cimInstance);
                case "Win32_SystemDriver":
                    return new Win32SystemDriver(scope, cimInstance);
                case "Win32_PnPSignedDriver":
                    return new Win32PnPSignedDriver(scope, cimInstance);
                case "Win32_ApplicationService":
                    return new Win32ApplicationService(scope, cimInstance);
                case "Win32_PrinterDriver":
                    return new Win32PrinterDriver(scope, cimInstance);
                case "CIM_DataFile":
                    return new CIMDataFile(scope, cimInstance);
                case "Win32_ShortcutFile":
                    return new Win32ShortcutFile(scope, cimInstance);
                case "Win32_CodecFile":
                    return new Win32CodecFile(scope, cimInstance);
                case "Win32_NTEventlogFile":
                    return new Win32NTEventlogFile(scope, cimInstance);
                case "Win32_PageFile":
                    return new Win32PageFile(scope, cimInstance);
                case "Win32_Directory":
                    return new Win32Directory(scope, cimInstance);
                case "Win32_Thread":
                    return new Win32Thread(scope, cimInstance);
                case "Win32_DCOMApplication":
                    return new Win32DCOMApplication(scope, cimInstance);
                case "Win32_ScheduledJob":
                    return new Win32ScheduledJob(scope, cimInstance);
                case "Win32_PrintJob":
                    return new Win32PrintJob(scope, cimInstance);
                case "Win32_ServerSession":
                    return new Win32ServerSession(scope, cimInstance);
                case "Win32_SoftwareFeature":
                    return new Win32SoftwareFeature(scope, cimInstance);
                case "Win32_DfsNode":
                    return new Win32DfsNode(scope, cimInstance);
                case "Win32_ComponentCategory":
                    return new Win32ComponentCategory(scope, cimInstance);
                case "Win32_LogicalProgramGroupItem":
                    return new Win32LogicalProgramGroupItem(scope, cimInstance);
                case "Win32_LogicalProgramGroup":
                    return new Win32LogicalProgramGroup(scope, cimInstance);
                case "Win32_NetworkConnection":
                    return new Win32NetworkConnection(scope, cimInstance);
                case "Win32_ClassicCOMClass":
                    return new Win32ClassicCOMClass(scope, cimInstance);
                case "Win32_UserAccount":
                    return new Win32UserAccount(scope, cimInstance);
                case "Win32_Group":
                    return new Win32Group(scope, cimInstance);
                case "Win32_SystemAccount":
                    return new Win32SystemAccount(scope, cimInstance);
                case "Win32_TCPIPPrinterPort":
                    return new Win32TCPIPPrinterPort(scope, cimInstance);
                case "Win32_CommandLineAccess":
                    return new Win32CommandLineAccess(scope, cimInstance);
                case "Win32_PortResource":
                    return new Win32PortResource(scope, cimInstance);
                case "Win32_DeviceMemoryAddress":
                    return new Win32DeviceMemoryAddress(scope, cimInstance);
                case "Win32_IRQResource":
                    return new Win32IRQResource(scope, cimInstance);
                case "Win32_Environment":
                    return new Win32Environment(scope, cimInstance);
                case "Win32_DMAChannel":
                    return new Win32DMAChannel(scope, cimInstance);
                case "Win32_Share":
                    return new Win32Share(scope, cimInstance);
                case "Win32_ClusterShare":
                    return new Win32ClusterShare(scope, cimInstance);
                case "Win32_NetworkProtocol":
                    return new Win32NetworkProtocol(scope, cimInstance);
                case "Win32_ShadowProvider":
                    return new Win32ShadowProvider(scope, cimInstance);
                case "Win32_QuickFixEngineering":
                    return new Win32QuickFixEngineering(scope, cimInstance);
                case "Win32_IP4RouteTable":
                    return new Win32IP4RouteTable(scope, cimInstance);
                case "Win32_ShadowCopy":
                    return new Win32ShadowCopy(scope, cimInstance);
                case "Win32_LoadOrderGroup":
                    return new Win32LoadOrderGroup(scope, cimInstance);
                case "Win32_LogonSession":
                    return new Win32LogonSession(scope, cimInstance);
                case "Win32_ServerConnection":
                    return new Win32ServerConnection(scope, cimInstance);
                case "Win32_DfsTarget":
                    return new Win32DfsTarget(scope, cimInstance);
                case "Win32_NetworkClient":
                    return new Win32NetworkClient(scope, cimInstance);
                case "Win32_PageFileUsage":
                    return new Win32PageFileUsage(scope, cimInstance);
                case "Win32_IP4PersistedRouteTable":
                    return new Win32IP4PersistedRouteTable(scope, cimInstance);
                case "Win32_Registry":
                    return new Win32Registry(scope, cimInstance);
                case "Win32_NetworkAdapterConfiguration":
                    return new Win32NetworkAdapterConfiguration(scope, cimInstance);
                case "Win32_TimeZone":
                    return new Win32TimeZone(scope, cimInstance);
                case "Win32_PageFileSetting":
                    return new Win32PageFileSetting(scope, cimInstance);
                case "Win32_Desktop":
                    return new Win32Desktop(scope, cimInstance);
                case "Win32_ShadowContext":
                    return new Win32ShadowContext(scope, cimInstance);
                case "Win32_ServiceControl":
                    return new Win32ServiceControl(scope, cimInstance);
                case "Win32_Property":
                    return new Win32Property(scope, cimInstance);
                case "Win32_Patch":
                    return new Win32Patch(scope, cimInstance);
                case "Win32_PatchPackage":
                    return new Win32PatchPackage(scope, cimInstance);
                case "Win32_Binary":
                    return new Win32Binary(scope, cimInstance);
                case "Win32_AutochkSetting":
                    return new Win32AutochkSetting(scope, cimInstance);
                case "Win32_SerialPortConfiguration":
                    return new Win32SerialPortConfiguration(scope, cimInstance);
                case "Win32_StartupCommand":
                    return new Win32StartupCommand(scope, cimInstance);
                case "Win32_BootConfiguration":
                    return new Win32BootConfiguration(scope, cimInstance);
                case "Win32_NetworkLoginProfile":
                    return new Win32NetworkLoginProfile(scope, cimInstance);
                case "Win32_NamedJobObjectLimitSetting":
                    return new Win32NamedJobObjectLimitSetting(scope, cimInstance);
                case "CIM_VideoControllerResolution":
                    return new CIMVideoControllerResolution(scope, cimInstance);
                case "Win32_NamedJobObjectSecLimitSetting":
                    return new Win32NamedJobObjectSecLimitSetting(scope, cimInstance);
                case "Win32_DisplayConfiguration":
                    return new Win32DisplayConfiguration(scope, cimInstance);
                case "Win32_QuotaSetting":
                    return new Win32QuotaSetting(scope, cimInstance);
                case "Win32_LogicalFileSecuritySetting":
                    return new Win32LogicalFileSecuritySetting(scope, cimInstance);
                case "Win32_LogicalShareSecuritySetting":
                    return new Win32LogicalShareSecuritySetting(scope, cimInstance);
                case "Win32_DisplayControllerConfiguration":
                    return new Win32DisplayControllerConfiguration(scope, cimInstance);
                case "Win32_WMISetting":
                    return new Win32WMISetting(scope, cimInstance);
                case "Win32_OSRecoveryConfiguration":
                    return new Win32OSRecoveryConfiguration(scope, cimInstance);
                case "Win32_ClassicCOMClassSetting":
                    return new Win32ClassicCOMClassSetting(scope, cimInstance);
                case "Win32_DCOMApplicationSetting":
                    return new Win32DCOMApplicationSetting(scope, cimInstance);
                case "Win32_VideoConfiguration":
                    return new Win32VideoConfiguration(scope, cimInstance);
                case "Win32_ODBCAttribute":
                    return new Win32ODBCAttribute(scope, cimInstance);
                case "Win32_ODBCSourceAttribute":
                    return new Win32ODBCSourceAttribute(scope, cimInstance);
                case "ScriptingStandardConsumerSetting":
                    return new ScriptingStandardConsumerSetting(scope, cimInstance);
                case "Win32_PrinterConfiguration":
                    return new Win32PrinterConfiguration(scope, cimInstance);
                case "Win32_NamedJobObjectActgInfo":
                    return new Win32NamedJobObjectActgInfo(scope, cimInstance);
                case "Win32_ComputerSystemProduct":
                    return new Win32ComputerSystemProduct(scope, cimInstance);
                case "Win32_Product":
                    return new Win32Product(scope, cimInstance);
                case "SoftwareLicensingProduct":
                    return new SoftwareLicensingProduct(scope, cimInstance);
                case "SoftwareLicensingService":
                    return new SoftwareLicensingService(scope, cimInstance);
                case "SoftwareLicensingTokenActivationLicense":
                    return new SoftwareLicensingTokenActivationLicense(scope, cimInstance);
                case "Win32_UserProfile":
                    return new Win32UserProfile(scope, cimInstance);
                case "Win32_FolderRedirectionHealth":
                    return new Win32FolderRedirectionHealth(scope, cimInstance);
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
                case "__ExtendedStatus":
                    return new ExtendedStatus(scope, cimInstance);
                case "Win32_PrivilegesStatus":
                    return new Win32PrivilegesStatus(scope, cimInstance);
                case "Win32_JobObjectStatus":
                    return new Win32JobObjectStatus(scope, cimInstance);
                case "CIM_Error":
                    return new CIMError(scope, cimInstance);
                case "MSFT_WmiError":
                    return new MSFTWmiError(scope, cimInstance);
                case "MSFT_ExtendedStatus":
                    return new MSFTExtendedStatus(scope, cimInstance);
                case "__NTLMUser9X":
                    return new NTLMUser9X(scope, cimInstance);
                case "Win32_NTLogEvent":
                    return new Win32NTLogEvent(scope, cimInstance);
                case "Win32_OfflineFilesUserConfiguration":
                    return new Win32OfflineFilesUserConfiguration(scope, cimInstance);
                case "Win32_WinSAT":
                    return new Win32WinSAT(scope, cimInstance);
                case "Win32_SecurityDescriptorHelper":
                    return new Win32SecurityDescriptorHelper(scope, cimInstance);
                case "Win32_UTCTime":
                    return new Win32UTCTime(scope, cimInstance);
                case "Win32_LocalTime":
                    return new Win32LocalTime(scope, cimInstance);
                case "Win32_ShortcutAction":
                    return new Win32ShortcutAction(scope, cimInstance);
                case "Win32_ExtensionInfoAction":
                    return new Win32ExtensionInfoAction(scope, cimInstance);
                case "Win32_CreateFolderAction":
                    return new Win32CreateFolderAction(scope, cimInstance);
                case "Win32_RegistryAction":
                    return new Win32RegistryAction(scope, cimInstance);
                case "Win32_ClassInfoAction":
                    return new Win32ClassInfoAction(scope, cimInstance);
                case "Win32_SelfRegModuleAction":
                    return new Win32SelfRegModuleAction(scope, cimInstance);
                case "Win32_TypeLibraryAction":
                    return new Win32TypeLibraryAction(scope, cimInstance);
                case "Win32_BindImageAction":
                    return new Win32BindImageAction(scope, cimInstance);
                case "Win32_RemoveIniAction":
                    return new Win32RemoveIniAction(scope, cimInstance);
                case "Win32_MIMEInfoAction":
                    return new Win32MIMEInfoAction(scope, cimInstance);
                case "Win32_FontInfoAction":
                    return new Win32FontInfoAction(scope, cimInstance);
                case "Win32_PublishComponentAction":
                    return new Win32PublishComponentAction(scope, cimInstance);
                case "Win32_MoveFileAction":
                    return new Win32MoveFileAction(scope, cimInstance);
                case "Win32_DuplicateFileAction":
                    return new Win32DuplicateFileAction(scope, cimInstance);
                case "Win32_RemoveFileAction":
                    return new Win32RemoveFileAction(scope, cimInstance);
                case "Win32_OfflineFilesAssociatedItems":
                    return new Win32OfflineFilesAssociatedItems(scope, cimInstance);
                case "Msft_Providers":
                    return new MsftProviders(scope, cimInstance);
                case "Win32_OfflineFilesChangeInfo":
                    return new Win32OfflineFilesChangeInfo(scope, cimInstance);
                case "Win32_RoamingProfileMachineConfiguration":
                    return new Win32RoamingProfileMachineConfiguration(scope, cimInstance);
                case "Win32_SID":
                    return new Win32SID(scope, cimInstance);
                case "Win32_RoamingProfileUserConfiguration":
                    return new Win32RoamingProfileUserConfiguration(scope, cimInstance);
                case "Msft_WmiProvider_Counters":
                    return new MsftWmiProviderCounters(scope, cimInstance);
                case "Win32_DirectorySpecification":
                    return new Win32DirectorySpecification(scope, cimInstance);
                case "Win32_SoftwareElementCondition":
                    return new Win32SoftwareElementCondition(scope, cimInstance);
                case "Win32_ODBCDriverSpecification":
                    return new Win32ODBCDriverSpecification(scope, cimInstance);
                case "Win32_ServiceSpecification":
                    return new Win32ServiceSpecification(scope, cimInstance);
                case "Win32_FileSpecification":
                    return new Win32FileSpecification(scope, cimInstance);
                case "Win32_IniFileSpecification":
                    return new Win32IniFileSpecification(scope, cimInstance);
                case "Win32_LaunchCondition":
                    return new Win32LaunchCondition(scope, cimInstance);
                case "Win32_ODBCDataSourceSpecification":
                    return new Win32ODBCDataSourceSpecification(scope, cimInstance);
                case "Win32_ODBCTranslatorSpecification":
                    return new Win32ODBCTranslatorSpecification(scope, cimInstance);
                case "Win32_ProgIDSpecification":
                    return new Win32ProgIDSpecification(scope, cimInstance);
                case "Win32_EnvironmentSpecification":
                    return new Win32EnvironmentSpecification(scope, cimInstance);
                case "Win32_ReserveCost":
                    return new Win32ReserveCost(scope, cimInstance);
                case "Win32_Condition":
                    return new Win32Condition(scope, cimInstance);
                case "StdRegProv":
                    return new StdRegProv(scope, cimInstance);
                case "Win32_FolderRedirection":
                    return new Win32FolderRedirection(scope, cimInstance);
                case "Win32_NamedJobObject":
                    return new Win32NamedJobObject(scope, cimInstance);
                case "Win32_OfflineFilesItem":
                    return new Win32OfflineFilesItem(scope, cimInstance);
                case "Win32_OfflineFilesBackgroundSync":
                    return new Win32OfflineFilesBackgroundSync(scope, cimInstance);
                case "Win32_InstalledWin32Program":
                    return new Win32InstalledWin32Program(scope, cimInstance);
                case "Win32_RoamingUserHealthConfiguration":
                    return new Win32RoamingUserHealthConfiguration(scope, cimInstance);
                case "Win32_UserStateConfigurationControls":
                    return new Win32UserStateConfigurationControls(scope, cimInstance);
                case "Win32_OfflineFilesPinInfo":
                    return new Win32OfflineFilesPinInfo(scope, cimInstance);
                case "Win32_OfflineFilesFileSysInfo":
                    return new Win32OfflineFilesFileSysInfo(scope, cimInstance);
                case "NTEventlogProviderConfig":
                    return new NTEventlogProviderConfig(scope, cimInstance);
                case "Win32_OfflineFilesSuspendInfo":
                    return new Win32OfflineFilesSuspendInfo(scope, cimInstance);
                case "Win32_PingStatus":
                    return new Win32PingStatus(scope, cimInstance);
                case "Win32_FolderRedirectionUserConfiguration":
                    return new Win32FolderRedirectionUserConfiguration(scope, cimInstance);
                case "Win32_ReliabilityStabilityMetrics":
                    return new Win32ReliabilityStabilityMetrics(scope, cimInstance);
                case "Win32_ReliabilityRecords":
                    return new Win32ReliabilityRecords(scope, cimInstance);
                case "Win32_InstalledProgramFramework":
                    return new Win32InstalledProgramFramework(scope, cimInstance);
                case "Win32_FolderRedirectionHealthConfiguration":
                    return new Win32FolderRedirectionHealthConfiguration(scope, cimInstance);
                case "Win32_OfflineFilesMachineConfiguration":
                    return new Win32OfflineFilesMachineConfiguration(scope, cimInstance);
                case "Win32_PnPDevicePropertyString":
                    return new Win32PnPDevicePropertyString(scope, cimInstance);
                case "Win32_PnPDevicePropertyReal32Array":
                    return new Win32PnPDevicePropertyReal32Array(scope, cimInstance);
                case "Win32_PnPDevicePropertyReal64":
                    return new Win32PnPDevicePropertyReal64(scope, cimInstance);
                case "Win32_PnPDevicePropertyUint16":
                    return new Win32PnPDevicePropertyUint16(scope, cimInstance);
                case "Win32_PnPDevicePropertySint16Array":
                    return new Win32PnPDevicePropertySint16Array(scope, cimInstance);
                case "Win32_PnPDevicePropertySint64":
                    return new Win32PnPDevicePropertySint64(scope, cimInstance);
                case "Win32_PnPDevicePropertyUint8":
                    return new Win32PnPDevicePropertyUint8(scope, cimInstance);
                case "Win32_PnPDevicePropertySint8":
                    return new Win32PnPDevicePropertySint8(scope, cimInstance);
                case "Win32_PnPDevicePropertySecurityDescriptor":
                    return new Win32PnPDevicePropertySecurityDescriptor(scope, cimInstance);
                case "Win32_PnPDevicePropertyReal32":
                    return new Win32PnPDevicePropertyReal32(scope, cimInstance);
                case "Win32_PnPDevicePropertySint32":
                    return new Win32PnPDevicePropertySint32(scope, cimInstance);
                case "Win32_PnPDevicePropertyStringArray":
                    return new Win32PnPDevicePropertyStringArray(scope, cimInstance);
                case "Win32_PnPDevicePropertyUint32":
                    return new Win32PnPDevicePropertyUint32(scope, cimInstance);
                case "Win32_PnPDevicePropertyUint64":
                    return new Win32PnPDevicePropertyUint64(scope, cimInstance);
                case "Win32_PnPDevicePropertyBoolean":
                    return new Win32PnPDevicePropertyBoolean(scope, cimInstance);
                case "Win32_PnPDevicePropertyUint16Array":
                    return new Win32PnPDevicePropertyUint16Array(scope, cimInstance);
                case "Win32_PnPDevicePropertyBinary":
                    return new Win32PnPDevicePropertyBinary(scope, cimInstance);
                case "Win32_PnPDevicePropertySint32Array":
                    return new Win32PnPDevicePropertySint32Array(scope, cimInstance);
                case "Win32_PnPDevicePropertySint16":
                    return new Win32PnPDevicePropertySint16(scope, cimInstance);
                case "Win32_PnPDevicePropertyReal64Array":
                    return new Win32PnPDevicePropertyReal64Array(scope, cimInstance);
                case "Win32_PnPDevicePropertyBooleanArray":
                    return new Win32PnPDevicePropertyBooleanArray(scope, cimInstance);
                case "Win32_PnPDevicePropertyUint32Array":
                    return new Win32PnPDevicePropertyUint32Array(scope, cimInstance);
                case "Win32_PnPDevicePropertyDateTime":
                    return new Win32PnPDevicePropertyDateTime(scope, cimInstance);
                case "Win32_PnPDevicePropertySecurityDescriptorArray":
                    return new Win32PnPDevicePropertySecurityDescriptorArray(scope, cimInstance);
                case "Win32_PnPDevicePropertySint8Array":
                    return new Win32PnPDevicePropertySint8Array(scope, cimInstance);
                case "Win32_OfflineFilesCache":
                    return new Win32OfflineFilesCache(scope, cimInstance);
                case "Win32_OfflineFilesConnectionInfo":
                    return new Win32OfflineFilesConnectionInfo(scope, cimInstance);
                case "Win32_InstalledStoreProgram":
                    return new Win32InstalledStoreProgram(scope, cimInstance);
                case "Win32_DefragAnalysis":
                    return new Win32DefragAnalysis(scope, cimInstance);
                case "Win32_RoamingProfileBackgroundUploadParams":
                    return new Win32RoamingProfileBackgroundUploadParams(scope, cimInstance);
                case "Win32_RoamingProfileSlowLinkParams":
                    return new Win32RoamingProfileSlowLinkParams(scope, cimInstance);
                case "Win32_OfflineFilesDiskSpaceLimit":
                    return new Win32OfflineFilesDiskSpaceLimit(scope, cimInstance);
                case "Win32_OfflineFilesDirtyInfo":
                    return new Win32OfflineFilesDirtyInfo(scope, cimInstance);
                case "Win32_OfflineFilesHealth":
                    return new Win32OfflineFilesHealth(scope, cimInstance);
                case "Win32_PerfFormattedData_AFDCounters_MicrosoftWinsockBSP":
                    return new Win32PerfFormattedDataAFDCountersMicrosoftWinsockBSP(scope, cimInstance);
                case "Win32_PerfRawData_AFDCounters_MicrosoftWinsockBSP":
                    return new Win32PerfRawDataAFDCountersMicrosoftWinsockBSP(scope, cimInstance);
                case "Win32_PerfFormattedData_ASPNET4030319_ASPNETAppsv4030319":
                    return new Win32PerfFormattedDataASPNET4030319ASPNETAppsv4030319(scope, cimInstance);
                case "Win32_PerfRawData_ASPNET4030319_ASPNETAppsv4030319":
                    return new Win32PerfRawDataASPNET4030319ASPNETAppsv4030319(scope, cimInstance);
                case "Win32_PerfFormattedData_ASPNET4030319_ASPNETv4030319":
                    return new Win32PerfFormattedDataASPNET4030319ASPNETv4030319(scope, cimInstance);
                case "Win32_PerfRawData_ASPNET4030319_ASPNETv4030319":
                    return new Win32PerfRawDataASPNET4030319ASPNETv4030319(scope, cimInstance);
                case "Win32_PerfFormattedData_ASPNET_ASPNET":
                    return new Win32PerfFormattedDataASPNETASPNET(scope, cimInstance);
                case "Win32_PerfRawData_ASPNET_ASPNET":
                    return new Win32PerfRawDataASPNETASPNET(scope, cimInstance);
                case "Win32_PerfFormattedData_ASPNET_ASPNETApplications":
                    return new Win32PerfFormattedDataASPNETASPNETApplications(scope, cimInstance);
                case "Win32_PerfRawData_ASPNET_ASPNETApplications":
                    return new Win32PerfRawDataASPNETASPNETApplications(scope, cimInstance);
                case "Win32_PerfFormattedData_aspnetstate_ASPNETStateService":
                    return new Win32PerfFormattedDataAspnetstateASPNETStateService(scope, cimInstance);
                case "Win32_PerfRawData_aspnetstate_ASPNETStateService":
                    return new Win32PerfRawDataAspnetstateASPNETStateService(scope, cimInstance);
                case "Win32_PerfFormattedData_AuthorizationManager_AuthorizationManagerApplications":
                    return new Win32PerfFormattedDataAuthorizationManagerAuthorizationManagerApplications(scope, cimInstance);
                case "Win32_PerfRawData_AuthorizationManager_AuthorizationManagerApplications":
                    return new Win32PerfRawDataAuthorizationManagerAuthorizationManagerApplications(scope, cimInstance);
                case "Win32_PerfFormattedData_BalancerStats_HyperVDynamicMemoryBalancer":
                    return new Win32PerfFormattedDataBalancerStatsHyperVDynamicMemoryBalancer(scope, cimInstance);
                case "Win32_PerfRawData_BalancerStats_HyperVDynamicMemoryBalancer":
                    return new Win32PerfRawDataBalancerStatsHyperVDynamicMemoryBalancer(scope, cimInstance);
                case "Win32_PerfFormattedData_BalancerStats_HyperVDynamicMemoryVM":
                    return new Win32PerfFormattedDataBalancerStatsHyperVDynamicMemoryVM(scope, cimInstance);
                case "Win32_PerfRawData_BalancerStats_HyperVDynamicMemoryVM":
                    return new Win32PerfRawDataBalancerStatsHyperVDynamicMemoryVM(scope, cimInstance);
                case "Win32_PerfFormattedData_BITS_BITSNetUtilization":
                    return new Win32PerfFormattedDataBITSBITSNetUtilization(scope, cimInstance);
                case "Win32_PerfRawData_BITS_BITSNetUtilization":
                    return new Win32PerfRawDataBITSBITSNetUtilization(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_AppVClientStreamedDataPercentage":
                    return new Win32PerfFormattedDataCountersAppVClientStreamedDataPercentage(scope, cimInstance);
                case "Win32_PerfRawData_Counters_AppVClientStreamedDataPercentage":
                    return new Win32PerfRawDataCountersAppVClientStreamedDataPercentage(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_BluetoothDevice":
                    return new Win32PerfFormattedDataCountersBluetoothDevice(scope, cimInstance);
                case "Win32_PerfRawData_Counters_BluetoothDevice":
                    return new Win32PerfRawDataCountersBluetoothDevice(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_BluetoothRadio":
                    return new Win32PerfFormattedDataCountersBluetoothRadio(scope, cimInstance);
                case "Win32_PerfRawData_Counters_BluetoothRadio":
                    return new Win32PerfRawDataCountersBluetoothRadio(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_DNS64Global":
                    return new Win32PerfFormattedDataCountersDNS64Global(scope, cimInstance);
                case "Win32_PerfRawData_Counters_DNS64Global":
                    return new Win32PerfRawDataCountersDNS64Global(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_EventLog":
                    return new Win32PerfFormattedDataCountersEventLog(scope, cimInstance);
                case "Win32_PerfRawData_Counters_EventLog":
                    return new Win32PerfRawDataCountersEventLog(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_EventTracingforWindows":
                    return new Win32PerfFormattedDataCountersEventTracingforWindows(scope, cimInstance);
                case "Win32_PerfRawData_Counters_EventTracingforWindows":
                    return new Win32PerfRawDataCountersEventTracingforWindows(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_EventTracingforWindowsSession":
                    return new Win32PerfFormattedDataCountersEventTracingforWindowsSession(scope, cimInstance);
                case "Win32_PerfRawData_Counters_EventTracingforWindowsSession":
                    return new Win32PerfRawDataCountersEventTracingforWindowsSession(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_FileSystemDiskActivity":
                    return new Win32PerfFormattedDataCountersFileSystemDiskActivity(scope, cimInstance);
                case "Win32_PerfRawData_Counters_FileSystemDiskActivity":
                    return new Win32PerfRawDataCountersFileSystemDiskActivity(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_GenericIKEv1AuthIPandIKEv2":
                    return new Win32PerfFormattedDataCountersGenericIKEv1AuthIPandIKEv2(scope, cimInstance);
                case "Win32_PerfRawData_Counters_GenericIKEv1AuthIPandIKEv2":
                    return new Win32PerfRawDataCountersGenericIKEv1AuthIPandIKEv2(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_HTTPService":
                    return new Win32PerfFormattedDataCountersHTTPService(scope, cimInstance);
                case "Win32_PerfRawData_Counters_HTTPService":
                    return new Win32PerfRawDataCountersHTTPService(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_HTTPServiceRequestQueues":
                    return new Win32PerfFormattedDataCountersHTTPServiceRequestQueues(scope, cimInstance);
                case "Win32_PerfRawData_Counters_HTTPServiceRequestQueues":
                    return new Win32PerfRawDataCountersHTTPServiceRequestQueues(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_HTTPServiceUrlGroups":
                    return new Win32PerfFormattedDataCountersHTTPServiceUrlGroups(scope, cimInstance);
                case "Win32_PerfRawData_Counters_HTTPServiceUrlGroups":
                    return new Win32PerfRawDataCountersHTTPServiceUrlGroups(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_HyperVDynamicMemoryIntegrationService":
                    return new Win32PerfFormattedDataCountersHyperVDynamicMemoryIntegrationService(scope, cimInstance);
                case "Win32_PerfRawData_Counters_HyperVDynamicMemoryIntegrationService":
                    return new Win32PerfRawDataCountersHyperVDynamicMemoryIntegrationService(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_HyperVVirtualMachineBus":
                    return new Win32PerfFormattedDataCountersHyperVVirtualMachineBus(scope, cimInstance);
                case "Win32_PerfRawData_Counters_HyperVVirtualMachineBus":
                    return new Win32PerfRawDataCountersHyperVVirtualMachineBus(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_HyperVVirtualMachineBusPipes":
                    return new Win32PerfFormattedDataCountersHyperVVirtualMachineBusPipes(scope, cimInstance);
                case "Win32_PerfRawData_Counters_HyperVVirtualMachineBusPipes":
                    return new Win32PerfRawDataCountersHyperVVirtualMachineBusPipes(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_HyperVVirtualMachineBusProviderPipes":
                    return new Win32PerfFormattedDataCountersHyperVVirtualMachineBusProviderPipes(scope, cimInstance);
                case "Win32_PerfRawData_Counters_HyperVVirtualMachineBusProviderPipes":
                    return new Win32PerfRawDataCountersHyperVVirtualMachineBusProviderPipes(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_HyperVVirtualStorageDevice":
                    return new Win32PerfFormattedDataCountersHyperVVirtualStorageDevice(scope, cimInstance);
                case "Win32_PerfRawData_Counters_HyperVVirtualStorageDevice":
                    return new Win32PerfRawDataCountersHyperVVirtualStorageDevice(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPHTTPSGlobal":
                    return new Win32PerfFormattedDataCountersIPHTTPSGlobal(scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPHTTPSGlobal":
                    return new Win32PerfRawDataCountersIPHTTPSGlobal(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPHTTPSSession":
                    return new Win32PerfFormattedDataCountersIPHTTPSSession(scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPHTTPSSession":
                    return new Win32PerfRawDataCountersIPHTTPSSession(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPsecAuthIPIPv4":
                    return new Win32PerfFormattedDataCountersIPsecAuthIPIPv4(scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPsecAuthIPIPv4":
                    return new Win32PerfRawDataCountersIPsecAuthIPIPv4(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPsecAuthIPIPv6":
                    return new Win32PerfFormattedDataCountersIPsecAuthIPIPv6(scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPsecAuthIPIPv6":
                    return new Win32PerfRawDataCountersIPsecAuthIPIPv6(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPsecConnections":
                    return new Win32PerfFormattedDataCountersIPsecConnections(scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPsecConnections":
                    return new Win32PerfRawDataCountersIPsecConnections(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPsecDriver":
                    return new Win32PerfFormattedDataCountersIPsecDriver(scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPsecDriver":
                    return new Win32PerfRawDataCountersIPsecDriver(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPsecIKEv1IPv4":
                    return new Win32PerfFormattedDataCountersIPsecIKEv1IPv4(scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPsecIKEv1IPv4":
                    return new Win32PerfRawDataCountersIPsecIKEv1IPv4(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPsecIKEv1IPv6":
                    return new Win32PerfFormattedDataCountersIPsecIKEv1IPv6(scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPsecIKEv1IPv6":
                    return new Win32PerfRawDataCountersIPsecIKEv1IPv6(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPsecIKEv2IPv4":
                    return new Win32PerfFormattedDataCountersIPsecIKEv2IPv4(scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPsecIKEv2IPv4":
                    return new Win32PerfRawDataCountersIPsecIKEv2IPv4(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_IPsecIKEv2IPv6":
                    return new Win32PerfFormattedDataCountersIPsecIKEv2IPv6(scope, cimInstance);
                case "Win32_PerfRawData_Counters_IPsecIKEv2IPv6":
                    return new Win32PerfRawDataCountersIPsecIKEv2IPv6(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_Netlogon":
                    return new Win32PerfFormattedDataCountersNetlogon(scope, cimInstance);
                case "Win32_PerfRawData_Counters_Netlogon":
                    return new Win32PerfRawDataCountersNetlogon(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_NetworkQoSPolicy":
                    return new Win32PerfFormattedDataCountersNetworkQoSPolicy(scope, cimInstance);
                case "Win32_PerfRawData_Counters_NetworkQoSPolicy":
                    return new Win32PerfRawDataCountersNetworkQoSPolicy(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_Nodejs":
                    return new Win32PerfFormattedDataCountersNodejs(scope, cimInstance);
                case "Win32_PerfRawData_Counters_Nodejs":
                    return new Win32PerfRawDataCountersNodejs(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PacerFlow":
                    return new Win32PerfFormattedDataCountersPacerFlow(scope, cimInstance);
                case "Win32_PerfRawData_Counters_PacerFlow":
                    return new Win32PerfRawDataCountersPacerFlow(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PacerPipe":
                    return new Win32PerfFormattedDataCountersPacerPipe(scope, cimInstance);
                case "Win32_PerfRawData_Counters_PacerPipe":
                    return new Win32PerfRawDataCountersPacerPipe(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PacketDirectECUtilization":
                    return new Win32PerfFormattedDataCountersPacketDirectECUtilization(scope, cimInstance);
                case "Win32_PerfRawData_Counters_PacketDirectECUtilization":
                    return new Win32PerfRawDataCountersPacketDirectECUtilization(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PacketDirectQueueDepth":
                    return new Win32PerfFormattedDataCountersPacketDirectQueueDepth(scope, cimInstance);
                case "Win32_PerfRawData_Counters_PacketDirectQueueDepth":
                    return new Win32PerfRawDataCountersPacketDirectQueueDepth(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PacketDirectReceiveCounters":
                    return new Win32PerfFormattedDataCountersPacketDirectReceiveCounters(scope, cimInstance);
                case "Win32_PerfRawData_Counters_PacketDirectReceiveCounters":
                    return new Win32PerfRawDataCountersPacketDirectReceiveCounters(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PacketDirectReceiveFilters":
                    return new Win32PerfFormattedDataCountersPacketDirectReceiveFilters(scope, cimInstance);
                case "Win32_PerfRawData_Counters_PacketDirectReceiveFilters":
                    return new Win32PerfRawDataCountersPacketDirectReceiveFilters(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PacketDirectTransmitCounters":
                    return new Win32PerfFormattedDataCountersPacketDirectTransmitCounters(scope, cimInstance);
                case "Win32_PerfRawData_Counters_PacketDirectTransmitCounters":
                    return new Win32PerfRawDataCountersPacketDirectTransmitCounters(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PerProcessorNetworkActivityCycles":
                    return new Win32PerfFormattedDataCountersPerProcessorNetworkActivityCycles(scope, cimInstance);
                case "Win32_PerfRawData_Counters_PerProcessorNetworkActivityCycles":
                    return new Win32PerfRawDataCountersPerProcessorNetworkActivityCycles(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PerProcessorNetworkInterfaceCardActivity":
                    return new Win32PerfFormattedDataCountersPerProcessorNetworkInterfaceCardActivity(scope, cimInstance);
                case "Win32_PerfRawData_Counters_PerProcessorNetworkInterfaceCardActivity":
                    return new Win32PerfRawDataCountersPerProcessorNetworkInterfaceCardActivity(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PhysicalNetworkInterfaceCardActivity":
                    return new Win32PerfFormattedDataCountersPhysicalNetworkInterfaceCardActivity(scope, cimInstance);
                case "Win32_PerfRawData_Counters_PhysicalNetworkInterfaceCardActivity":
                    return new Win32PerfRawDataCountersPhysicalNetworkInterfaceCardActivity(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_PowerShellWorkflow":
                    return new Win32PerfFormattedDataCountersPowerShellWorkflow(scope, cimInstance);
                case "Win32_PerfRawData_Counters_PowerShellWorkflow":
                    return new Win32PerfRawDataCountersPowerShellWorkflow(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_ProcessorInformation":
                    return new Win32PerfFormattedDataCountersProcessorInformation(scope, cimInstance);
                case "Win32_PerfRawData_Counters_ProcessorInformation":
                    return new Win32PerfRawDataCountersProcessorInformation(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_RDMAActivity":
                    return new Win32PerfFormattedDataCountersRDMAActivity(scope, cimInstance);
                case "Win32_PerfRawData_Counters_RDMAActivity":
                    return new Win32PerfRawDataCountersRDMAActivity(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_ReFS":
                    return new Win32PerfFormattedDataCountersReFS(scope, cimInstance);
                case "Win32_PerfRawData_Counters_ReFS":
                    return new Win32PerfRawDataCountersReFS(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_RemoteFXGraphics":
                    return new Win32PerfFormattedDataCountersRemoteFXGraphics(scope, cimInstance);
                case "Win32_PerfRawData_Counters_RemoteFXGraphics":
                    return new Win32PerfRawDataCountersRemoteFXGraphics(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_RemoteFXNetwork":
                    return new Win32PerfFormattedDataCountersRemoteFXNetwork(scope, cimInstance);
                case "Win32_PerfRawData_Counters_RemoteFXNetwork":
                    return new Win32PerfRawDataCountersRemoteFXNetwork(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_SMBClientShares":
                    return new Win32PerfFormattedDataCountersSMBClientShares(scope, cimInstance);
                case "Win32_PerfRawData_Counters_SMBClientShares":
                    return new Win32PerfRawDataCountersSMBClientShares(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_SMBDirectConnection":
                    return new Win32PerfFormattedDataCountersSMBDirectConnection(scope, cimInstance);
                case "Win32_PerfRawData_Counters_SMBDirectConnection":
                    return new Win32PerfRawDataCountersSMBDirectConnection(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_SMBServer":
                    return new Win32PerfFormattedDataCountersSMBServer(scope, cimInstance);
                case "Win32_PerfRawData_Counters_SMBServer":
                    return new Win32PerfRawDataCountersSMBServer(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_SMBServerSessions":
                    return new Win32PerfFormattedDataCountersSMBServerSessions(scope, cimInstance);
                case "Win32_PerfRawData_Counters_SMBServerSessions":
                    return new Win32PerfRawDataCountersSMBServerSessions(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_SMBServerShares":
                    return new Win32PerfFormattedDataCountersSMBServerShares(scope, cimInstance);
                case "Win32_PerfRawData_Counters_SMBServerShares":
                    return new Win32PerfRawDataCountersSMBServerShares(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_StorageQoSFilterFlow":
                    return new Win32PerfFormattedDataCountersStorageQoSFilterFlow(scope, cimInstance);
                case "Win32_PerfRawData_Counters_StorageQoSFilterFlow":
                    return new Win32PerfRawDataCountersStorageQoSFilterFlow(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_StorageQoSFilterVolume":
                    return new Win32PerfFormattedDataCountersStorageQoSFilterVolume(scope, cimInstance);
                case "Win32_PerfRawData_Counters_StorageQoSFilterVolume":
                    return new Win32PerfRawDataCountersStorageQoSFilterVolume(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_StorageSpacesDrt":
                    return new Win32PerfFormattedDataCountersStorageSpacesDrt(scope, cimInstance);
                case "Win32_PerfRawData_Counters_StorageSpacesDrt":
                    return new Win32PerfRawDataCountersStorageSpacesDrt(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_StorageSpacesTier":
                    return new Win32PerfFormattedDataCountersStorageSpacesTier(scope, cimInstance);
                case "Win32_PerfRawData_Counters_StorageSpacesTier":
                    return new Win32PerfRawDataCountersStorageSpacesTier(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_StorageSpacesVirtualDisk":
                    return new Win32PerfFormattedDataCountersStorageSpacesVirtualDisk(scope, cimInstance);
                case "Win32_PerfRawData_Counters_StorageSpacesVirtualDisk":
                    return new Win32PerfRawDataCountersStorageSpacesVirtualDisk(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_StorageSpacesWriteCache":
                    return new Win32PerfFormattedDataCountersStorageSpacesWriteCache(scope, cimInstance);
                case "Win32_PerfRawData_Counters_StorageSpacesWriteCache":
                    return new Win32PerfRawDataCountersStorageSpacesWriteCache(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_Synchronization":
                    return new Win32PerfFormattedDataCountersSynchronization(scope, cimInstance);
                case "Win32_PerfRawData_Counters_Synchronization":
                    return new Win32PerfRawDataCountersSynchronization(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_SynchronizationNuma":
                    return new Win32PerfFormattedDataCountersSynchronizationNuma(scope, cimInstance);
                case "Win32_PerfRawData_Counters_SynchronizationNuma":
                    return new Win32PerfRawDataCountersSynchronizationNuma(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_TeredoClient":
                    return new Win32PerfFormattedDataCountersTeredoClient(scope, cimInstance);
                case "Win32_PerfRawData_Counters_TeredoClient":
                    return new Win32PerfRawDataCountersTeredoClient(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_TeredoRelay":
                    return new Win32PerfFormattedDataCountersTeredoRelay(scope, cimInstance);
                case "Win32_PerfRawData_Counters_TeredoRelay":
                    return new Win32PerfRawDataCountersTeredoRelay(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_TeredoServer":
                    return new Win32PerfFormattedDataCountersTeredoServer(scope, cimInstance);
                case "Win32_PerfRawData_Counters_TeredoServer":
                    return new Win32PerfRawDataCountersTeredoServer(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_ThermalZoneInformation":
                    return new Win32PerfFormattedDataCountersThermalZoneInformation(scope, cimInstance);
                case "Win32_PerfRawData_Counters_ThermalZoneInformation":
                    return new Win32PerfRawDataCountersThermalZoneInformation(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPPortAverageInboundNetworkTraffic":
                    return new Win32PerfFormattedDataCountersVFPPortAverageInboundNetworkTraffic(scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPPortAverageInboundNetworkTraffic":
                    return new Win32PerfRawDataCountersVFPPortAverageInboundNetworkTraffic(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPPortAverageOutboundNetworkTraffic":
                    return new Win32PerfFormattedDataCountersVFPPortAverageOutboundNetworkTraffic(scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPPortAverageOutboundNetworkTraffic":
                    return new Win32PerfRawDataCountersVFPPortAverageOutboundNetworkTraffic(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPPortTotalInboundDroppedNetworkPackets":
                    return new Win32PerfFormattedDataCountersVFPPortTotalInboundDroppedNetworkPackets(scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPPortTotalInboundDroppedNetworkPackets":
                    return new Win32PerfRawDataCountersVFPPortTotalInboundDroppedNetworkPackets(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPPortTotalInboundNetworkTraffic":
                    return new Win32PerfFormattedDataCountersVFPPortTotalInboundNetworkTraffic(scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPPortTotalInboundNetworkTraffic":
                    return new Win32PerfRawDataCountersVFPPortTotalInboundNetworkTraffic(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPPortTotalOutboundDroppedNetworkPackets":
                    return new Win32PerfFormattedDataCountersVFPPortTotalOutboundDroppedNetworkPackets(scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPPortTotalOutboundDroppedNetworkPackets":
                    return new Win32PerfRawDataCountersVFPPortTotalOutboundDroppedNetworkPackets(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPPortTotalOutboundNetworkTraffic":
                    return new Win32PerfFormattedDataCountersVFPPortTotalOutboundNetworkTraffic(scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPPortTotalOutboundNetworkTraffic":
                    return new Win32PerfRawDataCountersVFPPortTotalOutboundNetworkTraffic(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPQoSQueueAverageInboundNetworkTraffic":
                    return new Win32PerfFormattedDataCountersVFPQoSQueueAverageInboundNetworkTraffic(scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPQoSQueueAverageInboundNetworkTraffic":
                    return new Win32PerfRawDataCountersVFPQoSQueueAverageInboundNetworkTraffic(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPQoSQueueAverageOutboundNetworkTraffic":
                    return new Win32PerfFormattedDataCountersVFPQoSQueueAverageOutboundNetworkTraffic(scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPQoSQueueAverageOutboundNetworkTraffic":
                    return new Win32PerfRawDataCountersVFPQoSQueueAverageOutboundNetworkTraffic(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPQoSQueueTotalInboundNetworkTraffic":
                    return new Win32PerfFormattedDataCountersVFPQoSQueueTotalInboundNetworkTraffic(scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPQoSQueueTotalInboundNetworkTraffic":
                    return new Win32PerfRawDataCountersVFPQoSQueueTotalInboundNetworkTraffic(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_VFPQoSQueueTotalOutboundNetworkTraffic":
                    return new Win32PerfFormattedDataCountersVFPQoSQueueTotalOutboundNetworkTraffic(scope, cimInstance);
                case "Win32_PerfRawData_Counters_VFPQoSQueueTotalOutboundNetworkTraffic":
                    return new Win32PerfRawDataCountersVFPQoSQueueTotalOutboundNetworkTraffic(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_WFP":
                    return new Win32PerfFormattedDataCountersWFP(scope, cimInstance);
                case "Win32_PerfRawData_Counters_WFP":
                    return new Win32PerfRawDataCountersWFP(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_WFPClassify":
                    return new Win32PerfFormattedDataCountersWFPClassify(scope, cimInstance);
                case "Win32_PerfRawData_Counters_WFPClassify":
                    return new Win32PerfRawDataCountersWFPClassify(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_WFPReauthorization":
                    return new Win32PerfFormattedDataCountersWFPReauthorization(scope, cimInstance);
                case "Win32_PerfRawData_Counters_WFPReauthorization":
                    return new Win32PerfRawDataCountersWFPReauthorization(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_WFPv4":
                    return new Win32PerfFormattedDataCountersWFPv4(scope, cimInstance);
                case "Win32_PerfRawData_Counters_WFPv4":
                    return new Win32PerfRawDataCountersWFPv4(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_WFPv6":
                    return new Win32PerfFormattedDataCountersWFPv6(scope, cimInstance);
                case "Win32_PerfRawData_Counters_WFPv6":
                    return new Win32PerfRawDataCountersWFPv6(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_WSManQuotaStatistics":
                    return new Win32PerfFormattedDataCountersWSManQuotaStatistics(scope, cimInstance);
                case "Win32_PerfRawData_Counters_WSManQuotaStatistics":
                    return new Win32PerfRawDataCountersWSManQuotaStatistics(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_XHCICommonBuffer":
                    return new Win32PerfFormattedDataCountersXHCICommonBuffer(scope, cimInstance);
                case "Win32_PerfRawData_Counters_XHCICommonBuffer":
                    return new Win32PerfRawDataCountersXHCICommonBuffer(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_XHCIInterrupter":
                    return new Win32PerfFormattedDataCountersXHCIInterrupter(scope, cimInstance);
                case "Win32_PerfRawData_Counters_XHCIInterrupter":
                    return new Win32PerfRawDataCountersXHCIInterrupter(scope, cimInstance);
                case "Win32_PerfFormattedData_Counters_XHCITransferRing":
                    return new Win32PerfFormattedDataCountersXHCITransferRing(scope, cimInstance);
                case "Win32_PerfRawData_Counters_XHCITransferRing":
                    return new Win32PerfRawDataCountersXHCITransferRing(scope, cimInstance);
                case "Win32_PerfFormattedData_DdmCounterProvider_RAS":
                    return new Win32PerfFormattedDataDdmCounterProviderRAS(scope, cimInstance);
                case "Win32_PerfRawData_DdmCounterProvider_RAS":
                    return new Win32PerfRawDataDdmCounterProviderRAS(scope, cimInstance);
                case "Win32_PerfFormattedData_DistributedRoutingTablePerf_DistributedRoutingTable":
                    return new Win32PerfFormattedDataDistributedRoutingTablePerfDistributedRoutingTable(scope, cimInstance);
                case "Win32_PerfRawData_DistributedRoutingTablePerf_DistributedRoutingTable":
                    return new Win32PerfRawDataDistributedRoutingTablePerfDistributedRoutingTable(scope, cimInstance);
                case "Win32_PerfFormattedData_ESENT_Database":
                    return new Win32PerfFormattedDataESENTDatabase(scope, cimInstance);
                case "Win32_PerfRawData_ESENT_Database":
                    return new Win32PerfRawDataESENTDatabase(scope, cimInstance);
                case "Win32_PerfFormattedData_ESENT_DatabaseDatabases":
                    return new Win32PerfFormattedDataESENTDatabaseDatabases(scope, cimInstance);
                case "Win32_PerfRawData_ESENT_DatabaseDatabases":
                    return new Win32PerfRawDataESENTDatabaseDatabases(scope, cimInstance);
                case "Win32_PerfFormattedData_ESENT_DatabaseInstances":
                    return new Win32PerfFormattedDataESENTDatabaseInstances(scope, cimInstance);
                case "Win32_PerfRawData_ESENT_DatabaseInstances":
                    return new Win32PerfRawDataESENTDatabaseInstances(scope, cimInstance);
                case "Win32_PerfFormattedData_ESENT_DatabaseTableClasses":
                    return new Win32PerfFormattedDataESENTDatabaseTableClasses(scope, cimInstance);
                case "Win32_PerfRawData_ESENT_DatabaseTableClasses":
                    return new Win32PerfRawDataESENTDatabaseTableClasses(scope, cimInstance);
                case "Win32_PerfFormattedData_EthernetPerfProvider_HyperVLegacyNetworkAdapter":
                    return new Win32PerfFormattedDataEthernetPerfProviderHyperVLegacyNetworkAdapter(scope, cimInstance);
                case "Win32_PerfRawData_EthernetPerfProvider_HyperVLegacyNetworkAdapter":
                    return new Win32PerfRawDataEthernetPerfProviderHyperVLegacyNetworkAdapter(scope, cimInstance);
                case "Win32_PerfFormattedData_FaxService_FaxService":
                    return new Win32PerfFormattedDataFaxServiceFaxService(scope, cimInstance);
                case "Win32_PerfRawData_FaxService_FaxService":
                    return new Win32PerfRawDataFaxServiceFaxService(scope, cimInstance);
                case "Win32_PerfFormattedData_GmoPerfProvider_HyperVVMSaveSnapshotandRestore":
                    return new Win32PerfFormattedDataGmoPerfProviderHyperVVMSaveSnapshotandRestore(scope, cimInstance);
                case "Win32_PerfRawData_GmoPerfProvider_HyperVVMSaveSnapshotandRestore":
                    return new Win32PerfRawDataGmoPerfProviderHyperVVMSaveSnapshotandRestore(scope, cimInstance);
                case "Win32_PerfFormattedData_GPUPerformanceCounters_GPUAdapterMemory":
                    return new Win32PerfFormattedDataGPUPerformanceCountersGPUAdapterMemory(scope, cimInstance);
                case "Win32_PerfRawData_GPUPerformanceCounters_GPUAdapterMemory":
                    return new Win32PerfRawDataGPUPerformanceCountersGPUAdapterMemory(scope, cimInstance);
                case "Win32_PerfFormattedData_GPUPerformanceCounters_GPUEngine":
                    return new Win32PerfFormattedDataGPUPerformanceCountersGPUEngine(scope, cimInstance);
                case "Win32_PerfRawData_GPUPerformanceCounters_GPUEngine":
                    return new Win32PerfRawDataGPUPerformanceCountersGPUEngine(scope, cimInstance);
                case "Win32_PerfFormattedData_GPUPerformanceCounters_GPULocalAdapterMemory":
                    return new Win32PerfFormattedDataGPUPerformanceCountersGPULocalAdapterMemory(scope, cimInstance);
                case "Win32_PerfRawData_GPUPerformanceCounters_GPULocalAdapterMemory":
                    return new Win32PerfRawDataGPUPerformanceCountersGPULocalAdapterMemory(scope, cimInstance);
                case "Win32_PerfFormattedData_GPUPerformanceCounters_GPUNonLocalAdapterMemory":
                    return new Win32PerfFormattedDataGPUPerformanceCountersGPUNonLocalAdapterMemory(scope, cimInstance);
                case "Win32_PerfRawData_GPUPerformanceCounters_GPUNonLocalAdapterMemory":
                    return new Win32PerfRawDataGPUPerformanceCountersGPUNonLocalAdapterMemory(scope, cimInstance);
                case "Win32_PerfFormattedData_GPUPerformanceCounters_GPUProcessMemory":
                    return new Win32PerfFormattedDataGPUPerformanceCountersGPUProcessMemory(scope, cimInstance);
                case "Win32_PerfRawData_GPUPerformanceCounters_GPUProcessMemory":
                    return new Win32PerfRawDataGPUPerformanceCountersGPUProcessMemory(scope, cimInstance);
                case "Win32_PerfFormattedData_HvStats_HyperVHypervisor":
                    return new Win32PerfFormattedDataHvStatsHyperVHypervisor(scope, cimInstance);
                case "Win32_PerfRawData_HvStats_HyperVHypervisor":
                    return new Win32PerfRawDataHvStatsHyperVHypervisor(scope, cimInstance);
                case "Win32_PerfFormattedData_HvStats_HyperVHypervisorLogicalProcessor":
                    return new Win32PerfFormattedDataHvStatsHyperVHypervisorLogicalProcessor(scope, cimInstance);
                case "Win32_PerfRawData_HvStats_HyperVHypervisorLogicalProcessor":
                    return new Win32PerfRawDataHvStatsHyperVHypervisorLogicalProcessor(scope, cimInstance);
                case "Win32_PerfFormattedData_HvStats_HyperVHypervisorPartition":
                    return new Win32PerfFormattedDataHvStatsHyperVHypervisorPartition(scope, cimInstance);
                case "Win32_PerfRawData_HvStats_HyperVHypervisorPartition":
                    return new Win32PerfRawDataHvStatsHyperVHypervisorPartition(scope, cimInstance);
                case "Win32_PerfFormattedData_HvStats_HyperVHypervisorRootPartition":
                    return new Win32PerfFormattedDataHvStatsHyperVHypervisorRootPartition(scope, cimInstance);
                case "Win32_PerfRawData_HvStats_HyperVHypervisorRootPartition":
                    return new Win32PerfRawDataHvStatsHyperVHypervisorRootPartition(scope, cimInstance);
                case "Win32_PerfFormattedData_HvStats_HyperVHypervisorRootVirtualProcessor":
                    return new Win32PerfFormattedDataHvStatsHyperVHypervisorRootVirtualProcessor(scope, cimInstance);
                case "Win32_PerfRawData_HvStats_HyperVHypervisorRootVirtualProcessor":
                    return new Win32PerfRawDataHvStatsHyperVHypervisorRootVirtualProcessor(scope, cimInstance);
                case "Win32_PerfFormattedData_HvStats_HyperVHypervisorVirtualProcessor":
                    return new Win32PerfFormattedDataHvStatsHyperVHypervisorVirtualProcessor(scope, cimInstance);
                case "Win32_PerfRawData_HvStats_HyperVHypervisorVirtualProcessor":
                    return new Win32PerfRawDataHvStatsHyperVHypervisorVirtualProcessor(scope, cimInstance);
                case "Win32_PerfFormattedData_HyperVReplicaStats_HyperVReplicaVM":
                    return new Win32PerfFormattedDataHyperVReplicaStatsHyperVReplicaVM(scope, cimInstance);
                case "Win32_PerfRawData_HyperVReplicaStats_HyperVReplicaVM":
                    return new Win32PerfRawDataHyperVReplicaStatsHyperVReplicaVM(scope, cimInstance);
                case "Win32_PerfFormattedData_HyperVStorageStats_HyperVConfiguration":
                    return new Win32PerfFormattedDataHyperVStorageStatsHyperVConfiguration(scope, cimInstance);
                case "Win32_PerfRawData_HyperVStorageStats_HyperVConfiguration":
                    return new Win32PerfRawDataHyperVStorageStatsHyperVConfiguration(scope, cimInstance);
                case "Win32_PerfFormattedData_IdePerfProvider_HyperVVirtualIDEControllerEmulated":
                    return new Win32PerfFormattedDataIdePerfProviderHyperVVirtualIDEControllerEmulated(scope, cimInstance);
                case "Win32_PerfRawData_IdePerfProvider_HyperVVirtualIDEControllerEmulated":
                    return new Win32PerfRawDataIdePerfProviderHyperVVirtualIDEControllerEmulated(scope, cimInstance);
                case "Win32_PerfFormattedData_IntelStorageCounters_IntelStorageCounters":
                    return new Win32PerfFormattedDataIntelStorageCountersIntelStorageCounters(scope, cimInstance);
                case "Win32_PerfRawData_IntelStorageCounters_IntelStorageCounters":
                    return new Win32PerfRawDataIntelStorageCountersIntelStorageCounters(scope, cimInstance);
                case "Win32_PerfFormattedData_LmPerfProvider_HyperVVMLiveMigration":
                    return new Win32PerfFormattedDataLmPerfProviderHyperVVMLiveMigration(scope, cimInstance);
                case "Win32_PerfRawData_LmPerfProvider_HyperVVMLiveMigration":
                    return new Win32PerfRawDataLmPerfProviderHyperVVMLiveMigration(scope, cimInstance);
                case "Win32_PerfFormattedData_LocalSessionManager_TerminalServices":
                    return new Win32PerfFormattedDataLocalSessionManagerTerminalServices(scope, cimInstance);
                case "Win32_PerfRawData_LocalSessionManager_TerminalServices":
                    return new Win32PerfRawDataLocalSessionManagerTerminalServices(scope, cimInstance);
                case "Win32_PerfFormattedData_Lsa_SecurityPerProcessStatistics":
                    return new Win32PerfFormattedDataLsaSecurityPerProcessStatistics(scope, cimInstance);
                case "Win32_PerfRawData_Lsa_SecurityPerProcessStatistics":
                    return new Win32PerfRawDataLsaSecurityPerProcessStatistics(scope, cimInstance);
                case "Win32_PerfFormattedData_Lsa_SecuritySystemWideStatistics":
                    return new Win32PerfFormattedDataLsaSecuritySystemWideStatistics(scope, cimInstance);
                case "Win32_PerfRawData_Lsa_SecuritySystemWideStatistics":
                    return new Win32PerfRawDataLsaSecuritySystemWideStatistics(scope, cimInstance);
                case "Win32_PerfFormattedData_LSM_UserInputDelayperProcess":
                    return new Win32PerfFormattedDataLSMUserInputDelayperProcess(scope, cimInstance);
                case "Win32_PerfRawData_LSM_UserInputDelayperProcess":
                    return new Win32PerfRawDataLSMUserInputDelayperProcess(scope, cimInstance);
                case "Win32_PerfFormattedData_LSM_UserInputDelayperSession":
                    return new Win32PerfFormattedDataLSMUserInputDelayperSession(scope, cimInstance);
                case "Win32_PerfRawData_LSM_UserInputDelayperSession":
                    return new Win32PerfRawDataLSMUserInputDelayperSession(scope, cimInstance);
                case "Win32_PerfFormattedData_MicrosoftWindowsBitLockerDriverCountersProvider_BitLocker":
                    return new Win32PerfFormattedDataMicrosoftWindowsBitLockerDriverCountersProviderBitLocker(scope, cimInstance);
                case "Win32_PerfRawData_MicrosoftWindowsBitLockerDriverCountersProvider_BitLocker":
                    return new Win32PerfRawDataMicrosoftWindowsBitLockerDriverCountersProviderBitLocker(scope, cimInstance);
                case "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMDevice":
                    return new Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice(scope, cimInstance);
                case "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMDevice":
                    return new Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice(scope, cimInstance);
                case "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMTransportChannel":
                    return new Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMTransportChannel(scope, cimInstance);
                case "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMTransportChannel":
                    return new Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMTransportChannel(scope, cimInstance);
                case "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSP":
                    return new Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP(scope, cimInstance);
                case "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSP":
                    return new Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP(scope, cimInstance);
                case "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSPVMDevice":
                    return new Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMDevice(scope, cimInstance);
                case "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSPVMDevice":
                    return new Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMDevice(scope, cimInstance);
                case "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSPVMTransportChannel":
                    return new Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMTransportChannel(scope, cimInstance);
                case "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSPVMTransportChannel":
                    return new Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMTransportChannel(scope, cimInstance);
                case "Win32_PerfFormattedData_MicrosoftWindowsW32TimePerf_WindowsTimeService":
                    return new Win32PerfFormattedDataMicrosoftWindowsW32TimePerfWindowsTimeService(scope, cimInstance);
                case "Win32_PerfRawData_MicrosoftWindowsW32TimePerf_WindowsTimeService":
                    return new Win32PerfRawDataMicrosoftWindowsW32TimePerfWindowsTimeService(scope, cimInstance);
                case "Win32_PerfFormattedData_MmPerfProvider_HyperVVMWorkerProcessMemoryManager":
                    return new Win32PerfFormattedDataMmPerfProviderHyperVVMWorkerProcessMemoryManager(scope, cimInstance);
                case "Win32_PerfRawData_MmPerfProvider_HyperVVMWorkerProcessMemoryManager":
                    return new Win32PerfRawDataMmPerfProviderHyperVVMWorkerProcessMemoryManager(scope, cimInstance);
                case "Win32_PerfFormattedData_MSDTC_DistributedTransactionCoordinator":
                    return new Win32PerfFormattedDataMSDTCDistributedTransactionCoordinator(scope, cimInstance);
                case "Win32_PerfRawData_MSDTC_DistributedTransactionCoordinator":
                    return new Win32PerfRawDataMSDTCDistributedTransactionCoordinator(scope, cimInstance);
                case "Win32_PerfFormattedData_MSDTCBridge4000_MSDTCBridge4000":
                    return new Win32PerfFormattedDataMSDTCBridge4000MSDTCBridge4000(scope, cimInstance);
                case "Win32_PerfRawData_MSDTCBridge4000_MSDTCBridge4000":
                    return new Win32PerfRawDataMSDTCBridge4000MSDTCBridge4000(scope, cimInstance);
                case "Win32_PerfFormattedData_NETCLRData_NETCLRData":
                    return new Win32PerfFormattedDataNETCLRDataNETCLRData(scope, cimInstance);
                case "Win32_PerfRawData_NETCLRData_NETCLRData":
                    return new Win32PerfRawDataNETCLRDataNETCLRData(scope, cimInstance);
                case "Win32_PerfFormattedData_NETCLRNetworking4000_NETCLRNetworking4000":
                    return new Win32PerfFormattedDataNETCLRNetworking4000NETCLRNetworking4000(scope, cimInstance);
                case "Win32_PerfRawData_NETCLRNetworking4000_NETCLRNetworking4000":
                    return new Win32PerfRawDataNETCLRNetworking4000NETCLRNetworking4000(scope, cimInstance);
                case "Win32_PerfFormattedData_NETCLRNetworking_NETCLRNetworking":
                    return new Win32PerfFormattedDataNETCLRNetworkingNETCLRNetworking(scope, cimInstance);
                case "Win32_PerfRawData_NETCLRNetworking_NETCLRNetworking":
                    return new Win32PerfRawDataNETCLRNetworkingNETCLRNetworking(scope, cimInstance);
                case "Win32_PerfFormattedData_NETDataProviderforOracle_NETDataProviderforOracle":
                    return new Win32PerfFormattedDataNETDataProviderforOracleNETDataProviderforOracle(scope, cimInstance);
                case "Win32_PerfRawData_NETDataProviderforOracle_NETDataProviderforOracle":
                    return new Win32PerfRawDataNETDataProviderforOracleNETDataProviderforOracle(scope, cimInstance);
                case "Win32_PerfFormattedData_NETDataProviderforSqlServer_NETDataProviderforSqlServer":
                    return new Win32PerfFormattedDataNETDataProviderforSqlServerNETDataProviderforSqlServer(scope, cimInstance);
                case "Win32_PerfRawData_NETDataProviderforSqlServer_NETDataProviderforSqlServer":
                    return new Win32PerfRawDataNETDataProviderforSqlServerNETDataProviderforSqlServer(scope, cimInstance);
                case "Win32_PerfFormattedData_NETFramework_NETCLRExceptions":
                    return new Win32PerfFormattedDataNETFrameworkNETCLRExceptions(scope, cimInstance);
                case "Win32_PerfRawData_NETFramework_NETCLRExceptions":
                    return new Win32PerfRawDataNETFrameworkNETCLRExceptions(scope, cimInstance);
                case "Win32_PerfFormattedData_NETFramework_NETCLRInterop":
                    return new Win32PerfFormattedDataNETFrameworkNETCLRInterop(scope, cimInstance);
                case "Win32_PerfRawData_NETFramework_NETCLRInterop":
                    return new Win32PerfRawDataNETFrameworkNETCLRInterop(scope, cimInstance);
                case "Win32_PerfFormattedData_NETFramework_NETCLRJit":
                    return new Win32PerfFormattedDataNETFrameworkNETCLRJit(scope, cimInstance);
                case "Win32_PerfRawData_NETFramework_NETCLRJit":
                    return new Win32PerfRawDataNETFrameworkNETCLRJit(scope, cimInstance);
                case "Win32_PerfFormattedData_NETFramework_NETCLRLoading":
                    return new Win32PerfFormattedDataNETFrameworkNETCLRLoading(scope, cimInstance);
                case "Win32_PerfRawData_NETFramework_NETCLRLoading":
                    return new Win32PerfRawDataNETFrameworkNETCLRLoading(scope, cimInstance);
                case "Win32_PerfFormattedData_NETFramework_NETCLRLocksAndThreads":
                    return new Win32PerfFormattedDataNETFrameworkNETCLRLocksAndThreads(scope, cimInstance);
                case "Win32_PerfRawData_NETFramework_NETCLRLocksAndThreads":
                    return new Win32PerfRawDataNETFrameworkNETCLRLocksAndThreads(scope, cimInstance);
                case "Win32_PerfFormattedData_NETFramework_NETCLRMemory":
                    return new Win32PerfFormattedDataNETFrameworkNETCLRMemory(scope, cimInstance);
                case "Win32_PerfRawData_NETFramework_NETCLRMemory":
                    return new Win32PerfRawDataNETFrameworkNETCLRMemory(scope, cimInstance);
                case "Win32_PerfFormattedData_NETFramework_NETCLRRemoting":
                    return new Win32PerfFormattedDataNETFrameworkNETCLRRemoting(scope, cimInstance);
                case "Win32_PerfRawData_NETFramework_NETCLRRemoting":
                    return new Win32PerfRawDataNETFrameworkNETCLRRemoting(scope, cimInstance);
                case "Win32_PerfFormattedData_NETFramework_NETCLRSecurity":
                    return new Win32PerfFormattedDataNETFrameworkNETCLRSecurity(scope, cimInstance);
                case "Win32_PerfRawData_NETFramework_NETCLRSecurity":
                    return new Win32PerfRawDataNETFrameworkNETCLRSecurity(scope, cimInstance);
                case "Win32_PerfFormattedData_NETMemoryCache40_NETMemoryCache40":
                    return new Win32PerfFormattedDataNETMemoryCache40NETMemoryCache40(scope, cimInstance);
                case "Win32_PerfRawData_NETMemoryCache40_NETMemoryCache40":
                    return new Win32PerfRawDataNETMemoryCache40NETMemoryCache40(scope, cimInstance);
                case "Win32_PerfFormattedData_NvspNicDropReasonsStats_HyperVVirtualNetworkAdapterDropReasons":
                    return new Win32PerfFormattedDataNvspNicDropReasonsStatsHyperVVirtualNetworkAdapterDropReasons(scope, cimInstance);
                case "Win32_PerfRawData_NvspNicDropReasonsStats_HyperVVirtualNetworkAdapterDropReasons":
                    return new Win32PerfRawDataNvspNicDropReasonsStatsHyperVVirtualNetworkAdapterDropReasons(scope, cimInstance);
                case "Win32_PerfFormattedData_NvspNicStats_HyperVVirtualNetworkAdapter":
                    return new Win32PerfFormattedDataNvspNicStatsHyperVVirtualNetworkAdapter(scope, cimInstance);
                case "Win32_PerfRawData_NvspNicStats_HyperVVirtualNetworkAdapter":
                    return new Win32PerfRawDataNvspNicStatsHyperVVirtualNetworkAdapter(scope, cimInstance);
                case "Win32_PerfFormattedData_NvspNicVRSSStats_HyperVVirtualNetworkAdapterVRSS":
                    return new Win32PerfFormattedDataNvspNicVRSSStatsHyperVVirtualNetworkAdapterVRSS(scope, cimInstance);
                case "Win32_PerfRawData_NvspNicVRSSStats_HyperVVirtualNetworkAdapterVRSS":
                    return new Win32PerfRawDataNvspNicVRSSStatsHyperVVirtualNetworkAdapterVRSS(scope, cimInstance);
                case "Win32_PerfFormattedData_NvspPortStats_HyperVVirtualSwitchPort":
                    return new Win32PerfFormattedDataNvspPortStatsHyperVVirtualSwitchPort(scope, cimInstance);
                case "Win32_PerfRawData_NvspPortStats_HyperVVirtualSwitchPort":
                    return new Win32PerfRawDataNvspPortStatsHyperVVirtualSwitchPort(scope, cimInstance);
                case "Win32_PerfFormattedData_NvspSwitchProcStats_HyperVVirtualSwitchProcessor":
                    return new Win32PerfFormattedDataNvspSwitchProcStatsHyperVVirtualSwitchProcessor(scope, cimInstance);
                case "Win32_PerfRawData_NvspSwitchProcStats_HyperVVirtualSwitchProcessor":
                    return new Win32PerfRawDataNvspSwitchProcStatsHyperVVirtualSwitchProcessor(scope, cimInstance);
                case "Win32_PerfFormattedData_NvspSwitchStats_HyperVVirtualSwitch":
                    return new Win32PerfFormattedDataNvspSwitchStatsHyperVVirtualSwitch(scope, cimInstance);
                case "Win32_PerfRawData_NvspSwitchStats_HyperVVirtualSwitch":
                    return new Win32PerfRawDataNvspSwitchStatsHyperVVirtualSwitch(scope, cimInstance);
                case "Win32_PerfFormattedData_OfflineFiles_ClientSideCaching":
                    return new Win32PerfFormattedDataOfflineFilesClientSideCaching(scope, cimInstance);
                case "Win32_PerfRawData_OfflineFiles_ClientSideCaching":
                    return new Win32PerfRawDataOfflineFilesClientSideCaching(scope, cimInstance);
                case "Win32_PerfFormattedData_OfflineFiles_OfflineFiles":
                    return new Win32PerfFormattedDataOfflineFilesOfflineFiles(scope, cimInstance);
                case "Win32_PerfRawData_OfflineFiles_OfflineFiles":
                    return new Win32PerfRawDataOfflineFilesOfflineFiles(scope, cimInstance);
                case "Win32_PerfFormattedData_PeerDistSvc_BranchCache":
                    return new Win32PerfFormattedDataPeerDistSvcBranchCache(scope, cimInstance);
                case "Win32_PerfRawData_PeerDistSvc_BranchCache":
                    return new Win32PerfRawDataPeerDistSvcBranchCache(scope, cimInstance);
                case "Win32_PerfFormattedData_PeerNameResolutionProtocolPerf_PeerNameResolutionProtocol":
                    return new Win32PerfFormattedDataPeerNameResolutionProtocolPerfPeerNameResolutionProtocol(scope, cimInstance);
                case "Win32_PerfRawData_PeerNameResolutionProtocolPerf_PeerNameResolutionProtocol":
                    return new Win32PerfRawDataPeerNameResolutionProtocolPerfPeerNameResolutionProtocol(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfDisk_LogicalDisk":
                    return new Win32PerfFormattedDataPerfDiskLogicalDisk(scope, cimInstance);
                case "Win32_PerfRawData_PerfDisk_LogicalDisk":
                    return new Win32PerfRawDataPerfDiskLogicalDisk(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfDisk_PhysicalDisk":
                    return new Win32PerfFormattedDataPerfDiskPhysicalDisk(scope, cimInstance);
                case "Win32_PerfRawData_PerfDisk_PhysicalDisk":
                    return new Win32PerfRawDataPerfDiskPhysicalDisk(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfNet_Browser":
                    return new Win32PerfFormattedDataPerfNetBrowser(scope, cimInstance);
                case "Win32_PerfRawData_PerfNet_Browser":
                    return new Win32PerfRawDataPerfNetBrowser(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfNet_Redirector":
                    return new Win32PerfFormattedDataPerfNetRedirector(scope, cimInstance);
                case "Win32_PerfRawData_PerfNet_Redirector":
                    return new Win32PerfRawDataPerfNetRedirector(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfNet_Server":
                    return new Win32PerfFormattedDataPerfNetServer(scope, cimInstance);
                case "Win32_PerfRawData_PerfNet_Server":
                    return new Win32PerfRawDataPerfNetServer(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfNet_ServerWorkQueues":
                    return new Win32PerfFormattedDataPerfNetServerWorkQueues(scope, cimInstance);
                case "Win32_PerfRawData_PerfNet_ServerWorkQueues":
                    return new Win32PerfRawDataPerfNetServerWorkQueues(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfOS_Cache":
                    return new Win32PerfFormattedDataPerfOSCache(scope, cimInstance);
                case "Win32_PerfRawData_PerfOS_Cache":
                    return new Win32PerfRawDataPerfOSCache(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfOS_Memory":
                    return new Win32PerfFormattedDataPerfOSMemory(scope, cimInstance);
                case "Win32_PerfRawData_PerfOS_Memory":
                    return new Win32PerfRawDataPerfOSMemory(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfOS_NUMANodeMemory":
                    return new Win32PerfFormattedDataPerfOSNUMANodeMemory(scope, cimInstance);
                case "Win32_PerfRawData_PerfOS_NUMANodeMemory":
                    return new Win32PerfRawDataPerfOSNUMANodeMemory(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfOS_Objects":
                    return new Win32PerfFormattedDataPerfOSObjects(scope, cimInstance);
                case "Win32_PerfRawData_PerfOS_Objects":
                    return new Win32PerfRawDataPerfOSObjects(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfOS_PagingFile":
                    return new Win32PerfFormattedDataPerfOSPagingFile(scope, cimInstance);
                case "Win32_PerfRawData_PerfOS_PagingFile":
                    return new Win32PerfRawDataPerfOSPagingFile(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfOS_Processor":
                    return new Win32PerfFormattedDataPerfOSProcessor(scope, cimInstance);
                case "Win32_PerfRawData_PerfOS_Processor":
                    return new Win32PerfRawDataPerfOSProcessor(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfOS_System":
                    return new Win32PerfFormattedDataPerfOSSystem(scope, cimInstance);
                case "Win32_PerfRawData_PerfOS_System":
                    return new Win32PerfRawDataPerfOSSystem(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfProc_JobObject":
                    return new Win32PerfFormattedDataPerfProcJobObject(scope, cimInstance);
                case "Win32_PerfRawData_PerfProc_JobObject":
                    return new Win32PerfRawDataPerfProcJobObject(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfProc_JobObjectDetails":
                    return new Win32PerfFormattedDataPerfProcJobObjectDetails(scope, cimInstance);
                case "Win32_PerfRawData_PerfProc_JobObjectDetails":
                    return new Win32PerfRawDataPerfProcJobObjectDetails(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfProc_Process":
                    return new Win32PerfFormattedDataPerfProcProcess(scope, cimInstance);
                case "Win32_PerfRawData_PerfProc_Process":
                    return new Win32PerfRawDataPerfProcProcess(scope, cimInstance);
                case "Win32_PerfFormattedData_PerfProc_Thread":
                    return new Win32PerfFormattedDataPerfProcThread(scope, cimInstance);
                case "Win32_PerfRawData_PerfProc_Thread":
                    return new Win32PerfRawDataPerfProcThread(scope, cimInstance);
                case "Win32_PerfFormattedData_PowerMeterCounter_EnergyMeter":
                    return new Win32PerfFormattedDataPowerMeterCounterEnergyMeter(scope, cimInstance);
                case "Win32_PerfRawData_PowerMeterCounter_EnergyMeter":
                    return new Win32PerfRawDataPowerMeterCounterEnergyMeter(scope, cimInstance);
                case "Win32_PerfFormattedData_PowerMeterCounter_PowerMeter":
                    return new Win32PerfFormattedDataPowerMeterCounterPowerMeter(scope, cimInstance);
                case "Win32_PerfRawData_PowerMeterCounter_PowerMeter":
                    return new Win32PerfRawDataPowerMeterCounterPowerMeter(scope, cimInstance);
                case "Win32_PerfFormattedData_rdyboost_ReadyBoostCache":
                    return new Win32PerfFormattedDataRdyboostReadyBoostCache(scope, cimInstance);
                case "Win32_PerfRawData_rdyboost_ReadyBoostCache":
                    return new Win32PerfRawDataRdyboostReadyBoostCache(scope, cimInstance);
                case "Win32_PerfFormattedData_RemoteAccess_RASPort":
                    return new Win32PerfFormattedDataRemoteAccessRASPort(scope, cimInstance);
                case "Win32_PerfRawData_RemoteAccess_RASPort":
                    return new Win32PerfRawDataRemoteAccessRASPort(scope, cimInstance);
                case "Win32_PerfFormattedData_RemoteAccess_RASTotal":
                    return new Win32PerfFormattedDataRemoteAccessRASTotal(scope, cimInstance);
                case "Win32_PerfRawData_RemoteAccess_RASTotal":
                    return new Win32PerfRawDataRemoteAccessRASTotal(scope, cimInstance);
                case "Win32_PerfFormattedData_RemoteFXPerformanceCounterProvider_RemoteFXSoftware":
                    return new Win32PerfFormattedDataRemoteFXPerformanceCounterProviderRemoteFXSoftware(scope, cimInstance);
                case "Win32_PerfRawData_RemoteFXPerformanceCounterProvider_RemoteFXSoftware":
                    return new Win32PerfRawDataRemoteFXPerformanceCounterProviderRemoteFXSoftware(scope, cimInstance);
                case "Win32_PerfFormattedData_RemotePerfProvider_HyperVVMRemoting":
                    return new Win32PerfFormattedDataRemotePerfProviderHyperVVMRemoting(scope, cimInstance);
                case "Win32_PerfRawData_RemotePerfProvider_HyperVVMRemoting":
                    return new Win32PerfRawDataRemotePerfProviderHyperVVMRemoting(scope, cimInstance);
                case "Win32_PerfFormattedData_ServiceModel4000_ServiceModelEndpoint4000":
                    return new Win32PerfFormattedDataServiceModel4000ServiceModelEndpoint4000(scope, cimInstance);
                case "Win32_PerfRawData_ServiceModel4000_ServiceModelEndpoint4000":
                    return new Win32PerfRawDataServiceModel4000ServiceModelEndpoint4000(scope, cimInstance);
                case "Win32_PerfFormattedData_ServiceModel4000_ServiceModelOperation4000":
                    return new Win32PerfFormattedDataServiceModel4000ServiceModelOperation4000(scope, cimInstance);
                case "Win32_PerfRawData_ServiceModel4000_ServiceModelOperation4000":
                    return new Win32PerfRawDataServiceModel4000ServiceModelOperation4000(scope, cimInstance);
                case "Win32_PerfFormattedData_ServiceModel4000_ServiceModelService4000":
                    return new Win32PerfFormattedDataServiceModel4000ServiceModelService4000(scope, cimInstance);
                case "Win32_PerfRawData_ServiceModel4000_ServiceModelService4000":
                    return new Win32PerfRawDataServiceModel4000ServiceModelService4000(scope, cimInstance);
                case "Win32_PerfFormattedData_SMSvcHost4000_SMSvcHost4000":
                    return new Win32PerfFormattedDataSMSvcHost4000SMSvcHost4000(scope, cimInstance);
                case "Win32_PerfRawData_SMSvcHost4000_SMSvcHost4000":
                    return new Win32PerfRawDataSMSvcHost4000SMSvcHost4000(scope, cimInstance);
                case "Win32_PerfFormattedData_Spooler_PrintQueue":
                    return new Win32PerfFormattedDataSpoolerPrintQueue(scope, cimInstance);
                case "Win32_PerfRawData_Spooler_PrintQueue":
                    return new Win32PerfRawDataSpoolerPrintQueue(scope, cimInstance);
                case "Win32_PerfFormattedData_Synth3dVideoPerfProvider_RemoteFXRootGPUManagement":
                    return new Win32PerfFormattedDataSynth3dVideoPerfProviderRemoteFXRootGPUManagement(scope, cimInstance);
                case "Win32_PerfRawData_Synth3dVideoPerfProvider_RemoteFXRootGPUManagement":
                    return new Win32PerfRawDataSynth3dVideoPerfProviderRemoteFXRootGPUManagement(scope, cimInstance);
                case "Win32_PerfFormattedData_TapiSrv_Telephony":
                    return new Win32PerfFormattedDataTapiSrvTelephony(scope, cimInstance);
                case "Win32_PerfRawData_TapiSrv_Telephony":
                    return new Win32PerfRawDataTapiSrvTelephony(scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_ICMP":
                    return new Win32PerfFormattedDataTcpipICMP(scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_ICMP":
                    return new Win32PerfRawDataTcpipICMP(scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_ICMPv6":
                    return new Win32PerfFormattedDataTcpipICMPv6(scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_ICMPv6":
                    return new Win32PerfRawDataTcpipICMPv6(scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_IPv4":
                    return new Win32PerfFormattedDataTcpipIPv4(scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_IPv4":
                    return new Win32PerfRawDataTcpipIPv4(scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_IPv6":
                    return new Win32PerfFormattedDataTcpipIPv6(scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_IPv6":
                    return new Win32PerfRawDataTcpipIPv6(scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_NBTConnection":
                    return new Win32PerfFormattedDataTcpipNBTConnection(scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_NBTConnection":
                    return new Win32PerfRawDataTcpipNBTConnection(scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_NetworkAdapter":
                    return new Win32PerfFormattedDataTcpipNetworkAdapter(scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_NetworkAdapter":
                    return new Win32PerfRawDataTcpipNetworkAdapter(scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_NetworkInterface":
                    return new Win32PerfFormattedDataTcpipNetworkInterface(scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_NetworkInterface":
                    return new Win32PerfRawDataTcpipNetworkInterface(scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_TCPv4":
                    return new Win32PerfFormattedDataTcpipTCPv4(scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_TCPv4":
                    return new Win32PerfRawDataTcpipTCPv4(scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_TCPv6":
                    return new Win32PerfFormattedDataTcpipTCPv6(scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_TCPv6":
                    return new Win32PerfRawDataTcpipTCPv6(scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_UDPv4":
                    return new Win32PerfFormattedDataTcpipUDPv4(scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_UDPv4":
                    return new Win32PerfRawDataTcpipUDPv4(scope, cimInstance);
                case "Win32_PerfFormattedData_Tcpip_UDPv6":
                    return new Win32PerfFormattedDataTcpipUDPv6(scope, cimInstance);
                case "Win32_PerfRawData_Tcpip_UDPv6":
                    return new Win32PerfRawDataTcpipUDPv6(scope, cimInstance);
                case "Win32_PerfFormattedData_TCPIPCounters_TCPIPPerformanceDiagnostics":
                    return new Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnostics(scope, cimInstance);
                case "Win32_PerfRawData_TCPIPCounters_TCPIPPerformanceDiagnostics":
                    return new Win32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnostics(scope, cimInstance);
                case "Win32_PerfFormattedData_TCPIPCounters_TCPIPPerformanceDiagnosticsPerCPU":
                    return new Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnosticsPerCPU(scope, cimInstance);
                case "Win32_PerfRawData_TCPIPCounters_TCPIPPerformanceDiagnosticsPerCPU":
                    return new Win32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnosticsPerCPU(scope, cimInstance);
                case "Win32_PerfFormattedData_TermService_TerminalServicesSession":
                    return new Win32PerfFormattedDataTermServiceTerminalServicesSession(scope, cimInstance);
                case "Win32_PerfRawData_TermService_TerminalServicesSession":
                    return new Win32PerfRawDataTermServiceTerminalServicesSession(scope, cimInstance);
                case "Win32_PerfFormattedData_UGatherer_SearchGathererProjects":
                    return new Win32PerfFormattedDataUGathererSearchGathererProjects(scope, cimInstance);
                case "Win32_PerfRawData_UGatherer_SearchGathererProjects":
                    return new Win32PerfRawDataUGathererSearchGathererProjects(scope, cimInstance);
                case "Win32_PerfFormattedData_UGTHRSVC_SearchGatherer":
                    return new Win32PerfFormattedDataUGTHRSVCSearchGatherer(scope, cimInstance);
                case "Win32_PerfRawData_UGTHRSVC_SearchGatherer":
                    return new Win32PerfRawDataUGTHRSVCSearchGatherer(scope, cimInstance);
                case "Win32_PerfFormattedData_usbhub_Noname":
                    return new Win32PerfFormattedDataUsbhubNoname(scope, cimInstance);
                case "Win32_PerfRawData_usbhub_Noname":
                    return new Win32PerfRawDataUsbhubNoname(scope, cimInstance);
                case "Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidDriver":
                    return new Win32PerfFormattedDataVidPerfProviderHyperVVMVidDriver(scope, cimInstance);
                case "Win32_PerfRawData_VidPerfProvider_HyperVVMVidDriver":
                    return new Win32PerfRawDataVidPerfProviderHyperVVMVidDriver(scope, cimInstance);
                case "Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidNumaNode":
                    return new Win32PerfFormattedDataVidPerfProviderHyperVVMVidNumaNode(scope, cimInstance);
                case "Win32_PerfRawData_VidPerfProvider_HyperVVMVidNumaNode":
                    return new Win32PerfRawDataVidPerfProviderHyperVVMVidNumaNode(scope, cimInstance);
                case "Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidPartition":
                    return new Win32PerfFormattedDataVidPerfProviderHyperVVMVidPartition(scope, cimInstance);
                case "Win32_PerfRawData_VidPerfProvider_HyperVVMVidPartition":
                    return new Win32PerfRawDataVidPerfProviderHyperVVMVidPartition(scope, cimInstance);
                case "Win32_PerfFormattedData_VMBusPipeIOPerfProvider_HyperVVMVirtualDevicePipeIO":
                    return new Win32PerfFormattedDataVMBusPipeIOPerfProviderHyperVVMVirtualDevicePipeIO(scope, cimInstance);
                case "Win32_PerfRawData_VMBusPipeIOPerfProvider_HyperVVMVirtualDevicePipeIO":
                    return new Win32PerfRawDataVMBusPipeIOPerfProviderHyperVVMVirtualDevicePipeIO(scope, cimInstance);
                case "Win32_PerfFormattedData_VmmsVirtualMachineStats_HyperVVirtualMachineHealthSummary":
                    return new Win32PerfFormattedDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary(scope, cimInstance);
                case "Win32_PerfRawData_VmmsVirtualMachineStats_HyperVVirtualMachineHealthSummary":
                    return new Win32PerfRawDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary(scope, cimInstance);
                case "Win32_PerfFormattedData_VSmbPerfProvider_HyperVVirtualSMB":
                    return new Win32PerfFormattedDataVSmbPerfProviderHyperVVirtualSMB(scope, cimInstance);
                case "Win32_PerfRawData_VSmbPerfProvider_HyperVVirtualSMB":
                    return new Win32PerfRawDataVSmbPerfProviderHyperVVirtualSMB(scope, cimInstance);
                case "Win32_PerfFormattedData_WindowsMediaPlayer_WindowsMediaPlayerMetadata":
                    return new Win32PerfFormattedDataWindowsMediaPlayerWindowsMediaPlayerMetadata(scope, cimInstance);
                case "Win32_PerfRawData_WindowsMediaPlayer_WindowsMediaPlayerMetadata":
                    return new Win32PerfRawDataWindowsMediaPlayerWindowsMediaPlayerMetadata(scope, cimInstance);
                case "Win32_PerfFormattedData_WindowsWorkflowFoundation4000_WFSystemWorkflow4000":
                    return new Win32PerfFormattedDataWindowsWorkflowFoundation4000WFSystemWorkflow4000(scope, cimInstance);
                case "Win32_PerfRawData_WindowsWorkflowFoundation4000_WFSystemWorkflow4000":
                    return new Win32PerfRawDataWindowsWorkflowFoundation4000WFSystemWorkflow4000(scope, cimInstance);
                case "Win32_PerfFormattedData_WinNatCounters_WinNAT":
                    return new Win32PerfFormattedDataWinNatCountersWinNAT(scope, cimInstance);
                case "Win32_PerfRawData_WinNatCounters_WinNAT":
                    return new Win32PerfRawDataWinNatCountersWinNAT(scope, cimInstance);
                case "Win32_PerfFormattedData_WinNatCounters_WinNATICMP":
                    return new Win32PerfFormattedDataWinNatCountersWinNATICMP(scope, cimInstance);
                case "Win32_PerfRawData_WinNatCounters_WinNATICMP":
                    return new Win32PerfRawDataWinNatCountersWinNATICMP(scope, cimInstance);
                case "Win32_PerfFormattedData_WinNatCounters_WinNATInstance":
                    return new Win32PerfFormattedDataWinNatCountersWinNATInstance(scope, cimInstance);
                case "Win32_PerfRawData_WinNatCounters_WinNATInstance":
                    return new Win32PerfRawDataWinNatCountersWinNATInstance(scope, cimInstance);
                case "Win32_PerfFormattedData_WinNatCounters_WinNATTCP":
                    return new Win32PerfFormattedDataWinNatCountersWinNATTCP(scope, cimInstance);
                case "Win32_PerfRawData_WinNatCounters_WinNATTCP":
                    return new Win32PerfRawDataWinNatCountersWinNATTCP(scope, cimInstance);
                case "Win32_PerfFormattedData_WinNatCounters_WinNATUDP":
                    return new Win32PerfFormattedDataWinNatCountersWinNATUDP(scope, cimInstance);
                case "Win32_PerfRawData_WinNatCounters_WinNATUDP":
                    return new Win32PerfRawDataWinNatCountersWinNATUDP(scope, cimInstance);
                case "Win32_PerfFormattedData_WorkerVpProvider_HyperVWorkerVirtualProcessor":
                    return new Win32PerfFormattedDataWorkerVpProviderHyperVWorkerVirtualProcessor(scope, cimInstance);
                case "Win32_PerfRawData_WorkerVpProvider_HyperVWorkerVirtualProcessor":
                    return new Win32PerfRawDataWorkerVpProviderHyperVWorkerVirtualProcessor(scope, cimInstance);
                case "Win32_PerfFormattedData_WorkflowServiceHost4000_WorkflowServiceHost4000":
                    return new Win32PerfFormattedDataWorkflowServiceHost4000WorkflowServiceHost4000(scope, cimInstance);
                case "Win32_PerfRawData_WorkflowServiceHost4000_WorkflowServiceHost4000":
                    return new Win32PerfRawDataWorkflowServiceHost4000WorkflowServiceHost4000(scope, cimInstance);
                case "Win32_PerfFormattedData_WSearchIdxPi_SearchIndexer":
                    return new Win32PerfFormattedDataWSearchIdxPiSearchIndexer(scope, cimInstance);
                case "Win32_PerfRawData_WSearchIdxPi_SearchIndexer":
                    return new Win32PerfRawDataWSearchIdxPiSearchIndexer(scope, cimInstance);
                default:
                    throw new KeyNotFoundException();
            }
        }

        private static Dictionary<Type, string> _typeMap = new Dictionary<Type, string>{ { typeof ( SystemClass ) ,  "__SystemClass" }
        ,  { typeof ( ThisNAMESPACE ) ,  "__thisNAMESPACE" }
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
        ,  { typeof ( NAMESPACE ) ,  "__NAMESPACE" }
        ,  { typeof ( IndicationRelated ) ,  "__IndicationRelated" }
        ,  { typeof ( EventConsumer ) ,  "__EventConsumer" }
        ,  { typeof ( AggregateEvent ) ,  "__AggregateEvent" }
        ,  { typeof ( TimerNextFiring ) ,  "__TimerNextFiring" }
        ,  { typeof ( EventFilter ) ,  "__EventFilter" }
        ,  { typeof ( Event ) ,  "__Event" }
        ,  { typeof ( NamespaceOperationEvent ) ,  "__NamespaceOperationEvent" }
        ,  { typeof ( NamespaceModificationEvent ) ,  "__NamespaceModificationEvent" }
        ,  { typeof ( NamespaceDeletionEvent ) ,  "__NamespaceDeletionEvent" }
        ,  { typeof ( NamespaceCreationEvent ) ,  "__NamespaceCreationEvent" }
        ,  { typeof ( ClassOperationEvent ) ,  "__ClassOperationEvent" }
        ,  { typeof ( ClassDeletionEvent ) ,  "__ClassDeletionEvent" }
        ,  { typeof ( ClassModificationEvent ) ,  "__ClassModificationEvent" }
        ,  { typeof ( ClassCreationEvent ) ,  "__ClassCreationEvent" }
        ,  { typeof ( InstanceOperationEvent ) ,  "__InstanceOperationEvent" }
        ,  { typeof ( InstanceCreationEvent ) ,  "__InstanceCreationEvent" }
        ,  { typeof ( MethodInvocationEvent ) ,  "__MethodInvocationEvent" }
        ,  { typeof ( InstanceModificationEvent ) ,  "__InstanceModificationEvent" }
        ,  { typeof ( InstanceDeletionEvent ) ,  "__InstanceDeletionEvent" }
        ,  { typeof ( TimerEvent ) ,  "__TimerEvent" }
        ,  { typeof ( ExtrinsicEvent ) ,  "__ExtrinsicEvent" }
        ,  { typeof ( SystemEvent ) ,  "__SystemEvent" }
        ,  { typeof ( EventDroppedEvent ) ,  "__EventDroppedEvent" }
        ,  { typeof ( EventQueueOverflowEvent ) ,  "__EventQueueOverflowEvent" }
        ,  { typeof ( QOSFailureEvent ) ,  "__QOSFailureEvent" }
        ,  { typeof ( ConsumerFailureEvent ) ,  "__ConsumerFailureEvent" }
        ,  { typeof ( MSFTSCMEvent ) ,  "MSFT_SCMEvent" }
        ,  { typeof ( MSFTSCMEventLogEvent ) ,  "MSFT_SCMEventLogEvent" }
        ,  { typeof ( MSFTNetSevereServiceFailed ) ,  "MSFT_NetSevereServiceFailed" }
        ,  { typeof ( MSFTNetTransactInvalid ) ,  "MSFT_NetTransactInvalid" }
        ,  { typeof ( MSFTNetServiceNotInteractive ) ,  "MSFT_NetServiceNotInteractive" }
        ,  { typeof ( MSFTNetTakeOwnership ) ,  "MSFT_NetTakeOwnership" }
        ,  { typeof ( MSFTNetServiceConfigBackoutFailed ) ,  "MSFT_NetServiceConfigBackoutFailed" }
        ,  { typeof ( MSFTNetServiceShutdownFailed ) ,  "MSFT_NetServiceShutdownFailed" }
        ,  { typeof ( MSFTNetServiceStartHung ) ,  "MSFT_NetServiceStartHung" }
        ,  { typeof ( MSFTNetServiceStopControlSuccess ) ,  "MSFT_NetServiceStopControlSuccess" }
        ,  { typeof ( MSFTNetServiceSlowStartup ) ,  "MSFT_NetServiceSlowStartup" }
        ,  { typeof ( MSFTNetCallToFunctionFailed ) ,  "MSFT_NetCallToFunctionFailed" }
        ,  { typeof ( MSFTNetBadAccount ) ,  "MSFT_NetBadAccount" }
        ,  { typeof ( MSFTNetBadServiceState ) ,  "MSFT_NetBadServiceState" }
        ,  { typeof ( MSFTNetConnectionTimeout ) ,  "MSFT_NetConnectionTimeout" }
        ,  { typeof ( MSFTNetCircularDependencyAuto ) ,  "MSFT_NetCircularDependencyAuto" }
        ,  { typeof ( MSFTNetServiceStartTypeChanged ) ,  "MSFT_NetServiceStartTypeChanged" }
        ,  { typeof ( MSFTNetServiceLogonTypeNotGranted ) ,  "MSFT_NetServiceLogonTypeNotGranted" }
        ,  { typeof ( MSFTNetServiceStartFailedGroup ) ,  "MSFT_NetServiceStartFailedGroup" }
        ,  { typeof ( MSFTNetDependOnLaterService ) ,  "MSFT_NetDependOnLaterService" }
        ,  { typeof ( MSFTNetFirstLogonFailedII ) ,  "MSFT_NetFirstLogonFailedII" }
        ,  { typeof ( MSFTNetServiceDifferentPIDConnected ) ,  "MSFT_NetServiceDifferentPIDConnected" }
        ,  { typeof ( MSFTNetServiceCrashNoAction ) ,  "MSFT_NetServiceCrashNoAction" }
        ,  { typeof ( MSFTNetCircularDependencyDemand ) ,  "MSFT_NetCircularDependencyDemand" }
        ,  { typeof ( MSFTNetServiceExitFailed ) ,  "MSFT_NetServiceExitFailed" }
        ,  { typeof ( MSFTNetServiceStartFailedII ) ,  "MSFT_NetServiceStartFailedII" }
        ,  { typeof ( MSFTNetServiceExitFailedSpecific ) ,  "MSFT_NetServiceExitFailedSpecific" }
        ,  { typeof ( MSFTNetBootSystemDriversFailed ) ,  "MSFT_NetBootSystemDriversFailed" }
        ,  { typeof ( MSFTNetServiceCrash ) ,  "MSFT_NetServiceCrash" }
        ,  { typeof ( MSFTNetServiceRecoveryFailed ) ,  "MSFT_NetServiceRecoveryFailed" }
        ,  { typeof ( MSFTNetServiceStatusSuccess ) ,  "MSFT_NetServiceStatusSuccess" }
        ,  { typeof ( MSFTNetTransactTimeout ) ,  "MSFT_NetTransactTimeout" }
        ,  { typeof ( MSFTNetFirstLogonFailed ) ,  "MSFT_NetFirstLogonFailed" }
        ,  { typeof ( MSFTNetServiceControlSuccess ) ,  "MSFT_NetServiceControlSuccess" }
        ,  { typeof ( MSFTNetServiceStartFailed ) ,  "MSFT_NetServiceStartFailed" }
        ,  { typeof ( MSFTNetServiceStartFailedNone ) ,  "MSFT_NetServiceStartFailedNone" }
        ,  { typeof ( MSFTNetReadfileTimeout ) ,  "MSFT_NetReadfileTimeout" }
        ,  { typeof ( MSFTNetRevertedToLastKnownGood ) ,  "MSFT_NetRevertedToLastKnownGood" }
        ,  { typeof ( MSFTNetCallToFunctionFailedII ) ,  "MSFT_NetCallToFunctionFailedII" }
        ,  { typeof ( MSFTNetDependOnLaterGroup ) ,  "MSFT_NetDependOnLaterGroup" }
        ,  { typeof ( MSFTWmiSelfEvent ) ,  "MSFT_WmiSelfEvent" }
        ,  { typeof ( MSFTWmiEssEvent ) ,  "MSFT_WmiEssEvent" }
        ,  { typeof ( MSFTWmiThreadPoolEvent ) ,  "MSFT_WmiThreadPoolEvent" }
        ,  { typeof ( MSFTWmiThreadPoolThreadCreated ) ,  "MSFT_WmiThreadPoolThreadCreated" }
        ,  { typeof ( MSFTWmiThreadPoolThreadDeleted ) ,  "MSFT_WmiThreadPoolThreadDeleted" }
        ,  { typeof ( MSFTWmiRegisterNotificationSink ) ,  "MSFT_WmiRegisterNotificationSink" }
        ,  { typeof ( MSFTWmiFilterEvent ) ,  "MSFT_WmiFilterEvent" }
        ,  { typeof ( MSFTWmiFilterDeactivated ) ,  "MSFT_WmiFilterDeactivated" }
        ,  { typeof ( MSFTWmiFilterActivated ) ,  "MSFT_WmiFilterActivated" }
        ,  { typeof ( MSFTWmiCancelNotificationSink ) ,  "MSFT_WmiCancelNotificationSink" }
        ,  { typeof ( MSFTWmiProviderEvent ) ,  "MSFT_WmiProviderEvent" }
        ,  { typeof ( MSFTWmiConsumerProviderEvent ) ,  "MSFT_WmiConsumerProviderEvent" }
        ,  { typeof ( MSFTWmiConsumerProviderSinkLoaded ) ,  "MSFT_WmiConsumerProviderSinkLoaded" }
        ,  { typeof ( MSFTWmiConsumerProviderSinkUnloaded ) ,  "MSFT_WmiConsumerProviderSinkUnloaded" }
        ,  { typeof ( MSFTWmiConsumerProviderUnloaded ) ,  "MSFT_WmiConsumerProviderUnloaded" }
        ,  { typeof ( MSFTWmiConsumerProviderLoaded ) ,  "MSFT_WmiConsumerProviderLoaded" }
        ,  { typeof ( MsftWmiProviderOperationEvent ) ,  "Msft_WmiProvider_OperationEvent" }
        ,  { typeof ( MsftWmiProviderComServerLoadOperationEvent ) ,  "Msft_WmiProvider_ComServerLoadOperationEvent" }
        ,  { typeof ( MsftWmiProviderOperationEventPost ) ,  "Msft_WmiProvider_OperationEvent_Post" }
        ,  { typeof ( MsftWmiProviderPutInstanceAsyncEventPost ) ,  "Msft_WmiProvider_PutInstanceAsyncEvent_Post" }
        ,  { typeof ( MsftWmiProviderCreateInstanceEnumAsyncEventPost ) ,  "Msft_WmiProvider_CreateInstanceEnumAsyncEvent_Post" }
        ,  { typeof ( MsftWmiProviderDeleteInstanceAsyncEventPost ) ,  "Msft_WmiProvider_DeleteInstanceAsyncEvent_Post" }
        ,  { typeof ( MsftWmiProviderCancelQueryPost ) ,  "Msft_WmiProvider_CancelQuery_Post" }
        ,  { typeof ( MsftWmiProviderNewQueryPost ) ,  "Msft_WmiProvider_NewQuery_Post" }
        ,  { typeof ( MsftWmiProviderProvideEventsPost ) ,  "Msft_WmiProvider_ProvideEvents_Post" }
        ,  { typeof ( MsftWmiProviderExecQueryAsyncEventPost ) ,  "Msft_WmiProvider_ExecQueryAsyncEvent_Post" }
        ,  { typeof ( MsftWmiProviderAccessCheckPost ) ,  "Msft_WmiProvider_AccessCheck_Post" }
        ,  { typeof ( MsftWmiProviderCreateClassEnumAsyncEventPost ) ,  "Msft_WmiProvider_CreateClassEnumAsyncEvent_Post" }
        ,  { typeof ( MsftWmiProviderDeleteClassAsyncEventPost ) ,  "Msft_WmiProvider_DeleteClassAsyncEvent_Post" }
        ,  { typeof ( MsftWmiProviderExecMethodAsyncEventPost ) ,  "Msft_WmiProvider_ExecMethodAsyncEvent_Post" }
        ,  { typeof ( MsftWmiProviderGetObjectAsyncEventPost ) ,  "Msft_WmiProvider_GetObjectAsyncEvent_Post" }
        ,  { typeof ( MsftWmiProviderPutClassAsyncEventPost ) ,  "Msft_WmiProvider_PutClassAsyncEvent_Post" }
        ,  { typeof ( MsftWmiProviderInitializationOperationFailureEvent ) ,  "Msft_WmiProvider_InitializationOperationFailureEvent" }
        ,  { typeof ( MsftWmiProviderInitializationOperationEvent ) ,  "Msft_WmiProvider_InitializationOperationEvent" }
        ,  { typeof ( MsftWmiProviderLoadOperationFailureEvent ) ,  "Msft_WmiProvider_LoadOperationFailureEvent" }
        ,  { typeof ( MsftWmiProviderComServerLoadOperationFailureEvent ) ,  "Msft_WmiProvider_ComServerLoadOperationFailureEvent" }
        ,  { typeof ( MsftWmiProviderUnLoadOperationEvent ) ,  "Msft_WmiProvider_UnLoadOperationEvent" }
        ,  { typeof ( MsftWmiProviderLoadOperationEvent ) ,  "Msft_WmiProvider_LoadOperationEvent" }
        ,  { typeof ( MsftWmiProviderOperationEventPre ) ,  "Msft_WmiProvider_OperationEvent_Pre" }
        ,  { typeof ( MsftWmiProviderDeleteInstanceAsyncEventPre ) ,  "Msft_WmiProvider_DeleteInstanceAsyncEvent_Pre" }
        ,  { typeof ( MsftWmiProviderAccessCheckPre ) ,  "Msft_WmiProvider_AccessCheck_Pre" }
        ,  { typeof ( MsftWmiProviderExecQueryAsyncEventPre ) ,  "Msft_WmiProvider_ExecQueryAsyncEvent_Pre" }
        ,  { typeof ( MsftWmiProviderDeleteClassAsyncEventPre ) ,  "Msft_WmiProvider_DeleteClassAsyncEvent_Pre" }
        ,  { typeof ( MsftWmiProviderNewQueryPre ) ,  "Msft_WmiProvider_NewQuery_Pre" }
        ,  { typeof ( MsftWmiProviderPutInstanceAsyncEventPre ) ,  "Msft_WmiProvider_PutInstanceAsyncEvent_Pre" }
        ,  { typeof ( MsftWmiProviderCreateClassEnumAsyncEventPre ) ,  "Msft_WmiProvider_CreateClassEnumAsyncEvent_Pre" }
        ,  { typeof ( MsftWmiProviderExecMethodAsyncEventPre ) ,  "Msft_WmiProvider_ExecMethodAsyncEvent_Pre" }
        ,  { typeof ( MsftWmiProviderProvideEventsPre ) ,  "Msft_WmiProvider_ProvideEvents_Pre" }
        ,  { typeof ( MsftWmiProviderCancelQueryPre ) ,  "Msft_WmiProvider_CancelQuery_Pre" }
        ,  { typeof ( MsftWmiProviderPutClassAsyncEventPre ) ,  "Msft_WmiProvider_PutClassAsyncEvent_Pre" }
        ,  { typeof ( MsftWmiProviderGetObjectAsyncEventPre ) ,  "Msft_WmiProvider_GetObjectAsyncEvent_Pre" }
        ,  { typeof ( MsftWmiProviderCreateInstanceEnumAsyncEventPre ) ,  "Msft_WmiProvider_CreateInstanceEnumAsyncEvent_Pre" }
        ,  { typeof ( MSFTWMIGenericNonCOMEvent ) ,  "MSFT_WMI_GenericNonCOMEvent" }
        ,  { typeof ( Win32ComputerSystemEvent ) ,  "Win32_ComputerSystemEvent" }
        ,  { typeof ( Win32ComputerShutdownEvent ) ,  "Win32_ComputerShutdownEvent" }
        ,  { typeof ( Win32IP4RouteTableEvent ) ,  "Win32_IP4RouteTableEvent" }
        ,  { typeof ( MSFTNCProvEvent ) ,  "MSFT_NCProvEvent" }
        ,  { typeof ( MSFTNCProvCancelQuery ) ,  "MSFT_NCProvCancelQuery" }
        ,  { typeof ( MSFTNCProvClientConnected ) ,  "MSFT_NCProvClientConnected" }
        ,  { typeof ( MSFTNCProvNewQuery ) ,  "MSFT_NCProvNewQuery" }
        ,  { typeof ( MSFTNCProvAccessCheck ) ,  "MSFT_NCProvAccessCheck" }
        ,  { typeof ( RegistryEvent ) ,  "RegistryEvent" }
        ,  { typeof ( RegistryKeyChangeEvent ) ,  "RegistryKeyChangeEvent" }
        ,  { typeof ( RegistryTreeChangeEvent ) ,  "RegistryTreeChangeEvent" }
        ,  { typeof ( RegistryValueChangeEvent ) ,  "RegistryValueChangeEvent" }
        ,  { typeof ( Win32SystemTrace ) ,  "Win32_SystemTrace" }
        ,  { typeof ( Win32ProcessTrace ) ,  "Win32_ProcessTrace" }
        ,  { typeof ( Win32ProcessStartTrace ) ,  "Win32_ProcessStartTrace" }
        ,  { typeof ( Win32ProcessStopTrace ) ,  "Win32_ProcessStopTrace" }
        ,  { typeof ( Win32ModuleTrace ) ,  "Win32_ModuleTrace" }
        ,  { typeof ( Win32ModuleLoadTrace ) ,  "Win32_ModuleLoadTrace" }
        ,  { typeof ( Win32ThreadTrace ) ,  "Win32_ThreadTrace" }
        ,  { typeof ( Win32ThreadStartTrace ) ,  "Win32_ThreadStartTrace" }
        ,  { typeof ( Win32ThreadStopTrace ) ,  "Win32_ThreadStopTrace" }
        ,  { typeof ( Win32PowerManagementEvent ) ,  "Win32_PowerManagementEvent" }
        ,  { typeof ( Win32DeviceChangeEvent ) ,  "Win32_DeviceChangeEvent" }
        ,  { typeof ( Win32SystemConfigurationChangeEvent ) ,  "Win32_SystemConfigurationChangeEvent" }
        ,  { typeof ( Win32VolumeChangeEvent ) ,  "Win32_VolumeChangeEvent" }
        ,  { typeof ( EventGenerator ) ,  "__EventGenerator" }
        ,  { typeof ( TimerInstruction ) ,  "__TimerInstruction" }
        ,  { typeof ( AbsoluteTimerInstruction ) ,  "__AbsoluteTimerInstruction" }
        ,  { typeof ( IntervalTimerInstruction ) ,  "__IntervalTimerInstruction" }
        ,  { typeof ( SystemSecurity ) ,  "__SystemSecurity" }
        ,  { typeof ( CIMManagedSystemElement ) ,  "CIM_ManagedSystemElement" }
        ,  { typeof ( CIMPhysicalElement ) ,  "CIM_PhysicalElement" }
        ,  { typeof ( CIMPhysicalPackage ) ,  "CIM_PhysicalPackage" }
        ,  { typeof ( CIMCard ) ,  "CIM_Card" }
        ,  { typeof ( Win32BaseBoard ) ,  "Win32_BaseBoard" }
        ,  { typeof ( CIMPhysicalFrame ) ,  "CIM_PhysicalFrame" }
        ,  { typeof ( CIMChassis ) ,  "CIM_Chassis" }
        ,  { typeof ( Win32SystemEnclosure ) ,  "Win32_SystemEnclosure" }
        ,  { typeof ( CIMRack ) ,  "CIM_Rack" }
        ,  { typeof ( Win32PhysicalMemoryArray ) ,  "Win32_PhysicalMemoryArray" }
        ,  { typeof ( CIMPhysicalComponent ) ,  "CIM_PhysicalComponent" }
        ,  { typeof ( CIMPhysicalMedia ) ,  "CIM_PhysicalMedia" }
        ,  { typeof ( Win32PhysicalMedia ) ,  "Win32_PhysicalMedia" }
        ,  { typeof ( CIMChip ) ,  "CIM_Chip" }
        ,  { typeof ( CIMPhysicalMemory ) ,  "CIM_PhysicalMemory" }
        ,  { typeof ( Win32PhysicalMemory ) ,  "Win32_PhysicalMemory" }
        ,  { typeof ( Win32OnBoardDevice ) ,  "Win32_OnBoardDevice" }
        ,  { typeof ( CIMPhysicalConnector ) ,  "CIM_PhysicalConnector" }
        ,  { typeof ( CIMSlot ) ,  "CIM_Slot" }
        ,  { typeof ( Win32SystemSlot ) ,  "Win32_SystemSlot" }
        ,  { typeof ( Win32PortConnector ) ,  "Win32_PortConnector" }
        ,  { typeof ( CIMPhysicalLink ) ,  "CIM_PhysicalLink" }
        ,  { typeof ( CIMLogicalElement ) ,  "CIM_LogicalElement" }
        ,  { typeof ( CIMOperatingSystem ) ,  "CIM_OperatingSystem" }
        ,  { typeof ( Win32OperatingSystem ) ,  "Win32_OperatingSystem" }
        ,  { typeof ( CIMProcess ) ,  "CIM_Process" }
        ,  { typeof ( Win32Process ) ,  "Win32_Process" }
        ,  { typeof ( CIMLogicalDevice ) ,  "CIM_LogicalDevice" }
        ,  { typeof ( CIMStorageExtent ) ,  "CIM_StorageExtent" }
        ,  { typeof ( CIMDiskPartition ) ,  "CIM_DiskPartition" }
        ,  { typeof ( Win32DiskPartition ) ,  "Win32_DiskPartition" }
        ,  { typeof ( CIMLogicalDisk ) ,  "CIM_LogicalDisk" }
        ,  { typeof ( Win32LogicalDisk ) ,  "Win32_LogicalDisk" }
        ,  { typeof ( Win32MappedLogicalDisk ) ,  "Win32_MappedLogicalDisk" }
        ,  { typeof ( CIMStorageVolume ) ,  "CIM_StorageVolume" }
        ,  { typeof ( Win32Volume ) ,  "Win32_Volume" }
        ,  { typeof ( CIMMemory ) ,  "CIM_Memory" }
        ,  { typeof ( CIMVolatileStorage ) ,  "CIM_VolatileStorage" }
        ,  { typeof ( CIMNonVolatileStorage ) ,  "CIM_NonVolatileStorage" }
        ,  { typeof ( CIMCacheMemory ) ,  "CIM_CacheMemory" }
        ,  { typeof ( Win32CacheMemory ) ,  "Win32_CacheMemory" }
        ,  { typeof ( CIMPhysicalExtent ) ,  "CIM_PhysicalExtent" }
        ,  { typeof ( Win32SMBIOSMemory ) ,  "Win32_SMBIOSMemory" }
        ,  { typeof ( Win32MemoryArray ) ,  "Win32_MemoryArray" }
        ,  { typeof ( Win32MemoryDevice ) ,  "Win32_MemoryDevice" }
        ,  { typeof ( CIMProtectedSpaceExtent ) ,  "CIM_ProtectedSpaceExtent" }
        ,  { typeof ( CIMAggregatePSExtent ) ,  "CIM_AggregatePSExtent" }
        ,  { typeof ( CIMAggregatePExtent ) ,  "CIM_AggregatePExtent" }
        ,  { typeof ( CIMVolumeSet ) ,  "CIM_VolumeSet" }
        ,  { typeof ( CIMMediaAccessDevice ) ,  "CIM_MediaAccessDevice" }
        ,  { typeof ( CIMDiskDrive ) ,  "CIM_DiskDrive" }
        ,  { typeof ( Win32DiskDrive ) ,  "Win32_DiskDrive" }
        ,  { typeof ( CIMCDROMDrive ) ,  "CIM_CDROMDrive" }
        ,  { typeof ( Win32CDROMDrive ) ,  "Win32_CDROMDrive" }
        ,  { typeof ( CIMDisketteDrive ) ,  "CIM_DisketteDrive" }
        ,  { typeof ( CIMTapeDrive ) ,  "CIM_TapeDrive" }
        ,  { typeof ( Win32TapeDrive ) ,  "Win32_TapeDrive" }
        ,  { typeof ( CIMMagnetoOpticalDrive ) ,  "CIM_MagnetoOpticalDrive" }
        ,  { typeof ( CIMWORMDrive ) ,  "CIM_WORMDrive" }
        ,  { typeof ( CIMProcessor ) ,  "CIM_Processor" }
        ,  { typeof ( Win32Processor ) ,  "Win32_Processor" }
        ,  { typeof ( CIMController ) ,  "CIM_Controller" }
        ,  { typeof ( CIMVideoController ) ,  "CIM_VideoController" }
        ,  { typeof ( CIMPCVideoController ) ,  "CIM_PCVideoController" }
        ,  { typeof ( Win32VideoController ) ,  "Win32_VideoController" }
        ,  { typeof ( CIMManagementController ) ,  "CIM_ManagementController" }
        ,  { typeof ( CIMSCSIController ) ,  "CIM_SCSIController" }
        ,  { typeof ( Win32SCSIController ) ,  "Win32_SCSIController" }
        ,  { typeof ( CIMInfraredController ) ,  "CIM_InfraredController" }
        ,  { typeof ( Win32InfraredDevice ) ,  "Win32_InfraredDevice" }
        ,  { typeof ( CIMPCIController ) ,  "CIM_PCIController" }
        ,  { typeof ( CIMPCMCIAController ) ,  "CIM_PCMCIAController" }
        ,  { typeof ( Win32PCMCIAController ) ,  "Win32_PCMCIAController" }
        ,  { typeof ( CIMUSBController ) ,  "CIM_USBController" }
        ,  { typeof ( Win32USBController ) ,  "Win32_USBController" }
        ,  { typeof ( CIMSerialController ) ,  "CIM_SerialController" }
        ,  { typeof ( Win32SerialPort ) ,  "Win32_SerialPort" }
        ,  { typeof ( CIMParallelController ) ,  "CIM_ParallelController" }
        ,  { typeof ( Win32ParallelPort ) ,  "Win32_ParallelPort" }
        ,  { typeof ( Win32IDEController ) ,  "Win32_IDEController" }
        ,  { typeof ( Win321394Controller ) ,  "Win32_1394Controller" }
        ,  { typeof ( CIMBattery ) ,  "CIM_Battery" }
        ,  { typeof ( Win32Battery ) ,  "Win32_Battery" }
        ,  { typeof ( Win32PortableBattery ) ,  "Win32_PortableBattery" }
        ,  { typeof ( CIMNetworkAdapter ) ,  "CIM_NetworkAdapter" }
        ,  { typeof ( Win32NetworkAdapter ) ,  "Win32_NetworkAdapter" }
        ,  { typeof ( Win32PnPEntity ) ,  "Win32_PnPEntity" }
        ,  { typeof ( CIMPrinter ) ,  "CIM_Printer" }
        ,  { typeof ( Win32Printer ) ,  "Win32_Printer" }
        ,  { typeof ( CIMSensor ) ,  "CIM_Sensor" }
        ,  { typeof ( CIMBinarySensor ) ,  "CIM_BinarySensor" }
        ,  { typeof ( CIMMultiStateSensor ) ,  "CIM_MultiStateSensor" }
        ,  { typeof ( CIMDiscreteSensor ) ,  "CIM_DiscreteSensor" }
        ,  { typeof ( CIMNumericSensor ) ,  "CIM_NumericSensor" }
        ,  { typeof ( CIMTemperatureSensor ) ,  "CIM_TemperatureSensor" }
        ,  { typeof ( Win32TemperatureProbe ) ,  "Win32_TemperatureProbe" }
        ,  { typeof ( CIMTachometer ) ,  "CIM_Tachometer" }
        ,  { typeof ( CIMVoltageSensor ) ,  "CIM_VoltageSensor" }
        ,  { typeof ( Win32VoltageProbe ) ,  "Win32_VoltageProbe" }
        ,  { typeof ( CIMCurrentSensor ) ,  "CIM_CurrentSensor" }
        ,  { typeof ( Win32CurrentProbe ) ,  "Win32_CurrentProbe" }
        ,  { typeof ( Win32Bus ) ,  "Win32_Bus" }
        ,  { typeof ( CIMUserDevice ) ,  "CIM_UserDevice" }
        ,  { typeof ( CIMKeyboard ) ,  "CIM_Keyboard" }
        ,  { typeof ( Win32Keyboard ) ,  "Win32_Keyboard" }
        ,  { typeof ( CIMDisplay ) ,  "CIM_Display" }
        ,  { typeof ( CIMFlatPanel ) ,  "CIM_FlatPanel" }
        ,  { typeof ( CIMDesktopMonitor ) ,  "CIM_DesktopMonitor" }
        ,  { typeof ( Win32DesktopMonitor ) ,  "Win32_DesktopMonitor" }
        ,  { typeof ( CIMPointingDevice ) ,  "CIM_PointingDevice" }
        ,  { typeof ( Win32PointingDevice ) ,  "Win32_PointingDevice" }
        ,  { typeof ( CIMUSBDevice ) ,  "CIM_USBDevice" }
        ,  { typeof ( CIMUSBHub ) ,  "CIM_USBHub" }
        ,  { typeof ( Win32USBHub ) ,  "Win32_USBHub" }
        ,  { typeof ( CIMAlarmDevice ) ,  "CIM_AlarmDevice" }
        ,  { typeof ( Win32SoundDevice ) ,  "Win32_SoundDevice" }
        ,  { typeof ( Win32MotherboardDevice ) ,  "Win32_MotherboardDevice" }
        ,  { typeof ( CIMPowerSupply ) ,  "CIM_PowerSupply" }
        ,  { typeof ( CIMUninterruptiblePowerSupply ) ,  "CIM_UninterruptiblePowerSupply" }
        ,  { typeof ( CIMScanner ) ,  "CIM_Scanner" }
        ,  { typeof ( CIMPotsModem ) ,  "CIM_PotsModem" }
        ,  { typeof ( Win32POTSModem ) ,  "Win32_POTSModem" }
        ,  { typeof ( CIMCoolingDevice ) ,  "CIM_CoolingDevice" }
        ,  { typeof ( CIMHeatPipe ) ,  "CIM_HeatPipe" }
        ,  { typeof ( Win32HeatPipe ) ,  "Win32_HeatPipe" }
        ,  { typeof ( CIMRefrigeration ) ,  "CIM_Refrigeration" }
        ,  { typeof ( Win32Refrigeration ) ,  "Win32_Refrigeration" }
        ,  { typeof ( CIMFan ) ,  "CIM_Fan" }
        ,  { typeof ( Win32Fan ) ,  "Win32_Fan" }
        ,  { typeof ( Win32OptionalFeature ) ,  "Win32_OptionalFeature" }
        ,  { typeof ( CIMSystem ) ,  "CIM_System" }
        ,  { typeof ( CIMComputerSystem ) ,  "CIM_ComputerSystem" }
        ,  { typeof ( CIMUnitaryComputerSystem ) ,  "CIM_UnitaryComputerSystem" }
        ,  { typeof ( Win32ComputerSystem ) ,  "Win32_ComputerSystem" }
        ,  { typeof ( CIMApplicationSystem ) ,  "CIM_ApplicationSystem" }
        ,  { typeof ( Win32NTDomain ) ,  "Win32_NTDomain" }
        ,  { typeof ( CIMSoftwareElement ) ,  "CIM_SoftwareElement" }
        ,  { typeof ( CIMBIOSElement ) ,  "CIM_BIOSElement" }
        ,  { typeof ( Win32BIOS ) ,  "Win32_BIOS" }
        ,  { typeof ( Win32SoftwareElement ) ,  "Win32_SoftwareElement" }
        ,  { typeof ( CIMVideoBIOSElement ) ,  "CIM_VideoBIOSElement" }
        ,  { typeof ( CIMService ) ,  "CIM_Service" }
        ,  { typeof ( Win32BaseService ) ,  "Win32_BaseService" }
        ,  { typeof ( Win32Service ) ,  "Win32_Service" }
        ,  { typeof ( Win32TerminalService ) ,  "Win32_TerminalService" }
        ,  { typeof ( Win32SystemDriver ) ,  "Win32_SystemDriver" }
        ,  { typeof ( Win32PnPSignedDriver ) ,  "Win32_PnPSignedDriver" }
        ,  { typeof ( CIMBootService ) ,  "CIM_BootService" }
        ,  { typeof ( CIMClusteringService ) ,  "CIM_ClusteringService" }
        ,  { typeof ( Win32ApplicationService ) ,  "Win32_ApplicationService" }
        ,  { typeof ( Win32PrinterDriver ) ,  "Win32_PrinterDriver" }
        ,  { typeof ( CIMLogicalFile ) ,  "CIM_LogicalFile" }
        ,  { typeof ( CIMDataFile ) ,  "CIM_DataFile" }
        ,  { typeof ( Win32ShortcutFile ) ,  "Win32_ShortcutFile" }
        ,  { typeof ( Win32CodecFile ) ,  "Win32_CodecFile" }
        ,  { typeof ( Win32NTEventlogFile ) ,  "Win32_NTEventlogFile" }
        ,  { typeof ( Win32PageFile ) ,  "Win32_PageFile" }
        ,  { typeof ( CIMDirectory ) ,  "CIM_Directory" }
        ,  { typeof ( Win32Directory ) ,  "Win32_Directory" }
        ,  { typeof ( CIMDeviceFile ) ,  "CIM_DeviceFile" }
        ,  { typeof ( CIMThread ) ,  "CIM_Thread" }
        ,  { typeof ( Win32Thread ) ,  "Win32_Thread" }
        ,  { typeof ( Win32COMApplication ) ,  "Win32_COMApplication" }
        ,  { typeof ( Win32DCOMApplication ) ,  "Win32_DCOMApplication" }
        ,  { typeof ( CIMJob ) ,  "CIM_Job" }
        ,  { typeof ( Win32ScheduledJob ) ,  "Win32_ScheduledJob" }
        ,  { typeof ( Win32PrintJob ) ,  "Win32_PrintJob" }
        ,  { typeof ( Win32ServerSession ) ,  "Win32_ServerSession" }
        ,  { typeof ( CIMSoftwareFeature ) ,  "CIM_SoftwareFeature" }
        ,  { typeof ( Win32SoftwareFeature ) ,  "Win32_SoftwareFeature" }
        ,  { typeof ( CIMVideoBIOSFeature ) ,  "CIM_VideoBIOSFeature" }
        ,  { typeof ( CIMBIOSFeature ) ,  "CIM_BIOSFeature" }
        ,  { typeof ( Win32DfsNode ) ,  "Win32_DfsNode" }
        ,  { typeof ( Win32ComponentCategory ) ,  "Win32_ComponentCategory" }
        ,  { typeof ( Win32ProgramGroupOrItem ) ,  "Win32_ProgramGroupOrItem" }
        ,  { typeof ( Win32LogicalProgramGroupItem ) ,  "Win32_LogicalProgramGroupItem" }
        ,  { typeof ( Win32LogicalProgramGroup ) ,  "Win32_LogicalProgramGroup" }
        ,  { typeof ( Win32NetworkConnection ) ,  "Win32_NetworkConnection" }
        ,  { typeof ( Win32COMClass ) ,  "Win32_COMClass" }
        ,  { typeof ( Win32ClassicCOMClass ) ,  "Win32_ClassicCOMClass" }
        ,  { typeof ( Win32Account ) ,  "Win32_Account" }
        ,  { typeof ( Win32UserAccount ) ,  "Win32_UserAccount" }
        ,  { typeof ( Win32Group ) ,  "Win32_Group" }
        ,  { typeof ( Win32SystemAccount ) ,  "Win32_SystemAccount" }
        ,  { typeof ( CIMServiceAccessPoint ) ,  "CIM_ServiceAccessPoint" }
        ,  { typeof ( Win32TCPIPPrinterPort ) ,  "Win32_TCPIPPrinterPort" }
        ,  { typeof ( CIMClusteringSAP ) ,  "CIM_ClusteringSAP" }
        ,  { typeof ( CIMBootSAP ) ,  "CIM_BootSAP" }
        ,  { typeof ( Win32CommandLineAccess ) ,  "Win32_CommandLineAccess" }
        ,  { typeof ( CIMSystemResource ) ,  "CIM_SystemResource" }
        ,  { typeof ( CIMMemoryMappedIO ) ,  "CIM_MemoryMappedIO" }
        ,  { typeof ( Win32SystemMemoryResource ) ,  "Win32_SystemMemoryResource" }
        ,  { typeof ( Win32PortResource ) ,  "Win32_PortResource" }
        ,  { typeof ( Win32DeviceMemoryAddress ) ,  "Win32_DeviceMemoryAddress" }
        ,  { typeof ( CIMIRQ ) ,  "CIM_IRQ" }
        ,  { typeof ( Win32IRQResource ) ,  "Win32_IRQResource" }
        ,  { typeof ( Win32Environment ) ,  "Win32_Environment" }
        ,  { typeof ( CIMDMA ) ,  "CIM_DMA" }
        ,  { typeof ( Win32DMAChannel ) ,  "Win32_DMAChannel" }
        ,  { typeof ( Win32Share ) ,  "Win32_Share" }
        ,  { typeof ( Win32ClusterShare ) ,  "Win32_ClusterShare" }
        ,  { typeof ( CIMFileSystem ) ,  "CIM_FileSystem" }
        ,  { typeof ( CIMRemoteFileSystem ) ,  "CIM_RemoteFileSystem" }
        ,  { typeof ( CIMNFS ) ,  "CIM_NFS" }
        ,  { typeof ( CIMLocalFileSystem ) ,  "CIM_LocalFileSystem" }
        ,  { typeof ( Win32NetworkProtocol ) ,  "Win32_NetworkProtocol" }
        ,  { typeof ( Win32ShadowProvider ) ,  "Win32_ShadowProvider" }
        ,  { typeof ( CIMRedundancyGroup ) ,  "CIM_RedundancyGroup" }
        ,  { typeof ( CIMExtraCapacityGroup ) ,  "CIM_ExtraCapacityGroup" }
        ,  { typeof ( CIMStorageRedundancyGroup ) ,  "CIM_StorageRedundancyGroup" }
        ,  { typeof ( CIMSpareGroup ) ,  "CIM_SpareGroup" }
        ,  { typeof ( Win32QuickFixEngineering ) ,  "Win32_QuickFixEngineering" }
        ,  { typeof ( Win32IP4RouteTable ) ,  "Win32_IP4RouteTable" }
        ,  { typeof ( Win32ShadowCopy ) ,  "Win32_ShadowCopy" }
        ,  { typeof ( Win32LoadOrderGroup ) ,  "Win32_LoadOrderGroup" }
        ,  { typeof ( Win32Session ) ,  "Win32_Session" }
        ,  { typeof ( Win32LogonSession ) ,  "Win32_LogonSession" }
        ,  { typeof ( Win32ServerConnection ) ,  "Win32_ServerConnection" }
        ,  { typeof ( CIMJobDestination ) ,  "CIM_JobDestination" }
        ,  { typeof ( Win32DfsTarget ) ,  "Win32_DfsTarget" }
        ,  { typeof ( Win32NetworkClient ) ,  "Win32_NetworkClient" }
        ,  { typeof ( Win32PageFileUsage ) ,  "Win32_PageFileUsage" }
        ,  { typeof ( Win32IP4PersistedRouteTable ) ,  "Win32_IP4PersistedRouteTable" }
        ,  { typeof ( Win32Registry ) ,  "Win32_Registry" }
        ,  { typeof ( CIMSetting ) ,  "CIM_Setting" }
        ,  { typeof ( Win32NetworkAdapterConfiguration ) ,  "Win32_NetworkAdapterConfiguration" }
        ,  { typeof ( Win32TimeZone ) ,  "Win32_TimeZone" }
        ,  { typeof ( Win32PageFileSetting ) ,  "Win32_PageFileSetting" }
        ,  { typeof ( Win32Desktop ) ,  "Win32_Desktop" }
        ,  { typeof ( Win32ShadowContext ) ,  "Win32_ShadowContext" }
        ,  { typeof ( Win32MSIResource ) ,  "Win32_MSIResource" }
        ,  { typeof ( Win32ServiceControl ) ,  "Win32_ServiceControl" }
        ,  { typeof ( Win32Property ) ,  "Win32_Property" }
        ,  { typeof ( Win32Patch ) ,  "Win32_Patch" }
        ,  { typeof ( Win32PatchPackage ) ,  "Win32_PatchPackage" }
        ,  { typeof ( Win32Binary ) ,  "Win32_Binary" }
        ,  { typeof ( Win32AutochkSetting ) ,  "Win32_AutochkSetting" }
        ,  { typeof ( Win32SerialPortConfiguration ) ,  "Win32_SerialPortConfiguration" }
        ,  { typeof ( CIMMonitorResolution ) ,  "CIM_MonitorResolution" }
        ,  { typeof ( Win32StartupCommand ) ,  "Win32_StartupCommand" }
        ,  { typeof ( Win32BootConfiguration ) ,  "Win32_BootConfiguration" }
        ,  { typeof ( Win32NetworkLoginProfile ) ,  "Win32_NetworkLoginProfile" }
        ,  { typeof ( Win32NamedJobObjectLimitSetting ) ,  "Win32_NamedJobObjectLimitSetting" }
        ,  { typeof ( CIMVideoControllerResolution ) ,  "CIM_VideoControllerResolution" }
        ,  { typeof ( Win32NamedJobObjectSecLimitSetting ) ,  "Win32_NamedJobObjectSecLimitSetting" }
        ,  { typeof ( Win32DisplayConfiguration ) ,  "Win32_DisplayConfiguration" }
        ,  { typeof ( Win32QuotaSetting ) ,  "Win32_QuotaSetting" }
        ,  { typeof ( Win32SecuritySetting ) ,  "Win32_SecuritySetting" }
        ,  { typeof ( Win32LogicalFileSecuritySetting ) ,  "Win32_LogicalFileSecuritySetting" }
        ,  { typeof ( Win32LogicalShareSecuritySetting ) ,  "Win32_LogicalShareSecuritySetting" }
        ,  { typeof ( Win32DisplayControllerConfiguration ) ,  "Win32_DisplayControllerConfiguration" }
        ,  { typeof ( Win32WMISetting ) ,  "Win32_WMISetting" }
        ,  { typeof ( Win32OSRecoveryConfiguration ) ,  "Win32_OSRecoveryConfiguration" }
        ,  { typeof ( Win32COMSetting ) ,  "Win32_COMSetting" }
        ,  { typeof ( Win32ClassicCOMClassSetting ) ,  "Win32_ClassicCOMClassSetting" }
        ,  { typeof ( Win32DCOMApplicationSetting ) ,  "Win32_DCOMApplicationSetting" }
        ,  { typeof ( Win32VideoConfiguration ) ,  "Win32_VideoConfiguration" }
        ,  { typeof ( Win32ODBCAttribute ) ,  "Win32_ODBCAttribute" }
        ,  { typeof ( Win32ODBCSourceAttribute ) ,  "Win32_ODBCSourceAttribute" }
        ,  { typeof ( ScriptingStandardConsumerSetting ) ,  "ScriptingStandardConsumerSetting" }
        ,  { typeof ( Win32PrinterConfiguration ) ,  "Win32_PrinterConfiguration" }
        ,  { typeof ( CIMStatisticalInformation ) ,  "CIM_StatisticalInformation" }
        ,  { typeof ( Win32Perf ) ,  "Win32_Perf" }
        ,  { typeof ( Win32PerfFormattedData ) ,  "Win32_PerfFormattedData" }
        ,  { typeof ( Win32PerfRawData ) ,  "Win32_PerfRawData" }
        ,  { typeof ( Win32NamedJobObjectActgInfo ) ,  "Win32_NamedJobObjectActgInfo" }
        ,  { typeof ( CIMDeviceErrorCounts ) ,  "CIM_DeviceErrorCounts" }
        ,  { typeof ( CIMProduct ) ,  "CIM_Product" }
        ,  { typeof ( Win32ComputerSystemProduct ) ,  "Win32_ComputerSystemProduct" }
        ,  { typeof ( Win32Product ) ,  "Win32_Product" }
        ,  { typeof ( SoftwareLicensingProduct ) ,  "SoftwareLicensingProduct" }
        ,  { typeof ( SoftwareLicensingService ) ,  "SoftwareLicensingService" }
        ,  { typeof ( SoftwareLicensingTokenActivationLicense ) ,  "SoftwareLicensingTokenActivationLicense" }
        ,  { typeof ( Win32UserProfile ) ,  "Win32_UserProfile" }
        ,  { typeof ( Win32FolderRedirectionHealth ) ,  "Win32_FolderRedirectionHealth" }
        ,  { typeof ( CIMIndication ) ,  "CIM_Indication" }
        ,  { typeof ( CIMClassIndication ) ,  "CIM_ClassIndication" }
        ,  { typeof ( CIMClassDeletion ) ,  "CIM_ClassDeletion" }
        ,  { typeof ( CIMClassCreation ) ,  "CIM_ClassCreation" }
        ,  { typeof ( CIMClassModification ) ,  "CIM_ClassModification" }
        ,  { typeof ( CIMInstIndication ) ,  "CIM_InstIndication" }
        ,  { typeof ( CIMInstCreation ) ,  "CIM_InstCreation" }
        ,  { typeof ( CIMInstModification ) ,  "CIM_InstModification" }
        ,  { typeof ( CIMInstDeletion ) ,  "CIM_InstDeletion" }
        ,  { typeof ( NotifyStatus ) ,  "__NotifyStatus" }
        ,  { typeof ( ExtendedStatus ) ,  "__ExtendedStatus" }
        ,  { typeof ( Win32PrivilegesStatus ) ,  "Win32_PrivilegesStatus" }
        ,  { typeof ( Win32JobObjectStatus ) ,  "Win32_JobObjectStatus" }
        ,  { typeof ( CIMError ) ,  "CIM_Error" }
        ,  { typeof ( MSFTWmiError ) ,  "MSFT_WmiError" }
        ,  { typeof ( MSFTExtendedStatus ) ,  "MSFT_ExtendedStatus" }
        ,  { typeof ( SecurityRelatedClass ) ,  "__SecurityRelatedClass" }
        ,  { typeof ( Trustee ) ,  "__Trustee" }
        ,  { typeof ( Win32Trustee ) ,  "Win32_Trustee" }
        ,  { typeof ( NTLMUser9X ) ,  "__NTLMUser9X" }
        ,  { typeof ( ACE ) ,  "__ACE" }
        ,  { typeof ( Win32ACE ) ,  "Win32_ACE" }
        ,  { typeof ( SecurityDescriptor ) ,  "__SecurityDescriptor" }
        ,  { typeof ( Win32SecurityDescriptor ) ,  "Win32_SecurityDescriptor" }
        ,  { typeof ( PARAMETERS ) ,  "__PARAMETERS" }
        ,  { typeof ( Win32NTLogEvent ) ,  "Win32_NTLogEvent" }
        ,  { typeof ( CIMConfiguration ) ,  "CIM_Configuration" }
        ,  { typeof ( Win32OfflineFilesUserConfiguration ) ,  "Win32_OfflineFilesUserConfiguration" }
        ,  { typeof ( CIMLocation ) ,  "CIM_Location" }
        ,  { typeof ( Win32WinSAT ) ,  "Win32_WinSAT" }
        ,  { typeof ( Win32SecurityDescriptorHelper ) ,  "Win32_SecurityDescriptorHelper" }
        ,  { typeof ( Win32CurrentTime ) ,  "Win32_CurrentTime" }
        ,  { typeof ( Win32UTCTime ) ,  "Win32_UTCTime" }
        ,  { typeof ( Win32LocalTime ) ,  "Win32_LocalTime" }
        ,  { typeof ( CIMFRU ) ,  "CIM_FRU" }
        ,  { typeof ( CIMAction ) ,  "CIM_Action" }
        ,  { typeof ( Win32ShortcutAction ) ,  "Win32_ShortcutAction" }
        ,  { typeof ( CIMRebootAction ) ,  "CIM_RebootAction" }
        ,  { typeof ( Win32ExtensionInfoAction ) ,  "Win32_ExtensionInfoAction" }
        ,  { typeof ( CIMDirectoryAction ) ,  "CIM_DirectoryAction" }
        ,  { typeof ( CIMCreateDirectoryAction ) ,  "CIM_CreateDirectoryAction" }
        ,  { typeof ( Win32CreateFolderAction ) ,  "Win32_CreateFolderAction" }
        ,  { typeof ( CIMRemoveDirectoryAction ) ,  "CIM_RemoveDirectoryAction" }
        ,  { typeof ( Win32RegistryAction ) ,  "Win32_RegistryAction" }
        ,  { typeof ( Win32ClassInfoAction ) ,  "Win32_ClassInfoAction" }
        ,  { typeof ( CIMModifySettingAction ) ,  "CIM_ModifySettingAction" }
        ,  { typeof ( Win32SelfRegModuleAction ) ,  "Win32_SelfRegModuleAction" }
        ,  { typeof ( Win32TypeLibraryAction ) ,  "Win32_TypeLibraryAction" }
        ,  { typeof ( CIMExecuteProgram ) ,  "CIM_ExecuteProgram" }
        ,  { typeof ( Win32BindImageAction ) ,  "Win32_BindImageAction" }
        ,  { typeof ( Win32RemoveIniAction ) ,  "Win32_RemoveIniAction" }
        ,  { typeof ( Win32MIMEInfoAction ) ,  "Win32_MIMEInfoAction" }
        ,  { typeof ( Win32FontInfoAction ) ,  "Win32_FontInfoAction" }
        ,  { typeof ( Win32PublishComponentAction ) ,  "Win32_PublishComponentAction" }
        ,  { typeof ( CIMFileAction ) ,  "CIM_FileAction" }
        ,  { typeof ( Win32MoveFileAction ) ,  "Win32_MoveFileAction" }
        ,  { typeof ( CIMCopyFileAction ) ,  "CIM_CopyFileAction" }
        ,  { typeof ( Win32DuplicateFileAction ) ,  "Win32_DuplicateFileAction" }
        ,  { typeof ( CIMRemoveFileAction ) ,  "CIM_RemoveFileAction" }
        ,  { typeof ( Win32RemoveFileAction ) ,  "Win32_RemoveFileAction" }
        ,  { typeof ( Win32OfflineFilesAssociatedItems ) ,  "Win32_OfflineFilesAssociatedItems" }
        ,  { typeof ( MsftProviders ) ,  "Msft_Providers" }
        ,  { typeof ( Win32OfflineFilesChangeInfo ) ,  "Win32_OfflineFilesChangeInfo" }
        ,  { typeof ( Win32RoamingProfileMachineConfiguration ) ,  "Win32_RoamingProfileMachineConfiguration" }
        ,  { typeof ( Win32SID ) ,  "Win32_SID" }
        ,  { typeof ( Win32RoamingProfileUserConfiguration ) ,  "Win32_RoamingProfileUserConfiguration" }
        ,  { typeof ( Win32LUIDandAttributes ) ,  "Win32_LUIDandAttributes" }
        ,  { typeof ( MsftWmiProviderCounters ) ,  "Msft_WmiProvider_Counters" }
        ,  { typeof ( Win32LUID ) ,  "Win32_LUID" }
        ,  { typeof ( CIMCheck ) ,  "CIM_Check" }
        ,  { typeof ( CIMDiskSpaceCheck ) ,  "CIM_DiskSpaceCheck" }
        ,  { typeof ( CIMDirectorySpecification ) ,  "CIM_DirectorySpecification" }
        ,  { typeof ( Win32DirectorySpecification ) ,  "Win32_DirectorySpecification" }
        ,  { typeof ( Win32SoftwareElementCondition ) ,  "Win32_SoftwareElementCondition" }
        ,  { typeof ( Win32ODBCDriverSpecification ) ,  "Win32_ODBCDriverSpecification" }
        ,  { typeof ( CIMMemoryCheck ) ,  "CIM_MemoryCheck" }
        ,  { typeof ( Win32ServiceSpecification ) ,  "Win32_ServiceSpecification" }
        ,  { typeof ( CIMFileSpecification ) ,  "CIM_FileSpecification" }
        ,  { typeof ( Win32FileSpecification ) ,  "Win32_FileSpecification" }
        ,  { typeof ( Win32IniFileSpecification ) ,  "Win32_IniFileSpecification" }
        ,  { typeof ( CIMSoftwareElementVersionCheck ) ,  "CIM_SoftwareElementVersionCheck" }
        ,  { typeof ( CIMSettingCheck ) ,  "CIM_SettingCheck" }
        ,  { typeof ( Win32LaunchCondition ) ,  "Win32_LaunchCondition" }
        ,  { typeof ( Win32ODBCDataSourceSpecification ) ,  "Win32_ODBCDataSourceSpecification" }
        ,  { typeof ( Win32ODBCTranslatorSpecification ) ,  "Win32_ODBCTranslatorSpecification" }
        ,  { typeof ( Win32ProgIDSpecification ) ,  "Win32_ProgIDSpecification" }
        ,  { typeof ( CIMSwapSpaceCheck ) ,  "CIM_SwapSpaceCheck" }
        ,  { typeof ( Win32EnvironmentSpecification ) ,  "Win32_EnvironmentSpecification" }
        ,  { typeof ( Win32ReserveCost ) ,  "Win32_ReserveCost" }
        ,  { typeof ( CIMVersionCompatibilityCheck ) ,  "CIM_VersionCompatibilityCheck" }
        ,  { typeof ( CIMOSVersionCheck ) ,  "CIM_OSVersionCheck" }
        ,  { typeof ( Win32Condition ) ,  "Win32_Condition" }
        ,  { typeof ( StdRegProv ) ,  "StdRegProv" }
        ,  { typeof ( Win32FolderRedirection ) ,  "Win32_FolderRedirection" }
        ,  { typeof ( Win32TokenPrivileges ) ,  "Win32_TokenPrivileges" }
        ,  { typeof ( CIMCollectionOfMSEs ) ,  "CIM_CollectionOfMSEs" }
        ,  { typeof ( Win32NamedJobObject ) ,  "Win32_NamedJobObject" }
        ,  { typeof ( CIMStorageError ) ,  "CIM_StorageError" }
        ,  { typeof ( Win32OfflineFilesItem ) ,  "Win32_OfflineFilesItem" }
        ,  { typeof ( Win32OfflineFilesBackgroundSync ) ,  "Win32_OfflineFilesBackgroundSync" }
        ,  { typeof ( Win32InstalledWin32Program ) ,  "Win32_InstalledWin32Program" }
        ,  { typeof ( Win32RoamingUserHealthConfiguration ) ,  "Win32_RoamingUserHealthConfiguration" }
        ,  { typeof ( CIMReplacementSet ) ,  "CIM_ReplacementSet" }
        ,  { typeof ( Win32UserStateConfigurationControls ) ,  "Win32_UserStateConfigurationControls" }
        ,  { typeof ( Win32OfflineFilesPinInfo ) ,  "Win32_OfflineFilesPinInfo" }
        ,  { typeof ( Win32OfflineFilesFileSysInfo ) ,  "Win32_OfflineFilesFileSysInfo" }
        ,  { typeof ( NTEventlogProviderConfig ) ,  "NTEventlogProviderConfig" }
        ,  { typeof ( Win32OfflineFilesSuspendInfo ) ,  "Win32_OfflineFilesSuspendInfo" }
        ,  { typeof ( Win32MethodParameterClass ) ,  "Win32_MethodParameterClass" }
        ,  { typeof ( Win32ProcessStartup ) ,  "Win32_ProcessStartup" }
        ,  { typeof ( Win32PingStatus ) ,  "Win32_PingStatus" }
        ,  { typeof ( Win32FolderRedirectionUserConfiguration ) ,  "Win32_FolderRedirectionUserConfiguration" }
        ,  { typeof ( Win32Reliability ) ,  "Win32_Reliability" }
        ,  { typeof ( Win32ReliabilityStabilityMetrics ) ,  "Win32_ReliabilityStabilityMetrics" }
        ,  { typeof ( Win32ReliabilityRecords ) ,  "Win32_ReliabilityRecords" }
        ,  { typeof ( Win32InstalledProgramFramework ) ,  "Win32_InstalledProgramFramework" }
        ,  { typeof ( Win32FolderRedirectionHealthConfiguration ) ,  "Win32_FolderRedirectionHealthConfiguration" }
        ,  { typeof ( Win32OfflineFilesMachineConfiguration ) ,  "Win32_OfflineFilesMachineConfiguration" }
        ,  { typeof ( Win32PnPDeviceProperty ) ,  "Win32_PnPDeviceProperty" }
        ,  { typeof ( Win32PnPDevicePropertyString ) ,  "Win32_PnPDevicePropertyString" }
        ,  { typeof ( Win32PnPDevicePropertyReal32Array ) ,  "Win32_PnPDevicePropertyReal32Array" }
        ,  { typeof ( Win32PnPDevicePropertyReal64 ) ,  "Win32_PnPDevicePropertyReal64" }
        ,  { typeof ( Win32PnPDevicePropertyUint16 ) ,  "Win32_PnPDevicePropertyUint16" }
        ,  { typeof ( Win32PnPDevicePropertySint16Array ) ,  "Win32_PnPDevicePropertySint16Array" }
        ,  { typeof ( Win32PnPDevicePropertySint64 ) ,  "Win32_PnPDevicePropertySint64" }
        ,  { typeof ( Win32PnPDevicePropertyUint8 ) ,  "Win32_PnPDevicePropertyUint8" }
        ,  { typeof ( Win32PnPDevicePropertySint8 ) ,  "Win32_PnPDevicePropertySint8" }
        ,  { typeof ( Win32PnPDevicePropertySecurityDescriptor ) ,  "Win32_PnPDevicePropertySecurityDescriptor" }
        ,  { typeof ( Win32PnPDevicePropertyReal32 ) ,  "Win32_PnPDevicePropertyReal32" }
        ,  { typeof ( Win32PnPDevicePropertySint32 ) ,  "Win32_PnPDevicePropertySint32" }
        ,  { typeof ( Win32PnPDevicePropertyStringArray ) ,  "Win32_PnPDevicePropertyStringArray" }
        ,  { typeof ( Win32PnPDevicePropertyUint32 ) ,  "Win32_PnPDevicePropertyUint32" }
        ,  { typeof ( Win32PnPDevicePropertyUint64 ) ,  "Win32_PnPDevicePropertyUint64" }
        ,  { typeof ( Win32PnPDevicePropertyBoolean ) ,  "Win32_PnPDevicePropertyBoolean" }
        ,  { typeof ( Win32PnPDevicePropertyUint16Array ) ,  "Win32_PnPDevicePropertyUint16Array" }
        ,  { typeof ( Win32PnPDevicePropertyBinary ) ,  "Win32_PnPDevicePropertyBinary" }
        ,  { typeof ( Win32PnPDevicePropertySint32Array ) ,  "Win32_PnPDevicePropertySint32Array" }
        ,  { typeof ( Win32PnPDevicePropertySint16 ) ,  "Win32_PnPDevicePropertySint16" }
        ,  { typeof ( Win32PnPDevicePropertyReal64Array ) ,  "Win32_PnPDevicePropertyReal64Array" }
        ,  { typeof ( Win32PnPDevicePropertyBooleanArray ) ,  "Win32_PnPDevicePropertyBooleanArray" }
        ,  { typeof ( Win32PnPDevicePropertyUint32Array ) ,  "Win32_PnPDevicePropertyUint32Array" }
        ,  { typeof ( Win32PnPDevicePropertyDateTime ) ,  "Win32_PnPDevicePropertyDateTime" }
        ,  { typeof ( Win32PnPDevicePropertySecurityDescriptorArray ) ,  "Win32_PnPDevicePropertySecurityDescriptorArray" }
        ,  { typeof ( Win32PnPDevicePropertySint8Array ) ,  "Win32_PnPDevicePropertySint8Array" }
        ,  { typeof ( Win32OfflineFilesCache ) ,  "Win32_OfflineFilesCache" }
        ,  { typeof ( CIMSupportAccess ) ,  "CIM_SupportAccess" }
        ,  { typeof ( Win32OfflineFilesConnectionInfo ) ,  "Win32_OfflineFilesConnectionInfo" }
        ,  { typeof ( Win32InstalledStoreProgram ) ,  "Win32_InstalledStoreProgram" }
        ,  { typeof ( Win32TokenGroups ) ,  "Win32_TokenGroups" }
        ,  { typeof ( CIMPhysicalCapacity ) ,  "CIM_PhysicalCapacity" }
        ,  { typeof ( CIMMemoryCapacity ) ,  "CIM_MemoryCapacity" }
        ,  { typeof ( Win32DefragAnalysis ) ,  "Win32_DefragAnalysis" }
        ,  { typeof ( Win32SIDandAttributes ) ,  "Win32_SIDandAttributes" }
        ,  { typeof ( Win32RoamingProfileBackgroundUploadParams ) ,  "Win32_RoamingProfileBackgroundUploadParams" }
        ,  { typeof ( Win32RoamingProfileSlowLinkParams ) ,  "Win32_RoamingProfileSlowLinkParams" }
        ,  { typeof ( Win32OfflineFilesDiskSpaceLimit ) ,  "Win32_OfflineFilesDiskSpaceLimit" }
        ,  { typeof ( Win32OfflineFilesDirtyInfo ) ,  "Win32_OfflineFilesDirtyInfo" }
        ,  { typeof ( Win32OfflineFilesHealth ) ,  "Win32_OfflineFilesHealth" }
        ,  { typeof ( Win32PerfFormattedDataAFDCountersMicrosoftWinsockBSP ) ,  "Win32_PerfFormattedData_AFDCounters_MicrosoftWinsockBSP" }
        ,  { typeof ( Win32PerfRawDataAFDCountersMicrosoftWinsockBSP ) ,  "Win32_PerfRawData_AFDCounters_MicrosoftWinsockBSP" }
        ,  { typeof ( Win32PerfFormattedDataASPNET4030319ASPNETAppsv4030319 ) ,  "Win32_PerfFormattedData_ASPNET4030319_ASPNETAppsv4030319" }
        ,  { typeof ( Win32PerfRawDataASPNET4030319ASPNETAppsv4030319 ) ,  "Win32_PerfRawData_ASPNET4030319_ASPNETAppsv4030319" }
        ,  { typeof ( Win32PerfFormattedDataASPNET4030319ASPNETv4030319 ) ,  "Win32_PerfFormattedData_ASPNET4030319_ASPNETv4030319" }
        ,  { typeof ( Win32PerfRawDataASPNET4030319ASPNETv4030319 ) ,  "Win32_PerfRawData_ASPNET4030319_ASPNETv4030319" }
        ,  { typeof ( Win32PerfFormattedDataASPNETASPNET ) ,  "Win32_PerfFormattedData_ASPNET_ASPNET" }
        ,  { typeof ( Win32PerfRawDataASPNETASPNET ) ,  "Win32_PerfRawData_ASPNET_ASPNET" }
        ,  { typeof ( Win32PerfFormattedDataASPNETASPNETApplications ) ,  "Win32_PerfFormattedData_ASPNET_ASPNETApplications" }
        ,  { typeof ( Win32PerfRawDataASPNETASPNETApplications ) ,  "Win32_PerfRawData_ASPNET_ASPNETApplications" }
        ,  { typeof ( Win32PerfFormattedDataAspnetstateASPNETStateService ) ,  "Win32_PerfFormattedData_aspnetstate_ASPNETStateService" }
        ,  { typeof ( Win32PerfRawDataAspnetstateASPNETStateService ) ,  "Win32_PerfRawData_aspnetstate_ASPNETStateService" }
        ,  { typeof ( Win32PerfFormattedDataAuthorizationManagerAuthorizationManagerApplications ) ,  "Win32_PerfFormattedData_AuthorizationManager_AuthorizationManagerApplications" }
        ,  { typeof ( Win32PerfRawDataAuthorizationManagerAuthorizationManagerApplications ) ,  "Win32_PerfRawData_AuthorizationManager_AuthorizationManagerApplications" }
        ,  { typeof ( Win32PerfFormattedDataBalancerStatsHyperVDynamicMemoryBalancer ) ,  "Win32_PerfFormattedData_BalancerStats_HyperVDynamicMemoryBalancer" }
        ,  { typeof ( Win32PerfRawDataBalancerStatsHyperVDynamicMemoryBalancer ) ,  "Win32_PerfRawData_BalancerStats_HyperVDynamicMemoryBalancer" }
        ,  { typeof ( Win32PerfFormattedDataBalancerStatsHyperVDynamicMemoryVM ) ,  "Win32_PerfFormattedData_BalancerStats_HyperVDynamicMemoryVM" }
        ,  { typeof ( Win32PerfRawDataBalancerStatsHyperVDynamicMemoryVM ) ,  "Win32_PerfRawData_BalancerStats_HyperVDynamicMemoryVM" }
        ,  { typeof ( Win32PerfFormattedDataBITSBITSNetUtilization ) ,  "Win32_PerfFormattedData_BITS_BITSNetUtilization" }
        ,  { typeof ( Win32PerfRawDataBITSBITSNetUtilization ) ,  "Win32_PerfRawData_BITS_BITSNetUtilization" }
        ,  { typeof ( Win32PerfFormattedDataCountersAppVClientStreamedDataPercentage ) ,  "Win32_PerfFormattedData_Counters_AppVClientStreamedDataPercentage" }
        ,  { typeof ( Win32PerfRawDataCountersAppVClientStreamedDataPercentage ) ,  "Win32_PerfRawData_Counters_AppVClientStreamedDataPercentage" }
        ,  { typeof ( Win32PerfFormattedDataCountersBluetoothDevice ) ,  "Win32_PerfFormattedData_Counters_BluetoothDevice" }
        ,  { typeof ( Win32PerfRawDataCountersBluetoothDevice ) ,  "Win32_PerfRawData_Counters_BluetoothDevice" }
        ,  { typeof ( Win32PerfFormattedDataCountersBluetoothRadio ) ,  "Win32_PerfFormattedData_Counters_BluetoothRadio" }
        ,  { typeof ( Win32PerfRawDataCountersBluetoothRadio ) ,  "Win32_PerfRawData_Counters_BluetoothRadio" }
        ,  { typeof ( Win32PerfFormattedDataCountersDNS64Global ) ,  "Win32_PerfFormattedData_Counters_DNS64Global" }
        ,  { typeof ( Win32PerfRawDataCountersDNS64Global ) ,  "Win32_PerfRawData_Counters_DNS64Global" }
        ,  { typeof ( Win32PerfFormattedDataCountersEventLog ) ,  "Win32_PerfFormattedData_Counters_EventLog" }
        ,  { typeof ( Win32PerfRawDataCountersEventLog ) ,  "Win32_PerfRawData_Counters_EventLog" }
        ,  { typeof ( Win32PerfFormattedDataCountersEventTracingforWindows ) ,  "Win32_PerfFormattedData_Counters_EventTracingforWindows" }
        ,  { typeof ( Win32PerfRawDataCountersEventTracingforWindows ) ,  "Win32_PerfRawData_Counters_EventTracingforWindows" }
        ,  { typeof ( Win32PerfFormattedDataCountersEventTracingforWindowsSession ) ,  "Win32_PerfFormattedData_Counters_EventTracingforWindowsSession" }
        ,  { typeof ( Win32PerfRawDataCountersEventTracingforWindowsSession ) ,  "Win32_PerfRawData_Counters_EventTracingforWindowsSession" }
        ,  { typeof ( Win32PerfFormattedDataCountersFileSystemDiskActivity ) ,  "Win32_PerfFormattedData_Counters_FileSystemDiskActivity" }
        ,  { typeof ( Win32PerfRawDataCountersFileSystemDiskActivity ) ,  "Win32_PerfRawData_Counters_FileSystemDiskActivity" }
        ,  { typeof ( Win32PerfFormattedDataCountersGenericIKEv1AuthIPandIKEv2 ) ,  "Win32_PerfFormattedData_Counters_GenericIKEv1AuthIPandIKEv2" }
        ,  { typeof ( Win32PerfRawDataCountersGenericIKEv1AuthIPandIKEv2 ) ,  "Win32_PerfRawData_Counters_GenericIKEv1AuthIPandIKEv2" }
        ,  { typeof ( Win32PerfFormattedDataCountersHTTPService ) ,  "Win32_PerfFormattedData_Counters_HTTPService" }
        ,  { typeof ( Win32PerfRawDataCountersHTTPService ) ,  "Win32_PerfRawData_Counters_HTTPService" }
        ,  { typeof ( Win32PerfFormattedDataCountersHTTPServiceRequestQueues ) ,  "Win32_PerfFormattedData_Counters_HTTPServiceRequestQueues" }
        ,  { typeof ( Win32PerfRawDataCountersHTTPServiceRequestQueues ) ,  "Win32_PerfRawData_Counters_HTTPServiceRequestQueues" }
        ,  { typeof ( Win32PerfFormattedDataCountersHTTPServiceUrlGroups ) ,  "Win32_PerfFormattedData_Counters_HTTPServiceUrlGroups" }
        ,  { typeof ( Win32PerfRawDataCountersHTTPServiceUrlGroups ) ,  "Win32_PerfRawData_Counters_HTTPServiceUrlGroups" }
        ,  { typeof ( Win32PerfFormattedDataCountersHyperVDynamicMemoryIntegrationService ) ,  "Win32_PerfFormattedData_Counters_HyperVDynamicMemoryIntegrationService" }
        ,  { typeof ( Win32PerfRawDataCountersHyperVDynamicMemoryIntegrationService ) ,  "Win32_PerfRawData_Counters_HyperVDynamicMemoryIntegrationService" }
        ,  { typeof ( Win32PerfFormattedDataCountersHyperVVirtualMachineBus ) ,  "Win32_PerfFormattedData_Counters_HyperVVirtualMachineBus" }
        ,  { typeof ( Win32PerfRawDataCountersHyperVVirtualMachineBus ) ,  "Win32_PerfRawData_Counters_HyperVVirtualMachineBus" }
        ,  { typeof ( Win32PerfFormattedDataCountersHyperVVirtualMachineBusPipes ) ,  "Win32_PerfFormattedData_Counters_HyperVVirtualMachineBusPipes" }
        ,  { typeof ( Win32PerfRawDataCountersHyperVVirtualMachineBusPipes ) ,  "Win32_PerfRawData_Counters_HyperVVirtualMachineBusPipes" }
        ,  { typeof ( Win32PerfFormattedDataCountersHyperVVirtualMachineBusProviderPipes ) ,  "Win32_PerfFormattedData_Counters_HyperVVirtualMachineBusProviderPipes" }
        ,  { typeof ( Win32PerfRawDataCountersHyperVVirtualMachineBusProviderPipes ) ,  "Win32_PerfRawData_Counters_HyperVVirtualMachineBusProviderPipes" }
        ,  { typeof ( Win32PerfFormattedDataCountersHyperVVirtualStorageDevice ) ,  "Win32_PerfFormattedData_Counters_HyperVVirtualStorageDevice" }
        ,  { typeof ( Win32PerfRawDataCountersHyperVVirtualStorageDevice ) ,  "Win32_PerfRawData_Counters_HyperVVirtualStorageDevice" }
        ,  { typeof ( Win32PerfFormattedDataCountersIPHTTPSGlobal ) ,  "Win32_PerfFormattedData_Counters_IPHTTPSGlobal" }
        ,  { typeof ( Win32PerfRawDataCountersIPHTTPSGlobal ) ,  "Win32_PerfRawData_Counters_IPHTTPSGlobal" }
        ,  { typeof ( Win32PerfFormattedDataCountersIPHTTPSSession ) ,  "Win32_PerfFormattedData_Counters_IPHTTPSSession" }
        ,  { typeof ( Win32PerfRawDataCountersIPHTTPSSession ) ,  "Win32_PerfRawData_Counters_IPHTTPSSession" }
        ,  { typeof ( Win32PerfFormattedDataCountersIPsecAuthIPIPv4 ) ,  "Win32_PerfFormattedData_Counters_IPsecAuthIPIPv4" }
        ,  { typeof ( Win32PerfRawDataCountersIPsecAuthIPIPv4 ) ,  "Win32_PerfRawData_Counters_IPsecAuthIPIPv4" }
        ,  { typeof ( Win32PerfFormattedDataCountersIPsecAuthIPIPv6 ) ,  "Win32_PerfFormattedData_Counters_IPsecAuthIPIPv6" }
        ,  { typeof ( Win32PerfRawDataCountersIPsecAuthIPIPv6 ) ,  "Win32_PerfRawData_Counters_IPsecAuthIPIPv6" }
        ,  { typeof ( Win32PerfFormattedDataCountersIPsecConnections ) ,  "Win32_PerfFormattedData_Counters_IPsecConnections" }
        ,  { typeof ( Win32PerfRawDataCountersIPsecConnections ) ,  "Win32_PerfRawData_Counters_IPsecConnections" }
        ,  { typeof ( Win32PerfFormattedDataCountersIPsecDriver ) ,  "Win32_PerfFormattedData_Counters_IPsecDriver" }
        ,  { typeof ( Win32PerfRawDataCountersIPsecDriver ) ,  "Win32_PerfRawData_Counters_IPsecDriver" }
        ,  { typeof ( Win32PerfFormattedDataCountersIPsecIKEv1IPv4 ) ,  "Win32_PerfFormattedData_Counters_IPsecIKEv1IPv4" }
        ,  { typeof ( Win32PerfRawDataCountersIPsecIKEv1IPv4 ) ,  "Win32_PerfRawData_Counters_IPsecIKEv1IPv4" }
        ,  { typeof ( Win32PerfFormattedDataCountersIPsecIKEv1IPv6 ) ,  "Win32_PerfFormattedData_Counters_IPsecIKEv1IPv6" }
        ,  { typeof ( Win32PerfRawDataCountersIPsecIKEv1IPv6 ) ,  "Win32_PerfRawData_Counters_IPsecIKEv1IPv6" }
        ,  { typeof ( Win32PerfFormattedDataCountersIPsecIKEv2IPv4 ) ,  "Win32_PerfFormattedData_Counters_IPsecIKEv2IPv4" }
        ,  { typeof ( Win32PerfRawDataCountersIPsecIKEv2IPv4 ) ,  "Win32_PerfRawData_Counters_IPsecIKEv2IPv4" }
        ,  { typeof ( Win32PerfFormattedDataCountersIPsecIKEv2IPv6 ) ,  "Win32_PerfFormattedData_Counters_IPsecIKEv2IPv6" }
        ,  { typeof ( Win32PerfRawDataCountersIPsecIKEv2IPv6 ) ,  "Win32_PerfRawData_Counters_IPsecIKEv2IPv6" }
        ,  { typeof ( Win32PerfFormattedDataCountersNetlogon ) ,  "Win32_PerfFormattedData_Counters_Netlogon" }
        ,  { typeof ( Win32PerfRawDataCountersNetlogon ) ,  "Win32_PerfRawData_Counters_Netlogon" }
        ,  { typeof ( Win32PerfFormattedDataCountersNetworkQoSPolicy ) ,  "Win32_PerfFormattedData_Counters_NetworkQoSPolicy" }
        ,  { typeof ( Win32PerfRawDataCountersNetworkQoSPolicy ) ,  "Win32_PerfRawData_Counters_NetworkQoSPolicy" }
        ,  { typeof ( Win32PerfFormattedDataCountersNodejs ) ,  "Win32_PerfFormattedData_Counters_Nodejs" }
        ,  { typeof ( Win32PerfRawDataCountersNodejs ) ,  "Win32_PerfRawData_Counters_Nodejs" }
        ,  { typeof ( Win32PerfFormattedDataCountersPacerFlow ) ,  "Win32_PerfFormattedData_Counters_PacerFlow" }
        ,  { typeof ( Win32PerfRawDataCountersPacerFlow ) ,  "Win32_PerfRawData_Counters_PacerFlow" }
        ,  { typeof ( Win32PerfFormattedDataCountersPacerPipe ) ,  "Win32_PerfFormattedData_Counters_PacerPipe" }
        ,  { typeof ( Win32PerfRawDataCountersPacerPipe ) ,  "Win32_PerfRawData_Counters_PacerPipe" }
        ,  { typeof ( Win32PerfFormattedDataCountersPacketDirectECUtilization ) ,  "Win32_PerfFormattedData_Counters_PacketDirectECUtilization" }
        ,  { typeof ( Win32PerfRawDataCountersPacketDirectECUtilization ) ,  "Win32_PerfRawData_Counters_PacketDirectECUtilization" }
        ,  { typeof ( Win32PerfFormattedDataCountersPacketDirectQueueDepth ) ,  "Win32_PerfFormattedData_Counters_PacketDirectQueueDepth" }
        ,  { typeof ( Win32PerfRawDataCountersPacketDirectQueueDepth ) ,  "Win32_PerfRawData_Counters_PacketDirectQueueDepth" }
        ,  { typeof ( Win32PerfFormattedDataCountersPacketDirectReceiveCounters ) ,  "Win32_PerfFormattedData_Counters_PacketDirectReceiveCounters" }
        ,  { typeof ( Win32PerfRawDataCountersPacketDirectReceiveCounters ) ,  "Win32_PerfRawData_Counters_PacketDirectReceiveCounters" }
        ,  { typeof ( Win32PerfFormattedDataCountersPacketDirectReceiveFilters ) ,  "Win32_PerfFormattedData_Counters_PacketDirectReceiveFilters" }
        ,  { typeof ( Win32PerfRawDataCountersPacketDirectReceiveFilters ) ,  "Win32_PerfRawData_Counters_PacketDirectReceiveFilters" }
        ,  { typeof ( Win32PerfFormattedDataCountersPacketDirectTransmitCounters ) ,  "Win32_PerfFormattedData_Counters_PacketDirectTransmitCounters" }
        ,  { typeof ( Win32PerfRawDataCountersPacketDirectTransmitCounters ) ,  "Win32_PerfRawData_Counters_PacketDirectTransmitCounters" }
        ,  { typeof ( Win32PerfFormattedDataCountersPerProcessorNetworkActivityCycles ) ,  "Win32_PerfFormattedData_Counters_PerProcessorNetworkActivityCycles" }
        ,  { typeof ( Win32PerfRawDataCountersPerProcessorNetworkActivityCycles ) ,  "Win32_PerfRawData_Counters_PerProcessorNetworkActivityCycles" }
        ,  { typeof ( Win32PerfFormattedDataCountersPerProcessorNetworkInterfaceCardActivity ) ,  "Win32_PerfFormattedData_Counters_PerProcessorNetworkInterfaceCardActivity" }
        ,  { typeof ( Win32PerfRawDataCountersPerProcessorNetworkInterfaceCardActivity ) ,  "Win32_PerfRawData_Counters_PerProcessorNetworkInterfaceCardActivity" }
        ,  { typeof ( Win32PerfFormattedDataCountersPhysicalNetworkInterfaceCardActivity ) ,  "Win32_PerfFormattedData_Counters_PhysicalNetworkInterfaceCardActivity" }
        ,  { typeof ( Win32PerfRawDataCountersPhysicalNetworkInterfaceCardActivity ) ,  "Win32_PerfRawData_Counters_PhysicalNetworkInterfaceCardActivity" }
        ,  { typeof ( Win32PerfFormattedDataCountersPowerShellWorkflow ) ,  "Win32_PerfFormattedData_Counters_PowerShellWorkflow" }
        ,  { typeof ( Win32PerfRawDataCountersPowerShellWorkflow ) ,  "Win32_PerfRawData_Counters_PowerShellWorkflow" }
        ,  { typeof ( Win32PerfFormattedDataCountersProcessorInformation ) ,  "Win32_PerfFormattedData_Counters_ProcessorInformation" }
        ,  { typeof ( Win32PerfRawDataCountersProcessorInformation ) ,  "Win32_PerfRawData_Counters_ProcessorInformation" }
        ,  { typeof ( Win32PerfFormattedDataCountersRDMAActivity ) ,  "Win32_PerfFormattedData_Counters_RDMAActivity" }
        ,  { typeof ( Win32PerfRawDataCountersRDMAActivity ) ,  "Win32_PerfRawData_Counters_RDMAActivity" }
        ,  { typeof ( Win32PerfFormattedDataCountersReFS ) ,  "Win32_PerfFormattedData_Counters_ReFS" }
        ,  { typeof ( Win32PerfRawDataCountersReFS ) ,  "Win32_PerfRawData_Counters_ReFS" }
        ,  { typeof ( Win32PerfFormattedDataCountersRemoteFXGraphics ) ,  "Win32_PerfFormattedData_Counters_RemoteFXGraphics" }
        ,  { typeof ( Win32PerfRawDataCountersRemoteFXGraphics ) ,  "Win32_PerfRawData_Counters_RemoteFXGraphics" }
        ,  { typeof ( Win32PerfFormattedDataCountersRemoteFXNetwork ) ,  "Win32_PerfFormattedData_Counters_RemoteFXNetwork" }
        ,  { typeof ( Win32PerfRawDataCountersRemoteFXNetwork ) ,  "Win32_PerfRawData_Counters_RemoteFXNetwork" }
        ,  { typeof ( Win32PerfFormattedDataCountersSMBClientShares ) ,  "Win32_PerfFormattedData_Counters_SMBClientShares" }
        ,  { typeof ( Win32PerfRawDataCountersSMBClientShares ) ,  "Win32_PerfRawData_Counters_SMBClientShares" }
        ,  { typeof ( Win32PerfFormattedDataCountersSMBDirectConnection ) ,  "Win32_PerfFormattedData_Counters_SMBDirectConnection" }
        ,  { typeof ( Win32PerfRawDataCountersSMBDirectConnection ) ,  "Win32_PerfRawData_Counters_SMBDirectConnection" }
        ,  { typeof ( Win32PerfFormattedDataCountersSMBServer ) ,  "Win32_PerfFormattedData_Counters_SMBServer" }
        ,  { typeof ( Win32PerfRawDataCountersSMBServer ) ,  "Win32_PerfRawData_Counters_SMBServer" }
        ,  { typeof ( Win32PerfFormattedDataCountersSMBServerSessions ) ,  "Win32_PerfFormattedData_Counters_SMBServerSessions" }
        ,  { typeof ( Win32PerfRawDataCountersSMBServerSessions ) ,  "Win32_PerfRawData_Counters_SMBServerSessions" }
        ,  { typeof ( Win32PerfFormattedDataCountersSMBServerShares ) ,  "Win32_PerfFormattedData_Counters_SMBServerShares" }
        ,  { typeof ( Win32PerfRawDataCountersSMBServerShares ) ,  "Win32_PerfRawData_Counters_SMBServerShares" }
        ,  { typeof ( Win32PerfFormattedDataCountersStorageQoSFilterFlow ) ,  "Win32_PerfFormattedData_Counters_StorageQoSFilterFlow" }
        ,  { typeof ( Win32PerfRawDataCountersStorageQoSFilterFlow ) ,  "Win32_PerfRawData_Counters_StorageQoSFilterFlow" }
        ,  { typeof ( Win32PerfFormattedDataCountersStorageQoSFilterVolume ) ,  "Win32_PerfFormattedData_Counters_StorageQoSFilterVolume" }
        ,  { typeof ( Win32PerfRawDataCountersStorageQoSFilterVolume ) ,  "Win32_PerfRawData_Counters_StorageQoSFilterVolume" }
        ,  { typeof ( Win32PerfFormattedDataCountersStorageSpacesDrt ) ,  "Win32_PerfFormattedData_Counters_StorageSpacesDrt" }
        ,  { typeof ( Win32PerfRawDataCountersStorageSpacesDrt ) ,  "Win32_PerfRawData_Counters_StorageSpacesDrt" }
        ,  { typeof ( Win32PerfFormattedDataCountersStorageSpacesTier ) ,  "Win32_PerfFormattedData_Counters_StorageSpacesTier" }
        ,  { typeof ( Win32PerfRawDataCountersStorageSpacesTier ) ,  "Win32_PerfRawData_Counters_StorageSpacesTier" }
        ,  { typeof ( Win32PerfFormattedDataCountersStorageSpacesVirtualDisk ) ,  "Win32_PerfFormattedData_Counters_StorageSpacesVirtualDisk" }
        ,  { typeof ( Win32PerfRawDataCountersStorageSpacesVirtualDisk ) ,  "Win32_PerfRawData_Counters_StorageSpacesVirtualDisk" }
        ,  { typeof ( Win32PerfFormattedDataCountersStorageSpacesWriteCache ) ,  "Win32_PerfFormattedData_Counters_StorageSpacesWriteCache" }
        ,  { typeof ( Win32PerfRawDataCountersStorageSpacesWriteCache ) ,  "Win32_PerfRawData_Counters_StorageSpacesWriteCache" }
        ,  { typeof ( Win32PerfFormattedDataCountersSynchronization ) ,  "Win32_PerfFormattedData_Counters_Synchronization" }
        ,  { typeof ( Win32PerfRawDataCountersSynchronization ) ,  "Win32_PerfRawData_Counters_Synchronization" }
        ,  { typeof ( Win32PerfFormattedDataCountersSynchronizationNuma ) ,  "Win32_PerfFormattedData_Counters_SynchronizationNuma" }
        ,  { typeof ( Win32PerfRawDataCountersSynchronizationNuma ) ,  "Win32_PerfRawData_Counters_SynchronizationNuma" }
        ,  { typeof ( Win32PerfFormattedDataCountersTeredoClient ) ,  "Win32_PerfFormattedData_Counters_TeredoClient" }
        ,  { typeof ( Win32PerfRawDataCountersTeredoClient ) ,  "Win32_PerfRawData_Counters_TeredoClient" }
        ,  { typeof ( Win32PerfFormattedDataCountersTeredoRelay ) ,  "Win32_PerfFormattedData_Counters_TeredoRelay" }
        ,  { typeof ( Win32PerfRawDataCountersTeredoRelay ) ,  "Win32_PerfRawData_Counters_TeredoRelay" }
        ,  { typeof ( Win32PerfFormattedDataCountersTeredoServer ) ,  "Win32_PerfFormattedData_Counters_TeredoServer" }
        ,  { typeof ( Win32PerfRawDataCountersTeredoServer ) ,  "Win32_PerfRawData_Counters_TeredoServer" }
        ,  { typeof ( Win32PerfFormattedDataCountersThermalZoneInformation ) ,  "Win32_PerfFormattedData_Counters_ThermalZoneInformation" }
        ,  { typeof ( Win32PerfRawDataCountersThermalZoneInformation ) ,  "Win32_PerfRawData_Counters_ThermalZoneInformation" }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPPortAverageInboundNetworkTraffic ) ,  "Win32_PerfFormattedData_Counters_VFPPortAverageInboundNetworkTraffic" }
        ,  { typeof ( Win32PerfRawDataCountersVFPPortAverageInboundNetworkTraffic ) ,  "Win32_PerfRawData_Counters_VFPPortAverageInboundNetworkTraffic" }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPPortAverageOutboundNetworkTraffic ) ,  "Win32_PerfFormattedData_Counters_VFPPortAverageOutboundNetworkTraffic" }
        ,  { typeof ( Win32PerfRawDataCountersVFPPortAverageOutboundNetworkTraffic ) ,  "Win32_PerfRawData_Counters_VFPPortAverageOutboundNetworkTraffic" }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPPortTotalInboundDroppedNetworkPackets ) ,  "Win32_PerfFormattedData_Counters_VFPPortTotalInboundDroppedNetworkPackets" }
        ,  { typeof ( Win32PerfRawDataCountersVFPPortTotalInboundDroppedNetworkPackets ) ,  "Win32_PerfRawData_Counters_VFPPortTotalInboundDroppedNetworkPackets" }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPPortTotalInboundNetworkTraffic ) ,  "Win32_PerfFormattedData_Counters_VFPPortTotalInboundNetworkTraffic" }
        ,  { typeof ( Win32PerfRawDataCountersVFPPortTotalInboundNetworkTraffic ) ,  "Win32_PerfRawData_Counters_VFPPortTotalInboundNetworkTraffic" }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPPortTotalOutboundDroppedNetworkPackets ) ,  "Win32_PerfFormattedData_Counters_VFPPortTotalOutboundDroppedNetworkPackets" }
        ,  { typeof ( Win32PerfRawDataCountersVFPPortTotalOutboundDroppedNetworkPackets ) ,  "Win32_PerfRawData_Counters_VFPPortTotalOutboundDroppedNetworkPackets" }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPPortTotalOutboundNetworkTraffic ) ,  "Win32_PerfFormattedData_Counters_VFPPortTotalOutboundNetworkTraffic" }
        ,  { typeof ( Win32PerfRawDataCountersVFPPortTotalOutboundNetworkTraffic ) ,  "Win32_PerfRawData_Counters_VFPPortTotalOutboundNetworkTraffic" }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPQoSQueueAverageInboundNetworkTraffic ) ,  "Win32_PerfFormattedData_Counters_VFPQoSQueueAverageInboundNetworkTraffic" }
        ,  { typeof ( Win32PerfRawDataCountersVFPQoSQueueAverageInboundNetworkTraffic ) ,  "Win32_PerfRawData_Counters_VFPQoSQueueAverageInboundNetworkTraffic" }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPQoSQueueAverageOutboundNetworkTraffic ) ,  "Win32_PerfFormattedData_Counters_VFPQoSQueueAverageOutboundNetworkTraffic" }
        ,  { typeof ( Win32PerfRawDataCountersVFPQoSQueueAverageOutboundNetworkTraffic ) ,  "Win32_PerfRawData_Counters_VFPQoSQueueAverageOutboundNetworkTraffic" }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPQoSQueueTotalInboundNetworkTraffic ) ,  "Win32_PerfFormattedData_Counters_VFPQoSQueueTotalInboundNetworkTraffic" }
        ,  { typeof ( Win32PerfRawDataCountersVFPQoSQueueTotalInboundNetworkTraffic ) ,  "Win32_PerfRawData_Counters_VFPQoSQueueTotalInboundNetworkTraffic" }
        ,  { typeof ( Win32PerfFormattedDataCountersVFPQoSQueueTotalOutboundNetworkTraffic ) ,  "Win32_PerfFormattedData_Counters_VFPQoSQueueTotalOutboundNetworkTraffic" }
        ,  { typeof ( Win32PerfRawDataCountersVFPQoSQueueTotalOutboundNetworkTraffic ) ,  "Win32_PerfRawData_Counters_VFPQoSQueueTotalOutboundNetworkTraffic" }
        ,  { typeof ( Win32PerfFormattedDataCountersWFP ) ,  "Win32_PerfFormattedData_Counters_WFP" }
        ,  { typeof ( Win32PerfRawDataCountersWFP ) ,  "Win32_PerfRawData_Counters_WFP" }
        ,  { typeof ( Win32PerfFormattedDataCountersWFPClassify ) ,  "Win32_PerfFormattedData_Counters_WFPClassify" }
        ,  { typeof ( Win32PerfRawDataCountersWFPClassify ) ,  "Win32_PerfRawData_Counters_WFPClassify" }
        ,  { typeof ( Win32PerfFormattedDataCountersWFPReauthorization ) ,  "Win32_PerfFormattedData_Counters_WFPReauthorization" }
        ,  { typeof ( Win32PerfRawDataCountersWFPReauthorization ) ,  "Win32_PerfRawData_Counters_WFPReauthorization" }
        ,  { typeof ( Win32PerfFormattedDataCountersWFPv4 ) ,  "Win32_PerfFormattedData_Counters_WFPv4" }
        ,  { typeof ( Win32PerfRawDataCountersWFPv4 ) ,  "Win32_PerfRawData_Counters_WFPv4" }
        ,  { typeof ( Win32PerfFormattedDataCountersWFPv6 ) ,  "Win32_PerfFormattedData_Counters_WFPv6" }
        ,  { typeof ( Win32PerfRawDataCountersWFPv6 ) ,  "Win32_PerfRawData_Counters_WFPv6" }
        ,  { typeof ( Win32PerfFormattedDataCountersWSManQuotaStatistics ) ,  "Win32_PerfFormattedData_Counters_WSManQuotaStatistics" }
        ,  { typeof ( Win32PerfRawDataCountersWSManQuotaStatistics ) ,  "Win32_PerfRawData_Counters_WSManQuotaStatistics" }
        ,  { typeof ( Win32PerfFormattedDataCountersXHCICommonBuffer ) ,  "Win32_PerfFormattedData_Counters_XHCICommonBuffer" }
        ,  { typeof ( Win32PerfRawDataCountersXHCICommonBuffer ) ,  "Win32_PerfRawData_Counters_XHCICommonBuffer" }
        ,  { typeof ( Win32PerfFormattedDataCountersXHCIInterrupter ) ,  "Win32_PerfFormattedData_Counters_XHCIInterrupter" }
        ,  { typeof ( Win32PerfRawDataCountersXHCIInterrupter ) ,  "Win32_PerfRawData_Counters_XHCIInterrupter" }
        ,  { typeof ( Win32PerfFormattedDataCountersXHCITransferRing ) ,  "Win32_PerfFormattedData_Counters_XHCITransferRing" }
        ,  { typeof ( Win32PerfRawDataCountersXHCITransferRing ) ,  "Win32_PerfRawData_Counters_XHCITransferRing" }
        ,  { typeof ( Win32PerfFormattedDataDdmCounterProviderRAS ) ,  "Win32_PerfFormattedData_DdmCounterProvider_RAS" }
        ,  { typeof ( Win32PerfRawDataDdmCounterProviderRAS ) ,  "Win32_PerfRawData_DdmCounterProvider_RAS" }
        ,  { typeof ( Win32PerfFormattedDataDistributedRoutingTablePerfDistributedRoutingTable ) ,  "Win32_PerfFormattedData_DistributedRoutingTablePerf_DistributedRoutingTable" }
        ,  { typeof ( Win32PerfRawDataDistributedRoutingTablePerfDistributedRoutingTable ) ,  "Win32_PerfRawData_DistributedRoutingTablePerf_DistributedRoutingTable" }
        ,  { typeof ( Win32PerfFormattedDataESENTDatabase ) ,  "Win32_PerfFormattedData_ESENT_Database" }
        ,  { typeof ( Win32PerfRawDataESENTDatabase ) ,  "Win32_PerfRawData_ESENT_Database" }
        ,  { typeof ( Win32PerfFormattedDataESENTDatabaseDatabases ) ,  "Win32_PerfFormattedData_ESENT_DatabaseDatabases" }
        ,  { typeof ( Win32PerfRawDataESENTDatabaseDatabases ) ,  "Win32_PerfRawData_ESENT_DatabaseDatabases" }
        ,  { typeof ( Win32PerfFormattedDataESENTDatabaseInstances ) ,  "Win32_PerfFormattedData_ESENT_DatabaseInstances" }
        ,  { typeof ( Win32PerfRawDataESENTDatabaseInstances ) ,  "Win32_PerfRawData_ESENT_DatabaseInstances" }
        ,  { typeof ( Win32PerfFormattedDataESENTDatabaseTableClasses ) ,  "Win32_PerfFormattedData_ESENT_DatabaseTableClasses" }
        ,  { typeof ( Win32PerfRawDataESENTDatabaseTableClasses ) ,  "Win32_PerfRawData_ESENT_DatabaseTableClasses" }
        ,  { typeof ( Win32PerfFormattedDataEthernetPerfProviderHyperVLegacyNetworkAdapter ) ,  "Win32_PerfFormattedData_EthernetPerfProvider_HyperVLegacyNetworkAdapter" }
        ,  { typeof ( Win32PerfRawDataEthernetPerfProviderHyperVLegacyNetworkAdapter ) ,  "Win32_PerfRawData_EthernetPerfProvider_HyperVLegacyNetworkAdapter" }
        ,  { typeof ( Win32PerfFormattedDataFaxServiceFaxService ) ,  "Win32_PerfFormattedData_FaxService_FaxService" }
        ,  { typeof ( Win32PerfRawDataFaxServiceFaxService ) ,  "Win32_PerfRawData_FaxService_FaxService" }
        ,  { typeof ( Win32PerfFormattedDataGmoPerfProviderHyperVVMSaveSnapshotandRestore ) ,  "Win32_PerfFormattedData_GmoPerfProvider_HyperVVMSaveSnapshotandRestore" }
        ,  { typeof ( Win32PerfRawDataGmoPerfProviderHyperVVMSaveSnapshotandRestore ) ,  "Win32_PerfRawData_GmoPerfProvider_HyperVVMSaveSnapshotandRestore" }
        ,  { typeof ( Win32PerfFormattedDataGPUPerformanceCountersGPUAdapterMemory ) ,  "Win32_PerfFormattedData_GPUPerformanceCounters_GPUAdapterMemory" }
        ,  { typeof ( Win32PerfRawDataGPUPerformanceCountersGPUAdapterMemory ) ,  "Win32_PerfRawData_GPUPerformanceCounters_GPUAdapterMemory" }
        ,  { typeof ( Win32PerfFormattedDataGPUPerformanceCountersGPUEngine ) ,  "Win32_PerfFormattedData_GPUPerformanceCounters_GPUEngine" }
        ,  { typeof ( Win32PerfRawDataGPUPerformanceCountersGPUEngine ) ,  "Win32_PerfRawData_GPUPerformanceCounters_GPUEngine" }
        ,  { typeof ( Win32PerfFormattedDataGPUPerformanceCountersGPULocalAdapterMemory ) ,  "Win32_PerfFormattedData_GPUPerformanceCounters_GPULocalAdapterMemory" }
        ,  { typeof ( Win32PerfRawDataGPUPerformanceCountersGPULocalAdapterMemory ) ,  "Win32_PerfRawData_GPUPerformanceCounters_GPULocalAdapterMemory" }
        ,  { typeof ( Win32PerfFormattedDataGPUPerformanceCountersGPUNonLocalAdapterMemory ) ,  "Win32_PerfFormattedData_GPUPerformanceCounters_GPUNonLocalAdapterMemory" }
        ,  { typeof ( Win32PerfRawDataGPUPerformanceCountersGPUNonLocalAdapterMemory ) ,  "Win32_PerfRawData_GPUPerformanceCounters_GPUNonLocalAdapterMemory" }
        ,  { typeof ( Win32PerfFormattedDataGPUPerformanceCountersGPUProcessMemory ) ,  "Win32_PerfFormattedData_GPUPerformanceCounters_GPUProcessMemory" }
        ,  { typeof ( Win32PerfRawDataGPUPerformanceCountersGPUProcessMemory ) ,  "Win32_PerfRawData_GPUPerformanceCounters_GPUProcessMemory" }
        ,  { typeof ( Win32PerfFormattedDataHvStatsHyperVHypervisor ) ,  "Win32_PerfFormattedData_HvStats_HyperVHypervisor" }
        ,  { typeof ( Win32PerfRawDataHvStatsHyperVHypervisor ) ,  "Win32_PerfRawData_HvStats_HyperVHypervisor" }
        ,  { typeof ( Win32PerfFormattedDataHvStatsHyperVHypervisorLogicalProcessor ) ,  "Win32_PerfFormattedData_HvStats_HyperVHypervisorLogicalProcessor" }
        ,  { typeof ( Win32PerfRawDataHvStatsHyperVHypervisorLogicalProcessor ) ,  "Win32_PerfRawData_HvStats_HyperVHypervisorLogicalProcessor" }
        ,  { typeof ( Win32PerfFormattedDataHvStatsHyperVHypervisorPartition ) ,  "Win32_PerfFormattedData_HvStats_HyperVHypervisorPartition" }
        ,  { typeof ( Win32PerfRawDataHvStatsHyperVHypervisorPartition ) ,  "Win32_PerfRawData_HvStats_HyperVHypervisorPartition" }
        ,  { typeof ( Win32PerfFormattedDataHvStatsHyperVHypervisorRootPartition ) ,  "Win32_PerfFormattedData_HvStats_HyperVHypervisorRootPartition" }
        ,  { typeof ( Win32PerfRawDataHvStatsHyperVHypervisorRootPartition ) ,  "Win32_PerfRawData_HvStats_HyperVHypervisorRootPartition" }
        ,  { typeof ( Win32PerfFormattedDataHvStatsHyperVHypervisorRootVirtualProcessor ) ,  "Win32_PerfFormattedData_HvStats_HyperVHypervisorRootVirtualProcessor" }
        ,  { typeof ( Win32PerfRawDataHvStatsHyperVHypervisorRootVirtualProcessor ) ,  "Win32_PerfRawData_HvStats_HyperVHypervisorRootVirtualProcessor" }
        ,  { typeof ( Win32PerfFormattedDataHvStatsHyperVHypervisorVirtualProcessor ) ,  "Win32_PerfFormattedData_HvStats_HyperVHypervisorVirtualProcessor" }
        ,  { typeof ( Win32PerfRawDataHvStatsHyperVHypervisorVirtualProcessor ) ,  "Win32_PerfRawData_HvStats_HyperVHypervisorVirtualProcessor" }
        ,  { typeof ( Win32PerfFormattedDataHyperVReplicaStatsHyperVReplicaVM ) ,  "Win32_PerfFormattedData_HyperVReplicaStats_HyperVReplicaVM" }
        ,  { typeof ( Win32PerfRawDataHyperVReplicaStatsHyperVReplicaVM ) ,  "Win32_PerfRawData_HyperVReplicaStats_HyperVReplicaVM" }
        ,  { typeof ( Win32PerfFormattedDataHyperVStorageStatsHyperVConfiguration ) ,  "Win32_PerfFormattedData_HyperVStorageStats_HyperVConfiguration" }
        ,  { typeof ( Win32PerfRawDataHyperVStorageStatsHyperVConfiguration ) ,  "Win32_PerfRawData_HyperVStorageStats_HyperVConfiguration" }
        ,  { typeof ( Win32PerfFormattedDataIdePerfProviderHyperVVirtualIDEControllerEmulated ) ,  "Win32_PerfFormattedData_IdePerfProvider_HyperVVirtualIDEControllerEmulated" }
        ,  { typeof ( Win32PerfRawDataIdePerfProviderHyperVVirtualIDEControllerEmulated ) ,  "Win32_PerfRawData_IdePerfProvider_HyperVVirtualIDEControllerEmulated" }
        ,  { typeof ( Win32PerfFormattedDataIntelStorageCountersIntelStorageCounters ) ,  "Win32_PerfFormattedData_IntelStorageCounters_IntelStorageCounters" }
        ,  { typeof ( Win32PerfRawDataIntelStorageCountersIntelStorageCounters ) ,  "Win32_PerfRawData_IntelStorageCounters_IntelStorageCounters" }
        ,  { typeof ( Win32PerfFormattedDataLmPerfProviderHyperVVMLiveMigration ) ,  "Win32_PerfFormattedData_LmPerfProvider_HyperVVMLiveMigration" }
        ,  { typeof ( Win32PerfRawDataLmPerfProviderHyperVVMLiveMigration ) ,  "Win32_PerfRawData_LmPerfProvider_HyperVVMLiveMigration" }
        ,  { typeof ( Win32PerfFormattedDataLocalSessionManagerTerminalServices ) ,  "Win32_PerfFormattedData_LocalSessionManager_TerminalServices" }
        ,  { typeof ( Win32PerfRawDataLocalSessionManagerTerminalServices ) ,  "Win32_PerfRawData_LocalSessionManager_TerminalServices" }
        ,  { typeof ( Win32PerfFormattedDataLsaSecurityPerProcessStatistics ) ,  "Win32_PerfFormattedData_Lsa_SecurityPerProcessStatistics" }
        ,  { typeof ( Win32PerfRawDataLsaSecurityPerProcessStatistics ) ,  "Win32_PerfRawData_Lsa_SecurityPerProcessStatistics" }
        ,  { typeof ( Win32PerfFormattedDataLsaSecuritySystemWideStatistics ) ,  "Win32_PerfFormattedData_Lsa_SecuritySystemWideStatistics" }
        ,  { typeof ( Win32PerfRawDataLsaSecuritySystemWideStatistics ) ,  "Win32_PerfRawData_Lsa_SecuritySystemWideStatistics" }
        ,  { typeof ( Win32PerfFormattedDataLSMUserInputDelayperProcess ) ,  "Win32_PerfFormattedData_LSM_UserInputDelayperProcess" }
        ,  { typeof ( Win32PerfRawDataLSMUserInputDelayperProcess ) ,  "Win32_PerfRawData_LSM_UserInputDelayperProcess" }
        ,  { typeof ( Win32PerfFormattedDataLSMUserInputDelayperSession ) ,  "Win32_PerfFormattedData_LSM_UserInputDelayperSession" }
        ,  { typeof ( Win32PerfRawDataLSMUserInputDelayperSession ) ,  "Win32_PerfRawData_LSM_UserInputDelayperSession" }
        ,  { typeof ( Win32PerfFormattedDataMicrosoftWindowsBitLockerDriverCountersProviderBitLocker ) ,  "Win32_PerfFormattedData_MicrosoftWindowsBitLockerDriverCountersProvider_BitLocker" }
        ,  { typeof ( Win32PerfRawDataMicrosoftWindowsBitLockerDriverCountersProviderBitLocker ) ,  "Win32_PerfRawData_MicrosoftWindowsBitLockerDriverCountersProvider_BitLocker" }
        ,  { typeof ( Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice ) ,  "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMDevice" }
        ,  { typeof ( Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMDevice ) ,  "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMDevice" }
        ,  { typeof ( Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMTransportChannel ) ,  "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMTransportChannel" }
        ,  { typeof ( Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMTransportChannel ) ,  "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMTransportChannel" }
        ,  { typeof ( Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP ) ,  "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSP" }
        ,  { typeof ( Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP ) ,  "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSP" }
        ,  { typeof ( Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMDevice ) ,  "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSPVMDevice" }
        ,  { typeof ( Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMDevice ) ,  "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSPVMDevice" }
        ,  { typeof ( Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMTransportChannel ) ,  "Win32_PerfFormattedData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSPVMTransportChannel" }
        ,  { typeof ( Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMTransportChannel ) ,  "Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsp_RemoteFXSynth3DVSPVMTransportChannel" }
        ,  { typeof ( Win32PerfFormattedDataMicrosoftWindowsW32TimePerfWindowsTimeService ) ,  "Win32_PerfFormattedData_MicrosoftWindowsW32TimePerf_WindowsTimeService" }
        ,  { typeof ( Win32PerfRawDataMicrosoftWindowsW32TimePerfWindowsTimeService ) ,  "Win32_PerfRawData_MicrosoftWindowsW32TimePerf_WindowsTimeService" }
        ,  { typeof ( Win32PerfFormattedDataMmPerfProviderHyperVVMWorkerProcessMemoryManager ) ,  "Win32_PerfFormattedData_MmPerfProvider_HyperVVMWorkerProcessMemoryManager" }
        ,  { typeof ( Win32PerfRawDataMmPerfProviderHyperVVMWorkerProcessMemoryManager ) ,  "Win32_PerfRawData_MmPerfProvider_HyperVVMWorkerProcessMemoryManager" }
        ,  { typeof ( Win32PerfFormattedDataMSDTCDistributedTransactionCoordinator ) ,  "Win32_PerfFormattedData_MSDTC_DistributedTransactionCoordinator" }
        ,  { typeof ( Win32PerfRawDataMSDTCDistributedTransactionCoordinator ) ,  "Win32_PerfRawData_MSDTC_DistributedTransactionCoordinator" }
        ,  { typeof ( Win32PerfFormattedDataMSDTCBridge4000MSDTCBridge4000 ) ,  "Win32_PerfFormattedData_MSDTCBridge4000_MSDTCBridge4000" }
        ,  { typeof ( Win32PerfRawDataMSDTCBridge4000MSDTCBridge4000 ) ,  "Win32_PerfRawData_MSDTCBridge4000_MSDTCBridge4000" }
        ,  { typeof ( Win32PerfFormattedDataNETCLRDataNETCLRData ) ,  "Win32_PerfFormattedData_NETCLRData_NETCLRData" }
        ,  { typeof ( Win32PerfRawDataNETCLRDataNETCLRData ) ,  "Win32_PerfRawData_NETCLRData_NETCLRData" }
        ,  { typeof ( Win32PerfFormattedDataNETCLRNetworking4000NETCLRNetworking4000 ) ,  "Win32_PerfFormattedData_NETCLRNetworking4000_NETCLRNetworking4000" }
        ,  { typeof ( Win32PerfRawDataNETCLRNetworking4000NETCLRNetworking4000 ) ,  "Win32_PerfRawData_NETCLRNetworking4000_NETCLRNetworking4000" }
        ,  { typeof ( Win32PerfFormattedDataNETCLRNetworkingNETCLRNetworking ) ,  "Win32_PerfFormattedData_NETCLRNetworking_NETCLRNetworking" }
        ,  { typeof ( Win32PerfRawDataNETCLRNetworkingNETCLRNetworking ) ,  "Win32_PerfRawData_NETCLRNetworking_NETCLRNetworking" }
        ,  { typeof ( Win32PerfFormattedDataNETDataProviderforOracleNETDataProviderforOracle ) ,  "Win32_PerfFormattedData_NETDataProviderforOracle_NETDataProviderforOracle" }
        ,  { typeof ( Win32PerfRawDataNETDataProviderforOracleNETDataProviderforOracle ) ,  "Win32_PerfRawData_NETDataProviderforOracle_NETDataProviderforOracle" }
        ,  { typeof ( Win32PerfFormattedDataNETDataProviderforSqlServerNETDataProviderforSqlServer ) ,  "Win32_PerfFormattedData_NETDataProviderforSqlServer_NETDataProviderforSqlServer" }
        ,  { typeof ( Win32PerfRawDataNETDataProviderforSqlServerNETDataProviderforSqlServer ) ,  "Win32_PerfRawData_NETDataProviderforSqlServer_NETDataProviderforSqlServer" }
        ,  { typeof ( Win32PerfFormattedDataNETFrameworkNETCLRExceptions ) ,  "Win32_PerfFormattedData_NETFramework_NETCLRExceptions" }
        ,  { typeof ( Win32PerfRawDataNETFrameworkNETCLRExceptions ) ,  "Win32_PerfRawData_NETFramework_NETCLRExceptions" }
        ,  { typeof ( Win32PerfFormattedDataNETFrameworkNETCLRInterop ) ,  "Win32_PerfFormattedData_NETFramework_NETCLRInterop" }
        ,  { typeof ( Win32PerfRawDataNETFrameworkNETCLRInterop ) ,  "Win32_PerfRawData_NETFramework_NETCLRInterop" }
        ,  { typeof ( Win32PerfFormattedDataNETFrameworkNETCLRJit ) ,  "Win32_PerfFormattedData_NETFramework_NETCLRJit" }
        ,  { typeof ( Win32PerfRawDataNETFrameworkNETCLRJit ) ,  "Win32_PerfRawData_NETFramework_NETCLRJit" }
        ,  { typeof ( Win32PerfFormattedDataNETFrameworkNETCLRLoading ) ,  "Win32_PerfFormattedData_NETFramework_NETCLRLoading" }
        ,  { typeof ( Win32PerfRawDataNETFrameworkNETCLRLoading ) ,  "Win32_PerfRawData_NETFramework_NETCLRLoading" }
        ,  { typeof ( Win32PerfFormattedDataNETFrameworkNETCLRLocksAndThreads ) ,  "Win32_PerfFormattedData_NETFramework_NETCLRLocksAndThreads" }
        ,  { typeof ( Win32PerfRawDataNETFrameworkNETCLRLocksAndThreads ) ,  "Win32_PerfRawData_NETFramework_NETCLRLocksAndThreads" }
        ,  { typeof ( Win32PerfFormattedDataNETFrameworkNETCLRMemory ) ,  "Win32_PerfFormattedData_NETFramework_NETCLRMemory" }
        ,  { typeof ( Win32PerfRawDataNETFrameworkNETCLRMemory ) ,  "Win32_PerfRawData_NETFramework_NETCLRMemory" }
        ,  { typeof ( Win32PerfFormattedDataNETFrameworkNETCLRRemoting ) ,  "Win32_PerfFormattedData_NETFramework_NETCLRRemoting" }
        ,  { typeof ( Win32PerfRawDataNETFrameworkNETCLRRemoting ) ,  "Win32_PerfRawData_NETFramework_NETCLRRemoting" }
        ,  { typeof ( Win32PerfFormattedDataNETFrameworkNETCLRSecurity ) ,  "Win32_PerfFormattedData_NETFramework_NETCLRSecurity" }
        ,  { typeof ( Win32PerfRawDataNETFrameworkNETCLRSecurity ) ,  "Win32_PerfRawData_NETFramework_NETCLRSecurity" }
        ,  { typeof ( Win32PerfFormattedDataNETMemoryCache40NETMemoryCache40 ) ,  "Win32_PerfFormattedData_NETMemoryCache40_NETMemoryCache40" }
        ,  { typeof ( Win32PerfRawDataNETMemoryCache40NETMemoryCache40 ) ,  "Win32_PerfRawData_NETMemoryCache40_NETMemoryCache40" }
        ,  { typeof ( Win32PerfFormattedDataNvspNicDropReasonsStatsHyperVVirtualNetworkAdapterDropReasons ) ,  "Win32_PerfFormattedData_NvspNicDropReasonsStats_HyperVVirtualNetworkAdapterDropReasons" }
        ,  { typeof ( Win32PerfRawDataNvspNicDropReasonsStatsHyperVVirtualNetworkAdapterDropReasons ) ,  "Win32_PerfRawData_NvspNicDropReasonsStats_HyperVVirtualNetworkAdapterDropReasons" }
        ,  { typeof ( Win32PerfFormattedDataNvspNicStatsHyperVVirtualNetworkAdapter ) ,  "Win32_PerfFormattedData_NvspNicStats_HyperVVirtualNetworkAdapter" }
        ,  { typeof ( Win32PerfRawDataNvspNicStatsHyperVVirtualNetworkAdapter ) ,  "Win32_PerfRawData_NvspNicStats_HyperVVirtualNetworkAdapter" }
        ,  { typeof ( Win32PerfFormattedDataNvspNicVRSSStatsHyperVVirtualNetworkAdapterVRSS ) ,  "Win32_PerfFormattedData_NvspNicVRSSStats_HyperVVirtualNetworkAdapterVRSS" }
        ,  { typeof ( Win32PerfRawDataNvspNicVRSSStatsHyperVVirtualNetworkAdapterVRSS ) ,  "Win32_PerfRawData_NvspNicVRSSStats_HyperVVirtualNetworkAdapterVRSS" }
        ,  { typeof ( Win32PerfFormattedDataNvspPortStatsHyperVVirtualSwitchPort ) ,  "Win32_PerfFormattedData_NvspPortStats_HyperVVirtualSwitchPort" }
        ,  { typeof ( Win32PerfRawDataNvspPortStatsHyperVVirtualSwitchPort ) ,  "Win32_PerfRawData_NvspPortStats_HyperVVirtualSwitchPort" }
        ,  { typeof ( Win32PerfFormattedDataNvspSwitchProcStatsHyperVVirtualSwitchProcessor ) ,  "Win32_PerfFormattedData_NvspSwitchProcStats_HyperVVirtualSwitchProcessor" }
        ,  { typeof ( Win32PerfRawDataNvspSwitchProcStatsHyperVVirtualSwitchProcessor ) ,  "Win32_PerfRawData_NvspSwitchProcStats_HyperVVirtualSwitchProcessor" }
        ,  { typeof ( Win32PerfFormattedDataNvspSwitchStatsHyperVVirtualSwitch ) ,  "Win32_PerfFormattedData_NvspSwitchStats_HyperVVirtualSwitch" }
        ,  { typeof ( Win32PerfRawDataNvspSwitchStatsHyperVVirtualSwitch ) ,  "Win32_PerfRawData_NvspSwitchStats_HyperVVirtualSwitch" }
        ,  { typeof ( Win32PerfFormattedDataOfflineFilesClientSideCaching ) ,  "Win32_PerfFormattedData_OfflineFiles_ClientSideCaching" }
        ,  { typeof ( Win32PerfRawDataOfflineFilesClientSideCaching ) ,  "Win32_PerfRawData_OfflineFiles_ClientSideCaching" }
        ,  { typeof ( Win32PerfFormattedDataOfflineFilesOfflineFiles ) ,  "Win32_PerfFormattedData_OfflineFiles_OfflineFiles" }
        ,  { typeof ( Win32PerfRawDataOfflineFilesOfflineFiles ) ,  "Win32_PerfRawData_OfflineFiles_OfflineFiles" }
        ,  { typeof ( Win32PerfFormattedDataPeerDistSvcBranchCache ) ,  "Win32_PerfFormattedData_PeerDistSvc_BranchCache" }
        ,  { typeof ( Win32PerfRawDataPeerDistSvcBranchCache ) ,  "Win32_PerfRawData_PeerDistSvc_BranchCache" }
        ,  { typeof ( Win32PerfFormattedDataPeerNameResolutionProtocolPerfPeerNameResolutionProtocol ) ,  "Win32_PerfFormattedData_PeerNameResolutionProtocolPerf_PeerNameResolutionProtocol" }
        ,  { typeof ( Win32PerfRawDataPeerNameResolutionProtocolPerfPeerNameResolutionProtocol ) ,  "Win32_PerfRawData_PeerNameResolutionProtocolPerf_PeerNameResolutionProtocol" }
        ,  { typeof ( Win32PerfFormattedDataPerfDiskLogicalDisk ) ,  "Win32_PerfFormattedData_PerfDisk_LogicalDisk" }
        ,  { typeof ( Win32PerfRawDataPerfDiskLogicalDisk ) ,  "Win32_PerfRawData_PerfDisk_LogicalDisk" }
        ,  { typeof ( Win32PerfFormattedDataPerfDiskPhysicalDisk ) ,  "Win32_PerfFormattedData_PerfDisk_PhysicalDisk" }
        ,  { typeof ( Win32PerfRawDataPerfDiskPhysicalDisk ) ,  "Win32_PerfRawData_PerfDisk_PhysicalDisk" }
        ,  { typeof ( Win32PerfFormattedDataPerfNetBrowser ) ,  "Win32_PerfFormattedData_PerfNet_Browser" }
        ,  { typeof ( Win32PerfRawDataPerfNetBrowser ) ,  "Win32_PerfRawData_PerfNet_Browser" }
        ,  { typeof ( Win32PerfFormattedDataPerfNetRedirector ) ,  "Win32_PerfFormattedData_PerfNet_Redirector" }
        ,  { typeof ( Win32PerfRawDataPerfNetRedirector ) ,  "Win32_PerfRawData_PerfNet_Redirector" }
        ,  { typeof ( Win32PerfFormattedDataPerfNetServer ) ,  "Win32_PerfFormattedData_PerfNet_Server" }
        ,  { typeof ( Win32PerfRawDataPerfNetServer ) ,  "Win32_PerfRawData_PerfNet_Server" }
        ,  { typeof ( Win32PerfFormattedDataPerfNetServerWorkQueues ) ,  "Win32_PerfFormattedData_PerfNet_ServerWorkQueues" }
        ,  { typeof ( Win32PerfRawDataPerfNetServerWorkQueues ) ,  "Win32_PerfRawData_PerfNet_ServerWorkQueues" }
        ,  { typeof ( Win32PerfFormattedDataPerfOSCache ) ,  "Win32_PerfFormattedData_PerfOS_Cache" }
        ,  { typeof ( Win32PerfRawDataPerfOSCache ) ,  "Win32_PerfRawData_PerfOS_Cache" }
        ,  { typeof ( Win32PerfFormattedDataPerfOSMemory ) ,  "Win32_PerfFormattedData_PerfOS_Memory" }
        ,  { typeof ( Win32PerfRawDataPerfOSMemory ) ,  "Win32_PerfRawData_PerfOS_Memory" }
        ,  { typeof ( Win32PerfFormattedDataPerfOSNUMANodeMemory ) ,  "Win32_PerfFormattedData_PerfOS_NUMANodeMemory" }
        ,  { typeof ( Win32PerfRawDataPerfOSNUMANodeMemory ) ,  "Win32_PerfRawData_PerfOS_NUMANodeMemory" }
        ,  { typeof ( Win32PerfFormattedDataPerfOSObjects ) ,  "Win32_PerfFormattedData_PerfOS_Objects" }
        ,  { typeof ( Win32PerfRawDataPerfOSObjects ) ,  "Win32_PerfRawData_PerfOS_Objects" }
        ,  { typeof ( Win32PerfFormattedDataPerfOSPagingFile ) ,  "Win32_PerfFormattedData_PerfOS_PagingFile" }
        ,  { typeof ( Win32PerfRawDataPerfOSPagingFile ) ,  "Win32_PerfRawData_PerfOS_PagingFile" }
        ,  { typeof ( Win32PerfFormattedDataPerfOSProcessor ) ,  "Win32_PerfFormattedData_PerfOS_Processor" }
        ,  { typeof ( Win32PerfRawDataPerfOSProcessor ) ,  "Win32_PerfRawData_PerfOS_Processor" }
        ,  { typeof ( Win32PerfFormattedDataPerfOSSystem ) ,  "Win32_PerfFormattedData_PerfOS_System" }
        ,  { typeof ( Win32PerfRawDataPerfOSSystem ) ,  "Win32_PerfRawData_PerfOS_System" }
        ,  { typeof ( Win32PerfFormattedDataPerfProcJobObject ) ,  "Win32_PerfFormattedData_PerfProc_JobObject" }
        ,  { typeof ( Win32PerfRawDataPerfProcJobObject ) ,  "Win32_PerfRawData_PerfProc_JobObject" }
        ,  { typeof ( Win32PerfFormattedDataPerfProcJobObjectDetails ) ,  "Win32_PerfFormattedData_PerfProc_JobObjectDetails" }
        ,  { typeof ( Win32PerfRawDataPerfProcJobObjectDetails ) ,  "Win32_PerfRawData_PerfProc_JobObjectDetails" }
        ,  { typeof ( Win32PerfFormattedDataPerfProcProcess ) ,  "Win32_PerfFormattedData_PerfProc_Process" }
        ,  { typeof ( Win32PerfRawDataPerfProcProcess ) ,  "Win32_PerfRawData_PerfProc_Process" }
        ,  { typeof ( Win32PerfFormattedDataPerfProcThread ) ,  "Win32_PerfFormattedData_PerfProc_Thread" }
        ,  { typeof ( Win32PerfRawDataPerfProcThread ) ,  "Win32_PerfRawData_PerfProc_Thread" }
        ,  { typeof ( Win32PerfFormattedDataPowerMeterCounterEnergyMeter ) ,  "Win32_PerfFormattedData_PowerMeterCounter_EnergyMeter" }
        ,  { typeof ( Win32PerfRawDataPowerMeterCounterEnergyMeter ) ,  "Win32_PerfRawData_PowerMeterCounter_EnergyMeter" }
        ,  { typeof ( Win32PerfFormattedDataPowerMeterCounterPowerMeter ) ,  "Win32_PerfFormattedData_PowerMeterCounter_PowerMeter" }
        ,  { typeof ( Win32PerfRawDataPowerMeterCounterPowerMeter ) ,  "Win32_PerfRawData_PowerMeterCounter_PowerMeter" }
        ,  { typeof ( Win32PerfFormattedDataRdyboostReadyBoostCache ) ,  "Win32_PerfFormattedData_rdyboost_ReadyBoostCache" }
        ,  { typeof ( Win32PerfRawDataRdyboostReadyBoostCache ) ,  "Win32_PerfRawData_rdyboost_ReadyBoostCache" }
        ,  { typeof ( Win32PerfFormattedDataRemoteAccessRASPort ) ,  "Win32_PerfFormattedData_RemoteAccess_RASPort" }
        ,  { typeof ( Win32PerfRawDataRemoteAccessRASPort ) ,  "Win32_PerfRawData_RemoteAccess_RASPort" }
        ,  { typeof ( Win32PerfFormattedDataRemoteAccessRASTotal ) ,  "Win32_PerfFormattedData_RemoteAccess_RASTotal" }
        ,  { typeof ( Win32PerfRawDataRemoteAccessRASTotal ) ,  "Win32_PerfRawData_RemoteAccess_RASTotal" }
        ,  { typeof ( Win32PerfFormattedDataRemoteFXPerformanceCounterProviderRemoteFXSoftware ) ,  "Win32_PerfFormattedData_RemoteFXPerformanceCounterProvider_RemoteFXSoftware" }
        ,  { typeof ( Win32PerfRawDataRemoteFXPerformanceCounterProviderRemoteFXSoftware ) ,  "Win32_PerfRawData_RemoteFXPerformanceCounterProvider_RemoteFXSoftware" }
        ,  { typeof ( Win32PerfFormattedDataRemotePerfProviderHyperVVMRemoting ) ,  "Win32_PerfFormattedData_RemotePerfProvider_HyperVVMRemoting" }
        ,  { typeof ( Win32PerfRawDataRemotePerfProviderHyperVVMRemoting ) ,  "Win32_PerfRawData_RemotePerfProvider_HyperVVMRemoting" }
        ,  { typeof ( Win32PerfFormattedDataServiceModel4000ServiceModelEndpoint4000 ) ,  "Win32_PerfFormattedData_ServiceModel4000_ServiceModelEndpoint4000" }
        ,  { typeof ( Win32PerfRawDataServiceModel4000ServiceModelEndpoint4000 ) ,  "Win32_PerfRawData_ServiceModel4000_ServiceModelEndpoint4000" }
        ,  { typeof ( Win32PerfFormattedDataServiceModel4000ServiceModelOperation4000 ) ,  "Win32_PerfFormattedData_ServiceModel4000_ServiceModelOperation4000" }
        ,  { typeof ( Win32PerfRawDataServiceModel4000ServiceModelOperation4000 ) ,  "Win32_PerfRawData_ServiceModel4000_ServiceModelOperation4000" }
        ,  { typeof ( Win32PerfFormattedDataServiceModel4000ServiceModelService4000 ) ,  "Win32_PerfFormattedData_ServiceModel4000_ServiceModelService4000" }
        ,  { typeof ( Win32PerfRawDataServiceModel4000ServiceModelService4000 ) ,  "Win32_PerfRawData_ServiceModel4000_ServiceModelService4000" }
        ,  { typeof ( Win32PerfFormattedDataSMSvcHost4000SMSvcHost4000 ) ,  "Win32_PerfFormattedData_SMSvcHost4000_SMSvcHost4000" }
        ,  { typeof ( Win32PerfRawDataSMSvcHost4000SMSvcHost4000 ) ,  "Win32_PerfRawData_SMSvcHost4000_SMSvcHost4000" }
        ,  { typeof ( Win32PerfFormattedDataSpoolerPrintQueue ) ,  "Win32_PerfFormattedData_Spooler_PrintQueue" }
        ,  { typeof ( Win32PerfRawDataSpoolerPrintQueue ) ,  "Win32_PerfRawData_Spooler_PrintQueue" }
        ,  { typeof ( Win32PerfFormattedDataSynth3dVideoPerfProviderRemoteFXRootGPUManagement ) ,  "Win32_PerfFormattedData_Synth3dVideoPerfProvider_RemoteFXRootGPUManagement" }
        ,  { typeof ( Win32PerfRawDataSynth3dVideoPerfProviderRemoteFXRootGPUManagement ) ,  "Win32_PerfRawData_Synth3dVideoPerfProvider_RemoteFXRootGPUManagement" }
        ,  { typeof ( Win32PerfFormattedDataTapiSrvTelephony ) ,  "Win32_PerfFormattedData_TapiSrv_Telephony" }
        ,  { typeof ( Win32PerfRawDataTapiSrvTelephony ) ,  "Win32_PerfRawData_TapiSrv_Telephony" }
        ,  { typeof ( Win32PerfFormattedDataTcpipICMP ) ,  "Win32_PerfFormattedData_Tcpip_ICMP" }
        ,  { typeof ( Win32PerfRawDataTcpipICMP ) ,  "Win32_PerfRawData_Tcpip_ICMP" }
        ,  { typeof ( Win32PerfFormattedDataTcpipICMPv6 ) ,  "Win32_PerfFormattedData_Tcpip_ICMPv6" }
        ,  { typeof ( Win32PerfRawDataTcpipICMPv6 ) ,  "Win32_PerfRawData_Tcpip_ICMPv6" }
        ,  { typeof ( Win32PerfFormattedDataTcpipIPv4 ) ,  "Win32_PerfFormattedData_Tcpip_IPv4" }
        ,  { typeof ( Win32PerfRawDataTcpipIPv4 ) ,  "Win32_PerfRawData_Tcpip_IPv4" }
        ,  { typeof ( Win32PerfFormattedDataTcpipIPv6 ) ,  "Win32_PerfFormattedData_Tcpip_IPv6" }
        ,  { typeof ( Win32PerfRawDataTcpipIPv6 ) ,  "Win32_PerfRawData_Tcpip_IPv6" }
        ,  { typeof ( Win32PerfFormattedDataTcpipNBTConnection ) ,  "Win32_PerfFormattedData_Tcpip_NBTConnection" }
        ,  { typeof ( Win32PerfRawDataTcpipNBTConnection ) ,  "Win32_PerfRawData_Tcpip_NBTConnection" }
        ,  { typeof ( Win32PerfFormattedDataTcpipNetworkAdapter ) ,  "Win32_PerfFormattedData_Tcpip_NetworkAdapter" }
        ,  { typeof ( Win32PerfRawDataTcpipNetworkAdapter ) ,  "Win32_PerfRawData_Tcpip_NetworkAdapter" }
        ,  { typeof ( Win32PerfFormattedDataTcpipNetworkInterface ) ,  "Win32_PerfFormattedData_Tcpip_NetworkInterface" }
        ,  { typeof ( Win32PerfRawDataTcpipNetworkInterface ) ,  "Win32_PerfRawData_Tcpip_NetworkInterface" }
        ,  { typeof ( Win32PerfFormattedDataTcpipTCPv4 ) ,  "Win32_PerfFormattedData_Tcpip_TCPv4" }
        ,  { typeof ( Win32PerfRawDataTcpipTCPv4 ) ,  "Win32_PerfRawData_Tcpip_TCPv4" }
        ,  { typeof ( Win32PerfFormattedDataTcpipTCPv6 ) ,  "Win32_PerfFormattedData_Tcpip_TCPv6" }
        ,  { typeof ( Win32PerfRawDataTcpipTCPv6 ) ,  "Win32_PerfRawData_Tcpip_TCPv6" }
        ,  { typeof ( Win32PerfFormattedDataTcpipUDPv4 ) ,  "Win32_PerfFormattedData_Tcpip_UDPv4" }
        ,  { typeof ( Win32PerfRawDataTcpipUDPv4 ) ,  "Win32_PerfRawData_Tcpip_UDPv4" }
        ,  { typeof ( Win32PerfFormattedDataTcpipUDPv6 ) ,  "Win32_PerfFormattedData_Tcpip_UDPv6" }
        ,  { typeof ( Win32PerfRawDataTcpipUDPv6 ) ,  "Win32_PerfRawData_Tcpip_UDPv6" }
        ,  { typeof ( Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnostics ) ,  "Win32_PerfFormattedData_TCPIPCounters_TCPIPPerformanceDiagnostics" }
        ,  { typeof ( Win32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnostics ) ,  "Win32_PerfRawData_TCPIPCounters_TCPIPPerformanceDiagnostics" }
        ,  { typeof ( Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnosticsPerCPU ) ,  "Win32_PerfFormattedData_TCPIPCounters_TCPIPPerformanceDiagnosticsPerCPU" }
        ,  { typeof ( Win32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnosticsPerCPU ) ,  "Win32_PerfRawData_TCPIPCounters_TCPIPPerformanceDiagnosticsPerCPU" }
        ,  { typeof ( Win32PerfFormattedDataTermServiceTerminalServicesSession ) ,  "Win32_PerfFormattedData_TermService_TerminalServicesSession" }
        ,  { typeof ( Win32PerfRawDataTermServiceTerminalServicesSession ) ,  "Win32_PerfRawData_TermService_TerminalServicesSession" }
        ,  { typeof ( Win32PerfFormattedDataUGathererSearchGathererProjects ) ,  "Win32_PerfFormattedData_UGatherer_SearchGathererProjects" }
        ,  { typeof ( Win32PerfRawDataUGathererSearchGathererProjects ) ,  "Win32_PerfRawData_UGatherer_SearchGathererProjects" }
        ,  { typeof ( Win32PerfFormattedDataUGTHRSVCSearchGatherer ) ,  "Win32_PerfFormattedData_UGTHRSVC_SearchGatherer" }
        ,  { typeof ( Win32PerfRawDataUGTHRSVCSearchGatherer ) ,  "Win32_PerfRawData_UGTHRSVC_SearchGatherer" }
        ,  { typeof ( Win32PerfFormattedDataUsbhubNoname ) ,  "Win32_PerfFormattedData_usbhub_Noname" }
        ,  { typeof ( Win32PerfRawDataUsbhubNoname ) ,  "Win32_PerfRawData_usbhub_Noname" }
        ,  { typeof ( Win32PerfFormattedDataVidPerfProviderHyperVVMVidDriver ) ,  "Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidDriver" }
        ,  { typeof ( Win32PerfRawDataVidPerfProviderHyperVVMVidDriver ) ,  "Win32_PerfRawData_VidPerfProvider_HyperVVMVidDriver" }
        ,  { typeof ( Win32PerfFormattedDataVidPerfProviderHyperVVMVidNumaNode ) ,  "Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidNumaNode" }
        ,  { typeof ( Win32PerfRawDataVidPerfProviderHyperVVMVidNumaNode ) ,  "Win32_PerfRawData_VidPerfProvider_HyperVVMVidNumaNode" }
        ,  { typeof ( Win32PerfFormattedDataVidPerfProviderHyperVVMVidPartition ) ,  "Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidPartition" }
        ,  { typeof ( Win32PerfRawDataVidPerfProviderHyperVVMVidPartition ) ,  "Win32_PerfRawData_VidPerfProvider_HyperVVMVidPartition" }
        ,  { typeof ( Win32PerfFormattedDataVMBusPipeIOPerfProviderHyperVVMVirtualDevicePipeIO ) ,  "Win32_PerfFormattedData_VMBusPipeIOPerfProvider_HyperVVMVirtualDevicePipeIO" }
        ,  { typeof ( Win32PerfRawDataVMBusPipeIOPerfProviderHyperVVMVirtualDevicePipeIO ) ,  "Win32_PerfRawData_VMBusPipeIOPerfProvider_HyperVVMVirtualDevicePipeIO" }
        ,  { typeof ( Win32PerfFormattedDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary ) ,  "Win32_PerfFormattedData_VmmsVirtualMachineStats_HyperVVirtualMachineHealthSummary" }
        ,  { typeof ( Win32PerfRawDataVmmsVirtualMachineStatsHyperVVirtualMachineHealthSummary ) ,  "Win32_PerfRawData_VmmsVirtualMachineStats_HyperVVirtualMachineHealthSummary" }
        ,  { typeof ( Win32PerfFormattedDataVSmbPerfProviderHyperVVirtualSMB ) ,  "Win32_PerfFormattedData_VSmbPerfProvider_HyperVVirtualSMB" }
        ,  { typeof ( Win32PerfRawDataVSmbPerfProviderHyperVVirtualSMB ) ,  "Win32_PerfRawData_VSmbPerfProvider_HyperVVirtualSMB" }
        ,  { typeof ( Win32PerfFormattedDataWindowsMediaPlayerWindowsMediaPlayerMetadata ) ,  "Win32_PerfFormattedData_WindowsMediaPlayer_WindowsMediaPlayerMetadata" }
        ,  { typeof ( Win32PerfRawDataWindowsMediaPlayerWindowsMediaPlayerMetadata ) ,  "Win32_PerfRawData_WindowsMediaPlayer_WindowsMediaPlayerMetadata" }
        ,  { typeof ( Win32PerfFormattedDataWindowsWorkflowFoundation4000WFSystemWorkflow4000 ) ,  "Win32_PerfFormattedData_WindowsWorkflowFoundation4000_WFSystemWorkflow4000" }
        ,  { typeof ( Win32PerfRawDataWindowsWorkflowFoundation4000WFSystemWorkflow4000 ) ,  "Win32_PerfRawData_WindowsWorkflowFoundation4000_WFSystemWorkflow4000" }
        ,  { typeof ( Win32PerfFormattedDataWinNatCountersWinNAT ) ,  "Win32_PerfFormattedData_WinNatCounters_WinNAT" }
        ,  { typeof ( Win32PerfRawDataWinNatCountersWinNAT ) ,  "Win32_PerfRawData_WinNatCounters_WinNAT" }
        ,  { typeof ( Win32PerfFormattedDataWinNatCountersWinNATICMP ) ,  "Win32_PerfFormattedData_WinNatCounters_WinNATICMP" }
        ,  { typeof ( Win32PerfRawDataWinNatCountersWinNATICMP ) ,  "Win32_PerfRawData_WinNatCounters_WinNATICMP" }
        ,  { typeof ( Win32PerfFormattedDataWinNatCountersWinNATInstance ) ,  "Win32_PerfFormattedData_WinNatCounters_WinNATInstance" }
        ,  { typeof ( Win32PerfRawDataWinNatCountersWinNATInstance ) ,  "Win32_PerfRawData_WinNatCounters_WinNATInstance" }
        ,  { typeof ( Win32PerfFormattedDataWinNatCountersWinNATTCP ) ,  "Win32_PerfFormattedData_WinNatCounters_WinNATTCP" }
        ,  { typeof ( Win32PerfRawDataWinNatCountersWinNATTCP ) ,  "Win32_PerfRawData_WinNatCounters_WinNATTCP" }
        ,  { typeof ( Win32PerfFormattedDataWinNatCountersWinNATUDP ) ,  "Win32_PerfFormattedData_WinNatCounters_WinNATUDP" }
        ,  { typeof ( Win32PerfRawDataWinNatCountersWinNATUDP ) ,  "Win32_PerfRawData_WinNatCounters_WinNATUDP" }
        ,  { typeof ( Win32PerfFormattedDataWorkerVpProviderHyperVWorkerVirtualProcessor ) ,  "Win32_PerfFormattedData_WorkerVpProvider_HyperVWorkerVirtualProcessor" }
        ,  { typeof ( Win32PerfRawDataWorkerVpProviderHyperVWorkerVirtualProcessor ) ,  "Win32_PerfRawData_WorkerVpProvider_HyperVWorkerVirtualProcessor" }
        ,  { typeof ( Win32PerfFormattedDataWorkflowServiceHost4000WorkflowServiceHost4000 ) ,  "Win32_PerfFormattedData_WorkflowServiceHost4000_WorkflowServiceHost4000" }
        ,  { typeof ( Win32PerfRawDataWorkflowServiceHost4000WorkflowServiceHost4000 ) ,  "Win32_PerfRawData_WorkflowServiceHost4000_WorkflowServiceHost4000" }
        ,  { typeof ( Win32PerfFormattedDataWSearchIdxPiSearchIndexer ) ,  "Win32_PerfFormattedData_WSearchIdxPi_SearchIndexer" }
        ,  { typeof ( Win32PerfRawDataWSearchIdxPiSearchIndexer ) ,  "Win32_PerfRawData_WSearchIdxPi_SearchIndexer" }
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