using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ProcessStopTrace : Win32ProcessTrace
    {
        public Win32ProcessStopTrace()
        {
        }

        public Win32ProcessStopTrace(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ExitStatus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExitStatus", out result);
                return result;
            }
        }
    }
}