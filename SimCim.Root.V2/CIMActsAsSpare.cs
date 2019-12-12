using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMActsAsSpare : GenericInfrastructureObject
    {
        protected CIMActsAsSpare()
        {
        }

        protected CIMActsAsSpare(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMSpareGroup Group
        {
            get
            {
                CIMSpareGroup result;
                this.GetInfrastructureObjectProperty("Group", out result);
                return result;
            }
        }

        public System.Boolean? HotStandby
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HotStandby", out result);
                return result;
            }
        }

        public CIMManagedSystemElement Spare
        {
            get
            {
                CIMManagedSystemElement result;
                this.GetInfrastructureObjectProperty("Spare", out result);
                return result;
            }
        }
    }
}