using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;

namespace SimCim.StandardCimV2
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
            public CIMElementSettingDataAssociation CIMElementSettingData => new CIMElementSettingDataAssociation(_scope);
            public MSFTNetTeredoStateAssociation MSFTNetTeredoState => new MSFTNetTeredoStateAssociation(_scope);
            public MSFTNetDnsTransitionInterfaceAssociationAssociation MSFTNetDnsTransitionInterfaceAssociation => new MSFTNetDnsTransitionInterfaceAssociationAssociation(_scope);
            public MSFTNet6to4StateAssociation MSFTNet6to4State => new MSFTNet6to4StateAssociation(_scope);
            public MSFTNetNatTransitionInterfaceAssociationAssociation MSFTNetNatTransitionInterfaceAssociation => new MSFTNetNatTransitionInterfaceAssociationAssociation(_scope);
            public MSFTNetISATAPStateAssociation MSFTNetISATAPState => new MSFTNetISATAPStateAssociation(_scope);
            public MSFTNetIPHttpsStateAssociation MSFTNetIPHttpsState => new MSFTNetIPHttpsStateAssociation(_scope);
            public MSFTNetAdapterElementSettingDataAssociation MSFTNetAdapterElementSettingData => new MSFTNetAdapterElementSettingDataAssociation(_scope);
            public MSFTNetAdapterPacketDirectElementSettingAssociation MSFTNetAdapterPacketDirectElementSetting => new MSFTNetAdapterPacketDirectElementSettingAssociation(_scope);
            public MSFTNetAdapterLsoElementSettingAssociation MSFTNetAdapterLsoElementSetting => new MSFTNetAdapterLsoElementSettingAssociation(_scope);
            public MSFTNetAdapterAdvancedPropertyElementSettingAssociation MSFTNetAdapterAdvancedPropertyElementSetting => new MSFTNetAdapterAdvancedPropertyElementSettingAssociation(_scope);
            public MSFTNetAdapterSriovVfElementSettingAssociation MSFTNetAdapterSriovVfElementSetting => new MSFTNetAdapterSriovVfElementSettingAssociation(_scope);
            public MSFTNetAdapterQosElementSettingAssociation MSFTNetAdapterQosElementSetting => new MSFTNetAdapterQosElementSettingAssociation(_scope);
            public MSFTNetAdapterIPsecOffloadV2ElementSettingAssociation MSFTNetAdapterIPsecOffloadV2ElementSetting => new MSFTNetAdapterIPsecOffloadV2ElementSettingAssociation(_scope);
            public MSFTNetAdapterChecksumOffloadElementSettingAssociation MSFTNetAdapterChecksumOffloadElementSetting => new MSFTNetAdapterChecksumOffloadElementSettingAssociation(_scope);
            public MSFTNetAdapterRssElementSettingAssociation MSFTNetAdapterRssElementSetting => new MSFTNetAdapterRssElementSettingAssociation(_scope);
            public MSFTNetAdapterStatisticsElementSettingAssociation MSFTNetAdapterStatisticsElementSetting => new MSFTNetAdapterStatisticsElementSettingAssociation(_scope);
            public MSFTNetAdapterVmqQueueElementSettingAssociation MSFTNetAdapterVmqQueueElementSetting => new MSFTNetAdapterVmqQueueElementSettingAssociation(_scope);
            public MSFTNetAdapterRdmaElementSettingAssociation MSFTNetAdapterRdmaElementSetting => new MSFTNetAdapterRdmaElementSettingAssociation(_scope);
            public MSFTNetAdapterEncapsulatedPacketTaskOffloadElementSettingAssociation MSFTNetAdapterEncapsulatedPacketTaskOffloadElementSetting => new MSFTNetAdapterEncapsulatedPacketTaskOffloadElementSettingAssociation(_scope);
            public MSFTNetAdapterBindingElementSettingAssociation MSFTNetAdapterBindingElementSetting => new MSFTNetAdapterBindingElementSettingAssociation(_scope);
            public MSFTNetAdapterRscElementSettingAssociation MSFTNetAdapterRscElementSetting => new MSFTNetAdapterRscElementSettingAssociation(_scope);
            public MSFTNetAdapterVPortElementSettingAssociation MSFTNetAdapterVPortElementSetting => new MSFTNetAdapterVPortElementSettingAssociation(_scope);
            public MSFTNetAdapterHardwareInfoElementSettingAssociation MSFTNetAdapterHardwareInfoElementSetting => new MSFTNetAdapterHardwareInfoElementSettingAssociation(_scope);
            public MSFTNetAdapterVmqElementSettingAssociation MSFTNetAdapterVmqElementSetting => new MSFTNetAdapterVmqElementSettingAssociation(_scope);
            public MSFTNetAdapterSriovElementSettingAssociation MSFTNetAdapterSriovElementSetting => new MSFTNetAdapterSriovElementSettingAssociation(_scope);
            public MSFTNetAdapterPowerManagementElementSettingAssociation MSFTNetAdapterPowerManagementElementSetting => new MSFTNetAdapterPowerManagementElementSettingAssociation(_scope);
            public MSFTNetAdapterUsoElementSettingAssociation MSFTNetAdapterUsoElementSetting => new MSFTNetAdapterUsoElementSettingAssociation(_scope);
            public MSFTNetLbfoTeamTeamNicAssociation MSFTNetLbfoTeamTeamNic => new MSFTNetLbfoTeamTeamNicAssociation(_scope);
            public MSFTNetEventCaptureTargetCaptureProviderAssociation MSFTNetEventCaptureTargetCaptureProvider => new MSFTNetEventCaptureTargetCaptureProviderAssociation(_scope);
            public MSFTNetLbfoTeamTeamMemberAssociation MSFTNetLbfoTeamTeamMember => new MSFTNetLbfoTeamTeamMemberAssociation(_scope);
            public MSFTNetEventSessionProviderAssociation MSFTNetEventSessionProvider => new MSFTNetEventSessionProviderAssociation(_scope);
            public CIMPolicyActionInPolicyRuleAssociation CIMPolicyActionInPolicyRule => new CIMPolicyActionInPolicyRuleAssociation(_scope);
            public MSFTNetSAActionInSARuleAssociation MSFTNetSAActionInSARule => new MSFTNetSAActionInSARuleAssociation(_scope);
            public MSFTNetSARuleQMCryptoAssociation MSFTNetSARuleQMCrypto => new MSFTNetSARuleQMCryptoAssociation(_scope);
            public MSFTNetConSecRuleQMCryptoSetAssociation MSFTNetConSecRuleQMCryptoSet => new MSFTNetConSecRuleQMCryptoSetAssociation(_scope);
            public MSFTNetSARuleMMAuthAssociation MSFTNetSARuleMMAuth => new MSFTNetSARuleMMAuthAssociation(_scope);
            public MSFTNetConSecRuleMMAuthSetAssociation MSFTNetConSecRuleMMAuthSet => new MSFTNetConSecRuleMMAuthSetAssociation(_scope);
            public MSFTNetMainModeRuleMMAuthSetAssociation MSFTNetMainModeRuleMMAuthSet => new MSFTNetMainModeRuleMMAuthSetAssociation(_scope);
            public MSFTNetSARuleMMCryptoAssociation MSFTNetSARuleMMCrypto => new MSFTNetSARuleMMCryptoAssociation(_scope);
            public MSFTNetMainModeRuleMMCryptoSetAssociation MSFTNetMainModeRuleMMCryptoSet => new MSFTNetMainModeRuleMMCryptoSetAssociation(_scope);
            public MSFTNetSARuleEMAuthAssociation MSFTNetSARuleEMAuth => new MSFTNetSARuleEMAuthAssociation(_scope);
            public MSFTNetConSecRuleEMAuthSetAssociation MSFTNetConSecRuleEMAuthSet => new MSFTNetConSecRuleEMAuthSetAssociation(_scope);
            public CIMPolicySetComponentAssociation CIMPolicySetComponent => new CIMPolicySetComponentAssociation(_scope);
            public MSFTNetRuleInProfileAssociation MSFTNetRuleInProfile => new MSFTNetRuleInProfileAssociation(_scope);
            public MSFTNetConSecRuleInProfileAssociation MSFTNetConSecRuleInProfile => new MSFTNetConSecRuleInProfileAssociation(_scope);
            public MSFTNetMainModeRuleInProfileAssociation MSFTNetMainModeRuleInProfile => new MSFTNetMainModeRuleInProfileAssociation(_scope);
            public MSFTNetFirewallRuleInProfileAssociation MSFTNetFirewallRuleInProfile => new MSFTNetFirewallRuleInProfileAssociation(_scope);
            public MSFTNetLbfoTeamProviderAssociation MSFTNetLbfoTeamProvider => new MSFTNetLbfoTeamProviderAssociation(_scope);
            public MSFTNetPolicyRuleFiltersAssociation MSFTNetPolicyRuleFilters => new MSFTNetPolicyRuleFiltersAssociation(_scope);
            public MSFTNetMainModeRuleFiltersAssociation MSFTNetMainModeRuleFilters => new MSFTNetMainModeRuleFiltersAssociation(_scope);
            public MSFTNetMainModeRuleFilterByAddressAssociation MSFTNetMainModeRuleFilterByAddress => new MSFTNetMainModeRuleFilterByAddressAssociation(_scope);
            public MSFTNetConSecRuleFiltersAssociation MSFTNetConSecRuleFilters => new MSFTNetConSecRuleFiltersAssociation(_scope);
            public MSFTNetConSecRuleFilterByInterfaceTypeAssociation MSFTNetConSecRuleFilterByInterfaceType => new MSFTNetConSecRuleFilterByInterfaceTypeAssociation(_scope);
            public MSFTNetConSecRuleFilterByProtocolPortAssociation MSFTNetConSecRuleFilterByProtocolPort => new MSFTNetConSecRuleFilterByProtocolPortAssociation(_scope);
            public MSFTNetConSecRuleFilterByInterfaceAssociation MSFTNetConSecRuleFilterByInterface => new MSFTNetConSecRuleFilterByInterfaceAssociation(_scope);
            public MSFTNetConSecRuleFilterByAddressAssociation MSFTNetConSecRuleFilterByAddress => new MSFTNetConSecRuleFilterByAddressAssociation(_scope);
            public MSFTNetFirewallRuleFiltersAssociation MSFTNetFirewallRuleFilters => new MSFTNetFirewallRuleFiltersAssociation(_scope);
            public MSFTNetFirewallRuleFilterBySecurityAssociation MSFTNetFirewallRuleFilterBySecurity => new MSFTNetFirewallRuleFilterBySecurityAssociation(_scope);
            public MSFTNetFirewallRuleFilterByInterfaceAssociation MSFTNetFirewallRuleFilterByInterface => new MSFTNetFirewallRuleFilterByInterfaceAssociation(_scope);
            public MSFTNetFirewallRuleFilterByServiceAssociation MSFTNetFirewallRuleFilterByService => new MSFTNetFirewallRuleFilterByServiceAssociation(_scope);
            public MSFTNetFirewallRuleFilterByProtocolPortAssociation MSFTNetFirewallRuleFilterByProtocolPort => new MSFTNetFirewallRuleFilterByProtocolPortAssociation(_scope);
            public MSFTNetFirewallRuleFilterByInterfaceTypeAssociation MSFTNetFirewallRuleFilterByInterfaceType => new MSFTNetFirewallRuleFilterByInterfaceTypeAssociation(_scope);
            public MSFTNetFirewallRuleFilterByApplicationAssociation MSFTNetFirewallRuleFilterByApplication => new MSFTNetFirewallRuleFilterByApplicationAssociation(_scope);
            public MSFTNetFirewallRuleFilterByAddressAssociation MSFTNetFirewallRuleFilterByAddress => new MSFTNetFirewallRuleFilterByAddressAssociation(_scope);
            public MSFTNetSwitchTeamTeamMemberAssociation MSFTNetSwitchTeamTeamMember => new MSFTNetSwitchTeamTeamMemberAssociation(_scope);
            public CIMSAPSAPDependencyAssociation CIMSAPSAPDependency => new CIMSAPSAPDependencyAssociation(_scope);
            public CIMBindsToAssociation CIMBindsTo => new CIMBindsToAssociation(_scope);
            public CIMBindsToLANEndpointAssociation CIMBindsToLANEndpoint => new CIMBindsToLANEndpointAssociation(_scope);
            public MSFTNetIPInterfaceIPAddressAssociation MSFTNetIPInterfaceIPAddress => new MSFTNetIPInterfaceIPAddressAssociation(_scope);
            public MSFTNetIPInterfaceNeighborAssociation MSFTNetIPInterfaceNeighbor => new MSFTNetIPInterfaceNeighborAssociation(_scope);
            public MSFTNetTransportFilterTCPSettingAssociation MSFTNetTransportFilterTCPSetting => new MSFTNetTransportFilterTCPSettingAssociation(_scope);
            public CIMPhase1SAUsedForPhase2Association CIMPhase1SAUsedForPhase2 => new CIMPhase1SAUsedForPhase2Association(_scope);
            public MSFTNetSAAssociationAssociation MSFTNetSAAssociation => new MSFTNetSAAssociationAssociation(_scope);
            public CIMDeviceSAPImplementationAssociation CIMDeviceSAPImplementation => new CIMDeviceSAPImplementationAssociation(_scope);
            public CIMPortImplementsEndpointAssociation CIMPortImplementsEndpoint => new CIMPortImplementsEndpointAssociation(_scope);
            public MSFTNetIPInterfaceAdapterAssociation MSFTNetIPInterfaceAdapter => new MSFTNetIPInterfaceAdapterAssociation(_scope);
            public CIMRouteUsesEndpointAssociation CIMRouteUsesEndpoint => new CIMRouteUsesEndpointAssociation(_scope);
            public MSFTNetIPInterfaceRouteAssociation MSFTNetIPInterfaceRoute => new MSFTNetIPInterfaceRouteAssociation(_scope);
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

        public static IObservable<BookmarkedEvent<InstanceOperationEvent>> SubscribeToInstanceOperationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<InstanceOperationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<InstanceCreationEvent>> SubscribeToInstanceCreationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<InstanceCreationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MethodInvocationEvent>> SubscribeToMethodInvocationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MethodInvocationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<InstanceModificationEvent>> SubscribeToInstanceModificationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<InstanceModificationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<InstanceDeletionEvent>> SubscribeToInstanceDeletionEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<InstanceDeletionEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<TimerEvent>> SubscribeToTimerEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<TimerEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<ExtrinsicEvent>> SubscribeToExtrinsicEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<ExtrinsicEvent>(pollingIntervalSeconds, wqlFilter, options);
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

        public static SystemSecurity GetSystemSecurity(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<SystemSecurity>().Single();
        }

        public static Task<SystemSecurity> GetSystemSecurityAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<SystemSecurity>(options).ToTask();
        }
    }
}