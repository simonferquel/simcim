using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMRemoveFileAction : CIMFileAction
    {
        protected CIMRemoveFileAction()
        {
        }

        protected CIMRemoveFileAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String File
        {
            get
            {
                System.String result;
                this.GetProperty("File", out result);
                return result;
            }
        }
    }
}