using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataWorkflowServiceHost4000WorkflowServiceHost4000 : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataWorkflowServiceHost4000WorkflowServiceHost4000()
        {
        }

        public Win32PerfFormattedDataWorkflowServiceHost4000WorkflowServiceHost4000(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AverageWorkflowLoadTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AverageWorkflowLoadTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageWorkflowLoadTime", value);
            }
        }

        public System.UInt32? AverageWorkflowPersistTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AverageWorkflowPersistTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageWorkflowPersistTime", value);
            }
        }

        public System.UInt32? WorkflowsAborted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsAborted", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsAborted", value);
            }
        }

        public System.UInt32? WorkflowsAbortedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsAbortedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsAbortedPerSecond", value);
            }
        }

        public System.UInt32? WorkflowsCompleted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsCompleted", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsCompleted", value);
            }
        }

        public System.UInt32? WorkflowsCompletedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsCompletedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsCompletedPerSecond", value);
            }
        }

        public System.UInt32? WorkflowsCreated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsCreated", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsCreated", value);
            }
        }

        public System.UInt32? WorkflowsCreatedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsCreatedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsCreatedPerSecond", value);
            }
        }

        public System.UInt32? WorkflowsExecuting
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsExecuting", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsExecuting", value);
            }
        }

        public System.UInt32? WorkflowsIdlePerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsIdlePerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsIdlePerSecond", value);
            }
        }

        public System.UInt32? WorkflowsInMemory
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsInMemory", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsInMemory", value);
            }
        }

        public System.UInt32? WorkflowsLoaded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsLoaded", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsLoaded", value);
            }
        }

        public System.UInt32? WorkflowsLoadedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsLoadedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsLoadedPerSecond", value);
            }
        }

        public System.UInt32? WorkflowsPersisted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsPersisted", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsPersisted", value);
            }
        }

        public System.UInt32? WorkflowsPersistedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsPersistedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsPersistedPerSecond", value);
            }
        }

        public System.UInt32? WorkflowsSuspended
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsSuspended", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsSuspended", value);
            }
        }

        public System.UInt32? WorkflowsSuspendedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsSuspendedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsSuspendedPerSecond", value);
            }
        }

        public System.UInt32? WorkflowsTerminated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsTerminated", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsTerminated", value);
            }
        }

        public System.UInt32? WorkflowsTerminatedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsTerminatedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsTerminatedPerSecond", value);
            }
        }

        public System.UInt32? WorkflowsUnloaded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsUnloaded", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsUnloaded", value);
            }
        }

        public System.UInt32? WorkflowsUnloadedPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsUnloadedPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsUnloadedPerSecond", value);
            }
        }
    }
}