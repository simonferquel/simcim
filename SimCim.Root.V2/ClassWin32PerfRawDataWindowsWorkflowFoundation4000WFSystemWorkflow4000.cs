using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataWindowsWorkflowFoundation4000WFSystemWorkflow4000 : Win32PerfRawData
    {
        public Win32PerfRawDataWindowsWorkflowFoundation4000WFSystemWorkflow4000()
        {
        }

        public Win32PerfRawDataWindowsWorkflowFoundation4000WFSystemWorkflow4000(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.UInt32? WorkflowsAbortedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsAbortedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsAbortedPersec", value);
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

        public System.UInt32? WorkflowsCompletedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsCompletedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsCompletedPersec", value);
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

        public System.UInt32? WorkflowsCreatedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsCreatedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsCreatedPersec", value);
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

        public System.UInt32? WorkflowsIdlePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsIdlePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsIdlePersec", value);
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

        public System.UInt32? WorkflowsLoadedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsLoadedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsLoadedPersec", value);
            }
        }

        public System.UInt32? WorkflowsPending
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsPending", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsPending", value);
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

        public System.UInt32? WorkflowsPersistedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsPersistedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsPersistedPersec", value);
            }
        }

        public System.UInt32? WorkflowsRunnable
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsRunnable", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsRunnable", value);
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

        public System.UInt32? WorkflowsSuspendedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsSuspendedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsSuspendedPersec", value);
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

        public System.UInt32? WorkflowsTerminatedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsTerminatedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsTerminatedPersec", value);
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

        public System.UInt32? WorkflowsUnloadedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowsUnloadedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowsUnloadedPersec", value);
            }
        }
    }
}