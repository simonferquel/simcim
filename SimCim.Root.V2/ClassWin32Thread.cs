using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Thread : CIMThread
    {
        public Win32Thread()
        {
        }

        public Win32Thread(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? ElapsedTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ElapsedTime", out result);
                return result;
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
        }

        public System.UInt32? StartAddress
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StartAddress", out result);
                return result;
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
        }

        public System.UInt32? ThreadWaitReason
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ThreadWaitReason", out result);
                return result;
            }
        }
    }
}