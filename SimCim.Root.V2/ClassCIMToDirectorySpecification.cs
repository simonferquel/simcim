using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMToDirectorySpecification : GenericInfrastructureObject
    {
        protected CIMToDirectorySpecification()
        {
        }

        protected CIMToDirectorySpecification(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMDirectorySpecification DestinationDirectory
        {
            get
            {
                CIMDirectorySpecification result;
                this.GetInfrastructureObjectProperty("DestinationDirectory", out result);
                return result;
            }
        }

        public CIMCopyFileAction FileName
        {
            get
            {
                CIMCopyFileAction result;
                this.GetInfrastructureObjectProperty("FileName", out result);
                return result;
            }
        }
    }
}