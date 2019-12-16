using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMDirectorySpecification : CIMCheck
    {
        protected CIMDirectorySpecification()
        {
        }

        protected CIMDirectorySpecification(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DirectoryPath
        {
            get
            {
                System.String result;
                this.GetProperty("DirectoryPath", out result);
                return result;
            }
        }

        public System.UInt16? DirectoryType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DirectoryType", out result);
                return result;
            }
        }
    }
}