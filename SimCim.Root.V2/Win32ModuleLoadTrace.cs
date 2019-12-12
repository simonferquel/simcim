using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ModuleLoadTrace : Win32ModuleTrace
    {
        public Win32ModuleLoadTrace()
        {
        }

        public Win32ModuleLoadTrace(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? DefaultBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DefaultBase", out result);
                return result;
            }
        }

        public System.String FileName
        {
            get
            {
                System.String result;
                this.GetProperty("FileName", out result);
                return result;
            }
        }

        public System.UInt64? ImageBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ImageBase", out result);
                return result;
            }
        }

        public System.UInt32? ImageChecksum
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ImageChecksum", out result);
                return result;
            }
        }

        public System.UInt64? ImageSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ImageSize", out result);
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

        public System.UInt32? TimeDateStamp
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TimeDateStamp", out result);
                return result;
            }
        }
    }
}