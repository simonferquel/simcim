using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataPerfProcThread : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataPerfProcThread()
        {
        }

        public Win32PerfFormattedDataPerfProcThread(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ContextSwitchesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ContextSwitchesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ContextSwitchesPersec", value);
            }
        }

        public System.UInt64? ElapsedTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ElapsedTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("ElapsedTime", value);
            }
        }

        public System.UInt32? IDProcess
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IDProcess", out result);
                return result;
            }

            set
            {
                this.SetProperty("IDProcess", value);
            }
        }

        public System.UInt32? IDThread
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IDThread", out result);
                return result;
            }

            set
            {
                this.SetProperty("IDThread", value);
            }
        }

        public System.UInt64? PercentPrivilegedTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentPrivilegedTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentPrivilegedTime", value);
            }
        }

        public System.UInt64? PercentProcessorTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentProcessorTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentProcessorTime", value);
            }
        }

        public System.UInt64? PercentUserTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentUserTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentUserTime", value);
            }
        }

        public System.UInt32? PriorityBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PriorityBase", out result);
                return result;
            }

            set
            {
                this.SetProperty("PriorityBase", value);
            }
        }

        public System.UInt32? PriorityCurrent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PriorityCurrent", out result);
                return result;
            }

            set
            {
                this.SetProperty("PriorityCurrent", value);
            }
        }

        public System.UInt32? StartAddress
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StartAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("StartAddress", value);
            }
        }

        public System.UInt32? ThreadState
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ThreadState", out result);
                return result;
            }

            set
            {
                this.SetProperty("ThreadState", value);
            }
        }

        public System.UInt32? ThreadWaitReason
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ThreadWaitReason", out result);
                return result;
            }

            set
            {
                this.SetProperty("ThreadWaitReason", value);
            }
        }
    }
}