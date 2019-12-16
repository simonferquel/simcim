using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataServiceModel4000ServiceModelService4000 : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataServiceModel4000ServiceModelService4000()
        {
        }

        public Win32PerfFormattedDataServiceModel4000ServiceModelService4000(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Calls
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Calls", out result);
                return result;
            }

            set
            {
                this.SetProperty("Calls", value);
            }
        }

        public System.UInt32? CallsDuration
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CallsDuration", out result);
                return result;
            }

            set
            {
                this.SetProperty("CallsDuration", value);
            }
        }

        public System.UInt32? CallsFailed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CallsFailed", out result);
                return result;
            }

            set
            {
                this.SetProperty("CallsFailed", value);
            }
        }

        public System.UInt32? CallsFailedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CallsFailedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("CallsFailedPerSecond", value);
            }
        }

        public System.UInt32? CallsFaulted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CallsFaulted", out result);
                return result;
            }

            set
            {
                this.SetProperty("CallsFaulted", value);
            }
        }

        public System.UInt32? CallsFaultedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CallsFaultedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("CallsFaultedPerSecond", value);
            }
        }

        public System.UInt32? CallsOutstanding
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CallsOutstanding", out result);
                return result;
            }

            set
            {
                this.SetProperty("CallsOutstanding", value);
            }
        }

        public System.UInt32? CallsPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CallsPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("CallsPerSecond", value);
            }
        }

        public System.UInt32? Instances
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Instances", out result);
                return result;
            }

            set
            {
                this.SetProperty("Instances", value);
            }
        }

        public System.UInt32? InstancesCreatedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InstancesCreatedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("InstancesCreatedPerSecond", value);
            }
        }

        public System.UInt32? PercentOfMaxConcurrentCalls
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentOfMaxConcurrentCalls", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentOfMaxConcurrentCalls", value);
            }
        }

        public System.UInt32? PercentOfMaxConcurrentInstances
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentOfMaxConcurrentInstances", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentOfMaxConcurrentInstances", value);
            }
        }

        public System.UInt32? PercentOfMaxConcurrentSessions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentOfMaxConcurrentSessions", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentOfMaxConcurrentSessions", value);
            }
        }

        public System.UInt32? QueuedMessagesDropped
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QueuedMessagesDropped", out result);
                return result;
            }

            set
            {
                this.SetProperty("QueuedMessagesDropped", value);
            }
        }

        public System.UInt32? QueuedMessagesDroppedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QueuedMessagesDroppedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("QueuedMessagesDroppedPerSecond", value);
            }
        }

        public System.UInt32? QueuedMessagesRejected
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QueuedMessagesRejected", out result);
                return result;
            }

            set
            {
                this.SetProperty("QueuedMessagesRejected", value);
            }
        }

        public System.UInt32? QueuedMessagesRejectedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QueuedMessagesRejectedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("QueuedMessagesRejectedPerSecond", value);
            }
        }

        public System.UInt32? QueuedPoisonMessages
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QueuedPoisonMessages", out result);
                return result;
            }

            set
            {
                this.SetProperty("QueuedPoisonMessages", value);
            }
        }

        public System.UInt32? QueuedPoisonMessagesPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QueuedPoisonMessagesPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("QueuedPoisonMessagesPerSecond", value);
            }
        }

        public System.UInt32? ReliableMessagingMessagesDropped
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReliableMessagingMessagesDropped", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReliableMessagingMessagesDropped", value);
            }
        }

        public System.UInt32? ReliableMessagingMessagesDroppedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReliableMessagingMessagesDroppedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReliableMessagingMessagesDroppedPerSecond", value);
            }
        }

        public System.UInt32? ReliableMessagingSessionsFaulted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReliableMessagingSessionsFaulted", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReliableMessagingSessionsFaulted", value);
            }
        }

        public System.UInt32? ReliableMessagingSessionsFaultedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReliableMessagingSessionsFaultedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReliableMessagingSessionsFaultedPerSecond", value);
            }
        }

        public System.UInt32? SecurityCallsNotAuthorized
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SecurityCallsNotAuthorized", out result);
                return result;
            }

            set
            {
                this.SetProperty("SecurityCallsNotAuthorized", value);
            }
        }

        public System.UInt32? SecurityCallsNotAuthorizedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SecurityCallsNotAuthorizedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("SecurityCallsNotAuthorizedPerSecond", value);
            }
        }

        public System.UInt32? SecurityValidationandAuthenticationFailures
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SecurityValidationandAuthenticationFailures", out result);
                return result;
            }

            set
            {
                this.SetProperty("SecurityValidationandAuthenticationFailures", value);
            }
        }

        public System.UInt32? SecurityValidationandAuthenticationFailuresPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SecurityValidationandAuthenticationFailuresPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("SecurityValidationandAuthenticationFailuresPerSecond", value);
            }
        }

        public System.UInt32? TransactedOperationsAborted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransactedOperationsAborted", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransactedOperationsAborted", value);
            }
        }

        public System.UInt32? TransactedOperationsAbortedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransactedOperationsAbortedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransactedOperationsAbortedPerSecond", value);
            }
        }

        public System.UInt32? TransactedOperationsCommitted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransactedOperationsCommitted", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransactedOperationsCommitted", value);
            }
        }

        public System.UInt32? TransactedOperationsCommittedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransactedOperationsCommittedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransactedOperationsCommittedPerSecond", value);
            }
        }

        public System.UInt32? TransactedOperationsInDoubt
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransactedOperationsInDoubt", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransactedOperationsInDoubt", value);
            }
        }

        public System.UInt32? TransactedOperationsInDoubtPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransactedOperationsInDoubtPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransactedOperationsInDoubtPerSecond", value);
            }
        }

        public System.UInt32? TransactionsFlowed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransactionsFlowed", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransactionsFlowed", value);
            }
        }

        public System.UInt32? TransactionsFlowedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransactionsFlowedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransactionsFlowedPerSecond", value);
            }
        }
    }
}