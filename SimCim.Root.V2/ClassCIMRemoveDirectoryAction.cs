using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMRemoveDirectoryAction : CIMDirectoryAction
    {
        protected CIMRemoveDirectoryAction()
        {
        }

        protected CIMRemoveDirectoryAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? MustBeEmpty
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MustBeEmpty", out result);
                return result;
            }
        }
    }
}