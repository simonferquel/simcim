using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMCopyFileAction : CIMFileAction
    {
        protected CIMCopyFileAction()
        {
        }

        protected CIMCopyFileAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? DeleteAfterCopy
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DeleteAfterCopy", out result);
                return result;
            }
        }

        public System.String Destination
        {
            get
            {
                System.String result;
                this.GetProperty("Destination", out result);
                return result;
            }
        }

        public System.String Source
        {
            get
            {
                System.String result;
                this.GetProperty("Source", out result);
                return result;
            }
        }
    }
}