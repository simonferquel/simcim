using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataASPNETASPNETApplications : Win32PerfRawData
    {
        public Win32PerfRawDataASPNETASPNETApplications()
        {
        }

        public Win32PerfRawDataASPNETASPNETApplications(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AnonymousRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AnonymousRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("AnonymousRequests", value);
            }
        }

        public System.UInt32? AnonymousRequestsPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AnonymousRequestsPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AnonymousRequestsPerSec", value);
            }
        }

        public System.UInt32? ApplicationLifetimeEvents
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ApplicationLifetimeEvents", out result);
                return result;
            }

            set
            {
                this.SetProperty("ApplicationLifetimeEvents", value);
            }
        }

        public System.UInt32? ApplicationLifetimeEventsPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ApplicationLifetimeEventsPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ApplicationLifetimeEventsPerSec", value);
            }
        }

        public System.UInt32? AuditFailureEventsRaised
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AuditFailureEventsRaised", out result);
                return result;
            }

            set
            {
                this.SetProperty("AuditFailureEventsRaised", value);
            }
        }

        public System.UInt32? AuditSuccessEventsRaised
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AuditSuccessEventsRaised", out result);
                return result;
            }

            set
            {
                this.SetProperty("AuditSuccessEventsRaised", value);
            }
        }

        public System.UInt32? CacheAPIEntries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheAPIEntries", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheAPIEntries", value);
            }
        }

        public System.UInt32? CacheAPIHitRatio
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheAPIHitRatio", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheAPIHitRatio", value);
            }
        }

        public System.UInt32? CacheAPIHitRatioBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheAPIHitRatio_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheAPIHitRatio_Base", value);
            }
        }

        public System.UInt32? CacheAPIHits
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheAPIHits", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheAPIHits", value);
            }
        }

        public System.UInt32? CacheAPIMisses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheAPIMisses", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheAPIMisses", value);
            }
        }

        public System.UInt32? CacheAPITrims
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheAPITrims", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheAPITrims", value);
            }
        }

        public System.UInt32? CacheAPITurnoverRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheAPITurnoverRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheAPITurnoverRate", value);
            }
        }

        public System.UInt32? CachePercentMachineMemoryLimitUsed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CachePercentMachineMemoryLimitUsed", out result);
                return result;
            }

            set
            {
                this.SetProperty("CachePercentMachineMemoryLimitUsed", value);
            }
        }

        public System.UInt32? CachePercentMachineMemoryLimitUsedBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CachePercentMachineMemoryLimitUsed_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("CachePercentMachineMemoryLimitUsed_Base", value);
            }
        }

        public System.UInt32? CachePercentProcessMemoryLimitUsed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CachePercentProcessMemoryLimitUsed", out result);
                return result;
            }

            set
            {
                this.SetProperty("CachePercentProcessMemoryLimitUsed", value);
            }
        }

        public System.UInt32? CachePercentProcessMemoryLimitUsedBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CachePercentProcessMemoryLimitUsed_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("CachePercentProcessMemoryLimitUsed_Base", value);
            }
        }

        public System.UInt32? CacheTotalEntries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheTotalEntries", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheTotalEntries", value);
            }
        }

        public System.UInt32? CacheTotalHitRatio
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheTotalHitRatio", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheTotalHitRatio", value);
            }
        }

        public System.UInt32? CacheTotalHitRatioBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheTotalHitRatio_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheTotalHitRatio_Base", value);
            }
        }

        public System.UInt32? CacheTotalHits
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheTotalHits", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheTotalHits", value);
            }
        }

        public System.UInt32? CacheTotalMisses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheTotalMisses", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheTotalMisses", value);
            }
        }

        public System.UInt32? CacheTotalTrims
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheTotalTrims", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheTotalTrims", value);
            }
        }

        public System.UInt32? CacheTotalTurnoverRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheTotalTurnoverRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheTotalTurnoverRate", value);
            }
        }

        public System.UInt32? CompilationsTotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CompilationsTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompilationsTotal", value);
            }
        }

        public System.UInt32? DebuggingRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DebuggingRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("DebuggingRequests", value);
            }
        }

        public System.UInt32? ErrorEventsRaised
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorEventsRaised", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorEventsRaised", value);
            }
        }

        public System.UInt32? ErrorEventsRaisedPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorEventsRaisedPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorEventsRaisedPerSec", value);
            }
        }

        public System.UInt32? ErrorsDuringCompilation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorsDuringCompilation", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorsDuringCompilation", value);
            }
        }

        public System.UInt32? ErrorsDuringExecution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorsDuringExecution", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorsDuringExecution", value);
            }
        }

        public System.UInt32? ErrorsDuringPreprocessing
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorsDuringPreprocessing", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorsDuringPreprocessing", value);
            }
        }

        public System.UInt32? ErrorsTotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorsTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorsTotal", value);
            }
        }

        public System.UInt32? ErrorsTotalPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorsTotalPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorsTotalPerSec", value);
            }
        }

        public System.UInt32? ErrorsUnhandledDuringExecution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorsUnhandledDuringExecution", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorsUnhandledDuringExecution", value);
            }
        }

        public System.UInt32? ErrorsUnhandledDuringExecutionPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorsUnhandledDuringExecutionPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorsUnhandledDuringExecutionPerSec", value);
            }
        }

        public System.UInt32? EventsRaised
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EventsRaised", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventsRaised", value);
            }
        }

        public System.UInt32? EventsRaisedPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EventsRaisedPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventsRaisedPerSec", value);
            }
        }

        public System.UInt32? FormsAuthenticationFailure
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FormsAuthenticationFailure", out result);
                return result;
            }

            set
            {
                this.SetProperty("FormsAuthenticationFailure", value);
            }
        }

        public System.UInt32? FormsAuthenticationSuccess
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FormsAuthenticationSuccess", out result);
                return result;
            }

            set
            {
                this.SetProperty("FormsAuthenticationSuccess", value);
            }
        }

        public System.UInt32? InfrastructureErrorEventsRaised
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InfrastructureErrorEventsRaised", out result);
                return result;
            }

            set
            {
                this.SetProperty("InfrastructureErrorEventsRaised", value);
            }
        }

        public System.UInt32? InfrastructureErrorEventsRaisedPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InfrastructureErrorEventsRaisedPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InfrastructureErrorEventsRaisedPerSec", value);
            }
        }

        public System.UInt32? ManagedMemoryUsedestimated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ManagedMemoryUsedestimated", out result);
                return result;
            }

            set
            {
                this.SetProperty("ManagedMemoryUsedestimated", value);
            }
        }

        public System.UInt32? MembershipAuthenticationFailure
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MembershipAuthenticationFailure", out result);
                return result;
            }

            set
            {
                this.SetProperty("MembershipAuthenticationFailure", value);
            }
        }

        public System.UInt32? MembershipAuthenticationSuccess
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MembershipAuthenticationSuccess", out result);
                return result;
            }

            set
            {
                this.SetProperty("MembershipAuthenticationSuccess", value);
            }
        }

        public System.UInt32? OutputCacheEntries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutputCacheEntries", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutputCacheEntries", value);
            }
        }

        public System.UInt32? OutputCacheHitRatio
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutputCacheHitRatio", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutputCacheHitRatio", value);
            }
        }

        public System.UInt32? OutputCacheHitRatioBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutputCacheHitRatio_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutputCacheHitRatio_Base", value);
            }
        }

        public System.UInt32? OutputCacheHits
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutputCacheHits", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutputCacheHits", value);
            }
        }

        public System.UInt32? OutputCacheMisses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutputCacheMisses", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutputCacheMisses", value);
            }
        }

        public System.UInt32? OutputCacheTrims
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutputCacheTrims", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutputCacheTrims", value);
            }
        }

        public System.UInt32? OutputCacheTurnoverRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutputCacheTurnoverRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutputCacheTurnoverRate", value);
            }
        }

        public System.UInt32? PercentManagedProcessorTimeestimated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentManagedProcessorTimeestimated", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentManagedProcessorTimeestimated", value);
            }
        }

        public System.UInt32? PercentManagedProcessorTimeestimatedBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentManagedProcessorTimeestimated_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentManagedProcessorTimeestimated_Base", value);
            }
        }

        public System.UInt32? PipelineInstanceCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PipelineInstanceCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("PipelineInstanceCount", value);
            }
        }

        public System.UInt32? RequestBytesInTotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestBytesInTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestBytesInTotal", value);
            }
        }

        public System.UInt32? RequestBytesInTotalWebSockets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestBytesInTotalWebSockets", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestBytesInTotalWebSockets", value);
            }
        }

        public System.UInt32? RequestBytesOutTotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestBytesOutTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestBytesOutTotal", value);
            }
        }

        public System.UInt32? RequestBytesOutTotalWebSockets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestBytesOutTotalWebSockets", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestBytesOutTotalWebSockets", value);
            }
        }

        public System.UInt32? RequestErrorEventsRaised
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestErrorEventsRaised", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestErrorEventsRaised", value);
            }
        }

        public System.UInt32? RequestErrorEventsRaisedPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestErrorEventsRaisedPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestErrorEventsRaisedPerSec", value);
            }
        }

        public System.UInt32? RequestEventsRaised
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestEventsRaised", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestEventsRaised", value);
            }
        }

        public System.UInt32? RequestEventsRaisedPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestEventsRaisedPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestEventsRaisedPerSec", value);
            }
        }

        public System.UInt32? RequestExecutionTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestExecutionTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestExecutionTime", value);
            }
        }

        public System.UInt32? RequestsDisconnected
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsDisconnected", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsDisconnected", value);
            }
        }

        public System.UInt32? RequestsExecuting
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsExecuting", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsExecuting", value);
            }
        }

        public System.UInt32? RequestsExecutingWebSockets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsExecutingWebSockets", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsExecutingWebSockets", value);
            }
        }

        public System.UInt32? RequestsFailed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsFailed", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsFailed", value);
            }
        }

        public System.UInt32? RequestsFailedWebSockets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsFailedWebSockets", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsFailedWebSockets", value);
            }
        }

        public System.UInt32? RequestsInApplicationQueue
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsInApplicationQueue", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsInApplicationQueue", value);
            }
        }

        public System.UInt32? RequestsNotAuthorized
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsNotAuthorized", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsNotAuthorized", value);
            }
        }

        public System.UInt32? RequestsNotFound
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsNotFound", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsNotFound", value);
            }
        }

        public System.UInt32? RequestsPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsPerSec", value);
            }
        }

        public System.UInt32? RequestsRejected
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsRejected", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsRejected", value);
            }
        }

        public System.UInt32? RequestsSucceeded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsSucceeded", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsSucceeded", value);
            }
        }

        public System.UInt32? RequestsSucceededWebSockets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsSucceededWebSockets", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsSucceededWebSockets", value);
            }
        }

        public System.UInt32? RequestsTimedOut
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsTimedOut", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsTimedOut", value);
            }
        }

        public System.UInt32? RequestsTotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsTotal", value);
            }
        }

        public System.UInt32? RequestsTotalWebSockets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsTotalWebSockets", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsTotalWebSockets", value);
            }
        }

        public System.UInt32? RequestWaitTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestWaitTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestWaitTime", value);
            }
        }

        public System.UInt32? SessionsAbandoned
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionsAbandoned", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionsAbandoned", value);
            }
        }

        public System.UInt32? SessionsActive
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionsActive", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionsActive", value);
            }
        }

        public System.UInt32? SessionSQLServerconnectionstotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionSQLServerconnectionstotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionSQLServerconnectionstotal", value);
            }
        }

        public System.UInt32? SessionStateServerconnectionstotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionStateServerconnectionstotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionStateServerconnectionstotal", value);
            }
        }

        public System.UInt32? SessionsTimedOut
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionsTimedOut", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionsTimedOut", value);
            }
        }

        public System.UInt32? SessionsTotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionsTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionsTotal", value);
            }
        }

        public System.UInt32? TransactionsAborted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransactionsAborted", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransactionsAborted", value);
            }
        }

        public System.UInt32? TransactionsCommitted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransactionsCommitted", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransactionsCommitted", value);
            }
        }

        public System.UInt32? TransactionsPending
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransactionsPending", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransactionsPending", value);
            }
        }

        public System.UInt32? TransactionsPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransactionsPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransactionsPerSec", value);
            }
        }

        public System.UInt32? TransactionsTotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransactionsTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransactionsTotal", value);
            }
        }

        public System.UInt32? ViewstateMACValidationFailure
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ViewstateMACValidationFailure", out result);
                return result;
            }

            set
            {
                this.SetProperty("ViewstateMACValidationFailure", value);
            }
        }
    }
}