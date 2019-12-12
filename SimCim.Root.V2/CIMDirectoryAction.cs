using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMDirectoryAction : CIMAction
    {
        protected CIMDirectoryAction()
        {
        }

        protected CIMDirectoryAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DirectoryName
        {
            get
            {
                System.String result;
                this.GetProperty("DirectoryName", out result);
                return result;
            }
        }
    }
}