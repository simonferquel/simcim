using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMRealizesDiskPartition : CIMRealizes
    {
        protected CIMRealizesDiskPartition()
        {
        }

        protected CIMRealizesDiskPartition(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMPhysicalMedia Antecedent
        {
            get
            {
                CIMPhysicalMedia result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMDiskPartition Dependent
        {
            get
            {
                CIMDiskPartition result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }

        public System.UInt64? StartingAddress
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("StartingAddress", out result);
                return result;
            }
        }
    }
}