using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ThreadStartTrace : Win32ThreadTrace
    {
        public Win32ThreadStartTrace()
        {
        }

        public Win32ThreadStartTrace(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? StackBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("StackBase", out result);
                return result;
            }
        }

        public System.UInt64? StackLimit
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("StackLimit", out result);
                return result;
            }
        }

        public System.UInt64? StartAddr
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("StartAddr", out result);
                return result;
            }

            set
            {
                this.SetProperty("StartAddr", value);
            }
        }

        public System.UInt64? UserStackBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("UserStackBase", out result);
                return result;
            }
        }

        public System.UInt64? UserStackLimit
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("UserStackLimit", out result);
                return result;
            }
        }

        public System.UInt32? WaitMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WaitMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("WaitMode", value);
            }
        }

        public System.UInt64? Win32StartAddr
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Win32StartAddr", out result);
                return result;
            }

            set
            {
                this.SetProperty("Win32StartAddr", value);
            }
        }
    }
}