using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataUGTHRSVCSearchGatherer : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataUGTHRSVCSearchGatherer()
        {
        }

        public Win32PerfFormattedDataUGTHRSVCSearchGatherer(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActiveQueueLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveQueueLength", value);
            }
        }

        public System.UInt32? AdminClients
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AdminClients", out result);
                return result;
            }

            set
            {
                this.SetProperty("AdminClients", value);
            }
        }

        public System.UInt32? AllNotificationsReceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AllNotificationsReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllNotificationsReceived", value);
            }
        }

        public System.UInt32? DelayedDocuments
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DelayedDocuments", out result);
                return result;
            }

            set
            {
                this.SetProperty("DelayedDocuments", value);
            }
        }

        public System.UInt32? DocumentEntries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentEntries", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentEntries", value);
            }
        }

        public System.UInt32? DocumentsDelayedRetry
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentsDelayedRetry", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentsDelayedRetry", value);
            }
        }

        public System.UInt32? DocumentsFiltered
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentsFiltered", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentsFiltered", value);
            }
        }

        public System.UInt32? DocumentsFilteredRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentsFilteredRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentsFilteredRate", value);
            }
        }

        public System.UInt32? DocumentsSuccessfullyFiltered
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentsSuccessfullyFiltered", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentsSuccessfullyFiltered", value);
            }
        }

        public System.UInt32? DocumentsSuccessfullyFilteredRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentsSuccessfullyFilteredRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentsSuccessfullyFilteredRate", value);
            }
        }

        public System.UInt32? ExtNotificationsRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExtNotificationsRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExtNotificationsRate", value);
            }
        }

        public System.UInt32? ExtNotificationsReceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExtNotificationsReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExtNotificationsReceived", value);
            }
        }

        public System.UInt32? FilteringThreads
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FilteringThreads", out result);
                return result;
            }

            set
            {
                this.SetProperty("FilteringThreads", value);
            }
        }

        public System.UInt32? FilterObjects
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FilterObjects", out result);
                return result;
            }

            set
            {
                this.SetProperty("FilterObjects", value);
            }
        }

        public System.UInt32? FilterProcessCreated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FilterProcessCreated", out result);
                return result;
            }

            set
            {
                this.SetProperty("FilterProcessCreated", value);
            }
        }

        public System.UInt32? FilterProcesses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FilterProcesses", out result);
                return result;
            }

            set
            {
                this.SetProperty("FilterProcesses", value);
            }
        }

        public System.UInt32? FilterProcessesMax
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FilterProcessesMax", out result);
                return result;
            }

            set
            {
                this.SetProperty("FilterProcessesMax", value);
            }
        }

        public System.UInt32? Heartbeats
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Heartbeats", out result);
                return result;
            }

            set
            {
                this.SetProperty("Heartbeats", value);
            }
        }

        public System.UInt32? HeartbeatsRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HeartbeatsRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("HeartbeatsRate", value);
            }
        }

        public System.UInt32? IdleThreads
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IdleThreads", out result);
                return result;
            }

            set
            {
                this.SetProperty("IdleThreads", value);
            }
        }

        public System.UInt32? NotificationSources
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NotificationSources", out result);
                return result;
            }

            set
            {
                this.SetProperty("NotificationSources", value);
            }
        }

        public System.UInt32? NotificationsRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NotificationsRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("NotificationsRate", value);
            }
        }

        public System.UInt32? PerformanceLevel
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PerformanceLevel", out result);
                return result;
            }

            set
            {
                this.SetProperty("PerformanceLevel", value);
            }
        }

        public System.UInt32? Reasontobackoff
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Reasontobackoff", out result);
                return result;
            }

            set
            {
                this.SetProperty("Reasontobackoff", value);
            }
        }

        public System.UInt32? ServerObjects
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ServerObjects", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServerObjects", value);
            }
        }

        public System.UInt32? ServerObjectsCreated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ServerObjectsCreated", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServerObjectsCreated", value);
            }
        }

        public System.UInt32? ServersCurrentlyUnavailable
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ServersCurrentlyUnavailable", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServersCurrentlyUnavailable", value);
            }
        }

        public System.UInt32? ServersUnavailable
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ServersUnavailable", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServersUnavailable", value);
            }
        }

        public System.UInt32? StemmersCached
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StemmersCached", out result);
                return result;
            }

            set
            {
                this.SetProperty("StemmersCached", value);
            }
        }

        public System.UInt32? SystemIOtrafficrate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SystemIOtrafficrate", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemIOtrafficrate", value);
            }
        }

        public System.UInt32? ThreadsAccessingNetwork
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ThreadsAccessingNetwork", out result);
                return result;
            }

            set
            {
                this.SetProperty("ThreadsAccessingNetwork", value);
            }
        }

        public System.UInt32? Threadsblockedduetobackoff
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Threadsblockedduetobackoff", out result);
                return result;
            }

            set
            {
                this.SetProperty("Threadsblockedduetobackoff", value);
            }
        }

        public System.UInt32? ThreadsInPlugins
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ThreadsInPlugins", out result);
                return result;
            }

            set
            {
                this.SetProperty("ThreadsInPlugins", value);
            }
        }

        public System.UInt32? TimeOuts
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TimeOuts", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimeOuts", value);
            }
        }

        public System.UInt32? WordBreakersCached
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WordBreakersCached", out result);
                return result;
            }

            set
            {
                this.SetProperty("WordBreakersCached", value);
            }
        }
    }
}