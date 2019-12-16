using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMCollectionOfMSEs : CIMCollection
    {
        protected CIMCollectionOfMSEs()
        {
        }

        protected CIMCollectionOfMSEs(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CollectionID
        {
            get
            {
                System.String result;
                this.GetProperty("CollectionID", out result);
                return result;
            }

            set
            {
                this.SetProperty("CollectionID", value);
            }
        }
    }
}