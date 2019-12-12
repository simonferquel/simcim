using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmCollectedReferencePoints : CIMCollectedMSEs
    {
        public MsvmCollectedReferencePoints()
        {
        }

        public MsvmCollectedReferencePoints(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmReferencePointCollection Collection
        {
            get
            {
                MsvmReferencePointCollection result;
                this.GetInfrastructureObjectProperty("Collection", out result);
                return result;
            }

            set
            {
                this.SetProperty("Collection", value);
            }
        }

        public new MsvmVirtualSystemReferencePoint Member
        {
            get
            {
                MsvmVirtualSystemReferencePoint result;
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