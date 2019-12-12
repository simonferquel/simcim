using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMToDirectoryAction : GenericInfrastructureObject
    {
        protected CIMToDirectoryAction()
        {
        }

        protected CIMToDirectoryAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMDirectoryAction DestinationDirectory
        {
            get
            {
                CIMDirectoryAction result;
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