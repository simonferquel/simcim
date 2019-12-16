using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ProcessTrace : Win32SystemTrace
    {
        public Win32ProcessTrace()
        {
        }

        public Win32ProcessTrace(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ParentProcessID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ParentProcessID", out result);
                return result;
            }
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

        public System.String ProcessName
        {
            get
            {
                System.String result;
                this.GetProperty("ProcessName", out result);
                return result;
            }
        }

        public System.UInt32? SessionID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionID", out result);
                return result;
            }
        }

        public System.Byte[] Sid
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("Sid", out result);
                return result;
            }
        }
    }
}