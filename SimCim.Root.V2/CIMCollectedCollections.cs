using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMCollectedCollections : GenericInfrastructureObject
    {
        protected CIMCollectedCollections()
        {
        }

        protected CIMCollectedCollections(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMCollectionOfMSEs Collection
        {
            get
            {
                CIMCollectionOfMSEs result;
                this.GetInfrastructureObjectProperty("Collection", out result);
                return result;
            }

            set
            {
                this.SetProperty("Collection", value);
            }
        }

        public CIMCollectionOfMSEs CollectionInCollection
        {
            get
            {
                CIMCollectionOfMSEs result;
                this.GetInfrastructureObjectProperty("CollectionInCollection", out result);
                return result;
            }

            set
            {
                this.SetProperty("CollectionInCollection", value);
            }
        }
    }
}