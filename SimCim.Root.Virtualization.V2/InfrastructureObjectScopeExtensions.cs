using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;

namespace SimCim.Root.Virtualization.V2
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
            public MsvmCollectedVirtualSystemsAssociation MsvmCollectedVirtualSystems => new MsvmCollectedVirtualSystemsAssociation(_scope);
            public MsvmCollectedSnapshotsAssociation MsvmCollectedSnapshots => new MsvmCollectedSnapshotsAssociation(_scope);
            public MsvmCollectedCollectionsAssociation MsvmCollectedCollections => new MsvmCollectedCollectionsAssociation(_scope);
            public MsvmCollectedReferencePointsAssociation MsvmCollectedReferencePoints => new MsvmCollectedReferencePointsAssociation(_scope);
            public MsvmHostedResourcePoolAssociation MsvmHostedResourcePool => new MsvmHostedResourcePoolAssociation(_scope);
            public MsvmSystemBIOSAssociation MsvmSystemBIOS => new MsvmSystemBIOSAssociation(_scope);
            public MsvmSystemComponentAssociation MsvmSystemComponent => new MsvmSystemComponentAssociation(_scope);
            public MsvmSystemDeviceAssociation MsvmSystemDevice => new MsvmSystemDeviceAssociation(_scope);
            public MsvmBootSourceComponentAssociation MsvmBootSourceComponent => new MsvmBootSourceComponentAssociation(_scope);
            public MsvmConcreteComponentAssociation MsvmConcreteComponent => new MsvmConcreteComponentAssociation(_scope);
            public MsvmSettingsDefineCapabilitiesAssociation MsvmSettingsDefineCapabilities => new MsvmSettingsDefineCapabilitiesAssociation(_scope);
            public MsvmFeatureSettingsDefineCapabilitiesAssociation MsvmFeatureSettingsDefineCapabilities => new MsvmFeatureSettingsDefineCapabilitiesAssociation(_scope);
            public MsvmVirtualSystemSettingDataComponentAssociation MsvmVirtualSystemSettingDataComponent => new MsvmVirtualSystemSettingDataComponentAssociation(_scope);
            public MsvmGuestServiceInterfaceSettingDataComponentAssociation MsvmGuestServiceInterfaceSettingDataComponent => new MsvmGuestServiceInterfaceSettingDataComponentAssociation(_scope);
            public MsvmSettingDataComponentAssociation MsvmSettingDataComponent => new MsvmSettingDataComponentAssociation(_scope);
            public MsvmEthernetPortFailoverSettingDataComponentAssociation MsvmEthernetPortFailoverSettingDataComponent => new MsvmEthernetPortFailoverSettingDataComponentAssociation(_scope);
            public MsvmEthernetPortSettingDataComponentAssociation MsvmEthernetPortSettingDataComponent => new MsvmEthernetPortSettingDataComponentAssociation(_scope);
            public MsvmVirtualEthernetSwitchSettingDataComponentAssociation MsvmVirtualEthernetSwitchSettingDataComponent => new MsvmVirtualEthernetSwitchSettingDataComponentAssociation(_scope);
            public MsvmVirtualSystemMigrationServiceSettingDataComponentAssociation MsvmVirtualSystemMigrationServiceSettingDataComponent => new MsvmVirtualSystemMigrationServiceSettingDataComponentAssociation(_scope);
            public MsvmSystemTerminalConnectionAssociation MsvmSystemTerminalConnection => new MsvmSystemTerminalConnectionAssociation(_scope);
            public MsvmHostedServiceAssociation MsvmHostedService => new MsvmHostedServiceAssociation(_scope);
            public MsvmHostedSwitchServiceAssociation MsvmHostedSwitchService => new MsvmHostedSwitchServiceAssociation(_scope);
            public MsvmHostedDependencyAssociation MsvmHostedDependency => new MsvmHostedDependencyAssociation(_scope);
            public MsvmSerialPortOnSerialControllerAssociation MsvmSerialPortOnSerialController => new MsvmSerialPortOnSerialControllerAssociation(_scope);
            public MsvmVideoHeadOnControllerAssociation MsvmVideoHeadOnController => new MsvmVideoHeadOnControllerAssociation(_scope);
            public MsvmHostedEthernetSwitchExtensionAssociation MsvmHostedEthernetSwitchExtension => new MsvmHostedEthernetSwitchExtensionAssociation(_scope);
            public MsvmReferencePointOfVirtualSystemAssociation MsvmReferencePointOfVirtualSystem => new MsvmReferencePointOfVirtualSystemAssociation(_scope);
            public MsvmSystemReplicationRelationshipAssociation MsvmSystemReplicationRelationship => new MsvmSystemReplicationRelationshipAssociation(_scope);
            public MsvmSnapshotOfVirtualSystemAssociation MsvmSnapshotOfVirtualSystem => new MsvmSnapshotOfVirtualSystemAssociation(_scope);
            public MsvmComputerSystemSummaryInformationAssociation MsvmComputerSystemSummaryInformation => new MsvmComputerSystemSummaryInformationAssociation(_scope);
            public MsvmLastAppliedSnapshotAssociation MsvmLastAppliedSnapshot => new MsvmLastAppliedSnapshotAssociation(_scope);
            public CIMMostCurrentSnapshotInBranchAssociation CIMMostCurrentSnapshotInBranch => new CIMMostCurrentSnapshotInBranchAssociation(_scope);
            public MsvmMostCurrentSnapshotInBranchAssociation MsvmMostCurrentSnapshotInBranch => new MsvmMostCurrentSnapshotInBranchAssociation(_scope);
            public MsvmReplicaSystemDependencyAssociation MsvmReplicaSystemDependency => new MsvmReplicaSystemDependencyAssociation(_scope);
            public MsvmElementAllocatedFromNumaNodeAssociation MsvmElementAllocatedFromNumaNode => new MsvmElementAllocatedFromNumaNodeAssociation(_scope);
            public MsvmElementAllocatedFromPoolAssociation MsvmElementAllocatedFromPool => new MsvmElementAllocatedFromPoolAssociation(_scope);
            public MsvmMetricDefForMEAssociation MsvmMetricDefForME => new MsvmMetricDefForMEAssociation(_scope);
            public MsvmMetricCollectionDependencyAssociation MsvmMetricCollectionDependency => new MsvmMetricCollectionDependencyAssociation(_scope);
            public MsvmMetricForMEAssociation MsvmMetricForME => new MsvmMetricForMEAssociation(_scope);
            public MsvmConcreteDependencyAssociation MsvmConcreteDependency => new MsvmConcreteDependencyAssociation(_scope);
            public MsvmParentChildSettingDataAssociation MsvmParentChildSettingData => new MsvmParentChildSettingDataAssociation(_scope);
            public MsvmResourceAllocationFromPoolAssociation MsvmResourceAllocationFromPool => new MsvmResourceAllocationFromPoolAssociation(_scope);
            public MsvmResourceDependentOnResourceAssociation MsvmResourceDependentOnResource => new MsvmResourceDependentOnResourceAssociation(_scope);
            public MsvmActiveConnectionAssociation MsvmActiveConnection => new MsvmActiveConnectionAssociation(_scope);
            public MsvmFcActiveConnectionAssociation MsvmFcActiveConnection => new MsvmFcActiveConnectionAssociation(_scope);
            public MsvmBindsToLANEndpointAssociation MsvmBindsToLANEndpoint => new MsvmBindsToLANEndpointAssociation(_scope);
            public MsvmSwitchPortDynamicForwardingAssociation MsvmSwitchPortDynamicForwarding => new MsvmSwitchPortDynamicForwardingAssociation(_scope);
            public MsvmServiceOfVssComponentAssociation MsvmServiceOfVssComponent => new MsvmServiceOfVssComponentAssociation(_scope);
            public MsvmProtocolControllerForUnitAssociation MsvmProtocolControllerForUnit => new MsvmProtocolControllerForUnitAssociation(_scope);
            public MsvmReferencePointOfVirtualSystemCollectionAssociation MsvmReferencePointOfVirtualSystemCollection => new MsvmReferencePointOfVirtualSystemCollectionAssociation(_scope);
            public MsvmVirtualEthernetSwitchNicTeamingMemberAssociation MsvmVirtualEthernetSwitchNicTeamingMember => new MsvmVirtualEthernetSwitchNicTeamingMemberAssociation(_scope);
            public MsvmEthernetDeviceSAPImplementationAssociation MsvmEthernetDeviceSAPImplementation => new MsvmEthernetDeviceSAPImplementationAssociation(_scope);
            public MsvmWiFiDeviceSAPImplementationAssociation MsvmWiFiDeviceSAPImplementation => new MsvmWiFiDeviceSAPImplementationAssociation(_scope);
            public MsvmFcDeviceSAPImplementationAssociation MsvmFcDeviceSAPImplementation => new MsvmFcDeviceSAPImplementationAssociation(_scope);
            public MsvmDeviceSAPImplementationAssociation MsvmDeviceSAPImplementation => new MsvmDeviceSAPImplementationAssociation(_scope);
            public MsvmMetricInstanceAssociation MsvmMetricInstance => new MsvmMetricInstanceAssociation(_scope);
            public MsvmParentEthernetSwitchExtensionAssociation MsvmParentEthernetSwitchExtension => new MsvmParentEthernetSwitchExtensionAssociation(_scope);
            public MsvmEthernetSwitchInfoAssociation MsvmEthernetSwitchInfo => new MsvmEthernetSwitchInfoAssociation(_scope);
            public MsvmBasedOnAssociation MsvmBasedOn => new MsvmBasedOnAssociation(_scope);
            public MsvmRegisteredGuestServiceAssociation MsvmRegisteredGuestService => new MsvmRegisteredGuestServiceAssociation(_scope);
            public MsvmControlledByAssociation MsvmControlledBy => new MsvmControlledByAssociation(_scope);
            public MsvmSnapshotOfVirtualSystemCollectionAssociation MsvmSnapshotOfVirtualSystemCollection => new MsvmSnapshotOfVirtualSystemCollectionAssociation(_scope);
            public MsvmEthernetPortInfoAssociation MsvmEthernetPortInfo => new MsvmEthernetPortInfoAssociation(_scope);
            public MsvmMediaPresentAssociation MsvmMediaPresent => new MsvmMediaPresentAssociation(_scope);
            public MsvmTransparentBridgingDynamicForwardingAssociation MsvmTransparentBridgingDynamicForwarding => new MsvmTransparentBridgingDynamicForwardingAssociation(_scope);
            public MsvmElementConformsToProfileAssociation MsvmElementConformsToProfile => new MsvmElementConformsToProfileAssociation(_scope);
            public MsvmSystemExportSettingDataAssociation MsvmSystemExportSettingData => new MsvmSystemExportSettingDataAssociation(_scope);
            public MsvmElementSettingDataAssociation MsvmElementSettingData => new MsvmElementSettingDataAssociation(_scope);
            public MsvmAffectedStorageJobElementAssociation MsvmAffectedStorageJobElement => new MsvmAffectedStorageJobElementAssociation(_scope);
            public MsvmAffectedJobElementAssociation MsvmAffectedJobElement => new MsvmAffectedJobElementAssociation(_scope);
            public MsvmLogicalIdentityAssociation MsvmLogicalIdentity => new MsvmLogicalIdentityAssociation(_scope);
            public MsvmSettingsDefineStateAssociation MsvmSettingsDefineState => new MsvmSettingsDefineStateAssociation(_scope);
            public MsvmServiceAffectsElementAssociation MsvmServiceAffectsElement => new MsvmServiceAffectsElementAssociation(_scope);
            public MsvmElementCapabilitiesAssociation MsvmElementCapabilities => new MsvmElementCapabilitiesAssociation(_scope);
            public MsvmEthernetSwitchExtensionCapabilitiesAssociation MsvmEthernetSwitchExtensionCapabilities => new MsvmEthernetSwitchExtensionCapabilitiesAssociation(_scope);
            public MsvmOwningJobElementAssociation MsvmOwningJobElement => new MsvmOwningJobElementAssociation(_scope);
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

        public static IObservable<BookmarkedEvent<InstanceOperationEvent>> SubscribeToInstanceOperationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<InstanceOperationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<InstanceCreationEvent>> SubscribeToInstanceCreationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<InstanceCreationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<InstanceDeletionEvent>> SubscribeToInstanceDeletionEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<InstanceDeletionEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<InstanceModificationEvent>> SubscribeToInstanceModificationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<InstanceModificationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MethodInvocationEvent>> SubscribeToMethodInvocationEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MethodInvocationEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<ExtrinsicEvent>> SubscribeToExtrinsicEvent(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<ExtrinsicEvent>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<CIMIndication>> SubscribeToCIMIndication(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<CIMIndication>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<CIMProcessIndication>> SubscribeToCIMProcessIndication(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<CIMProcessIndication>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<CIMAlertIndication>> SubscribeToCIMAlertIndication(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<CIMAlertIndication>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<MsvmStorageAlert>> SubscribeToMsvmStorageAlert(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<MsvmStorageAlert>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<CIMClassIndication>> SubscribeToCIMClassIndication(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<CIMClassIndication>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<CIMClassDeletion>> SubscribeToCIMClassDeletion(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<CIMClassDeletion>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<CIMClassCreation>> SubscribeToCIMClassCreation(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<CIMClassCreation>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<CIMClassModification>> SubscribeToCIMClassModification(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<CIMClassModification>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<CIMInstIndication>> SubscribeToCIMInstIndication(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<CIMInstIndication>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<CIMInstCreation>> SubscribeToCIMInstCreation(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<CIMInstCreation>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<CIMInstModification>> SubscribeToCIMInstModification(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<CIMInstModification>(pollingIntervalSeconds, wqlFilter, options);
        }

        public static IObservable<BookmarkedEvent<CIMInstDeletion>> SubscribeToCIMInstDeletion(this IInfrastructureObjectScope scope, double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null)
        {
            return scope.SubscribeToEvents<CIMInstDeletion>(pollingIntervalSeconds, wqlFilter, options);
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

        public static MsvmServicingSettings GetMsvmServicingSettings(this IInfrastructureObjectScope scope)
        {
            return scope.EnumerateInstances<MsvmServicingSettings>().Single();
        }

        public static Task<MsvmServicingSettings> GetMsvmServicingSettingsAsync(this IInfrastructureObjectScope scope, CimOperationOptions options = null)
        {
            return scope.EnumerateInstancesAsync<MsvmServicingSettings>(options).ToTask();
        }
    }
}