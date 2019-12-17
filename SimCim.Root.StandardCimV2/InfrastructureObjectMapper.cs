using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class InfrastructureObjectMapper : IInfrastructureObjectMapper
    {
        public string CimNamespace => "root/standardcimv2";
        public IInfrastructureObject Create(IInfrastructureObjectScope scope, CimInstance cimInstance)
        {
            if (cimInstance == null)
            {
                return null;
            }

            switch (cimInstance.CimSystemProperties.ClassName)
            {
                case "__thisNAMESPACE":
                    return new ThisNAMESPACE(scope, cimInstance);
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
                case "__Win32Provider":
                    return new Win32Provider(scope, cimInstance);
                case "__NAMESPACE":
                    return new NAMESPACE(scope, cimInstance);
                case "__EventFilter":
                    return new EventFilter(scope, cimInstance);
                case "__AggregateEvent":
                    return new AggregateEvent(scope, cimInstance);
                case "__TimerNextFiring":
                    return new TimerNextFiring(scope, cimInstance);
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
                case "__AbsoluteTimerInstruction":
                    return new AbsoluteTimerInstruction(scope, cimInstance);
                case "__IntervalTimerInstruction":
                    return new IntervalTimerInstruction(scope, cimInstance);
                case "__SystemSecurity":
                    return new SystemSecurity(scope, cimInstance);
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
                case "CIM_Error":
                    return new CIMError(scope, cimInstance);
                case "MSFT_WmiError":
                    return new MSFTWmiError(scope, cimInstance);
                case "MSFT_ExtendedStatus":
                    return new MSFTExtendedStatus(scope, cimInstance);
                case "MSFT_DASettingsIndication":
                    return new MSFTDASettingsIndication(scope, cimInstance);
                case "MSFT_NetAdapter_PacketDirectCapabilities":
                    return new MSFTNetAdapterPacketDirectCapabilities(scope, cimInstance);
                case "MSFT_NetAdapterEncapsulatedPacketTaskOffloadCapabilities":
                    return new MSFTNetAdapterEncapsulatedPacketTaskOffloadCapabilities(scope, cimInstance);
                case "MSFT_NetAdapterEncapsulatedPacketTaskOffloadCapabilitiesEx":
                    return new MSFTNetAdapterEncapsulatedPacketTaskOffloadCapabilitiesEx(scope, cimInstance);
                case "CIM_IKEProposal":
                    return new CIMIKEProposal(scope, cimInstance);
                case "MSFT_NetIKEAuthProposal":
                    return new MSFTNetIKEAuthProposal(scope, cimInstance);
                case "MSFT_NetIKEBasicAuthProposal":
                    return new MSFTNetIKEBasicAuthProposal(scope, cimInstance);
                case "MSFT_NetIKECertAuthProposal":
                    return new MSFTNetIKECertAuthProposal(scope, cimInstance);
                case "MSFT_NetIKEPSKAuthProposal":
                    return new MSFTNetIKEPSKAuthProposal(scope, cimInstance);
                case "MSFT_NetIKEKerbAuthProposal":
                    return new MSFTNetIKEKerbAuthProposal(scope, cimInstance);
                case "MSFT_NetIKECryptoProposal":
                    return new MSFTNetIKECryptoProposal(scope, cimInstance);
                case "MSFT_NetIKEQMCryptoProposal":
                    return new MSFTNetIKEQMCryptoProposal(scope, cimInstance);
                case "MSFT_NetIKEMMCryptoProposal":
                    return new MSFTNetIKEMMCryptoProposal(scope, cimInstance);
                case "CIM_IPAssignmentSettingData":
                    return new CIMIPAssignmentSettingData(scope, cimInstance);
                case "CIM_DNSGeneralSettingData":
                    return new CIMDNSGeneralSettingData(scope, cimInstance);
                case "MSFT_DNSClientGlobalSetting":
                    return new MSFTDNSClientGlobalSetting(scope, cimInstance);
                case "MSFT_NetSettingData":
                    return new MSFTNetSettingData(scope, cimInstance);
                case "MSFT_NetNatSession":
                    return new MSFTNetNatSession(scope, cimInstance);
                case "MSFT_NetNatStaticMapping":
                    return new MSFTNetNatStaticMapping(scope, cimInstance);
                case "MSFT_NCSIPolicyConfiguration":
                    return new MSFTNCSIPolicyConfiguration(scope, cimInstance);
                case "MSFT_DAClientExperienceConfiguration":
                    return new MSFTDAClientExperienceConfiguration(scope, cimInstance);
                case "MSFT_NetNatGlobal":
                    return new MSFTNetNatGlobal(scope, cimInstance);
                case "MSFT_DASiteTableEntry":
                    return new MSFTDASiteTableEntry(scope, cimInstance);
                case "MSFT_DAConnectionStatus":
                    return new MSFTDAConnectionStatus(scope, cimInstance);
                case "MSFT_NetAdapterSettingData":
                    return new MSFTNetAdapterSettingData(scope, cimInstance);
                case "MSFT_NetAdapterPacketDirectSettingData":
                    return new MSFTNetAdapterPacketDirectSettingData(scope, cimInstance);
                case "MSFT_NetAdapterUsoSettingData":
                    return new MSFTNetAdapterUsoSettingData(scope, cimInstance);
                case "MSFT_NetAdapterBindingSettingData":
                    return new MSFTNetAdapterBindingSettingData(scope, cimInstance);
                case "MSFT_NetAdapterStatisticsSettingData":
                    return new MSFTNetAdapterStatisticsSettingData(scope, cimInstance);
                case "MSFT_NetAdapterVmqQueueSettingData":
                    return new MSFTNetAdapterVmqQueueSettingData(scope, cimInstance);
                case "MSFT_NetAdapterRssSettingData":
                    return new MSFTNetAdapterRssSettingData(scope, cimInstance);
                case "MSFT_NetAdapterChecksumOffloadSettingData":
                    return new MSFTNetAdapterChecksumOffloadSettingData(scope, cimInstance);
                case "MSFT_NetAdapterIPsecOffloadV2SettingData":
                    return new MSFTNetAdapterIPsecOffloadV2SettingData(scope, cimInstance);
                case "MSFT_NetAdapterVPortSettingData":
                    return new MSFTNetAdapterVPortSettingData(scope, cimInstance);
                case "MSFT_NetAdapterVmqSettingData":
                    return new MSFTNetAdapterVmqSettingData(scope, cimInstance);
                case "MSFT_NetAdapterRdmaSettingData":
                    return new MSFTNetAdapterRdmaSettingData(scope, cimInstance);
                case "MSFT_NetAdapterRscSettingData":
                    return new MSFTNetAdapterRscSettingData(scope, cimInstance);
                case "MSFT_NetAdapterSriovVfSettingData":
                    return new MSFTNetAdapterSriovVfSettingData(scope, cimInstance);
                case "MSFT_NetAdapterLsoSettingData":
                    return new MSFTNetAdapterLsoSettingData(scope, cimInstance);
                case "MSFT_NetAdapterEncapsulatedPacketTaskOffloadSettingData":
                    return new MSFTNetAdapterEncapsulatedPacketTaskOffloadSettingData(scope, cimInstance);
                case "MSFT_NetAdapterPowerManagementSettingData":
                    return new MSFTNetAdapterPowerManagementSettingData(scope, cimInstance);
                case "MSFT_NetAdapterHardwareInfoSettingData":
                    return new MSFTNetAdapterHardwareInfoSettingData(scope, cimInstance);
                case "MSFT_NetAdapterQosSettingData":
                    return new MSFTNetAdapterQosSettingData(scope, cimInstance);
                case "MSFT_NetAdapterSriovSettingData":
                    return new MSFTNetAdapterSriovSettingData(scope, cimInstance);
                case "MSFT_NetAdapterAdvancedPropertySettingData":
                    return new MSFTNetAdapterAdvancedPropertySettingData(scope, cimInstance);
                case "MSFT_NetNatExternalAddress":
                    return new MSFTNetNatExternalAddress(scope, cimInstance);
                case "MSFT_NetCompartment":
                    return new MSFTNetCompartment(scope, cimInstance);
                case "MSFT_NetNat":
                    return new MSFTNetNat(scope, cimInstance);
                case "MSFT_NetDnsTransitionMonitoring":
                    return new MSFTNetDnsTransitionMonitoring(scope, cimInstance);
                case "MSFT_NetIPHttpsConfiguration":
                    return new MSFTNetIPHttpsConfiguration(scope, cimInstance);
                case "MSFT_NetNatTransitionConfiguration":
                    return new MSFTNetNatTransitionConfiguration(scope, cimInstance);
                case "MSFT_NetTeredoConfiguration":
                    return new MSFTNetTeredoConfiguration(scope, cimInstance);
                case "MSFT_NetBranchCacheSettingData":
                    return new MSFTNetBranchCacheSettingData(scope, cimInstance);
                case "MSFT_NetBranchCacheHostedCacheServerSettingData":
                    return new MSFTNetBranchCacheHostedCacheServerSettingData(scope, cimInstance);
                case "MSFT_NetBranchCacheNetworkSettingData":
                    return new MSFTNetBranchCacheNetworkSettingData(scope, cimInstance);
                case "MSFT_NetBranchCacheContentServerSettingData":
                    return new MSFTNetBranchCacheContentServerSettingData(scope, cimInstance);
                case "MSFT_NetBranchCacheClientSettingData":
                    return new MSFTNetBranchCacheClientSettingData(scope, cimInstance);
                case "MSFT_NetIPsecDoSPSetting":
                    return new MSFTNetIPsecDoSPSetting(scope, cimInstance);
                case "MSFT_NetDnsTransitionConfiguration":
                    return new MSFTNetDnsTransitionConfiguration(scope, cimInstance);
                case "MSFT_NetNatTransitionMonitoring":
                    return new MSFTNetNatTransitionMonitoring(scope, cimInstance);
                case "MSFT_NetOffloadGlobalSetting":
                    return new MSFTNetOffloadGlobalSetting(scope, cimInstance);
                case "MSFT_Net6to4Configuration":
                    return new MSFTNet6to4Configuration(scope, cimInstance);
                case "MSFT_NetConnectionProfile":
                    return new MSFTNetConnectionProfile(scope, cimInstance);
                case "MSFT_NetISATAPConfiguration":
                    return new MSFTNetISATAPConfiguration(scope, cimInstance);
                case "MSFT_NetQosPolicySettingData":
                    return new MSFTNetQosPolicySettingData(scope, cimInstance);
                case "MSFT_NetSecuritySettingData":
                    return new MSFTNetSecuritySettingData(scope, cimInstance);
                case "MSFT_NetSecDeltaCollection":
                    return new MSFTNetSecDeltaCollection(scope, cimInstance);
                case "MSFT_NetGPO":
                    return new MSFTNetGPO(scope, cimInstance);
                case "MSFT_Printer":
                    return new MSFTPrinter(scope, cimInstance);
                case "MSFT_3DPrinter":
                    return new MSFT3DPrinter(scope, cimInstance);
                case "MSFT_NetEventSession":
                    return new MSFTNetEventSession(scope, cimInstance);
                case "CIM_ConcreteJob":
                    return new CIMConcreteJob(scope, cimInstance);
                case "MSFT_NetEventVmSwitch":
                    return new MSFTNetEventVmSwitch(scope, cimInstance);
                case "MSFT_NetEventVmNetworkAdapter":
                    return new MSFTNetEventVmNetworkAdapter(scope, cimInstance);
                case "MSFT_NetEventNetworkAdapter":
                    return new MSFTNetEventNetworkAdapter(scope, cimInstance);
                case "MSFT_NetEventProvider":
                    return new MSFTNetEventProvider(scope, cimInstance);
                case "MSFT_NetEventWFPCaptureProvider":
                    return new MSFTNetEventWFPCaptureProvider(scope, cimInstance);
                case "MSFT_NetEventPacketCaptureProvider":
                    return new MSFTNetEventPacketCaptureProvider(scope, cimInstance);
                case "MSFT_NetEventVmSwitchProvider":
                    return new MSFTNetEventVmSwitchProvider(scope, cimInstance);
                case "MSFT_NetEventVFPProvider":
                    return new MSFTNetEventVFPProvider(scope, cimInstance);
                case "CIM_LogicalPort":
                    return new CIMLogicalPort(scope, cimInstance);
                case "CIM_NetworkPort":
                    return new CIMNetworkPort(scope, cimInstance);
                case "MSFT_NetAdapter":
                    return new MSFTNetAdapter(scope, cimInstance);
                case "CIM_ProtocolEndpoint":
                    return new CIMProtocolEndpoint(scope, cimInstance);
                case "CIM_LANEndpoint":
                    return new CIMLANEndpoint(scope, cimInstance);
                case "MSFT_NetIPInterface":
                    return new MSFTNetIPInterface(scope, cimInstance);
                case "CIM_DNSProtocolEndpoint":
                    return new CIMDNSProtocolEndpoint(scope, cimInstance);
                case "MSFT_DNSClient":
                    return new MSFTDNSClient(scope, cimInstance);
                case "CIM_SecurityAssociationEndpoint":
                    return new CIMSecurityAssociationEndpoint(scope, cimInstance);
                case "CIM_IKESAEndpoint":
                    return new CIMIKESAEndpoint(scope, cimInstance);
                case "MSFT_NetMainModeSA":
                    return new MSFTNetMainModeSA(scope, cimInstance);
                case "CIM_IPsecSAEndpoint":
                    return new CIMIPsecSAEndpoint(scope, cimInstance);
                case "MSFT_NetQuickModeSA":
                    return new MSFTNetQuickModeSA(scope, cimInstance);
                case "CIM_IPProtocolEndpoint":
                    return new CIMIPProtocolEndpoint(scope, cimInstance);
                case "MSFT_NetIPAddress":
                    return new MSFTNetIPAddress(scope, cimInstance);
                case "MSFT_NetBaseIPProtocol":
                    return new MSFTNetBaseIPProtocol(scope, cimInstance);
                case "MSFT_NetIPv6Protocol":
                    return new MSFTNetIPv6Protocol(scope, cimInstance);
                case "MSFT_NetIPv4Protocol":
                    return new MSFTNetIPv4Protocol(scope, cimInstance);
                case "CIM_RemoteServiceAccessPoint":
                    return new CIMRemoteServiceAccessPoint(scope, cimInstance);
                case "MSFT_NetNeighbor":
                    return new MSFTNetNeighbor(scope, cimInstance);
                case "MSFT_DNSClientServerAddress":
                    return new MSFTDNSClientServerAddress(scope, cimInstance);
                case "CIM_NetworkPipe":
                    return new CIMNetworkPipe(scope, cimInstance);
                case "MSFT_NetTransportConnection":
                    return new MSFTNetTransportConnection(scope, cimInstance);
                case "MSFT_NetTCPConnection":
                    return new MSFTNetTCPConnection(scope, cimInstance);
                case "MSFT_NetUDPEndpoint":
                    return new MSFTNetUDPEndpoint(scope, cimInstance);
                case "MSFT_NetSwitchTeamMember":
                    return new MSFTNetSwitchTeamMember(scope, cimInstance);
                case "MSFT_NetLbfoTeamNic":
                    return new MSFTNetLbfoTeamNic(scope, cimInstance);
                case "MSFT_NetLbfoTeamMember":
                    return new MSFTNetLbfoTeamMember(scope, cimInstance);
                case "MSFT_NetServiceFilter":
                    return new MSFTNetServiceFilter(scope, cimInstance);
                case "MSFT_NetApplicationFilter":
                    return new MSFTNetApplicationFilter(scope, cimInstance);
                case "MSFT_NetInterfaceFilter":
                    return new MSFTNetInterfaceFilter(scope, cimInstance);
                case "MSFT_NetTransportFilter":
                    return new MSFTNetTransportFilter(scope, cimInstance);
                case "MSFT_NetInterfaceTypeFilter":
                    return new MSFTNetInterfaceTypeFilter(scope, cimInstance);
                case "MSFT_NetNetworkLayerSecurityFilter":
                    return new MSFTNetNetworkLayerSecurityFilter(scope, cimInstance);
                case "MSFT_NetAddressFilter":
                    return new MSFTNetAddressFilter(scope, cimInstance);
                case "MSFT_NetProtocolPortFilter":
                    return new MSFTNetProtocolPortFilter(scope, cimInstance);
                case "MSFT_NetBranchCacheStatus":
                    return new MSFTNetBranchCacheStatus(scope, cimInstance);
                case "MSFT_NetBranchCacheDataCacheExtension":
                    return new MSFTNetBranchCacheDataCacheExtension(scope, cimInstance);
                case "MSFT_NetBranchCacheDataCache":
                    return new MSFTNetBranchCacheDataCache(scope, cimInstance);
                case "MSFT_NetBranchCacheHashCache":
                    return new MSFTNetBranchCacheHashCache(scope, cimInstance);
                case "MSFT_PrintJob":
                    return new MSFTPrintJob(scope, cimInstance);
                case "MSFT_PrinterDriver":
                    return new MSFTPrinterDriver(scope, cimInstance);
                case "MSFT_PrinterPort":
                    return new MSFTPrinterPort(scope, cimInstance);
                case "MSFT_WsdPrinterPort":
                    return new MSFTWsdPrinterPort(scope, cimInstance);
                case "MSFT_LprPrinterPort":
                    return new MSFTLprPrinterPort(scope, cimInstance);
                case "MSFT_TcpIpPrinterPort":
                    return new MSFTTcpIpPrinterPort(scope, cimInstance);
                case "MSFT_LocalPrinterPort":
                    return new MSFTLocalPrinterPort(scope, cimInstance);
                case "CIM_NextHopRoute":
                    return new CIMNextHopRoute(scope, cimInstance);
                case "MSFT_NetRoute":
                    return new MSFTNetRoute(scope, cimInstance);
                case "CIM_IKEAction":
                    return new CIMIKEAction(scope, cimInstance);
                case "MSFT_NetIKEAuthSet":
                    return new MSFTNetIKEAuthSet(scope, cimInstance);
                case "MSFT_NetIKEP1AuthSet":
                    return new MSFTNetIKEP1AuthSet(scope, cimInstance);
                case "MSFT_NetIKEP2AuthSet":
                    return new MSFTNetIKEP2AuthSet(scope, cimInstance);
                case "MSFT_NetIKECryptoSet":
                    return new MSFTNetIKECryptoSet(scope, cimInstance);
                case "MSFT_NetIKEMMCryptoSet":
                    return new MSFTNetIKEMMCryptoSet(scope, cimInstance);
                case "MSFT_NetIKEQMCryptoSet":
                    return new MSFTNetIKEQMCryptoSet(scope, cimInstance);
                case "MSFT_NetTCPSetting":
                    return new MSFTNetTCPSetting(scope, cimInstance);
                case "MSFT_NetUDPSetting":
                    return new MSFTNetUDPSetting(scope, cimInstance);
                case "CIM_PolicyRule":
                    return new CIMPolicyRule(scope, cimInstance);
                case "CIM_SARule":
                    return new CIMSARule(scope, cimInstance);
                case "MSFT_NetSARule":
                    return new MSFTNetSARule(scope, cimInstance);
                case "MSFT_NetMainModeRule":
                    return new MSFTNetMainModeRule(scope, cimInstance);
                case "MSFT_NetConSecRule":
                    return new MSFTNetConSecRule(scope, cimInstance);
                case "MSFT_NetFirewallRule":
                    return new MSFTNetFirewallRule(scope, cimInstance);
                case "MSFT_DNSClientCache":
                    return new MSFTDNSClientCache(scope, cimInstance);
                case "MSFT_NetFirewallProfile":
                    return new MSFTNetFirewallProfile(scope, cimInstance);
                case "MSFT_NetLbfoProvider":
                    return new MSFTNetLbfoProvider(scope, cimInstance);
                case "MSFT_NetPrefixPolicy":
                    return new MSFTNetPrefixPolicy(scope, cimInstance);
                case "MSFT_NetSwitchTeam":
                    return new MSFTNetSwitchTeam(scope, cimInstance);
                case "MSFT_NetLbfoTeam":
                    return new MSFTNetLbfoTeam(scope, cimInstance);
                case "MSFT_NetBranchCacheOrchestrator":
                    return new MSFTNetBranchCacheOrchestrator(scope, cimInstance);
                case "MSFT_PrinterProperty":
                    return new MSFTPrinterProperty(scope, cimInstance);
                case "MSFT_NetAdapter_RdmaStatistics":
                    return new MSFTNetAdapterRdmaStatistics(scope, cimInstance);
                case "MSFT_NetAdapterUdpSegmentationOffloadCapabilities":
                    return new MSFTNetAdapterUdpSegmentationOffloadCapabilities(scope, cimInstance);
                case "MSFT_NetAdapter_RscStatistics":
                    return new MSFTNetAdapterRscStatistics(scope, cimInstance);
                case "MSFT_NetAdapterUsoEncapsulationTypes":
                    return new MSFTNetAdapterUsoEncapsulationTypes(scope, cimInstance);
                case "__ExtendedStatus":
                    return new ExtendedStatus(scope, cimInstance);
                case "__NTLMUser9X":
                    return new NTLMUser9X(scope, cimInstance);
                case "MSFT_NetAdapterLargeSendOffloadV2Capabilities":
                    return new MSFTNetAdapterLargeSendOffloadV2Capabilities(scope, cimInstance);
                case "MSFT_PrinterPortTasks":
                    return new MSFTPrinterPortTasks(scope, cimInstance);
                case "MSFT_NetAdapter_RssProcessor":
                    return new MSFTNetAdapterRssProcessor(scope, cimInstance);
                case "MSFT_NetAdapter_QosSettings":
                    return new MSFTNetAdapterQosSettings(scope, cimInstance);
                case "MSFT_NetAdapter_RdmaAdapterInfo":
                    return new MSFTNetAdapterRdmaAdapterInfo(scope, cimInstance);
                case "MSFT_NetAdapterPowerManagement_Offload":
                    return new MSFTNetAdapterPowerManagementOffload(scope, cimInstance);
                case "MSFT_NetAdapterPowerManagement_Offload_RsnRekey":
                    return new MSFTNetAdapterPowerManagementOffloadRsnRekey(scope, cimInstance);
                case "MSFT_NetAdapterPowerManagement_Offload_Arp":
                    return new MSFTNetAdapterPowerManagementOffloadArp(scope, cimInstance);
                case "MSFT_NetAdapterPowerManagement_Offload_NS":
                    return new MSFTNetAdapterPowerManagementOffloadNS(scope, cimInstance);
                case "MSFT_NetAdapterRscCapabilities":
                    return new MSFTNetAdapterRscCapabilities(scope, cimInstance);
                case "MSFT_NetAdapterLargeSendOffloadV1Capabilities":
                    return new MSFTNetAdapterLargeSendOffloadV1Capabilities(scope, cimInstance);
                case "MSFT_NetAdapter_Group_Affinity":
                    return new MSFTNetAdapterGroupAffinity(scope, cimInstance);
                case "MSFT_PrinterConfiguration":
                    return new MSFTPrinterConfiguration(scope, cimInstance);
                case "MSFT_PrinterNfcTagTasks":
                    return new MSFTPrinterNfcTagTasks(scope, cimInstance);
                case "MSFT_NetAdapter_RdmaMissingCounterInfo":
                    return new MSFTNetAdapterRdmaMissingCounterInfo(scope, cimInstance);
                case "MSFT_NetAdapterChecksumOffloadCapabilities":
                    return new MSFTNetAdapterChecksumOffloadCapabilities(scope, cimInstance);
                case "MSFT_NetAdapterLsoEncapsulationTypes":
                    return new MSFTNetAdapterLsoEncapsulationTypes(scope, cimInstance);
                case "MSFT_NetAdapter_QosCapabilities":
                    return new MSFTNetAdapterQosCapabilities(scope, cimInstance);
                case "MSFT_NetAdapter_QosClassificationElement":
                    return new MSFTNetAdapterQosClassificationElement(scope, cimInstance);
                case "MSFT_NetAdapter_ProcessorNumber":
                    return new MSFTNetAdapterProcessorNumber(scope, cimInstance);
                case "MSFT_NetAdapterSriovCapabilities":
                    return new MSFTNetAdapterSriovCapabilities(scope, cimInstance);
                case "MSFT_NetAdapter_VmqFilter":
                    return new MSFTNetAdapterVmqFilter(scope, cimInstance);
                case "MSFT_NetIPsecIdentity":
                    return new MSFTNetIPsecIdentity(scope, cimInstance);
                case "MSFT_NetAdapterChecksumOffloadEncapsulationTypes":
                    return new MSFTNetAdapterChecksumOffloadEncapsulationTypes(scope, cimInstance);
                case "MSFT_NetAdapterPowerManagement_WakePattern":
                    return new MSFTNetAdapterPowerManagementWakePattern(scope, cimInstance);
                case "MSFT_NetAdapterPowerManagement_WakePattern_WildCard":
                    return new MSFTNetAdapterPowerManagementWakePatternWildCard(scope, cimInstance);
                case "MSFT_NetAdapterPowerManagement_WakePattern_TcpSyn":
                    return new MSFTNetAdapterPowerManagementWakePatternTcpSyn(scope, cimInstance);
                case "MSFT_NetAdapterPowerManagement_WakePattern_Bitmap":
                    return new MSFTNetAdapterPowerManagementWakePatternBitmap(scope, cimInstance);
                case "MSFT_NetAdapterPowerManagement_WakePattern_MagicPacket":
                    return new MSFTNetAdapterPowerManagementWakePatternMagicPacket(scope, cimInstance);
                case "MSFT_NetAdapterPowerManagement_WakePattern_EapolRequestId":
                    return new MSFTNetAdapterPowerManagementWakePatternEapolRequestId(scope, cimInstance);
                case "MSFT_PrinterNfcTag":
                    return new MSFTPrinterNfcTag(scope, cimInstance);
                default:
                    throw new KeyNotFoundException();
            }
        }

        private static Dictionary<Type, string> _typeMap = new Dictionary<Type, string>{ { typeof ( SystemClass ) ,  "__SystemClass" }
        ,  { typeof ( ThisNAMESPACE ) ,  "__thisNAMESPACE" }
        ,  { typeof ( ProviderRegistration ) ,  "__ProviderRegistration" }
        ,  { typeof ( EventProviderRegistration ) ,  "__EventProviderRegistration" }
        ,  { typeof ( ObjectProviderRegistration ) ,  "__ObjectProviderRegistration" }
        ,  { typeof ( ClassProviderRegistration ) ,  "__ClassProviderRegistration" }
        ,  { typeof ( InstanceProviderRegistration ) ,  "__InstanceProviderRegistration" }
        ,  { typeof ( MethodProviderRegistration ) ,  "__MethodProviderRegistration" }
        ,  { typeof ( PropertyProviderRegistration ) ,  "__PropertyProviderRegistration" }
        ,  { typeof ( EventConsumerProviderRegistration ) ,  "__EventConsumerProviderRegistration" }
        ,  { typeof ( Provider ) ,  "__Provider" }
        ,  { typeof ( Win32Provider ) ,  "__Win32Provider" }
        ,  { typeof ( NAMESPACE ) ,  "__NAMESPACE" }
        ,  { typeof ( IndicationRelated ) ,  "__IndicationRelated" }
        ,  { typeof ( EventFilter ) ,  "__EventFilter" }
        ,  { typeof ( EventConsumer ) ,  "__EventConsumer" }
        ,  { typeof ( AggregateEvent ) ,  "__AggregateEvent" }
        ,  { typeof ( TimerNextFiring ) ,  "__TimerNextFiring" }
        ,  { typeof ( Event ) ,  "__Event" }
        ,  { typeof ( InstanceOperationEvent ) ,  "__InstanceOperationEvent" }
        ,  { typeof ( InstanceCreationEvent ) ,  "__InstanceCreationEvent" }
        ,  { typeof ( MethodInvocationEvent ) ,  "__MethodInvocationEvent" }
        ,  { typeof ( InstanceModificationEvent ) ,  "__InstanceModificationEvent" }
        ,  { typeof ( InstanceDeletionEvent ) ,  "__InstanceDeletionEvent" }
        ,  { typeof ( ClassOperationEvent ) ,  "__ClassOperationEvent" }
        ,  { typeof ( ClassDeletionEvent ) ,  "__ClassDeletionEvent" }
        ,  { typeof ( ClassModificationEvent ) ,  "__ClassModificationEvent" }
        ,  { typeof ( ClassCreationEvent ) ,  "__ClassCreationEvent" }
        ,  { typeof ( NamespaceOperationEvent ) ,  "__NamespaceOperationEvent" }
        ,  { typeof ( NamespaceModificationEvent ) ,  "__NamespaceModificationEvent" }
        ,  { typeof ( NamespaceDeletionEvent ) ,  "__NamespaceDeletionEvent" }
        ,  { typeof ( NamespaceCreationEvent ) ,  "__NamespaceCreationEvent" }
        ,  { typeof ( TimerEvent ) ,  "__TimerEvent" }
        ,  { typeof ( ExtrinsicEvent ) ,  "__ExtrinsicEvent" }
        ,  { typeof ( SystemEvent ) ,  "__SystemEvent" }
        ,  { typeof ( EventDroppedEvent ) ,  "__EventDroppedEvent" }
        ,  { typeof ( EventQueueOverflowEvent ) ,  "__EventQueueOverflowEvent" }
        ,  { typeof ( QOSFailureEvent ) ,  "__QOSFailureEvent" }
        ,  { typeof ( ConsumerFailureEvent ) ,  "__ConsumerFailureEvent" }
        ,  { typeof ( EventGenerator ) ,  "__EventGenerator" }
        ,  { typeof ( TimerInstruction ) ,  "__TimerInstruction" }
        ,  { typeof ( AbsoluteTimerInstruction ) ,  "__AbsoluteTimerInstruction" }
        ,  { typeof ( IntervalTimerInstruction ) ,  "__IntervalTimerInstruction" }
        ,  { typeof ( SystemSecurity ) ,  "__SystemSecurity" }
        ,  { typeof ( CIMIndication ) ,  "CIM_Indication" }
        ,  { typeof ( CIMClassIndication ) ,  "CIM_ClassIndication" }
        ,  { typeof ( CIMClassDeletion ) ,  "CIM_ClassDeletion" }
        ,  { typeof ( CIMClassCreation ) ,  "CIM_ClassCreation" }
        ,  { typeof ( CIMClassModification ) ,  "CIM_ClassModification" }
        ,  { typeof ( CIMInstIndication ) ,  "CIM_InstIndication" }
        ,  { typeof ( CIMInstCreation ) ,  "CIM_InstCreation" }
        ,  { typeof ( CIMInstModification ) ,  "CIM_InstModification" }
        ,  { typeof ( CIMInstDeletion ) ,  "CIM_InstDeletion" }
        ,  { typeof ( CIMError ) ,  "CIM_Error" }
        ,  { typeof ( MSFTWmiError ) ,  "MSFT_WmiError" }
        ,  { typeof ( MSFTExtendedStatus ) ,  "MSFT_ExtendedStatus" }
        ,  { typeof ( MSFTDASettingsIndication ) ,  "MSFT_DASettingsIndication" }
        ,  { typeof ( MSFTNetAdapterPacketDirectCapabilities ) ,  "MSFT_NetAdapter_PacketDirectCapabilities" }
        ,  { typeof ( MSFTNetAdapterEncapsulatedPacketTaskOffloadCapabilities ) ,  "MSFT_NetAdapterEncapsulatedPacketTaskOffloadCapabilities" }
        ,  { typeof ( MSFTNetAdapterEncapsulatedPacketTaskOffloadCapabilitiesEx ) ,  "MSFT_NetAdapterEncapsulatedPacketTaskOffloadCapabilitiesEx" }
        ,  { typeof ( CIMManagedElement ) ,  "CIM_ManagedElement" }
        ,  { typeof ( CIMSettingData ) ,  "CIM_SettingData" }
        ,  { typeof ( CIMScopedSettingData ) ,  "CIM_ScopedSettingData" }
        ,  { typeof ( CIMSAProposal ) ,  "CIM_SAProposal" }
        ,  { typeof ( CIMIKEProposal ) ,  "CIM_IKEProposal" }
        ,  { typeof ( MSFTNetIKEAuthProposal ) ,  "MSFT_NetIKEAuthProposal" }
        ,  { typeof ( MSFTNetIKEBasicAuthProposal ) ,  "MSFT_NetIKEBasicAuthProposal" }
        ,  { typeof ( MSFTNetIKECertAuthProposal ) ,  "MSFT_NetIKECertAuthProposal" }
        ,  { typeof ( MSFTNetIKEPSKAuthProposal ) ,  "MSFT_NetIKEPSKAuthProposal" }
        ,  { typeof ( MSFTNetIKEKerbAuthProposal ) ,  "MSFT_NetIKEKerbAuthProposal" }
        ,  { typeof ( MSFTNetIKECryptoProposal ) ,  "MSFT_NetIKECryptoProposal" }
        ,  { typeof ( MSFTNetIKEQMCryptoProposal ) ,  "MSFT_NetIKEQMCryptoProposal" }
        ,  { typeof ( MSFTNetIKEMMCryptoProposal ) ,  "MSFT_NetIKEMMCryptoProposal" }
        ,  { typeof ( CIMIPAssignmentSettingData ) ,  "CIM_IPAssignmentSettingData" }
        ,  { typeof ( CIMDNSGeneralSettingData ) ,  "CIM_DNSGeneralSettingData" }
        ,  { typeof ( MSFTDNSClientGlobalSetting ) ,  "MSFT_DNSClientGlobalSetting" }
        ,  { typeof ( MSFTNetSettingData ) ,  "MSFT_NetSettingData" }
        ,  { typeof ( MSFTNetNatSession ) ,  "MSFT_NetNatSession" }
        ,  { typeof ( MSFTNetNatStaticMapping ) ,  "MSFT_NetNatStaticMapping" }
        ,  { typeof ( MSFTNCSIPolicyConfiguration ) ,  "MSFT_NCSIPolicyConfiguration" }
        ,  { typeof ( MSFTDAClientExperienceConfiguration ) ,  "MSFT_DAClientExperienceConfiguration" }
        ,  { typeof ( MSFTNetNatGlobal ) ,  "MSFT_NetNatGlobal" }
        ,  { typeof ( MSFTDASiteTableEntry ) ,  "MSFT_DASiteTableEntry" }
        ,  { typeof ( MSFTDAConnectionStatus ) ,  "MSFT_DAConnectionStatus" }
        ,  { typeof ( MSFTNetAdapterSettingData ) ,  "MSFT_NetAdapterSettingData" }
        ,  { typeof ( MSFTNetAdapterPacketDirectSettingData ) ,  "MSFT_NetAdapterPacketDirectSettingData" }
        ,  { typeof ( MSFTNetAdapterUsoSettingData ) ,  "MSFT_NetAdapterUsoSettingData" }
        ,  { typeof ( MSFTNetAdapterBindingSettingData ) ,  "MSFT_NetAdapterBindingSettingData" }
        ,  { typeof ( MSFTNetAdapterStatisticsSettingData ) ,  "MSFT_NetAdapterStatisticsSettingData" }
        ,  { typeof ( MSFTNetAdapterVmqQueueSettingData ) ,  "MSFT_NetAdapterVmqQueueSettingData" }
        ,  { typeof ( MSFTNetAdapterRssSettingData ) ,  "MSFT_NetAdapterRssSettingData" }
        ,  { typeof ( MSFTNetAdapterChecksumOffloadSettingData ) ,  "MSFT_NetAdapterChecksumOffloadSettingData" }
        ,  { typeof ( MSFTNetAdapterIPsecOffloadV2SettingData ) ,  "MSFT_NetAdapterIPsecOffloadV2SettingData" }
        ,  { typeof ( MSFTNetAdapterVPortSettingData ) ,  "MSFT_NetAdapterVPortSettingData" }
        ,  { typeof ( MSFTNetAdapterVmqSettingData ) ,  "MSFT_NetAdapterVmqSettingData" }
        ,  { typeof ( MSFTNetAdapterRdmaSettingData ) ,  "MSFT_NetAdapterRdmaSettingData" }
        ,  { typeof ( MSFTNetAdapterRscSettingData ) ,  "MSFT_NetAdapterRscSettingData" }
        ,  { typeof ( MSFTNetAdapterSriovVfSettingData ) ,  "MSFT_NetAdapterSriovVfSettingData" }
        ,  { typeof ( MSFTNetAdapterLsoSettingData ) ,  "MSFT_NetAdapterLsoSettingData" }
        ,  { typeof ( MSFTNetAdapterEncapsulatedPacketTaskOffloadSettingData ) ,  "MSFT_NetAdapterEncapsulatedPacketTaskOffloadSettingData" }
        ,  { typeof ( MSFTNetAdapterPowerManagementSettingData ) ,  "MSFT_NetAdapterPowerManagementSettingData" }
        ,  { typeof ( MSFTNetAdapterHardwareInfoSettingData ) ,  "MSFT_NetAdapterHardwareInfoSettingData" }
        ,  { typeof ( MSFTNetAdapterQosSettingData ) ,  "MSFT_NetAdapterQosSettingData" }
        ,  { typeof ( MSFTNetAdapterSriovSettingData ) ,  "MSFT_NetAdapterSriovSettingData" }
        ,  { typeof ( MSFTNetAdapterAdvancedPropertySettingData ) ,  "MSFT_NetAdapterAdvancedPropertySettingData" }
        ,  { typeof ( MSFTNetNatExternalAddress ) ,  "MSFT_NetNatExternalAddress" }
        ,  { typeof ( MSFTNetCompartment ) ,  "MSFT_NetCompartment" }
        ,  { typeof ( MSFTNetNat ) ,  "MSFT_NetNat" }
        ,  { typeof ( MSFTNetDnsTransitionMonitoring ) ,  "MSFT_NetDnsTransitionMonitoring" }
        ,  { typeof ( MSFTNetIPHttpsConfiguration ) ,  "MSFT_NetIPHttpsConfiguration" }
        ,  { typeof ( MSFTNetNatTransitionConfiguration ) ,  "MSFT_NetNatTransitionConfiguration" }
        ,  { typeof ( MSFTNetTeredoConfiguration ) ,  "MSFT_NetTeredoConfiguration" }
        ,  { typeof ( MSFTNetBranchCacheSettingData ) ,  "MSFT_NetBranchCacheSettingData" }
        ,  { typeof ( MSFTNetBranchCacheHostedCacheServerSettingData ) ,  "MSFT_NetBranchCacheHostedCacheServerSettingData" }
        ,  { typeof ( MSFTNetBranchCacheNetworkSettingData ) ,  "MSFT_NetBranchCacheNetworkSettingData" }
        ,  { typeof ( MSFTNetBranchCacheContentServerSettingData ) ,  "MSFT_NetBranchCacheContentServerSettingData" }
        ,  { typeof ( MSFTNetBranchCacheClientSettingData ) ,  "MSFT_NetBranchCacheClientSettingData" }
        ,  { typeof ( MSFTNetIPsecDoSPSetting ) ,  "MSFT_NetIPsecDoSPSetting" }
        ,  { typeof ( MSFTNetDnsTransitionConfiguration ) ,  "MSFT_NetDnsTransitionConfiguration" }
        ,  { typeof ( MSFTNetNatTransitionMonitoring ) ,  "MSFT_NetNatTransitionMonitoring" }
        ,  { typeof ( MSFTNetOffloadGlobalSetting ) ,  "MSFT_NetOffloadGlobalSetting" }
        ,  { typeof ( MSFTNet6to4Configuration ) ,  "MSFT_Net6to4Configuration" }
        ,  { typeof ( MSFTNetConnectionProfile ) ,  "MSFT_NetConnectionProfile" }
        ,  { typeof ( MSFTNetISATAPConfiguration ) ,  "MSFT_NetISATAPConfiguration" }
        ,  { typeof ( MSFTNetQosPolicySettingData ) ,  "MSFT_NetQosPolicySettingData" }
        ,  { typeof ( MSFTNetSecuritySettingData ) ,  "MSFT_NetSecuritySettingData" }
        ,  { typeof ( MSFTNetSecDeltaCollection ) ,  "MSFT_NetSecDeltaCollection" }
        ,  { typeof ( MSFTNetGPO ) ,  "MSFT_NetGPO" }
        ,  { typeof ( CIMManagedSystemElement ) ,  "CIM_ManagedSystemElement" }
        ,  { typeof ( MSFTPrinter ) ,  "MSFT_Printer" }
        ,  { typeof ( MSFT3DPrinter ) ,  "MSFT_3DPrinter" }
        ,  { typeof ( CIMLogicalElement ) ,  "CIM_LogicalElement" }
        ,  { typeof ( MSFTNetEventSession ) ,  "MSFT_NetEventSession" }
        ,  { typeof ( CIMJob ) ,  "CIM_Job" }
        ,  { typeof ( CIMConcreteJob ) ,  "CIM_ConcreteJob" }
        ,  { typeof ( MSFTNetEventPacketCaptureTarget ) ,  "MSFT_NetEventPacketCaptureTarget" }
        ,  { typeof ( MSFTNetEventVmSwitch ) ,  "MSFT_NetEventVmSwitch" }
        ,  { typeof ( MSFTNetEventVmNetworkAdapter ) ,  "MSFT_NetEventVmNetworkAdapter" }
        ,  { typeof ( MSFTNetEventNetworkAdapter ) ,  "MSFT_NetEventNetworkAdapter" }
        ,  { typeof ( MSFTNetEventProviderBase ) ,  "MSFT_NetEventProviderBase" }
        ,  { typeof ( MSFTNetEventProvider ) ,  "MSFT_NetEventProvider" }
        ,  { typeof ( MSFTNetEventWFPCaptureProvider ) ,  "MSFT_NetEventWFPCaptureProvider" }
        ,  { typeof ( MSFTNetEventPacketCaptureProvider ) ,  "MSFT_NetEventPacketCaptureProvider" }
        ,  { typeof ( MSFTNetEventVmSwitchProvider ) ,  "MSFT_NetEventVmSwitchProvider" }
        ,  { typeof ( MSFTNetEventVFPProvider ) ,  "MSFT_NetEventVFPProvider" }
        ,  { typeof ( CIMEnabledLogicalElement ) ,  "CIM_EnabledLogicalElement" }
        ,  { typeof ( CIMLogicalDevice ) ,  "CIM_LogicalDevice" }
        ,  { typeof ( CIMLogicalPort ) ,  "CIM_LogicalPort" }
        ,  { typeof ( CIMNetworkPort ) ,  "CIM_NetworkPort" }
        ,  { typeof ( MSFTNetAdapter ) ,  "MSFT_NetAdapter" }
        ,  { typeof ( CIMServiceAccessPoint ) ,  "CIM_ServiceAccessPoint" }
        ,  { typeof ( CIMProtocolEndpoint ) ,  "CIM_ProtocolEndpoint" }
        ,  { typeof ( CIMLANEndpoint ) ,  "CIM_LANEndpoint" }
        ,  { typeof ( MSFTNetIPInterface ) ,  "MSFT_NetIPInterface" }
        ,  { typeof ( CIMDNSProtocolEndpoint ) ,  "CIM_DNSProtocolEndpoint" }
        ,  { typeof ( MSFTDNSClient ) ,  "MSFT_DNSClient" }
        ,  { typeof ( CIMSecurityAssociationEndpoint ) ,  "CIM_SecurityAssociationEndpoint" }
        ,  { typeof ( CIMIKESAEndpoint ) ,  "CIM_IKESAEndpoint" }
        ,  { typeof ( MSFTNetMainModeSA ) ,  "MSFT_NetMainModeSA" }
        ,  { typeof ( CIMIPsecSAEndpoint ) ,  "CIM_IPsecSAEndpoint" }
        ,  { typeof ( MSFTNetQuickModeSA ) ,  "MSFT_NetQuickModeSA" }
        ,  { typeof ( CIMIPProtocolEndpoint ) ,  "CIM_IPProtocolEndpoint" }
        ,  { typeof ( MSFTNetIPAddress ) ,  "MSFT_NetIPAddress" }
        ,  { typeof ( MSFTNetBaseIPProtocol ) ,  "MSFT_NetBaseIPProtocol" }
        ,  { typeof ( MSFTNetIPv6Protocol ) ,  "MSFT_NetIPv6Protocol" }
        ,  { typeof ( MSFTNetIPv4Protocol ) ,  "MSFT_NetIPv4Protocol" }
        ,  { typeof ( CIMRemoteServiceAccessPoint ) ,  "CIM_RemoteServiceAccessPoint" }
        ,  { typeof ( MSFTNetNeighbor ) ,  "MSFT_NetNeighbor" }
        ,  { typeof ( MSFTDNSClientServerAddress ) ,  "MSFT_DNSClientServerAddress" }
        ,  { typeof ( CIMNetworkPipe ) ,  "CIM_NetworkPipe" }
        ,  { typeof ( MSFTNetTransportConnection ) ,  "MSFT_NetTransportConnection" }
        ,  { typeof ( MSFTNetTCPConnection ) ,  "MSFT_NetTCPConnection" }
        ,  { typeof ( MSFTNetUDPEndpoint ) ,  "MSFT_NetUDPEndpoint" }
        ,  { typeof ( MSFTNetImPlatAdapter ) ,  "MSFT_NetImPlatAdapter" }
        ,  { typeof ( MSFTNetSwitchTeamMember ) ,  "MSFT_NetSwitchTeamMember" }
        ,  { typeof ( MSFTNetLbfoTeamNic ) ,  "MSFT_NetLbfoTeamNic" }
        ,  { typeof ( MSFTNetLbfoTeamMember ) ,  "MSFT_NetLbfoTeamMember" }
        ,  { typeof ( CIMFilterEntryBase ) ,  "CIM_FilterEntryBase" }
        ,  { typeof ( MSFTNetServiceFilter ) ,  "MSFT_NetServiceFilter" }
        ,  { typeof ( MSFTNetApplicationFilter ) ,  "MSFT_NetApplicationFilter" }
        ,  { typeof ( MSFTNetInterfaceFilter ) ,  "MSFT_NetInterfaceFilter" }
        ,  { typeof ( MSFTNetTransportFilter ) ,  "MSFT_NetTransportFilter" }
        ,  { typeof ( MSFTNetInterfaceTypeFilter ) ,  "MSFT_NetInterfaceTypeFilter" }
        ,  { typeof ( MSFTNetNetworkLayerSecurityFilter ) ,  "MSFT_NetNetworkLayerSecurityFilter" }
        ,  { typeof ( MSFTNetAddressFilter ) ,  "MSFT_NetAddressFilter" }
        ,  { typeof ( MSFTNetProtocolPortFilter ) ,  "MSFT_NetProtocolPortFilter" }
        ,  { typeof ( MSFTNetBranchCacheStatus ) ,  "MSFT_NetBranchCacheStatus" }
        ,  { typeof ( MSFTNetBranchCacheCache ) ,  "MSFT_NetBranchCacheCache" }
        ,  { typeof ( MSFTNetBranchCacheSecondaryCache ) ,  "MSFT_NetBranchCacheSecondaryCache" }
        ,  { typeof ( MSFTNetBranchCacheDataCacheExtension ) ,  "MSFT_NetBranchCacheDataCacheExtension" }
        ,  { typeof ( MSFTNetBranchCachePrimaryCache ) ,  "MSFT_NetBranchCachePrimaryCache" }
        ,  { typeof ( MSFTNetBranchCacheDataCache ) ,  "MSFT_NetBranchCacheDataCache" }
        ,  { typeof ( MSFTNetBranchCacheHashCache ) ,  "MSFT_NetBranchCacheHashCache" }
        ,  { typeof ( MSFTPrintJob ) ,  "MSFT_PrintJob" }
        ,  { typeof ( MSFTPrinterDriver ) ,  "MSFT_PrinterDriver" }
        ,  { typeof ( MSFTPrinterPort ) ,  "MSFT_PrinterPort" }
        ,  { typeof ( MSFTWsdPrinterPort ) ,  "MSFT_WsdPrinterPort" }
        ,  { typeof ( MSFTLprPrinterPort ) ,  "MSFT_LprPrinterPort" }
        ,  { typeof ( MSFTTcpIpPrinterPort ) ,  "MSFT_TcpIpPrinterPort" }
        ,  { typeof ( MSFTLocalPrinterPort ) ,  "MSFT_LocalPrinterPort" }
        ,  { typeof ( CIMNextHopRoute ) ,  "CIM_NextHopRoute" }
        ,  { typeof ( MSFTNetRoute ) ,  "MSFT_NetRoute" }
        ,  { typeof ( CIMPolicy ) ,  "CIM_Policy" }
        ,  { typeof ( CIMPolicyAction ) ,  "CIM_PolicyAction" }
        ,  { typeof ( CIMSAAction ) ,  "CIM_SAAction" }
        ,  { typeof ( CIMSANegotiationAction ) ,  "CIM_SANegotiationAction" }
        ,  { typeof ( CIMIKEAction ) ,  "CIM_IKEAction" }
        ,  { typeof ( MSFTNetIKEAuthSet ) ,  "MSFT_NetIKEAuthSet" }
        ,  { typeof ( MSFTNetIKEP1AuthSet ) ,  "MSFT_NetIKEP1AuthSet" }
        ,  { typeof ( MSFTNetIKEP2AuthSet ) ,  "MSFT_NetIKEP2AuthSet" }
        ,  { typeof ( MSFTNetIKECryptoSet ) ,  "MSFT_NetIKECryptoSet" }
        ,  { typeof ( MSFTNetIKEMMCryptoSet ) ,  "MSFT_NetIKEMMCryptoSet" }
        ,  { typeof ( MSFTNetIKEQMCryptoSet ) ,  "MSFT_NetIKEQMCryptoSet" }
        ,  { typeof ( MSFTNetTCPSetting ) ,  "MSFT_NetTCPSetting" }
        ,  { typeof ( MSFTNetUDPSetting ) ,  "MSFT_NetUDPSetting" }
        ,  { typeof ( CIMPolicySet ) ,  "CIM_PolicySet" }
        ,  { typeof ( CIMPolicyRule ) ,  "CIM_PolicyRule" }
        ,  { typeof ( CIMSARule ) ,  "CIM_SARule" }
        ,  { typeof ( MSFTNetSARule ) ,  "MSFT_NetSARule" }
        ,  { typeof ( MSFTNetMainModeRule ) ,  "MSFT_NetMainModeRule" }
        ,  { typeof ( MSFTNetConSecRule ) ,  "MSFT_NetConSecRule" }
        ,  { typeof ( MSFTNetFirewallRule ) ,  "MSFT_NetFirewallRule" }
        ,  { typeof ( MSFTDNSClientCache ) ,  "MSFT_DNSClientCache" }
        ,  { typeof ( MSFTNetFirewallProfile ) ,  "MSFT_NetFirewallProfile" }
        ,  { typeof ( MSFTNetImPlatProvider ) ,  "MSFT_NetImPlatProvider" }
        ,  { typeof ( MSFTNetLbfoProvider ) ,  "MSFT_NetLbfoProvider" }
        ,  { typeof ( MSFTNetPrefixPolicy ) ,  "MSFT_NetPrefixPolicy" }
        ,  { typeof ( MSFTNetImPlatTeam ) ,  "MSFT_NetImPlatTeam" }
        ,  { typeof ( MSFTNetSwitchTeam ) ,  "MSFT_NetSwitchTeam" }
        ,  { typeof ( MSFTNetLbfoTeam ) ,  "MSFT_NetLbfoTeam" }
        ,  { typeof ( MSFTNetBranchCacheOrchestrator ) ,  "MSFT_NetBranchCacheOrchestrator" }
        ,  { typeof ( MSFTPrinterProperty ) ,  "MSFT_PrinterProperty" }
        ,  { typeof ( MSFTNetAdapterRdmaStatistics ) ,  "MSFT_NetAdapter_RdmaStatistics" }
        ,  { typeof ( MSFTNetAdapterUdpSegmentationOffloadCapabilities ) ,  "MSFT_NetAdapterUdpSegmentationOffloadCapabilities" }
        ,  { typeof ( MSFTNetAdapterRscStatistics ) ,  "MSFT_NetAdapter_RscStatistics" }
        ,  { typeof ( MSFTNetAdapterUsoEncapsulationTypes ) ,  "MSFT_NetAdapterUsoEncapsulationTypes" }
        ,  { typeof ( NotifyStatus ) ,  "__NotifyStatus" }
        ,  { typeof ( ExtendedStatus ) ,  "__ExtendedStatus" }
        ,  { typeof ( SecurityRelatedClass ) ,  "__SecurityRelatedClass" }
        ,  { typeof ( Trustee ) ,  "__Trustee" }
        ,  { typeof ( NTLMUser9X ) ,  "__NTLMUser9X" }
        ,  { typeof ( ACE ) ,  "__ACE" }
        ,  { typeof ( SecurityDescriptor ) ,  "__SecurityDescriptor" }
        ,  { typeof ( PARAMETERS ) ,  "__PARAMETERS" }
        ,  { typeof ( MSFTNetAdapterLargeSendOffloadV2Capabilities ) ,  "MSFT_NetAdapterLargeSendOffloadV2Capabilities" }
        ,  { typeof ( MSFTPrinterPortTasks ) ,  "MSFT_PrinterPortTasks" }
        ,  { typeof ( MSFTNetAdapterRssProcessor ) ,  "MSFT_NetAdapter_RssProcessor" }
        ,  { typeof ( MSFTNetAdapterQosSettings ) ,  "MSFT_NetAdapter_QosSettings" }
        ,  { typeof ( MSFTNetAdapterRdmaAdapterInfo ) ,  "MSFT_NetAdapter_RdmaAdapterInfo" }
        ,  { typeof ( MSFTNetAdapterPowerManagementOffload ) ,  "MSFT_NetAdapterPowerManagement_Offload" }
        ,  { typeof ( MSFTNetAdapterPowerManagementOffloadRsnRekey ) ,  "MSFT_NetAdapterPowerManagement_Offload_RsnRekey" }
        ,  { typeof ( MSFTNetAdapterPowerManagementOffloadArp ) ,  "MSFT_NetAdapterPowerManagement_Offload_Arp" }
        ,  { typeof ( MSFTNetAdapterPowerManagementOffloadNS ) ,  "MSFT_NetAdapterPowerManagement_Offload_NS" }
        ,  { typeof ( MSFTNetAdapterRscCapabilities ) ,  "MSFT_NetAdapterRscCapabilities" }
        ,  { typeof ( MSFTNetAdapterLargeSendOffloadV1Capabilities ) ,  "MSFT_NetAdapterLargeSendOffloadV1Capabilities" }
        ,  { typeof ( MSFTNetAdapterGroupAffinity ) ,  "MSFT_NetAdapter_Group_Affinity" }
        ,  { typeof ( MSFTPrinterConfiguration ) ,  "MSFT_PrinterConfiguration" }
        ,  { typeof ( MSFTPrinterNfcTagTasks ) ,  "MSFT_PrinterNfcTagTasks" }
        ,  { typeof ( MSFTNetAdapterRdmaMissingCounterInfo ) ,  "MSFT_NetAdapter_RdmaMissingCounterInfo" }
        ,  { typeof ( MSFTNetAdapterChecksumOffloadCapabilities ) ,  "MSFT_NetAdapterChecksumOffloadCapabilities" }
        ,  { typeof ( MSFTNetAdapterLsoEncapsulationTypes ) ,  "MSFT_NetAdapterLsoEncapsulationTypes" }
        ,  { typeof ( MSFTNetAdapterQosCapabilities ) ,  "MSFT_NetAdapter_QosCapabilities" }
        ,  { typeof ( MSFTNetAdapterQosClassificationElement ) ,  "MSFT_NetAdapter_QosClassificationElement" }
        ,  { typeof ( MSFTNetAdapterProcessorNumber ) ,  "MSFT_NetAdapter_ProcessorNumber" }
        ,  { typeof ( MSFTNetAdapterSriovCapabilities ) ,  "MSFT_NetAdapterSriovCapabilities" }
        ,  { typeof ( MSFTNetAdapterVmqFilter ) ,  "MSFT_NetAdapter_VmqFilter" }
        ,  { typeof ( MSFTNetIPsecIdentity ) ,  "MSFT_NetIPsecIdentity" }
        ,  { typeof ( MSFTNetAdapterChecksumOffloadEncapsulationTypes ) ,  "MSFT_NetAdapterChecksumOffloadEncapsulationTypes" }
        ,  { typeof ( MSFTNetAdapterPowerManagementWakePattern ) ,  "MSFT_NetAdapterPowerManagement_WakePattern" }
        ,  { typeof ( MSFTNetAdapterPowerManagementWakePatternWildCard ) ,  "MSFT_NetAdapterPowerManagement_WakePattern_WildCard" }
        ,  { typeof ( MSFTNetAdapterPowerManagementWakePatternTcpSyn ) ,  "MSFT_NetAdapterPowerManagement_WakePattern_TcpSyn" }
        ,  { typeof ( MSFTNetAdapterPowerManagementWakePatternBitmap ) ,  "MSFT_NetAdapterPowerManagement_WakePattern_Bitmap" }
        ,  { typeof ( MSFTNetAdapterPowerManagementWakePatternMagicPacket ) ,  "MSFT_NetAdapterPowerManagement_WakePattern_MagicPacket" }
        ,  { typeof ( MSFTNetAdapterPowerManagementWakePatternEapolRequestId ) ,  "MSFT_NetAdapterPowerManagement_WakePattern_EapolRequestId" }
        ,  { typeof ( MSFTPrinterNfcTag ) ,  "MSFT_PrinterNfcTag" }
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