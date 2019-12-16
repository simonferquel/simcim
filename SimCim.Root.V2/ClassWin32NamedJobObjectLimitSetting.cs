using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NamedJobObjectLimitSetting : CIMSetting
    {
        public Win32NamedJobObjectLimitSetting()
        {
        }

        public Win32NamedJobObjectLimitSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActiveProcessLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveProcessLimit", out result);
                return result;
            }
        }

        public System.UInt32? Affinity
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Affinity", out result);
                return result;
            }
        }

        public System.UInt32? JobMemoryLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("JobMemoryLimit", out result);
                return result;
            }
        }

        public System.UInt32? LimitFlags
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LimitFlags", out result);
                return result;
            }
        }

        public System.UInt32? MaximumWorkingSetSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumWorkingSetSize", out result);
                return result;
            }
        }

        public System.UInt32? MinimumWorkingSetSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MinimumWorkingSetSize", out result);
                return result;
            }
        }

        public System.UInt64? PerJobUserTimeLimit
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PerJobUserTimeLimit", out result);
                return result;
            }
        }

        public System.UInt64? PerProcessUserTimeLimit
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PerProcessUserTimeLimit", out result);
                return result;
            }
        }

        public System.UInt32? PriorityClass
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PriorityClass", out result);
                return result;
            }
        }

        public System.UInt32? ProcessMemoryLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessMemoryLimit", out result);
                return result;
            }
        }

        public System.UInt32? SchedulingClass
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SchedulingClass", out result);
                return result;
            }
        }
    }
}