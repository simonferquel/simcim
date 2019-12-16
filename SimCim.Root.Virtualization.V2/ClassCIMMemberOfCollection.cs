using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMMemberOfCollection : GenericInfrastructureObject
    {
        protected CIMMemberOfCollection()
        {
        }

        protected CIMMemberOfCollection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMCollection Collection
        {
            get
            {
                CIMCollection result;
                this.GetInfrastructureObjectProperty("Collection", out result);
                return result;
            }

            set
            {
                this.SetProperty("Collection", value);
            }
        }

        public CIMManagedElement Member
        {
            get
            {
                CIMManagedElement result;
                this.GetInfrastructureObjectProperty("Member", out result);
                return result;
            }

            set
            {
                this.SetProperty("Member", value);
            }
        }
    }
}