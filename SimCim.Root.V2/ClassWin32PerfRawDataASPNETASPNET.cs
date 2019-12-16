using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataASPNETASPNET : Win32PerfRawData
    {
        public Win32PerfRawDataASPNETASPNET()
        {
        }

        public Win32PerfRawDataASPNETASPNET(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ApplicationRestarts
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ApplicationRestarts", out result);
                return result;
            }

            set
            {
                this.SetProperty("ApplicationRestarts", value);
            }
        }

        public System.UInt32? ApplicationsRunning
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ApplicationsRunning", out result);
                return result;
            }

            set
            {
                this.SetProperty("ApplicationsRunning", value);
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

        public System.UInt32? RequestsCurrent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsCurrent", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsCurrent", value);
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

        public System.UInt32? RequestsInNativeQueue
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsInNativeQueue", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsInNativeQueue", value);
            }
        }

        public System.UInt32? RequestsQueued
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsQueued", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsQueued", value);
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

        public System.UInt32? StateServerSessionsAbandoned
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StateServerSessionsAbandoned", out result);
                return result;
            }

            set
            {
                this.SetProperty("StateServerSessionsAbandoned", value);
            }
        }

        public System.UInt32? StateServerSessionsActive
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StateServerSessionsActive", out result);
                return result;
            }

            set
            {
                this.SetProperty("StateServerSessionsActive", value);
            }
        }

        public System.UInt32? StateServerSessionsTimedOut
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StateServerSessionsTimedOut", out result);
                return result;
            }

            set
            {
                this.SetProperty("StateServerSessionsTimedOut", value);
            }
        }

        public System.UInt32? StateServerSessionsTotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StateServerSessionsTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("StateServerSessionsTotal", value);
            }
        }

        public System.UInt32? WorkerProcessesRunning
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkerProcessesRunning", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkerProcessesRunning", value);
            }
        }

        public System.UInt32? WorkerProcessRestarts
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkerProcessRestarts", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkerProcessRestarts", value);
            }
        }
    }
}