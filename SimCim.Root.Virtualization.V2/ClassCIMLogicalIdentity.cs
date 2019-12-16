using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMLogicalIdentity : GenericInfrastructureObject
    {
        protected CIMLogicalIdentity()
        {
        }

        protected CIMLogicalIdentity(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMManagedElement SameElement
        {
            get
            {
                CIMManagedElement result;
                this.GetInfrastructureObjectProperty("SameElement", out result);
                return result;
            }

            set
            {
                this.SetProperty("SameElement", value);
            }
        }

        public CIMManagedElement SystemElement
        {
            get
            {
                CIMManagedElement result;
                this.GetInfrastructureObjectProperty("SystemElement", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemElement", value);
            }
        }
    }
}