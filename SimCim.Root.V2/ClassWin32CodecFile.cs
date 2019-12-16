using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32CodecFile : CIMDataFile
    {
        public Win32CodecFile()
        {
        }

        public Win32CodecFile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Group
        {
            get
            {
                System.String result;
                this.GetProperty("Group", out result);
                return result;
            }
        }
    }
}