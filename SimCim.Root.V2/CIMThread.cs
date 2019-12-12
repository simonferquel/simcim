﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMThread : CIMLogicalElement
    {
        protected CIMThread()
        {
        }

        protected CIMThread(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CreationClassName", out result);
                return result;
            }
        }

        public System.String CSCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CSCreationClassName", out result);
                return result;
            }
        }

        public System.String CSName
        {
            get
            {
                System.String result;
                this.GetProperty("CSName", out result);
                return result;
            }
        }

        public System.UInt16? ExecutionState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ExecutionState", out result);
                return result;
            }
        }

        public System.String Handle
        {
            get
            {
                System.String result;
                this.GetProperty("Handle", out result);
                return result;
            }
        }

        public System.UInt64? KernelModeTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("KernelModeTime", out result);
                return result;
            }
        }

        public System.String OSCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("OSCreationClassName", out result);
                return result;
            }
        }

        public System.String OSName
        {
            get
            {
                System.String result;
                this.GetProperty("OSName", out result);
                return result;
            }
        }

        public System.UInt32? Priority
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Priority", out result);
                return result;
            }
        }

        public System.String ProcessCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("ProcessCreationClassName", out result);
                return result;
            }
        }

        public System.String ProcessHandle
        {
            get
            {
                System.String result;
                this.GetProperty("ProcessHandle", out result);
                return result;
            }
        }

        public System.UInt64? UserModeTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("UserModeTime", out result);
                return result;
            }
        }
    }
}