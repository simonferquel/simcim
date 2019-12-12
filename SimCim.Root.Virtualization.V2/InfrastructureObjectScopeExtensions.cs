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
        public static IInfrastructureObjectScope WithSimCimRootVirtualizationV2(this IInfrastructureObjectScope scope)
        {
            scope.Mapper.AddNamespaceMapper("root/virtualization/v2", new InfrastructureObjectMapper(scope));
            return scope;
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