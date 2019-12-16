using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DirectorySpecification : CIMDirectorySpecification
    {
        public Win32DirectorySpecification()
        {
        }

        public Win32DirectorySpecification(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DefaultDir
        {
            get
            {
                System.String result;
                this.GetProperty("DefaultDir", out result);
                return result;
            }
        }

        public System.String Directory
        {
            get
            {
                System.String result;
                this.GetProperty("Directory", out result);
                return result;
            }
        }
    }
}