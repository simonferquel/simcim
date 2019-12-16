using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PageFile : CIMDataFile
    {
        public Win32PageFile()
        {
        }

        public Win32PageFile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? FreeSpace
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FreeSpace", out result);
                return result;
            }
        }

        public System.UInt32? InitialSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InitialSize", out result);
                return result;
            }
        }

        public System.UInt32? MaximumSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumSize", out result);
                return result;
            }
        }
    }
}