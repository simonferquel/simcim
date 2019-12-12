using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMStorageDefect : GenericInfrastructureObject
    {
        protected CIMStorageDefect()
        {
        }

        protected CIMStorageDefect(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMStorageError Error
        {
            get
            {
                CIMStorageError result;
                this.GetInfrastructureObjectProperty("Error", out result);
                return result;
            }
        }

        public CIMStorageExtent Extent
        {
            get
            {
                CIMStorageExtent result;
                this.GetInfrastructureObjectProperty("Extent", out result);
                return result;
            }
        }
    }
}