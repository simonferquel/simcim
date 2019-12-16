using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ThreadTrace : Win32SystemTrace
    {
        public Win32ThreadTrace()
        {
        }

        public Win32ThreadTrace(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ProcessID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessID", out result);
                return result;
            }
        }

        public System.UInt32? ThreadID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ThreadID", out result);
                return result;
            }
        }
    }
}